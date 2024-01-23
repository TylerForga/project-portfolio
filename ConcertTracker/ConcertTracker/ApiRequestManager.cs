using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

/*
* Ticketmaster event search api does not support searching for multiple keywords. To support searching for concerts based on each
* of the GUI entry boxes, I will have to make multiple requests to their Venue Search, Classification Search and Event Search APIs.
* Event Search supports parameters of venueId, genreId, stateCode and keyword. Keyword parameter will be dedicated to the artists
* name.
* TODO- 1) Consider adding logic to BuildApiUrl to minimize total number of elements in a page from api response. Must include query 
        parameters of size="" and page="" to apiUrl variable in BuildApiUrl method. It takes a few seconds to populate the data in 
        the viewConcerts form, so making multiple api requests with smaller number of elements per page but multiple api requests 
        could decrease that time.
        2) Consider using geopoint of user's location for a default location. Currently, GetVenueId method obtains the first array 
        element's id which could be out of their state or not even the venue that they are looking for. 
        
*/
namespace ConcertTracker
{
     
    public class ApiRequestManager
    {
        private readonly HttpClient httpClient;

        public ApiRequestManager()
        {
            this.httpClient = new HttpClient();
        }

        public async Task<List<ConcertData>> MakeApiRequest(Dictionary<string, string> userValues)
        {
            List<ConcertData> events = new List<ConcertData>();
            string apiUrl = await BuildApiURL(userValues);

            //make GET resquest to Ticketmaster API
            HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
            if (response.IsSuccessStatusCode)
            {
                //if response is successful, seralize data and parse it to JSON Object
                string responseData = await response.Content.ReadAsStringAsync();
                JObject apiResponse = JObject.Parse(responseData);

                //get size of number of elements on page. max number of concerts I want is 100
                int numberOfElements = (int)apiResponse["page"]?["totalElements"];
                if (numberOfElements > 100)
                {
                    numberOfElements = 100;
                }

                for (int i = 0; i < numberOfElements; i++)
                {
                    //create object of concertdata class and add api data to it
                    ConcertData eventData = new ConcertData();
                    eventData.Id = apiResponse["_embedded"]?["events"]?[i]?["id"]?.ToString();
                    eventData.EventName = apiResponse["_embedded"]?["events"]?[i]?["name"]?.ToString();
                    eventData.Date = apiResponse["_embedded"]?["events"]?[i]?["dates"]?["start"]?["localDate"]?.ToString();
                    eventData.Venue = apiResponse["_embedded"]?["events"]?[i]?["_embedded"]?["venues"][0]?["name"]?.ToString();
                    eventData.State = apiResponse["_embedded"]?["events"]?[i]?["_embedded"]?["venues"][0]?["state"]?["stateCode"]?.ToString();
                    eventData.MinPrice = (double)(apiResponse["_embedded"]?["events"]?[i]?["priceRanges"]?[0]?["min"] ?? 0.0);
                    eventData.MaxPrice = (double)(apiResponse["_embedded"]?["events"]?[i]?["priceRanges"]?[0]?["max"] ?? 0.0);
                    eventData.Url = apiResponse["_embedded"]?["events"]?[i]?["url"]?.ToString();

                    //only add the events to list that have a venue and url to list
                    if (eventData.Venue != null && eventData.Url != null && eventData.State != null)
                    {
                        events.Add(eventData);
                    }
                    
                }
            }

            return events;
        }
        private async Task<string> BuildApiURL(Dictionary<string, string> userValues)
        {
            string apiUrl = "https://app.ticketmaster.com/discovery/v2/events.json?apikey=9JlGJuAewBcYCqqsoiMLVmHwF9yYgERZ";


            //conditional statements to check if GUI entered values are in the dictionary
            //these conditional statements will build the apiURL with parameters based on user values
            if (userValues.ContainsKey("venue") && !userValues.ContainsKey("stateCode"))
            {
                //get user entered venue value from dictionary and pass it to GetVenueID to obtain venue ID from Ticketmaster API
                string venue = userValues["venue"];
                string venueId = await GetVenueId(venue);
                //if not null, concatentate apiURL with venue query parameter and value
                if (venueId != null)
                    apiUrl += $"&venueId={venueId}";
            }
            if (userValues.ContainsKey("venue") && userValues.ContainsKey("stateCode"))
            {
                //get user entered venue & state value from dictionary and pass it to GetVenueID to obtain venue ID from Ticketmaster API
                string venue = userValues["venue"];
                string stateCode = userValues["stateCode"];
                string venueId = await GetVenueId(venue, stateCode);
                //if not null, concatentate apiURL with venue query parameter and value
                if (venueId != null)
                    apiUrl += $"&venueId={venueId}&stateCode={stateCode}";
            }
            if (userValues.ContainsKey("genre"))
            {
                //get user entered genre value from dictionary and pass it to GetGenre to obtain genre ID from Ticketmaster API
                string genre = userValues["genre"];
                string genreId = await GetGenreId(genre);
                //if not null, concatentate apiURL with genre query parameter and value
                if (genreId != null)
                    apiUrl += $"&genreId={genreId}";
            }
            if (userValues.ContainsKey("stateCode"))
            {
                //if user selected a statecode from form, concatentate apiUrl with query paramater and stateCode value
                string stateCode = userValues["stateCode"];
                apiUrl += $"&stateCode={stateCode}";
            }
            if (userValues.ContainsKey("artist"))
            {
                //if user entered a artist or event name in form, sanitize the input and concatentate apiUrl with query parameter and value
                string artist = userValues["artist"];
                string sanitizedArtist = WebUtility.UrlEncode(artist);
                apiUrl += $"&keyword={sanitizedArtist}";
            }

            //make api request to obtain the total elements of api and add it to api url
            HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
            if (response.IsSuccessStatusCode)
            {
                //if response is successful, seralize data and parse it to JSON Object
                string responseData = await response.Content.ReadAsStringAsync();
                JObject apiResponse = JObject.Parse(responseData);

                //get totalelements of api response
                int numberOfElements = (int)apiResponse["page"]?["totalElements"];
                //currently only want to get data from a max of 100 objects from api response
                if (numberOfElements > 100)
                {
                    apiUrl += $"&size=100";
                }
                else
                {
                    apiUrl += $"&size={numberOfElements}";
                }
            }

            return apiUrl;
        }
        
