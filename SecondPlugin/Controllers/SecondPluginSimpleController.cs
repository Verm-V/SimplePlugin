using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SecondPlugin.Services.Implementations;
using SecondPlugin.Services.Interfaces;

namespace SecondPlugin.Controllers
{
	[ApiController]
	//[ApiExplorerSettings(GroupName = "v2")]

	public class SecondPluginSimpleController : ControllerBase
	{
		private readonly ISecondPluginService _secondPluginService;

		public SecondPluginSimpleController()
		{
			_secondPluginService = new SecondPluginService();
		}

		/// <summary>
		/// Пинг первого плагина. Не использует зависимостей из других плагинов.
		/// </summary>
		[HttpGet("api/secondpluginsimple/ping")]
		public IActionResult Ping()
		{
			return Ok(_secondPluginService.GetValue());
		}

	}
}
