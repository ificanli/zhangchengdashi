using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding.Collections;
using Pathfinding.Serialization;
using UnityEngine;
using UnityEngine.Serialization;

namespace Pathfinding
{
	[Token(Token = "0x2000111")]
	[AddComponentMenu("Pathfinding/Navmesh/RecastNavmeshModifier")]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/recastnavmeshmodifier.html")]
	[DisallowMultipleComponent]
	public class RecastNavmeshModifier : VersionedMonoBehaviour, RecastMeshObj
	{
		[Token(Token = "0x2000112")]
		public enum ScanInclusion
		{
			[Token(Token = "0x40005D9")]
			Auto = 0,
			[Token(Token = "0x40005DA")]
			AlwaysExclude = 1,
			[Token(Token = "0x40005DB")]
			AlwaysInclude = 2
		}

		[Token(Token = "0x2000113")]
		public enum GeometrySource
		{
			[Token(Token = "0x40005DD")]
			Auto = 0,
			[Token(Token = "0x40005DE")]
			MeshFilter = 1,
			[Token(Token = "0x40005DF")]
			Collider = 2
		}

		[Token(Token = "0x2000114")]
		public enum Mode
		{
			[Token(Token = "0x40005E1")]
			UnwalkableSurface = 1,
			[Token(Token = "0x40005E2")]
			WalkableSurface = 2,
			[Token(Token = "0x40005E3")]
			WalkableSurfaceWithSeam = 3,
			[Token(Token = "0x40005E4")]
			WalkableSurfaceWithTag = 4
		}

		[Token(Token = "0x40005D0")]
		[FieldOffset(Offset = "0x0")]
		protected static AABBTree<RecastNavmeshModifier> tree;

		[Token(Token = "0x40005D1")]
		[FieldOffset(Offset = "0x28")]
		public bool dynamic;

		[Token(Token = "0x40005D2")]
		[FieldOffset(Offset = "0x29")]
		public bool solid;

		[Token(Token = "0x40005D3")]
		[FieldOffset(Offset = "0x2C")]
		public GeometrySource geometrySource;

		[Token(Token = "0x40005D4")]
		[FieldOffset(Offset = "0x30")]
		public ScanInclusion includeInScan;

		[Token(Token = "0x40005D5")]
		[FieldOffset(Offset = "0x34")]
		[FormerlySerializedAs("area")]
		public int surfaceID;

		[Token(Token = "0x40005D6")]
		[FieldOffset(Offset = "0x38")]
		public Mode mode;

		[Token(Token = "0x40005D7")]
		[FieldOffset(Offset = "0x3C")]
		private AABBTree<RecastNavmeshModifier>.Key treeKey;

		[Token(Token = "0x170001B0")]
		[Obsolete("Use mode and surfaceID instead")]
		public int area
		{
			[Token(Token = "0x600094B")]
			[Address(RVA = "0x454EBD8", Offset = "0x454ABD8", VA = "0x454EBD8")]
			get
			{
				return default;
			}
			[Token(Token = "0x600094C")]
			[Address(RVA = "0x454EC18", Offset = "0x454AC18", VA = "0x454EC18")]
			set
			{
			}
		}

		[Token(Token = "0x170001B1")]
bool RecastMeshObj.dynamic
		{
			[Token(Token = "0x6000954")]
			[Address(RVA = "0x454FB00", Offset = "0x454BB00", VA = "0x454FB00", Slot = "17")]
			get
			{
				return Pathfinding_002ERecastMeshObj_002Eget_dynamic();
			}
			[Token(Token = "0x6000955")]
			[Address(RVA = "0x454FB08", Offset = "0x454BB08", VA = "0x454FB08", Slot = "18")]
			set
			{
				Pathfinding_002ERecastMeshObj_002Eset_dynamic(value);
			}
		}

