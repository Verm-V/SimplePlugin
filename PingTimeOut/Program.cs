using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Web;

namespace PingTimeOut
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var logger = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
			try
			{
				logger.Trace("---- [BEGIN]----");
				logger.Debug("---- [BEGIN]----");
				logger.Info("---- [BEGIN]----");
				CreateHostBuilder(args).Build().Run();
			}
			// отлов всех исключений в рамках работы приложения
			catch (Exception exception)
			{
				// NLog: устанавливаем отлов исключений
				logger.Error(exception, "Stopped program because of exception");
			}
			finally
			{
				// Остановка логера 
				logger.Info("---- [ END ]----");
				logger.Debug("---- [ END ]----");
				logger.Trace("---- [ END ]----");
				NLog.LogManager.Shutdown();
			}
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseStartup<Startup>();
				})
				.ConfigureLogging(logging =>
				{
					logging.AddDebug();
					logging.ClearProviders(); // Создание провайдеров логирования
					logging.SetMinimumLevel(LogLevel.Trace); // Устанавливаем минимальный уровень логирования
				})
				.UseNLog(); // Добавляем библиотеку nlog
	}
}
