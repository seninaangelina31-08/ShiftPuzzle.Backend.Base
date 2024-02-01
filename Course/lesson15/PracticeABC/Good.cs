using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeABC
{
    public class Good
    {
        public required string Name { get; set; }
        public float Price { get; set; }
        public bool IsAvailable { get; set; }

        public Good(string name, float price, bool isAvailable)
        {
            this.Name = name;
            this.Price = price;
            this.IsAvailable = isAvailable;
        }
    }
}