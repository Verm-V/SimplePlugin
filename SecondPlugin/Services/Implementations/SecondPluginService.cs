using SecondPlugin.Services.Interfaces;

namespace SecondPlugin.Services.Implementations
{
	public class SecondPluginService : ISecondPluginService
	{
		public string GetValue()
		{
			return "value from Second Plugin v0.3.1";
		}
	}
}
