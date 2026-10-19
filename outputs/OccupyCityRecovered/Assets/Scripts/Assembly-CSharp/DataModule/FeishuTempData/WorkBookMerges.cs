using Il2CppDummyDll;

namespace DataModule.FeishuTempData
{
	[Token(Token = "0x2000EFC")]
	public class WorkBookMerges
	{
		[Token(Token = "0x40067F8")]
		[FieldOffset(Offset = "0x10")]
		public int start_row_index;

		[Token(Token = "0x40067F9")]
		[FieldOffset(Offset = "0x14")]
		public int end_row_index;

		[Token(Token = "0x40067FA")]
		[FieldOffset(Offset = "0x18")]
		public int start_column_index;

		[Token(Token = "0x40067FB")]
		[FieldOffset(Offset = "0x1C")]
		public int end_column_index;

		[Token(Token = "0x6005A3F")]
		[Address(RVA = "0x4390138", Offset = "0x438C138", VA = "0x4390138")]
		public WorkBookMerges()
		{
		}
	}
}
