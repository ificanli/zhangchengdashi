using Il2CppDummyDll;
using Pathfinding.Util;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace Pathfinding.Graphs.Grid.Rules
{
	[Token(Token = "0x2000217")]
	[Preserve]
	public class RuleElevationPenalty : GridGraphRule
	{
		[Token(Token = "0x2000218")]
		[BurstCompile(FloatMode = FloatMode.Fast)]
		public struct JobElevationPenalty : IJob
		{
			[Token(Token = "0x40009E7")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<float> elevationToPenalty;

			[Token(Token = "0x40009E8")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<Vector3> nodePositions;

			[Token(Token = "0x40009E9")]
			[FieldOffset(Offset = "0x20")]
			public Matrix4x4 worldToGraph;

			[Token(Token = "0x40009EA")]
			[FieldOffset(Offset = "0x60")]
			public NativeArray<uint> penalty;

			[Token(Token = "0x6000DEC")]
			[Address(RVA = "0x4478B84", Offset = "0x4474B84", VA = "0x4478B84", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Token(Token = "0x40009E3")]
		[FieldOffset(Offset = "0x18")]
		public float penaltyScale;

		[Token(Token = "0x40009E4")]
		[FieldOffset(Offset = "0x1C")]
		public Vector2 elevationRange;

		[Token(Token = "0x40009E5")]
		[FieldOffset(Offset = "0x28")]
		public AnimationCurve curve;

		[Token(Token = "0x40009E6")]
		[FieldOffset(Offset = "0x30")]
		private NativeArray<float> elevationToPenalty;

		[Token(Token = "0x6000DE9")]
		[Address(RVA = "0x447890C", Offset = "0x447490C", VA = "0x447890C", Slot = "7")]
		public override void Register(GridGraphRules rules)
		{
		}

		[Token(Token = "0x6000DEA")]
		[Address(RVA = "0x4478AC4", Offset = "0x4474AC4", VA = "0x4478AC4", Slot = "6")]
		public override void DisposeUnmanagedData()
		{
		}

		[Token(Token = "0x6000DEB")]
		[Address(RVA = "0x4478B2C", Offset = "0x4474B2C", VA = "0x4478B2C")]
		public RuleElevationPenalty()
		{
		}
	}
}
