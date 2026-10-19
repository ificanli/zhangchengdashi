using System.Collections.Generic;
using Il2CppDummyDll;

namespace L_Tools
{
	[Token(Token = "0x2000FAA")]
	public class DataRegister_SS
	{
		[Token(Token = "0x4006B76")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, string> Register;

		[Token(Token = "0x4006B77")]
		[FieldOffset(Offset = "0x18")]
		private bool isInit;

		[Token(Token = "0x6005DBF")]
		[Address(RVA = "0x43BBEA4", Offset = "0x43B7EA4", VA = "0x43BBEA4")]
		public void InitDictionary(string[] values)
		{
		}

		[Token(Token = "0x6005DC0")]
		[Address(RVA = "0x43BC0E0", Offset = "0x43B80E0", VA = "0x43BC0E0")]
		public void InitDictionary(List<StringStringKV> stringStringKVs)
		{
		}

		[Token(Token = "0x6005DC1")]
		[Address(RVA = "0x43BC2A4", Offset = "0x43B82A4", VA = "0x43BC2A4")]
		public DataRegister_SS()
		{
		}

		[Token(Token = "0x6005DC2")]
		[Address(RVA = "0x43BC32C", Offset = "0x43B832C", VA = "0x43BC32C")]
		public DataRegister_SS(List<StringStringKV> stringStringKVs)
		{
		}

		[Token(Token = "0x6005DC3")]
		[Address(RVA = "0x43BC3C0", Offset = "0x43B83C0", VA = "0x43BC3C0")]
		public void ClearAll()
		{
		}

		[Token(Token = "0x6005DC4")]
		[Address(RVA = "0x43BC46C", Offset = "0x43B846C", VA = "0x43BC46C")]
		public void AddData(string key, string value)
		{
		}

		[Token(Token = "0x6005DC5")]
		[Address(RVA = "0x43BBF8C", Offset = "0x43B7F8C", VA = "0x43BBF8C")]
		public void SetData(string key, string value)
		{
		}

		[Token(Token = "0x6005DC6")]
		[Address(RVA = "0x43BC568", Offset = "0x43B8568", VA = "0x43BC568")]
		public void RemoveData(string key)
		{
		}

		[Token(Token = "0x6005DC7")]
		[Address(RVA = "0x43BC5F8", Offset = "0x43B85F8", VA = "0x43BC5F8")]
		public string GetValue(string key, string ret = "")
		{
			return null;
		}

		[Token(Token = "0x6005DC8")]
		[Address(RVA = "0x43BC6B8", Offset = "0x43B86B8", VA = "0x43BC6B8")]
		public string GetValueThenRemove(string key)
		{
			return null;
		}

		[Token(Token = "0x6005DC9")]
		[Address(RVA = "0x43BC78C", Offset = "0x43B878C", VA = "0x43BC78C")]
		public bool ContainsKey(string key)
		{
			return default;
		}

		[Token(Token = "0x6005DCA")]
		[Address(RVA = "0x43BC7E4", Offset = "0x43B87E4", VA = "0x43BC7E4")]
		public List<StringStringKV> ToArray()
		{
			return null;
		}

		[Token(Token = "0x6005DCB")]
		[Address(RVA = "0x43BCA74", Offset = "0x43B8A74", VA = "0x43BCA74")]
		public void LogAll()
		{
		}
	}
}
