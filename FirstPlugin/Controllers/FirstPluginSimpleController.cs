using System;
using System.Reflection;
using FirstPlugin.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FirstPlugin.Controllers
{
	[ApiController]
	//[ApiExplorerSettings(GroupName = "v2")]

	public class FirstPluginSimpleController : ControllerBase
	{
		private readonly string VERSION = Assembly.GetExecutingAssembly().GetName().Version.ToString();
		private readonly IFirstPluginService _firstPluginService;

		public FirstPluginSimpleController(IFirstPluginService firstPluginService)
		{
			_firstPluginService = firstPluginService;
		}

		/// <summary>
		/// Пинг первого плагина. Не использует зависимостей из других плагинов.
		/// </summary>
		[HttpGet("api/firstpluginsimple/ping")]
		public IActionResult Ping()
		{
			Console.WriteLine(string.Empty);
			Console.WriteLine($"{VERSION} Контроллер FirstPluginSimpleController из FirstPlugin отработал.");
			return Ok(_firstPluginService.GetValue());
		}

	}
}
