using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x20001F2")]
	public class NotifyParams
	{
		[Token(Token = "0x40006DC")]
		[FieldOffset(Offset = "0x10")]
		public string CM_TYPE;

		[Token(Token = "0x40006DD")]
		[FieldOffset(Offset = "0x18")]
		public string CM_ACTION;

		[Token(Token = "0x40006DE")]
		[FieldOffset(Offset = "0x20")]
		public string CM_DATAFIELD;

		[Token(Token = "0x60019D4")]
		[Address(RVA = "0x70AB368", Offset = "0x70A7368", VA = "0x70AB368")]
		public NotifyParams()
		{
		}
	}
}
