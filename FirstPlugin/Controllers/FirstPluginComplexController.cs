using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SecondPlugin.Services.Interfaces;
using SecondPlugin.Services.Implementations;

namespace FirstPlugin.Controllers
{
	[ApiController]
	//[ApiExplorerSettings(GroupName = "v2")]

	public class FirstPluginComplexController : ControllerBase
	{
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
			return Ok(_secondPluginService.GetValue().ToString());
		}

	}
}
