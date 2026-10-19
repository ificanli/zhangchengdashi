using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace AssetsModule
{
	[Serializable]
	[Token(Token = "0x2000630")]
	public class AssetsPathInfo
	{
		[Token(Token = "0x40032A0")]
		[FieldOffset(Offset = "0x10")]
		public string assetPath;

		[Token(Token = "0x40032A1")]
		[FieldOffset(Offset = "0x18")]
		public string groupName;

		[Token(Token = "0x40032A2")]
		[FieldOffset(Offset = "0x20")]
		public List<string> labels;

		[Token(Token = "0x60020B8")]
		[Address(RVA = "0x3F128E0", Offset = "0x3F0E8E0", VA = "0x3F128E0")]
		public AssetsPathInfo()
		{
		}
	}
}
