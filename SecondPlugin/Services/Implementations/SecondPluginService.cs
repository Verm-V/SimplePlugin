using System;
using System.Reflection;
using SecondPlugin.Services.Interfaces;

namespace SecondPlugin.Services.Implementations
{
	class SecondPluginService : ISecondPluginService
	{
		private readonly string VERSION = Assembly.GetExecutingAssembly().GetName().Version.ToString();

		public string GetValue()
		{
			Console.WriteLine($"{VERSION} Сервис SecondPluginService отработал");
			return $"{VERSION} значение полученное из сервиса SecondPlugin";
		}
	}
}
