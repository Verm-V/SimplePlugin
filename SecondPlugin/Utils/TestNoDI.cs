using System;
using System.Reflection;
using RDEV.Web.Models.Methods;

namespace SecondPlugin.Utils
{
	public class TestNoDI
	{
		private readonly string VERSION = Assembly.GetExecutingAssembly().GetName().Version.ToString();

		/// <summary>
		/// Простой тестовый метод в классе не включенном в DI
		/// </summary>
		/// <returns></returns>
		public MethodResult SimpleTestNoDI()
		{
			Console.WriteLine(string.Empty);
			Console.WriteLine($"{VERSION} Second Plugin Test no DI");
			return new MethodResult(true, $"{VERSION} Value from Second Plugin Test no DI", $"{VERSION} Успешно");
		}
	}
}
