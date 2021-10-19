using System;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using SecondPlugin.Services.Interfaces;

namespace SecondPlugin.Controllers
{
	[ApiController]
	//[ApiExplorerSettings(GroupName = "v2")]

	public class SecondPluginSimpleController : ControllerBase
	{
		private readonly string VERSION = Assembly.GetExecutingAssembly().GetName().Version.ToString();
		private readonly ISecondPluginService _secondPluginService;

		public SecondPluginSimpleController(ISecondPluginService secondPluginService)
		{
			_secondPluginService = secondPluginService;
		}

		/// <summary>
		/// Пинг первого плагина. Не использует зависимостей из других плагинов.
		/// </summary>
		[HttpGet("api/secondpluginsimple/ping")]
		public IActionResult Ping()
		{
			Console.WriteLine(string.Empty);
			Console.WriteLine($"{VERSION} Контроллер SecondPluginSimpleController из SecondPlugin отработал.");
			return Ok(_secondPluginService.GetValue());
		}

	}
}
