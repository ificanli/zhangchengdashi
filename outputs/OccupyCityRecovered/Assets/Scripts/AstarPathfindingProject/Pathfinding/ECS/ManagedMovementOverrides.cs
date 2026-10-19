using System;
using Il2CppDummyDll;
using Unity.Entities;

namespace Pathfinding.ECS
{
	[Token(Token = "0x20002F6")]
	public struct ManagedMovementOverrides
	{
		[Token(Token = "0x4000D9A")]
		[FieldOffset(Offset = "0x0")]
		private Entity entity;

		[Token(Token = "0x4000D9B")]
		[FieldOffset(Offset = "0x8")]
		private World world;

		[Token(Token = "0x60012BA")]
		[Address(RVA = "0x44B4BF0", Offset = "0x44B0BF0", VA = "0x44B4BF0")]
		public ManagedMovementOverrides(Entity entity, World world)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ManagedMovementOverrides..ctor RVA=0x44B4BF0 Token=0x60012BA");
}

		[Token(Token = "0x60012BB")]
		[Address(RVA = "0x44B4BF8", Offset = "0x44B0BF8", VA = "0x44B4BF8")]
		public void AddBeforeControlCallback(BeforeControlDelegate value)
		{
		}

		[Token(Token = "0x60012BC")]
		[Address(RVA = "0x44B4C50", Offset = "0x44B0C50", VA = "0x44B4C50")]
		public void RemoveBeforeControlCallback(BeforeControlDelegate value)
		{
		}

		[Token(Token = "0x60012BD")]
		[Address(RVA = "0x44B4CA8", Offset = "0x44B0CA8", VA = "0x44B4CA8")]
		public void AddAfterControlCallback(AfterControlDelegate value)
		{
		}

		[Token(Token = "0x60012BE")]
		[Address(RVA = "0x44B4D00", Offset = "0x44B0D00", VA = "0x44B4D00")]
		public void RemoveAfterControlCallback(AfterControlDelegate value)
		{
		}

		[Token(Token = "0x60012BF")]
		[Address(RVA = "0x44B4D58", Offset = "0x44B0D58", VA = "0x44B4D58")]
		public void AddBeforeMovementCallback(BeforeMovementDelegate value)
		{
		}

		[Token(Token = "0x60012C0")]
		[Address(RVA = "0x44B4DB0", Offset = "0x44B0DB0", VA = "0x44B4DB0")]
		public void RemoveBeforeMovementCallback(BeforeMovementDelegate value)
		{
		}

		[Token(Token = "0x60012C1")]
		private void AddCallback<C, T>(T callback) where C : ManagedMovementOverride<T>, IComponentData, new() where T : Delegate
		{
		}

		[Token(Token = "0x60012C2")]
		private void RemoveCallback<C, T>(T callback) where C : ManagedMovementOverride<T>, IComponentData, new() where T : Delegate
		{
		}
	}
}
