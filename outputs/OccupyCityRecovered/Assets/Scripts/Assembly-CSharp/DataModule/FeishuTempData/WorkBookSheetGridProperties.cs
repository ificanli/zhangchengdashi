using Il2CppDummyDll;

namespace DataModule.FeishuTempData
{
	[Token(Token = "0x2000EFB")]
	public class WorkBookSheetGridProperties
	{
		[Token(Token = "0x40067F4")]
		[FieldOffset(Offset = "0x10")]
		public int frozen_row_count;

		[Token(Token = "0x40067F5")]
		[FieldOffset(Offset = "0x14")]
		public int frozen_column_count;

		[Token(Token = "0x40067F6")]
		[FieldOffset(Offset = "0x18")]
		public int row_count;

		[Token(Token = "0x40067F7")]
		[FieldOffset(Offset = "0x1C")]
		public int column_count;

		[Token(Token = "0x6005A3E")]
		[Address(RVA = "0x4390130", Offset = "0x438C130", VA = "0x4390130")]
		public WorkBookSheetGridProperties()
		{
		}
	}
}
