using DistributeurBoissons.Models;

namespace DistributeurBoissons.Services
{
    public class DrinkService : IDrinkService
    {
        private readonly List<Recipe> _recipes;

        public DrinkService()
        {
   
            _recipes = new List<Recipe>
        {
            new Recipe
            {
                Name = "Expresso",
                Ingredients = new List<Product>
                {
                    new Product { Name = "Café", CostPrice = 1.0m },
                    new Product { Name = "Eau", CostPrice = 0.2m }
                }
            },
             new Recipe
            {
                Name = "Allongé",
                Ingredients = new List<Product>
                {
                    new Product { Name = "Café", CostPrice =1.0m },
                    new Product { Name = "Eau", CostPrice = 0.2m },
                    new Product { Name = "Eau", CostPrice = 0.2m }
                }
            },
            new Recipe
            {
                Name = "Cappuccino",
                Ingredients = new List<Product>
                {
                    new Product { Name = "Café", CostPrice = 1.0m },
                    new Product { Name = "Chocolat", CostPrice = 1.0m },
                    new Product { Name = "Eau", CostPrice = 0.2m }
                }
            },
            new Recipe
            {
                Name = "Chocolat",
                Ingredients = new List<Product>
                {
                    new Product { Name = "Crème", CostPrice = 0.5m },
                    new Product { Name = "Lait", CostPrice = 0.4m },
                    new Product { Name = "Eau", CostPrice = 0.2m },
                    new Product { Name = "Sucre", CostPrice = 0.1m }
                }
            }
        };
        }

        public IEnumerable<Recipe> GetRecipes()
        {
            return _recipes;
        }

        public decimal GetPrice(string name)
        {
            var recipe = _recipes.FirstOrDefault(r => r.Name == name);
            if (recipe == null)
            {
                throw new InvalidOperationException("Recipe not found");
            }

            decimal totalPrice = recipe.Ingredients.Sum(i => i.CostPrice);
            decimal sellingPrice = totalPrice * 1.3m; 

            return sellingPrice;
        }
    }
}
