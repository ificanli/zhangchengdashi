using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.Internal;
using Unity.Jobs;

namespace Pathfinding.ECS
{
	[Token(Token = "0x20003AB")]
	[UpdateInGroup(typeof(AIMovementSystemGroup))]
	[UpdateBefore(typeof(FollowerControlSystem))]
	[UpdateBefore(typeof(RepairPathSystem))]
	public partial struct TraverseOffMeshLinkSystem : ISystem, ISystemCompilerGenerated
	{
		[Token(Token = "0x20003AC")]
		private readonly struct IFE_1565301199_0
		{
			[Token(Token = "0x20003AD")]
			public struct ResolvedChunk
			{
				[Token(Token = "0x4000F86")]
				[FieldOffset(Offset = "0x0")]
				public ManagedComponentAccessor<ManagedState> item1_ManagedComponentAccessor;

				[Token(Token = "0x4000F87")]
				[FieldOffset(Offset = "0x20")]
				public ManagedComponentAccessor<ManagedSettings> item2_ManagedComponentAccessor;

				[Token(Token = "0x4000F88")]
				[FieldOffset(Offset = "0x40")]
				public IntPtr Entity_IntPtr;

				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				[Token(Token = "0x6001784")]
				[Address(RVA = "0x44DEF48", Offset = "0x44DAF48", VA = "0x44DEF48")]
				public QueryEnumerableWithEntity<ManagedState, ManagedSettings> Get(int index)
				{
					return default;
				}
			}

			[Token(Token = "0x20003AE")]
			public struct TypeHandle
			{
				[Token(Token = "0x4000F89")]
				[FieldOffset(Offset = "0x0")]
				public EntityManager _entityManager;

				[Token(Token = "0x4000F8A")]
				[FieldOffset(Offset = "0x8")]
				[ReadOnly]
				private ComponentTypeHandle<ManagedState> item1_ManagedComponentTypeHandle_RO;

				[Token(Token = "0x4000F8B")]
				[FieldOffset(Offset = "0x30")]
				[ReadOnly]
				private ComponentTypeHandle<ManagedSettings> item2_ManagedComponentTypeHandle_RO;

				[Token(Token = "0x4000F8C")]
				[FieldOffset(Offset = "0x58")]
				private EntityTypeHandle Entity_TypeHandle;

				[Token(Token = "0x6001785")]
				[Address(RVA = "0x44DF03C", Offset = "0x44DB03C", VA = "0x44DF03C")]
				public TypeHandle(ref SystemState systemState)
				{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TraverseOffMeshLinkSystem.IFE_1565301199_0.TypeHandle..ctor RVA=0x44DF03C Token=0x6001785");
}

				[Token(Token = "0x6001786")]
				[Address(RVA = "0x44DF140", Offset = "0x44DB140", VA = "0x44DF140")]
				public void Update(ref SystemState systemState)
				{
				}

				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				[Token(Token = "0x6001787")]
				[Address(RVA = "0x44DF1CC", Offset = "0x44DB1CC", VA = "0x44DF1CC")]
				public ResolvedChunk Resolve(ArchetypeChunk archetypeChunk)
				{
					return default;
				}
			}

			[Token(Token = "0x20003AF")]
			public struct Enumerator : IEnumerator<QueryEnumerableWithEntity<ManagedState, ManagedSettings>>, IEnumerator, IDisposable
			{
				[Token(Token = "0x4000F8D")]
				[FieldOffset(Offset = "0x0")]
				private InternalEntityQueryEnumerator _entityQueryEnumerator;

				[Token(Token = "0x4000F8E")]
				[FieldOffset(Offset = "0xF8")]
				private TypeHandle _typeHandle;

				[Token(Token = "0x4000F8F")]
				[FieldOffset(Offset = "0x158")]
				private ResolvedChunk _resolvedChunk;

				[Token(Token = "0x4000F90")]
				[FieldOffset(Offset = "0x1A0")]
				private int _currentEntityIndex;

				[Token(Token = "0x4000F91")]
				[FieldOffset(Offset = "0x1A4")]
				private int _endEntityIndex;

				[Token(Token = "0x17000329")]
				public QueryEnumerableWithEntity<ManagedState, ManagedSettings> Current
				{
					[Token(Token = "0x600178B")]
					[Address(RVA = "0x44DE9F0", Offset = "0x44DA9F0", VA = "0x44DE9F0", Slot = "4")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x1700032A")]
object System.Collections.IEnumerator.Current				{
					[Token(Token = "0x600178E")]
					[Address(RVA = "0x44DF46C", Offset = "0x44DB46C", VA = "0x44DF46C", Slot = "7")]
					get
					{
						return global_003A_003ASystem_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x6001788")]
				[Address(RVA = "0x44DEDBC", Offset = "0x44DADBC", VA = "0x44DEDBC")]
				public Enumerator(EntityQuery entityQuery, TypeHandle typeHandle, ref SystemState state)
				{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TraverseOffMeshLinkSystem.IFE_1565301199_0.Enumerator..ctor RVA=0x44DEDBC Token=0x6001788");
}

				[Token(Token = "0x6001789")]
				[Address(RVA = "0x44DF2C8", Offset = "0x44DB2C8", VA = "0x44DF2C8", Slot = "5")]
				public void Dispose()
				{
				}

				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				[Token(Token = "0x600178A")]
				[Address(RVA = "0x44DF2D0", Offset = "0x44DB2D0", VA = "0x44DF2D0", Slot = "6")]
				public bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x600178C")]
				[Address(RVA = "0x44DE9E0", Offset = "0x44DA9E0", VA = "0x44DE9E0")]
				public Enumerator GetEnumerator()
				{
					return default;
				}

				[Token(Token = "0x600178D")]
				[Address(RVA = "0x44DF434", Offset = "0x44DB434", VA = "0x44DF434", Slot = "8")]
				public void Reset()
				{
				}

				[Token(Token = "0x600178E")]
				[Address(RVA = "0x44DF46C", Offset = "0x44DB46C", VA = "0x44DF46C", Slot = "7")]
				private object global_003A_003ASystem_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6001782")]
			[Address(RVA = "0x44DED4C", Offset = "0x44DAD4C", VA = "0x44DED4C")]
			public static Enumerator Query(EntityQuery entityQuery, TypeHandle typeHandle, ref SystemState state)
			{
				return default;
			}

			[Token(Token = "0x6001783")]
			[Address(RVA = "0x44DEEA0", Offset = "0x44DAEA0", VA = "0x44DEEA0")]
			public static void CompleteDependencies(ref SystemState state)
			{
			}
		}

		[Token(Token = "0x20003B0")]
		private struct TypeHandle
		{
			[Token(Token = "0x4000F92")]
			[FieldOffset(Offset = "0x0")]
			public IFE_1565301199_0.TypeHandle __IFE_1565301199_0_TypeHandle;

			[Token(Token = "0x4000F93")]
			[FieldOffset(Offset = "0x60")]
			public JobManagedOffMeshLinkTransition.InternalCompilerQueryAndHandleData __Pathfinding_ECS_JobManagedOffMeshLinkTransition_WithDefaultQuery_JobEntityTypeHandle;

			[Token(Token = "0x4000F94")]
			[FieldOffset(Offset = "0x1E0")]
			public JobManagedOffMeshLinkTransitionCleanup.InternalCompilerQueryAndHandleData __Pathfinding_ECS_JobManagedOffMeshLinkTransitionCleanup_WithoutDefaultQuery_JobEntityTypeHandle;

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x600178F")]
			[Address(RVA = "0x44DF4A4", Offset = "0x44DB4A4", VA = "0x44DF4A4")]
			public void __AssignHandles(ref SystemState state)
			{
			}
		}

		[Token(Token = "0x4000F80")]
		[FieldOffset(Offset = "0x0")]
		private EntityQuery entityQueryPrepare;

		[Token(Token = "0x4000F81")]
		[FieldOffset(Offset = "0x10")]
		private EntityQuery entityQueryOffMeshLinkCleanup;

		[Token(Token = "0x4000F82")]
		[FieldOffset(Offset = "0x20")]
		public JobRepairPath.Scheduler jobRepairPathScheduler;

		[Token(Token = "0x4000F83")]
		[FieldOffset(Offset = "0x198")]
		private TypeHandle __TypeHandle;

		[Token(Token = "0x4000F84")]
		[FieldOffset(Offset = "0x3B0")]
		private EntityQuery __query_1565301199_0;

		[Token(Token = "0x4000F85")]
		[FieldOffset(Offset = "0x3C0")]
		private EntityQuery __query_1565301199_1;

		[Token(Token = "0x6001773")]
		[Address(RVA = "0x44DE080", Offset = "0x44DA080", VA = "0x44DE080", Slot = "4")]
		public void OnCreate(ref SystemState state)
		{
		}

		[Token(Token = "0x6001774")]
		[Address(RVA = "0x44DE218", Offset = "0x44DA218", VA = "0x44DE218", Slot = "5")]
		public void OnDestroy(ref SystemState state)
		{
		}

		[Token(Token = "0x6001775")]
		[Address(RVA = "0x44DE224", Offset = "0x44DA224", VA = "0x44DE224", Slot = "6")]
		public void OnUpdate(ref SystemState systemState)
		{
		}

		[Token(Token = "0x6001776")]
		[Address(RVA = "0x44DE378", Offset = "0x44DA378", VA = "0x44DE378")]
		private void StartOffMeshLinkTraversal(ref SystemState systemState, EntityCommandBuffer commandBuffer)
		{
		}

		[Token(Token = "0x6001777")]
		[Address(RVA = "0x44D964C", Offset = "0x44D564C", VA = "0x44D964C")]
		public static OffMeshLinks.OffMeshLinkTracer NextLinkToTraverse(ManagedState state)
		{
			return default;
		}

		[Token(Token = "0x6001778")]
		[Address(RVA = "0x44D96DC", Offset = "0x44D56DC", VA = "0x44D96DC")]
		public static IOffMeshLinkHandler ResolveOffMeshLinkHandler(ManagedSettings settings, AgentOffMeshLinkTraversalContext ctx)
		{
			return null;
		}

		[Token(Token = "0x6001779")]
		[Address(RVA = "0x44DE720", Offset = "0x44DA720", VA = "0x44DE720")]
		private void ProcessActiveOffMeshLinkTraversal(ref SystemState systemState)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600177A")]
		[Address(RVA = "0x44DEA2C", Offset = "0x44DAA2C", VA = "0x44DEA2C")]
		private void __ScheduleViaJobChunkExtension_0(JobManagedOffMeshLinkTransition job, EntityQuery query, JobHandle dependency, ref SystemState state, bool hasUserDefinedQuery)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600177B")]
		[Address(RVA = "0x44DEAB8", Offset = "0x44DAAB8", VA = "0x44DEAB8")]
		private void __ScheduleViaJobChunkExtension_1(JobManagedOffMeshLinkTransitionCleanup job, EntityQuery query, JobHandle dependency, ref SystemState state, bool hasUserDefinedQuery)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600177C")]
		[Address(RVA = "0x44DEB44", Offset = "0x44DAB44", VA = "0x44DEB44")]
		private void __AssignQueries(ref SystemState state)
		{
		}

		[Token(Token = "0x600177D")]
		[Address(RVA = "0x44DECCC", Offset = "0x44DACCC", VA = "0x44DECCC", Slot = "7")]
		public void OnCreateForCompiler(ref SystemState state)
		{
		}
	}
}
