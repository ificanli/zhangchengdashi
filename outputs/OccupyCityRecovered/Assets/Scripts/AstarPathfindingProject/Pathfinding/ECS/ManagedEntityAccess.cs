using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Entities;

namespace Pathfinding.ECS
{
	[Token(Token = "0x2000311")]
	public struct ManagedEntityAccess<T> where T : class, IComponentData
	{
		[Token(Token = "0x4000DE4")]
		[FieldOffset(Offset = "0x0")]
		private EntityManager entityManager;

		[Token(Token = "0x4000DE5")]
		[FieldOffset(Offset = "0x0")]
		private ComponentTypeHandle<T> handle;

		[Token(Token = "0x4000DE6")]
		[FieldOffset(Offset = "0x0")]
		private bool readOnly;

		[Token(Token = "0x1700031A")]
		public T this[EntityStorageInfo storage]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6001302")]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6001303")]
			set
			{
			}
		}

		[Token(Token = "0x60012FF")]
		public ManagedEntityAccess(bool readOnly)
		{
            entityManager = default;
            handle = default;
            this.readOnly = readOnly;
        }

		[Token(Token = "0x6001300")]
		public ManagedEntityAccess(EntityManager entityManager, bool readOnly)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ManagedEntityAccess..ctor RVA= Token=0x6001300");
}

		[Token(Token = "0x6001301")]
		public void Update(EntityManager entityManager)
		{
		}
	}
}
