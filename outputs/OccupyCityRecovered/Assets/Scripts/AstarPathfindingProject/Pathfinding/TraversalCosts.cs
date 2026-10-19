using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Serializable]
	[Token(Token = "0x20000C6")]
	public struct TraversalCosts
	{
		[Token(Token = "0x400042D")]
		[FieldOffset(Offset = "0x0")]
		public ITraversalProvider traversalProvider;

		[Token(Token = "0x400042E")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private uint[] tagEntryCostsInternal;

		[Token(Token = "0x400042F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float[] tagCostMultipliersInternal;

		[Token(Token = "0x1700014B")]
		public uint[] tagEntryCosts
		{
			[Token(Token = "0x6000684")]
			[Address(RVA = "0x451CA14", Offset = "0x4518A14", VA = "0x451CA14")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000685")]
			[Address(RVA = "0x450CD20", Offset = "0x4508D20", VA = "0x450CD20")]
			set
			{
			}
		}

		[Token(Token = "0x1700014C")]
		public float[] tagCostMultipliers
		{
			[Token(Token = "0x6000686")]
			[Address(RVA = "0x451CA1C", Offset = "0x4518A1C", VA = "0x451CA1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000687")]
			[Address(RVA = "0x450CD88", Offset = "0x4508D88", VA = "0x450CD88")]
			set
			{
			}
		}

		[Token(Token = "0x1700014D")]
		public bool hasCosts
		{
			[Token(Token = "0x6000688")]
			[Address(RVA = "0x451CA24", Offset = "0x4518A24", VA = "0x451CA24")]
			get
			{
				return default;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000689")]
		[Address(RVA = "0x451CA4C", Offset = "0x4518A4C", VA = "0x451CA4C")]
		[Obsolete("Use GetTraversalCostMultiplier instead")]
		public uint GetTraversalCost(GraphNode node)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600068A")]
		[Address(RVA = "0x451CA54", Offset = "0x4518A54", VA = "0x451CA54")]
		public float GetTraversalCostMultiplier(GraphNode node)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600068B")]
		[Address(RVA = "0x451CB44", Offset = "0x4518B44", VA = "0x451CB44")]
		public uint GetConnectionCost(GraphNode from, GraphNode to)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600068C")]
		[Address(RVA = "0x451CC54", Offset = "0x4518C54", VA = "0x451CC54")]
		public float GetDefaultTraversalCostMultiplier(GraphNode node)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600068D")]
		[Address(RVA = "0x451CC98", Offset = "0x4518C98", VA = "0x451CC98")]
		public uint GetDefaultConnectionCost(GraphNode from, GraphNode to)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600068E")]
		[Address(RVA = "0x451CCDC", Offset = "0x4518CDC", VA = "0x451CCDC")]
		public uint GetTagEntryCost(uint tag)
		{
			return default;
		}
	}
}
