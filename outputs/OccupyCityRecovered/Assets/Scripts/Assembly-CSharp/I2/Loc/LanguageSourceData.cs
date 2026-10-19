using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

namespace I2.Loc
{
	[Serializable]
	[Token(Token = "0x2000D7D")]
	[ExecuteInEditMode]
	public class LanguageSourceData
	{
		[Token(Token = "0x2000D7E")]
		public enum MissingTranslationAction
		{
			[Token(Token = "0x4005FB1")]
			Empty = 0,
			[Token(Token = "0x4005FB2")]
			Fallback = 1,
			[Token(Token = "0x4005FB3")]
			ShowWarning = 2,
			[Token(Token = "0x4005FB4")]
			ShowTerm = 3
		}

		[Token(Token = "0x2000D7F")]
		public enum eAllowUnloadLanguages
		{
			[Token(Token = "0x4005FB6")]
			Never = 0,
			[Token(Token = "0x4005FB7")]
			OnlyInDevice = 1,
			[Token(Token = "0x4005FB8")]
			EditorAndDevice = 2
		}

		[Token(Token = "0x2000D80")]
		public enum eGoogleUpdateFrequency
		{
			[Token(Token = "0x4005FBA")]
			Always = 0,
			[Token(Token = "0x4005FBB")]
			Never = 1,
			[Token(Token = "0x4005FBC")]
			Daily = 2,
			[Token(Token = "0x4005FBD")]
			Weekly = 3,
			[Token(Token = "0x4005FBE")]
			Monthly = 4,
			[Token(Token = "0x4005FBF")]
			OnlyOnce = 5,
			[Token(Token = "0x4005FC0")]
			EveryOtherDay = 6
		}

		[Token(Token = "0x2000D81")]
		public enum eGoogleUpdateSynchronization
		{
			[Token(Token = "0x4005FC2")]
			Manual = 0,
			[Token(Token = "0x4005FC3")]
			OnSceneLoaded = 1,
			[Token(Token = "0x4005FC4")]
			AsSoonAsDownloaded = 2
		}

		[Token(Token = "0x2000D83")]
		[CompilerGenerated]
		private sealed class _003CImport_Google_Coroutine_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005FCC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005FCD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005FCE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LanguageSourceData _003C_003E4__this;

