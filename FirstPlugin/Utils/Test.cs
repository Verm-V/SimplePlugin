using System;
using System.Reflection;

namespace FirstPlugin.Utils
{
	public class Test
	{
		private readonly string VERSION = Assembly.GetExecutingAssembly().GetName().Version.ToString();
		public void SimpleTest()
		{
			Console.WriteLine(string.Empty);
			Console.WriteLine($"{VERSION} First Plugin Test Method");
		}

		public void ComplexTest()
		{
			var test = new SecondPlugin.Utils.Test();
			test.ConsoleWrite();
			Console.WriteLine($"{VERSION} SecondPlugin Test method called from FirstPlugin");
		}

		public void SimpleServiceTest()
		{
			Console.WriteLine(string.Empty);
			var value = new Services.Implementations.FirstPluginService().GetValue();
			Console.WriteLine(value);
			Console.WriteLine($"{VERSION} First Plugin Service test");
		}
		public void ComplexServiceTest()
		{
			Console.WriteLine(string.Empty);
			var value = new SecondPlugin.Services.Implementations.SecondPluginService().GetValue();
			Console.WriteLine(value);
			Console.WriteLine($"{VERSION} Second Plugin Service test called from FirsPlugin");
		}

	}
}
