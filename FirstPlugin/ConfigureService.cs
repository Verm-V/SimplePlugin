using System;
using ExtCore.Infrastructure.Actions;
using FirstPlugin.Services.Implementations;
using FirstPlugin.Services.Interfaces;
using FirstPlugin.Utils;
using Microsoft.Extensions.DependencyInjection;

namespace FirstPlugin
{
	public class ConfigureService : IConfigureServicesAction
	{
		public int Priority => 2000;

		public void Execute(IServiceCollection serviceCollection, IServiceProvider serviceProvider)
		{
			serviceCollection.AddTransient<IFirstPluginService, FirstPluginService>();
			serviceCollection.AddTransient<Test>();
		}
	}
}
