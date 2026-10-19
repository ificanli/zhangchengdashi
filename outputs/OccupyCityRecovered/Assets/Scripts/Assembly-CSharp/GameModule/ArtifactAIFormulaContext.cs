using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x200022E")]
	public class ArtifactAIFormulaContext
	{
		[Token(Token = "0x200022F")]
		public struct UnitSnapshot
		{
			[Token(Token = "0x4001DE6")]
			[FieldOffset(Offset = "0x0")]
			public RoleBehaviour Role;

			[Token(Token = "0x4001DE7")]
			[FieldOffset(Offset = "0x8")]
			public float ValueWeight;

			[Token(Token = "0x4001DE8")]
			[FieldOffset(Offset = "0xC")]
			public HexManager.HexCoord HexCoord;

			[Token(Token = "0x4001DE9")]
			[FieldOffset(Offset = "0x14")]
			public Vector3 Position;

			[Token(Token = "0x4001DEA")]
			[FieldOffset(Offset = "0x20")]
			public float HpPct;

			[Token(Token = "0x4001DEB")]
			[FieldOffset(Offset = "0x24")]
			public bool IsInCombat;

			[Token(Token = "0x4001DEC")]
			[FieldOffset(Offset = "0x25")]
			public bool IsTakingDamage;

			[Token(Token = "0x4001DED")]
			[FieldOffset(Offset = "0x28")]
			public float AtkRange;

			[Token(Token = "0x4001DEE")]
			[FieldOffset(Offset = "0x2C")]
			public int DistanceToPlayerMainTower;

			[Token(Token = "0x4001DEF")]
			[FieldOffset(Offset = "0x30")]
			public int DistanceToEnemyMainTower;

			[Token(Token = "0x4001DF0")]
			[FieldOffset(Offset = "0x34")]
			public int NearestEnemyDistance;

			[Token(Token = "0x170000BA")]
			public bool IsRanged
			{
				[Token(Token = "0x6000952")]
				[Address(RVA = "0x428F584", Offset = "0x428B584", VA = "0x428F584")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000953")]
			[Address(RVA = "0x428F1F0", Offset = "0x428B1F0", VA = "0x428F1F0")]
			public static UnitSnapshot From(RoleBehaviour role)
			{
				return default;
			}
		}

		[Token(Token = "0x2000230")]
		public struct BuildingSnapshot
		{
			[Token(Token = "0x4001DF1")]
			[FieldOffset(Offset = "0x0")]
			public ArchitectureBehaviour Building;

			[Token(Token = "0x4001DF2")]
			[FieldOffset(Offset = "0x8")]
			public HexManager.HexCoord HexCoord;

			[Token(Token = "0x4001DF3")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 Position;

			[Token(Token = "0x4001DF4")]
			[FieldOffset(Offset = "0x1C")]
			public bool IsAttacked;

			[Token(Token = "0x4001DF5")]
			[FieldOffset(Offset = "0x20")]
			public float HpPct;

			[Token(Token = "0x6000954")]
			[Address(RVA = "0x428F3F0", Offset = "0x428B3F0", VA = "0x428F3F0")]
			public static BuildingSnapshot From(ArchitectureBehaviour building)
			{
				return default;
			}
		}

		[Token(Token = "0x170000B4")]
		public List<UnitSnapshot> AllyUnits
		{
			[Token(Token = "0x600093C")]
			[Address(RVA = "0x428E2C0", Offset = "0x428A2C0", VA = "0x428E2C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600093D")]
			[Address(RVA = "0x428E2C8", Offset = "0x428A2C8", VA = "0x428E2C8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		public List<UnitSnapshot> EnemyUnits
		{
			[Token(Token = "0x600093E")]
			[Address(RVA = "0x428E2D0", Offset = "0x428A2D0", VA = "0x428E2D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600093F")]
			[Address(RVA = "0x428E2D8", Offset = "0x428A2D8", VA = "0x428E2D8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		public List<BuildingSnapshot> AllyBuildings
		{
			[Token(Token = "0x6000940")]
			[Address(RVA = "0x428E2E0", Offset = "0x428A2E0", VA = "0x428E2E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000941")]
			[Address(RVA = "0x428E2E8", Offset = "0x428A2E8", VA = "0x428E2E8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000B7")]
		public List<BuildingSnapshot> EnemyBuildings
		{
			[Token(Token = "0x6000942")]
			[Address(RVA = "0x428E2F0", Offset = "0x428A2F0", VA = "0x428E2F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000943")]
			[Address(RVA = "0x428E2F8", Offset = "0x428A2F8", VA = "0x428E2F8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000B8")]
		public HexManager.HexCoord? PlayerMainTowerHex
		{
			[Token(Token = "0x6000944")]
			[Address(RVA = "0x428E300", Offset = "0x428A300", VA = "0x428E300")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000945")]
			[Address(RVA = "0x428E310", Offset = "0x428A310", VA = "0x428E310")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		public HexManager.HexCoord? EnemyMainTowerHex
		{
			[Token(Token = "0x6000946")]
			[Address(RVA = "0x428E31C", Offset = "0x428A31C", VA = "0x428E31C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000947")]
			[Address(RVA = "0x428E32C", Offset = "0x428A32C", VA = "0x428E32C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0x428E338", Offset = "0x428A338", VA = "0x428E338")]
		public static ArtifactAIFormulaContext Build()
		{
			return null;
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0x428EAD8", Offset = "0x428AAD8", VA = "0x428EAD8")]
		public static float GetValueWeight(RareLevel rareLevel)
		{
			return default;
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0x428EAFC", Offset = "0x428AAFC", VA = "0x428EAFC")]
		public List<UnitSnapshot> GetUnitsInRadius(Vector3 centerWorldPos, int radiusHex, bool ally)
		{
			return null;
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0x428EB9C", Offset = "0x428AB9C", VA = "0x428EB9C")]
		public List<UnitSnapshot> GetUnitsInRadius(HexManager.HexCoord centerHex, int radiusHex, bool ally)
		{
			return null;
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0x428EDD0", Offset = "0x428ADD0", VA = "0x428EDD0")]
		public List<UnitSnapshot> GetAllUnitsInRadius(HexManager.HexCoord centerHex, int radiusHex)
		{
			return null;
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0x428F128", Offset = "0x428B128", VA = "0x428F128")]
		public int GetEnemyCountNearEnemy(UnitSnapshot enemyUnit)
		{
			return default;
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0x428E494", Offset = "0x428A494", VA = "0x428E494")]
		private static List<UnitSnapshot> FilterAndMap(List<RoleBehaviour> list)
		{
			return null;
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0x428E698", Offset = "0x428A698", VA = "0x428E698")]
		private static List<BuildingSnapshot> FilterAndMapBuildings(List<ArchitectureBehaviour> list)
		{
			return null;
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0x428E878", Offset = "0x428A878", VA = "0x428E878")]
		private static void PopulateUnitDerivedData(List<UnitSnapshot> source, HexManager.HexCoord? playerMainTowerHex, HexManager.HexCoord? enemyMainTowerHex, List<UnitSnapshot> oppositeUnits)
		{
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0x428E48C", Offset = "0x428A48C", VA = "0x428E48C")]
		public ArtifactAIFormulaContext()
		{
		}
	}
}
