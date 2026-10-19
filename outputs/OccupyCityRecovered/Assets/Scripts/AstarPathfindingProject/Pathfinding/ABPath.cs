using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x2000136")]
	public class ABPath : Path
	{
		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Vector3 originalStartPoint;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public Vector3 originalEndPoint;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Vector3 startPoint;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public Vector3 endPoint;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public uint cost;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public bool calculatePartial;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		protected uint partialBestTargetPathNodeIndex;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		protected uint partialBestTargetHScore;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected uint partialBestTargetGScore;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public PathEndingCondition endingCondition;

		[Token(Token = "0x170001CC")]
		public GraphNode startNode
		{
			[Token(Token = "0x6000A0A")]
			[Address(RVA = "0x455F84C", Offset = "0x455B84C", VA = "0x455F84C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001CD")]
		public GraphNode endNode
		{
			[Token(Token = "0x6000A0B")]
			[Address(RVA = "0x455F8C8", Offset = "0x455B8C8", VA = "0x455F8C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001CE")]
		protected virtual bool hasEndPoint
		{
			[Token(Token = "0x6000A0C")]
			[Address(RVA = "0x455F940", Offset = "0x455B940", VA = "0x455F940", Slot = "26")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001CF")]
		public virtual bool endPointKnownBeforeCalculation
		{
			[Token(Token = "0x6000A0D")]
			[Address(RVA = "0x455F948", Offset = "0x455B948", VA = "0x455F948", Slot = "27")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x455F950", Offset = "0x455B950", VA = "0x455F950")]
		public ABPath()
		{
		}

		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x455F9B0", Offset = "0x455B9B0", VA = "0x455F9B0")]
		public static ABPath Construct(Vector3 start, Vector3 end, [Optional] OnPathDelegate callback)
		{
			return null;
		}

		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x455FA70", Offset = "0x455BA70", VA = "0x455FA70")]
		protected void Setup(Vector3 start, Vector3 end, OnPathDelegate callbackDelegate)
		{
		}

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x455FAAC", Offset = "0x455BAAC", VA = "0x455FAAC")]
		public static ABPath FakePath(List<Vector3> vectorPath, [Optional] List<GraphNode> nodePath)
		{
			return null;
		}

		[Token(Token = "0x6000A12")]
		[Address(RVA = "0x455FA90", Offset = "0x455BA90", VA = "0x455FA90")]
		protected void UpdateStartEnd(Vector3 start, Vector3 end)
		{
		}

		[Token(Token = "0x6000A13")]
		[Address(RVA = "0x455FDB0", Offset = "0x455BDB0", VA = "0x455FDB0", Slot = "16")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0x455FE68", Offset = "0x455BE68", VA = "0x455FE68", Slot = "28")]
		protected virtual bool EndPointGridGraphSpecialCase(ref SearchContext ctx, GraphNode closestWalkableEndNode, Vector3 originalEndPoint, int targetIndex)
		{
			return default;
		}

		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x45602B8", Offset = "0x455C2B8", VA = "0x45602B8")]
		private void AddEndpointsForSurroundingGridNodes(ref SearchContext ctx, GridNode gridNode, Vector3 desiredPoint, int targetIndex)
		{
		}

		[Token(Token = "0x6000A16")]
		[Address(RVA = "0x456059C", Offset = "0x455C59C", VA = "0x456059C", Slot = "20")]
		protected override void Prepare(ref SearchContext ctx)
		{
		}

		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x45605F8", Offset = "0x455C5F8", VA = "0x45605F8")]
		protected void FindStartAndEndNodes(ref SearchContext ctx, ref NearestNodeConstraint constraint)
		{
		}

		[Token(Token = "0x6000A18")]
		[Address(RVA = "0x45609B8", Offset = "0x455C9B8", VA = "0x45609B8")]
		private void CompletePartial(ref SearchContext ctx)
		{
		}

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x4560A3C", Offset = "0x455CA3C", VA = "0x4560A3C", Slot = "22")]
		protected override void OnHeapExhausted(ref SearchContext ctx)
		{
		}

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x4560AB0", Offset = "0x455CAB0", VA = "0x4560AB0", Slot = "23")]
		protected override void OnFoundEndNode(ref SearchContext ctx, uint pathNode, uint hScore, uint gScore)
		{
		}

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x4560C30", Offset = "0x455CC30", VA = "0x4560C30", Slot = "24")]
		public override void OnVisitNode(ref SearchContext ctx, uint pathNode, uint hScore, uint gScore)
		{
		}

		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x4560CF4", Offset = "0x455CCF4", VA = "0x4560CF4", Slot = "18")]
		protected override void DebugString(StringBuilder builder, PathLog logMode)
		{
		}
	}
}
