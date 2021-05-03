using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DrinksDispenser.Models
{
    public class DrinksDispenserViewModel
    {

        public List<Drink> Drinks { get; set; }



        public string Message { get; set; }

        public DrinksDispenserViewModel(IDrinksDispenserBusinessLayer businessLayer)
        {
            Drinks = businessLayer.GetListDrinksWithPrices();
            if (Drinks == null || Drinks.Count == 0)
                Message = "Aucune boisson disponible.";

        }





    }
}