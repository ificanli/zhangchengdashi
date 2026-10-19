using Il2CppDummyDll;

namespace CommonGameModule.Email
{
	[Token(Token = "0x2000FF5")]
	public abstract class EmailBaseModule
	{
		[Token(Token = "0x6005FBB")]
		[Address(RVA = "0x440BBDC", Offset = "0x4407BDC", VA = "0x440BBDC", Slot = "4")]
		internal virtual string GetEmailTag()
		{
			return null;
		}

		[Token(Token = "0x6005FBC")]
		[Address(RVA = "0x440BC30", Offset = "0x4407C30", VA = "0x440BC30", Slot = "5")]
		internal virtual float GetEmailInterval()
		{
			return default;
		}

		[Token(Token = "0x6005FBD")]
		[Address(RVA = "0x440BC38", Offset = "0x4407C38", VA = "0x440BC38", Slot = "6")]
		internal virtual int GetEmailMaxLimit()
		{
			return default;
		}

		[Token(Token = "0x6005FBE")]
		[Address(RVA = "0x440BC40", Offset = "0x4407C40", VA = "0x440BC40", Slot = "7")]
		internal virtual string GetEmailUserID()
		{
			return null;
		}

		[Token(Token = "0x6005FBF")]
		[Address(RVA = "0x440BD2C", Offset = "0x4407D2C", VA = "0x440BD2C")]
		private string GetDeviceID()
		{
			return null;
		}

		[Token(Token = "0x6005FC0")]
		[Address(RVA = "0x440BD88", Offset = "0x4407D88", VA = "0x440BD88")]
		internal string GetAddres()
		{
			return null;
		}

		[Token(Token = "0x6005FC1")]
		[Address(RVA = "0x440BD94", Offset = "0x4407D94", VA = "0x440BD94", Slot = "8")]
		internal virtual string GetEditorAddres()
		{
			return null;
		}

		[Token(Token = "0x6005FC2")]
		internal abstract string GetEmailBizDomain();

		[Token(Token = "0x6005FC3")]
		internal abstract bool EmailValidation(EmailData emailData);

		[Token(Token = "0x6005FC4")]
		[Address(RVA = "0x440BDD4", Offset = "0x4407DD4", VA = "0x440BDD4")]
		public EmailTotalData GetEmailTotalData()
		{
			return null;
		}

		[Token(Token = "0x6005FC5")]
		[Address(RVA = "0x440BE48", Offset = "0x4407E48", VA = "0x440BE48")]
		public void SetEmailReadState(EmailData emailData)
		{
		}

		[Token(Token = "0x6005FC6")]
		[Address(RVA = "0x440C000", Offset = "0x4408000", VA = "0x440C000")]
		public void Pause()
		{
		}

		[Token(Token = "0x6005FC7")]
		[Address(RVA = "0x440C060", Offset = "0x4408060", VA = "0x440C060")]
		public void Continue()
		{
		}

		[Token(Token = "0x6005FC8")]
		[Address(RVA = "0x440C0B8", Offset = "0x44080B8", VA = "0x440C0B8")]
		protected EmailBaseModule()
		{
		}
	}
}
