using System.Collections.Generic;
using Il2CppDummyDll;

namespace Pathfinding.Pooling
{
	[Token(Token = "0x2000254")]
	public static class ListExtensions
	{
		[Token(Token = "0x6000EB8")]
		public static T[] ToArrayFromPool<T>(this List<T> list)
		{
			return null;
		}

		[Token(Token = "0x6000EB9")]
		public static void ClearFast<T>(this List<T> list)
		{
 int count=list.Count;
 if (list.Capacity<=unchecked(2*count)) list.Clear(); else list.RemoveRange(0,list.Count);
}
	}
}
