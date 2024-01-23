using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertTracker
{
    public class ConcertData
    {
        //getters and setters for variables I want from api data
        private string id;
        private string eventName;
        private string date;
        private string venue;
        private string state;
        private double minPrice;
        private double maxPrice;
        private string url;

        public string Id { get => id; set => id = value; }
        public string EventName { get => eventName; set => eventName = value; }
        public string Date { get => date; set => date = value; }
        public string Venue { get => venue; set => venue = value; }
        public string State { get => state; set => state = value; }
        public double MinPrice { get => minPrice; set => minPrice = value; }
        public double MaxPrice { get => maxPrice; set => maxPrice = value; }
        public string Url { get => url; set => url = value; }
    }

}
