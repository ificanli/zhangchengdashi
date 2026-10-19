using System.Collections.Generic;
using Il2CppDummyDll;

namespace GameFramework.Net.Http
{
	[Token(Token = "0x2000488")]
	public class ResponseGetAttachement : IResponseData
	{
		[Token(Token = "0x2000489")]
		public class Data
		{
			[Token(Token = "0x4001EBB")]
			[FieldOffset(Offset = "0x10")]
			public List<UserAttachmentInfo> list;

			[Token(Token = "0x6006BDC")]
			[Address(RVA = "0x72860A4", Offset = "0x72820A4", VA = "0x72860A4")]
			public Data()
			{
			}
		}

		[Token(Token = "0x200048A")]
		public class UserAttachmentInfo
		{
			[Token(Token = "0x4001EBC")]
			[FieldOffset(Offset = "0x10")]
			public string attachment;

			[Token(Token = "0x4001EBD")]
			[FieldOffset(Offset = "0x18")]
			public string userId;

			[Token(Token = "0x6006BDD")]
			[Address(RVA = "0x72860AC", Offset = "0x72820AC", VA = "0x72860AC")]
			public UserAttachmentInfo()
			{
			}
		}

		[Token(Token = "0x4001EBA")]
		[FieldOffset(Offset = "0x20")]
		public Data data;

		[Token(Token = "0x6006BDB")]
		[Address(RVA = "0x728609C", Offset = "0x728209C", VA = "0x728609C")]
		public ResponseGetAttachement()
		{
		}
	}
}
