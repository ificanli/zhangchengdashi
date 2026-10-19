using Il2CppDummyDll;

namespace DataModule.FeishuTempData
{
	[Token(Token = "0x2000EFA")]
	public class WorkBookSheetData
	{
		[Token(Token = "0x40067ED")]
		[FieldOffset(Offset = "0x10")]
		public string sheet_id;

		[Token(Token = "0x40067EE")]
		[FieldOffset(Offset = "0x18")]
		public string title;

		[Token(Token = "0x40067EF")]
		[FieldOffset(Offset = "0x20")]
		public int index;

		[Token(Token = "0x40067F0")]
		[FieldOffset(Offset = "0x24")]
		public bool hidden;

		[Token(Token = "0x40067F1")]
		[FieldOffset(Offset = "0x28")]
		public WorkBookSheetGridProperties grid_properties;

		[Token(Token = "0x40067F2")]
		[FieldOffset(Offset = "0x30")]
		public string resource_type;

		[Token(Token = "0x40067F3")]
		[FieldOffset(Offset = "0x38")]
		public WorkBookMerges[] merges;

		[Token(Token = "0x6005A3D")]
		[Address(RVA = "0x4390128", Offset = "0x438C128", VA = "0x4390128")]
		public WorkBookSheetData()
		{
		}
	}
}
