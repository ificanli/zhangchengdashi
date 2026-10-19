using System;
using Il2CppDummyDll;

namespace BadgeGraph
{
	[Serializable]
	[Token(Token = "0x2000E03")]
	public class BadgeData
	{
		[Token(Token = "0x40061DE")]
		[FieldOffset(Offset = "0x10")]
		public string m_Key;

		[Token(Token = "0x40061DF")]
		[FieldOffset(Offset = "0x18")]
		public string[] m_Children;

		[Token(Token = "0x6005687")]
		[Address(RVA = "0x433E234", Offset = "0x433A234", VA = "0x433E234")]
		public BadgeData()
		{
		}
	}
}
