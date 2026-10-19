using System;
using Il2CppDummyDll;

namespace Pathfinding.Collections
{
	[Token(Token = "0x2000273")]
	public static class SlabListExtensions
	{
		[Token(Token = "0x6000F8A")]
		public static void Remove<T>(this ref SlabAllocator<T>.List list, T value) where T : unmanaged, IEquatable<T>
		{
		}
	}
}
