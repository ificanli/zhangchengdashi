using Il2CppDummyDll;
using Pathfinding.Util;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding.Graphs.Grid.Rules
{
	[Token(Token = "0x2000215")]
	[Preserve]
	public class RuleAnglePenalty : GridGraphRule
	{
		[Token(Token = "0x2000216")]
		[BurstCompile(FloatMode = FloatMode.Fast)]
		public struct JobPenaltyAngle : IJob
		{
			[Token(Token = "0x40009DF")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 up;

			[Token(Token = "0x40009E0")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<float> angleToPenalty;

			[Token(Token = "0x40009E1")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public NativeArray<float4> nodeNormals;

			[Token(Token = "0x40009E2")]
			[FieldOffset(Offset = "0x30")]
			public NativeArray<uint> penalty;

			[Token(Token = "0x6000DE8")]
			[Address(RVA = "0x4478778", Offset = "0x4474778", VA = "0x4478778", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Token(Token = "0x40009DC")]
		[FieldOffset(Offset = "0x18")]
		public float penaltyScale;

		[Token(Token = "0x40009DD")]
		[FieldOffset(Offset = "0x20")]
		public AnimationCurve curve;

		[Token(Token = "0x40009DE")]
		[FieldOffset(Offset = "0x28")]
		private NativeArray<float> angleToPenalty;

		[Token(Token = "0x6000DE4")]
		[Address(RVA = "0x44784D0", Offset = "0x44744D0", VA = "0x44784D0", Slot = "7")]
		public override void Register(GridGraphRules rules)
		{
		}

		[Token(Token = "0x6000DE5")]
		[Address(RVA = "0x447862C", Offset = "0x447462C", VA = "0x447862C", Slot = "6")]
		public override void DisposeUnmanagedData()
		{
		}

		[Token(Token = "0x6000DE6")]
		[Address(RVA = "0x4478694", Offset = "0x4474694", VA = "0x4478694")]
		public RuleAnglePenalty()
		{
		}
	}
}
