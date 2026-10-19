using System.Collections.Generic;
using Il2CppDummyDll;

namespace Pathfinding.Pooling
{
	[Token(Token = "0x2000253")]
	public static class ArrayPool<T>
	{
		[Token(Token = "0x4000AF7")]
		private const int MaximumExactArrayLength = 256;

		[Token(Token = "0x4000AF8")]
		[FieldOffset(Offset = "0x0")]
		private static readonly bool containsReferenceTypes;

		[Token(Token = "0x4000AF9")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Stack<T[]>[] pool;

		[Token(Token = "0x4000AFA")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Stack<T[]>[] exactPool;

		[Token(Token = "0x6000EB4")]
		static ArrayPool()
		{
		}

		[Token(Token = "0x6000EB5")]
		public static T[] Claim(int minimumLength)
		{
			return null;
		}

		[Token(Token = "0x6000EB6")]
		public static T[] ClaimWithExactLength(int length)
		{
			return null;
		}

		[Token(Token = "0x6000EB7")]
		public static void Release(ref T[] array, bool allowNonPowerOfTwo = false)
		{
		}
	}
}
