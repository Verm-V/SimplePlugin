using System;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;

namespace FirstPlugin.Controllers
{
	[ApiController]
	//[ApiExplorerSettings(GroupName = "v2")]

	public class FirstPluginComplexController : ControllerBase
	{
		private readonly string VERSION = Assembly.GetExecutingAssembly().GetName().Version.ToString();

		/// <summary>
		/// Пинг первого плагина. Использует методы из второго плагина.
		/// </summary>
		[HttpGet("api/firstplugincomplex/ping")]
		public IActionResult Ping()
		{
			Console.WriteLine(string.Empty);
			Console.WriteLine($"{VERSION} First Plugin Simple Controller work");
			var result = new SecondPlugin.Utils.TestNoDI().SimpleTestNoDI();
			return Ok(result.Message);

		}

	}
}
