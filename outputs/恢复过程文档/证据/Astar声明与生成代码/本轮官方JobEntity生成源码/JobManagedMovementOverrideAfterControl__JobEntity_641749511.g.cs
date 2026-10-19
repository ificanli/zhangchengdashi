#pragma warning disable 0219
#line 1 "Temp/GeneratedCode/AstarPathfindingProject.check/JobManagedMovementOverrideAfterControl__JobEntity_641749511.g.cs"
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Burst.Intrinsics;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Transforms;

namespace Pathfinding.ECS {
[global::System.Runtime.CompilerServices.CompilerGenerated]
partial struct JobManagedMovementOverrideAfterControl : global::Unity.Entities.IJobChunk
{
    InternalCompilerQueryAndHandleData.TypeHandle __TypeHandle;
    public global::Unity.Entities.EntityManager __EntityManager;
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    public void Execute(in global::Unity.Entities.ArchetypeChunk chunk, int chunkIndexInQuery, bool useEnabledMask, in global::Unity.Burst.Intrinsics.v128 chunkEnabledMask)
    {
        var managedOverrideManagedComponentAccessor = chunk.GetManagedComponentAccessor(ref __TypeHandle.__Pathfinding_ECS_ManagedMovementOverrideAfterControl_RW_ComponentTypeHandle, __EntityManager);
        var entityPointer = Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetChunkEntityArrayIntPtr(chunk, __TypeHandle.__Unity_Entities_Entity_TypeHandle);
        var localTransformArrayIntPtr = Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetChunkNativeArrayIntPtr<global::Unity.Transforms.LocalTransform>(chunk, ref __TypeHandle.__Unity_Transforms_LocalTransform_RW_ComponentTypeHandle);
        var shapeArrayIntPtr = Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetChunkNativeArrayIntPtr<global::Pathfinding.ECS.AgentCylinderShape>(chunk, ref __TypeHandle.__Pathfinding_ECS_AgentCylinderShape_RW_ComponentTypeHandle);
        var movementPlaneArrayIntPtr = Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetChunkNativeArrayIntPtr<global::Pathfinding.ECS.AgentMovementPlane>(chunk, ref __TypeHandle.__Pathfinding_ECS_AgentMovementPlane_RW_ComponentTypeHandle);
        var destinationArrayIntPtr = Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetChunkNativeArrayIntPtr<global::Pathfinding.ECS.DestinationPoint>(chunk, ref __TypeHandle.__Pathfinding_ECS_DestinationPoint_RW_ComponentTypeHandle);
        var movementStateArrayIntPtr = Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetChunkNativeArrayIntPtr<global::Pathfinding.ECS.MovementState>(chunk, ref __TypeHandle.__Pathfinding_ECS_MovementState_RW_ComponentTypeHandle);
        var movementSettingsArrayIntPtr = Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetChunkNativeArrayIntPtr<global::Pathfinding.ECS.MovementSettings>(chunk, ref __TypeHandle.__Pathfinding_ECS_MovementSettings_RW_ComponentTypeHandle);
        var movementControlArrayIntPtr = Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetChunkNativeArrayIntPtr<global::Pathfinding.ECS.MovementControl>(chunk, ref __TypeHandle.__Pathfinding_ECS_MovementControl_RW_ComponentTypeHandle);
        int chunkEntityCount = chunk.Count;
        int matchingEntityCount = 0;
        
        if (!useEnabledMask)
        {
            for(int entityIndexInChunk = 0; entityIndexInChunk < chunkEntityCount; ++entityIndexInChunk)
            {
                var retrievedByIndexInmanagedOverrideManagedComponentAccessor = managedOverrideManagedComponentAccessor[entityIndexInChunk];
                var entity = Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetCopyOfNativeArrayPtrElement<Entity>(entityPointer, entityIndexInChunk);
                ref var localTransformArrayIntPtrRef = ref Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::Unity.Transforms.LocalTransform>(localTransformArrayIntPtr, entityIndexInChunk);
                ref var shapeArrayIntPtrRef = ref Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::Pathfinding.ECS.AgentCylinderShape>(shapeArrayIntPtr, entityIndexInChunk);
                ref var movementPlaneArrayIntPtrRef = ref Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::Pathfinding.ECS.AgentMovementPlane>(movementPlaneArrayIntPtr, entityIndexInChunk);
                ref var destinationArrayIntPtrRef = ref Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::Pathfinding.ECS.DestinationPoint>(destinationArrayIntPtr, entityIndexInChunk);
                ref var movementStateArrayIntPtrRef = ref Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::Pathfinding.ECS.MovementState>(movementStateArrayIntPtr, entityIndexInChunk);
                ref var movementSettingsArrayIntPtrRef = ref Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::Pathfinding.ECS.MovementSettings>(movementSettingsArrayIntPtr, entityIndexInChunk);
                ref var movementControlArrayIntPtrRef = ref Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::Pathfinding.ECS.MovementControl>(movementControlArrayIntPtr, entityIndexInChunk);
                Execute(retrievedByIndexInmanagedOverrideManagedComponentAccessor,entity,ref localTransformArrayIntPtrRef,ref shapeArrayIntPtrRef,ref movementPlaneArrayIntPtrRef,ref destinationArrayIntPtrRef,ref movementStateArrayIntPtrRef,ref movementSettingsArrayIntPtrRef,ref movementControlArrayIntPtrRef);
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
                        var retrievedByIndexInmanagedOverrideManagedComponentAccessor = managedOverrideManagedComponentAccessor[entityIndexInChunk];
                        var entity = Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetCopyOfNativeArrayPtrElement<Entity>(entityPointer, entityIndexInChunk);
                        ref var localTransformArrayIntPtrRef = ref Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::Unity.Transforms.LocalTransform>(localTransformArrayIntPtr, entityIndexInChunk);
                        ref var shapeArrayIntPtrRef = ref Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::Pathfinding.ECS.AgentCylinderShape>(shapeArrayIntPtr, entityIndexInChunk);
                        ref var movementPlaneArrayIntPtrRef = ref Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::Pathfinding.ECS.AgentMovementPlane>(movementPlaneArrayIntPtr, entityIndexInChunk);
                        ref var destinationArrayIntPtrRef = ref Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::Pathfinding.ECS.DestinationPoint>(destinationArrayIntPtr, entityIndexInChunk);
                        ref var movementStateArrayIntPtrRef = ref Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::Pathfinding.ECS.MovementState>(movementStateArrayIntPtr, entityIndexInChunk);
                        ref var movementSettingsArrayIntPtrRef = ref Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::Pathfinding.ECS.MovementSettings>(movementSettingsArrayIntPtr, entityIndexInChunk);
                        ref var movementControlArrayIntPtrRef = ref Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::Pathfinding.ECS.MovementControl>(movementControlArrayIntPtr, entityIndexInChunk);
                        Execute(retrievedByIndexInmanagedOverrideManagedComponentAccessor,entity,ref localTransformArrayIntPtrRef,ref shapeArrayIntPtrRef,ref movementPlaneArrayIntPtrRef,ref destinationArrayIntPtrRef,ref movementStateArrayIntPtrRef,ref movementSettingsArrayIntPtrRef,ref movementControlArrayIntPtrRef);
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
                        var retrievedByIndexInmanagedOverrideManagedComponentAccessor = managedOverrideManagedComponentAccessor[entityIndexInChunk];
                        var entity = Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetCopyOfNativeArrayPtrElement<Entity>(entityPointer, entityIndexInChunk);
                        ref var localTransformArrayIntPtrRef = ref Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::Unity.Transforms.LocalTransform>(localTransformArrayIntPtr, entityIndexInChunk);
                        ref var shapeArrayIntPtrRef = ref Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::Pathfinding.ECS.AgentCylinderShape>(shapeArrayIntPtr, entityIndexInChunk);
                        ref var movementPlaneArrayIntPtrRef = ref Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::Pathfinding.ECS.AgentMovementPlane>(movementPlaneArrayIntPtr, entityIndexInChunk);
                        ref var destinationArrayIntPtrRef = ref Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::Pathfinding.ECS.DestinationPoint>(destinationArrayIntPtr, entityIndexInChunk);
                        ref var movementStateArrayIntPtrRef = ref Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::Pathfinding.ECS.MovementState>(movementStateArrayIntPtr, entityIndexInChunk);
                        ref var movementSettingsArrayIntPtrRef = ref Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::Pathfinding.ECS.MovementSettings>(movementSettingsArrayIntPtr, entityIndexInChunk);
                        ref var movementControlArrayIntPtrRef = ref Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::Pathfinding.ECS.MovementControl>(movementControlArrayIntPtr, entityIndexInChunk);
                        Execute(retrievedByIndexInmanagedOverrideManagedComponentAccessor,entity,ref localTransformArrayIntPtrRef,ref shapeArrayIntPtrRef,ref movementPlaneArrayIntPtrRef,ref destinationArrayIntPtrRef,ref movementStateArrayIntPtrRef,ref movementSettingsArrayIntPtrRef,ref movementControlArrayIntPtrRef);
                        matchingEntityCount++;
                    }
                    mask64 >>= 1;
                }
                mask64 = chunkEnabledMask.ULong1;
                for (int entityIndexInChunk = 64; entityIndexInChunk < chunkEntityCount; ++entityIndexInChunk)
                {
                    if ((mask64 & 1) != 0)
                    {
                        var retrievedByIndexInmanagedOverrideManagedComponentAccessor = managedOverrideManagedComponentAccessor[entityIndexInChunk];
                        var entity = Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetCopyOfNativeArrayPtrElement<Entity>(entityPointer, entityIndexInChunk);
                        ref var localTransformArrayIntPtrRef = ref Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::Unity.Transforms.LocalTransform>(localTransformArrayIntPtr, entityIndexInChunk);
                        ref var shapeArrayIntPtrRef = ref Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::Pathfinding.ECS.AgentCylinderShape>(shapeArrayIntPtr, entityIndexInChunk);
                        ref var movementPlaneArrayIntPtrRef = ref Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::Pathfinding.ECS.AgentMovementPlane>(movementPlaneArrayIntPtr, entityIndexInChunk);
                        ref var destinationArrayIntPtrRef = ref Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::Pathfinding.ECS.DestinationPoint>(destinationArrayIntPtr, entityIndexInChunk);
                        ref var movementStateArrayIntPtrRef = ref Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::Pathfinding.ECS.MovementState>(movementStateArrayIntPtr, entityIndexInChunk);
                        ref var movementSettingsArrayIntPtrRef = ref Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::Pathfinding.ECS.MovementSettings>(movementSettingsArrayIntPtr, entityIndexInChunk);
                        ref var movementControlArrayIntPtrRef = ref Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::Pathfinding.ECS.MovementControl>(movementControlArrayIntPtr, entityIndexInChunk);
                        Execute(retrievedByIndexInmanagedOverrideManagedComponentAccessor,entity,ref localTransformArrayIntPtrRef,ref shapeArrayIntPtrRef,ref movementPlaneArrayIntPtrRef,ref destinationArrayIntPtrRef,ref movementStateArrayIntPtrRef,ref movementSettingsArrayIntPtrRef,ref movementControlArrayIntPtrRef);
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
            public Unity.Entities.ComponentTypeHandle<global::Pathfinding.ECS.ManagedMovementOverrideAfterControl> __Pathfinding_ECS_ManagedMovementOverrideAfterControl_RW_ComponentTypeHandle;
            [global::Unity.Collections.ReadOnly] public global::Unity.Entities.EntityTypeHandle __Unity_Entities_Entity_TypeHandle;
            public Unity.Entities.ComponentTypeHandle<global::Unity.Transforms.LocalTransform> __Unity_Transforms_LocalTransform_RW_ComponentTypeHandle;
            public Unity.Entities.ComponentTypeHandle<global::Pathfinding.ECS.AgentCylinderShape> __Pathfinding_ECS_AgentCylinderShape_RW_ComponentTypeHandle;
            public Unity.Entities.ComponentTypeHandle<global::Pathfinding.ECS.AgentMovementPlane> __Pathfinding_ECS_AgentMovementPlane_RW_ComponentTypeHandle;
            public Unity.Entities.ComponentTypeHandle<global::Pathfinding.ECS.DestinationPoint> __Pathfinding_ECS_DestinationPoint_RW_ComponentTypeHandle;
            public Unity.Entities.ComponentTypeHandle<global::Pathfinding.ECS.MovementState> __Pathfinding_ECS_MovementState_RW_ComponentTypeHandle;
            public Unity.Entities.ComponentTypeHandle<global::Pathfinding.ECS.MovementSettings> __Pathfinding_ECS_MovementSettings_RW_ComponentTypeHandle;
            public Unity.Entities.ComponentTypeHandle<global::Pathfinding.ECS.MovementControl> __Pathfinding_ECS_MovementControl_RW_ComponentTypeHandle;
            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public void __AssignHandles(ref global::Unity.Entities.SystemState state)
            {
                __Pathfinding_ECS_ManagedMovementOverrideAfterControl_RW_ComponentTypeHandle = state.EntityManager.GetComponentTypeHandle<global::Pathfinding.ECS.ManagedMovementOverrideAfterControl>(false);
                __Unity_Entities_Entity_TypeHandle = state.GetEntityTypeHandle();
                __Unity_Transforms_LocalTransform_RW_ComponentTypeHandle = state.GetComponentTypeHandle<global::Unity.Transforms.LocalTransform>(false);
                __Pathfinding_ECS_AgentCylinderShape_RW_ComponentTypeHandle = state.GetComponentTypeHandle<global::Pathfinding.ECS.AgentCylinderShape>(false);
                __Pathfinding_ECS_AgentMovementPlane_RW_ComponentTypeHandle = state.GetComponentTypeHandle<global::Pathfinding.ECS.AgentMovementPlane>(false);
                __Pathfinding_ECS_DestinationPoint_RW_ComponentTypeHandle = state.GetComponentTypeHandle<global::Pathfinding.ECS.DestinationPoint>(false);
                __Pathfinding_ECS_MovementState_RW_ComponentTypeHandle = state.GetComponentTypeHandle<global::Pathfinding.ECS.MovementState>(false);
                __Pathfinding_ECS_MovementSettings_RW_ComponentTypeHandle = state.GetComponentTypeHandle<global::Pathfinding.ECS.MovementSettings>(false);
                __Pathfinding_ECS_MovementControl_RW_ComponentTypeHandle = state.GetComponentTypeHandle<global::Pathfinding.ECS.MovementControl>(false);
            }
            
            public void Update(ref global::Unity.Entities.SystemState state)
            {
                __Pathfinding_ECS_ManagedMovementOverrideAfterControl_RW_ComponentTypeHandle.Update(ref state);
                __Unity_Entities_Entity_TypeHandle.Update(ref state);
                __Unity_Transforms_LocalTransform_RW_ComponentTypeHandle.Update(ref state);
                __Pathfinding_ECS_AgentCylinderShape_RW_ComponentTypeHandle.Update(ref state);
                __Pathfinding_ECS_AgentMovementPlane_RW_ComponentTypeHandle.Update(ref state);
                __Pathfinding_ECS_DestinationPoint_RW_ComponentTypeHandle.Update(ref state);
                __Pathfinding_ECS_MovementState_RW_ComponentTypeHandle.Update(ref state);
                __Pathfinding_ECS_MovementSettings_RW_ComponentTypeHandle.Update(ref state);
                __Pathfinding_ECS_MovementControl_RW_ComponentTypeHandle.Update(ref state);
            }
            
        }
        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        void __AssignQueries(ref global::Unity.Entities.SystemState state)
        {
            var entityQueryBuilder = new global::Unity.Entities.EntityQueryBuilder(global::Unity.Collections.Allocator.Temp);
            DefaultQuery = 
                entityQueryBuilder
                    .WithAllRW<global::Pathfinding.ECS.ManagedMovementOverrideAfterControl>()
                    .WithAllRW<global::Unity.Transforms.LocalTransform>()
                    .WithAllRW<global::Pathfinding.ECS.AgentCylinderShape>()
                    .WithAllRW<global::Pathfinding.ECS.AgentMovementPlane>()
                    .WithAllRW<global::Pathfinding.ECS.DestinationPoint>()
                    .WithAllRW<global::Pathfinding.ECS.MovementState>()
                    .WithAllRW<global::Pathfinding.ECS.MovementSettings>()
                    .WithAllRW<global::Pathfinding.ECS.MovementControl>()
                    .Build(ref state);
            entityQueryBuilder.Reset();
            entityQueryBuilder.Dispose();
        }
        
        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static int GetRequiredComponentTypeCount() => 8;
        
        public static void AddRequiredComponentTypes(ref global::System.Span<Unity.Entities.ComponentType> components)
        {
            components[0] = Unity.Entities.ComponentType.ReadWrite<global::Pathfinding.ECS.ManagedMovementOverrideAfterControl>();
            components[1] = Unity.Entities.ComponentType.ReadWrite<global::Unity.Transforms.LocalTransform>();
            components[2] = Unity.Entities.ComponentType.ReadWrite<global::Pathfinding.ECS.AgentCylinderShape>();
            components[3] = Unity.Entities.ComponentType.ReadWrite<global::Pathfinding.ECS.AgentMovementPlane>();
            components[4] = Unity.Entities.ComponentType.ReadWrite<global::Pathfinding.ECS.DestinationPoint>();
            components[5] = Unity.Entities.ComponentType.ReadWrite<global::Pathfinding.ECS.MovementState>();
            components[6] = Unity.Entities.ComponentType.ReadWrite<global::Pathfinding.ECS.MovementSettings>();
            components[7] = Unity.Entities.ComponentType.ReadWrite<global::Pathfinding.ECS.MovementControl>();
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
        public void Run(ref global::Pathfinding.ECS.JobManagedMovementOverrideAfterControl job, global::Unity.Entities.EntityQuery query)
        {
            job.__TypeHandle = __TypeHandle;
            global::Unity.Entities.Internal.InternalCompilerInterface.JobChunkInterface.RunByRefWithoutJobs(ref job, query);
        }
        
        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Unity.Jobs.JobHandle Schedule(ref global::Pathfinding.ECS.JobManagedMovementOverrideAfterControl job, global::Unity.Entities.EntityQuery query, global::Unity.Jobs.JobHandle dependency)
        {
            job.__TypeHandle = __TypeHandle;
            return global::Unity.Entities.JobChunkExtensions.ScheduleByRef(ref job, query, dependency);
        }
        
        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Unity.Jobs.JobHandle ScheduleParallel(ref global::Pathfinding.ECS.JobManagedMovementOverrideAfterControl job, global::Unity.Entities.EntityQuery query, global::Unity.Jobs.JobHandle dependency)
        {
            job.__TypeHandle = __TypeHandle;
            return global::Unity.Entities.JobChunkExtensions.ScheduleParallelByRef(ref job, query, dependency);
        }
        
        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void UpdateBaseEntityIndexArray(ref global::Pathfinding.ECS.JobManagedMovementOverrideAfterControl job, global::Unity.Entities.EntityQuery query, ref global::Unity.Entities.SystemState state)
        {
        }
        
        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Unity.Jobs.JobHandle UpdateBaseEntityIndexArray(ref global::Pathfinding.ECS.JobManagedMovementOverrideAfterControl job, global::Unity.Entities.EntityQuery query, global::Unity.Jobs.JobHandle dependency, ref global::Unity.Entities.SystemState state)
        {
            return dependency;
        }
        
        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void AssignEntityManager(ref global::Pathfinding.ECS.JobManagedMovementOverrideAfterControl job, global::Unity.Entities.EntityManager entityManager)
        {
            job.__EntityManager = entityManager;
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
            if(scheduleType == 2) throw new global::System.InvalidOperationException("Tried to ScheduleParallel a job with a managed execute signature. Please use .Run or .Schedule instead.");
        }
    }
}


}