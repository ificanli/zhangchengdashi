using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UIModuleO
{
	[Serializable]
	[Token(Token = "0x2000A1B")]
	public class MysteryAdventureRuinsGlowBinding
	{
		[Token(Token = "0x4004AF6")]
		[FieldOffset(Offset = "0x10")]
		[Tooltip("建筑 buildId（含起点/前进/后退/商店/遗迹等）；cellId 为 0 时从 ChessboardConfig 解析所在格子")]
		public int buildId;

		[Token(Token = "0x4004AF7")]
		[FieldOffset(Offset = "0x14")]
		[Tooltip("格子 ID；为 0 则按 buildId 从棋盘配置自动填充")]
		public int cellId;

		[Token(Token = "0x4004AF8")]
		[FieldOffset(Offset = "0x18")]
		public GameObject effect;

		[Token(Token = "0x6003C24")]
		[Address(RVA = "0x4145DD0", Offset = "0x4141DD0", VA = "0x4145DD0")]
		public MysteryAdventureRuinsGlowBinding()
		{
		}
	}
}
