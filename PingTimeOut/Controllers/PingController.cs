using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PingTimeOut.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PingTimeOut.Controllers
{
	[ApiController]
	//[ApiExplorerSettings(GroupName = "v2")]

	public class PingController : ControllerBase
	{
		private readonly ILogger<PingController> _logger;
		private readonly IPingService _pingService;

		public PingController(ILogger<PingController> logger, IPingService pingService)
		{
			_logger = logger;
			_pingService = pingService;
		}

		/// <summary>
		/// Проверка доступности сервера, возвращает OK после заданной в настройках сервера паузы
		/// </summary>
		[HttpGet("ping")]
		public IActionResult Ping()
		{
			_pingService.PingSleep();
			return Ok();
		}

		/// <summary>
		/// Устанавливает новое значение паузы перед ответом сервера во время пинга
		/// </summary>
		/// <param name="timeout">Новое значение таймаута, в секундах</param>
		[HttpPost("setpingtimeout")]
		public IActionResult SetPingTimeout([FromQuery] int timeout)
		{
			_pingService.SetPingTimeout(timeout);
			return Ok();
		}

		/// <summary>
		/// Возвращает текущее значение паузы перед ответом сервера во время пинга
		/// </summary>
		[HttpGet("getpingtimeout")]
		public IActionResult GetPingTimeout()
		{
			return new OkObjectResult(_pingService.GetPingTimeout());
		}

	}
}
