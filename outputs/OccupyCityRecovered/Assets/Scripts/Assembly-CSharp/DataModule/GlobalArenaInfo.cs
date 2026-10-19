using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E4F")]
	public class GlobalArenaInfo : GlobalInfoBase
	{
		[Token(Token = "0x4006399")]
		[FieldOffset(Offset = "0x18")]
		public string trophyReward;

		[Token(Token = "0x400639A")]
		[FieldOffset(Offset = "0x20")]
		public string trophyPunish;

		[Token(Token = "0x400639B")]
		[FieldOffset(Offset = "0x28")]
		public string diamondReward;

		[Token(Token = "0x400639C")]
		[FieldOffset(Offset = "0x30")]
		public string BetlimitA;

		[Token(Token = "0x400639D")]
		[FieldOffset(Offset = "0x38")]
		public string BetlimitB;

		[Token(Token = "0x400639E")]
		[FieldOffset(Offset = "0x40")]
		public string completeTrophyRequire;

		[Token(Token = "0x400639F")]
		[FieldOffset(Offset = "0x48")]
		public string completeDiamondReward;

		[Token(Token = "0x40063A0")]
		[FieldOffset(Offset = "0x50")]
		public string winCountUnLock;

		[Token(Token = "0x40063A1")]
		[FieldOffset(Offset = "0x58")]
		public string keyReward;

		[Token(Token = "0x40063A2")]
		[FieldOffset(Offset = "0x60")]
		public string completeKeyReward;

		[Token(Token = "0x40063A3")]
		[FieldOffset(Offset = "0x68")]
		public string completeBoxRewardType;

		[Token(Token = "0x40063A4")]
		[FieldOffset(Offset = "0x70")]
		public string boxRewardFold;

		[Token(Token = "0x40063A5")]
		[FieldOffset(Offset = "0x78")]
		public string countDownTime;

		[Token(Token = "0x40063A6")]
		[FieldOffset(Offset = "0x80")]
		public string iconPath;

		[Token(Token = "0x40063A7")]
		[FieldOffset(Offset = "0x88")]
		public string arenaPlanePrefabPath;

		[Token(Token = "0x40063A8")]
		[FieldOffset(Offset = "0x90")]
		public string arenaHexPrefabPath;

		[Token(Token = "0x40063A9")]
		[FieldOffset(Offset = "0x98")]
		public string arenaSkyBoxMaterialPath;

		[Token(Token = "0x40063AA")]
		[FieldOffset(Offset = "0xA0")]
		public string arenaDecorationPrefabPath;

		[Token(Token = "0x40063AB")]
		[FieldOffset(Offset = "0xA8")]
		public string arenaMapSize;

		[Token(Token = "0x40063AC")]
		[FieldOffset(Offset = "0xB0")]
		public string mapExcludingHexPos;

		[Token(Token = "0x40063AD")]
		[FieldOffset(Offset = "0xB8")]
		public string arenaGroundPrefabPath;

		[Token(Token = "0x40063AE")]
		[FieldOffset(Offset = "0xC0")]
		public string cameraLimitSize;

		[Token(Token = "0x40063AF")]
		[FieldOffset(Offset = "0xC8")]
		public string cameraAnimationNum;

		[Token(Token = "0x40063B0")]
		[FieldOffset(Offset = "0xD0")]
		public string mainTowerPosKey;

		[Token(Token = "0x40063B1")]
		[FieldOffset(Offset = "0xD8")]
		public string chestRange;

		[Token(Token = "0x40063B2")]
		[FieldOffset(Offset = "0xE0")]
		public string arenaPath;

		[Token(Token = "0x40063B3")]
		[FieldOffset(Offset = "0xE8")]
		public string minesCountLimit;

		[Token(Token = "0x40063B4")]
		[FieldOffset(Offset = "0xF0")]
		public string arenaProgressReward;

		[Token(Token = "0x40063B5")]
		[FieldOffset(Offset = "0xF8")]
		public string victoryGoldNoBet;

		[Token(Token = "0x40063B6")]
		[FieldOffset(Offset = "0x100")]
		public string dailyGoldLimitNoBet;

		[Token(Token = "0x17000EEA")]
		public string playDiamondRequire
		{
			[Token(Token = "0x60057C5")]
			[Address(RVA = "0x4357EC4", Offset = "0x4353EC4", VA = "0x4357EC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60057C6")]
		[Address(RVA = "0x4357F54", Offset = "0x4353F54", VA = "0x4357F54")]
		public GlobalArenaInfo()
		{
		}
	}
}
