using Il2CppDummyDll;

namespace CommonGameModule.Debugger.Tools
{
	[Token(Token = "0x200001C")]
	public class BuildInGM_UseLocalTime : IBuildInGM
	{
		[Token(Token = "0x4000056")]
		private const string GM_NAME = "Use Local Time";

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x4637DA8", Offset = "0x4633DA8", VA = "0x4637DA8", Slot = "4")]
		public void RegisterGM()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x4637108", Offset = "0x4633108", VA = "0x4637108")]
		public BuildInGM_UseLocalTime()
		{
		}
	}
}
