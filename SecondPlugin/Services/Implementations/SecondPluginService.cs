using System;
using SecondPlugin.Services.Interfaces;

namespace SecondPlugin.Services.Implementations
{
	public class SecondPluginService : ISecondPluginService
	{
		public string GetValue()
		{
			Console.WriteLine("Service from Second Plugin work V0.4.1");
			return "value from Second Plugin v0.4.1";
		}
	}
}
