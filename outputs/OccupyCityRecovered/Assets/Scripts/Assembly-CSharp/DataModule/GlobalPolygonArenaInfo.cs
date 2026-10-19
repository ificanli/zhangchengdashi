using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E73")]
	public class GlobalPolygonArenaInfo : GlobalInfoBase
	{
		[Token(Token = "0x40064BB")]
		[FieldOffset(Offset = "0x18")]
		public string arenaMapSize;

		[Token(Token = "0x40064BC")]
		[FieldOffset(Offset = "0x20")]
		public string mapExcludingHexPos;

		[Token(Token = "0x40064BD")]
		[FieldOffset(Offset = "0x28")]
		public string arenaGroundPrefabPath;

		[Token(Token = "0x40064BE")]
		[FieldOffset(Offset = "0x30")]
		public string mainTowerPosKey;

		[Token(Token = "0x40064BF")]
		[FieldOffset(Offset = "0x38")]
		public string specialPos;

		[Token(Token = "0x40064C0")]
		[FieldOffset(Offset = "0x40")]
		public string arenaDecorationPrefabPath;

		[Token(Token = "0x6005882")]
		[Address(RVA = "0x4361298", Offset = "0x435D298", VA = "0x4361298")]
		public GlobalPolygonArenaInfo()
		{
		}
	}
}
