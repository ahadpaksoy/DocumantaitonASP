using DocumantationApp.Models;

namespace DocumantationApp.Data
{
    public static class MenuData
    {
        public static List<DrinkModel> GetDrinksMenu()
        {
            return new List<DrinkModel>
            {
                new DrinkModel { Name = "Iced Coffee", Description = "Refreshing iced coffee", Price = 3.50m, Volume = "16 oz", CaffeineContent = 100, Calories = 150 },
                new DrinkModel { Name = "Latte", Description = "Creamy latte", Price = 4.00m, Volume = "12 oz", CaffeineContent = 80, Calories = 200 },
                // Add more drinks here
            };
        }

        public static List<SandwichModel> GetSandwichesMenu()
        {
            return new List<SandwichModel>
            {
                new SandwichModel { Name = "Turkey Sandwich", Description = "Classic turkey sandwich", Ingredients = "Turkey, lettuce, tomato, mayo", Calories = 300, Price = 7.50m },
                new SandwichModel { Name = "BLT", Description = "Bacon, lettuce, and tomato sandwich", Ingredients = "Bacon, lettuce, tomato, mayo", Calories = 400, Price = 8.00m },
                // Add more sandwiches here
            };
        }

        public static List<DessertModel> GetDessertsMenu()
        {
            return new List<DessertModel>
            {
                new DessertModel { Name = "Chocolate Cake", Description = "Rich chocolate cake", Ingredients = "Chocolate, flour, sugar, eggs", Price = 5.00m, Calories = 500 },
                new DessertModel { Name = "Cheesecake", Description = "Creamy cheesecake", Ingredients = "Cream cheese, sugar, eggs, graham cracker crust", Price = 6.00m, Calories = 600 },
                // Add more desserts here
            };
        }
    }
}
