using System.Collections.Generic;
using DataModule;
using Il2CppDummyDll;

[Token(Token = "0x2000056")]
public struct BattlePowerSideInput
{
	[Token(Token = "0x400019C")]
	[FieldOffset(Offset = "0x0")]
	public List<UserHeroCardData> cardList;

	[Token(Token = "0x400019D")]
	[FieldOffset(Offset = "0x8")]
	public Dictionary<string, List<int>> cardTalentUnlockIds;

	[Token(Token = "0x400019E")]
	[FieldOffset(Offset = "0x10")]
	public bool artifactsEnabled;

	[Token(Token = "0x400019F")]
	[FieldOffset(Offset = "0x18")]
	public string equipPropId;

	[Token(Token = "0x40001A0")]
	[FieldOffset(Offset = "0x20")]
	public List<ArtifactBattleEntry> activatedArtifacts;
}
