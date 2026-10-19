using System.Collections.Generic;
using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E86")]
	public class GlobalMapInfo : GlobalInfoBase
	{
		[Token(Token = "0x400653E")]
		[FieldOffset(Offset = "0x18")]
		public string tileKey;

		[Token(Token = "0x400653F")]
		[FieldOffset(Offset = "0x20")]
		public string tileTypeID;

		[Token(Token = "0x4006540")]
		[FieldOffset(Offset = "0x28")]
		public string tileHumanData;

		[Token(Token = "0x4006541")]
		[FieldOffset(Offset = "0x30")]
		public List<string> tileCards;

		[Token(Token = "0x4006542")]
		[FieldOffset(Offset = "0x38")]
		public string enemyModelId;

		[Token(Token = "0x4006543")]
		[FieldOffset(Offset = "0x40")]
		public string buildModelId;

		[Token(Token = "0x4006544")]
		[FieldOffset(Offset = "0x48")]
		public string eventType;

		[Token(Token = "0x60058AC")]
		[Address(RVA = "0x4364884", Offset = "0x4360884", VA = "0x4364884")]
		public GlobalMapInfo()
		{
		}
	}
}
