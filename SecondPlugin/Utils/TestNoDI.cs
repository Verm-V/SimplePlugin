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
			Console.WriteLine($"{VERSION} SimpleTestNoDI из SecondPlugin отработал");
			return new MethodResult(true, $"{VERSION} значение из SecondPlugin ", $"{VERSION} Успешно");
		}
	}
}
