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
            this.entity = entity;
            this.world = world;
        }

		[Token(Token = "0x60012BB")]
		[Address(RVA = "0x44B4BF8", Offset = "0x44B0BF8", VA = "0x44B4BF8")]
		public void AddBeforeControlCallback(BeforeControlDelegate value)
		{
            AddCallback<ManagedMovementOverrideBeforeControl, BeforeControlDelegate>(value);
        }

		[Token(Token = "0x60012BC")]
		[Address(RVA = "0x44B4C50", Offset = "0x44B0C50", VA = "0x44B4C50")]
		public void RemoveBeforeControlCallback(BeforeControlDelegate value)
		{
            RemoveCallback<ManagedMovementOverrideBeforeControl, BeforeControlDelegate>(value);
        }

		[Token(Token = "0x60012BD")]
		[Address(RVA = "0x44B4CA8", Offset = "0x44B0CA8", VA = "0x44B4CA8")]
		public void AddAfterControlCallback(AfterControlDelegate value)
		{
            AddCallback<ManagedMovementOverrideAfterControl, AfterControlDelegate>(value);
        }

		[Token(Token = "0x60012BE")]
		[Address(RVA = "0x44B4D00", Offset = "0x44B0D00", VA = "0x44B4D00")]
		public void RemoveAfterControlCallback(AfterControlDelegate value)
		{
            RemoveCallback<ManagedMovementOverrideAfterControl, AfterControlDelegate>(value);
        }

		[Token(Token = "0x60012BF")]
		[Address(RVA = "0x44B4D58", Offset = "0x44B0D58", VA = "0x44B4D58")]
		public void AddBeforeMovementCallback(BeforeMovementDelegate value)
		{
            AddCallback<ManagedMovementOverrideBeforeMovement, BeforeMovementDelegate>(value);
        }

		[Token(Token = "0x60012C0")]
		[Address(RVA = "0x44B4DB0", Offset = "0x44B0DB0", VA = "0x44B4DB0")]
		public void RemoveBeforeMovementCallback(BeforeMovementDelegate value)
		{
            RemoveCallback<ManagedMovementOverrideBeforeMovement, BeforeMovementDelegate>(value);
        }

		[Token(Token = "0x60012C1")]
		private void AddCallback<C, T>(T callback) where C : ManagedMovementOverride<T>, IComponentData, new() where T : Delegate
		{
            if (callback == null) throw new ArgumentNullException("callback");
            if (world == null || !world.EntityManager.Exists(entity)) {
                throw new InvalidOperationException("The entity does not exist. You can only set a callback when the FollowerEntity is active and has been enabled. If you are trying to set this during Awake or OnEnable, try setting it during Start instead.");
            }
            if (!world.EntityManager.HasComponent<C>(entity)) {
                world.EntityManager.AddComponentData(entity, new C());
            }
            world.EntityManager.GetComponentData<C>(entity).AddCallback(callback);
        }

		[Token(Token = "0x60012C2")]
		private void RemoveCallback<C, T>(T callback) where C : ManagedMovementOverride<T>, IComponentData, new() where T : Delegate
		{
            if (callback == null) throw new ArgumentNullException("callback");
            if (world != null && world.EntityManager.Exists(entity)) {
                if (world.EntityManager.HasComponent<C>(entity)) {
                    if (!world.EntityManager.GetComponentData<C>(entity).RemoveCallback(callback)) {
                        world.EntityManager.RemoveComponent<C>(entity);
                    }
                }
            }
        }
	}
}
