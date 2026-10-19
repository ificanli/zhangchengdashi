using Il2CppDummyDll;

namespace GameFramework.Resources
{
	[Token(Token = "0x20004C7")]
	public abstract class ProviderBase
	{
		[Token(Token = "0x20004C8")]
		public enum EStatus
		{
			[Token(Token = "0x4001F8F")]
			None = 0,
			[Token(Token = "0x4001F90")]
			CheckBundle = 1,
			[Token(Token = "0x4001F91")]
			Loading = 2,
			[Token(Token = "0x4001F92")]
			Checking = 3,
			[Token(Token = "0x4001F93")]
			Success = 4,
			[Token(Token = "0x4001F94")]
			Fail = 5
		}

		[Token(Token = "0x6007227")]
		[Address(RVA = "0x72EB0B8", Offset = "0x72E70B8", VA = "0x72EB0B8")]
		protected ProviderBase()
		{
		}
	}
}
