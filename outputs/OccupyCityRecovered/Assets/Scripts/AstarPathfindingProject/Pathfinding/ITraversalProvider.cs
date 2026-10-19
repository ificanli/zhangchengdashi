using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	[Token(Token = "0x20000B0")]
	public interface ITraversalProvider
	{
		[Token(Token = "0x17000125")]
		bool filterDiagonalGridConnections
		{
			[Token(Token = "0x60005BC")]
			[Address(RVA = "0x451547C", Offset = "0x451147C", VA = "0x451547C", Slot = "0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x4515484", Offset = "0x4511484", VA = "0x4515484", Slot = "1")]
		bool CanTraverse(ref TraversalConstraint traversalConstraint, GraphNode node)
		{
			return default;
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x451548C", Offset = "0x451148C", VA = "0x451548C", Slot = "2")]
		bool CanTraverse(ref TraversalConstraint traversalConstraint, GraphNode from, GraphNode to)
		{
			return default;
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x451553C", Offset = "0x451153C", VA = "0x451553C", Slot = "3")]
		uint GetConnectionCost(ref TraversalCosts traversalCosts, GraphNode from, GraphNode to)
		{
			return default;
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x4515580", Offset = "0x4511580", VA = "0x4515580", Slot = "4")]
		float GetTraversalCostMultiplier(ref TraversalCosts traversalCosts, GraphNode node)
		{
			return default;
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x45155C4", Offset = "0x45115C4", VA = "0x45155C4", Slot = "5")]
		[Obsolete("Use CanTraverse(ref TraversalConstraint, GraphNode, GraphNode) instead")]
		bool CanTraverse(Path path, GraphNode from, GraphNode to)
		{
			return default;
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x45155FC", Offset = "0x45115FC", VA = "0x45155FC", Slot = "6")]
		[Obsolete("Use CanTraverse(ref TraversalConstraint, GraphNode) instead")]
		bool CanTraverse(Path path, GraphNode node)
		{
			return default;
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x4515634", Offset = "0x4511634", VA = "0x4515634", Slot = "7")]
		[Obsolete("Use GetTraversalCostMultiplier(ref TraversalCosts, GraphNode) instead")]
		uint GetTraversalCost(Path path, GraphNode node)
		{
			return default;
		}
	}
}
