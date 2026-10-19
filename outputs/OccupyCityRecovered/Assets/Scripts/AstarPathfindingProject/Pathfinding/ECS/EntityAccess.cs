using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Entities;

namespace Pathfinding.ECS
{
	[Token(Token = "0x2000310")]
	public struct EntityAccess<T> where T : struct, IComponentData
	{
		[Token(Token = "0x4000DE0")]
		[FieldOffset(Offset = "0x0")]
		public ComponentTypeHandle<T> handle;

		[Token(Token = "0x4000DE1")]
		[FieldOffset(Offset = "0x0")]
		private uint lastSystemVersion;

		[Token(Token = "0x4000DE2")]
		[FieldOffset(Offset = "0x0")]
		private ulong worldSequenceNumber;

		[Token(Token = "0x4000DE3")]
		[FieldOffset(Offset = "0x0")]
		private bool readOnly;

		[Token(Token = "0x17000319")]
		public unsafe ref T this[EntityStorageInfo storage]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x60012FE")]
			get
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED EntityAccess.indexer.get RVA= Token=0x60012FE");
}
		}

		[Token(Token = "0x60012FB")]
		public EntityAccess(bool readOnly)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED EntityAccess..ctor RVA= Token=0x60012FB");
}

		[Token(Token = "0x60012FC")]
		public void Update(EntityManager entityManager)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60012FD")]
		public bool HasComponent(EntityStorageInfo storage)
		{
			return default;
		}
	}
}
