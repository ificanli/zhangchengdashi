using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x2000051")]
	public static class StringTools
	{
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x0")]
		private static StringBuilder _stringBuilder;

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x46448C8", Offset = "0x46408C8", VA = "0x46448C8")]
		public static string[] GetPaths(string path)
		{
			return null;
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x46449A4", Offset = "0x46409A4", VA = "0x46449A4")]
		public static string GetPath(IList<string> paths)
		{
			return null;
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x4644BD0", Offset = "0x4640BD0", VA = "0x4644BD0")]
		public static string GetTextInLimit(string text)
		{
			return null;
		}
	}
}
