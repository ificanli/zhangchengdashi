using System.Collections.Generic;
using CommonGameModule.Email;
using Il2CppDummyDll;
using L_Tools;

namespace ljzs_lt
{
	[Token(Token = "0x2000F4A")]
	public class LTEmailControl : Singleton<LTEmailControl>
	{
		[Token(Token = "0x40069AF")]
		[FieldOffset(Offset = "0x10")]
		private EmailModule emailModule;

		[Token(Token = "0x40069B0")]
		private const string EmailSaveKey = "EmailSave";

		[Token(Token = "0x40069B1")]
		[FieldOffset(Offset = "0x18")]
		private bool RegUpdate;

		[Token(Token = "0x40069B2")]
		[FieldOffset(Offset = "0x1C")]
		private int FailTime;

		[Token(Token = "0x40069B3")]
		[FieldOffset(Offset = "0x20")]
		private float updateEmailTimer;

		[Token(Token = "0x17000F72")]
		private float updateEmailInterval
		{
			[Token(Token = "0x6005B6D")]
			[Address(RVA = "0x439CE74", Offset = "0x4398E74", VA = "0x439CE74")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005B6C")]
		[Address(RVA = "0x439CA0C", Offset = "0x4398A0C", VA = "0x439CA0C")]
		public void InitEmail()
		{
		}

		[Token(Token = "0x6005B6E")]
		[Address(RVA = "0x439CE8C", Offset = "0x4398E8C", VA = "0x439CE8C")]
		private void Update()
		{
		}

		[Token(Token = "0x6005B6F")]
		[Address(RVA = "0x439CB24", Offset = "0x4398B24", VA = "0x439CB24")]
		public int GetEmailTotalData(List<EmailData> emailDataList)
		{
			return default;
		}

		[Token(Token = "0x6005B70")]
		[Address(RVA = "0x439CF94", Offset = "0x4398F94", VA = "0x439CF94")]
		private void SetEmailReadState(EmailData data)
		{
		}

		[Token(Token = "0x6005B71")]
		[Address(RVA = "0x439CEF4", Offset = "0x4398EF4", VA = "0x439CEF4")]
		public EmailStatus GetEmailStatus(EmailData data)
		{
			return default;
		}

		[Token(Token = "0x6005B72")]
		[Address(RVA = "0x439CFB0", Offset = "0x4398FB0", VA = "0x439CFB0")]
		public void SetEmailStatus(EmailData data, EmailStatus emailStatus)
		{
		}

		[Token(Token = "0x6005B73")]
		[Address(RVA = "0x439D1FC", Offset = "0x43991FC", VA = "0x439D1FC")]
		public void ReportEmailRewardGet(EmailData data)
		{
		}

		[Token(Token = "0x6005B74")]
		[Address(RVA = "0x439D2A4", Offset = "0x43992A4", VA = "0x439D2A4")]
		public LTEmailControl()
		{
		}
	}
}
