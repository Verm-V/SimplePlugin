using PingTimeOut.Infrastructure.Settings.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PingTimeOut.Infrastructure.Settings.Implementations
{
	public class AppSettings : IAppSettings
	{
		public int PingTimeout { get; set; }
	}
}
