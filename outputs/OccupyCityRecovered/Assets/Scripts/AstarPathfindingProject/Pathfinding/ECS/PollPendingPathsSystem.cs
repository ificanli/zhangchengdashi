using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.Internal;

namespace Pathfinding.ECS
{
	[Token(Token = "0x200038B")]
	[BurstCompile]
	public partial struct PollPendingPathsSystem : ISystem, ISystemCompilerGenerated
	{
		[Token(Token = "0x200038C")]
		private readonly struct IFE_1964892062_0
		{
			[Token(Token = "0x200038D")]
			public struct ResolvedChunk
			{
				[Token(Token = "0x4000F35")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public ManagedComponentAccessor<ManagedState> item1_ManagedComponentAccessor;

				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				[Token(Token = "0x60016C1")]
				[Address(RVA = "0x44D8F38", Offset = "0x44D4F38", VA = "0x44D8F38")]
				public ManagedState Get(int index)
				{
					return null;
				}
			}

			[Token(Token = "0x200038E")]
			public struct TypeHandle
			{
				[Token(Token = "0x4000F36")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public EntityManager _entityManager;

				[Token(Token = "0x4000F37")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[ReadOnly]
				private ComponentTypeHandle<ManagedState> item1_ManagedComponentTypeHandle_RO;

				[Token(Token = "0x60016C2")]
				[Address(RVA = "0x44D8F90", Offset = "0x44D4F90", VA = "0x44D8F90")]
				public TypeHandle(ref SystemState systemState)
				{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PollPendingPathsSystem.IFE_1964892062_0.TypeHandle..ctor RVA=0x44D8F90 Token=0x60016C2");
}

				[Token(Token = "0x60016C3")]
				[Address(RVA = "0x44D9040", Offset = "0x44D5040", VA = "0x44D9040")]
				public void Update(ref SystemState systemState)
				{
				}

				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				[Token(Token = "0x60016C4")]
				[Address(RVA = "0x44D9098", Offset = "0x44D5098", VA = "0x44D9098")]
				public ResolvedChunk Resolve(ArchetypeChunk archetypeChunk)
				{
					return default;
				}
			}

			[Token(Token = "0x200038F")]
			public struct Enumerator : IEnumerator<ManagedState>, IEnumerator, IDisposable
			{
				[Token(Token = "0x4000F38")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private InternalEntityQueryEnumerator _entityQueryEnumerator;

				[Token(Token = "0x4000F39")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
				private TypeHandle _typeHandle;

				[Token(Token = "0x4000F3A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
				private ResolvedChunk _resolvedChunk;

				[Token(Token = "0x4000F3B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
				private int _currentEntityIndex;

				[Token(Token = "0x4000F3C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
				private int _endEntityIndex;

				[Token(Token = "0x17000325")]
				public ManagedState Current
				{
					[Token(Token = "0x60016C8")]
					[Address(RVA = "0x44D8BEC", Offset = "0x44D4BEC", VA = "0x44D8BEC", Slot = "4")]
					get
					{
						return null;
					}
				}

				[Token(Token = "0x17000326")]
object System.Collections.IEnumerator.Current				{
					[Token(Token = "0x60016CB")]
					[Address(RVA = "0x44D927C", Offset = "0x44D527C", VA = "0x44D927C", Slot = "7")]
					get
					{
						return global_003A_003ASystem_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x60016C5")]
				[Address(RVA = "0x44D8DD8", Offset = "0x44D4DD8", VA = "0x44D8DD8")]
				public Enumerator(EntityQuery entityQuery, TypeHandle typeHandle, ref SystemState state)
				{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PollPendingPathsSystem.IFE_1964892062_0.Enumerator..ctor RVA=0x44D8DD8 Token=0x60016C5");
}

				[Token(Token = "0x60016C6")]
				[Address(RVA = "0x44D9138", Offset = "0x44D5138", VA = "0x44D9138", Slot = "5")]
				public void Dispose()
				{
				}

				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				[Token(Token = "0x60016C7")]
				[Address(RVA = "0x44D9140", Offset = "0x44D5140", VA = "0x44D9140", Slot = "6")]
				public bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x60016C9")]
				[Address(RVA = "0x44D8BDC", Offset = "0x44D4BDC", VA = "0x44D8BDC")]
				public Enumerator GetEnumerator()
				{
					return default;
				}

				[Token(Token = "0x60016CA")]
				[Address(RVA = "0x44D9244", Offset = "0x44D5244", VA = "0x44D9244", Slot = "8")]
				public void Reset()
				{
				}

				[Token(Token = "0x60016CB")]
				[Address(RVA = "0x44D927C", Offset = "0x44D527C", VA = "0x44D927C", Slot = "7")]
				private object global_003A_003ASystem_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x60016BF")]
			[Address(RVA = "0x44D8D6C", Offset = "0x44D4D6C", VA = "0x44D8D6C")]
			public static Enumerator Query(EntityQuery entityQuery, TypeHandle typeHandle, ref SystemState state)
			{
				return default;
			}

			[Token(Token = "0x60016C0")]
			[Address(RVA = "0x44D8EB8", Offset = "0x44D4EB8", VA = "0x44D8EB8")]
			public static void CompleteDependencies(ref SystemState state)
			{
			}
		}

		[Token(Token = "0x2000390")]
		private struct TypeHandle
		{
			[Token(Token = "0x4000F3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IFE_1964892062_0.TypeHandle __IFE_1964892062_0_TypeHandle;

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x60016CC")]
			[Address(RVA = "0x44D92B4", Offset = "0x44D52B4", VA = "0x44D92B4")]
			public void __AssignHandles(ref SystemState state)
			{
			}
		}

		[Token(Token = "0x4000F2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private GCHandle onPathsCalculated;

		[Token(Token = "0x4000F30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool anyPendingPaths;

		[Token(Token = "0x4000F31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private JobRepairPath.Scheduler jobRepairPathScheduler;

		[Token(Token = "0x4000F32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private EntityQuery entityQueryPrepare;

		[Token(Token = "0x4000F33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private TypeHandle __TypeHandle;

		[Token(Token = "0x4000F34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private EntityQuery __query_1964892062_0;

		[Token(Token = "0x60016B6")]
		[Address(RVA = "0x44D85CC", Offset = "0x44D45CC", VA = "0x44D85CC", Slot = "4")]
		public void OnCreate(ref SystemState state)
		{
		}

		[Token(Token = "0x60016B7")]
		[Address(RVA = "0x44D87A4", Offset = "0x44D47A4", VA = "0x44D87A4", Slot = "5")]
		public void OnDestroy(ref SystemState state)
		{
		}

		[Token(Token = "0x60016B8")]
		[Address(RVA = "0x44D88A8", Offset = "0x44D48A8", VA = "0x44D88A8")]
		private void OnUpdate(ref SystemState systemState)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60016B9")]
		[Address(RVA = "0x44D8C3C", Offset = "0x44D4C3C", VA = "0x44D8C3C")]
		private void __AssignQueries(ref SystemState state)
		{
		}

		[Token(Token = "0x60016BA")]
		[Address(RVA = "0x44D8D18", Offset = "0x44D4D18", VA = "0x44D8D18", Slot = "7")]
		public void OnCreateForCompiler(ref SystemState state)
		{
		}
	}
}
