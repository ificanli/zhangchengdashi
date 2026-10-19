using Il2CppDummyDll;

namespace CommonGameModule.Debugger.Tools.FeiShu
{
	[Token(Token = "0x2000043")]
	public class FeiShuOrderSendLogMsgToChat : FeiShuOrderTokenBase
	{
		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x30")]
		private readonly string groupId;

		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x38")]
		private readonly string msg;

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x4642B48", Offset = "0x463EB48", VA = "0x4642B48")]
		public FeiShuOrderSendLogMsgToChat(string appId, string appSecret, string groupId, string msg) : base(appId, appSecret)
		{
			throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED FeiShuOrderSendLogMsgToChat..ctor RVA=0x4642B48 Token=0x06000112; original base constructor arguments recovered; remaining original constructor body pending.");
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x4642B88", Offset = "0x463EB88", VA = "0x4642B88", Slot = "6")]
		protected override void OnGetTokenSuccess(string token)
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x4642C70", Offset = "0x463EC70", VA = "0x4642C70")]
		private void OnSendChatSuccess()
		{
		}
	}
}
