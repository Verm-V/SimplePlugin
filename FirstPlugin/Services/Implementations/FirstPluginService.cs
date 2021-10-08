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
			Console.WriteLine($"{VERSION} First Plugin Service work");
			return $"{VERSION} value from First Plugin";
		}
	}
}
