using DistributeurBoissons.Controllers;
using DistributeurBoissons.Services;

namespace TestDrinks
{
    [TestClass]
    public class Test
    {
        private IDrinkService _drinkService;

        public Test()
        {
            _drinkService = new DrinkService();
        }
        [TestMethod]
        public void GetPrice_ReturnsSellingPrice_WhenDrinkExists()
        {
            // Arrange
            var controller = new DrinkController(_drinkService);

            // Act
            var result = controller.GetPrice("Expresso");

            // Assert
            Assert.AreEqual(1.56m, result.Value);
        }

    }

}