using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace L_Tools
{
	[Token(Token = "0x2000FB0")]
	public class PlayerPrefs2RunTime
	{
		[Token(Token = "0x4006B89")]
		public const string BoolPrefix = "B_";

		[Token(Token = "0x4006B8A")]
		public const string FloatPrefix = "F_";

		[Token(Token = "0x4006B8B")]
		[FieldOffset(Offset = "0x10")]
		private PlayerPrefs2Save _playerPrefs2Save;

		[Token(Token = "0x4006B8C")]
		[FieldOffset(Offset = "0x18")]
		private DataRegister_SS _stringStringKV;

		[Token(Token = "0x4006B8D")]
		[FieldOffset(Offset = "0x20")]
		private DataRegister_SI _stringIntKV;

		[Token(Token = "0x4006B8E")]
		[FieldOffset(Offset = "0x0")]
		public static bool IsBindingAccount;

		[Token(Token = "0x4006B8F")]
		[FieldOffset(Offset = "0x28")]
		private List<string> _ignoreSaveKey;

		[Token(Token = "0x4006B90")]
		[FieldOffset(Offset = "0x30")]
		private Action TrySaveAction;

		[Token(Token = "0x17000F9F")]
		private static bool AdapterPlayerPrefs
		{
			[Token(Token = "0x6005DF3")]
			[Address(RVA = "0x43F77D8", Offset = "0x43F37D8", VA = "0x43F77D8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000FA0")]
		public int DVersion
		{
			[Token(Token = "0x6005DF7")]
			[Address(RVA = "0x43F79E8", Offset = "0x43F39E8", VA = "0x43F79E8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005DF8")]
			[Address(RVA = "0x43F7AF0", Offset = "0x43F3AF0", VA = "0x43F7AF0")]
			set
			{
			}
		}

		[Token(Token = "0x17000FA1")]
		private bool LogOpened
		{
			[Token(Token = "0x6005DFF")]
			[Address(RVA = "0x43F8484", Offset = "0x43F4484", VA = "0x43F8484")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005DF2")]
		[Address(RVA = "0x43F7750", Offset = "0x43F3750", VA = "0x43F7750")]
		public PlayerPrefs2RunTime(Action trySaveAction)
		{
		}

		[Token(Token = "0x6005DF4")]
		[Address(RVA = "0x43F7830", Offset = "0x43F3830", VA = "0x43F7830")]
		public void AddIgnoreSaveKey(string str)
		{
		}

		[Token(Token = "0x6005DF5")]
		[Address(RVA = "0x43F7900", Offset = "0x43F3900", VA = "0x43F7900")]
		private bool IsNotIgnoreSaveKey(string str)
		{
			return default;
		}

		[Token(Token = "0x6005DF6")]
		[Address(RVA = "0x43F797C", Offset = "0x43F397C", VA = "0x43F797C")]
		public void ReBindXXX()
		{
		}

		[Token(Token = "0x6005DF9")]
		[Address(RVA = "0x43F7BE8", Offset = "0x43F3BE8", VA = "0x43F7BE8")]
		public string GetXXX()
		{
			return null;
		}

		[Token(Token = "0x6005DFA")]
		[Address(RVA = "0x43F7C3C", Offset = "0x43F3C3C", VA = "0x43F7C3C")]
		public void Init(string saveData)
		{
		}

		[Token(Token = "0x6005DFB")]
		[Address(RVA = "0x43F8070", Offset = "0x43F4070", VA = "0x43F8070")]
		public string ToSave()
		{
			return null;
		}

		[Token(Token = "0x6005DFC")]
		[Address(RVA = "0x43F8278", Offset = "0x43F4278", VA = "0x43F8278")]
		public bool HasKey(string key)
		{
			return default;
		}

		[Token(Token = "0x6005DFD")]
		[Address(RVA = "0x43F83C4", Offset = "0x43F43C4", VA = "0x43F83C4")]
		public void DeleteKey(string key)
		{
		}

		[Token(Token = "0x6005DFE")]
		[Address(RVA = "0x43F8434", Offset = "0x43F4434", VA = "0x43F8434")]
		public void DeleteAll()
		{
		}

		[Token(Token = "0x6005E00")]
		[Address(RVA = "0x43F848C", Offset = "0x43F448C", VA = "0x43F848C")]
		public void SetString(string key, string value)
		{
		}

		[Token(Token = "0x6005E01")]
		[Address(RVA = "0x43F8554", Offset = "0x43F4554", VA = "0x43F8554")]
		public string GetString(string key, string defaultValue = "")
		{
			return null;
		}

		[Token(Token = "0x6005E02")]
		[Address(RVA = "0x43F7B48", Offset = "0x43F3B48", VA = "0x43F7B48")]
		public void SetInt(string key, int value)
		{
		}

		[Token(Token = "0x6005E03")]
		[Address(RVA = "0x43F7A34", Offset = "0x43F3A34", VA = "0x43F7A34")]
		public int GetInt(string key, int defaultValue = 0)
		{
			return default;
		}

		[Token(Token = "0x6005E04")]
		[Address(RVA = "0x43F8610", Offset = "0x43F4610", VA = "0x43F8610")]
		public void SetFloat(string key, float value)
		{
		}

		[Token(Token = "0x6005E05")]
		[Address(RVA = "0x43F8714", Offset = "0x43F4714", VA = "0x43F8714")]
		public float GetFloat(string key, float defaultValue = 0f)
		{
			return default;
		}

		[Token(Token = "0x6005E06")]
		[Address(RVA = "0x43F8850", Offset = "0x43F4850", VA = "0x43F8850")]
		public void SetBool(string key, bool value)
		{
		}

		[Token(Token = "0x6005E07")]
		[Address(RVA = "0x43F8908", Offset = "0x43F4908", VA = "0x43F8908")]
		public bool GetBool(string key, bool defaultValue = false)
		{
			return default;
		}
	}
}
