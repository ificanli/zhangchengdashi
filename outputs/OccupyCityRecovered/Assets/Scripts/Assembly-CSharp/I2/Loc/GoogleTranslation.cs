using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace I2.Loc
{
	[Token(Token = "0x2000D69")]
	public static class GoogleTranslation
	{
		[Token(Token = "0x2000D6A")]
		public delegate void fnOnTranslated(string Translation, string Error);

		[Token(Token = "0x2000D6B")]
		public delegate void fnOnTranslationReady(Dictionary<string, TranslationQuery> dict, string error);

		[Token(Token = "0x2000D6D")]
		[CompilerGenerated]
		private sealed class _003CWaitForTranslations_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005F52")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005F53")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x17000E65")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600530C")]
				[Address(RVA = "0x4310C74", Offset = "0x430CC74", VA = "0x4310C74", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000E66")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600530E")]
				[Address(RVA = "0x4310CB4", Offset = "0x430CCB4", VA = "0x4310CB4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005309")]
			[Address(RVA = "0x430EB88", Offset = "0x430AB88", VA = "0x430EB88")]
			[DebuggerHidden]
			public _003CWaitForTranslations_003Ed__11(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600530A")]
			[Address(RVA = "0x4310AEC", Offset = "0x430CAEC", VA = "0x4310AEC", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600530B")]
			[Address(RVA = "0x4310AF0", Offset = "0x430CAF0", VA = "0x4310AF0", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600530C")]
			[Address(RVA = "0x4310C74", Offset = "0x430CC74", VA = "0x4310C74", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600530D")]
			[Address(RVA = "0x4310C7C", Offset = "0x430CC7C", VA = "0x4310C7C", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600530E")]
			[Address(RVA = "0x4310CB4", Offset = "0x430CCB4", VA = "0x4310CB4", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4005F4C")]
		[FieldOffset(Offset = "0x0")]
		private static List<UnityWebRequest> mCurrentTranslations;

		[Token(Token = "0x4005F4D")]
		[FieldOffset(Offset = "0x8")]
		private static List<TranslationJob> mTranslationJobs;

		[Token(Token = "0x60052E3")]
		[Address(RVA = "0x430DEE8", Offset = "0x4309EE8", VA = "0x430DEE8")]
		public static bool CanTranslate()
		{
			return default;
		}

		[Token(Token = "0x60052E4")]
		[Address(RVA = "0x4304F88", Offset = "0x4300F88", VA = "0x4304F88")]
		public static void Translate(string text, string LanguageCodeFrom, string LanguageCodeTo, fnOnTranslated OnTranslationReady)
		{
		}

		[Token(Token = "0x60052E5")]
		[Address(RVA = "0x430E1BC", Offset = "0x430A1BC", VA = "0x430E1BC")]
		public static string ForceTranslate(string text, string LanguageCodeFrom, string LanguageCodeTo)
		{
			return null;
		}

		[Token(Token = "0x60052E6")]
		[Address(RVA = "0x43059FC", Offset = "0x43019FC", VA = "0x43059FC")]
		public static void Translate(Dictionary<string, TranslationQuery> requests, fnOnTranslationReady OnTranslationReady, bool usePOST = true)
		{
		}

		[Token(Token = "0x60052E7")]
		[Address(RVA = "0x4305758", Offset = "0x4301758", VA = "0x4305758")]
		public static bool ForceTranslate(Dictionary<string, TranslationQuery> requests, bool usePOST = true)
		{
			return default;
		}

		[Token(Token = "0x60052E8")]
		[Address(RVA = "0x430E508", Offset = "0x430A508", VA = "0x430E508")]
		public static List<string> ConvertTranslationRequest(Dictionary<string, TranslationQuery> requests, bool encodeGET)
		{
			return null;
		}

		[Token(Token = "0x60052E9")]
		[Address(RVA = "0x430E3F8", Offset = "0x430A3F8", VA = "0x430E3F8")]
		private static void AddTranslationJob(TranslationJob job)
		{
		}

		[Token(Token = "0x60052EA")]
		[Address(RVA = "0x430EB30", Offset = "0x430AB30", VA = "0x430EB30")]
		[IteratorStateMachine(typeof(_003CWaitForTranslations_003Ed__11))]
		private static IEnumerator WaitForTranslations()
		{
			return null;
		}

		[Token(Token = "0x60052EB")]
		[Address(RVA = "0x430EBB0", Offset = "0x430ABB0", VA = "0x430EBB0")]
		public static string ParseTranslationResult(string html, Dictionary<string, TranslationQuery> requests)
		{
			return null;
		}

		[Token(Token = "0x60052EC")]
		[Address(RVA = "0x430F244", Offset = "0x430B244", VA = "0x430F244")]
		public static bool IsTranslating()
		{
			return default;
		}

		[Token(Token = "0x60052ED")]
		[Address(RVA = "0x430F2F8", Offset = "0x430B2F8", VA = "0x430F2F8")]
		public static void CancelCurrentGoogleTranslations()
		{
		}

		[Token(Token = "0x60052EE")]
		[Address(RVA = "0x430DF98", Offset = "0x4309F98", VA = "0x430DF98")]
		public static void CreateQueries(string text, string LanguageCodeFrom, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
		}

		[Token(Token = "0x60052EF")]
		[Address(RVA = "0x430F500", Offset = "0x430B500", VA = "0x430F500")]
		private static void CreateQueries_Plurals(string text, string LanguageCodeFrom, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
		}

		[Token(Token = "0x60052F0")]
		[Address(RVA = "0x4305518", Offset = "0x4301518", VA = "0x4305518")]
		public static void AddQuery(string text, string LanguageCodeFrom, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
		}

		[Token(Token = "0x60052F1")]
		[Address(RVA = "0x430FF54", Offset = "0x430BF54", VA = "0x430FF54")]
		private static string GetTranslation(string text, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
			return null;
		}

		[Token(Token = "0x60052F2")]
		[Address(RVA = "0x430EFE4", Offset = "0x430AFE4", VA = "0x430EFE4")]
		private static TranslationQuery FindQueryFromOrigText(string origText, Dictionary<string, TranslationQuery> dict)
		{
			return default;
		}

		[Token(Token = "0x60052F3")]
		[Address(RVA = "0x430F748", Offset = "0x430B748", VA = "0x430F748")]
		public static bool HasParameters(string text)
		{
			return default;
		}

		[Token(Token = "0x60052F4")]
		[Address(RVA = "0x430F91C", Offset = "0x430B91C", VA = "0x430F91C")]
		public static string GetPluralParameter(string text, bool forceTag)
		{
			return null;
		}

		[Token(Token = "0x60052F5")]
		[Address(RVA = "0x430F7E4", Offset = "0x430B7E4", VA = "0x430F7E4")]
		public static string GetPluralText(string text, string pluralType)
		{
			return null;
		}

		[Token(Token = "0x60052F6")]
		[Address(RVA = "0x4310054", Offset = "0x430C054", VA = "0x4310054")]
		private static int FindClosingTag(string tag, MatchCollection matches, int startIndex)
		{
			return default;
		}

		[Token(Token = "0x60052F7")]
		[Address(RVA = "0x430F194", Offset = "0x430B194", VA = "0x430F194")]
		private static string GetGoogleNoTranslateTag(int tagNumber)
		{
			return null;
		}

		[Token(Token = "0x60052F8")]
		[Address(RVA = "0x430FA0C", Offset = "0x430BA0C", VA = "0x430FA0C")]
		private static void ParseNonTranslatableElements(ref TranslationQuery query)
		{
		}

		[Token(Token = "0x60052F9")]
		[Address(RVA = "0x43057E0", Offset = "0x43017E0", VA = "0x43057E0")]
		public static string GetQueryResult(string text, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
			return null;
		}

		[Token(Token = "0x60052FA")]
		[Address(RVA = "0x431011C", Offset = "0x430C11C", VA = "0x431011C")]
		public static string RebuildTranslation(string text, Dictionary<string, TranslationQuery> dict, string LanguageCodeTo)
		{
			return null;
		}

		[Token(Token = "0x60052FB")]
		[Address(RVA = "0x4310444", Offset = "0x430C444", VA = "0x4310444")]
		private static string RebuildTranslation_Plural(string text, Dictionary<string, TranslationQuery> dict, string LanguageCodeTo)
		{
			return null;
		}

		[Token(Token = "0x60052FC")]
		[Address(RVA = "0x43107A8", Offset = "0x430C7A8", VA = "0x43107A8")]
		public static string UppercaseFirst(string s)
		{
			return null;
		}

		[Token(Token = "0x60052FD")]
		[Address(RVA = "0x430EA7C", Offset = "0x430AA7C", VA = "0x430EA7C")]
		public static string TitleCase(string s)
		{
			return null;
		}
	}
}
