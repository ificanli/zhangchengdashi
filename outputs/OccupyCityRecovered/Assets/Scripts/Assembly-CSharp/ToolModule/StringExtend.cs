using Il2CppDummyDll;
using UnityEngine;

namespace ToolModule
{
	[Token(Token = "0x2000196")]
	public static class StringExtend
	{
		[Token(Token = "0x600067F")]
		[Address(RVA = "0x3F7DD80", Offset = "0x3F79D80", VA = "0x3F7DD80")]
		public static string AddColor(this string text, Color color)
		{
			return null;
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x3F7DC5C", Offset = "0x3F79C5C", VA = "0x3F7DC5C")]
		public static string AddColor(this string text, string hexColor)
		{
			return null;
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x3F7DDA0", Offset = "0x3F79DA0", VA = "0x3F7DDA0")]
		public static string AddConditionalColor(this string text, bool condition, Color trueColor, Color falseColor)
		{
			return null;
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x3F7DDD4", Offset = "0x3F79DD4", VA = "0x3F7DDD4")]
		public static string AddSign(this string number)
		{
			return null;
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x3F7DE40", Offset = "0x3F79E40", VA = "0x3F7DE40")]
		public static string AddSlashes(this string number1, string number2)
		{
			return null;
		}
	}
}
