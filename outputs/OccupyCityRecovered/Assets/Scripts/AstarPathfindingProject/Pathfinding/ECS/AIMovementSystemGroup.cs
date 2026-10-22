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
			private float maximumDt = 1f / 30f;

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
			public double CustomTimeScale = 1d;

			[Token(Token = "0x1700031F")]
			public static bool CheapSimulationOnly
			{
				[Token(Token = "0x6001549")]
				[Address(RVA = "0x44CD7CC", Offset = "0x44C97CC", VA = "0x44CD7CC")]
				get
				{
                    if (!inGroup) throw new InvalidOperationException("Cannot call this method outside of a simulation group using TimeScaledRateManager");
                    return cheapSimulationOnly;
                }
			}

			[Token(Token = "0x17000320")]
			public static float CheapStepDeltaTime
			{
				[Token(Token = "0x600154A")]
				[Address(RVA = "0x44CD864", Offset = "0x44C9864", VA = "0x44CD864")]
				get
				{
                    if (!inGroup) throw new InvalidOperationException("Cannot call this method outside of a simulation group using TimeScaledRateManager");
                    return cheapTimeData.DeltaTime;
                }
			}

			[Token(Token = "0x17000321")]
			public static bool IsLastSubstep
			{
				[Token(Token = "0x600154B")]
				[Address(RVA = "0x44CD8FC", Offset = "0x44C98FC", VA = "0x44CD8FC")]
				get
				{
                    if (!inGroup) throw new InvalidOperationException("Cannot call this method outside of a simulation group using TimeScaledRateManager");
                    return isLastSubstep;
                }
			}

			[Token(Token = "0x17000322")]
			public static bool IsFirstSubstep
			{
				[Token(Token = "0x600154C")]
				[Address(RVA = "0x44CD994", Offset = "0x44C9994", VA = "0x44CD994")]
				get
				{
                    if (!inGroup) throw new InvalidOperationException("Cannot call this method outside of a simulation group using TimeScaledRateManager");
                    return isFirstSubstep;
                }
			}

			[Token(Token = "0x17000323")]
			public int NumUpdatesThisFrame
			{
				[Token(Token = "0x600154D")]
				[Address(RVA = "0x44CDA2C", Offset = "0x44C9A2C", VA = "0x44CDA2C")]
				get
				{ return numUpdatesThisFrame; }
			}

			[Token(Token = "0x17000324")]
			public float Timestep
			{
				[Token(Token = "0x6001552")]
				[Address(RVA = "0x44CDE6C", Offset = "0x44C9E6C", VA = "0x44CDE6C", Slot = "5")]
				get
				{ return maximumDt; }
				[Token(Token = "0x6001553")]
				[Address(RVA = "0x44CDE74", Offset = "0x44C9E74", VA = "0x44CDE74", Slot = "6")]
				set
				{ maximumDt = value; }
			}

			[Token(Token = "0x600154E")]
			[Address(RVA = "0x44CD70C", Offset = "0x44C970C", VA = "0x44CD70C")]
			public TimeScaledRateManager()
			{
				cheapTimeDataQueue = new NativeList<TimeData>(Allocator.Persistent);
				timeDataQueue = new NativeList<TimeData>(Allocator.Persistent);
			}

			[Token(Token = "0x600154F")]
			[Address(RVA = "0x44CD658", Offset = "0x44C9658", VA = "0x44CD658", Slot = "7")]
			public void Dispose()
			{
				cheapTimeDataQueue.Dispose();
				timeDataQueue.Dispose();
			}

			[Token(Token = "0x6001550")]
			[Address(RVA = "0x44CD568", Offset = "0x44C9568", VA = "0x44CD568")]
			public void OnSimulationStepsFinished(float totalSimulationProcessingTime)
			{
                if (!cheapSimulationOnly)
                    ownProcessingTimePerIteration = totalSimulationProcessingTime / (float)numUpdatesThisFrame;
            }

			[Token(Token = "0x6001551")]
			[Address(RVA = "0x44CDA34", Offset = "0x44C9A34", VA = "0x44CDA34", Slot = "4")]
			public bool ShouldGroupUpdate(ComponentSystemGroup group)
			{
                if (inGroup) {
                    group.World.PopTime();
                    updateIndex = unchecked(updateIndex + 1);
                    if (updateIndex >= numUpdatesThisFrame) {
                        inGroup = false;
                        return false;
                    }
                } else {
                    cheapTimeDataQueue.Clear();
                    timeDataQueue.Clear();
                    if (inGroup) throw new InvalidOperationException("Cannot nest simulation groups using TimeScaledRateManager");
                    double scaledElapsedTime = group.World.Time.ElapsedTime * CustomTimeScale;
                    float elapsed = (float)(scaledElapsedTime - lastFullSimulation);
                    if (elapsed <= 0f) elapsed = 0f;
                    float stepEstimate = Unity.Mathematics.math.pow(
                        elapsed / (maximumDt + ownProcessingTimePerIteration), 0.8f);
                    numUpdatesThisFrame = unchecked((int)Unity.Mathematics.math.floor(stepEstimate));
                    cheapSimulationOnly = numUpdatesThisFrame == 0;
                    if (numUpdatesThisFrame != 0) {
                        stepDt = elapsed / numUpdatesThisFrame;
                        if (numUpdatesThisFrame >= 1) {
                            int i = 1;
                            while (true) {
                                double stepEnd = lastFullSimulation + (double)(stepDt * i);
                                timeDataQueue.Add(new TimeData(stepEnd, stepDt));
                                cheapTimeDataQueue.Add(new TimeData(stepEnd, (float)(stepEnd - lastCheapSimulation)));
                                lastCheapSimulation = stepEnd;
                                if (i >= numUpdatesThisFrame) break;
                                i = unchecked(i + 1);
                            }
                        }
                        lastFullSimulation = scaledElapsedTime;
                    } else {
                        timeDataQueue.Add(new TimeData(lastFullSimulation, 0f));
                        cheapTimeDataQueue.Add(new TimeData(scaledElapsedTime, (float)(scaledElapsedTime - lastCheapSimulation)));
                        lastCheapSimulation = scaledElapsedTime;
                    }
                    numUpdatesThisFrame = Math.Max(numUpdatesThisFrame, 1);
                    inGroup = true;
                    updateIndex = 0;
                }
                group.World.PushTime(timeDataQueue[updateIndex]);
                cheapTimeData = cheapTimeDataQueue[updateIndex];
                isLastSubstep = unchecked(updateIndex + 1) >= numUpdatesThisFrame;
                isFirstSubstep = updateIndex == 0;
                return true;
            }
		}

		[Token(Token = "0x1700031E")]
		public double CustomTimeScale
		{
			[Token(Token = "0x6001543")]
			[Address(RVA = "0x44CD06C", Offset = "0x44C906C", VA = "0x44CD06C")]
			get
			{ return (RateManager as TimeScaledRateManager).CustomTimeScale; }
			[Token(Token = "0x6001544")]
			[Address(RVA = "0x44CD0E8", Offset = "0x44C90E8", VA = "0x44CD0E8")]
			set
			{ (RateManager as TimeScaledRateManager).CustomTimeScale = value; }
		}

		[Token(Token = "0x6001545")]
		[Address(RVA = "0x44CD170", Offset = "0x44C9170", VA = "0x44CD170", Slot = "13")]
		[Preserve]
		protected override void OnUpdate()
		{
            var graphReadLock = AstarPath.active != null
                ? AstarPath.active.LockGraphDataForReading()
                : default(Pathfinding.Sync.RWLock.ReadLockAsync);
            var systems = GetUnmanagedSystems(Allocator.Temp);
            for (int i = 0; i < systems.Length; i++) {
                ref var state = ref World.Unmanaged.ResolveSystemStateRef(systems[i]);
                state.Dependency = Unity.Jobs.JobHandle.CombineDependencies(state.Dependency, graphReadLock.dependency);
            }
            long start = System.Diagnostics.Stopwatch.GetTimestamp();
            base.OnUpdate();
            long end = System.Diagnostics.Stopwatch.GetTimestamp();
            (RateManager as TimeScaledRateManager).OnSimulationStepsFinished(
                (float)((end - start) / (double)System.Diagnostics.Stopwatch.Frequency));
            var dependency = default(Unity.Jobs.JobHandle);
            for (int i = 0; i < systems.Length; i++) {
                ref var state = ref World.Unmanaged.ResolveSystemStateRef(systems[i]);
                dependency = Unity.Jobs.JobHandle.CombineDependencies(dependency, state.Dependency);
            }
            systems.Dispose();
            graphReadLock.UnlockAfter(dependency);
        }

		[Token(Token = "0x6001546")]
		[Address(RVA = "0x44CD5D4", Offset = "0x44C95D4", VA = "0x44CD5D4", Slot = "9")]
		[Preserve]
		protected override void OnDestroy()
		{
			base.OnDestroy();
			(RateManager as TimeScaledRateManager).Dispose();
		}

		[Token(Token = "0x6001547")]
		[Address(RVA = "0x44CD6AC", Offset = "0x44C96AC", VA = "0x44CD6AC", Slot = "5")]
		[Preserve]
		protected override void OnCreate()
		{
			base.OnCreate();
			RateManager = new TimeScaledRateManager();
		}

		[Token(Token = "0x6001548")]
		[Address(RVA = "0x44CD7C4", Offset = "0x44C97C4", VA = "0x44CD7C4")]
		[Preserve]
		public AIMovementSystemGroup()
		{
		}
	}
}
