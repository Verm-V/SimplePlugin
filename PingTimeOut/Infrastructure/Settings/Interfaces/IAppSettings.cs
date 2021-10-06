using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PingTimeOut.Infrastructure.Settings.Interfaces
{
	/// <summary>
	/// Содержит основные настройки приложения
	/// </summary>
	public interface IAppSettings
	{
		/// <summary>
		/// Пауза которую выдерживает сервер прежде чем отдать ответ на пинг
		/// </summary>
		public int PingTimeout { get; set; }
	}
}
