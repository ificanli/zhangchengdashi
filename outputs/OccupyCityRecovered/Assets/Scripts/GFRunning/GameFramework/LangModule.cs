using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GameFramework
{
	[Token(Token = "0x2000379")]
	public class LangModule : GameFrameModule
	{
		[Token(Token = "0x4001AE4")]
		[FieldOffset(Offset = "0x20")]
		private ELangType defaultType;

		[Token(Token = "0x4001AE5")]
		[FieldOffset(Offset = "0x0")]
		public static ELangType LangTypeStatic;

		[Token(Token = "0x4001AE6")]
		[FieldOffset(Offset = "0x4")]
		private static ELangType appDefaultLangType;

		[Token(Token = "0x4001AE7")]
		[FieldOffset(Offset = "0x8")]
		private static LocalELangLibrary appLocalELangLibrary;

		[Token(Token = "0x4001AE8")]
		[FieldOffset(Offset = "0xC")]
		public static bool IsChinaPhone;

		[Token(Token = "0x4001AE9")]
		[FieldOffset(Offset = "0x28")]
		private LangData config;

		[Token(Token = "0x4001AEA")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, LangData> dicLang;

		[Token(Token = "0x4001AEB")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, ImageData> dicImage;

		[Token(Token = "0x4001AEC")]
		[FieldOffset(Offset = "0x40")]
		private bool AlreadySetLangData;

		[Token(Token = "0x4001AED")]
		[FieldOffset(Offset = "0x48")]
		private List<LangData> _pendingOnlineList;

		[Token(Token = "0x4001AEE")]
		[FieldOffset(Offset = "0x50")]
		private bool AlreadySetImageData;

		[Token(Token = "0x4001AEF")]
		[FieldOffset(Offset = "0x58")]
		private string[] NullImageDataResult;

		[Token(Token = "0x17001120")]
		internal override int Priority
		{
			[Token(Token = "0x6005A1F")]
			[Address(RVA = "0x71A36A8", Offset = "0x719F6A8", VA = "0x71A36A8", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17001121")]
		public ELangType LangType
		{
			[Token(Token = "0x6005A29")]
			[Address(RVA = "0x71A4D50", Offset = "0x71A0D50", VA = "0x71A4D50")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005A2A")]
			[Address(RVA = "0x71A4D58", Offset = "0x71A0D58", VA = "0x71A4D58")]
			set
			{
			}
		}

		[Token(Token = "0x6005A20")]
		[Address(RVA = "0x71A36B0", Offset = "0x719F6B0", VA = "0x71A36B0", Slot = "5")]
		internal override void Initialize(params object[] arg)
		{
		}

		[Token(Token = "0x6005A21")]
		[Address(RVA = "0x71A379C", Offset = "0x719F79C", VA = "0x71A379C")]
		public static ELangType GetAPPLangType(LocalELangLibrary LangLibrary, ELangType AppDefaultLangType = ELangType.ZH_CN)
		{
			return default;
		}

		[Token(Token = "0x6005A22")]
		[Address(RVA = "0x71A40B0", Offset = "0x71A00B0", VA = "0x71A40B0")]
		public void SetLocalLangLibrary(LocalELangLibrary LangLibrary, ELangType AppDefaultLangType = ELangType.ZH_CN)
		{
		}

		[Token(Token = "0x6005A23")]
		[Address(RVA = "0x71A4320", Offset = "0x71A0320", VA = "0x71A4320")]
		[Obsolete("已过时，请更新MienGameMain脚本到3.1.0版本")]
		public void SetLangData(Dictionary<string, LangData> datas)
		{
		}

		[Token(Token = "0x6005A24")]
		[Address(RVA = "0x71A4334", Offset = "0x71A0334", VA = "0x71A4334")]
		private void ReadLangData()
		{
		}

		[Token(Token = "0x6005A25")]
		[Address(RVA = "0x71A4898", Offset = "0x71A0898", VA = "0x71A4898")]
		public void UpdateLangData(string onlineLangJsonData, bool isFullData = false)
		{
		}

		[Token(Token = "0x6005A26")]
		[Address(RVA = "0x71A4754", Offset = "0x71A0754", VA = "0x71A4754")]
		private void ApplyOnlineLangList(List<LangData> list)
		{
		}

		[Token(Token = "0x6005A27")]
		[Address(RVA = "0x71A4934", Offset = "0x71A0934", VA = "0x71A4934")]
		[Obsolete("已过时，请更新MienGameMain脚本到3.1.0版本")]
		public void SetImageData(Dictionary<string, ImageData> datas)
		{
		}

		[Token(Token = "0x6005A28")]
		[Address(RVA = "0x71A4944", Offset = "0x71A0944", VA = "0x71A4944")]
		private void ReadImageData()
		{
		}

		[Token(Token = "0x6005A2B")]
		[Address(RVA = "0x719F870", Offset = "0x719B870", VA = "0x719F870")]
		public string Get(string key)
		{
			return null;
		}

		[Token(Token = "0x6005A2C")]
		[Address(RVA = "0x71A4FF4", Offset = "0x71A0FF4", VA = "0x71A4FF4")]
		public string GetFormat(string key, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6005A2D")]
		[Address(RVA = "0x71A5000", Offset = "0x71A1000", VA = "0x71A5000")]
		public string GetFormat(string key, ELangType type, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6005A2E")]
		[Address(RVA = "0x719F97C", Offset = "0x719B97C", VA = "0x719F97C")]
		public string Get(string key, ELangType type)
		{
			return null;
		}

		[Token(Token = "0x6005A2F")]
		[Address(RVA = "0x71A50C8", Offset = "0x71A10C8", VA = "0x71A50C8")]
		public string[] GetImageData(string key)
		{
			return null;
		}

		[Token(Token = "0x6005A30")]
		[Address(RVA = "0x71A50D0", Offset = "0x71A10D0", VA = "0x71A50D0")]
		public string[] GetImageData(string key, ELangType type)
		{
			return null;
		}

		[Token(Token = "0x6005A31")]
		[Address(RVA = "0x71A4150", Offset = "0x71A0150", VA = "0x71A4150")]
		public static bool CheckIsChinaPhone()
		{
			return default;
		}

		[Token(Token = "0x6005A32")]
		[Address(RVA = "0x71A5328", Offset = "0x71A1328", VA = "0x71A5328", Slot = "6")]
		internal override void Start()
		{
		}

		[Token(Token = "0x6005A33")]
		[Address(RVA = "0x71A532C", Offset = "0x71A132C", VA = "0x71A532C", Slot = "7")]
		internal override void Update(float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x6005A34")]
		[Address(RVA = "0x71A5330", Offset = "0x71A1330", VA = "0x71A5330", Slot = "9")]
		internal override void Shutdown()
		{
		}

		[Token(Token = "0x6005A35")]
		[Address(RVA = "0x71A5388", Offset = "0x71A1388", VA = "0x71A5388")]
		public LangModule()
		{
		}
	}
}
