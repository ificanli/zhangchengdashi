using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x200013A")]
	public class FloodPath : Path
	{
		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Vector3 originalStartPoint;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public Vector3 startPoint;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public GraphNode startNode;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public bool saveParents;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		protected Dictionary<uint, uint> parents;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private uint validationHash;

		[Token(Token = "0x40006BA")]
		public const uint TemporaryNodeBit = 2147483648u;

		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x4561A90", Offset = "0x455DA90", VA = "0x4561A90")]
		public bool HasPathTo(GraphNode node)
		{
			return default;
		}

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x4561B64", Offset = "0x455DB64", VA = "0x4561B64")]
		internal bool IsValid(GlobalNodeStorage nodeStorage)
		{
			return default;
		}

		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x4561B88", Offset = "0x455DB88", VA = "0x4561B88")]
		public uint GetParent(uint node)
		{
			return default;
		}

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x4561C00", Offset = "0x455DC00", VA = "0x4561C00")]
		public FloodPath()
		{
		}

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x4561C60", Offset = "0x455DC60", VA = "0x4561C60")]
		public static FloodPath Construct(Vector3 start, [Optional] OnPathDelegate callback)
		{
			return null;
		}

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x4561D24", Offset = "0x455DD24", VA = "0x4561D24")]
		public static FloodPath Construct(GraphNode start, [Optional] OnPathDelegate callback)
		{
			return null;
		}

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x4561D08", Offset = "0x455DD08", VA = "0x4561D08")]
		protected void Setup(Vector3 start, OnPathDelegate callback)
		{
		}

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x4561DFC", Offset = "0x455DDFC", VA = "0x4561DFC")]
		protected void Setup(GraphNode start, OnPathDelegate callback)
		{
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x4561E74", Offset = "0x455DE74", VA = "0x4561E74", Slot = "16")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x4561F58", Offset = "0x455DF58", VA = "0x4561F58", Slot = "20")]
		protected override void Prepare(ref SearchContext ctx)
		{
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x4562208", Offset = "0x455E208", VA = "0x4562208", Slot = "22")]
		protected override void OnHeapExhausted(ref SearchContext ctx)
		{
		}

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x4562214", Offset = "0x455E214", VA = "0x4562214", Slot = "23")]
		protected override void OnFoundEndNode(ref SearchContext ctx, uint pathNode, uint hScore, uint gScore)
		{
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x4562260", Offset = "0x455E260", VA = "0x4562260", Slot = "24")]
		public override void OnVisitNode(ref SearchContext ctx, uint pathNode, uint hScore, uint gScore)
		{
		}
	}
}
