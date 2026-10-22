using System;
using Il2CppDummyDll;
using Unity.Entities;
using UnityEngine.Scripting;

namespace Pathfinding.ECS
{
	[Token(Token = "0x20002F7")]
	public class ManagedMovementOverride<T> : IComponentData, IQueryTypeParameter where T : class, Delegate
	{
		[Token(Token = "0x4000D9C")]
		[FieldOffset(Offset = "0x0")]
		public T callback;

		[Token(Token = "0x60012C3")]
		public void AddCallback(T callback)
		{
            this.callback = (T)Delegate.Combine(this.callback, callback);
        }

		[Token(Token = "0x60012C4")]
		public bool RemoveCallback(T callback)
		{
            this.callback = (T)Delegate.Remove(this.callback, callback);
            return this.callback != null;
        }

		[Token(Token = "0x60012C5")]
		[Preserve]
		public ManagedMovementOverride()
		{
		}
	}
}
