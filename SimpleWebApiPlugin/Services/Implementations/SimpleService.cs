namespace SimpleWebApiPlugin.Services.Implementations
{
	/// <summary>
	/// Сервисы для вызова из API плагина
	/// </summary>
	public class SimpleService
	{
		/// <summary>
		/// Возвращает число
		/// </summary>
		/// <returns>Ответ на главный вопрос жизни, вселенной и всего такого</returns>
		public int GetValue()
		{
			return 42;
		}
	}
}
