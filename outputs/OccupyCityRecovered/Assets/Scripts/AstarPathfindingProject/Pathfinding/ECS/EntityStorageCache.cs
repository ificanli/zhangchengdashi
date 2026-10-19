using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Entities;

namespace Pathfinding.ECS
{
	[Token(Token = "0x200030F")]
	public struct EntityStorageCache
	{
		[Token(Token = "0x4000DDD")]
		[FieldOffset(Offset = "0x0")]
		private EntityStorageInfo storage;

		[Token(Token = "0x4000DDE")]
		[FieldOffset(Offset = "0x18")]
		private Entity entity;

		[Token(Token = "0x4000DDF")]
		[FieldOffset(Offset = "0x20")]
		private int lastWorldHash;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60012F8")]
		[Address(RVA = "0x44B5C9C", Offset = "0x44B1C9C", VA = "0x44B5C9C")]
		public bool Update(World world, Entity entity, out EntityManager entityManager, out EntityStorageInfo storage)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED EntityStorageCache.Update RVA=0x44B5C9C Token=0x60012F8");
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60012F9")]
		public bool GetComponentData<A>(World world, Entity entity, ref EntityAccess<A> access, out ComponentRef<A> value) where A : struct, IComponentData
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED EntityStorageCache.GetComponentData RVA= Token=0x60012F9");
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60012FA")]
		public bool GetComponentData<A>(World world, Entity entity, ref ManagedEntityAccess<A> access, out A value) where A : class, IComponentData
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED EntityStorageCache.GetComponentData RVA= Token=0x60012FA");
}
	}
}
