using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x20002B3")]
	internal sealed class WebGLHexPathField
	{
		[Token(Token = "0x4002161")]
		internal const int WallCostMultiplier = 5;

		[Token(Token = "0x4002162")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<HexManager.HexCoord, int> _indexByCoord;

		[Token(Token = "0x4002163")]
		[FieldOffset(Offset = "0x18")]
		private readonly WebGLHexAStar _astar;

		[Token(Token = "0x4002164")]
		[FieldOffset(Offset = "0x20")]
		private BattleGameSceneManager _scene;

		[Token(Token = "0x4002165")]
		[FieldOffset(Offset = "0x28")]
		private HexBehaviour[] _hexes;

		[Token(Token = "0x4002166")]
		[FieldOffset(Offset = "0x30")]
		private HexManager.HexCoord[] _coords;

		[Token(Token = "0x4002167")]
		[FieldOffset(Offset = "0x38")]
		private int[] _neighbors;

		[Token(Token = "0x4002168")]
		[FieldOffset(Offset = "0x40")]
		private bool[] _enemyWallBlocked;

		[Token(Token = "0x4002169")]
		[FieldOffset(Offset = "0x48")]
		private bool[] _playerWallBlocked;

		[Token(Token = "0x400216A")]
		[FieldOffset(Offset = "0x50")]
		private int[] _playerNext;

		[Token(Token = "0x400216B")]
		[FieldOffset(Offset = "0x58")]
		private int[] _enemyNext;

		[Token(Token = "0x400216C")]
		[FieldOffset(Offset = "0x60")]
		private int[] _playerCost;

		[Token(Token = "0x400216D")]
		[FieldOffset(Offset = "0x68")]
		private int[] _enemyCost;

		[Token(Token = "0x400216E")]
		[FieldOffset(Offset = "0x70")]
		private bool[] _playerSourceMarks;

		[Token(Token = "0x400216F")]
		[FieldOffset(Offset = "0x78")]
		private bool[] _enemySourceMarks;

		[Token(Token = "0x4002170")]
		[FieldOffset(Offset = "0x80")]
		private int[] _heapIndex;

		[Token(Token = "0x4002171")]
		[FieldOffset(Offset = "0x88")]
		private int[] _heapCost;

		[Token(Token = "0x4002172")]
		[FieldOffset(Offset = "0x90")]
		private int _heapCount;

		[Token(Token = "0x4002173")]
		[FieldOffset(Offset = "0x94")]
		private bool _graphDirty;

		[Token(Token = "0x4002174")]
		[FieldOffset(Offset = "0x95")]
		private bool _playerDirty;

		[Token(Token = "0x4002175")]
		[FieldOffset(Offset = "0x96")]
		private bool _enemyDirty;

		[Token(Token = "0x170000D7")]
		public int HexCount
		{
			[Token(Token = "0x6000C02")]
			[Address(RVA = "0x3D32500", Offset = "0x3D2E500", VA = "0x3D32500")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000C03")]
		[Address(RVA = "0x3D330F4", Offset = "0x3D2F0F4", VA = "0x3D330F4")]
		public void Initialize(BattleGameSceneManager scene)
		{
		}

		[Token(Token = "0x6000C04")]
		[Address(RVA = "0x3D33120", Offset = "0x3D2F120", VA = "0x3D33120")]
		public void MarkDirty()
		{
		}

		[Token(Token = "0x6000C05")]
		[Address(RVA = "0x3D3310C", Offset = "0x3D2F10C", VA = "0x3D3310C")]
		public void MarkGraphDirty()
		{
		}

		[Token(Token = "0x6000C06")]
		[Address(RVA = "0x3D33134", Offset = "0x3D2F134", VA = "0x3D33134")]
		public void MarkAllFieldsDirty()
		{
		}

		[Token(Token = "0x6000C07")]
		[Address(RVA = "0x3D33158", Offset = "0x3D2F158", VA = "0x3D33158")]
		public void MarkTargetFieldDirty(bool targetIsEnemy)
		{
		}

		[Token(Token = "0x6000C08")]
		[Address(RVA = "0x3D33140", Offset = "0x3D2F140", VA = "0x3D33140")]
		private void MarkOwnerFieldDirty(bool ownerIsEnemy)
		{
		}

		[Token(Token = "0x6000C09")]
		[Address(RVA = "0x3D33170", Offset = "0x3D2F170", VA = "0x3D33170")]
		public bool TryGetNextHex(bool ownerIsEnemy, HexBehaviour currentHex, out HexBehaviour nextHex)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WebGLHexPathField.TryGetNextHex RVA=0x3D33170 Token=0x6000C09");
}

		[Token(Token = "0x6000C0A")]
		[Address(RVA = "0x3D3347C", Offset = "0x3D2F47C", VA = "0x3D3347C")]
		public bool TryGetNextHexToTarget(bool ownerIsEnemy, HexBehaviour currentHex, HexBehaviour targetHex, out HexBehaviour nextHex)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WebGLHexPathField.TryGetNextHexToTarget RVA=0x3D3347C Token=0x6000C0A");
}

		[Token(Token = "0x6000C0B")]
		[Address(RVA = "0x3D336DC", Offset = "0x3D2F6DC", VA = "0x3D336DC")]
		public bool TryCollectRemainingPath(bool ownerIsEnemy, HexBehaviour currentHex, List<Vector3> result, int maxPoints)
		{
			return default;
		}

		[Token(Token = "0x6000C0C")]
		[Address(RVA = "0x3D338B0", Offset = "0x3D2F8B0", VA = "0x3D338B0")]
		public bool TryCollectPathToTarget(bool ownerIsEnemy, HexBehaviour currentHex, HexBehaviour targetHex, List<Vector3> result, int maxPoints)
		{
			return default;
		}

		[Token(Token = "0x6000C0D")]
		[Address(RVA = "0x3D32AC4", Offset = "0x3D2EAC4", VA = "0x3D32AC4")]
		internal int GetNeighborIndex(int index, int neighborOffset)
		{
			return default;
		}

		[Token(Token = "0x6000C0E")]
		[Address(RVA = "0x3D32CF4", Offset = "0x3D2ECF4", VA = "0x3D32CF4")]
		internal bool IsEdgeWallBlocked(bool ownerIsEnemy, int index, int neighborOffset)
		{
			return default;
		}

		[Token(Token = "0x6000C0F")]
		[Address(RVA = "0x3D32F58", Offset = "0x3D2EF58", VA = "0x3D32F58")]
		internal Vector3 GetHexPosition(int index)
		{
			return default;
		}

		[Token(Token = "0x6000C10")]
		[Address(RVA = "0x3D33A18", Offset = "0x3D2FA18", VA = "0x3D33A18")]
		internal int GetFlowCostAtPosition(bool ownerIsEnemy, Vector3 worldPos)
		{
			return default;
		}

		[Token(Token = "0x6000C11")]
		[Address(RVA = "0x3D33BA0", Offset = "0x3D2FBA0", VA = "0x3D33BA0")]
		internal int GetFlowCost(bool ownerIsEnemy, HexBehaviour hex)
		{
			return default;
		}

		[Token(Token = "0x6000C12")]
		[Address(RVA = "0x3D32C04", Offset = "0x3D2EC04", VA = "0x3D32C04")]
		internal int GetTraversalCost(bool ownerIsEnemy, int index, int targetIndex)
		{
			return default;
		}

		[Token(Token = "0x6000C13")]
		[Address(RVA = "0x3D32B0C", Offset = "0x3D2EB0C", VA = "0x3D32B0C")]
		internal bool CanUseHexForAStar(bool ownerIsEnemy, int index, int startIndex, int targetIndex)
		{
			return default;
		}

		[Token(Token = "0x6000C14")]
		[Address(RVA = "0x3D32700", Offset = "0x3D2E700", VA = "0x3D32700")]
		internal int GetHeuristic(int a, int b)
		{
			return default;
		}

		[Token(Token = "0x6000C15")]
		[Address(RVA = "0x3D332AC", Offset = "0x3D2F2AC", VA = "0x3D332AC")]
		private bool EnsureField(bool ownerIsEnemy)
		{
			return default;
		}

		[Token(Token = "0x6000C16")]
		[Address(RVA = "0x3D33610", Offset = "0x3D2F610", VA = "0x3D33610")]
		private bool EnsureGraph()
		{
			return default;
		}

		[Token(Token = "0x6000C17")]
		[Address(RVA = "0x3D33304", Offset = "0x3D2F304", VA = "0x3D33304")]
		private bool TryGetNextIndex(bool ownerIsEnemy, int index, out int nextIndex)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WebGLHexPathField.TryGetNextIndex RVA=0x3D33304 Token=0x6000C17");
}

		[Token(Token = "0x6000C18")]
		[Address(RVA = "0x3D33F98", Offset = "0x3D2FF98", VA = "0x3D33F98")]
		private void BuildGraph()
		{
		}

		[Token(Token = "0x6000C19")]
		[Address(RVA = "0x3D33CB0", Offset = "0x3D2FCB0", VA = "0x3D33CB0")]
		private void RebuildField(bool ownerIsEnemy)
		{
		}

		[Token(Token = "0x6000C1A")]
		[Address(RVA = "0x3D34AB0", Offset = "0x3D30AB0", VA = "0x3D34AB0")]
		private void AddArchitectureSources(bool targetIsEnemy, int[] cost, int[] next, bool[] sourceMarks)
		{
		}

		[Token(Token = "0x6000C1B")]
		[Address(RVA = "0x3D34C80", Offset = "0x3D30C80", VA = "0x3D34C80")]
		private void AddMainTowerSource(bool targetIsEnemy, int[] cost, int[] next, bool[] sourceMarks)
		{
		}

		[Token(Token = "0x6000C1C")]
		[Address(RVA = "0x3D351D4", Offset = "0x3D311D4", VA = "0x3D351D4")]
		private void AddSource(HexBehaviour hex, int[] cost, int[] next, bool[] sourceMarks)
		{
		}

		[Token(Token = "0x6000C1D")]
		[Address(RVA = "0x3D352B4", Offset = "0x3D312B4", VA = "0x3D352B4")]
		private void AddSource(int index, int[] cost, int[] next, bool[] sourceMarks)
		{
		}

		[Token(Token = "0x6000C1E")]
		[Address(RVA = "0x3D34EF8", Offset = "0x3D30EF8", VA = "0x3D34EF8")]
		private bool CanUseHexForField(bool ownerIsEnemy, int index)
		{
			return default;
		}

		[Token(Token = "0x6000C1F")]
		[Address(RVA = "0x3D34FFC", Offset = "0x3D30FFC", VA = "0x3D34FFC")]
		private int GetFieldEnterCost(bool ownerIsEnemy, int index)
		{
			return default;
		}

		[Token(Token = "0x6000C20")]
		[Address(RVA = "0x3D349F4", Offset = "0x3D309F4", VA = "0x3D349F4")]
		private int GetIndex(HexBehaviour hex)
		{
			return default;
		}

		[Token(Token = "0x6000C21")]
		[Address(RVA = "0x3D33898", Offset = "0x3D2F898", VA = "0x3D33898")]
		private int[] GetNextArray(bool ownerIsEnemy)
		{
			return null;
		}

		[Token(Token = "0x6000C22")]
		[Address(RVA = "0x3D33B88", Offset = "0x3D2FB88", VA = "0x3D33B88")]
		private int[] GetCostArray(bool ownerIsEnemy)
		{
			return null;
		}

		[Token(Token = "0x6000C23")]
		[Address(RVA = "0x3D34878", Offset = "0x3D30878", VA = "0x3D34878")]
		private void EnsureArrays(int count)
		{
		}

		[Token(Token = "0x6000C24")]
		[Address(RVA = "0x3D350F0", Offset = "0x3D310F0", VA = "0x3D350F0")]
		private void PushHeap(int index, int cost)
		{
		}

		[Token(Token = "0x6000C25")]
		[Address(RVA = "0x3D34D94", Offset = "0x3D30D94", VA = "0x3D34D94")]
		private int PopHeap(out int cost)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WebGLHexPathField.PopHeap RVA=0x3D34D94 Token=0x6000C25");
}

		[Token(Token = "0x6000C26")]
		[Address(RVA = "0x3D3532C", Offset = "0x3D3132C", VA = "0x3D3532C")]
		public WebGLHexPathField()
		{
		}
	}
}
