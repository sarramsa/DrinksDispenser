using System;
using System.Collections.Generic;
using System.Linq;

namespace DrinksDispenser.Models
{
    public class DrinksDispenserBusinessLayer : IDrinksDispenserBusinessLayer
    {
        private const double MARGIN = 0.3;

        /// <summary>
        /// Gets drinks details with calculate prices
        /// </summary>
        /// <returns></returns>
        public List<Drink> GetListDrinksWithPrices()
        {
            try
            {
                List<Drink> drinks = GetDrinksList();
                List<Product> products = GetListProduct();

                if (products == null)
                    throw new ArgumentNullException("products","Aucun produit disponible.");
                foreach (Drink d in drinks)
                {
                    double price = 0;
                    foreach (var item in d.Recipe)
                    {

                        Product product = products.FirstOrDefault(x => x.Id == item.Key);
                        if (product != null)
                            price = price + (product.price * item.Value);
                    }
                    //30% Margin
                    d.Price = Math.Round(price + (price * MARGIN), 2);
                }
                return drinks;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Drink> GetDrinksList()
        {
            return new List<Drink>()
            { new Drink() { Id=1, Name = "Expresso", Recipe = new Dictionary<int, int>() { { 1, 1 }, { 5 , 1 } } },
            new Drink() { Id=2, Name = "Allongé", Recipe = new Dictionary<int, int>() { { 1 , 1 }, { 5 , 2 } } },
            new Drink() { Id=3, Name = "Capuccino", Recipe = new Dictionary<int, int>() { { 1 , 1 }, { 6 , 1 }, { 5, 1 }, { 3 , 1 } } },
            new Drink() { Id=4, Name = "Chocolat", Recipe = new Dictionary<int, int>() { { 6 , 3 }, { 7 , 2 }, { 5 , 1 }, { 2 , 1 } } },
            new Drink() { Id=5, Name = "The", Recipe = new Dictionary<int, int>() { { 4 , 1 }, { 5 , 2 } } }
            };


        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Product> GetListProduct()
        {
            return new List<Product>(){
             new Product(){Id=1, Name="coffee",price=1},
             new Product(){Id=2, Name="sugar",price=0.1},
             new Product(){Id=3, Name="cream",price=0.5},
             new Product(){Id=4, Name="tea",price=2},
             new Product(){Id=5, Name="water",price=0.2},
             new Product(){Id=6, Name="chocolate",price=1},
             new Product(){Id=7, Name="milk",price=0.4}

            };

        }

    }
}