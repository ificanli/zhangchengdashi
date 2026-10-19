using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x2000137")]
	public class ConstantPath : Path
	{
		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public GraphNode startNode;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Vector3 startPoint;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public Vector3 originalStartPoint;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public List<GraphNode> allNodes;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public PathEndingCondition endingCondition;

		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x4560F88", Offset = "0x455CF88", VA = "0x4560F88")]
		public static ConstantPath Construct(Vector3 start, int maxGScore, [Optional] OnPathDelegate callback)
		{
			return null;
		}

		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x4561044", Offset = "0x455D044", VA = "0x4561044")]
		protected void Setup(Vector3 start, int maxGScore, OnPathDelegate callback)
		{
		}

		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x4561124", Offset = "0x455D124", VA = "0x4561124", Slot = "15")]
		protected override void OnEnterPool()
		{
		}

		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x45611B0", Offset = "0x455D1B0", VA = "0x45611B0", Slot = "16")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x456128C", Offset = "0x455D28C", VA = "0x456128C", Slot = "20")]
		protected override void Prepare(ref SearchContext ctx)
		{
		}

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x45614A4", Offset = "0x455D4A4", VA = "0x45614A4", Slot = "22")]
		protected override void OnHeapExhausted(ref SearchContext ctx)
		{
		}

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x45614B0", Offset = "0x455D4B0", VA = "0x45614B0", Slot = "23")]
		protected override void OnFoundEndNode(ref SearchContext ctx, uint pathNode, uint hScore, uint gScore)
		{
		}

		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x45614FC", Offset = "0x455D4FC", VA = "0x45614FC", Slot = "24")]
		public override void OnVisitNode(ref SearchContext ctx, uint pathNode, uint hScore, uint gScore)
		{
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x4561764", Offset = "0x455D764", VA = "0x4561764", Slot = "21")]
		protected override void Cleanup(ref SearchContext ctx)
		{
		}

		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x45618CC", Offset = "0x455D8CC", VA = "0x45618CC")]
		public ConstantPath()
		{
		}
	}
}
