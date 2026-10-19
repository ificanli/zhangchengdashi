using System.Collections.Generic;
using Il2CppDummyDll;

namespace DBTSDK.Iap
{
	[Token(Token = "0x20002BF")]
	public class ProductJson
	{
		[Token(Token = "0x4001709")]
		[FieldOffset(Offset = "0x10")]
		public string productKey;

		[Token(Token = "0x400170A")]
		[FieldOffset(Offset = "0x18")]
		public List<ProductData> datas;

		[Token(Token = "0x6005057")]
		[Address(RVA = "0x710C914", Offset = "0x7108914", VA = "0x710C914")]
		public ProductJson()
		{
		}
	}
}
