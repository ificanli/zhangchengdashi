using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2000D8A")]
	public static class LocalizationManager
	{
		[Token(Token = "0x2000D8B")]
		public delegate bool FnCustomApplyLocalizationParams(ref string translation, _GetParam getParam, bool allowLocalizedParameters);

		[Token(Token = "0x2000D8C")]
		public delegate object _GetParam(string param);

		[Token(Token = "0x2000D8D")]
		public delegate void OnLocalizeCallback();

		[Token(Token = "0x2000D94")]
		[CompilerGenerated]
		private sealed class _003CCoroutine_LocalizeAll_003Ed__88 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006023")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006024")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x17000E74")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6005435")]
				[Address(RVA = "0x4325E20", Offset = "0x4321E20", VA = "0x4325E20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000E75")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6005437")]
				[Address(RVA = "0x4325E60", Offset = "0x4321E60", VA = "0x4325E60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005432")]
			[Address(RVA = "0x4324FAC", Offset = "0x4320FAC", VA = "0x4324FAC")]
			[DebuggerHidden]
			public _003CCoroutine_LocalizeAll_003Ed__88(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005433")]
			[Address(RVA = "0x4325D60", Offset = "0x4321D60", VA = "0x4325D60", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6005434")]
			[Address(RVA = "0x4325D64", Offset = "0x4321D64", VA = "0x4325D64", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005435")]
			[Address(RVA = "0x4325E20", Offset = "0x4321E20", VA = "0x4325E20", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005436")]
			[Address(RVA = "0x4325E28", Offset = "0x4321E28", VA = "0x4325E28", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6005437")]
			[Address(RVA = "0x4325E60", Offset = "0x4321E60", VA = "0x4325E60", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2000D95")]
		[CompilerGenerated]
		private sealed class _003CDelayed_Import_Google_003Ed__63 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006025")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006026")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4006027")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x4006028")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public LanguageSourceData source;

			[Token(Token = "0x4006029")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool justCheck;

			[Token(Token = "0x17000E76")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600543B")]
				[Address(RVA = "0x4325F1C", Offset = "0x4321F1C", VA = "0x4325F1C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000E77")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600543D")]
				[Address(RVA = "0x4325F5C", Offset = "0x4321F5C", VA = "0x4325F5C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005438")]
			[Address(RVA = "0x4323DD4", Offset = "0x431FDD4", VA = "0x4323DD4")]
			[DebuggerHidden]
			public _003CDelayed_Import_Google_003Ed__63(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005439")]
			[Address(RVA = "0x4325E68", Offset = "0x4321E68", VA = "0x4325E68", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600543A")]
			[Address(RVA = "0x4325E6C", Offset = "0x4321E6C", VA = "0x4325E6C", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600543B")]
			[Address(RVA = "0x4325F1C", Offset = "0x4321F1C", VA = "0x4325F1C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600543C")]
			[Address(RVA = "0x4325F24", Offset = "0x4321F24", VA = "0x4325F24", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600543D")]
			[Address(RVA = "0x4325F5C", Offset = "0x4321F5C", VA = "0x4325F5C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4006008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string mCurrentLanguage;

		[Token(Token = "0x4006009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string mLanguageCode;

		[Token(Token = "0x400600A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static CultureInfo mCurrentCulture;

		[Token(Token = "0x400600B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static bool mChangeCultureInfo;

		[Token(Token = "0x400600C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public static bool IsRight2Left;

		[Token(Token = "0x400600D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public static bool HasJoinedWords;

		[Token(Token = "0x400600E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static List<ILocalizationParamsManager> ParamManagers;

		[Token(Token = "0x400600F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static FnCustomApplyLocalizationParams CustomApplyLocalizationParams;

		[Token(Token = "0x4006010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static string[] LanguagesRTL;

		[Token(Token = "0x4006011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static List<LanguageSourceData> Sources;

		[Token(Token = "0x4006012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] GlobalSources;

		[Token(Token = "0x4006013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static Func<LanguageSourceData, bool> Callback_AllowSyncFromGoogle;

		[Token(Token = "0x4006014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static string mCurrentDeviceLanguage;

		[Token(Token = "0x4006015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static List<ILocalizeTargetDescriptor> mLocalizeTargets;

		[Token(Token = "0x4006016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[CompilerGenerated]
		private static OnLocalizeCallback m_OnLocalizeEvent;

		[Token(Token = "0x4006017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static bool mLocalizeIsScheduled;

		[Token(Token = "0x4006018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private static bool mLocalizeIsScheduledWithForcedValue;

		[Token(Token = "0x4006019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		public static bool HighlightLocalizedTargets;

		[Token(Token = "0x17000E6F")]
		public static string CurrentLanguage
		{
			[Token(Token = "0x60053D8")]
			[Address(RVA = "0x431D614", Offset = "0x4319614", VA = "0x431D614")]
			get
			{
				return null;
			}
			[Token(Token = "0x60053D9")]
			[Address(RVA = "0x431E580", Offset = "0x431A580", VA = "0x431E580")]
			set
			{
			}
		}

		[Token(Token = "0x17000E70")]
		public static string CurrentLanguageCode
		{
			[Token(Token = "0x60053DA")]
			[Address(RVA = "0x43209B4", Offset = "0x431C9B4", VA = "0x43209B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60053DB")]
			[Address(RVA = "0x4320A10", Offset = "0x431CA10", VA = "0x4320A10")]
			set
			{
			}
		}

		[Token(Token = "0x17000E71")]
		public static string CurrentRegion
		{
			[Token(Token = "0x60053DC")]
			[Address(RVA = "0x4320C9C", Offset = "0x431CC9C", VA = "0x4320C9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60053DD")]
			[Address(RVA = "0x4320E10", Offset = "0x431CE10", VA = "0x4320E10")]
			set
			{
			}
		}

		[Token(Token = "0x17000E72")]
		public static string CurrentRegionCode
		{
			[Token(Token = "0x60053DE")]
			[Address(RVA = "0x4320FC8", Offset = "0x431CFC8", VA = "0x4320FC8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60053DF")]
			[Address(RVA = "0x4321098", Offset = "0x431D098", VA = "0x4321098")]
			set
			{
			}
		}

		[Token(Token = "0x17000E73")]
		public static CultureInfo CurrentCulture
		{
			[Token(Token = "0x60053E0")]
			[Address(RVA = "0x432119C", Offset = "0x431D19C", VA = "0x432119C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000014")]
		public static event OnLocalizeCallback OnLocalizeEvent
		{
			[Token(Token = "0x6005409")]
			[Address(RVA = "0x431EAF8", Offset = "0x431AAF8", VA = "0x431EAF8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600540A")]
			[Address(RVA = "0x431ED5C", Offset = "0x431AD5C", VA = "0x431ED5C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60053D4")]
		[Address(RVA = "0x431F9E4", Offset = "0x431B9E4", VA = "0x431F9E4")]
		public static void InitializeIfNeeded()
		{
		}

		[Token(Token = "0x60053D5")]
		[Address(RVA = "0x43200D4", Offset = "0x431C0D4", VA = "0x43200D4")]
		public static string GetVersion()
		{
			return null;
		}

		[Token(Token = "0x60053D6")]
		[Address(RVA = "0x4320114", Offset = "0x431C114", VA = "0x4320114")]
		public static int GetRequiredWebServiceVersion()
		{
			return default;
		}

		[Token(Token = "0x60053D7")]
		[Address(RVA = "0x432011C", Offset = "0x431C11C", VA = "0x432011C")]
		public static string GetWebServiceURL([Optional] LanguageSourceData source)
		{
			return null;
		}

		[Token(Token = "0x60053E1")]
		[Address(RVA = "0x43207DC", Offset = "0x431C7DC", VA = "0x43207DC")]
		public static void SetLanguageAndCode(string LanguageName, string LanguageCode, bool RememberLanguage = true, bool Force = false)
		{
		}

		[Token(Token = "0x60053E2")]
		[Address(RVA = "0x43211F4", Offset = "0x431D1F4", VA = "0x43211F4")]
		private static CultureInfo CreateCultureForCode(string code)
		{
			return null;
		}

		[Token(Token = "0x60053E3")]
		[Address(RVA = "0x43214D0", Offset = "0x431D4D0", VA = "0x43214D0")]
		public static void EnableChangingCultureInfo(bool bEnable)
		{
		}

		[Token(Token = "0x60053E4")]
		[Address(RVA = "0x43212E8", Offset = "0x431D2E8", VA = "0x43212E8")]
		private static void SetCurrentCultureInfo()
		{
		}

		[Token(Token = "0x60053E5")]
		[Address(RVA = "0x431FCFC", Offset = "0x431BCFC", VA = "0x431FCFC")]
		private static void SelectStartupLanguage()
		{
		}

		[Token(Token = "0x60053E6")]
		[Address(RVA = "0x4321600", Offset = "0x431D600", VA = "0x4321600")]
		public static bool HasLanguage(string Language, bool AllowDiscartingRegion = true, bool Initialize = true, bool SkipDisabled = true)
		{
			return default;
		}

		[Token(Token = "0x60053E7")]
		[Address(RVA = "0x43202A8", Offset = "0x431C2A8", VA = "0x43202A8")]
		public static string GetSupportedLanguage(string Language, bool ignoreDisabled = false)
		{
			return null;
		}

		[Token(Token = "0x60053E8")]
		[Address(RVA = "0x4320620", Offset = "0x431C620", VA = "0x4320620")]
		public static string GetLanguageCode(string Language)
		{
			return null;
		}

		[Token(Token = "0x60053E9")]
		[Address(RVA = "0x4320AD8", Offset = "0x431CAD8", VA = "0x4320AD8")]
		public static string GetLanguageFromCode(string Code, bool exactMatch = true)
		{
			return null;
		}

		[Token(Token = "0x60053EA")]
		[Address(RVA = "0x43217C4", Offset = "0x431D7C4", VA = "0x43217C4")]
		public static List<string> GetAllLanguages(bool SkipDisabled = true)
		{
			return null;
		}

		[Token(Token = "0x60053EB")]
		[Address(RVA = "0x4321A20", Offset = "0x431DA20", VA = "0x4321A20")]
		public static List<string> GetAllLanguagesCode(bool allowRegions = true, bool SkipDisabled = true)
		{
			return null;
		}

		[Token(Token = "0x60053EC")]
		[Address(RVA = "0x4321C50", Offset = "0x431DC50", VA = "0x4321C50")]
		public static bool IsLanguageEnabled(string Language)
		{
			return default;
		}

		[Token(Token = "0x60053ED")]
		[Address(RVA = "0x4321D5C", Offset = "0x431DD5C", VA = "0x4321D5C")]
		private static void LoadCurrentLanguage()
		{
		}

		[Token(Token = "0x60053EE")]
		[Address(RVA = "0x4321E8C", Offset = "0x431DE8C", VA = "0x4321E8C")]
		public static void PreviewLanguage(string NewLanguage)
		{
		}

		[Token(Token = "0x60053EF")]
		[Address(RVA = "0x431FAA8", Offset = "0x431BAA8", VA = "0x431FAA8")]
		public static void AutoLoadGlobalParamManagers()
		{
		}

		[Token(Token = "0x60053F0")]
		[Address(RVA = "0x4321F5C", Offset = "0x431DF5C", VA = "0x4321F5C")]
		public static void ApplyLocalizationParams(ref string translation, bool allowLocalizedParameters = true)
		{
		}

		[Token(Token = "0x60053F1")]
		[Address(RVA = "0x431D8D0", Offset = "0x43198D0", VA = "0x431D8D0")]
		public static void ApplyLocalizationParams(ref string translation, GameObject root, bool allowLocalizedParameters = true)
		{
		}

		[Token(Token = "0x60053F2")]
		[Address(RVA = "0x4322580", Offset = "0x431E580", VA = "0x4322580")]
		public static void ApplyLocalizationParams(ref string translation, Dictionary<string, object> parameters, bool allowLocalizedParameters = true)
		{
		}

		[Token(Token = "0x60053F3")]
		[Address(RVA = "0x4322100", Offset = "0x431E100", VA = "0x4322100")]
		public static void ApplyLocalizationParams(ref string translation, _GetParam getParam, bool allowLocalizedParameters = true)
		{
		}

		[Token(Token = "0x60053F4")]
		[Address(RVA = "0x43228C0", Offset = "0x431E8C0", VA = "0x43228C0")]
		internal static string GetLocalizationParam(string ParamName, GameObject root)
		{
			return null;
		}

		[Token(Token = "0x60053F5")]
		[Address(RVA = "0x4322B50", Offset = "0x431EB50", VA = "0x4322B50")]
		private static string GetPluralType(MatchCollection matches, string langCode, _GetParam getParam)
		{
			return null;
		}

		[Token(Token = "0x60053F6")]
		[Address(RVA = "0x431DD48", Offset = "0x4319D48", VA = "0x431DD48")]
		public static string ApplyRTLfix(string line)
		{
			return null;
		}

		[Token(Token = "0x60053F7")]
		[Address(RVA = "0x431D9B0", Offset = "0x43199B0", VA = "0x431D9B0")]
		public static string ApplyRTLfix(string line, int maxCharacters, bool ignoreNumbers)
		{
			return null;
		}

		[Token(Token = "0x60053F8")]
		[Address(RVA = "0x4323500", Offset = "0x431F500", VA = "0x4323500")]
		public static string FixRTL_IfNeeded(string text, int maxCharacters = 0, bool ignoreNumber = false)
		{
			return null;
		}

		[Token(Token = "0x60053F9")]
		[Address(RVA = "0x4321360", Offset = "0x431D360", VA = "0x4321360")]
		public static bool IsRTL(string Code)
		{
			return default;
		}

		[Token(Token = "0x60053FA")]
		[Address(RVA = "0x431FC78", Offset = "0x431BC78", VA = "0x431FC78")]
		public static bool UpdateSources()
		{
			return default;
		}

		[Token(Token = "0x60053FB")]
		[Address(RVA = "0x432359C", Offset = "0x431F59C", VA = "0x432359C")]
		private static void UnregisterDeletededSources()
		{
		}

		[Token(Token = "0x60053FC")]
		[Address(RVA = "0x432383C", Offset = "0x431F83C", VA = "0x432383C")]
		private static void RegisterSceneSources()
		{
		}

		[Token(Token = "0x60053FD")]
		[Address(RVA = "0x43236A4", Offset = "0x431F6A4", VA = "0x43236A4")]
		private static void RegisterSourceInResources()
		{
		}

		[Token(Token = "0x60053FE")]
		[Address(RVA = "0x4323C8C", Offset = "0x431FC8C", VA = "0x4323C8C")]
		private static bool AllowSyncFromGoogle(LanguageSourceData Source)
		{
			return default;
		}

		[Token(Token = "0x60053FF")]
		[Address(RVA = "0x4323A40", Offset = "0x431FA40", VA = "0x4323A40")]
		internal static void AddSource(LanguageSourceData Source)
		{
		}

		[Token(Token = "0x6005400")]
		[Address(RVA = "0x4323D2C", Offset = "0x431FD2C", VA = "0x4323D2C")]
		[IteratorStateMachine(typeof(_003CDelayed_Import_Google_003Ed__63))]
		private static IEnumerator Delayed_Import_Google(LanguageSourceData source, float delay, bool justCheck)
		{
			return null;
		}

		[Token(Token = "0x6005401")]
		[Address(RVA = "0x43239C0", Offset = "0x431F9C0", VA = "0x43239C0")]
		internal static void RemoveSource(LanguageSourceData Source)
		{
		}

		[Token(Token = "0x6005402")]
		[Address(RVA = "0x4323DFC", Offset = "0x431FDFC", VA = "0x4323DFC")]
		public static bool IsGlobalSource(string SourceName)
		{
			return default;
		}

		[Token(Token = "0x6005403")]
		[Address(RVA = "0x4323E80", Offset = "0x431FE80", VA = "0x4323E80")]
		public static LanguageSourceData GetSourceContaining(string term, bool fallbackToFirst = true)
		{
			return null;
		}

		[Token(Token = "0x6005404")]
		[Address(RVA = "0x4324030", Offset = "0x4320030", VA = "0x4324030")]
		public static UnityEngine.Object FindAsset(string value)
		{
			return null;
		}

		[Token(Token = "0x6005405")]
		[Address(RVA = "0x4324164", Offset = "0x4320164", VA = "0x4324164")]
		public static void ApplyDownloadedDataFromGoogle()
		{
		}

		[Token(Token = "0x6005406")]
		[Address(RVA = "0x4321564", Offset = "0x431D564", VA = "0x4321564")]
		public static string GetCurrentDeviceLanguage(bool force = false)
		{
			return null;
		}

		[Token(Token = "0x6005407")]
		[Address(RVA = "0x4324244", Offset = "0x4320244", VA = "0x4324244")]
		private static void DetectDeviceLanguage()
		{
		}

		[Token(Token = "0x6005408")]
		[Address(RVA = "0x43246BC", Offset = "0x43206BC", VA = "0x43246BC")]
		public static void RegisterTarget(ILocalizeTargetDescriptor desc)
		{
		}

		[Token(Token = "0x600540B")]
		[Address(RVA = "0x431D804", Offset = "0x4319804", VA = "0x431D804")]
		public static string GetTranslation(string Term, [Optional][DefaultParameterValue(true)] bool FixForRTL, [Optional][DefaultParameterValue(0)] int maxLineLengthForRTL, [Optional][DefaultParameterValue(true)] bool ignoreRTLnumbers, [Optional][DefaultParameterValue(false)] bool applyParameters, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage, bool allowLocalizedParameters = true)
		{
			return null;
		}

		[Token(Token = "0x600540C")]
		[Address(RVA = "0x4324B18", Offset = "0x4320B18", VA = "0x4324B18")]
		public static string GetTermTranslation(string Term, [Optional][DefaultParameterValue(true)] bool FixForRTL, [Optional][DefaultParameterValue(0)] int maxLineLengthForRTL, [Optional][DefaultParameterValue(true)] bool ignoreRTLnumbers, [Optional][DefaultParameterValue(false)] bool applyParameters, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage, bool allowLocalizedParameters = true)
		{
			return null;
		}

		[Token(Token = "0x600540D")]
		[Address(RVA = "0x4324938", Offset = "0x4320938", VA = "0x4324938")]
		public static bool TryGetTranslation(string Term, out string Translation, [Optional][DefaultParameterValue(true)] bool FixForRTL, [Optional][DefaultParameterValue(0)] int maxLineLengthForRTL, [Optional][DefaultParameterValue(true)] bool ignoreRTLnumbers, [Optional][DefaultParameterValue(false)] bool applyParameters, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage, bool allowLocalizedParameters = true)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED LocalizationManager.TryGetTranslation RVA=0x4324938 Token=0x600540D");
}

		[Token(Token = "0x600540E")]
		public static T GetTranslatedObject<T>(string AssetName, [Optional] Localize optionalLocComp) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600540F")]
		public static T GetTranslatedObjectByTermName<T>(string Term, [Optional] Localize optionalLocComp) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6005410")]
		[Address(RVA = "0x4324BC4", Offset = "0x4320BC4", VA = "0x4324BC4")]
		public static string GetAppName(string languageCode)
		{
			return null;
		}

		[Token(Token = "0x6005411")]
		[Address(RVA = "0x43213E4", Offset = "0x431D3E4", VA = "0x43213E4")]
		public static void LocalizeAll(bool Force = false)
		{
		}

		[Token(Token = "0x6005412")]
		[Address(RVA = "0x4324F54", Offset = "0x4320F54", VA = "0x4324F54")]
		[IteratorStateMachine(typeof(_003CCoroutine_LocalizeAll_003Ed__88))]
		private static IEnumerator Coroutine_LocalizeAll()
		{
			return null;
		}

		[Token(Token = "0x6005413")]
		[Address(RVA = "0x4324DDC", Offset = "0x4320DDC", VA = "0x4324DDC")]
		private static void DoLocalizeAll(bool Force = false)
		{
		}

		[Token(Token = "0x6005414")]
		[Address(RVA = "0x4324FD4", Offset = "0x4320FD4", VA = "0x4324FD4")]
		public static List<string> GetCategories()
		{
			return null;
		}

		[Token(Token = "0x6005415")]
		[Address(RVA = "0x43250FC", Offset = "0x43210FC", VA = "0x43250FC")]
		public static List<string> GetTermsList([Optional] string Category)
		{
			return null;
		}

		[Token(Token = "0x6005416")]
		[Address(RVA = "0x432534C", Offset = "0x432134C", VA = "0x432534C")]
		public static TermData GetTermData(string term)
		{
			return null;
		}

		[Token(Token = "0x6005417")]
		[Address(RVA = "0x4322668", Offset = "0x431E668", VA = "0x4322668")]
		public static TermData GetTermData(string term, out LanguageSourceData source)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED LocalizationManager.GetTermData RVA=0x4322668 Token=0x6005417");
}
	}
}
