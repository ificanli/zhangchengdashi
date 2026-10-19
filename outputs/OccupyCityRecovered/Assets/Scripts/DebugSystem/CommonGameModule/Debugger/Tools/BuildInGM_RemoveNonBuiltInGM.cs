using Il2CppDummyDll;

namespace CommonGameModule.Debugger.Tools
{
	[Token(Token = "0x200001A")]
	public class BuildInGM_RemoveNonBuiltInGM : IBuildInGM
	{
		[Token(Token = "0x4000054")]
		private const string GM_NAME = "Remove Non-Built-In GM";

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x463798C", Offset = "0x463398C", VA = "0x463798C", Slot = "4")]
		public void RegisterGM()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x4637A9C", Offset = "0x4633A9C", VA = "0x4637A9C")]
		private static void RemoveNonBuiltInGM(string input)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x4637AEC", Offset = "0x4633AEC", VA = "0x4637AEC")]
		public BuildInGM_RemoveNonBuiltInGM()
		{
		}
	}
}
