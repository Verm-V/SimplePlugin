using System;
using System.Reflection;
using SecondPlugin.Services.Interfaces;

namespace SecondPlugin.Services.Implementations
{
	public class SecondPluginService : ISecondPluginService
	{
		private readonly string VERSION = Assembly.GetExecutingAssembly().GetName().Version.ToString();

		public string GetValue()
		{
			Console.WriteLine($"{VERSION} Second Plugin Service work");
			return $"{VERSION} value from Second Plugin";
		}
	}
}
