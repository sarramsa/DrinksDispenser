using DrinksDispenser.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DrinksDispenserTests
{
    [TestClass]
    public class DrinksDispenserViewModelTest
    {
        [TestMethod]
        public void TeaDrinkTest()
        {
            IDrinksDispenserBusinessLayer businessLayer = new DrinksDispenserBusinessLayer();
            DrinksDispenserViewModel model = new DrinksDispenserViewModel(businessLayer);
            Drink tea = model.Drinks.FirstOrDefault(x => x.Name == "The");
            Assert.IsNotNull(tea);
            Assert.AreEqual(3.12, tea.Price);
        }
        [TestMethod]
        public void NoDrinksTest()
        {
            Mock<IDrinksDispenserBusinessLayer> businessLayer = new Mock<IDrinksDispenserBusinessLayer>();
            businessLayer.Setup(x => x.GetListDrinksWithPrices()).Returns(default(List<Drink>));
            DrinksDispenserViewModel model = new DrinksDispenserViewModel(businessLayer.Object);

            Assert.IsNull(model.Drinks);
            Assert.AreEqual("Aucune boisson disponible.", model.Message);
        }

    }
}
