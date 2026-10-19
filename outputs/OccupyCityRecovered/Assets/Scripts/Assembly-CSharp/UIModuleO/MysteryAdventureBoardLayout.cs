using System.Collections.Generic;
using GameModule;
using Il2CppDummyDll;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x20009B6")]
	public static class MysteryAdventureBoardLayout
	{
		[Token(Token = "0x400486E")]
		public const float CellMatchDistanceSqr = 3600f;

		[Token(Token = "0x400486F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector2[] CellPositions;

		[Token(Token = "0x4004870")]
		[FieldOffset(Offset = "0x8")]
		private static readonly bool[] ClockwiseStepFaceFront;

		[Token(Token = "0x60039BD")]
		[Address(RVA = "0x4107A34", Offset = "0x4103A34", VA = "0x4107A34")]
		public static Vector2 GetAnchoredPosition(int cellId)
		{
			return default;
		}

		[Token(Token = "0x60039BE")]
		[Address(RVA = "0x4107B2C", Offset = "0x4103B2C", VA = "0x4107B2C")]
		public static bool TryMatchCellIdByAnchoredPosition(Vector2 anchoredPosition, ICollection<int> usedCellIds, out int cellId)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MysteryAdventureBoardLayout.TryMatchCellIdByAnchoredPosition RVA=0x4107B2C Token=0x60039BE");
}

		[Token(Token = "0x60039BF")]
		[Address(RVA = "0x4107CFC", Offset = "0x4103CFC", VA = "0x4107CFC")]
		public static int GetNextClockwiseCellId(int cellId)
		{
			return default;
		}

		[Token(Token = "0x60039C0")]
		[Address(RVA = "0x4107D80", Offset = "0x4103D80", VA = "0x4107D80")]
		public static bool IsClockwiseStep(int fromCellId, int toCellId)
		{
			return default;
		}

		[Token(Token = "0x60039C1")]
		[Address(RVA = "0x4107DEC", Offset = "0x4103DEC", VA = "0x4107DEC")]
		public static bool GetClockwiseStepFaceFront(int fromCellId)
		{
			return default;
		}

		[Token(Token = "0x60039C2")]
		[Address(RVA = "0x4107EA8", Offset = "0x4103EA8", VA = "0x4107EA8")]
		public static bool ResolveClockwiseFacing(Vector2 delta)
		{
			return default;
		}

		[Token(Token = "0x60039C3")]
		[Address(RVA = "0x4107F1C", Offset = "0x4103F1C", VA = "0x4107F1C")]
		private static bool[] BuildClockwiseStepFaceFront()
		{
			return null;
		}

		[Token(Token = "0x60039C4")]
		[Address(RVA = "0x410807C", Offset = "0x410407C", VA = "0x410807C")]
		public static bool TryResolveClockwiseCellsFromRoot(RectTransform cellsRoot, out MysteryAdventureBoardCellView[] orderedCells)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MysteryAdventureBoardLayout.TryResolveClockwiseCellsFromRoot RVA=0x410807C Token=0x60039C4");
}

		[Token(Token = "0x60039C5")]
		[Address(RVA = "0x4108338", Offset = "0x4104338", VA = "0x4108338")]
		public static bool TryAssignClockwiseCellIdsByGeometry(IReadOnlyList<BoardCellGeometrySample> samples, out MysteryAdventureBoardCellView[] orderedCells)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MysteryAdventureBoardLayout.TryAssignClockwiseCellIdsByGeometry RVA=0x4108338 Token=0x60039C5");
}

		[Token(Token = "0x60039C6")]
		[Address(RVA = "0x4109024", Offset = "0x4105024", VA = "0x4109024")]
		public static bool VerifyClockwiseGeometryBinding(MysteryAdventureBoardCellView[] cells)
		{
			return default;
		}

		[Token(Token = "0x60039C7")]
		[Address(RVA = "0x4108F38", Offset = "0x4104F38", VA = "0x4108F38")]
		private static float ComputeSignedArea(List<BoardCellGeometrySample> ordered)
		{
			return default;
		}

		[Token(Token = "0x60039C8")]
		[Address(RVA = "0x4109294", Offset = "0x4105294", VA = "0x4109294")]
		public static Color GetCellColor(MysteryAdventureCellType cellType)
		{
			return default;
		}

		[Token(Token = "0x60039C9")]
		[Address(RVA = "0x41092E4", Offset = "0x41052E4", VA = "0x41092E4")]
		public static string GetCellLabel(MysteryAdventureCellType cellType)
		{
			return null;
		}

		[Token(Token = "0x60039CA")]
		[Address(RVA = "0x41093DC", Offset = "0x41053DC", VA = "0x41093DC")]
		public static int GetChessboardIconIndex(int buildId)
		{
			return default;
		}

		[Token(Token = "0x60039CB")]
		[Address(RVA = "0x4109400", Offset = "0x4105400", VA = "0x4109400")]
		public static bool ShouldShowChessboardIcon(int buildId)
		{
			return default;
		}

		[Token(Token = "0x60039CC")]
		[Address(RVA = "0x4109460", Offset = "0x4105460", VA = "0x4109460")]
		public static Vector2 GetChessboardIconSize(int iconIndex)
		{
			return default;
		}

		[Token(Token = "0x60039CD")]
		[Address(RVA = "0x410949C", Offset = "0x410549C", VA = "0x410949C")]
		public static Vector2 GetChessboardIconOffset(int iconIndex)
		{
			return default;
		}
	}
}
