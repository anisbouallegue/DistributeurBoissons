namespace DistributeurBoissons.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Ingredients { get; set; }
        public decimal Price { get; set; }
    }
}
