using Microsoft.Extensions.Logging;
using PingTimeOut.Infrastructure.Settings.Interfaces;
using PingTimeOut.Services.Interfaces;
using System;
using System.Threading;

namespace PingTimeOut.Services.Implementations
{
	public class PingService : IPingService
	{
		private readonly ILogger<PingService> _logger;
		private readonly IAppSettings _appSettings;

		public PingService(ILogger<PingService> logger, IAppSettings appSettings)
		{
			_logger = logger;
			_appSettings = appSettings;
		}
		public void PingSleep()
		{
			_logger.LogDebug("Sleeping");
			Thread.Sleep(new TimeSpan(0,0,_appSettings.PingTimeout));
		}

		public void SetPingTimeout(int timeout)
		{
			_logger.LogDebug("Setting timeout");
			_appSettings.PingTimeout = timeout;
		}

		public int GetPingTimeout()
		{
			_logger.LogDebug("Getting timeout");
			return _appSettings.PingTimeout;
		}
	}
}
