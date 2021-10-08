using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace SecondPlugin.Utils
{
	public class Test
	{
		private readonly string VERSION = Assembly.GetExecutingAssembly().GetName().Version.ToString();

		public void ConsoleWrite()
		{
			Console.WriteLine(string.Empty);
			Console.WriteLine($"{VERSION} Second Plugin Test Method");
		}
	}
}
