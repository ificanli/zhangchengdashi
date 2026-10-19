using System.Collections.Generic;
using Il2CppDummyDll;

namespace I2.Loc
{
	[Token(Token = "0x2000D72")]
	public class TranslationJob_GET : TranslationJob_WWW
	{
		[Token(Token = "0x4005F60")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, TranslationQuery> _requests;

		[Token(Token = "0x4005F61")]
		[FieldOffset(Offset = "0x28")]
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

		[Token(Token = "0x4005F62")]
		[FieldOffset(Offset = "0x30")]
		private List<string> mQueries;

		[Token(Token = "0x4005F63")]
		[FieldOffset(Offset = "0x38")]
		public string mErrorMessage;

		[Token(Token = "0x6005314")]
		[Address(RVA = "0x4310CFC", Offset = "0x430CCFC", VA = "0x4310CFC")]
		public TranslationJob_GET(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
		}

		[Token(Token = "0x6005315")]
		[Address(RVA = "0x4310D88", Offset = "0x430CD88", VA = "0x4310D88")]
		private void ExecuteNextQuery()
		{
		}

		[Token(Token = "0x6005316")]
		[Address(RVA = "0x4310EAC", Offset = "0x430CEAC", VA = "0x4310EAC", Slot = "5")]
		public override eJobState GetState()
		{
			return default;
		}

		[Token(Token = "0x6005317")]
		[Address(RVA = "0x4310F4C", Offset = "0x430CF4C", VA = "0x4310F4C")]
		public void ProcessResult(byte[] bytes, string errorMsg)
		{
		}
	}
}
