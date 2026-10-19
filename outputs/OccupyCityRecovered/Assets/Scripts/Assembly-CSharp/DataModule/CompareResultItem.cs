using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E1D")]
	public class CompareResultItem
	{
		[Token(Token = "0x400627C")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x400627D")]
		[FieldOffset(Offset = "0x18")]
		public string localValue;

		[Token(Token = "0x400627E")]
		[FieldOffset(Offset = "0x20")]
		public string serverValue;

		[Token(Token = "0x400627F")]
		[FieldOffset(Offset = "0x28")]
		public CompareResultType compareResultType;

		[Token(Token = "0x60056FB")]
		[Address(RVA = "0x4348E80", Offset = "0x4344E80", VA = "0x4348E80")]
		public CompareResultItem(string name)
		{
		}

		[Token(Token = "0x60056FC")]
		[Address(RVA = "0x4348F08", Offset = "0x4344F08", VA = "0x4348F08")]
		public CompareResultItem(string name, long localValue, long serverValue)
		{
		}

		[Token(Token = "0x60056FD")]
		[Address(RVA = "0x4349100", Offset = "0x4345100", VA = "0x4349100")]
		public CompareResultItem(string name, string localValue, string serverValue, CompareResultType compareResultType, bool addColorTag = false)
		{
		}

		[Token(Token = "0x60056FE")]
		[Address(RVA = "0x434921C", Offset = "0x434521C", VA = "0x434921C")]
		public string GetText(bool isLocal)
		{
			return null;
		}
	}
}
