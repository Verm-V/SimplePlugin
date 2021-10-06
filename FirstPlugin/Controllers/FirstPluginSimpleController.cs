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
			return Ok(_firstPluginService.GetValue());
		}

	}
}
