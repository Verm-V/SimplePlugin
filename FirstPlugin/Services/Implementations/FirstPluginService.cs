using System;
using FirstPlugin.Services.Interfaces;

namespace FirstPlugin.Services.Implementations
{
	class FirstPluginService : IFirstPluginService
	{
		public string GetValue()
		{
			Console.WriteLine("Service from First Plugin work V0.4.0");
			return "value from First Plugin v0.4.0";
		}
	}
}
