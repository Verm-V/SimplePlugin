using System;
using ExtCore.Infrastructure.Actions;
using Microsoft.Extensions.DependencyInjection;
using SecondPlugin.Services.Implementations;
using SecondPlugin.Services.Interfaces;
using SecondPlugin.Utils;

namespace SecondPlugin
{
	public class ConfigureService : IConfigureServicesAction
	{
		public int Priority => 2000;

		public void Execute(IServiceCollection serviceCollection, IServiceProvider serviceProvider)
		{
			serviceCollection.AddTransient<ISecondPluginService, SecondPluginService>();
			serviceCollection.AddTransient<Test>();
		}
	}
}
