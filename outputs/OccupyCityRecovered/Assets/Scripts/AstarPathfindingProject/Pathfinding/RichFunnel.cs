using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x2000021")]
	public class RichFunnel : RichPathPart
	{
		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<Vector3> left;

		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<Vector3> right;

		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x20")]
		private List<TriangleMeshNode> nodes;

		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 exactStart;

		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 exactEnd;

		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x40")]
		private NavmeshBase graph;

		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x48")]
		private int currentNode;

		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 currentPosition;

		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x58")]
		private int checkForDestroyedNodesCounter;

		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x60")]
		private RichPath path;

		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x68")]
		private int[] triBuffer;

		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x70")]
		public bool funnelSimplification;

		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x0")]
		private static Queue<TriangleMeshNode> navmeshClampQueue;

		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x8")]
		private static List<TriangleMeshNode> navmeshClampList;

		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x10")]
		private static Dictionary<TriangleMeshNode, TriangleMeshNode> navmeshClampDict;

		[Token(Token = "0x170000AF")]
		public TriangleMeshNode CurrentNode
		{
			[Token(Token = "0x600020F")]
			[Address(RVA = "0x4459798", Offset = "0x4455798", VA = "0x4459798")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B0")]
		public float DistanceToEndOfPath
		{
			[Token(Token = "0x6000213")]
			[Address(RVA = "0x4459CA0", Offset = "0x4455CA0", VA = "0x4459CA0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x44595F0", Offset = "0x44555F0", VA = "0x44595F0")]
		public RichFunnel()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x4457FB4", Offset = "0x4453FB4", VA = "0x4457FB4")]
		public RichFunnel Initialize(RichPath path, NavmeshBase graph)
		{
			return null;
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x44596F0", Offset = "0x44556F0", VA = "0x44596F0", Slot = "5")]
		public override void OnEnterPool()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x4458094", Offset = "0x4454094", VA = "0x4458094")]
		public void BuildFunnelCorridor(List<GraphNode> nodes, int start, int end)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x4459808", Offset = "0x4455808", VA = "0x4459808")]
		private void UpdateFunnelCorridor(int splitIndex, List<TriangleMeshNode> prefix)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x4459BEC", Offset = "0x4455BEC", VA = "0x4459BEC")]
		private bool CheckForDestroyedNodes()
		{
			return default;
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x4459D6C", Offset = "0x4455D6C", VA = "0x4459D6C")]
		public Vector3 ClampToNavmesh(Vector3 position)
		{
			return default;
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x44591E0", Offset = "0x44551E0", VA = "0x44591E0")]
		public Vector3 Update(Vector3 position, List<Vector3> buffer, int numCorners, out bool lastCorner, out bool requiresRepath)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RichFunnel.Update RVA=0x44591E0 Token=0x6000215");
}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x4459F04", Offset = "0x4455F04", VA = "0x4459F04")]
		private bool ClampToNavmeshInternal(ref Vector3 position)
		{
			return default;
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x445AEBC", Offset = "0x4456EBC", VA = "0x445AEBC")]
		public void FindWalls(List<Vector3> wallBuffer, float range)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x445AED8", Offset = "0x4456ED8", VA = "0x445AED8")]
		private void FindWalls(int nodeIndex, List<Vector3> wallBuffer, Vector3 position, float range)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x445A500", Offset = "0x4456500", VA = "0x445A500")]
		private bool FindNextCorners(Vector3 origin, int startIndex, List<Vector3> funnelPath, int numCorners, out bool lastCorner)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RichFunnel.FindNextCorners RVA=0x445A500 Token=0x6000219");
}
	}
}
