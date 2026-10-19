using Il2CppDummyDll;

namespace CommonGameModule.Debugger.Tools.FeiShu
{
	[Token(Token = "0x2000041")]
	public class FeiShuOrderSendLogFileToChat : FeiShuOrderUploadLogFile
	{
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x38")]
		private readonly string chatId;

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x46426BC", Offset = "0x463E6BC", VA = "0x46426BC")]
		public FeiShuOrderSendLogFileToChat(string appId, string appSecret, string chatId, string filePath) : base(appId, appSecret, filePath)
		{
			throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED FeiShuOrderSendLogFileToChat..ctor RVA=0x46426BC Token=0x0600010C; original base constructor arguments recovered; remaining original constructor body pending.");
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x4642738", Offset = "0x463E738", VA = "0x4642738", Slot = "7")]
		protected override void OnUploadFileSuccess(string fileId)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x464280C", Offset = "0x463E80C", VA = "0x464280C")]
		private void OnSendChatSuccess()
		{
		}
	}
}
