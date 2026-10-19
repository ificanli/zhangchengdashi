using Il2CppDummyDll;

namespace DataModule.FeishuTempData
{
	[Token(Token = "0x2000EF8")]
	public class WorkbookInfo
	{
		[Token(Token = "0x40067E9")]
		[FieldOffset(Offset = "0x10")]
		public int code;

		[Token(Token = "0x40067EA")]
		[FieldOffset(Offset = "0x18")]
		public string msg;

		[Token(Token = "0x40067EB")]
		[FieldOffset(Offset = "0x20")]
		public WorkBookData data;

		[Token(Token = "0x6005A3B")]
		[Address(RVA = "0x4390118", Offset = "0x438C118", VA = "0x4390118")]
		public WorkbookInfo()
		{
		}
	}
}
