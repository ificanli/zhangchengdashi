using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E14")]
	public class compareArtifactInfo
	{
		[Token(Token = "0x400622A")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x400622B")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x400622C")]
		[FieldOffset(Offset = "0x20")]
		public int rare;

		[Token(Token = "0x400622D")]
		[FieldOffset(Offset = "0x24")]
		public int level;

		[Token(Token = "0x400622E")]
		[FieldOffset(Offset = "0x28")]
		public int starLevel;

		[Token(Token = "0x400622F")]
		[FieldOffset(Offset = "0x2C")]
		public int count;

		[Token(Token = "0x4006230")]
		[FieldOffset(Offset = "0x30")]
		public bool isEquip;

		[Token(Token = "0x60056D6")]
		[Address(RVA = "0x4341418", Offset = "0x433D418", VA = "0x4341418")]
		public compareArtifactInfo()
		{
		}
	}
}
