using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Collections;
using Pathfinding.Graphs.Util;
using Unity.Burst;
using Unity.Mathematics;

namespace Pathfinding
{
	[Token(Token = "0x20000A8")]
	[BurstCompile]
	public readonly struct HeuristicObjective
	{
		[Token(Token = "0x20000A9")]
		public delegate int Calculate_0000055B_0024PostfixBurstDelegate(in HeuristicObjective objective, ref int3 point, uint nodeIndex);

		[Token(Token = "0x20000AA")]
		internal static class Calculate_0000055B_0024BurstDirectCall
		{
			[Token(Token = "0x4000384")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			[Token(Token = "0x4000385")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;

			[Token(Token = "0x6000598")]
			[Address(RVA = "0x4511FFC", Offset = "0x450DFFC", VA = "0x4511FFC")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			[Token(Token = "0x6000599")]
			[Address(RVA = "0x4512118", Offset = "0x450E118", VA = "0x4512118")]
			private static IntPtr GetFunctionPointer()
			{
				return default;
			}

			[Token(Token = "0x600059A")]
			[Address(RVA = "0x4512174", Offset = "0x450E174", VA = "0x4512174")]
			public static void Constructor()
			{
			}

			[Token(Token = "0x600059B")]
			[Address(RVA = "0x451221C", Offset = "0x450E21C", VA = "0x451221C")]
			public static void Initialize()
			{
			}

			[Token(Token = "0x600059D")]
			[Address(RVA = "0x4511AE8", Offset = "0x450DAE8", VA = "0x4511AE8")]
			public static int Invoke(in HeuristicObjective objective, ref int3 point, uint nodeIndex)
			{
				return default;
			}
		}

		[Token(Token = "0x400037D")]
		[FieldOffset(Offset = "0x0")]
		private readonly int3 mn;

		[Token(Token = "0x400037E")]
		[FieldOffset(Offset = "0xC")]
		private readonly int3 mx;

		[Token(Token = "0x400037F")]
		[FieldOffset(Offset = "0x18")]
		private readonly Heuristic heuristic;

		[Token(Token = "0x4000380")]
		[FieldOffset(Offset = "0x1C")]
		private readonly float heuristicScale;

		[Token(Token = "0x4000381")]
		[FieldOffset(Offset = "0x20")]
		private readonly UnsafeSpan<uint> euclideanEmbeddingCosts;

		[Token(Token = "0x4000382")]
		[FieldOffset(Offset = "0x30")]
		private readonly uint euclideanEmbeddingPivots;

		[Token(Token = "0x4000383")]
		[FieldOffset(Offset = "0x34")]
		private readonly uint targetNodeIndex;

		[Token(Token = "0x17000122")]
		public bool hasHeuristic
		{
			[Token(Token = "0x600058D")]
			[Address(RVA = "0x4511854", Offset = "0x450D854", VA = "0x4511854")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x4511864", Offset = "0x450D864", VA = "0x4511864")]
		public HeuristicObjective(int3 point, Heuristic heuristic, float heuristicScale)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED HeuristicObjective..ctor RVA=0x4511864 Token=0x600058E");
}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x4511884", Offset = "0x450D884", VA = "0x4511884")]
		public HeuristicObjective(int3 point, Heuristic heuristic, float heuristicScale, uint targetNodeIndex, EuclideanEmbedding euclideanEmbedding)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED HeuristicObjective..ctor RVA=0x4511884 Token=0x600058F");
}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x4511964", Offset = "0x450D964", VA = "0x4511964")]
		public HeuristicObjective(int3 mn, int3 mx, Heuristic heuristic, float heuristicScale, uint targetNodeIndex, EuclideanEmbedding euclideanEmbedding)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED HeuristicObjective..ctor RVA=0x4511964 Token=0x6000590");
}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x4511A54", Offset = "0x450DA54", VA = "0x4511A54")]
		public int Calculate(int3 point, uint nodeIndex)
		{
			return default;
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x4511A7C", Offset = "0x450DA7C", VA = "0x4511A7C")]
		[BurstCompile]
		public static int Calculate(in HeuristicObjective objective, ref int3 point, uint nodeIndex)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000593")]
		[Address(RVA = "0x4511BB0", Offset = "0x450DBB0", VA = "0x4511BB0")]
		[BurstCompile]
		public static int Calculate_0024BurstManaged(in HeuristicObjective objective, ref int3 point, uint nodeIndex)
		{
			return default;
		}
	}
}