        private async Task<string> GetVenueId(string userVenue)
        {
            string venueKeyword = userVenue;
            string sanitizedVenue = WebUtility.UrlEncode(venueKeyword);
            string venueID = null;
            string apiURL = $"https://app.ticketmaster.com/discovery/v2/venues.json?apikey=9JlGJuAewBcYCqqsoiMLVmHwF9yYgERZ&keyword={sanitizedVenue}";

            //make GET resquest to Ticketmaster API
            HttpResponseMessage response = await httpClient.GetAsync(apiURL);

            if (response.IsSuccessStatusCode)
            {
                //if response is successful, serialize data and parse it to JSON Object
                string responseData = await response.Content.ReadAsStringAsync();
                JObject apiResponse = JObject.Parse(responseData);

                //check if venue exists in api
                if (apiResponse["_embedded"]?["venues"] != null)
                {
                    //get ID of first venue-----TODO make sure this works for most venues
                    var venue = apiResponse["_embedded"]["venues"]?[0];
                    venueID = venue?["id"]?.ToString();
                }
            }

            return venueID;
        }

        //overloaded GetVenueID method allowing user to enter in a more precise location for venue
        //TODO- considering using geoPoint query parameter instead of state
        private async Task<string> GetVenueId(string userVenue, string userStateCode)
        {
            string venueKeyword = userVenue;
            string sanitizedVenue = WebUtility.UrlEncode(venueKeyword);
            string venueState = userStateCode; 
            string venueID = null;
            string apiURL = $"https://app.ticketmaster.com/discovery/v2/venues.json?apikey=9JlGJuAewBcYCqqsoiMLVmHwF9yYgERZ&keyword={sanitizedVenue}&stateCode={venueState}";

            //make GET resquest to Ticketmaster API
            HttpResponseMessage response = await httpClient.GetAsync(apiURL);

            if (response.IsSuccessStatusCode)
            {
                //if response is successful, seralize data and parse it to JSON Object
                string responseData = await response.Content.ReadAsStringAsync();
                JObject apiResponse = JObject.Parse(responseData);

                //check if venue exists in api
                if (apiResponse["_embedded"]?["venues"] != null)
                {
                    //this will obtain the first venue id. user's will have to select a statecode if there's multiple of the same venue name
                    var venue = apiResponse["_embedded"]?["venues"]?[0];
                    venueID = venue?["id"]?.ToString();
                    
                }
            }
            
            return venueID;
        }

