using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.IO;
using System.Reflection;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using PingTimeOut.Services.Interfaces;
using PingTimeOut.Services.Implementations;

namespace PingTimeOut.Infrastructure.Extensions
{
	/// <summary>Расширения для коллекций сервисов</summary>
	[ExcludeFromCodeCoverage]
	public static class ServiceCollectionExtension
	{
		/// <summary>Конфигурация swagger'а</summary>
		public static void ConfigureSwagger(this IServiceCollection services,
			IConfiguration configuration)
		{
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo
				{
					Version = "v1",
					Title = "Tools API",
					Description = "Tools for deveopment",
				});
				c.SwaggerDoc("v2", new OpenApiInfo
				{
					Version = "v2",
					Title = "Tools API",
					Description = "Tools for deveopment",
				});
				// Указываем файл из которого брать комментарии для Swagger UI
				var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
				var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
				c.IncludeXmlComments(xmlPath, true);
				c.OrderActionsBy(apiDesc => apiDesc.RelativePath.Replace("/", "|"));
			});
		}

		/// <summary>Конфигурация сервисов</summary>
		public static void ConfigureServices(this IServiceCollection services)
		{
			services.AddScoped<IPingService, PingService>();
		}

	}

}
