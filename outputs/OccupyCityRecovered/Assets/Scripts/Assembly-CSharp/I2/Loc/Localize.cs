using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace I2.Loc
{
	[Token(Token = "0x2000D86")]
	[AddComponentMenu("I2/Localization/I2 Localize")]
	public class Localize : MonoBehaviour
	{
		[Token(Token = "0x2000D87")]
		public enum TermModification
		{
			[Token(Token = "0x4005FFD")]
			DontModify = 0,
			[Token(Token = "0x4005FFE")]
			ToUpper = 1,
			[Token(Token = "0x4005FFF")]
			ToLower = 2,
			[Token(Token = "0x4006000")]
			ToUpperFirst = 3,
			[Token(Token = "0x4006001")]
			ToTitle = 4
		}

		[Token(Token = "0x4005FD7")]
		[FieldOffset(Offset = "0x20")]
		public string mTerm;

		[Token(Token = "0x4005FD8")]
		[FieldOffset(Offset = "0x28")]
		public string mTermSecondary;

		[NonSerialized]
		[Token(Token = "0x4005FD9")]
		[FieldOffset(Offset = "0x30")]
		public string FinalTerm;

		[NonSerialized]
		[Token(Token = "0x4005FDA")]
		[FieldOffset(Offset = "0x38")]
		public string FinalSecondaryTerm;

		[Token(Token = "0x4005FDB")]
		[FieldOffset(Offset = "0x40")]
		public TermModification PrimaryTermModifier;

		[Token(Token = "0x4005FDC")]
		[FieldOffset(Offset = "0x44")]
		public TermModification SecondaryTermModifier;

		[Token(Token = "0x4005FDD")]
		[FieldOffset(Offset = "0x48")]
		public string TermPrefix;

		[Token(Token = "0x4005FDE")]
		[FieldOffset(Offset = "0x50")]
		public string TermSuffix;

		[Token(Token = "0x4005FDF")]
		[FieldOffset(Offset = "0x58")]
		public bool LocalizeOnAwake;

		[Token(Token = "0x4005FE0")]
		[FieldOffset(Offset = "0x60")]
		private string LastLocalizedLanguage;

		[Token(Token = "0x4005FE1")]
		[FieldOffset(Offset = "0x68")]
		public bool IgnoreRTL;

		[Token(Token = "0x4005FE2")]
		[FieldOffset(Offset = "0x6C")]
		public int MaxCharactersInRTL;

		[Token(Token = "0x4005FE3")]
		[FieldOffset(Offset = "0x70")]
		public bool IgnoreNumbersInRTL;

		[Token(Token = "0x4005FE4")]
		[FieldOffset(Offset = "0x71")]
		public bool CorrectAlignmentForRTL;

		[Token(Token = "0x4005FE5")]
		[FieldOffset(Offset = "0x72")]
		public bool AddSpacesToJoinedLanguages;

		[Token(Token = "0x4005FE6")]
		[FieldOffset(Offset = "0x73")]
		public bool AllowLocalizedParameters;

		[Token(Token = "0x4005FE7")]
		[FieldOffset(Offset = "0x74")]
		public bool AllowParameters;

		[Token(Token = "0x4005FE8")]
		[FieldOffset(Offset = "0x78")]
		public List<UnityEngine.Object> TranslatedObjects;

		[NonSerialized]
		[Token(Token = "0x4005FE9")]
		[FieldOffset(Offset = "0x80")]
		public Dictionary<string, UnityEngine.Object> mAssetDictionary;

		[Token(Token = "0x4005FEA")]
		[FieldOffset(Offset = "0x88")]
		public UnityEvent LocalizeEvent;

		[Token(Token = "0x4005FEB")]
		[FieldOffset(Offset = "0x0")]
		public static string MainTranslation;

		[Token(Token = "0x4005FEC")]
		[FieldOffset(Offset = "0x8")]
		public static string SecondaryTranslation;

		[Token(Token = "0x4005FED")]
		[FieldOffset(Offset = "0x10")]
		public static string CallBackTerm;

		[Token(Token = "0x4005FEE")]
		[FieldOffset(Offset = "0x18")]
		public static string CallBackSecondaryTerm;

		[Token(Token = "0x4005FEF")]
		[FieldOffset(Offset = "0x20")]
		public static Localize CurrentLocalizeComponent;

		[Token(Token = "0x4005FF0")]
		[FieldOffset(Offset = "0x90")]
		public bool AlwaysForceLocalize;

		[Token(Token = "0x4005FF1")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		public EventCallback LocalizeCallBack;

		[Token(Token = "0x4005FF2")]
		[FieldOffset(Offset = "0xA0")]
		public bool mGUI_ShowReferences;

		[Token(Token = "0x4005FF3")]
		[FieldOffset(Offset = "0xA1")]
		public bool mGUI_ShowTems;

		[Token(Token = "0x4005FF4")]
		[FieldOffset(Offset = "0xA2")]
		public bool mGUI_ShowCallback;

		[Token(Token = "0x4005FF5")]
		[FieldOffset(Offset = "0xA8")]
		public ILocalizeTarget mLocalizeTarget;

		[Token(Token = "0x4005FF6")]
		[FieldOffset(Offset = "0xB0")]
		public string mLocalizeTargetName;

		[Token(Token = "0x4005FF7")]
		private const string KSplit = "-";

		[Token(Token = "0x4005FF8")]
		private const char KSpace = ' ';

		[Token(Token = "0x4005FF9")]
		private const string KLOC = "LOC:";

		[Token(Token = "0x4005FFA")]
		private const char KSecondaryTranslationStart = '[';

		[Token(Token = "0x4005FFB")]
		private const char KSecondaryTranslationEnd = ']';

		[Token(Token = "0x17000E6D")]
		public string Term
		{
			[Token(Token = "0x60053AB")]
			[Address(RVA = "0x431C384", Offset = "0x4318384", VA = "0x431C384")]
			get
			{
				return null;
			}
			[Token(Token = "0x60053AC")]
			[Address(RVA = "0x431C38C", Offset = "0x431838C", VA = "0x431C38C")]
			set
			{
			}
		}

		[Token(Token = "0x17000E6E")]
		public string SecondaryTerm
		{
			[Token(Token = "0x60053AD")]
			[Address(RVA = "0x431C3CC", Offset = "0x43183CC", VA = "0x431C3CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60053AE")]
			[Address(RVA = "0x431C3D4", Offset = "0x43183D4", VA = "0x431C3D4")]
			set
			{
			}
		}

		[Token(Token = "0x60053AF")]
		[Address(RVA = "0x431C428", Offset = "0x4318428", VA = "0x431C428")]
		private void Awake()
		{
		}

		[Token(Token = "0x60053B0")]
		[Address(RVA = "0x431D440", Offset = "0x4319440", VA = "0x431D440")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60053B1")]
		[Address(RVA = "0x431D448", Offset = "0x4319448", VA = "0x431D448")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60053B2")]
		[Address(RVA = "0x431D5CC", Offset = "0x43195CC", VA = "0x431D5CC")]
		public bool HasCallback()
		{
			return default;
		}

		[Token(Token = "0x60053B3")]
		[Address(RVA = "0x431CBDC", Offset = "0x4318BDC", VA = "0x431CBDC")]
		public void OnLocalize(bool Force = false)
		{
		}

		[Token(Token = "0x60053B4")]
		[Address(RVA = "0x431C788", Offset = "0x4318788", VA = "0x431C788")]
		public bool FindTarget()
		{
			return default;
		}

		[Token(Token = "0x60053B5")]
		[Address(RVA = "0x431D4E8", Offset = "0x43194E8", VA = "0x431D4E8")]
		private void ReleaseLocalizeTarget()
		{
		}

		[Token(Token = "0x60053B6")]
		[Address(RVA = "0x431D670", Offset = "0x4319670", VA = "0x431D670")]
		public void GetFinalTerms(out string primaryTerm, out string secondaryTerm)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Localize.GetFinalTerms RVA=0x431D670 Token=0x60053B6");
}

		[Token(Token = "0x60053B7")]
		[Address(RVA = "0x431DDC4", Offset = "0x4319DC4", VA = "0x431DDC4")]
		public string GetMainTargetsText()
		{
			return null;
		}

		[Token(Token = "0x60053B8")]
		[Address(RVA = "0x431DE88", Offset = "0x4319E88", VA = "0x431DE88")]
		public void SetFinalTerms(string Main, string Secondary, out string primaryTerm, out string secondaryTerm, bool RemoveNonASCII)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Localize.SetFinalTerms RVA=0x431DE88 Token=0x60053B8");
}

		[Token(Token = "0x60053B9")]
		[Address(RVA = "0x431C390", Offset = "0x4318390", VA = "0x431C390")]
		public void SetTerm(string primary)
		{
		}

		[Token(Token = "0x60053BA")]
		[Address(RVA = "0x431C3E0", Offset = "0x43183E0", VA = "0x431C3E0")]
		public void SetTerm(string primary, string secondary)
		{
		}

		[Token(Token = "0x60053BB")]
		internal T GetSecondaryTranslatedObj<T>(ref string mainTranslation, ref string secondaryTranslation) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x60053BC")]
		[Address(RVA = "0x431C45C", Offset = "0x431845C", VA = "0x431C45C")]
		public void UpdateAssetDictionary()
		{
		}

		[Token(Token = "0x60053BD")]
		internal T GetObject<T>(string Translation) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x60053BE")]
		private T GetTranslatedObject<T>(string Translation) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x60053BF")]
		[Address(RVA = "0x431DEC0", Offset = "0x4319EC0", VA = "0x431DEC0")]
		private void DeserializeTranslation(string translation, out string value, out string secondary)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Localize.DeserializeTranslation RVA=0x431DEC0 Token=0x60053BF");
}

		[Token(Token = "0x60053C0")]
		public T FindTranslatedObject<T>(string value) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x60053C1")]
		[Address(RVA = "0x431DFAC", Offset = "0x4319FAC", VA = "0x431DFAC")]
		public bool HasTranslatedObject(UnityEngine.Object Obj)
		{
			return default;
		}

		[Token(Token = "0x60053C2")]
		[Address(RVA = "0x431E450", Offset = "0x431A450", VA = "0x431E450")]
		public void AddTranslatedObject(UnityEngine.Object Obj)
		{
		}

		[Token(Token = "0x60053C3")]
		[Address(RVA = "0x431E52C", Offset = "0x431A52C", VA = "0x431E52C")]
		public void SetGlobalLanguage(string Language)
		{
		}

		[Token(Token = "0x60053C4")]
		[Address(RVA = "0x431E650", Offset = "0x431A650", VA = "0x431E650")]
		public Localize()
		{
		}
	}
}
