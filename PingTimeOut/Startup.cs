using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PingTimeOut.Infrastructure.Extensions;
using PingTimeOut.Infrastructure.Settings.Implementations;
using PingTimeOut.Infrastructure.Settings.Interfaces;
using SimpleLibraryPlugin.Controllers;

namespace PingTimeOut
{
	public class Startup
	{
		private readonly IAppSettings _appSettings;
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
			_appSettings = GetAppSettings();
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			var assembly = Assembly.GetAssembly(typeof(SimpleController));
			// Controllers
			services
				.AddControllers()
				.AddApplicationPart(assembly)
				.AddControllersAsServices();

			// Services
			services.ConfigureServices();

			// Swagger
			services.ConfigureSwagger(Configuration);

			// Application Settings
			services.AddSingleton<IAppSettings>((sp) => _appSettings);
		}

		public IAppSettings GetAppSettings()
		{
			var settings = new AppSettings();
			var section = Configuration.GetSection("AppSettings");
			section.Bind(settings);

			return settings;
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseSwagger();
			app.UseSwaggerUI(c =>
			{
				c.SwaggerEndpoint("/swagger/v2/swagger.json", "Tools API v2");
				c.SwaggerEndpoint("/swagger/v1/swagger.json", "Tools API v1");
				c.RoutePrefix = string.Empty;
			});

			//app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
