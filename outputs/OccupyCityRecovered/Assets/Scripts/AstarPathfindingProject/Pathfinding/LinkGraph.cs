using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding.Drawing;
using Pathfinding.Serialization;
using Pathfinding.Util;
using Unity.Jobs;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x20000D8")]
	[JsonOptIn]
	[Preserve]
	public class LinkGraph : NavGraph
	{
		[Token(Token = "0x20000D9")]
		private class LinkGraphUpdatePromise : IGraphUpdatePromise
		{
			[Token(Token = "0x40004B0")]
			[FieldOffset(Offset = "0x10")]
			public LinkGraph graph;

			[Token(Token = "0x6000738")]
			[Address(RVA = "0x452D95C", Offset = "0x452995C", VA = "0x452D95C", Slot = "6")]
			public void Apply(IGraphUpdateContext ctx)
			{
			}

			[Token(Token = "0x6000739")]
			[Address(RVA = "0x452D980", Offset = "0x4529980", VA = "0x452D980", Slot = "5")]
			public IEnumerator<JobHandle> Prepare()
			{
				return null;
			}

			[Token(Token = "0x600073A")]
			[Address(RVA = "0x452D8E4", Offset = "0x45298E4", VA = "0x452D8E4")]
			public LinkGraphUpdatePromise()
			{
			}
		}

		[Token(Token = "0x40004AE")]
		[FieldOffset(Offset = "0x50")]
		private LinkNode[] nodes;

		[Token(Token = "0x40004AF")]
		[FieldOffset(Offset = "0x58")]
		private int nodeCount;

		[Token(Token = "0x17000163")]
		public override bool isScanned
		{
			[Token(Token = "0x600072B")]
			[Address(RVA = "0x452D13C", Offset = "0x452913C", VA = "0x452D13C", Slot = "13")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000164")]
		public override bool persistent
		{
			[Token(Token = "0x600072C")]
			[Address(RVA = "0x452D144", Offset = "0x4529144", VA = "0x452D144", Slot = "14")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000165")]
		public override bool showInInspector
		{
			[Token(Token = "0x600072D")]
			[Address(RVA = "0x452D14C", Offset = "0x452914C", VA = "0x452D14C", Slot = "15")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x452D154", Offset = "0x4529154", VA = "0x452D154", Slot = "17")]
		public override int CountNodes()
		{
			return default;
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x452D15C", Offset = "0x452915C", VA = "0x452D15C", Slot = "28")]
		protected override void DestroyAllNodes()
		{
		}

		[Token(Token = "0x6000730")]
		public override void GetNodes<T>(GraphNode.NodeActionWithData<T> action, ref T data)
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x452D2A4", Offset = "0x45292A4", VA = "0x452D2A4")]
		internal LinkNode AddNode()
		{
			return null;
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x452D3E4", Offset = "0x45293E4", VA = "0x452D3E4")]
		internal void RemoveNode(LinkNode node)
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x452D524", Offset = "0x4529524", VA = "0x452D524", Slot = "23")]
		public override float NearestNodeDistanceSqrLowerBound(Vector3 position, ref NearestNodeConstraint constraint)
		{
			return default;
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x452D530", Offset = "0x4529530", VA = "0x452D530", Slot = "24")]
		public override NNInfo GetNearest(Vector3 position, ref NearestNodeConstraint constraint)
		{
			return default;
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x452D53C", Offset = "0x452953C", VA = "0x452D53C", Slot = "35")]
		public override void OnDrawGizmos(DrawingData gizmos, bool drawNodes, RedrawScope redrawScope, bool renderInGame)
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x452D880", Offset = "0x4529880", VA = "0x452D880", Slot = "30")]
		protected override IGraphUpdatePromise ScanInternal()
		{
			return null;
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x452D8EC", Offset = "0x45298EC", VA = "0x452D8EC")]
		public LinkGraph()
		{
		}
	}
}
