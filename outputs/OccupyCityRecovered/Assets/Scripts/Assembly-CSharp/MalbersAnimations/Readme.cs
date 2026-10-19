using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MalbersAnimations
{
	[Token(Token = "0x2000D4F")]
	public class Readme : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x2000D50")]
		public class Section
		{
			[Token(Token = "0x4005F12")]
			[FieldOffset(Offset = "0x10")]
			public string heading;

			[Token(Token = "0x4005F13")]
			[FieldOffset(Offset = "0x18")]
			public string text;

			[Token(Token = "0x4005F14")]
			[FieldOffset(Offset = "0x20")]
			public string linkText;

			[Token(Token = "0x4005F15")]
			[FieldOffset(Offset = "0x28")]
			public string url;

			[Token(Token = "0x6005268")]
			[Address(RVA = "0x4300F90", Offset = "0x42FCF90", VA = "0x4300F90")]
			public Section()
			{
			}
		}

		[Token(Token = "0x4005F0F")]
		[FieldOffset(Offset = "0x18")]
		public Texture2D icon;

		[Token(Token = "0x4005F10")]
		[FieldOffset(Offset = "0x20")]
		public string title;

		[Token(Token = "0x4005F11")]
		[FieldOffset(Offset = "0x28")]
		public Section[] sections;

		[Token(Token = "0x6005267")]
		[Address(RVA = "0x4300F88", Offset = "0x42FCF88", VA = "0x4300F88")]
		public Readme()
		{
		}
	}
}
