using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SimpleLibraryPlugin.Controllers
{
	[ApiController]
	//[ApiExplorerSettings(GroupName = "v2")]

	public class SimpleController : ControllerBase
	{
		private readonly ILogger<SimpleController> _logger;

		public SimpleController(ILogger<SimpleController> logger)
		{
			_logger = logger;
		}

		/// <summary>
		/// Проверка доступности сервера, возвращает OK после заданной в настройках сервера паузы
		/// Не использует дополнительных библиотек
		/// </summary>
		[HttpGet("simple/ping")]
		public IActionResult Ping()
		{
			return Ok("simple");
		}

	}
}
