using System;
using Il2CppDummyDll;

namespace SDKModule
{
	[Serializable]
	[Token(Token = "0x200014E")]
	public class UserSegmentationClass
	{
		[Token(Token = "0x4001A24")]
		[FieldOffset(Offset = "0x10")]
		public int UserSegmentation = -1;

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x3F736FC", Offset = "0x3F6F6FC", VA = "0x3F736FC")]
		public UserSegmentationClass()
		{
		}
	}
}
