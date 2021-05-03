using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DrinksDispenser.Models
{
    public class Drink
    {   
        public int Id { get; set; }
        public string Name { get; set; }

        // Recipe: Id product and amount of product
        public Dictionary<int,int> Recipe { get; set; }
        
        public Double Price { get; set; }

    }
}