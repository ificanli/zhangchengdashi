using System.Collections.Generic;
using Il2CppDummyDll;

namespace Pathfinding.Pooling
{
	[Token(Token = "0x2000258")]
	public static class ObjectPoolSimple<T> where T : class, new()
	{
		[Token(Token = "0x4000B01")]
		[FieldOffset(Offset = "0x0")]
		private static List<T> pool = new List<T>();

		[Token(Token = "0x4000B02")]
		[FieldOffset(Offset = "0x0")]
		private static readonly HashSet<T> inPool = new HashSet<T>();

		[Token(Token = "0x6000EC6")]
		public static T Claim()
		{
 lock (pool) {
  if (pool.Count==0) return System.Activator.CreateInstance<T>();
  var result=pool[pool.Count-1];
  pool.RemoveAt(pool.Count-1);
  inPool.Remove(result);
  return result;
 }
}

		[Token(Token = "0x6000EC7")]
		public static void Release(ref T obj)
		{ lock (pool) pool.Add(obj); obj=null; }

		[Token(Token = "0x6000EC8")]
		public static void Clear()
		{ lock (pool) pool.Clear(); }

		[Token(Token = "0x6000EC9")]
		public static int GetSize()
		{ return pool.Count; }
	}
}
