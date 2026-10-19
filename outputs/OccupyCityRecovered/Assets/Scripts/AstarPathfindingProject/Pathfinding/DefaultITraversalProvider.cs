using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Pathfinding
{
	[Token(Token = "0x20000B1")]
	public static class DefaultITraversalProvider
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x451566C", Offset = "0x451166C", VA = "0x451566C")]
		public static bool CanTraverse(ref TraversalConstraint traversalConstraint, GraphNode node)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x4515674", Offset = "0x4511674", VA = "0x4515674")]
		public static float GetTraversalCostMultiplier(ref TraversalCosts traversalCosts, GraphNode node)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x45156B8", Offset = "0x45116B8", VA = "0x45156B8")]
		public static uint GetConnectionCost(ref TraversalCosts traversalCosts, GraphNode from, GraphNode to)
		{
			return default;
		}
	}
}
