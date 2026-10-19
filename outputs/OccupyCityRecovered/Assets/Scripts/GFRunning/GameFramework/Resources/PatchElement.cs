using Il2CppDummyDll;

namespace GameFramework.Resources
{
	[Token(Token = "0x20004D3")]
	public class PatchElement
	{
		[Token(Token = "0x4001FAE")]
		[FieldOffset(Offset = "0x10")]
		public string EName;

		[Token(Token = "0x4001FAF")]
		[FieldOffset(Offset = "0x18")]
		public string ObfuscatorName;

		[Token(Token = "0x4001FB0")]
		[FieldOffset(Offset = "0x20")]
		public string MD5;

		[Token(Token = "0x4001FB1")]
		[FieldOffset(Offset = "0x28")]
		public ulong Size;

		[Token(Token = "0x4001FB2")]
		[FieldOffset(Offset = "0x30")]
		public int Version;

		[Token(Token = "0x4001FB3")]
		[FieldOffset(Offset = "0x34")]
		public bool IsEncrypAB;

		[Token(Token = "0x6007325")]
		[Address(RVA = "0x72F03B8", Offset = "0x72EC3B8", VA = "0x72F03B8")]
		public string GetFileString()
		{
			return null;
		}

		[Token(Token = "0x6007326")]
		[Address(RVA = "0x72F04D8", Offset = "0x72EC4D8", VA = "0x72F04D8")]
		public PatchElement()
		{
		}
	}
}
