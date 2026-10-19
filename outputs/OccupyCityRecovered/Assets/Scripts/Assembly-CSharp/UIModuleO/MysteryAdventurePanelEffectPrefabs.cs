using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UIModuleO
{
	[Serializable]
	[Token(Token = "0x2000A1C")]
	public class MysteryAdventurePanelEffectPrefabs
	{
		[Token(Token = "0x4004AF9")]
		[FieldOffset(Offset = "0x10")]
		[Header("棋盘建筑光效（按格子）")]
		public MysteryAdventureRuinsGlowBinding[] buildingGlowByCell;

		[Token(Token = "0x4004AFA")]
		[FieldOffset(Offset = "0x18")]
		[Header("跑圈/自动")]
		public GameObject lapLevelEnergyGlow;

		[Token(Token = "0x4004AFB")]
		[FieldOffset(Offset = "0x20")]
		public GameObject lapLevelUpgradeGlow;

		[Token(Token = "0x4004AFC")]
		[FieldOffset(Offset = "0x28")]
		public GameObject autoRollRing;

		[Token(Token = "0x6003C25")]
		[Address(RVA = "0x4145DD8", Offset = "0x4141DD8", VA = "0x4145DD8")]
		public MysteryAdventurePanelEffectPrefabs()
		{
		}
	}
}
