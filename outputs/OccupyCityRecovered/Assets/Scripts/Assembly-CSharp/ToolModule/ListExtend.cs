using System;
using System.Collections.Generic;
using DataModule;
using Il2CppDummyDll;

namespace ToolModule
{
	[Token(Token = "0x2000195")]
	public static class ListExtend
	{
		[Token(Token = "0x6000678")]
		public static bool IsNullOrEmpty<T>(this IList<T> list)
		{
			return default;
		}

		[Token(Token = "0x6000679")]
		public static void Populate<T>(this IList<T> list, T item)
		{
		}

		[Token(Token = "0x600067A")]
		public static bool TryFindById<T>(this IList<T> list, string id, out T result) where T : GlobalInfoBase
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ListExtend.TryFindById RVA= Token=0x600067A");
}

		[Token(Token = "0x600067B")]
		public static T FindById<T>(this IList<T> list, string id) where T : GlobalInfoBase
		{
			return null;
		}

		[Token(Token = "0x600067C")]
		public static void AddRange<T>(this IList<T> list, IEnumerable<T> collection)
		{
		}

		[Token(Token = "0x600067D")]
		public static void Sort<T>(this IList<T> list, Comparison<T> comparison)
		{
		}

		[Token(Token = "0x600067E")]
		public static void Sort<T>(this IList<T> list)
		{
		}
	}
}
