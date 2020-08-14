using BlazingPizza.Server.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Linq;

namespace BlazingPizza.Server
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var host = CreateHostBuilder(args).Build();

			//Obetener el DBContext
			var scopeFactory = host.Services.GetRequiredService<IServiceScopeFactory>();
			using (var Scope = scopeFactory.CreateScope())
			{
				var Context = Scope.ServiceProvider.GetRequiredService<PizzaStoreContext>();
				if (Context.Specials.Count() == 0)
				{
					SeedData.Initialize(Context);
				}
			}
			host.Run();
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseStartup<Startup>();
				});
	}
}
