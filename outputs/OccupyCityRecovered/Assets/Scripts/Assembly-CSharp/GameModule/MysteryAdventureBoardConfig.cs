using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000505")]
	public static class MysteryAdventureBoardConfig
	{
		[Token(Token = "0x6001959")]
		[Address(RVA = "0x3E9259C", Offset = "0x3E8E59C", VA = "0x3E9259C")]
		[Obsolete("Use MysteryAdventureConfigService.BuildCells() instead.")]
		public static IReadOnlyList<MysteryAdventureCellConfig> BuildMvpCells()
		{
			return null;
		}

		[Token(Token = "0x600195A")]
		[Address(RVA = "0x3E92A58", Offset = "0x3E8EA58", VA = "0x3E92A58")]
		[Obsolete("Use MysteryAdventureConfigService.BuildCells() instead.")]
		public static MysteryAdventureCellConfig GetCell(int cellId)
		{
			return null;
		}

		[Token(Token = "0x600195B")]
		[Address(RVA = "0x3E92994", Offset = "0x3E8E994", VA = "0x3E92994")]
		private static void SetCell(List<MysteryAdventureCellConfig> list, int cellId, MysteryAdventureCellType type, MysteryAdventureTriggerType trigger, int min, int max, string resourceId)
		{
		}

		[Token(Token = "0x600195C")]
		[Address(RVA = "0x3E92908", Offset = "0x3E8E908", VA = "0x3E92908")]
		private static MysteryAdventureCellConfig BuildPlaceholderCell(int cellId)
		{
			return null;
		}
	}
}
