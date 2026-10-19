using System.Collections.Generic;
using Il2CppDummyDll;

namespace L_Tools
{
	[Token(Token = "0x2000FA6")]
	public class DataRegister_II
	{
		[Token(Token = "0x4006B6D")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<int, int> Register;

		[Token(Token = "0x4006B6E")]
		[FieldOffset(Offset = "0x18")]
		private bool isInit;

		[Token(Token = "0x6005DA1")]
		[Address(RVA = "0x43BA394", Offset = "0x43B6394", VA = "0x43BA394")]
		public void InitDictionary(string[] values)
		{
		}

		[Token(Token = "0x6005DA2")]
		[Address(RVA = "0x43BA5F8", Offset = "0x43B65F8", VA = "0x43BA5F8")]
		public void InitDictionary(List<IntIntKV> stringIntKVs)
		{
		}

		[Token(Token = "0x6005DA3")]
		[Address(RVA = "0x43BA6F4", Offset = "0x43B66F4", VA = "0x43BA6F4")]
		public DataRegister_II()
		{
		}

		[Token(Token = "0x6005DA4")]
		[Address(RVA = "0x43BA77C", Offset = "0x43B677C", VA = "0x43BA77C")]
		public DataRegister_II(List<IntIntKV> stringIntKVs)
		{
		}

		[Token(Token = "0x6005DA5")]
		[Address(RVA = "0x43BA810", Offset = "0x43B6810", VA = "0x43BA810")]
		public void ClearAll()
		{
		}

		[Token(Token = "0x6005DA6")]
		[Address(RVA = "0x43BA8BC", Offset = "0x43B68BC", VA = "0x43BA8BC")]
		public void AddData(int key, int value)
		{
		}

		[Token(Token = "0x6005DA7")]
		[Address(RVA = "0x43BA4A4", Offset = "0x43B64A4", VA = "0x43BA4A4")]
		public void SetData(int key, int value)
		{
		}

		[Token(Token = "0x6005DA8")]
		[Address(RVA = "0x43BA9AC", Offset = "0x43B69AC", VA = "0x43BA9AC")]
		public int GetValue(int key, int ret = 0)
		{
			return default;
		}

		[Token(Token = "0x6005DA9")]
		[Address(RVA = "0x43BAA50", Offset = "0x43B6A50", VA = "0x43BAA50")]
		public int GetValueThenRemove(int key)
		{
			return default;
		}

		[Token(Token = "0x6005DAA")]
		[Address(RVA = "0x43BAB14", Offset = "0x43B6B14", VA = "0x43BAB14")]
		public bool ContainsKey(int key)
		{
			return default;
		}

		[Token(Token = "0x6005DAB")]
		[Address(RVA = "0x43BAB6C", Offset = "0x43B6B6C", VA = "0x43BAB6C")]
		public List<IntIntKV> ToArray()
		{
			return null;
		}

		[Token(Token = "0x6005DAC")]
		[Address(RVA = "0x43BADF0", Offset = "0x43B6DF0", VA = "0x43BADF0")]
		public void LogAll()
		{
		}
	}
}
