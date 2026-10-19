using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E87")]
	public class GlobalTileInfo : GlobalInfoBase
	{
		[Token(Token = "0x4006545")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x4006546")]
		[FieldOffset(Offset = "0x20")]
		public string type;

		[Token(Token = "0x4006547")]
		[FieldOffset(Offset = "0x28")]
		public string eventId;

		[Token(Token = "0x4006548")]
		[FieldOffset(Offset = "0x30")]
		public string prefabPath;

		[Token(Token = "0x4006549")]
		[FieldOffset(Offset = "0x38")]
		public string incomeFactor;

		[Token(Token = "0x400654A")]
		[FieldOffset(Offset = "0x40")]
		public string priceFactor;

		[Token(Token = "0x400654B")]
		[FieldOffset(Offset = "0x48")]
		public string enemyPathID;

		[Token(Token = "0x60058AD")]
		[Address(RVA = "0x436488C", Offset = "0x436088C", VA = "0x436488C")]
		public GlobalTileInfo()
		{
		}
	}
}
