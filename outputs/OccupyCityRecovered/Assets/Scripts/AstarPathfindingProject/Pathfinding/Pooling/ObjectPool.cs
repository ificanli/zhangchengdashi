using Il2CppDummyDll;

namespace Pathfinding.Pooling
{
	[Token(Token = "0x2000257")]
	public static class ObjectPool<T> where T : class, IAstarPooledObject, new()
	{
		[Token(Token = "0x6000EC4")]
		public static T Claim()
		{ return ObjectPoolSimple<T>.Claim(); }

		[Token(Token = "0x6000EC5")]
		public static void Release(ref T obj)
		{ obj.OnEnterPool(); ObjectPoolSimple<T>.Release(ref obj); }
	}
}