		[Token(Token = "0x170001B2")]
bool RecastMeshObj.solid
		{
			[Token(Token = "0x6000956")]
			[Address(RVA = "0x454FB14", Offset = "0x454BB14", VA = "0x454FB14", Slot = "19")]
			get
			{
				return Pathfinding_002ERecastMeshObj_002Eget_solid();
			}
			[Token(Token = "0x6000957")]
			[Address(RVA = "0x454FB1C", Offset = "0x454BB1C", VA = "0x454FB1C", Slot = "20")]
			set
			{
				Pathfinding_002ERecastMeshObj_002Eset_solid(value);
			}
		}

		[Token(Token = "0x170001B3")]
GeometrySource RecastMeshObj.geometrySource
		{
			[Token(Token = "0x6000958")]
			[Address(RVA = "0x454FB28", Offset = "0x454BB28", VA = "0x454FB28", Slot = "21")]
			get
			{
				return Pathfinding_002ERecastMeshObj_002Eget_geometrySource();
			}
			[Token(Token = "0x6000959")]
			[Address(RVA = "0x454FB30", Offset = "0x454BB30", VA = "0x454FB30", Slot = "22")]
			set
			{
				Pathfinding_002ERecastMeshObj_002Eset_geometrySource(value);
			}
		}

		[Token(Token = "0x170001B4")]
ScanInclusion RecastMeshObj.includeInScan
		{
			[Token(Token = "0x600095A")]
			[Address(RVA = "0x454FB38", Offset = "0x454BB38", VA = "0x454FB38", Slot = "23")]
			get
			{
				return Pathfinding_002ERecastMeshObj_002Eget_includeInScan();
			}
			[Token(Token = "0x600095B")]
			[Address(RVA = "0x454FB40", Offset = "0x454BB40", VA = "0x454FB40", Slot = "24")]
			set
			{
				Pathfinding_002ERecastMeshObj_002Eset_includeInScan(value);
			}
		}

		[Token(Token = "0x170001B5")]
int RecastMeshObj.surfaceID
		{
			[Token(Token = "0x600095C")]
			[Address(RVA = "0x454FB48", Offset = "0x454BB48", VA = "0x454FB48", Slot = "25")]
			get
			{
				return Pathfinding_002ERecastMeshObj_002Eget_surfaceID();
			}
			[Token(Token = "0x600095D")]
			[Address(RVA = "0x454FB50", Offset = "0x454BB50", VA = "0x454FB50", Slot = "26")]
			set
			{
				Pathfinding_002ERecastMeshObj_002Eset_surfaceID(value);
			}
		}

