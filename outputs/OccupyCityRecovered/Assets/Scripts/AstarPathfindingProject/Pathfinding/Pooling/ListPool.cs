using System.Collections.Generic;
using Il2CppDummyDll;

namespace Pathfinding.Pooling
{
	[Token(Token = "0x2000255")]
	public static class ListPool<T>
	{
		[Token(Token = "0x4000AFB")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<List<T>> pool;

		[Token(Token = "0x4000AFC")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<List<T>> largePool;

		[Token(Token = "0x4000AFD")]
		[FieldOffset(Offset = "0x0")]
		private static readonly HashSet<List<T>> inPool;

		[Token(Token = "0x4000AFE")]
		private const int MaxCapacitySearchLength = 8;

		[Token(Token = "0x4000AFF")]
		private const int LargeThreshold = 5000;

		[Token(Token = "0x4000B00")]
		private const int MaxLargePoolSize = 8;

		[Token(Token = "0x6000EBA")]
		public static List<T> Claim()
		{
			return null;
		}

		[Token(Token = "0x6000EBB")]
		private static int FindCandidate(List<List<T>> pool, int capacity)
		{
			return default;
		}

		[Token(Token = "0x6000EBC")]
		public static List<T> Claim(int capacity)
		{
			return null;
		}

		[Token(Token = "0x6000EBD")]
		public static void Warmup(int count, int size)
		{
		}

		[Token(Token = "0x6000EBE")]
		public static void Release(ref List<T> list)
		{
		}

		[Token(Token = "0x6000EBF")]
		public static void Release(List<T> list)
		{
		}

		[Token(Token = "0x6000EC0")]
		public static void Clear()
		{
		}

		[Token(Token = "0x6000EC1")]
		public static int GetSize()
		{
			return default;
		}
	}
}
