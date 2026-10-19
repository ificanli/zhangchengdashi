using System.IO;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x20000CB")]
	public static class MB_TGAWriter
	{
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x748570C", Offset = "0x748170C", VA = "0x748570C")]
		public static void Write(Color[] pixels, int width, int height, string path)
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x7485770", Offset = "0x7481770", VA = "0x7485770")]
		public static void Write(Color[] pixels, int width, int height, Stream output)
		{
		}
	}
}
