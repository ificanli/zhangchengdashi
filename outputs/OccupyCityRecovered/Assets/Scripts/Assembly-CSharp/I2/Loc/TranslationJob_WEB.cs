using System.Collections.Generic;
using Il2CppDummyDll;

namespace I2.Loc
{
	[Token(Token = "0x2000D75")]
	public class TranslationJob_WEB : TranslationJob_WWW
	{
		[Token(Token = "0x4005F6C")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, TranslationQuery> _requests;

		[Token(Token = "0x4005F6D")]
		[FieldOffset(Offset = "0x28")]
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

		[Token(Token = "0x4005F6E")]
		[FieldOffset(Offset = "0x30")]
		public string mErrorMessage;

		[Token(Token = "0x4005F6F")]
		[FieldOffset(Offset = "0x38")]
		private string mCurrentBatch_ToLanguageCode;

		[Token(Token = "0x4005F70")]
		[FieldOffset(Offset = "0x40")]
		private string mCurrentBatch_FromLanguageCode;

		[Token(Token = "0x4005F71")]
		[FieldOffset(Offset = "0x48")]
		private List<string> mCurrentBatch_Text;

		[Token(Token = "0x4005F72")]
		[FieldOffset(Offset = "0x50")]
		private List<KeyValuePair<string, string>> mQueries;

		[Token(Token = "0x600531E")]
		[Address(RVA = "0x4311540", Offset = "0x430D540", VA = "0x4311540")]
		public TranslationJob_WEB(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
		}

		[Token(Token = "0x600531F")]
		[Address(RVA = "0x4311578", Offset = "0x430D578", VA = "0x4311578")]
		private void FindAllQueries()
		{
		}

		[Token(Token = "0x6005320")]
		[Address(RVA = "0x4311924", Offset = "0x430D924", VA = "0x4311924")]
		private void ExecuteNextBatch()
		{
		}

		[Token(Token = "0x6005321")]
		[Address(RVA = "0x4311CB8", Offset = "0x430DCB8", VA = "0x4311CB8", Slot = "5")]
		public override eJobState GetState()
		{
			return default;
		}

		[Token(Token = "0x6005322")]
		[Address(RVA = "0x4311D58", Offset = "0x430DD58", VA = "0x4311D58")]
		public void ProcessResult(byte[] bytes, string errorMsg)
		{
		}

		[Token(Token = "0x6005323")]
		[Address(RVA = "0x4311E74", Offset = "0x430DE74", VA = "0x4311E74")]
		private string ParseTranslationResult(string html, string OriginalText)
		{
			return null;
		}
	}
}
