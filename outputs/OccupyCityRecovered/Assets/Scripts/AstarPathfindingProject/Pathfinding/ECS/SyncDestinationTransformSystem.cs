using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.Internal;

namespace Pathfinding.ECS
{
	[Token(Token = "0x20003A2")]
	[UpdateBefore(typeof(SchedulePathSearchSystem))]
	[UpdateInGroup(typeof(AIMovementSystemGroup))]
	[RequireMatchingQueriesForUpdate]
	public partial struct SyncDestinationTransformSystem : ISystem, ISystemCompilerGenerated
	{
		[Token(Token = "0x20003A3")]
		private readonly struct IFE_315116516_0
		{
			[Token(Token = "0x20003A4")]
			public struct ResolvedChunk
			{
				[Token(Token = "0x4000F67")]
				[FieldOffset(Offset = "0x0")]
				public IntPtr item1_IntPtr;

				[Token(Token = "0x4000F68")]
				[FieldOffset(Offset = "0x8")]
				public ManagedComponentAccessor<AIDestinationSetter> item2_ManagedComponentAccessor;

				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				[Token(Token = "0x600175F")]
				[Address(RVA = "0x44DCF10", Offset = "0x44D8F10", VA = "0x44DCF10")]
				public (InternalCompilerInterface.UncheckedRefRW<DestinationPoint>, SystemAPI.ManagedAPI.UnityEngineComponent<AIDestinationSetter>) Get(int index)
				{
					return default;
				}
			}

			[Token(Token = "0x20003A5")]
			public struct TypeHandle
			{
				[Token(Token = "0x4000F69")]
				[FieldOffset(Offset = "0x0")]
				public EntityManager _entityManager;

				[Token(Token = "0x4000F6A")]
				[FieldOffset(Offset = "0x8")]
				private ComponentTypeHandle<DestinationPoint> item1_ComponentTypeHandle_RW;

				[Token(Token = "0x4000F6B")]
				[FieldOffset(Offset = "0x30")]
				[ReadOnly]
				private ComponentTypeHandle<AIDestinationSetter> item2_ManagedComponentTypeHandle_RO;

				[Token(Token = "0x6001760")]
				[Address(RVA = "0x44DCFF0", Offset = "0x44D8FF0", VA = "0x44DCFF0")]
				public TypeHandle(ref SystemState systemState)
				{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED SyncDestinationTransformSystem.IFE_315116516_0.TypeHandle..ctor RVA=0x44DCFF0 Token=0x6001760");
}

				[Token(Token = "0x6001761")]
				[Address(RVA = "0x44DD0EC", Offset = "0x44D90EC", VA = "0x44DD0EC")]
				public void Update(ref SystemState systemState)
				{
				}

				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				[Token(Token = "0x6001762")]
				[Address(RVA = "0x44DD168", Offset = "0x44D9168", VA = "0x44DD168")]
				public ResolvedChunk Resolve(ArchetypeChunk archetypeChunk)
				{
					return default;
				}
			}

			[Token(Token = "0x20003A6")]
			public struct Enumerator : IEnumerator<(InternalCompilerInterface.UncheckedRefRW<DestinationPoint>, SystemAPI.ManagedAPI.UnityEngineComponent<AIDestinationSetter>)>, IEnumerator, IDisposable
			{
				[Token(Token = "0x4000F6C")]
				[FieldOffset(Offset = "0x0")]
				private InternalEntityQueryEnumerator _entityQueryEnumerator;

				[Token(Token = "0x4000F6D")]
				[FieldOffset(Offset = "0xF8")]
				private TypeHandle _typeHandle;

				[Token(Token = "0x4000F6E")]
				[FieldOffset(Offset = "0x150")]
				private ResolvedChunk _resolvedChunk;

				[Token(Token = "0x4000F6F")]
				[FieldOffset(Offset = "0x178")]
				private int _currentEntityIndex;

				[Token(Token = "0x4000F70")]
				[FieldOffset(Offset = "0x17C")]
				private int _endEntityIndex;

				[Token(Token = "0x17000327")]
				public (InternalCompilerInterface.UncheckedRefRW<DestinationPoint>, SystemAPI.ManagedAPI.UnityEngineComponent<AIDestinationSetter>) Current
				{
					[Token(Token = "0x6001766")]
					[Address(RVA = "0x44DCBD4", Offset = "0x44D8BD4", VA = "0x44DCBD4", Slot = "4")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x17000328")]
object System.Collections.IEnumerator.Current				{
					[Token(Token = "0x6001769")]
					[Address(RVA = "0x44DD38C", Offset = "0x44D938C", VA = "0x44DD38C", Slot = "7")]
					get
					{
						return global_003A_003ASystem_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x6001763")]
				[Address(RVA = "0x44DCD8C", Offset = "0x44D8D8C", VA = "0x44DCD8C")]
				public Enumerator(EntityQuery entityQuery, TypeHandle typeHandle, ref SystemState state)
				{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED SyncDestinationTransformSystem.IFE_315116516_0.Enumerator..ctor RVA=0x44DCD8C Token=0x6001763");
}

				[Token(Token = "0x6001764")]
				[Address(RVA = "0x44DD278", Offset = "0x44D9278", VA = "0x44DD278", Slot = "5")]
				public void Dispose()
				{
				}

				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				[Token(Token = "0x6001765")]
				[Address(RVA = "0x44DD280", Offset = "0x44D9280", VA = "0x44DD280", Slot = "6")]
				public bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x6001767")]
				[Address(RVA = "0x44DCBC4", Offset = "0x44D8BC4", VA = "0x44DCBC4")]
				public Enumerator GetEnumerator()
				{
					return default;
				}

				[Token(Token = "0x6001768")]
				[Address(RVA = "0x44DD354", Offset = "0x44D9354", VA = "0x44DD354", Slot = "8")]
				public void Reset()
				{
				}

				[Token(Token = "0x6001769")]
				[Address(RVA = "0x44DD38C", Offset = "0x44D938C", VA = "0x44DD38C", Slot = "7")]
				private object global_003A_003ASystem_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x600175D")]
			[Address(RVA = "0x44DCD1C", Offset = "0x44D8D1C", VA = "0x44DCD1C")]
			public static Enumerator Query(EntityQuery entityQuery, TypeHandle typeHandle, ref SystemState state)
			{
				return default;
			}

			[Token(Token = "0x600175E")]
			[Address(RVA = "0x44DCE68", Offset = "0x44D8E68", VA = "0x44DCE68")]
			public static void CompleteDependencies(ref SystemState state)
			{
			}
		}

		[Token(Token = "0x20003A7")]
		private struct TypeHandle
		{
			[Token(Token = "0x4000F71")]
			[FieldOffset(Offset = "0x0")]
			public IFE_315116516_0.TypeHandle __IFE_315116516_0_TypeHandle;

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x600176A")]
			[Address(RVA = "0x44DD3C4", Offset = "0x44D93C4", VA = "0x44DD3C4")]
			public void __AssignHandles(ref SystemState state)
			{
			}
		}

		[Token(Token = "0x4000F65")]
		[FieldOffset(Offset = "0x0")]
		private TypeHandle __TypeHandle;

		[Token(Token = "0x4000F66")]
		[FieldOffset(Offset = "0x58")]
		private EntityQuery __query_315116516_0;

		[Token(Token = "0x6001758")]
		[Address(RVA = "0x44DC878", Offset = "0x44D8878", VA = "0x44DC878", Slot = "6")]
		public void OnUpdate(ref SystemState systemState)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6001759")]
		[Address(RVA = "0x44DCBE4", Offset = "0x44D8BE4", VA = "0x44DCBE4")]
		private void __AssignQueries(ref SystemState state)
		{
		}

		[Token(Token = "0x600175A")]
		[Address(RVA = "0x44DCCC0", Offset = "0x44D8CC0", VA = "0x44DCCC0", Slot = "7")]
		public void OnCreateForCompiler(ref SystemState state)
		{
		}
	}
}
