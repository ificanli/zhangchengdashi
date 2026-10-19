using Il2CppDummyDll;
using Pathfinding.Serialization;
using Pathfinding.Util;
using Unity.Jobs;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x20000D6")]
	[Preserve]
	public class LayerGridGraph : GridGraph, IUpdatableGraph
	{
		[Token(Token = "0x40004A8")]
		[FieldOffset(Offset = "0x1B8")]
		[JsonMember]
		internal int layerCount;

		[Token(Token = "0x40004A9")]
		[FieldOffset(Offset = "0x1BC")]
		[JsonMember]
		public float characterHeight;

		[Token(Token = "0x40004AA")]
		[FieldOffset(Offset = "0x1C0")]
		internal int lastScannedWidth;

		[Token(Token = "0x40004AB")]
		[FieldOffset(Offset = "0x1C4")]
		internal int lastScannedDepth;

		[Token(Token = "0x17000161")]
		public override int LayerCount
		{
			[Token(Token = "0x600071C")]
			[Address(RVA = "0x452C5E0", Offset = "0x45285E0", VA = "0x452C5E0", Slot = "48")]
			get
			{
				return default;
			}
			[Token(Token = "0x600071D")]
			[Address(RVA = "0x452C5E8", Offset = "0x45285E8", VA = "0x452C5E8", Slot = "49")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000162")]
		public override int MaxLayers
		{
			[Token(Token = "0x600071E")]
			[Address(RVA = "0x452C5F0", Offset = "0x45285F0", VA = "0x452C5F0", Slot = "50")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x452C3C0", Offset = "0x45283C0", VA = "0x452C3C0", Slot = "27")]
		protected override void DisposeUnmanagedData()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x452C42C", Offset = "0x452842C", VA = "0x452C42C")]
		public LayerGridGraph()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x452C53C", Offset = "0x452853C", VA = "0x452C53C", Slot = "51")]
		protected override GridNodeBase[] AllocateNodesJob(int size, out JobHandle dependency)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED LayerGridGraph.AllocateNodesJob RVA=0x452C53C Token=0x600071B");
}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x452C5F8", Offset = "0x45285F8", VA = "0x452C5F8", Slot = "17")]
		public override int CountNodes()
		{
			return default;
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x452C658", Offset = "0x4528658", VA = "0x452C658", Slot = "57")]
		public override int GetNodesInRegion(IntRect rect, GridNodeBase[] buffer)
		{
			return default;
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x452C8D4", Offset = "0x45288D4", VA = "0x452C8D4")]
		public GridNodeBase GetNode(int x, int z, int layer)
		{
			return null;
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x452C94C", Offset = "0x452894C", VA = "0x452C94C", Slot = "31")]
		protected override IGraphUpdatePromise ScanInternal(bool async)
		{
			return null;
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x452C9D4", Offset = "0x45289D4", VA = "0x452C9D4", Slot = "52")]
		protected override GridNodeBase GetNearestFromGraphSpace(Vector3 positionGraphSpace)
		{
			return null;
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x452CA8C", Offset = "0x4528A8C", VA = "0x452CA8C")]
		private GridNodeBase GetNearestNode(Vector3 position, int x, int z)
		{
			return null;
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x452CB5C", Offset = "0x4528B5C", VA = "0x452CB5C", Slot = "32")]
		protected override void SerializeExtraInfo(GraphSerializationContext ctx)
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x452CC74", Offset = "0x4528C74", VA = "0x452CC74", Slot = "33")]
		protected override void DeserializeExtraInfo(GraphSerializationContext ctx)
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x452CE80", Offset = "0x4528E80", VA = "0x452CE80", Slot = "34")]
		protected override void PostDeserialization(GraphSerializationContext ctx)
		{
		}
	}
}
