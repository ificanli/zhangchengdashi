using Il2CppDummyDll;

namespace CommonGameModule.Debugger.Tools.FeiShu
{
	[Token(Token = "0x2000044")]
	public class FeiShuOrderSendLogTextFileToChat : FeiShuOrderTokenBase
	{
		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x30")]
		private readonly string chatId;

		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x38")]
		private readonly string text;

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x4642D3C", Offset = "0x463ED3C", VA = "0x4642D3C")]
		public FeiShuOrderSendLogTextFileToChat(string appId, string appSecret, string chatId, string text) : base(appId, appSecret)
		{
			throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED FeiShuOrderSendLogTextFileToChat..ctor RVA=0x4642D3C Token=0x06000115; original base constructor arguments recovered; remaining original constructor body pending.");
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x4642D7C", Offset = "0x463ED7C", VA = "0x4642D7C", Slot = "6")]
		protected override void OnGetTokenSuccess(string token)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x4642E44", Offset = "0x463EE44", VA = "0x4642E44")]
		private void OnUploadTextFileSuccess(string fileId)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x4642F14", Offset = "0x463EF14", VA = "0x4642F14")]
		private void OnSendChatSuccess()
		{
		}
	}
}
