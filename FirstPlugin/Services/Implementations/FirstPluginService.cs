using System;
using System.Reflection;
using FirstPlugin.Services.Interfaces;

namespace FirstPlugin.Services.Implementations
{
	class FirstPluginService : IFirstPluginService
	{
		private readonly string VERSION = Assembly.GetExecutingAssembly().GetName().Version.ToString();

		public string GetValue()
		{
			Console.WriteLine($"{VERSION} Сервис FirstPluginService отработал");
			return $"{VERSION} значение полученное из сервиса FirstPlugin";
		}
	}
}
