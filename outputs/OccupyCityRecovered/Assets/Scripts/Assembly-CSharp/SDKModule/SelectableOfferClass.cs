using System;
using Il2CppDummyDll;

namespace SDKModule
{
	[Serializable]
	[Token(Token = "0x2000140")]
	public class SelectableOfferClass
	{
		[Token(Token = "0x4001A16")]
		[FieldOffset(Offset = "0x10")]
		public int SelectableOffer;

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x3F7361C", Offset = "0x3F6F61C", VA = "0x3F7361C")]
		public SelectableOfferClass()
		{
		}
	}
}
