using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2000D62")]
	public class RealTimeTranslation : MonoBehaviour
	{
		[Token(Token = "0x4005F3A")]
		[FieldOffset(Offset = "0x20")]
		private string OriginalText;

		[Token(Token = "0x4005F3B")]
		[FieldOffset(Offset = "0x28")]
		private string TranslatedText;

		[Token(Token = "0x4005F3C")]
		[FieldOffset(Offset = "0x30")]
		private bool IsTranslating;

		[Token(Token = "0x60052BC")]
		[Address(RVA = "0x43047CC", Offset = "0x43007CC", VA = "0x43047CC")]
		public void OnGUI()
		{
		}

		[Token(Token = "0x60052BD")]
		[Address(RVA = "0x4304C70", Offset = "0x4300C70", VA = "0x4304C70")]
		public void StartTranslating(string fromCode, string toCode)
		{
		}

		[Token(Token = "0x60052BE")]
		[Address(RVA = "0x430523C", Offset = "0x430123C", VA = "0x430523C")]
		private void OnTranslationReady(string Translation, string errorMsg)
		{
		}

		[Token(Token = "0x60052BF")]
		[Address(RVA = "0x43052C0", Offset = "0x43012C0", VA = "0x43052C0")]
		public void ExampleMultiTranslations_Blocking()
		{
		}

		[Token(Token = "0x60052C0")]
		[Address(RVA = "0x4304D34", Offset = "0x4300D34", VA = "0x4304D34")]
		public void ExampleMultiTranslations_Async()
		{
		}

		[Token(Token = "0x60052C1")]
		[Address(RVA = "0x4305A88", Offset = "0x4301A88", VA = "0x4305A88")]
		private void OnMultitranslationReady(Dictionary<string, TranslationQuery> dict, string errorMsg)
		{
		}

		[Token(Token = "0x60052C2")]
		[Address(RVA = "0x4305CB8", Offset = "0x4301CB8", VA = "0x4305CB8")]
		public bool IsWaitingForTranslation()
		{
			return default;
		}

		[Token(Token = "0x60052C3")]
		[Address(RVA = "0x4305CC0", Offset = "0x4301CC0", VA = "0x4305CC0")]
		public string GetTranslatedText()
		{
			return null;
		}

		[Token(Token = "0x60052C4")]
		[Address(RVA = "0x4305CC8", Offset = "0x4301CC8", VA = "0x4305CC8")]
		public void SetOriginalText(string text)
		{
		}

		[Token(Token = "0x60052C5")]
		[Address(RVA = "0x4305CD0", Offset = "0x4301CD0", VA = "0x4305CD0")]
		public RealTimeTranslation()
		{
		}
	}
}
