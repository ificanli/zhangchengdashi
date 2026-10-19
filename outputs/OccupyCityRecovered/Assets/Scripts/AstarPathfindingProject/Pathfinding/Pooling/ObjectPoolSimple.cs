using System.Collections.Generic;
using Il2CppDummyDll;

namespace Pathfinding.Pooling
{
	[Token(Token = "0x2000258")]
	public static class ObjectPoolSimple<T> where T : class, new()
	{
		[Token(Token = "0x4000B01")]
		[FieldOffset(Offset = "0x0")]
		private static List<T> pool;

		[Token(Token = "0x4000B02")]
		[FieldOffset(Offset = "0x0")]
		private static readonly HashSet<T> inPool;

		[Token(Token = "0x6000EC6")]
		public static T Claim()
		{
			return null;
		}

		[Token(Token = "0x6000EC7")]
		public static void Release(ref T obj)
		{
		}

		[Token(Token = "0x6000EC8")]
		public static void Clear()
		{
		}

		[Token(Token = "0x6000EC9")]
		public static int GetSize()
		{
			return default;
		}
	}
}
