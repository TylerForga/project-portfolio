using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertTracker
{
    public class ApiRequestDto
    {
        //getters and setters for variables from user input from form
        private string artist;
        private string venue;
        private string state;
        private string genre;

        public string Artist { get => artist; set => artist = value; }
        public string Venue { get => venue; set => venue = value; }
        public string State { get => state; set => state = value; }
        public string Genre { get => genre; set => genre = value; }

        public Dictionary<string, string> GetNonNullValues()
        {
            //declare a dictionary to add all non null values from dto and return it
            var nonNullValues = new Dictionary<string, string>();

            if (Artist != null)
                nonNullValues.Add("artist", Artist);
            if (Venue != null)
                nonNullValues.Add("venue", Venue);
            if (State != null)
                nonNullValues.Add("stateCode", State);
            if (Genre != null)
                nonNullValues.Add("genre", Genre);

            return nonNullValues;
        }
    }
}
