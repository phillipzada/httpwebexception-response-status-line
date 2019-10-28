using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace WebApplication1
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var host = new WebHostBuilder()
				.UseWebListener()
				.UseContentRoot(Directory.GetCurrentDirectory())
				.UseUrls("http://127.0.0.1:5000")
				.UseStartup<Startup>()
				.Build();

			host.Run();
		}
	}
}
