using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2000D79")]
	[ExecuteInEditMode]
	[AddComponentMenu("I2/Localization/Source")]
	public class LanguageSource : MonoBehaviour, ISerializationCallbackReceiver, ILanguageSource
	{
		[Token(Token = "0x2000D7A")]
		public delegate void fnOnSourceUpdated(LanguageSourceData source, bool ReceivedNewData, string errorMsg);

		[Token(Token = "0x4005F7F")]
		[FieldOffset(Offset = "0x20")]
		public LanguageSourceData mSource;

		[Token(Token = "0x4005F80")]
		[FieldOffset(Offset = "0x28")]
		public int version;

		[Token(Token = "0x4005F81")]
		[FieldOffset(Offset = "0x2C")]
		public bool NeverDestroy;

		[Token(Token = "0x4005F82")]
		[FieldOffset(Offset = "0x2D")]
		public bool UserAgreesToHaveItOnTheScene;

		[Token(Token = "0x4005F83")]
		[FieldOffset(Offset = "0x2E")]
		public bool UserAgreesToHaveItInsideThePluginsFolder;

		[Token(Token = "0x4005F84")]
		[FieldOffset(Offset = "0x2F")]
		public bool GoogleLiveSyncIsUptoDate;

		[Token(Token = "0x4005F85")]
		[FieldOffset(Offset = "0x30")]
		public List<Object> Assets;

		[Token(Token = "0x4005F86")]
		[FieldOffset(Offset = "0x38")]
		public string Google_WebServiceURL;

		[Token(Token = "0x4005F87")]
		[FieldOffset(Offset = "0x40")]
		public string Google_SpreadsheetKey;

		[Token(Token = "0x4005F88")]
		[FieldOffset(Offset = "0x48")]
		public string Google_SpreadsheetName;

		[Token(Token = "0x4005F89")]
		[FieldOffset(Offset = "0x50")]
		public string Google_LastUpdatedVersion;

		[Token(Token = "0x4005F8A")]
		[FieldOffset(Offset = "0x58")]
		public LanguageSourceData.eGoogleUpdateFrequency GoogleUpdateFrequency;

		[Token(Token = "0x4005F8B")]
		[FieldOffset(Offset = "0x5C")]
		public float GoogleUpdateDelay;

		[Token(Token = "0x4005F8C")]
		[FieldOffset(Offset = "0x60")]
		[CompilerGenerated]
		private fnOnSourceUpdated m_Event_OnSourceUpdateFromGoogle;

		[Token(Token = "0x4005F8D")]
		[FieldOffset(Offset = "0x68")]
		public List<LanguageData> mLanguages;

		[Token(Token = "0x4005F8E")]
		[FieldOffset(Offset = "0x70")]
		public bool IgnoreDeviceLanguage;

		[Token(Token = "0x4005F8F")]
		[FieldOffset(Offset = "0x74")]
		public LanguageSourceData.eAllowUnloadLanguages _AllowUnloadingLanguages;

		[Token(Token = "0x4005F90")]
		[FieldOffset(Offset = "0x78")]
		public List<TermData> mTerms;

		[Token(Token = "0x4005F91")]
		[FieldOffset(Offset = "0x80")]
		public bool CaseInsensitiveTerms;

		[Token(Token = "0x4005F92")]
		[FieldOffset(Offset = "0x84")]
		public LanguageSourceData.MissingTranslationAction OnMissingTranslation;

		[Token(Token = "0x4005F93")]
		[FieldOffset(Offset = "0x88")]
		public string mTerm_AppName;

		[Token(Token = "0x17000E67")]
		public LanguageSourceData SourceData
		{
			[Token(Token = "0x6005330")]
			[Address(RVA = "0x43125B0", Offset = "0x430E5B0", VA = "0x43125B0", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005331")]
			[Address(RVA = "0x43125B8", Offset = "0x430E5B8", VA = "0x43125B8", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x14000012")]
		public event fnOnSourceUpdated Event_OnSourceUpdateFromGoogle
		{
			[Token(Token = "0x6005332")]
			[Address(RVA = "0x43125C0", Offset = "0x430E5C0", VA = "0x43125C0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005333")]
			[Address(RVA = "0x431265C", Offset = "0x430E65C", VA = "0x431265C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6005334")]
		[Address(RVA = "0x43126F8", Offset = "0x430E6F8", VA = "0x43126F8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005335")]
		[Address(RVA = "0x4312790", Offset = "0x430E790", VA = "0x4312790")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6005336")]
		[Address(RVA = "0x4312808", Offset = "0x430E808", VA = "0x4312808")]
		public string GetSourceName()
		{
			return null;
		}

		[Token(Token = "0x6005337")]
		[Address(RVA = "0x43128F8", Offset = "0x430E8F8", VA = "0x43128F8", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6005338")]
		[Address(RVA = "0x4312904", Offset = "0x430E904", VA = "0x4312904", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6005339")]
		[Address(RVA = "0x4312F98", Offset = "0x430EF98", VA = "0x4312F98")]
		public LanguageSource()
		{
		}
	}
}
