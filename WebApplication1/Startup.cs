using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http.Extensions;

namespace WebApplication1
{
	public class Startup
	{
		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app)
		{
			app.Run(context =>
			{
				if (context.Request.GetDisplayUrl().EndsWith("redirect.html"))
				{
					context.Response.StatusCode = 200;
					return Task.CompletedTask;
				}

				context.Response.Redirect("/redirect.html");

				return Task.CompletedTask;
			});
		}
	}
}