        private async Task<string> GetGenreId(string userGenre)
        {
            string genreKeyword = userGenre;
            string genreId = null;
            string apiURL = $"https://app.ticketmaster.com/discovery/v2/classifications.json?apikey=9JlGJuAewBcYCqqsoiMLVmHwF9yYgERZ&keyword={genreKeyword}";
            
            //make GET resquest to Ticketmaster API
            HttpResponseMessage response = await httpClient.GetAsync(apiURL);

            if (response.IsSuccessStatusCode)
            {
                //if response is successful, serialize data and parse it to JSON Object
                string responseData = await response.Content.ReadAsStringAsync();
                JObject apiResponse = JObject.Parse(responseData);

                
                //get number of elements in array to loop over
               
                int numberOfElements = (int)apiResponse["page"]?["totalElements"];
                int numberOfEvents = (int)apiResponse["page"]?["size"];

                int genreElements = 0;
                //only 20 a page, the response from keyword search for genre in classification api wont return over 1page
                if (numberOfElements < 20)
                {
                    for (int i = 0; i < numberOfElements; i++)
                    {
                        //loop through classifications array
                        var musicSegment = apiResponse["_embedded"]?["classifications"]?[i];
                        //find the segment array in classifications array that has a name of music
                        if (musicSegment?["segment"]?["name"]?.ToString() == "Music")
                        {
                            //loop through music segment array
                            while (genreId == null)
                            {
                                var genre = musicSegment["segment"]["_embedded"]?["genres"]?[genreElements];
                                //find the genre that has a name the same as the genrekeyword
                                if (genre?["name"]?.ToString() == genreKeyword)
                                {
                                    //set genreId with genreID from API if not null
                                    genreId = genre["id"]?.ToString();
                                    break;
                                }
                                if (genre == null)
                                {
                                    //break out of while loop if element in genrearray is null or doesnt exist
                                    break;
                                }
                                genreElements++;
                                    
                            }
                            if (genreId != null)
                            {
                                //genreId is obtained, break out of the outer for loop
                                break;
                            }
                        }    
                    }
                }else
                {
                    //if api changes and response does return a size over 20, just use the default size of the page (which is 20)
                    //TODO-- music genre has been at the beginning of classifications array. If this changes, implementation of 
                    //      making multiple api requests with page query parameter will be required (refer to top of class in
                    //      TODOs for more information)
                    for (int i = 0; i < numberOfEvents; i++)
                    {
                        //loop through classifications array
                        var musicSegment = apiResponse["_embedded"]?["classifications"]?[i];
                        //find the segment array in classifications array that has a name of music
                        if (musicSegment?["segment"]?["name"]?.ToString() == "Music")
                        {
                            //loop through music segment array
                            while (genreId == null)
                            {
                                var genre = musicSegment["segment"]["_embedded"]?["genres"]?[genreElements];
                                //find the genre that has a name the same as the genrekeyword
                                if (genre?["name"]?.ToString() == genreKeyword)
                                {
                                    //set genreId with genreID from API if not null
                                    genreId = genre["id"]?.ToString();
                                    break;
                                }
                                if (genre == null)
                                {
                                    //break out of while loop if element in genrearray is null or doesnt exist
                                    break;
                                }
                                genreElements++;

                            }
                            if (genreId != null)
                            {
                                //genreId is obtained, break out of the outer for loop
                                break;
                            }
                        }
                    }
                }
            }
            //return id
            return genreId;
        }




    }
}
