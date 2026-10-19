using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x200013D")]
	public class MultiTargetPath : ABPath
	{
		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public OnPathDelegate[] callbacks;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public GraphNode[] targetNodes;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		protected int targetNodeCount;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public bool[] targetsFound;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public uint[] targetPathCosts;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public Vector3[] targetPoints;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public Vector3[] originalTargetPoints;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public List<Vector3>[] vectorPaths;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public List<GraphNode>[] nodePaths;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public bool pathsForAll;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		public int chosenTarget;

		[Token(Token = "0x170001D1")]
		public bool inverted
		{
			[Token(Token = "0x6000A43")]
			[Address(RVA = "0x4562BB8", Offset = "0x455EBB8", VA = "0x4562BB8")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000A44")]
			[Address(RVA = "0x4562BC0", Offset = "0x455EBC0", VA = "0x4562BC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x170001D2")]
		public override bool endPointKnownBeforeCalculation
		{
			[Token(Token = "0x6000A45")]
			[Address(RVA = "0x4562BCC", Offset = "0x455EBCC", VA = "0x4562BCC", Slot = "27")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x4562BD4", Offset = "0x455EBD4", VA = "0x4562BD4")]
		public MultiTargetPath()
		{
		}

		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x4562BE8", Offset = "0x455EBE8", VA = "0x4562BE8")]
		public static MultiTargetPath Construct(Vector3[] startPoints, Vector3 target, OnPathDelegate[] callbackDelegates, [Optional] OnPathDelegate callback)
		{
			return null;
		}

		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x4562C08", Offset = "0x455EC08", VA = "0x4562C08")]
		public static MultiTargetPath Construct(Vector3 start, Vector3[] targets, OnPathDelegate[] callbackDelegates, [Optional] OnPathDelegate callback)
		{
			return null;
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x4562CCC", Offset = "0x455ECCC", VA = "0x4562CCC")]
		protected void Setup(Vector3 start, Vector3[] targets, OnPathDelegate[] callbackDelegates, OnPathDelegate callback)
		{
		}

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x4562E8C", Offset = "0x455EE8C", VA = "0x4562E8C", Slot = "16")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x4562EB4", Offset = "0x455EEB4", VA = "0x4562EB4", Slot = "15")]
		protected override void OnEnterPool()
		{
		}

		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x4563014", Offset = "0x455F014", VA = "0x4563014")]
		private void ChooseShortestPath()
		{
		}

		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x45630A0", Offset = "0x455F0A0", VA = "0x45630A0")]
		private void SetPathParametersForReturn(int target)
		{
		}

		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x45631BC", Offset = "0x455F1BC", VA = "0x45631BC", Slot = "19")]
		protected override void ReturnPath()
		{
		}

		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x45633B4", Offset = "0x455F3B4", VA = "0x45633B4")]
		protected void RebuildOpenList(ref SearchContext ctx)
		{
		}

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x45635FC", Offset = "0x455F5FC", VA = "0x45635FC", Slot = "20")]
		protected override void Prepare(ref SearchContext ctx)
		{
		}

		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x4563B54", Offset = "0x455FB54", VA = "0x4563B54")]
		private void RecalculateHTarget(ref SearchContext ctx)
		{
		}

		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x4563C40", Offset = "0x455FC40", VA = "0x4563C40", Slot = "21")]
		protected override void Cleanup(ref SearchContext ctx)
		{
		}

		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x4563C6C", Offset = "0x455FC6C", VA = "0x4563C6C", Slot = "22")]
		protected override void OnHeapExhausted(ref SearchContext ctx)
		{
		}

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x4563C78", Offset = "0x455FC78", VA = "0x4563C78", Slot = "23")]
		protected override void OnFoundEndNode(ref SearchContext ctx, uint pathNode, uint hScore, uint gScore)
		{
		}

		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x4563FB8", Offset = "0x455FFB8", VA = "0x4563FB8", Slot = "17")]
		protected override void Trace(ref SearchContext ctx, uint pathNodeIndex)
		{
		}

		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x4563FCC", Offset = "0x455FFCC", VA = "0x4563FCC", Slot = "18")]
		protected override void DebugString(StringBuilder text, PathLog logMode)
		{
		}
	}
}
