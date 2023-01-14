using DigitalCloudTechnologies.Data;
using DigitalCloudTechnologies.Services;
using DigitalCloudTechnologies.Services.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MudBlazor.Services;

namespace DigitalCloudTechnologies
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddRazorPages();
			builder.Services.AddServerSideBlazor();
			builder.Services.AddSingleton<WeatherForecastService>();
			builder.Services.AddHttpClient();
			builder.Services.AddMudServices();
			builder.Services.AddScoped<ICryptoSevice, CryptoSevice>();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Error");
			}

			app.UseStaticFiles();

			app.UseRouting();

			app.MapBlazorHub();
			app.MapFallbackToPage("/_Host");

			app.Run();
		}
	}
}