using Il2CppDummyDll;

namespace CommonGameModule.Debugger.Tools.FeiShu
{
	[Token(Token = "0x2000046")]
	public class FeiShuOrderUploadLogFile : FeiShuOrderTokenBase
	{
		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x30")]
		private readonly string filePath;

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x46426FC", Offset = "0x463E6FC", VA = "0x46426FC")]
		public FeiShuOrderUploadLogFile(string appId, string appSecret, string filePath) : base(appId, appSecret)
		{
			throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED FeiShuOrderUploadLogFile..ctor RVA=0x46426FC Token=0x0600011D; original base constructor arguments recovered; remaining original constructor body pending.");
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x46430CC", Offset = "0x463F0CC", VA = "0x46430CC", Slot = "6")]
		protected override void OnGetTokenSuccess(string token)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x4643268", Offset = "0x463F268", VA = "0x4643268", Slot = "7")]
		protected virtual void OnUploadFileSuccess(string fileId)
		{
		}
	}
}
