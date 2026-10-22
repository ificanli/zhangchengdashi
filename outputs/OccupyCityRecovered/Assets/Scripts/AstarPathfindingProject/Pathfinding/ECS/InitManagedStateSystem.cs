using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Entities;

namespace Pathfinding.ECS
{
	[Token(Token = "0x2000378")]
	[UpdateBefore(typeof(SchedulePathSearchSystem))]
	[UpdateBefore(typeof(MovementPlaneFromGraphSystem))]
	[UpdateInGroup(typeof(AIMovementSystemGroup))]
	[RequireMatchingQueriesForUpdate]
	public partial struct InitManagedStateSystem : ISystem, ISystemCompilerGenerated
	{
		[Token(Token = "0x2000379")]
		private struct TypeHandle
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6001638")]
			[Address(RVA = "0x44D42D4", Offset = "0x44D02D4", VA = "0x44D42D4")]
			public void __AssignHandles(ref SystemState state)
			{
			}
		}

		[Token(Token = "0x4000F07")]
		[FieldOffset(Offset = "0x0")]
		private TypeHandle __TypeHandle;

		[Token(Token = "0x4000F08")]
		[FieldOffset(Offset = "0x8")]
		private EntityQuery __query_1374900497_0;

		[Token(Token = "0x6001633")]
		[Address(RVA = "0x44D3FE0", Offset = "0x44CFFE0", VA = "0x44D3FE0", Slot = "6")]
		public void OnUpdate(ref SystemState state)
		{
            var entities = __query_1374900497_0.ToEntityArray(Unity.Collections.Allocator.Temp);
            var manager = state.EntityManager;
            manager.AddComponent<ManagedState>(entities);
            for (int i = 0; i < entities.Length; i++) {
                var managedState = new ManagedState();
                managedState.pathTracer = new PathTracer(Unity.Collections.Allocator.Persistent);
                manager.SetComponentData(entities[i], managedState);
            }
            for (int i = 0; i < entities.Length; i++) {
                var proxy = new FollowerEntityProxy(state.World, entities[i]);
                proxy.Teleport(proxy.position, false);
            }
        }

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6001634")]
		[Address(RVA = "0x44D41F0", Offset = "0x44D01F0", VA = "0x44D41F0")]
		private void __AssignQueries(ref SystemState state)
		{
            var builder = new EntityQueryBuilder(Unity.Collections.Allocator.Temp);
            __query_1374900497_0 = builder.WithAll<ManagedSettings>().WithNone<ManagedState>().Build(ref state);
            builder.Reset();
            builder.Dispose();
        }

		[Token(Token = "0x6001635")]
		[Address(RVA = "0x44D42CC", Offset = "0x44D02CC", VA = "0x44D42CC", Slot = "7")]
		public void OnCreateForCompiler(ref SystemState state)
		{
            __AssignQueries(ref state);
        }
	}
}
