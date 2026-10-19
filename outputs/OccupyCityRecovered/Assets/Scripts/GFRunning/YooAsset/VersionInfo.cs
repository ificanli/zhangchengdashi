using System;
using Il2CppDummyDll;

namespace YooAsset
{
	[Serializable]
	[Token(Token = "0x2000140")]
	public class VersionInfo
	{
		[Token(Token = "0x40004A1")]
		[FieldOffset(Offset = "0x10")]
		public string resPath;

		[Token(Token = "0x40004A2")]
		[FieldOffset(Offset = "0x18")]
		public string resCode;

		[Token(Token = "0x40004A3")]
		[FieldOffset(Offset = "0x20")]
		public string resCodeShowName;

		[Token(Token = "0x6001235")]
		[Address(RVA = "0x7354520", Offset = "0x7350520", VA = "0x7354520")]
		public VersionInfo()
		{
		}
	}
}
