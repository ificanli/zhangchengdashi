using System.Collections.Generic;
using Il2CppDummyDll;

namespace CommonGameModule.Debugger
{
	[Token(Token = "0x2000014")]
	public class MultiKeyDictionary<T1, T2, T3> : Dictionary<T1, Dictionary<T2, T3>>
	{
		[Token(Token = "0x17000015")]
		public new Dictionary<T2, T3> this[T1 key]
		{
			[Token(Token = "0x6000067")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000068")]
		public bool ContainsKey(T1 key1, T2 key2)
		{
			return default;
		}

		[Token(Token = "0x6000069")]
		public MultiKeyDictionary()
		{
		}
	}
}
