using BlazingPizza.Shared;

namespace BlazingPizza.Server.Models
{
	public static class SeedData
	{
		public static void Initialize(PizzaStoreContext context)
		{
			var Specials = new PizzaSpecial[]
			{
				new PizzaSpecial{ Name = "Pizza clasica de queso", Description = "Es de queso y delicioza, Porque no querrias una?", BasePrice = 189.99m, ImageUrl = "images/pizzas/cheese.jpg" },
				new PizzaSpecial{ Name = "Tocinator", Description = "Tiene TODO tipo de tocino", BasePrice = 227.99m, ImageUrl = "images/pizzas/bacon.jpg" },
				new PizzaSpecial{ Name = "Hawaina", Description = "De piña, jamon y queso", BasePrice = 190.25m, ImageUrl = "images/pizzas/hawaiian.jpg" },
				new PizzaSpecial{ Name = "Delicia vegetariana", Description = "Es como una enzalada pero es una pizza", BasePrice = 218.50m, ImageUrl = "images/pizzas/salad.jpg" },
				new PizzaSpecial{ Name = "Margarita", Description = "Pizza Italiana tradicional con tomates y albaca", BasePrice = 189.99m, ImageUrl = "images/pizzas/margarita.jpg" }
			};

			context.Specials.AddRange(Specials);
			context.SaveChanges();
		}
	}
}
