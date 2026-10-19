using System.Collections.Generic;
using Il2CppDummyDll;

namespace I2.Loc
{
	[Token(Token = "0x2000D74")]
	public class TranslationJob_POST : TranslationJob_WWW
	{
		[Token(Token = "0x4005F6A")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, TranslationQuery> _requests;

		[Token(Token = "0x4005F6B")]
		[FieldOffset(Offset = "0x28")]
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

		[Token(Token = "0x600531B")]
		[Address(RVA = "0x431104C", Offset = "0x430D04C", VA = "0x431104C")]
		public TranslationJob_POST(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
		}

		[Token(Token = "0x600531C")]
		[Address(RVA = "0x43113CC", Offset = "0x430D3CC", VA = "0x43113CC", Slot = "5")]
		public override eJobState GetState()
		{
			return default;
		}

		[Token(Token = "0x600531D")]
		[Address(RVA = "0x4311458", Offset = "0x430D458", VA = "0x4311458")]
		public void ProcessResult(byte[] bytes, string errorMsg)
		{
		}
	}
}
