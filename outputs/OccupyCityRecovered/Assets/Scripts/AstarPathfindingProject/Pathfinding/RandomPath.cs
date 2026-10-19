using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x200013E")]
	public class RandomPath : ABPath
	{
		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public int searchLength;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		public int spread;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public float aimStrength;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private uint chosenPathNodeIndex;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private uint chosenPathNodeGScore;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private uint maxGScorePathNodeIndex;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private uint maxGScore;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public Vector3 aim;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private int nodesEvaluatedRep;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private readonly System.Random rnd;

		[Token(Token = "0x170001D3")]
		protected override bool hasEndPoint
		{
			[Token(Token = "0x6000A57")]
			[Address(RVA = "0x456437C", Offset = "0x456037C", VA = "0x456437C", Slot = "26")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001D4")]
		public override bool endPointKnownBeforeCalculation
		{
			[Token(Token = "0x6000A58")]
			[Address(RVA = "0x4564384", Offset = "0x4560384", VA = "0x4564384", Slot = "27")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x456438C", Offset = "0x456038C", VA = "0x456438C", Slot = "16")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x456440C", Offset = "0x456040C", VA = "0x456440C")]
		public RandomPath()
		{
		}

		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x4564474", Offset = "0x4560474", VA = "0x4564474")]
		public static RandomPath Construct(Vector3 start, int length, [Optional] OnPathDelegate callback)
		{
			return null;
		}

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x4564524", Offset = "0x4560524", VA = "0x4564524")]
		protected RandomPath Setup(Vector3 start, int length, OnPathDelegate callback)
		{
			return null;
		}

		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x45645C4", Offset = "0x45605C4", VA = "0x45645C4", Slot = "19")]
		protected override void ReturnPath()
		{
		}

		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x4564644", Offset = "0x4560644", VA = "0x4564644", Slot = "20")]
		protected override void Prepare(ref SearchContext ctx)
		{
		}

		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x4564870", Offset = "0x4560870", VA = "0x4564870", Slot = "22")]
		protected override void OnHeapExhausted(ref SearchContext ctx)
		{
		}

		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x456490C", Offset = "0x456090C", VA = "0x456490C", Slot = "23")]
		protected override void OnFoundEndNode(ref SearchContext ctx, uint pathNode, uint hScore, uint gScore)
		{
		}

		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x45649E0", Offset = "0x45609E0", VA = "0x45649E0", Slot = "24")]
		public override void OnVisitNode(ref SearchContext ctx, uint pathNode, uint hScore, uint gScore)
		{
		}
	}
}
