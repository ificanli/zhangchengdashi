using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E7C")]
	public class GlobalTrainingMapInfo : GlobalInfoBase
	{
		[Token(Token = "0x40064F8")]
		[FieldOffset(Offset = "0x18")]
		public string mapSize;

		[Token(Token = "0x40064F9")]
		[FieldOffset(Offset = "0x20")]
		public string mainTowerPos;

		[Token(Token = "0x40064FA")]
		[FieldOffset(Offset = "0x28")]
		public string hexConfigs;

		[Token(Token = "0x40064FB")]
		[FieldOffset(Offset = "0x30")]
		public string enemyCardDeck;

		[Token(Token = "0x40064FC")]
		[FieldOffset(Offset = "0x38")]
		public string enemyDifficultLevel;

		[Token(Token = "0x40064FD")]
		[FieldOffset(Offset = "0x40")]
		public string tutorialSteps;

		[Token(Token = "0x40064FE")]
		[FieldOffset(Offset = "0x48")]
		public string playerInitialCoin;

		[Token(Token = "0x40064FF")]
		[FieldOffset(Offset = "0x50")]
		public string enemyInitialCoin;

		[Token(Token = "0x4006500")]
		[FieldOffset(Offset = "0x58")]
		public string enemyFlipHexSeq;

		[Token(Token = "0x4006501")]
		[FieldOffset(Offset = "0x60")]
		public string enemyFlipIntervals;

		[Token(Token = "0x4006502")]
		[FieldOffset(Offset = "0x68")]
		public string mapShape;

		[Token(Token = "0x4006503")]
		[FieldOffset(Offset = "0x70")]
		public string gameTutorEndReward;

		[Token(Token = "0x4006504")]
		[FieldOffset(Offset = "0x78")]
		public string dragonKnightConfig;

		[Token(Token = "0x4006505")]
		[FieldOffset(Offset = "0x80")]
		public string cameraLimitBounds;

		[Token(Token = "0x60058A2")]
		[Address(RVA = "0x43647D8", Offset = "0x43607D8", VA = "0x43647D8")]
		public GlobalTrainingMapInfo()
		{
		}
	}
}
