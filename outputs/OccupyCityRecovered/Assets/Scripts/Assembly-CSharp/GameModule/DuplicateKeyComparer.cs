using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20005A9")]
	public class DuplicateKeyComparer<TKey> : IComparer<TKey> where TKey : IComparable
	{
		[Token(Token = "0x1700017E")]
		public bool Reverse
		{
			[Token(Token = "0x6001D7B")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6001D7C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6001D7D")]
		public DuplicateKeyComparer(bool reverse = false)
		{
		}

		[Token(Token = "0x6001D7E")]
		public int Compare(TKey x, TKey y)
		{
			return default;
		}
	}
}
