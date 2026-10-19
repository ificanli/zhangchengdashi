using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x20001FD")]
	public class WXAccountInfo
	{
		[Token(Token = "0x400073D")]
		[FieldOffset(Offset = "0x10")]
		public MiniProgram miniProgram;

		[Token(Token = "0x400073E")]
		[FieldOffset(Offset = "0x18")]
		public Plugin plugin;

		[Token(Token = "0x60019E7")]
		[Address(RVA = "0x70B8E84", Offset = "0x70B4E84", VA = "0x70B8E84")]
		public WXAccountInfo()
		{
		}
	}
}
