using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Token(Token = "0x2000EBB")]
	public class PlayerArenaData : ServerBaseData
	{
		[Token(Token = "0x4006641")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("uadl")]
		public List<UserArenaData> userArenaDataList;

		[Token(Token = "0x4006642")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("wtc")]
		public int WonTrophyCount;

		[Token(Token = "0x4006643")]
		[FieldOffset(Offset = "0x1C")]
		[JsonProperty("dn")]
		public int DanNum;

		[Token(Token = "0x4006644")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("ihada")]
		public bool isHandleArenaDanAbout;

		[Token(Token = "0x4006645")]
		[FieldOffset(Offset = "0x21")]
		[JsonProperty("isnasp")]
		public bool isSliverNoArena3SpecialPlayer;

		[Token(Token = "0x4006646")]
		[FieldOffset(Offset = "0x22")]
		[JsonProperty("ihopau")]
		public bool isHandleOldPlayerArtifactsUnlock;

		[Token(Token = "0x4006647")]
		[FieldOffset(Offset = "0x28")]
		public List<TrophyProgressRewardData> trophyProgressRewardDataList;

		[Token(Token = "0x6005955")]
		[Address(RVA = "0x436BBF8", Offset = "0x4367BF8", VA = "0x436BBF8", Slot = "5")]
		public override void InitFromDefaults()
		{
    base.InitFromDefaults();
    DanNum = 1;
    if (userArenaDataList == null)
        userArenaDataList = new global::System.Collections.Generic.List<DataModule.UserArenaData>();
}

		[Token(Token = "0x6005956")]
		[Address(RVA = "0x436BC80", Offset = "0x4367C80", VA = "0x436BC80", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x6005957")]
		[Address(RVA = "0x436BFE4", Offset = "0x4367FE4", VA = "0x436BFE4")]
		public PlayerArenaData()
		{
    userArenaDataList = new global::System.Collections.Generic.List<DataModule.UserArenaData>();
}
	}
}
