using System;
using System.Reflection;
using RDEV.Web.Models.Methods;
using SecondPlugin.Services.Interfaces;

namespace SecondPlugin.Utils
{
	public class Test
	{
		private readonly string VERSION = Assembly.GetExecutingAssembly().GetName().Version.ToString();
		private readonly ISecondPluginService _secondPluginService;

		public Test(ISecondPluginService secondPluginService)
		{
			_secondPluginService = secondPluginService;
		}

		/// <summary>
		/// Простой метод не использующий другие методы
		/// </summary>
		/// <returns></returns>
		public MethodResult SimpleTest()
		{
			Console.WriteLine(string.Empty);
			Console.WriteLine($"{VERSION} SimpleTest из SecondPlugin отработал");
			return new MethodResult(true, string.Empty, $"{VERSION} Успешно");
		}

		/// <summary>
		/// Метод использующий сервис этого плагина через DI
		/// </summary>
		/// <returns></returns>
		public MethodResult SimpleServiceTest()
		{
			Console.WriteLine(string.Empty);
			string value = _secondPluginService.GetValue();
			Console.WriteLine($"{VERSION} SimpleServiceTest из SecondPlugin отработал");
			return new MethodResult(true, value.ToString(), $"{VERSION} Успешно. Получено значение: {value}");
		}
	}
}
