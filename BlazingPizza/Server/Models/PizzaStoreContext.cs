using BlazingPizza.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Server.Models
{
	public class PizzaStoreContext : DbContext
	{
		public PizzaStoreContext(DbContextOptions<PizzaStoreContext> options) : base(options) { }
		public DbSet<PizzaSpecial> Specials { get; set; }
	}
}
