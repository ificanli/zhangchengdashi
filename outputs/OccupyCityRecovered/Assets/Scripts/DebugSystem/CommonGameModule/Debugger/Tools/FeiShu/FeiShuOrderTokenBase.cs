using Il2CppDummyDll;

namespace CommonGameModule.Debugger.Tools.FeiShu
{
	[Token(Token = "0x2000045")]
	public abstract class FeiShuOrderTokenBase : FeiShuOrderBase
	{
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x18")]
		private readonly string appId;

		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x20")]
		private readonly string appSecret;

		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x28")]
		protected string token;

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x4642590", Offset = "0x463E590", VA = "0x4642590")]
		public FeiShuOrderTokenBase(string appId, string appSecret)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x4643010", Offset = "0x463F010", VA = "0x4643010", Slot = "4")]
		public override void Execute()
		{
		}

		[Token(Token = "0x600011B")]
		protected abstract void OnGetTokenSuccess(string token);
	}
}
