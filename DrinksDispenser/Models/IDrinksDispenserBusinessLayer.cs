using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DrinksDispenser.Models
{
    public interface IDrinksDispenserBusinessLayer
    {

        List<Drink> GetListDrinksWithPrices();
        List<Product> GetListProduct();
    }
}