using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Drawing
{
	[Token(Token = "0x2000054")]
	public static class Palette
	{
		[Token(Token = "0x2000055")]
		public static class Pure
		{
			[Token(Token = "0x4000157")]
			[FieldOffset(Offset = "0x0")]
			public static readonly Color Yellow;

			[Token(Token = "0x4000158")]
			[FieldOffset(Offset = "0x10")]
			public static readonly Color Clear;

			[Token(Token = "0x4000159")]
			[FieldOffset(Offset = "0x20")]
			public static readonly Color Grey;

			[Token(Token = "0x400015A")]
			[FieldOffset(Offset = "0x30")]
			public static readonly Color Magenta;

			[Token(Token = "0x400015B")]
			[FieldOffset(Offset = "0x40")]
			public static readonly Color Cyan;

			[Token(Token = "0x400015C")]
			[FieldOffset(Offset = "0x50")]
			public static readonly Color Red;

			[Token(Token = "0x400015D")]
			[FieldOffset(Offset = "0x60")]
			public static readonly Color Black;

			[Token(Token = "0x400015E")]
			[FieldOffset(Offset = "0x70")]
			public static readonly Color White;

			[Token(Token = "0x400015F")]
			[FieldOffset(Offset = "0x80")]
			public static readonly Color Blue;

			[Token(Token = "0x4000160")]
			[FieldOffset(Offset = "0x90")]
			public static readonly Color Green;
		}

		[Token(Token = "0x2000056")]
		public static class Colorbrewer
		{
			[Token(Token = "0x2000057")]
			public static class Set1
			{
				[Token(Token = "0x4000161")]
				[FieldOffset(Offset = "0x0")]
				public static readonly Color Red;

				[Token(Token = "0x4000162")]
				[FieldOffset(Offset = "0x10")]
				public static readonly Color Blue;

				[Token(Token = "0x4000163")]
				[FieldOffset(Offset = "0x20")]
				public static readonly Color Green;

				[Token(Token = "0x4000164")]
				[FieldOffset(Offset = "0x30")]
				public static readonly Color Purple;

				[Token(Token = "0x4000165")]
				[FieldOffset(Offset = "0x40")]
				public static readonly Color Orange;

				[Token(Token = "0x4000166")]
				[FieldOffset(Offset = "0x50")]
				public static readonly Color Yellow;

				[Token(Token = "0x4000167")]
				[FieldOffset(Offset = "0x60")]
				public static readonly Color Brown;

				[Token(Token = "0x4000168")]
				[FieldOffset(Offset = "0x70")]
				public static readonly Color Pink;

				[Token(Token = "0x4000169")]
				[FieldOffset(Offset = "0x80")]
				public static readonly Color Grey;
			}

			[Token(Token = "0x2000058")]
			public static class Blues
			{
				[Token(Token = "0x400016A")]
				[FieldOffset(Offset = "0x0")]
				private static readonly Color[] Colors;

				[Token(Token = "0x60002A3")]
				[Address(RVA = "0x46EFF54", Offset = "0x46EBF54", VA = "0x46EFF54")]
				public static Color GetColor(int classes, int index)
				{
					return default;
				}
			}
		}
	}
}
