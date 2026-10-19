using Il2CppDummyDll;

namespace GameFramework
{
	[Token(Token = "0x200030C")]
	public class DependBundle
	{
		[Token(Token = "0x40018C9")]
		[FieldOffset(Offset = "0x10")]
		public string BundleName;

		[Token(Token = "0x40018CA")]
		[FieldOffset(Offset = "0x18")]
		public int RefCount;

		[Token(Token = "0x40018CB")]
		[FieldOffset(Offset = "0x1C")]
		public int Status;

		[Token(Token = "0x60053C2")]
		[Address(RVA = "0x713EA9C", Offset = "0x713AA9C", VA = "0x713EA9C")]
		public DependBundle()
		{
		}
	}
}