		[Token(Token = "0x170001B6")]
Mode RecastMeshObj.mode
		{
			[Token(Token = "0x600095E")]
			[Address(RVA = "0x454FB58", Offset = "0x454BB58", VA = "0x454FB58", Slot = "27")]
			get
			{
				return Pathfinding_002ERecastMeshObj_002Eget_mode();
			}
			[Token(Token = "0x600095F")]
			[Address(RVA = "0x454FB60", Offset = "0x454BB60", VA = "0x454FB60", Slot = "28")]
			set
			{
				Pathfinding_002ERecastMeshObj_002Eset_mode(value);
			}
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0x454EC40", Offset = "0x454AC40", VA = "0x454EC40")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0x454F040", Offset = "0x454B040", VA = "0x454F040")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0x454F34C", Offset = "0x454B34C", VA = "0x454F34C")]
		private static void OnUpdate(RecastNavmeshModifier[] components, int _)
		{
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0x454F594", Offset = "0x454B594", VA = "0x454F594")]
		public static void GetAllInBounds(List<RecastNavmeshModifier> buffer, Bounds bounds)
		{
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0x454F8D0", Offset = "0x454B8D0", VA = "0x454F8D0")]
		public void ResolveMeshSource(out MeshFilter meshFilter, out Collider collider, out Collider2D collider2D)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RecastNavmeshModifier.ResolveMeshSource RVA=0x454F8D0 Token=0x6000951");
}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0x454EDCC", Offset = "0x454ADCC", VA = "0x454EDCC")]
		private Bounds CalculateBounds()
		{
			return default;
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0x454FA78", Offset = "0x454BA78", VA = "0x454FA78", Slot = "14")]
		protected override void OnUpgradeSerializedData(ref Migrations migrations, bool unityThread)
		{
		}

		[Token(Token = "0x6000954")]
		[Address(RVA = "0x454FB00", Offset = "0x454BB00", VA = "0x454FB00", Slot = "17")]
		private bool Pathfinding_002ERecastMeshObj_002Eget_dynamic()
		{
			return default;
		}

		[Token(Token = "0x6000955")]
		[Address(RVA = "0x454FB08", Offset = "0x454BB08", VA = "0x454FB08", Slot = "18")]
		private void Pathfinding_002ERecastMeshObj_002Eset_dynamic(bool value)
		{
		}

		[Token(Token = "0x6000956")]
		[Address(RVA = "0x454FB14", Offset = "0x454BB14", VA = "0x454FB14", Slot = "19")]
		private bool Pathfinding_002ERecastMeshObj_002Eget_solid()
		{
			return default;
		}

		[Token(Token = "0x6000957")]
		[Address(RVA = "0x454FB1C", Offset = "0x454BB1C", VA = "0x454FB1C", Slot = "20")]
		private void Pathfinding_002ERecastMeshObj_002Eset_solid(bool value)
		{
		}

		[Token(Token = "0x6000958")]
		[Address(RVA = "0x454FB28", Offset = "0x454BB28", VA = "0x454FB28", Slot = "21")]
		private GeometrySource Pathfinding_002ERecastMeshObj_002Eget_geometrySource()
		{
			return default;
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0x454FB30", Offset = "0x454BB30", VA = "0x454FB30", Slot = "22")]
		private void Pathfinding_002ERecastMeshObj_002Eset_geometrySource(GeometrySource value)
		{
		}

		[Token(Token = "0x600095A")]
		[Address(RVA = "0x454FB38", Offset = "0x454BB38", VA = "0x454FB38", Slot = "23")]
		private ScanInclusion Pathfinding_002ERecastMeshObj_002Eget_includeInScan()
		{
			return default;
		}

		[Token(Token = "0x600095B")]
		[Address(RVA = "0x454FB40", Offset = "0x454BB40", VA = "0x454FB40", Slot = "24")]
		private void Pathfinding_002ERecastMeshObj_002Eset_includeInScan(ScanInclusion value)
		{
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0x454FB48", Offset = "0x454BB48", VA = "0x454FB48", Slot = "25")]
		private int Pathfinding_002ERecastMeshObj_002Eget_surfaceID()
		{
			return default;
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0x454FB50", Offset = "0x454BB50", VA = "0x454FB50", Slot = "26")]
		private void Pathfinding_002ERecastMeshObj_002Eset_surfaceID(int value)
		{
		}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0x454FB58", Offset = "0x454BB58", VA = "0x454FB58", Slot = "27")]
		private Mode Pathfinding_002ERecastMeshObj_002Eget_mode()
		{
			return default;
		}

		[Token(Token = "0x600095F")]
		[Address(RVA = "0x454FB60", Offset = "0x454BB60", VA = "0x454FB60", Slot = "28")]
		private void Pathfinding_002ERecastMeshObj_002Eset_mode(Mode value)
		{
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0x454FB68", Offset = "0x454BB68", VA = "0x454FB68")]
		public RecastNavmeshModifier()
		{
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0x454FC10", Offset = "0x454BC10", VA = "0x454FC10", Slot = "15")]
		private bool Pathfinding_002ERecastMeshObj_002Eget_enabled()
		{
			return default;
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0x454FC18", Offset = "0x454BC18", VA = "0x454FC18", Slot = "16")]
		private void Pathfinding_002ERecastMeshObj_002Eset_enabled(bool value)
		{
		}
	}
}
