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
		private readonly ILogger<SecondPluginSimpleController> _logger;
		private readonly ISecondPluginService _secondPluginService;

		public SecondPluginSimpleController(ILogger<SecondPluginSimpleController> logger)
		{
			_logger = logger;
			_secondPluginService = new SecondPluginService();
		}

		/// <summary>
		/// Пинг первого плагина. Не использует зависимостей из других плагинов.
		/// </summary>
		[HttpGet("api/secondpluginsimple/ping")]
		public IActionResult Ping()
		{
			_logger.LogDebug("SecondPluginSimple/Ping");
			return Ok(_secondPluginService.GetValue());
		}

	}
}
