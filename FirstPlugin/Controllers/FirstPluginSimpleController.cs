using System;
using System.Reflection;
using FirstPlugin.Services.Implementations;
using FirstPlugin.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FirstPlugin.Controllers
{
	[ApiController]
	//[ApiExplorerSettings(GroupName = "v2")]

	public class FirstPluginSimpleController : ControllerBase
	{
		private readonly string VERSION = Assembly.GetExecutingAssembly().GetName().Version.ToString();
		private readonly IFirstPluginService _firstPluginService;

		public FirstPluginSimpleController()
		{
			_firstPluginService = new FirstPluginService();
		}

		/// <summary>
		/// Пинг первого плагина. Не использует зависимостей из других плагинов.
		/// </summary>
		[HttpGet("api/firstpluginsimple/ping")]
		public IActionResult Ping()
		{
			Console.WriteLine(string.Empty);
			Console.WriteLine($"{VERSION} First Plugin Complex Controller work");
			return Ok(_firstPluginService.GetValue());
		}

	}
}
