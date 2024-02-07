namespace DocumantationApp.Models
{
    public class DrinkModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Volume { get; set; }
        public int CaffeineContent { get; set; }
        public int Calories { get; set; }
    }

    // Define similar models for Dessert and Sandwich
}
