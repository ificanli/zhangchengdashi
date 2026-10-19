using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Drawing.Text
{
	[Token(Token = "0x200005C")]
	internal struct SDFFont
	{
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x0")]
		public string name;

		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x8")]
		public int size;

		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0xC")]
		public int width;

		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x10")]
		public int height;

		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x14")]
		public bool bold;

		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x15")]
		public bool italic;

		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x18")]
		public SDFCharacter[] characters;

		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x20")]
		public Material material;
	}
}
