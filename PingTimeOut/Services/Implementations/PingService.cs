using PingTimeOut.Infrastructure.Settings.Interfaces;
using PingTimeOut.Services.Interfaces;
using System;
using System.Threading;

namespace PingTimeOut.Services.Implementations
{
	public class PingService : IPingService
	{
		private readonly IAppSettings _appSettings;

		public PingService(IAppSettings appSettings)
		{
			_appSettings = appSettings;
		}
		public void PingSleep()
		{
			Thread.Sleep(new TimeSpan(0,0,_appSettings.PingTimeout));
		}

		public void SetPingTimeout(int timeout)
		{
			_appSettings.PingTimeout = timeout;
		}

		public int GetPingTimeout()
		{
			return _appSettings.PingTimeout;
		}
	}
}
