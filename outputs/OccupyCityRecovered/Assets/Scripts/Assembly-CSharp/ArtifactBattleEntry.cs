using System.Collections.Generic;
using DataModule;
using GameModule;
using Il2CppDummyDll;

[Token(Token = "0x2000055")]
public struct ArtifactBattleEntry
{
	[Token(Token = "0x4000198")]
	[FieldOffset(Offset = "0x0")]
	public string infoId;

	[Token(Token = "0x4000199")]
	[FieldOffset(Offset = "0x8")]
	public int level;

	[Token(Token = "0x400019A")]
	[FieldOffset(Offset = "0xC")]
	public int startLevel;

	[Token(Token = "0x400019B")]
	[FieldOffset(Offset = "0x10")]
	public List<string> traitIds;

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x3D0D3D8", Offset = "0x3D093D8", VA = "0x3D0D3D8")]
	public static ArtifactBattleEntry FromUserPropData(UserPropData prop)
	{
		return default;
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x3D0D410", Offset = "0x3D09410", VA = "0x3D0D410")]
	public static ArtifactBattleEntry FromEnemyPropBattleEntry(EnemyPropBattleEntry prop)
	{
		return default;
	}
}
