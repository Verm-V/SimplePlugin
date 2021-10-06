using FirstPlugin.Services.Interfaces;

namespace FirstPlugin.Services.Implementations
{
	class FirstPluginService : IFirstPluginService
	{
		public string GetValue()
		{
			return "value from First Plugin";
		}
	}
}
