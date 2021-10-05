using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleWebApiPlugin.Services.Implementations;

namespace SimpleLibraryPlugin.Controllers
{
	[ApiController]
	//[ApiExplorerSettings(GroupName = "v2")]

	public class ComplexController : ControllerBase
	{
		private readonly ILogger<ComplexController> _logger;
		private readonly SimpleService _simpleService;

		public ComplexController(ILogger<ComplexController> logger)
		{
			_logger = logger;
			_simpleService = new SimpleService();
		}

		/// <summary>
		/// Проверка доступности сервера, возвращает OK после заданной в настройках сервера паузы
		/// Не использует дополнительных библиотек
		/// </summary>
		[HttpGet("complex/ping")]
		public IActionResult Ping()
		{
			return Ok(_simpleService.GetValue().ToString());
		}

	}
}
