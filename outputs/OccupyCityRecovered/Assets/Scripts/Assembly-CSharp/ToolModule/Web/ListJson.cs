using System;
using Il2CppDummyDll;

namespace ToolModule.Web
{
	[Serializable]
	[Token(Token = "0x20001C1")]
	public class ListJson<T>
	{
		[Token(Token = "0x4001B39")]
		[FieldOffset(Offset = "0x0")]
		public T[] list;

		[Token(Token = "0x4001B3A")]
		[FieldOffset(Offset = "0x0")]
		public string error;

		[Token(Token = "0x6000737")]
		public ListJson()
		{
		}
	}
}
