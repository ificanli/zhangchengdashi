using System;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Core;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine.Scripting;

namespace Pathfinding.ECS
{
	[Token(Token = "0x2000358")]
	[UpdateAfter(typeof(TransformSystemGroup))]
	public partial class AIMovementSystemGroup : ComponentSystemGroup
	{
		[Token(Token = "0x2000359")]
		public class TimeScaledRateManager : IRateManager, IDisposable
		{
			[Token(Token = "0x4000EC1")]
			[FieldOffset(Offset = "0x10")]
			private int numUpdatesThisFrame;

			[Token(Token = "0x4000EC2")]
			[FieldOffset(Offset = "0x14")]
			private int updateIndex;

			[Token(Token = "0x4000EC3")]
			[FieldOffset(Offset = "0x18")]
			private float stepDt;

			[Token(Token = "0x4000EC4")]
			[FieldOffset(Offset = "0x1C")]
			private float maximumDt;

			[Token(Token = "0x4000EC5")]
			[FieldOffset(Offset = "0x20")]
			private float ownProcessingTimePerIteration;

			[Token(Token = "0x4000EC6")]
			[FieldOffset(Offset = "0x28")]
			private NativeList<TimeData> cheapTimeDataQueue;

			[Token(Token = "0x4000EC7")]
			[FieldOffset(Offset = "0x30")]
			private NativeList<TimeData> timeDataQueue;

			[Token(Token = "0x4000EC8")]
			[FieldOffset(Offset = "0x38")]
			private double lastFullSimulation;

			[Token(Token = "0x4000EC9")]
			[FieldOffset(Offset = "0x40")]
			private double lastCheapSimulation;

			[Token(Token = "0x4000ECA")]
			[FieldOffset(Offset = "0x0")]
			private static bool cheapSimulationOnly;

			[Token(Token = "0x4000ECB")]
			[FieldOffset(Offset = "0x1")]
			private static bool isLastSubstep;

			[Token(Token = "0x4000ECC")]
			[FieldOffset(Offset = "0x2")]
			private static bool isFirstSubstep;

			[Token(Token = "0x4000ECD")]
			[FieldOffset(Offset = "0x3")]
			private static bool inGroup;

			[Token(Token = "0x4000ECE")]
			[FieldOffset(Offset = "0x8")]
			private static TimeData cheapTimeData;

			[Token(Token = "0x4000ECF")]
			[FieldOffset(Offset = "0x48")]
			public double CustomTimeScale;

			[Token(Token = "0x1700031F")]
			public static bool CheapSimulationOnly
			{
				[Token(Token = "0x6001549")]
				[Address(RVA = "0x44CD7CC", Offset = "0x44C97CC", VA = "0x44CD7CC")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000320")]
			public static float CheapStepDeltaTime
			{
				[Token(Token = "0x600154A")]
				[Address(RVA = "0x44CD864", Offset = "0x44C9864", VA = "0x44CD864")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000321")]
			public static bool IsLastSubstep
			{
				[Token(Token = "0x600154B")]
				[Address(RVA = "0x44CD8FC", Offset = "0x44C98FC", VA = "0x44CD8FC")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000322")]
			public static bool IsFirstSubstep
			{
				[Token(Token = "0x600154C")]
				[Address(RVA = "0x44CD994", Offset = "0x44C9994", VA = "0x44CD994")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000323")]
			public int NumUpdatesThisFrame
			{
				[Token(Token = "0x600154D")]
				[Address(RVA = "0x44CDA2C", Offset = "0x44C9A2C", VA = "0x44CDA2C")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000324")]
			public float Timestep
			{
				[Token(Token = "0x6001552")]
				[Address(RVA = "0x44CDE6C", Offset = "0x44C9E6C", VA = "0x44CDE6C", Slot = "5")]
				get
				{
					return default;
				}
				[Token(Token = "0x6001553")]
				[Address(RVA = "0x44CDE74", Offset = "0x44C9E74", VA = "0x44CDE74", Slot = "6")]
				set
				{
				}
			}

			[Token(Token = "0x600154E")]
			[Address(RVA = "0x44CD70C", Offset = "0x44C970C", VA = "0x44CD70C")]
			public TimeScaledRateManager()
			{
			}

			[Token(Token = "0x600154F")]
			[Address(RVA = "0x44CD658", Offset = "0x44C9658", VA = "0x44CD658", Slot = "7")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6001550")]
			[Address(RVA = "0x44CD568", Offset = "0x44C9568", VA = "0x44CD568")]
			public void OnSimulationStepsFinished(float totalSimulationProcessingTime)
			{
			}

			[Token(Token = "0x6001551")]
			[Address(RVA = "0x44CDA34", Offset = "0x44C9A34", VA = "0x44CDA34", Slot = "4")]
			public bool ShouldGroupUpdate(ComponentSystemGroup group)
			{
				return default;
			}
		}

		[Token(Token = "0x1700031E")]
		public double CustomTimeScale
		{
			[Token(Token = "0x6001543")]
			[Address(RVA = "0x44CD06C", Offset = "0x44C906C", VA = "0x44CD06C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001544")]
			[Address(RVA = "0x44CD0E8", Offset = "0x44C90E8", VA = "0x44CD0E8")]
			set
			{
			}
		}

		[Token(Token = "0x6001545")]
		[Address(RVA = "0x44CD170", Offset = "0x44C9170", VA = "0x44CD170", Slot = "13")]
		[Preserve]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6001546")]
		[Address(RVA = "0x44CD5D4", Offset = "0x44C95D4", VA = "0x44CD5D4", Slot = "9")]
		[Preserve]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6001547")]
		[Address(RVA = "0x44CD6AC", Offset = "0x44C96AC", VA = "0x44CD6AC", Slot = "5")]
		[Preserve]
		protected override void OnCreate()
		{
		}

		[Token(Token = "0x6001548")]
		[Address(RVA = "0x44CD7C4", Offset = "0x44C97C4", VA = "0x44CD7C4")]
		[Preserve]
		public AIMovementSystemGroup()
		{
		}
	}
}
