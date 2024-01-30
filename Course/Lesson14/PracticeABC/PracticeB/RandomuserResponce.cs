using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeB
{
    public class RandomuserResponce
    {
        public List<Results> results { get; set; }
    }

    public class Results
    {   
        public string gender { get; set; }
        public Name name { get; set; }

        
    }
    public class Name
    {
        public string title { get; set; }
        public string first { get; set; }
    }
}