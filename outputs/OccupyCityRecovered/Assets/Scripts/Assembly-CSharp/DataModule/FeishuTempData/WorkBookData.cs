using Il2CppDummyDll;

namespace DataModule.FeishuTempData
{
	[Token(Token = "0x2000EF9")]
	public class WorkBookData
	{
		[Token(Token = "0x40067EC")]
		[FieldOffset(Offset = "0x10")]
		public WorkBookSheetData[] sheets;

		[Token(Token = "0x6005A3C")]
		[Address(RVA = "0x4390120", Offset = "0x438C120", VA = "0x4390120")]
		public WorkBookData()
		{
		}
	}
}
