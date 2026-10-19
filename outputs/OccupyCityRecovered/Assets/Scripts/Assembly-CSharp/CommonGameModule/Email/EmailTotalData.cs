using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CommonGameModule.Email
{
	[Serializable]
	[Token(Token = "0x2001001")]
	public class EmailTotalData
	{
		[Token(Token = "0x4006CAD")]
		[FieldOffset(Offset = "0x10")]
		public List<EmailData> Datas;

		[Token(Token = "0x6005FF0")]
		[Address(RVA = "0x440D94C", Offset = "0x440994C", VA = "0x440D94C")]
		public EmailTotalData()
		{
		}
	}
}
