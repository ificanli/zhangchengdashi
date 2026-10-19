using Il2CppDummyDll;
using Pathfinding.Util;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding.Graphs.Grid.Rules
{
	[Token(Token = "0x200021E")]
	[Preserve]
	public class RuleTexture : GridGraphRule
	{
		[Token(Token = "0x200021F")]
		public enum ScalingMode
		{
			[Token(Token = "0x40009FE")]
			FixedScale = 0,
			[Token(Token = "0x40009FF")]
			StretchToFitGraph = 1
		}

		[Token(Token = "0x2000220")]
		public enum ChannelUse
		{
			[Token(Token = "0x4000A01")]
			None = 0,
			[Token(Token = "0x4000A02")]
			Penalty = 1,
			[Token(Token = "0x4000A03")]
			Position = 2,
			[Token(Token = "0x4000A04")]
			WalkablePenalty = 3,
			[Token(Token = "0x4000A05")]
			Walkable = 4
		}

		[Token(Token = "0x2000221")]
		[BurstCompile]
		public struct JobTexturePosition : IJob, GridIterationUtilities.INodeModifier
		{
			[Token(Token = "0x4000A06")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<int> colorData;

			[Token(Token = "0x4000A07")]
			[FieldOffset(Offset = "0x10")]
			[WriteOnly]
			public NativeArray<Vector3> nodePositions;

			[Token(Token = "0x4000A08")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public NativeArray<float4> nodeNormals;

			[Token(Token = "0x4000A09")]
			[FieldOffset(Offset = "0x30")]
			public Matrix4x4 graphToWorld;

			[Token(Token = "0x4000A0A")]
			[FieldOffset(Offset = "0x70")]
			public IntBounds bounds;

			[Token(Token = "0x4000A0B")]
			[FieldOffset(Offset = "0x88")]
			public int2 colorDataSize;

			[Token(Token = "0x4000A0C")]
			[FieldOffset(Offset = "0x90")]
			public float2 scale;

			[Token(Token = "0x4000A0D")]
			[FieldOffset(Offset = "0x98")]
			public float4 channelPositionScale;

			[Token(Token = "0x6000DF7")]
			[Address(RVA = "0x4479974", Offset = "0x4475974", VA = "0x4479974", Slot = "5")]
			public void ModifyNode(int dataIndex, int dataX, int dataLayer, int dataZ)
			{
			}

			[Token(Token = "0x6000DF8")]
			[Address(RVA = "0x4479B10", Offset = "0x4475B10", VA = "0x4479B10", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Token(Token = "0x2000222")]
		[BurstCompile]
		public struct JobTexturePenalty : IJob, GridIterationUtilities.INodeModifier
		{
			[Token(Token = "0x4000A0E")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<int> colorData;

			[Token(Token = "0x4000A0F")]
			[FieldOffset(Offset = "0x10")]
			public NativeArray<uint> penalty;

			[Token(Token = "0x4000A10")]
			[FieldOffset(Offset = "0x20")]
			public NativeArray<bool> walkable;

			[Token(Token = "0x4000A11")]
			[FieldOffset(Offset = "0x30")]
			[ReadOnly]
			public NativeArray<float4> nodeNormals;

			[Token(Token = "0x4000A12")]
			[FieldOffset(Offset = "0x40")]
			public IntBounds bounds;

			[Token(Token = "0x4000A13")]
			[FieldOffset(Offset = "0x58")]
			public int2 colorDataSize;

			[Token(Token = "0x4000A14")]
			[FieldOffset(Offset = "0x60")]
			public float2 scale;

			[Token(Token = "0x4000A15")]
			[FieldOffset(Offset = "0x68")]
			public float4 channelPenalties;

			[Token(Token = "0x4000A16")]
			[FieldOffset(Offset = "0x78")]
			public bool4 channelDeterminesWalkability;

			[Token(Token = "0x6000DF9")]
			[Address(RVA = "0x4479B6C", Offset = "0x4475B6C", VA = "0x4479B6C", Slot = "5")]
			public void ModifyNode(int dataIndex, int dataX, int dataLayer, int dataZ)
			{
			}

			[Token(Token = "0x6000DFA")]
			[Address(RVA = "0x4479D20", Offset = "0x4475D20", VA = "0x4479D20", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Token(Token = "0x40009F7")]
		[FieldOffset(Offset = "0x18")]
		public Texture2D texture;

		[Token(Token = "0x40009F8")]
		[FieldOffset(Offset = "0x20")]
		public ChannelUse[] channels;

		[Token(Token = "0x40009F9")]
		[FieldOffset(Offset = "0x28")]
		public float[] channelScales;

		[Token(Token = "0x40009FA")]
		[FieldOffset(Offset = "0x30")]
		public ScalingMode scalingMode;

		[Token(Token = "0x40009FB")]
		[FieldOffset(Offset = "0x34")]
		public float nodesPerPixel;

		[Token(Token = "0x40009FC")]
		[FieldOffset(Offset = "0x38")]
		private NativeArray<int> colors;

		[Token(Token = "0x1700021D")]
		public override int Hash
		{
			[Token(Token = "0x6000DF3")]
			[Address(RVA = "0x4479364", Offset = "0x4475364", VA = "0x4479364", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000DF4")]
		[Address(RVA = "0x4479414", Offset = "0x4475414", VA = "0x4479414", Slot = "7")]
		public override void Register(GridGraphRules rules)
		{
		}

		[Token(Token = "0x6000DF5")]
		[Address(RVA = "0x4479850", Offset = "0x4475850", VA = "0x4479850", Slot = "6")]
		public override void DisposeUnmanagedData()
		{
		}

		[Token(Token = "0x6000DF6")]
		[Address(RVA = "0x44798B8", Offset = "0x44758B8", VA = "0x44798B8")]
		public RuleTexture()
		{
		}
	}
}
