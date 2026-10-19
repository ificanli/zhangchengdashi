using System.Collections.Generic;
using Il2CppDummyDll;

namespace I2.Loc
{
	[Token(Token = "0x2000D73")]
	public class TranslationJob_Main : TranslationJob
	{
		[Token(Token = "0x4005F64")]
		[FieldOffset(Offset = "0x18")]
		private TranslationJob_WEB mWeb;

		[Token(Token = "0x4005F65")]
		[FieldOffset(Offset = "0x20")]
		private TranslationJob_POST mPost;

		[Token(Token = "0x4005F66")]
		[FieldOffset(Offset = "0x28")]
		private TranslationJob_GET mGet;

		[Token(Token = "0x4005F67")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, TranslationQuery> _requests;

		[Token(Token = "0x4005F68")]
		[FieldOffset(Offset = "0x38")]
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

		[Token(Token = "0x4005F69")]
		[FieldOffset(Offset = "0x40")]
		public string mErrorMessage;

		[Token(Token = "0x6005318")]
		[Address(RVA = "0x430E37C", Offset = "0x430A37C", VA = "0x430E37C")]
		public TranslationJob_Main(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
		}

		[Token(Token = "0x6005319")]
		[Address(RVA = "0x43111D0", Offset = "0x430D1D0", VA = "0x43111D0", Slot = "5")]
		public override eJobState GetState()
		{
			return default;
		}

		[Token(Token = "0x600531A")]
		[Address(RVA = "0x4311384", Offset = "0x430D384", VA = "0x4311384", Slot = "6")]
		public override void Dispose()
		{
		}
	}
}
