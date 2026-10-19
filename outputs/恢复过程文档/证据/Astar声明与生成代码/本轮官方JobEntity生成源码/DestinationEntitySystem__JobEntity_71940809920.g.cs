#pragma warning disable 0219
#line 1 "Temp/GeneratedCode/AstarPathfindingProject.check/DestinationEntitySystem__JobEntity_71940809920.g.cs"
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Burst.Intrinsics;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Transforms;

namespace Pathfinding.ECS {
partial struct DestinationEntitySystem  {
[global::System.Runtime.CompilerServices.CompilerGenerated]
partial struct UpdateDestinationJob : global::Unity.Entities.IJobChunk
{
    InternalCompilerQueryAndHandleData.TypeHandle __TypeHandle;
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    public void Execute(in global::Unity.Entities.ArchetypeChunk chunk, int chunkIndexInQuery, bool useEnabledMask, in global::Unity.Burst.Intrinsics.v128 chunkEnabledMask)
    {
        var destPointArrayIntPtr = Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetChunkNativeArrayIntPtr<global::Pathfinding.ECS.DestinationPoint>(chunk, ref __TypeHandle.__Pathfinding_ECS_DestinationPoint_RW_ComponentTypeHandle);
        var destEntityArrayIntPtr = Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetChunkNativeArrayReadOnlyIntPtr<global::Pathfinding.ECS.DestinationEntity>(chunk, ref __TypeHandle.__Pathfinding_ECS_DestinationEntity_RO_ComponentTypeHandle);
        int chunkEntityCount = chunk.Count;
        int matchingEntityCount = 0;
        
        if (!useEnabledMask)
        {
            for(int entityIndexInChunk = 0; entityIndexInChunk < chunkEntityCount; ++entityIndexInChunk)
            {
                ref var destPointArrayIntPtrRef = ref Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::Pathfinding.ECS.DestinationPoint>(destPointArrayIntPtr, entityIndexInChunk);
                ref var destEntityArrayIntPtrRef = ref Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::Pathfinding.ECS.DestinationEntity>(destEntityArrayIntPtr, entityIndexInChunk);
                Execute(ref destPointArrayIntPtrRef,in destEntityArrayIntPtrRef);
                matchingEntityCount++;
            }
        }
        else
        {
            int edgeCount = global::Unity.Mathematics.math.countbits(chunkEnabledMask.ULong0 ^ (chunkEnabledMask.ULong0 << 1)) + global::Unity.Mathematics.math.countbits(chunkEnabledMask.ULong1 ^ (chunkEnabledMask.ULong1 << 1)) - 1;
            bool useRanges = edgeCount <= 4;
            if (useRanges)
            {
                int entityIndexInChunk = 0;
                int chunkEndIndex = 0;
                
                while (global::Unity.Entities.Internal.InternalCompilerInterface.UnsafeTryGetNextEnabledBitRange(chunkEnabledMask, chunkEndIndex, out entityIndexInChunk, out chunkEndIndex))
                {
                    while (entityIndexInChunk < chunkEndIndex)
                    {
                        ref var destPointArrayIntPtrRef = ref Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::Pathfinding.ECS.DestinationPoint>(destPointArrayIntPtr, entityIndexInChunk);
                        ref var destEntityArrayIntPtrRef = ref Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::Pathfinding.ECS.DestinationEntity>(destEntityArrayIntPtr, entityIndexInChunk);
                        Execute(ref destPointArrayIntPtrRef,in destEntityArrayIntPtrRef);
                        entityIndexInChunk++;
                        matchingEntityCount++;
                    }
                }
            }
            else
            {
                ulong mask64 = chunkEnabledMask.ULong0;
                int count = global::Unity.Mathematics.math.min(64, chunkEntityCount);
                for (int entityIndexInChunk = 0; entityIndexInChunk < count; ++entityIndexInChunk)
                {
                    if ((mask64 & 1) != 0)
                    {
                        ref var destPointArrayIntPtrRef = ref Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::Pathfinding.ECS.DestinationPoint>(destPointArrayIntPtr, entityIndexInChunk);
                        ref var destEntityArrayIntPtrRef = ref Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::Pathfinding.ECS.DestinationEntity>(destEntityArrayIntPtr, entityIndexInChunk);
                        Execute(ref destPointArrayIntPtrRef,in destEntityArrayIntPtrRef);
                        matchingEntityCount++;
                    }
                    mask64 >>= 1;
                }
                mask64 = chunkEnabledMask.ULong1;
                for (int entityIndexInChunk = 64; entityIndexInChunk < chunkEntityCount; ++entityIndexInChunk)
                {
                    if ((mask64 & 1) != 0)
                    {
                        ref var destPointArrayIntPtrRef = ref Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::Pathfinding.ECS.DestinationPoint>(destPointArrayIntPtr, entityIndexInChunk);
                        ref var destEntityArrayIntPtrRef = ref Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::Pathfinding.ECS.DestinationEntity>(destEntityArrayIntPtr, entityIndexInChunk);
                        Execute(ref destPointArrayIntPtrRef,in destEntityArrayIntPtrRef);
                        matchingEntityCount++;
                    }
                    mask64 >>= 1;
                }
            }
        }
    }
    global::Unity.Jobs.JobHandle __ThrowCodeGenException() => throw new global::System.Exception("This method should have been replaced by source gen.");
    
