using System;
using Il2CppDummyDll;

namespace L_Tools.Localization
{
	[Serializable]
	[Token(Token = "0x2000FBF")]
	public class LangData
	{
		[Token(Token = "0x4006BAE")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x4006BAF")]
		[FieldOffset(Offset = "0x18")]
		public string EN;

		[Token(Token = "0x4006BB0")]
		[FieldOffset(Offset = "0x20")]
		public string ZH_CN;

		[Token(Token = "0x6005E4B")]
		[Address(RVA = "0x43FB94C", Offset = "0x43F794C", VA = "0x43FB94C")]
		public LangData()
		{
		}
	}
}
