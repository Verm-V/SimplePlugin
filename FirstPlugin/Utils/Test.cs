using System;
using System.Reflection;
using FirstPlugin.Services.Interfaces;
using RDEV.Web.Models.Methods;

namespace FirstPlugin.Utils
{
	/// <summary>
	/// Тестовые методы
	/// </summary>
	public class Test
	{
		private readonly string VERSION = Assembly.GetExecutingAssembly().GetName().Version.ToString();
		private readonly IFirstPluginService _firstPluginService;
		private readonly SecondPlugin.Utils.Test _secondTest;

		public Test(IFirstPluginService firstPluginService, SecondPlugin.Utils.Test secondTest)
		{
			_firstPluginService = firstPluginService;
			_secondTest = secondTest;
		}
		
		/// <summary>
		/// Простой метод не использующий другие методы
		/// </summary>
		/// <returns></returns>
		public MethodResult SimpleTest()
		{
			Console.WriteLine(string.Empty);
			Console.WriteLine($"{VERSION} SimpleTest из FirstPlugin отработал");
			return new MethodResult(true, string.Empty, $"{VERSION} Успешно");
		}

		/// <summary>
		/// Метод использующий сервис из второго плагина через DI
		/// </summary>
		/// <returns></returns>
		public MethodResult ComplexTest()
		{
			_secondTest.SimpleTest();
			Console.WriteLine($"{VERSION} ComplexTest из FirstPlugin отработал");
			return new MethodResult(true, string.Empty, $"{VERSION} Успешно");
		}

		/// <summary>
		/// Метод использующий сервис из этого плагина через DI
		/// </summary>
		/// <returns></returns>
		public MethodResult SimpleServiceTest()
		{
			Console.WriteLine(string.Empty);
			string value = _firstPluginService.GetValue();
			Console.WriteLine($"{VERSION} SimpleServiceTest из FirstPlugin отработал");
			return new MethodResult(true, string.Empty, $"{VERSION} Успешно. Получена строка: {value}");
		}

		/// <summary>
		/// Метод использующий тест из второго плагина через DI и получающий оттуда значение
		/// </summary>
		/// <returns></returns>
		public MethodResult ComplexServiceTest()
		{
			Console.WriteLine(string.Empty);
			MethodResult value = _secondTest.SimpleServiceTest();
			Console.WriteLine($"{VERSION} ComplexServiceTest из FirstPlugin отработал");
			return new MethodResult(true, string.Empty, $"{VERSION} Успешно. Получена строка: {value.Message}");
		}

	}
}