    // Emitted to disambiguate scheduling method invocations
    public void Run() => __ThrowCodeGenException();
    public void RunByRef() => __ThrowCodeGenException();
    public void Run(global::Unity.Entities.EntityQuery query) => __ThrowCodeGenException();
    public void RunByRef(global::Unity.Entities.EntityQuery query) => __ThrowCodeGenException();
    public global::Unity.Jobs.JobHandle Schedule(global::Unity.Jobs.JobHandle dependsOn) => __ThrowCodeGenException();
    public global::Unity.Jobs.JobHandle ScheduleByRef(global::Unity.Jobs.JobHandle dependsOn) => __ThrowCodeGenException();
    public global::Unity.Jobs.JobHandle Schedule(global::Unity.Entities.EntityQuery query, global::Unity.Jobs.JobHandle dependsOn) => __ThrowCodeGenException();
    public global::Unity.Jobs.JobHandle ScheduleByRef(global::Unity.Entities.EntityQuery query, global::Unity.Jobs.JobHandle dependsOn) => __ThrowCodeGenException();
    public void Schedule() => __ThrowCodeGenException();
    public void ScheduleByRef() => __ThrowCodeGenException();
    public void Schedule(global::Unity.Entities.EntityQuery query) => __ThrowCodeGenException();
    public void ScheduleByRef(global::Unity.Entities.EntityQuery query) => __ThrowCodeGenException();
    public global::Unity.Jobs.JobHandle ScheduleParallel(global::Unity.Jobs.JobHandle dependsOn) => __ThrowCodeGenException();
    public global::Unity.Jobs.JobHandle ScheduleParallelByRef(global::Unity.Jobs.JobHandle dependsOn) => __ThrowCodeGenException();
    public global::Unity.Jobs.JobHandle ScheduleParallel(global::Unity.Entities.EntityQuery query, global::Unity.Jobs.JobHandle dependsOn) => __ThrowCodeGenException();
    public global::Unity.Jobs.JobHandle ScheduleParallelByRef(global::Unity.Entities.EntityQuery query, global::Unity.Jobs.JobHandle dependsOn) => __ThrowCodeGenException();
    public global::Unity.Jobs.JobHandle ScheduleParallel(global::Unity.Entities.EntityQuery query, global::Unity.Jobs.JobHandle dependsOn, global::Unity.Collections.NativeArray<int> chunkBaseEntityIndices) => __ThrowCodeGenException();
    public global::Unity.Jobs.JobHandle ScheduleParallelByRef(global::Unity.Entities.EntityQuery query, global::Unity.Jobs.JobHandle dependsOn, global::Unity.Collections.NativeArray<int> chunkBaseEntityIndices) => __ThrowCodeGenException();
    public void ScheduleParallel() => __ThrowCodeGenException();
    public void ScheduleParallelByRef() => __ThrowCodeGenException();
    public void ScheduleParallel(global::Unity.Entities.EntityQuery query) => __ThrowCodeGenException();
    public void ScheduleParallelByRef(global::Unity.Entities.EntityQuery query) => __ThrowCodeGenException();
    /// <summary> Used internally by the compiler, we won't promise this exists in the future </summary>
    public struct InternalCompilerQueryAndHandleData
    {
        public TypeHandle __TypeHandle;
        public global::Unity.Entities.EntityQuery DefaultQuery;
        public struct TypeHandle
        {
            public Unity.Entities.ComponentTypeHandle<global::Pathfinding.ECS.DestinationPoint> __Pathfinding_ECS_DestinationPoint_RW_ComponentTypeHandle;
            [global::Unity.Collections.ReadOnly] public Unity.Entities.ComponentTypeHandle<global::Pathfinding.ECS.DestinationEntity> __Pathfinding_ECS_DestinationEntity_RO_ComponentTypeHandle;
            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public void __AssignHandles(ref global::Unity.Entities.SystemState state)
            {
                __Pathfinding_ECS_DestinationPoint_RW_ComponentTypeHandle = state.GetComponentTypeHandle<global::Pathfinding.ECS.DestinationPoint>(false);
                __Pathfinding_ECS_DestinationEntity_RO_ComponentTypeHandle = state.GetComponentTypeHandle<global::Pathfinding.ECS.DestinationEntity>(true);
            }
            
