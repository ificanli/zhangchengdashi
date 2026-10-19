using System.Collections.Generic;
using Il2CppDummyDll;

namespace Pathfinding.Pooling
{
	[Token(Token = "0x200025A")]
	public static class StackPool<T>
	{
		[Token(Token = "0x4000B05")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<Stack<T>> pool;

		[Token(Token = "0x6000ED0")]
		static StackPool()
		{
		}

		[Token(Token = "0x6000ED1")]
		public static Stack<T> Claim()
		{
			return null;
		}

		[Token(Token = "0x6000ED2")]
		public static void Warmup(int count)
		{
		}

		[Token(Token = "0x6000ED3")]
		public static void Release(Stack<T> stack)
		{
		}

		[Token(Token = "0x6000ED4")]
		public static void Clear()
		{
		}

		[Token(Token = "0x6000ED5")]
		public static int GetSize()
		{
			return default;
		}
	}
}
