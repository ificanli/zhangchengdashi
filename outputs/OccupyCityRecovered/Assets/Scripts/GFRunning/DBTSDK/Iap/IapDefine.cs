using Il2CppDummyDll;

namespace DBTSDK.Iap
{
	[Token(Token = "0x20002BE")]
	public class IapDefine
	{
		[Token(Token = "0x4001706")]
		public const string Consumable = "1";

		[Token(Token = "0x4001707")]
		public const string NoConsumable = "0";

		[Token(Token = "0x4001708")]
		public const string subscription = "2";

		[Token(Token = "0x6005056")]
		[Address(RVA = "0x710C90C", Offset = "0x710890C", VA = "0x710C90C")]
		public IapDefine()
		{
		}
	}
}
