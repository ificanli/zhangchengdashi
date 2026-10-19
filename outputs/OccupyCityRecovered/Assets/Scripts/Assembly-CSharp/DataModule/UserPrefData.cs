using System.Collections.Generic;
using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000EEB")]
	public class UserPrefData
	{
		[Token(Token = "0x400678D")]
		[FieldOffset(Offset = "0x10")]
		public bool isAudioBgmEnable;

		[Token(Token = "0x400678E")]
		[FieldOffset(Offset = "0x11")]
		public bool isAudioSfxEnable;

		[Token(Token = "0x400678F")]
		[FieldOffset(Offset = "0x14")]
		public int maxRecord;

		[Token(Token = "0x4006790")]
		[FieldOffset(Offset = "0x18")]
		public bool oepnAiSendEmoji;

		[Token(Token = "0x4006791")]
		[FieldOffset(Offset = "0x20")]
		public List<int> battleCardID;

		[Token(Token = "0x4006792")]
		[FieldOffset(Offset = "0x28")]
		public List<RankItemData> rankInfo;

		[Token(Token = "0x4006793")]
		[FieldOffset(Offset = "0x30")]
		public int DanNum;

		[Token(Token = "0x4006794")]
		[FieldOffset(Offset = "0x38")]
		public string playerName;

		[Token(Token = "0x4006795")]
		[FieldOffset(Offset = "0x40")]
		public int PlayerGameCount;

		[Token(Token = "0x4006796")]
		[FieldOffset(Offset = "0x44")]
		public int WonGameCount;

		[Token(Token = "0x4006797")]
		[FieldOffset(Offset = "0x48")]
		public string HeadShotID;

		[Token(Token = "0x4006798")]
		[FieldOffset(Offset = "0x50")]
		public bool isFirstThroghGame;

		[Token(Token = "0x4006799")]
		[FieldOffset(Offset = "0x51")]
		public bool PLayerWonED;

		[Token(Token = "0x400679A")]
		[FieldOffset(Offset = "0x52")]
		public bool getSliverDan;

		[Token(Token = "0x400679B")]
		[FieldOffset(Offset = "0x53")]
		public bool getWoodDan;

		[Token(Token = "0x400679C")]
		[FieldOffset(Offset = "0x54")]
		public bool getBronzeDan;

		[Token(Token = "0x400679D")]
		[FieldOffset(Offset = "0x55")]
		public bool getGoldenDan;

		[Token(Token = "0x400679E")]
		[FieldOffset(Offset = "0x56")]
		public bool getPlatinumDan;

		[Token(Token = "0x400679F")]
		[FieldOffset(Offset = "0x57")]
		public bool getDiamondDan;

		[Token(Token = "0x40067A0")]
		[FieldOffset(Offset = "0x58")]
		public bool getMasterDan;

		[Token(Token = "0x40067A1")]
		[FieldOffset(Offset = "0x59")]
		public bool getGrandMasterDan;

		[Token(Token = "0x40067A2")]
		[FieldOffset(Offset = "0x5A")]
		public bool getChallengerDan;

		[Token(Token = "0x40067A3")]
		[FieldOffset(Offset = "0x5B")]
		public bool fistUnLockPropShowPropPack;

		[Token(Token = "0x40067A4")]
		[FieldOffset(Offset = "0x5C")]
		public bool handledDanGetData;

		[Token(Token = "0x40067A5")]
		[FieldOffset(Offset = "0x5D")]
		public bool playerTimeInfoConverted;

		[Token(Token = "0x40067A6")]
		[FieldOffset(Offset = "0x5E")]
		public bool isShowNewBieGiftPack;

		[Token(Token = "0x40067A7")]
		[FieldOffset(Offset = "0x5F")]
		public bool isBuyMonthPass;

		[Token(Token = "0x40067A8")]
		[FieldOffset(Offset = "0x60")]
		public List<string> monthPass;

		[Token(Token = "0x40067A9")]
		[FieldOffset(Offset = "0x68")]
		public int userWinStreak;

		[Token(Token = "0x40067AA")]
		[FieldOffset(Offset = "0x6C")]
		public int userLoseStreak;

		[Token(Token = "0x40067AB")]
		[FieldOffset(Offset = "0x70")]
		public bool isPopPacks;

		[Token(Token = "0x6005A09")]
		[Address(RVA = "0x437908C", Offset = "0x437508C", VA = "0x437908C")]
		public UserPrefData()
		{
		}

		[Token(Token = "0x6005A0A")]
		[Address(RVA = "0x4379524", Offset = "0x4375524", VA = "0x4379524")]
		public void EquipCardChangeInfo(int id, int id2)
		{
		}
	}
}
