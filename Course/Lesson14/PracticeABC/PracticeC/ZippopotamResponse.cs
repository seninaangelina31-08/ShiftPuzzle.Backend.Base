using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeC
{
    public class ZippopotamResponse
    {
        public string post_code { get; set; }
        public string country { get; set; }
        public string country_abbreviation { get; set; }
        public List<Place> places { get; set; }
    }

    public class Place
    {
        public string place_name { get; set; }
        public string longitude { get; set; }
        public string state { get; set; }
        public string state_abbreviation { get; set; }
        public string latitude { get; set; }
    }
}