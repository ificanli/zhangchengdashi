using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x20001FE")]
	public class MiniProgram
	{
		[Token(Token = "0x400073F")]
		[FieldOffset(Offset = "0x10")]
		public string appId;

		[Token(Token = "0x4000740")]
		[FieldOffset(Offset = "0x18")]
		public WXEnvVersion envVersion;

		[Token(Token = "0x4000741")]
		[FieldOffset(Offset = "0x20")]
		public string version;

		[Token(Token = "0x60019E8")]
		[Address(RVA = "0x70B8E8C", Offset = "0x70B4E8C", VA = "0x70B8E8C")]
		public MiniProgram()
		{
		}
	}
}
