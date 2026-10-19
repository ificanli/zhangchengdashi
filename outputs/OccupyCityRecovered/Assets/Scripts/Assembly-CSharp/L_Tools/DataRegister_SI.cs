using System.Collections.Generic;
using Il2CppDummyDll;

namespace L_Tools
{
	[Token(Token = "0x2000FA8")]
	public class DataRegister_SI
	{
		[Token(Token = "0x4006B71")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, int> Register;

		[Token(Token = "0x4006B72")]
		[FieldOffset(Offset = "0x18")]
		private bool isInit;

		[Token(Token = "0x4006B73")]
		[FieldOffset(Offset = "0x19")]
		private bool TransLevelData;

		[Token(Token = "0x6005DAF")]
		[Address(RVA = "0x43BAFC4", Offset = "0x43B6FC4", VA = "0x43BAFC4")]
		public void InitDictionary(string[] values)
		{
		}

		[Token(Token = "0x6005DB0")]
		[Address(RVA = "0x43BB210", Offset = "0x43B7210", VA = "0x43BB210")]
		public void InitDictionary(List<stringIntKV> stringIntKVs)
		{
		}

		[Token(Token = "0x6005DB1")]
		[Address(RVA = "0x43BB3D4", Offset = "0x43B73D4", VA = "0x43BB3D4")]
		public DataRegister_SI()
		{
		}

		[Token(Token = "0x6005DB2")]
		[Address(RVA = "0x43BB45C", Offset = "0x43B745C", VA = "0x43BB45C")]
		public DataRegister_SI(List<stringIntKV> stringIntKVs, bool TransLevelData = false)
		{
		}

		[Token(Token = "0x6005DB3")]
		[Address(RVA = "0x43BB504", Offset = "0x43B7504", VA = "0x43BB504")]
		public void ClearAll()
		{
		}

		[Token(Token = "0x6005DB4")]
		[Address(RVA = "0x43BB5B0", Offset = "0x43B75B0", VA = "0x43BB5B0")]
		public void AddData(string name, int value)
		{
		}

		[Token(Token = "0x6005DB5")]
		[Address(RVA = "0x43BB0BC", Offset = "0x43B70BC", VA = "0x43BB0BC")]
		public void SetData(string name, int value)
		{
		}

		[Token(Token = "0x6005DB6")]
		[Address(RVA = "0x43BB6A0", Offset = "0x43B76A0", VA = "0x43BB6A0")]
		public void RemoveData(string key)
		{
		}

		[Token(Token = "0x6005DB7")]
		[Address(RVA = "0x43BB730", Offset = "0x43B7730", VA = "0x43BB730")]
		public int GetValue(string name, int defaultvalue = 0)
		{
			return default;
		}

		[Token(Token = "0x6005DB8")]
		[Address(RVA = "0x43BB7D4", Offset = "0x43B77D4", VA = "0x43BB7D4")]
		public int GetValueThenRemove(string name)
		{
			return default;
		}

		[Token(Token = "0x6005DB9")]
		[Address(RVA = "0x43BB898", Offset = "0x43B7898", VA = "0x43BB898")]
		public bool ContainsKey(string name)
		{
			return default;
		}

		[Token(Token = "0x6005DBA")]
		[Address(RVA = "0x43BB8F0", Offset = "0x43B78F0", VA = "0x43BB8F0")]
		public List<stringIntKV> ToArray()
		{
			return null;
		}

		[Token(Token = "0x6005DBB")]
		[Address(RVA = "0x43BBB68", Offset = "0x43B7B68", VA = "0x43BBB68")]
		public void LogAll()
		{
		}
	}
}
