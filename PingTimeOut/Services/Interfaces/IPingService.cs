using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PingTimeOut.Services.Interfaces
{
	public interface IPingService
	{
		/// <summary>
		/// Засыпает на время таймаута
		/// </summary>
		public void PingSleep();

		/// <summary>
		/// Устанавливает таймаут для пинга
		/// </summary>
		/// <param name="timeout">Новое значение для таймаута, в милисекундах</param>
		public void SetPingTimeout(int timeout);

		/// <summary>
		/// Возвращает текущее значение таймаута
		/// </summary>
		/// <returns>Текущее значение таймаута</returns>
		public int GetPingTimeout();
	}
}
