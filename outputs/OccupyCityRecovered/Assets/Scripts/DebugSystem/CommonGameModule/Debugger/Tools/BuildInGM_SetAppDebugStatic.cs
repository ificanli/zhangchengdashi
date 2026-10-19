using Il2CppDummyDll;

namespace CommonGameModule.Debugger.Tools
{
	[Token(Token = "0x200001B")]
	public class BuildInGM_SetAppDebugStatic : IBuildInGM
	{
		[Token(Token = "0x4000055")]
		private const string GM_NAME = "SetAppDebugStatic";

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x4637AF4", Offset = "0x4633AF4", VA = "0x4637AF4", Slot = "4")]
		public void RegisterGM()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x4637C44", Offset = "0x4633C44", VA = "0x4637C44")]
		private static void SetAppDebugStatic(bool isOn)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x4637100", Offset = "0x4633100", VA = "0x4637100")]
		public BuildInGM_SetAppDebugStatic()
		{
		}
	}
}
