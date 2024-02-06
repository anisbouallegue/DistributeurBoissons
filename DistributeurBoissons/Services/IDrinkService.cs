using DistributeurBoissons.Models;

namespace DistributeurBoissons.Services
{
    public interface IDrinkService
    {
        IEnumerable<Recipe> GetRecipes();
        decimal GetPrice(string name);
    }
}
