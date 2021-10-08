using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SecondPlugin.Services.Interfaces;
using SecondPlugin.Services.Implementations;
using System;
using System.Reflection;

namespace FirstPlugin.Controllers
{
	[ApiController]
	//[ApiExplorerSettings(GroupName = "v2")]

	public class FirstPluginComplexController : ControllerBase
	{
		private readonly string VERSION = Assembly.GetExecutingAssembly().GetName().Version.ToString();
		private readonly ISecondPluginService _secondPluginService;

		public FirstPluginComplexController()
		{
			_secondPluginService = new SecondPluginService();
		}

		/// <summary>
		/// Пинг первого плагина. Использует сервис из второго плагина.
		/// </summary>
		[HttpGet("api/firstplugincomplex/ping")]
		public IActionResult Ping()
		{
			Console.WriteLine(string.Empty);
			Console.WriteLine($"{VERSION} First Plugin Simple Controller work");
			return Ok(_secondPluginService.GetValue().ToString());
		}

	}
}