			[Token(Token = "0x4005FCF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool forceUpdate;

			[Token(Token = "0x4005FD0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			public bool JustCheck;

			[Token(Token = "0x4005FD1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UnityWebRequest _003Cwww_003E5__2;

			[Token(Token = "0x17000E6B")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600539D")]
				[Address(RVA = "0x431B350", Offset = "0x4317350", VA = "0x431B350", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000E6C")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600539F")]
				[Address(RVA = "0x431B390", Offset = "0x4317390", VA = "0x431B390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600539A")]
			[Address(RVA = "0x431B05C", Offset = "0x431705C", VA = "0x431B05C")]
			[DebuggerHidden]
			public _003CImport_Google_Coroutine_003Ed__65(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600539B")]
			[Address(RVA = "0x431B084", Offset = "0x4317084", VA = "0x431B084", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600539C")]
			[Address(RVA = "0x431B088", Offset = "0x4317088", VA = "0x431B088", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600539D")]
			[Address(RVA = "0x431B350", Offset = "0x4317350", VA = "0x431B350", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600539E")]
			[Address(RVA = "0x431B358", Offset = "0x4317358", VA = "0x431B358", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600539F")]
			[Address(RVA = "0x431B390", Offset = "0x4317390", VA = "0x431B390", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[NonSerialized]
		[Token(Token = "0x4005F95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ILanguageSource owner;

		[Token(Token = "0x4005F96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool UserAgreesToHaveItOnTheScene;

		[Token(Token = "0x4005F97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool UserAgreesToHaveItInsideThePluginsFolder;

		[Token(Token = "0x4005F98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool GoogleLiveSyncIsUptoDate;

		[NonSerialized]
		[Token(Token = "0x4005F99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool mIsGlobalSource;

		[Token(Token = "0x4005F9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<TermData> mTerms;

		[Token(Token = "0x4005F9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool CaseInsensitiveTerms;

		[NonSerialized]
		[Token(Token = "0x4005F9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Dictionary<string, TermData> mDictionary;

		[Token(Token = "0x4005F9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MissingTranslationAction OnMissingTranslation;

		[Token(Token = "0x4005F9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mTerm_AppName;

		[Token(Token = "0x4005F9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<LanguageData> mLanguages;

		[Token(Token = "0x4005FA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool IgnoreDeviceLanguage;

		[Token(Token = "0x4005FA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public eAllowUnloadLanguages _AllowUnloadingLanguages;

		[Token(Token = "0x4005FA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string Google_WebServiceURL;

		[Token(Token = "0x4005FA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string Google_SpreadsheetKey;

		[Token(Token = "0x4005FA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string Google_SpreadsheetName;

		[Token(Token = "0x4005FA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string Google_LastUpdatedVersion;

		[Token(Token = "0x4005FA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public eGoogleUpdateFrequency GoogleUpdateFrequency;

		[Token(Token = "0x4005FA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public eGoogleUpdateFrequency GoogleInEditorCheckFrequency;

		[Token(Token = "0x4005FA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public eGoogleUpdateSynchronization GoogleUpdateSynchronization;

		[Token(Token = "0x4005FA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float GoogleUpdateDelay;

		[Token(Token = "0x4005FAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[CompilerGenerated]
		private LanguageSource.fnOnSourceUpdated m_Event_OnSourceUpdateFromGoogle;

		[Token(Token = "0x4005FAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<UnityEngine.Object> Assets;

		[NonSerialized]
		[Token(Token = "0x4005FAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Dictionary<string, UnityEngine.Object> mAssetDictionary;

		[Token(Token = "0x4005FAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private string mDelayedGoogleData;

		[Token(Token = "0x4005FAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string EmptyCategory;

		[Token(Token = "0x4005FAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static char[] CategorySeparators;

		[Token(Token = "0x17000E6A")]
		public UnityEngine.Object ownerObject
		{
			[Token(Token = "0x6005343")]
			[Address(RVA = "0x4313314", Offset = "0x430F314", VA = "0x4313314")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000013")]
		public event LanguageSource.fnOnSourceUpdated Event_OnSourceUpdateFromGoogle
		{
			[Token(Token = "0x6005344")]
			[Address(RVA = "0x4312EFC", Offset = "0x430EEFC", VA = "0x4312EFC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005345")]
			[Address(RVA = "0x4313390", Offset = "0x430F390", VA = "0x4313390")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6005346")]
		[Address(RVA = "0x4312718", Offset = "0x430E718", VA = "0x4312718")]
		public void Awake()
		{
		}

		[Token(Token = "0x6005347")]
		[Address(RVA = "0x43127B0", Offset = "0x430E7B0", VA = "0x43127B0")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x6005348")]
		[Address(RVA = "0x4313AFC", Offset = "0x430FAFC", VA = "0x4313AFC")]
		public bool IsEqualTo(LanguageSourceData Source)
		{
			return default;
		}

		[Token(Token = "0x6005349")]
		[Address(RVA = "0x4314080", Offset = "0x4310080", VA = "0x4314080")]
		internal bool ManagerHasASimilarSource()
		{
			return default;
		}

		[Token(Token = "0x600534A")]
		[Address(RVA = "0x4314190", Offset = "0x4310190", VA = "0x4314190")]
		public void ClearAllData()
		{
		}

		[Token(Token = "0x600534B")]
		[Address(RVA = "0x4314274", Offset = "0x4310274", VA = "0x4314274")]
		public bool IsGlobalSource()
		{
			return default;
		}

		[Token(Token = "0x600534C")]
		[Address(RVA = "0x431427C", Offset = "0x431027C", VA = "0x431427C")]
		public void Editor_SetDirty()
		{
		}

		[Token(Token = "0x600534D")]
		[Address(RVA = "0x4313720", Offset = "0x430F720", VA = "0x4313720")]
		public void UpdateAssetDictionary()
		{
		}

		[Token(Token = "0x600534E")]
		[Address(RVA = "0x4314280", Offset = "0x4310280", VA = "0x4314280")]
		public UnityEngine.Object FindAsset(string Name)
		{
			return null;
		}

		[Token(Token = "0x600534F")]
		[Address(RVA = "0x4314354", Offset = "0x4310354", VA = "0x4314354")]
		public bool HasAsset(UnityEngine.Object Obj)
		{
			return default;
		}

		[Token(Token = "0x6005350")]
		[Address(RVA = "0x43143AC", Offset = "0x43103AC", VA = "0x43143AC")]
		public void AddAsset(UnityEngine.Object Obj)
		{
		}

		[Token(Token = "0x6005351")]
		[Address(RVA = "0x4314488", Offset = "0x4310488", VA = "0x4314488")]
		private string Export_Language_to_Cache(int langIndex, bool fillTermWithFallback)
		{
			return null;
		}

		[Token(Token = "0x6005352")]
		[Address(RVA = "0x4314978", Offset = "0x4310978", VA = "0x4314978")]
		public string Export_I2CSV(string Category, char Separator = ',', bool specializationsAsRows = true, bool sortRows = true)
		{
			return null;
		}

		[Token(Token = "0x6005353")]
		[Address(RVA = "0x4315090", Offset = "0x4311090", VA = "0x4315090")]
		private static void AppendI2Term(StringBuilder Builder, int nLanguages, string Term, TermData termData, char Separator, string forceSpecialization)
		{
		}

		[Token(Token = "0x6005354")]
		[Address(RVA = "0x43152EC", Offset = "0x43112EC", VA = "0x43152EC")]
		private static void AppendI2Text(StringBuilder Builder, string text)
		{
		}

		[Token(Token = "0x6005355")]
		[Address(RVA = "0x43153C0", Offset = "0x43113C0", VA = "0x43153C0")]
		public string Export_CSV(string Category, char Separator = ',', bool specializationsAsRows = true, bool sortRows = true)
		{
			return null;
		}

		[Token(Token = "0x6005356")]
		[Address(RVA = "0x4315D00", Offset = "0x4311D00", VA = "0x4315D00")]
		private static void AppendTerm(StringBuilder Builder, int nLanguages, string Term, TermData termData, string specialization, char Separator)
		{
		}

		[Token(Token = "0x6005357")]
		[Address(RVA = "0x4315B74", Offset = "0x4311B74", VA = "0x4315B74")]
		private static void AppendString(StringBuilder Builder, string Text, char Separator)
		{
		}

		[Token(Token = "0x6005358")]
		[Address(RVA = "0x4315F60", Offset = "0x4311F60", VA = "0x4315F60")]
		private static void AppendTranslation(StringBuilder Builder, string Text, char Separator, string tags)
		{
		}

		[Token(Token = "0x6005359")]
		[Address(RVA = "0x4316104", Offset = "0x4312104", VA = "0x4316104")]
		public UnityWebRequest Export_Google_CreateWWWcall(eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			return null;
		}

		[Token(Token = "0x600535A")]
		[Address(RVA = "0x43162CC", Offset = "0x43122CC", VA = "0x43162CC")]
		private string Export_Google_CreateData()
		{
			return null;
		}

		[Token(Token = "0x600535B")]
		[Address(RVA = "0x43167C4", Offset = "0x43127C4", VA = "0x43167C4")]
		public string Import_CSV(string Category, string CSVstring, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace, char Separator = ',')
		{
			return null;
		}

		[Token(Token = "0x600535C")]
		[Address(RVA = "0x4317328", Offset = "0x4313328", VA = "0x4317328")]
		public string Import_I2CSV(string Category, string I2CSVstring, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			return null;
		}

		[Token(Token = "0x600535D")]
		[Address(RVA = "0x4316804", Offset = "0x4312804", VA = "0x4316804")]
		public string Import_CSV(string Category, List<string[]> CSV, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			return null;
		}

		[Token(Token = "0x600535E")]
		[Address(RVA = "0x4317364", Offset = "0x4313364", VA = "0x4317364")]
		private bool ArrayContains(string MainText, params string[] texts)
		{
			return default;
		}

		[Token(Token = "0x600535F")]
		[Address(RVA = "0x43176F4", Offset = "0x43136F4", VA = "0x43176F4")]
		public static eTermType GetTermType(string type)
		{
			return default;
		}

		[Token(Token = "0x6005360")]
		[Address(RVA = "0x4317A08", Offset = "0x4313A08", VA = "0x4317A08")]
		private void Import_Language_from_Cache(int langIndex, string langData, bool useFallback, bool onlyCurrentSpecialization)
		{
		}

		[Token(Token = "0x6005361")]
		[Address(RVA = "0x4317C10", Offset = "0x4313C10", VA = "0x4317C10")]
		public static void FreeUnusedLanguages()
		{
		}

		[Token(Token = "0x6005362")]
		[Address(RVA = "0x4317D5C", Offset = "0x4313D5C", VA = "0x4317D5C")]
		public void Import_Google_FromCache()
		{
		}

		[Token(Token = "0x6005363")]
		[Address(RVA = "0x431816C", Offset = "0x431416C", VA = "0x431816C")]
		private bool IsNewerVersion(string currentVersion, string newVersion)
		{
			return default;
		}

		[Token(Token = "0x6005364")]
		[Address(RVA = "0x4318828", Offset = "0x4314828", VA = "0x4318828")]
		public void Import_Google(bool ForceUpdate, bool justCheck)
		{
		}

		[Token(Token = "0x6005365")]
		[Address(RVA = "0x4317FB0", Offset = "0x4313FB0", VA = "0x4317FB0")]
		private string GetSourcePlayerPrefName()
		{
			return null;
		}

		[Token(Token = "0x6005366")]
		[Address(RVA = "0x4318AD8", Offset = "0x4314AD8", VA = "0x4318AD8")]
		[IteratorStateMachine(typeof(_003CImport_Google_Coroutine_003Ed__65))]
		private IEnumerator Import_Google_Coroutine(bool forceUpdate, bool JustCheck)
		{
			return null;
		}

		[Token(Token = "0x6005367")]
		[Address(RVA = "0x4318B60", Offset = "0x4314B60", VA = "0x4318B60")]
		private void ApplyDownloadedDataOnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6005368")]
		[Address(RVA = "0x4318C0C", Offset = "0x4314C0C", VA = "0x4318C0C")]
		public void ApplyDownloadedDataFromGoogle()
		{
		}

		[Token(Token = "0x6005369")]
		[Address(RVA = "0x4318D74", Offset = "0x4314D74", VA = "0x4318D74")]
		public UnityWebRequest Import_Google_CreateWWWcall(bool ForceUpdate, bool justCheck)
		{
			return null;
		}

		[Token(Token = "0x600536A")]
		[Address(RVA = "0x4318EE0", Offset = "0x4314EE0", VA = "0x4318EE0")]
		public bool HasGoogleSpreadsheet()
		{
			return default;
		}

		[Token(Token = "0x600536B")]
		[Address(RVA = "0x43181FC", Offset = "0x43141FC", VA = "0x43181FC")]
		public string Import_Google_Result(string JsonString, eSpreadsheetUpdateMode UpdateMode, bool saveInPlayerPrefs = false)
		{
			return null;
		}

		[Token(Token = "0x600536C")]
		[Address(RVA = "0x4313C6C", Offset = "0x430FC6C", VA = "0x4313C6C")]
		public int GetLanguageIndex(string language, bool AllowDiscartingRegion = true, bool SkipDisabled = true)
		{
			return default;
		}

		[Token(Token = "0x600536D")]
		[Address(RVA = "0x4319140", Offset = "0x4315140", VA = "0x4319140")]
		public LanguageData GetLanguageData(string language, bool AllowDiscartingRegion = true)
		{
			return null;
		}

		[Token(Token = "0x600536E")]
		[Address(RVA = "0x43191D0", Offset = "0x43151D0", VA = "0x43191D0")]
		public bool IsCurrentLanguage(int languageIndex)
		{
			return default;
		}

		[Token(Token = "0x600536F")]
		[Address(RVA = "0x431740C", Offset = "0x431340C", VA = "0x431740C")]
		public int GetLanguageIndexFromCode(string Code, bool exactMatch = true, bool ignoreDisabled = false)
		{
			return default;
		}

		[Token(Token = "0x6005370")]
		[Address(RVA = "0x4318F74", Offset = "0x4314F74", VA = "0x4318F74")]
		public static int GetCommonWordInLanguageNames(string Language1, string Language2)
		{
			return default;
		}

		[Token(Token = "0x6005371")]
		[Address(RVA = "0x4319278", Offset = "0x4315278", VA = "0x4319278")]
		public static bool AreTheSameLanguage(string Language1, string Language2)
		{
			return default;
		}

		[Token(Token = "0x6005372")]
		[Address(RVA = "0x4319304", Offset = "0x4315304", VA = "0x4319304")]
		public static string GetLanguageWithoutRegion(string Language)
		{
			return null;
		}

		[Token(Token = "0x6005373")]
		[Address(RVA = "0x431939C", Offset = "0x431539C", VA = "0x431939C")]
		public void AddLanguage(string LanguageName)
		{
		}

		[Token(Token = "0x6005374")]
		[Address(RVA = "0x4319410", Offset = "0x4315410", VA = "0x4319410")]
		public void AddLanguage(string LanguageName, string LanguageCode)
		{
		}

		[Token(Token = "0x6005375")]
		[Address(RVA = "0x43195E0", Offset = "0x43155E0", VA = "0x43195E0")]
		public void RemoveLanguage(string LanguageName)
		{
		}

		[Token(Token = "0x6005376")]
		[Address(RVA = "0x4319880", Offset = "0x4315880", VA = "0x4319880")]
		public List<string> GetLanguages(bool skipDisabled = true)
		{
			return null;
		}

		[Token(Token = "0x6005377")]
		[Address(RVA = "0x43199F0", Offset = "0x43159F0", VA = "0x43199F0")]
		public List<string> GetLanguagesCode(bool allowRegions = true, bool skipDisabled = true)
		{
			return null;
		}

		[Token(Token = "0x6005378")]
		[Address(RVA = "0x4319BDC", Offset = "0x4315BDC", VA = "0x4319BDC")]
		public bool IsLanguageEnabled(string Language)
		{
			return default;
		}

		[Token(Token = "0x6005379")]
		[Address(RVA = "0x4319C68", Offset = "0x4315C68", VA = "0x4319C68")]
		public void EnableLanguage(string Language, bool bEnabled)
		{
		}

		[Token(Token = "0x600537A")]
		[Address(RVA = "0x4319CFC", Offset = "0x4315CFC", VA = "0x4319CFC")]
		public bool AllowUnloadingLanguages()
		{
			return default;
		}

		[Token(Token = "0x600537B")]
		[Address(RVA = "0x4319D0C", Offset = "0x4315D0C", VA = "0x4319D0C")]
		private string GetSavedLanguageFileName(int languageIndex)
		{
			return null;
		}

		[Token(Token = "0x600537C")]
		[Address(RVA = "0x4319E4C", Offset = "0x4315E4C", VA = "0x4319E4C")]
		public void LoadLanguage(int languageIndex, bool UnloadOtherLanguages, bool useFallback, bool onlyCurrentSpecialization, bool forceLoad)
		{
		}

		[Token(Token = "0x600537D")]
		[Address(RVA = "0x431A20C", Offset = "0x431620C", VA = "0x431A20C")]
		public void LoadAllLanguages(bool forceLoad = false)
		{
		}

		[Token(Token = "0x600537E")]
		[Address(RVA = "0x4319FB8", Offset = "0x4315FB8", VA = "0x4319FB8")]
		public void UnloadLanguage(int languageIndex)
		{
		}

		[Token(Token = "0x600537F")]
		[Address(RVA = "0x4317828", Offset = "0x4313828", VA = "0x4317828")]
		public void SaveLanguages(bool unloadAll, PersistentStorage.eFileType fileLocation = PersistentStorage.eFileType.Temporal)
		{
		}

		[Token(Token = "0x6005380")]
		[Address(RVA = "0x431778C", Offset = "0x431378C", VA = "0x431778C")]
		public bool HasUnloadedLanguages()
		{
			return default;
		}

		[Token(Token = "0x6005381")]
		[Address(RVA = "0x431650C", Offset = "0x431250C", VA = "0x431650C")]
		public List<string> GetCategories([Optional][DefaultParameterValue(false)] bool OnlyMainCategory, [Optional] List<string> Categories)
		{
			return null;
		}

		[Token(Token = "0x6005382")]
		[Address(RVA = "0x431A358", Offset = "0x4316358", VA = "0x431A358")]
		public static string GetKeyFromFullTerm(string FullTerm, bool OnlyMainCategory = false)
		{
			return null;
		}

		[Token(Token = "0x6005383")]
		[Address(RVA = "0x431A290", Offset = "0x4316290", VA = "0x431A290")]
		public static string GetCategoryFromFullTerm(string FullTerm, bool OnlyMainCategory = false)
		{
			return null;
		}

		[Token(Token = "0x6005384")]
		[Address(RVA = "0x431A404", Offset = "0x4316404", VA = "0x431A404")]
		public static void DeserializeFullTerm(string FullTerm, out string Key, out string Category, bool OnlyMainCategory = false)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED LanguageSourceData.DeserializeFullTerm RVA=0x431A404 Token=0x6005384");
}

		[Token(Token = "0x6005385")]
		[Address(RVA = "0x431342C", Offset = "0x430F42C", VA = "0x431342C")]
		public void UpdateDictionary(bool force = false)
		{
		}

		[Token(Token = "0x6005386")]
		[Address(RVA = "0x431A4F8", Offset = "0x43164F8", VA = "0x431A4F8")]
		public string GetTranslation(string term, [Optional] string overrideLanguage, [Optional] string overrideSpecialization, bool skipDisabled = false, bool allowCategoryMistmatch = false)
		{
			return null;
		}

		[Token(Token = "0x6005387")]
		[Address(RVA = "0x431A52C", Offset = "0x431652C", VA = "0x431A52C")]
		public bool TryGetTranslation(string term, out string Translation, [Optional] string overrideLanguage, [Optional] string overrideSpecialization, bool skipDisabled = false, bool allowCategoryMistmatch = false)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED LanguageSourceData.TryGetTranslation RVA=0x431A52C Token=0x6005387");
}

		[Token(Token = "0x6005388")]
		[Address(RVA = "0x4314708", Offset = "0x4310708", VA = "0x4314708")]
		private bool TryGetFallbackTranslation(TermData termData, out string Translation, int langIndex, [Optional] string overrideSpecialization, bool skipDisabled = false)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED LanguageSourceData.TryGetFallbackTranslation RVA=0x4314708 Token=0x6005388");
}

		[Token(Token = "0x6005389")]
		[Address(RVA = "0x431A828", Offset = "0x4316828", VA = "0x431A828")]
		public TermData AddTerm(string term)
		{
			return null;
		}

		[Token(Token = "0x600538A")]
		[Address(RVA = "0x4313E1C", Offset = "0x430FE1C", VA = "0x4313E1C")]
		public TermData GetTermData(string term, bool allowCategoryMistmatch = false)
		{
			return null;
		}

		[Token(Token = "0x600538B")]
		[Address(RVA = "0x431AA4C", Offset = "0x4316A4C", VA = "0x431AA4C")]
		public bool ContainsTerm(string term)
		{
			return default;
		}

		[Token(Token = "0x600538C")]
		[Address(RVA = "0x431AA68", Offset = "0x4316A68", VA = "0x431AA68")]
		public List<string> GetTermsList([Optional] string Category)
		{
			return null;
		}

		[Token(Token = "0x600538D")]
		[Address(RVA = "0x431A834", Offset = "0x4316834", VA = "0x431A834")]
		public TermData AddTerm(string NewTerm, eTermType termType, bool SaveSource = true)
		{
			return null;
		}

		[Token(Token = "0x600538E")]
		[Address(RVA = "0x431ACB0", Offset = "0x4316CB0", VA = "0x431ACB0")]
		public void RemoveTerm(string term)
		{
		}

		[Token(Token = "0x600538F")]
		[Address(RVA = "0x4317580", Offset = "0x4313580", VA = "0x4317580")]
		public static void ValidateFullTerm(ref string Term)
		{
		}

		[Token(Token = "0x6005390")]
		[Address(RVA = "0x4312CAC", Offset = "0x430ECAC", VA = "0x4312CAC")]
		public LanguageSourceData()
		{
		}
	}
}
