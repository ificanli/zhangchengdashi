using Il2CppDummyDll;

namespace CommonGameModule.Debugger.Tools.FeiShu
{
	[Token(Token = "0x2000042")]
	public class FeiShuOrderSendLogFileToRobot : FeiShuOrderUploadLogFile
	{
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x38")]
		private readonly string robotUrl;

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x4642940", Offset = "0x463E940", VA = "0x4642940")]
		public FeiShuOrderSendLogFileToRobot(string appId, string appSecret, string filePath, string robotUrl) : base(appId, appSecret, filePath)
		{
			throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED FeiShuOrderSendLogFileToRobot..ctor RVA=0x4642940 Token=0x0600010F; original base constructor arguments recovered; remaining original constructor body pending.");
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x4642980", Offset = "0x463E980", VA = "0x4642980", Slot = "7")]
		protected override void OnUploadFileSuccess(string fileId)
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x4642A4C", Offset = "0x463EA4C", VA = "0x4642A4C")]
		private void OnSendRobotMsgSuccess()
		{
		}
	}
}
