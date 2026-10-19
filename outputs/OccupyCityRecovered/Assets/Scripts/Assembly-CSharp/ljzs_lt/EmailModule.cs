using CommonGameModule.Email;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Token(Token = "0x2000F48")]
	public class EmailModule : EmailBaseModule
	{
		[Token(Token = "0x40069A8")]
		[FieldOffset(Offset = "0x10")]
		public float emailInterval;

		[Token(Token = "0x40069A9")]
		[FieldOffset(Offset = "0x14")]
		public int emailMaxLimit;

		[Token(Token = "0x6005B64")]
		[Address(RVA = "0x439C874", Offset = "0x4398874", VA = "0x439C874", Slot = "4")]
		internal override string GetEmailTag()
		{
			return null;
		}

		[Token(Token = "0x6005B65")]
		[Address(RVA = "0x439C8F8", Offset = "0x43988F8", VA = "0x439C8F8", Slot = "5")]
		internal override float GetEmailInterval()
		{
			return default;
		}

		[Token(Token = "0x6005B66")]
		[Address(RVA = "0x439C900", Offset = "0x4398900", VA = "0x439C900", Slot = "6")]
		internal override int GetEmailMaxLimit()
		{
			return default;
		}

		[Token(Token = "0x6005B67")]
		[Address(RVA = "0x439C908", Offset = "0x4398908", VA = "0x439C908", Slot = "7")]
		internal override string GetEmailUserID()
		{
			return null;
		}

		[Token(Token = "0x6005B68")]
		[Address(RVA = "0x439C968", Offset = "0x4398968", VA = "0x439C968", Slot = "8")]
		internal override string GetEditorAddres()
		{
			return null;
		}

		[Token(Token = "0x6005B69")]
		[Address(RVA = "0x439C9AC", Offset = "0x43989AC", VA = "0x439C9AC", Slot = "9")]
		internal override string GetEmailBizDomain()
		{
			return null;
		}

		[Token(Token = "0x6005B6A")]
		[Address(RVA = "0x439C9F0", Offset = "0x43989F0", VA = "0x439C9F0", Slot = "10")]
		internal override bool EmailValidation(EmailData emailData)
		{
			return default;
		}

		[Token(Token = "0x6005B6B")]
		[Address(RVA = "0x439C9F8", Offset = "0x43989F8", VA = "0x439C9F8")]
		public EmailModule()
		{
		}
	}
}
