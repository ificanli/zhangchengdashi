using Il2CppDummyDll;

namespace GameFramework
{
	[Token(Token = "0x20003D2")]
	public class UserVariable
	{
		[Token(Token = "0x4001C92")]
		[FieldOffset(Offset = "0x10")]
		public string Key;

		[Token(Token = "0x4001C93")]
		[FieldOffset(Offset = "0x18")]
		public string StrVar;

		[Token(Token = "0x4001C94")]
		[FieldOffset(Offset = "0x20")]
		public int IntVar;

		[Token(Token = "0x4001C95")]
		[FieldOffset(Offset = "0x24")]
		public float FloatVar;

		[Token(Token = "0x6005FC5")]
		[Address(RVA = "0x71DC784", Offset = "0x71D8784", VA = "0x71DC784")]
		public static UserVariable BuildVariable(string key, string strVar)
		{
			return null;
		}

		[Token(Token = "0x6005FC6")]
		[Address(RVA = "0x71DC7FC", Offset = "0x71D87FC", VA = "0x71DC7FC")]
		public static UserVariable BuildVariable(string key, int intVar)
		{
			return null;
		}

		[Token(Token = "0x6005FC7")]
		[Address(RVA = "0x71DC870", Offset = "0x71D8870", VA = "0x71DC870")]
		public static UserVariable BuildVariable(string key, float floatVar)
		{
			return null;
		}

		[Token(Token = "0x6005FC8")]
		[Address(RVA = "0x71DC8E4", Offset = "0x71D88E4", VA = "0x71DC8E4")]
		public static UserVariable BuildVariable(string key, string strVar = "", int intVar = 0, float floatVar = 0f)
		{
			return null;
		}

		[Token(Token = "0x6005FC9")]
		[Address(RVA = "0x71DC7F4", Offset = "0x71D87F4", VA = "0x71DC7F4")]
		public UserVariable()
		{
		}
	}
}
