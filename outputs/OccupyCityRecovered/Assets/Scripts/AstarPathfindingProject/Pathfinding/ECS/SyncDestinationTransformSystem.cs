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
	[CompilerGenerated]
	public partial struct SyncDestinationTransformSystem : ISystem, ISystemCompilerGenerated
	{
		[Token(Token = "0x20003A3")]
		private readonly struct IFE_315116516_0
		{
			[Token(Token = "0x20003A4")]
			public struct ResolvedChunk
			{
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                public ComponentTypeHandle<DestinationPoint> item1_TypeHandle;
#endif

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
#if ENABLE_UNITY_COLLECTIONS_CHECKS
					return (InternalCompilerInterface.UnsafeGetUncheckedRefRW<DestinationPoint>(item1_IntPtr, index, ref item1_TypeHandle), new SystemAPI.ManagedAPI.UnityEngineComponent<AIDestinationSetter>(item2_ManagedComponentAccessor[index]));
#else
					return (InternalCompilerInterface.UnsafeGetUncheckedRefRW<DestinationPoint>(item1_IntPtr, index), new SystemAPI.ManagedAPI.UnityEngineComponent<AIDestinationSetter>(item2_ManagedComponentAccessor[index]));
#endif
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
					_entityManager = systemState.EntityManager;
					item1_ComponentTypeHandle_RW = systemState.GetComponentTypeHandle<DestinationPoint>(false);
					item2_ManagedComponentTypeHandle_RO = systemState.EntityManager.GetComponentTypeHandle<AIDestinationSetter>(false);
				}

				[Token(Token = "0x6001761")]
				[Address(RVA = "0x44DD0EC", Offset = "0x44D90EC", VA = "0x44DD0EC")]
				public void Update(ref SystemState systemState)
				{
					item1_ComponentTypeHandle_RW.Update(ref systemState);
					item2_ManagedComponentTypeHandle_RO.Update(ref systemState);
				}

				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				[Token(Token = "0x6001762")]
				[Address(RVA = "0x44DD168", Offset = "0x44D9168", VA = "0x44DD168")]
				public ResolvedChunk Resolve(ArchetypeChunk archetypeChunk)
				{
					ResolvedChunk resolvedChunk = new ResolvedChunk();
#if ENABLE_UNITY_COLLECTIONS_CHECKS
					resolvedChunk.item1_TypeHandle = item1_ComponentTypeHandle_RW;
#endif
					resolvedChunk.item1_IntPtr = InternalCompilerInterface.UnsafeGetChunkNativeArrayIntPtrWithoutChecks<DestinationPoint>(in archetypeChunk, ref item1_ComponentTypeHandle_RW);
					resolvedChunk.item2_ManagedComponentAccessor = archetypeChunk.GetManagedComponentAccessor(ref item2_ManagedComponentTypeHandle_RO, _entityManager);
					return resolvedChunk;
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
					return _resolvedChunk.Get(_currentEntityIndex);
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
					if (!entityQuery.IsEmptyIgnoreFilter)
					{
					    CompleteDependencies(ref state);
					    typeHandle.Update(ref state);
					}
					_entityQueryEnumerator = new InternalEntityQueryEnumerator(entityQuery);
					_typeHandle = typeHandle;
					_resolvedChunk = default;
					_currentEntityIndex = -1;
					_endEntityIndex = -1;
				}

				[Token(Token = "0x6001764")]
				[Address(RVA = "0x44DD278", Offset = "0x44D9278", VA = "0x44DD278", Slot = "5")]
				public void Dispose()
				{
					_entityQueryEnumerator.Dispose();
				}

				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				[Token(Token = "0x6001765")]
				[Address(RVA = "0x44DD280", Offset = "0x44D9280", VA = "0x44DD280", Slot = "6")]
				public bool MoveNext()
				{
					if (++_currentEntityIndex < _endEntityIndex)
					{
					    return true;
					}
					if (_entityQueryEnumerator.MoveNextEntityRange(out bool movedToNewChunk, out ArchetypeChunk chunk, out int startIndex, out int endIndex))
					{
					    if (movedToNewChunk)
					    {
					        _resolvedChunk = _typeHandle.Resolve(chunk);
					    }
					    _currentEntityIndex = startIndex;
					    _endEntityIndex = endIndex;
					    return true;
					}
					return false;
				}

				[Token(Token = "0x6001767")]
				[Address(RVA = "0x44DCBC4", Offset = "0x44D8BC4", VA = "0x44DCBC4")]
				public Enumerator GetEnumerator()
				{
					return this;
				}

				[Token(Token = "0x6001768")]
				[Address(RVA = "0x44DD354", Offset = "0x44D9354", VA = "0x44DD354", Slot = "8")]
				public void Reset()
				{
					throw new NotImplementedException();
				}

				[Token(Token = "0x6001769")]
				[Address(RVA = "0x44DD38C", Offset = "0x44D938C", VA = "0x44DD38C", Slot = "7")]
				private object global_003A_003ASystem_002ECollections_002EIEnumerator_002Eget_Current()
				{
					throw new NotImplementedException();
				}
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x600175D")]
			[Address(RVA = "0x44DCD1C", Offset = "0x44D8D1C", VA = "0x44DCD1C")]
			public static Enumerator Query(EntityQuery entityQuery, TypeHandle typeHandle, ref SystemState state)
			{
				return new Enumerator(entityQuery, typeHandle, ref state);
			}

			[Token(Token = "0x600175E")]
			[Address(RVA = "0x44DCE68", Offset = "0x44D8E68", VA = "0x44DCE68")]
			public static void CompleteDependencies(ref SystemState state)
			{
				state.EntityManager.CompleteDependencyBeforeRW<DestinationPoint>();
				state.EntityManager.CompleteDependencyBeforeRW<AIDestinationSetter>();
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
				__IFE_315116516_0_TypeHandle = new IFE_315116516_0.TypeHandle(ref state);
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
			if (!AIMovementSystemGroup.TimeScaledRateManager.IsFirstSubstep)
			{
			    return;
			}
			foreach (var item in IFE_315116516_0.Query(__query_315116516_0, __TypeHandle.__IFE_315116516_0_TypeHandle, ref systemState))
			{
			    AIDestinationSetter setter = item.Item2.Value;
			    if (setter.target != null)
			    {
			        ref DestinationPoint point = ref item.Item1.ValueRW;
			        Unity.Mathematics.float3 destination = setter.target.position;
			        Unity.Mathematics.float3 facingDirection = setter.useRotation ? setter.target.forward : UnityEngine.Vector3.zero;
			        point.destination = destination;
			        point.facingDirection = facingDirection;
			    }
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6001759")]
		[Address(RVA = "0x44DCBE4", Offset = "0x44D8BE4", VA = "0x44DCBE4")]
		private void __AssignQueries(ref SystemState state)
		{
			EntityQueryBuilder builder = new EntityQueryBuilder(Allocator.Temp);
			__query_315116516_0 = builder.WithAllRW<DestinationPoint>().WithAllRW<AIDestinationSetter>().Build(ref state);
			builder.Reset();
			builder.Dispose();
		}

		[Token(Token = "0x600175A")]
		[Address(RVA = "0x44DCCC0", Offset = "0x44D8CC0", VA = "0x44DCCC0", Slot = "7")]
		public void OnCreateForCompiler(ref SystemState state)
		{
			__AssignQueries(ref state);
			__TypeHandle.__AssignHandles(ref state);
		}
	}
}
