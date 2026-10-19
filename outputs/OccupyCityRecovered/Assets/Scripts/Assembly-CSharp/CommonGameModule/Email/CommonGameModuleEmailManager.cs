using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace CommonGameModule.Email
{
	[Token(Token = "0x2001002")]
	[ModelRegister("CommonGameModuleEmail", false, false)]
	[Skip]
	public class CommonGameModuleEmailManager : DataManagerBase
	{
		[Token(Token = "0x4006CAE")]
		[FieldOffset(Offset = "0x28")]
		public EmailTotalData emailTotalData;

		[Token(Token = "0x17000FB9")]
		public int mailCount
		{
			[Token(Token = "0x6005FF1")]
			[Address(RVA = "0x440D22C", Offset = "0x440922C", VA = "0x440D22C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005FF2")]
		[Address(RVA = "0x440D954", Offset = "0x4409954", VA = "0x440D954", Slot = "5")]
		public override void OnInit()
		{
		}

		[Token(Token = "0x6005FF3")]
		[Address(RVA = "0x440D964", Offset = "0x4409964", VA = "0x440D964", Slot = "11")]
		protected override void UpdateDataCallBack(string str)
		{
		}

		[Token(Token = "0x6005FF4")]
		[Address(RVA = "0x440DA8C", Offset = "0x4409A8C", VA = "0x440DA8C", Slot = "7")]
		public override void OnRelease()
		{
		}

		[Token(Token = "0x6005FF5")]
		[Address(RVA = "0x440DA90", Offset = "0x4409A90", VA = "0x440DA90", Slot = "6")]
		public override void OnSave()
		{
		}

		[Token(Token = "0x6005FF6")]
		[Address(RVA = "0x440D27C", Offset = "0x440927C", VA = "0x440D27C")]
		internal void AddNewMail(EmailData emailData)
		{
		}

		[Token(Token = "0x6005FF7")]
		[Address(RVA = "0x440DBBC", Offset = "0x4409BBC", VA = "0x440DBBC")]
		public void DeleteNewMail(EmailData emailData)
		{
		}

		[Token(Token = "0x6005FF8")]
		[Address(RVA = "0x440D33C", Offset = "0x440933C", VA = "0x440D33C")]
		public void DeleteOverMails()
		{
		}

		[Token(Token = "0x6005FF9")]
		[Address(RVA = "0x440CDC4", Offset = "0x4408DC4", VA = "0x440CDC4")]
		public void DeleteTimeOutEmails()
		{
		}

		[Token(Token = "0x6005FFA")]
		[Address(RVA = "0x440DB10", Offset = "0x4409B10", VA = "0x440DB10")]
		private bool ExistMailID(long id)
		{
			return default;
		}

		[Token(Token = "0x6005FFB")]
		[Address(RVA = "0x440CA48", Offset = "0x4408A48", VA = "0x440CA48")]
		public CommonGameModuleEmailManager()
		{
		}
	}
}
