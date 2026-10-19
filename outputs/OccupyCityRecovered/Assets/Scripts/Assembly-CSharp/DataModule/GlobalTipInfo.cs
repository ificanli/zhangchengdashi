using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E7B")]
	public class GlobalTipInfo : GlobalInfoBase
	{
		[Token(Token = "0x40064F6")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x40064F7")]
		[FieldOffset(Offset = "0x20")]
		public string des;

		[Token(Token = "0x60058A1")]
		[Address(RVA = "0x43647D0", Offset = "0x43607D0", VA = "0x43647D0")]
		public GlobalTipInfo()
		{
		}
	}
}