            public void Update(ref global::Unity.Entities.SystemState state)
            {
                __Pathfinding_ECS_DestinationPoint_RW_ComponentTypeHandle.Update(ref state);
                __Pathfinding_ECS_DestinationEntity_RO_ComponentTypeHandle.Update(ref state);
            }
            
        }
        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        void __AssignQueries(ref global::Unity.Entities.SystemState state)
        {
            var entityQueryBuilder = new global::Unity.Entities.EntityQueryBuilder(global::Unity.Collections.Allocator.Temp);
            DefaultQuery = 
                entityQueryBuilder
                    .WithAll<global::Pathfinding.ECS.DestinationEntity>()
                    .WithAllRW<global::Pathfinding.ECS.DestinationPoint>()
                    .Build(ref state);
            entityQueryBuilder.Reset();
            entityQueryBuilder.Dispose();
        }
        
        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static int GetRequiredComponentTypeCount() => 2;
        
        public static void AddRequiredComponentTypes(ref global::System.Span<Unity.Entities.ComponentType> components)
        {
            components[0] = Unity.Entities.ComponentType.ReadWrite<global::Pathfinding.ECS.DestinationPoint>();
            components[1] = Unity.Entities.ComponentType.ReadOnly<global::Pathfinding.ECS.DestinationEntity>();
        }
        
        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static bool QueryHasRequiredComponentsForExecuteMethodToRun(ref EntityQuery userDefinedQuery, ref global::System.Span<global::Unity.Entities.ComponentType> components) =>
            global::Unity.Entities.Internal.InternalCompilerInterface.EntityQueryInterface.HasComponentsRequiredForExecuteMethodToRun(ref userDefinedQuery, ref components);
        
        public void Init(ref global::Unity.Entities.SystemState state, bool assignDefaultQuery)
        {
            if (assignDefaultQuery)
                __AssignQueries(ref state);
            __TypeHandle.__AssignHandles(ref state);
        }
        
        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Run(ref global::Pathfinding.ECS.DestinationEntitySystem.UpdateDestinationJob job, global::Unity.Entities.EntityQuery query)
        {
            job.__TypeHandle = __TypeHandle;
            global::Unity.Entities.JobChunkExtensions.RunByRef(ref job, query);
        }
        
        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Unity.Jobs.JobHandle Schedule(ref global::Pathfinding.ECS.DestinationEntitySystem.UpdateDestinationJob job, global::Unity.Entities.EntityQuery query, global::Unity.Jobs.JobHandle dependency)
        {
            job.__TypeHandle = __TypeHandle;
            return global::Unity.Entities.JobChunkExtensions.ScheduleByRef(ref job, query, dependency);
        }
        
        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Unity.Jobs.JobHandle ScheduleParallel(ref global::Pathfinding.ECS.DestinationEntitySystem.UpdateDestinationJob job, global::Unity.Entities.EntityQuery query, global::Unity.Jobs.JobHandle dependency)
        {
            job.__TypeHandle = __TypeHandle;
            return global::Unity.Entities.JobChunkExtensions.ScheduleParallelByRef(ref job, query, dependency);
        }
        
        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void UpdateBaseEntityIndexArray(ref global::Pathfinding.ECS.DestinationEntitySystem.UpdateDestinationJob job, global::Unity.Entities.EntityQuery query, ref global::Unity.Entities.SystemState state)
        {
        }
        
        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Unity.Jobs.JobHandle UpdateBaseEntityIndexArray(ref global::Pathfinding.ECS.DestinationEntitySystem.UpdateDestinationJob job, global::Unity.Entities.EntityQuery query, global::Unity.Jobs.JobHandle dependency, ref global::Unity.Entities.SystemState state)
        {
            return dependency;
        }
        
        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void AssignEntityManager(ref global::Pathfinding.ECS.DestinationEntitySystem.UpdateDestinationJob job, global::Unity.Entities.EntityManager entityManager)
        {
        }
    }
    /// <summary> Internal structure used by the compiler</summary>
    public struct InternalCompiler
    {
        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [global::System.Diagnostics.Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
        // scheduleType 0:Run, 1:Schedule, 2:ScheduleParallel
        public static void CheckForErrors(int scheduleType)
        {
        }
    }
}


}}