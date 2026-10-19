using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace AssetsModule
{
	[Serializable]
	[Token(Token = "0x2000631")]
	public class AssetsPathInfoCollection
	{
		[Token(Token = "0x40032A3")]
		[FieldOffset(Offset = "0x10")]
		public List<AssetsPathInfo> items;

		[Token(Token = "0x60020B9")]
		[Address(RVA = "0x3F128E8", Offset = "0x3F0E8E8", VA = "0x3F128E8")]
		public AssetsPathInfoCollection()
		{
		}
	}
}
