using Il2CppDummyDll;
using UnityEngine;

namespace FishFlock
{
	[Token(Token = "0x2000DD7")]
	public struct FishData
	{
		[Token(Token = "0x40060FB")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 position;

		[Token(Token = "0x40060FC")]
		[FieldOffset(Offset = "0xC")]
		public Vector3 velocity;

		[Token(Token = "0x40060FD")]
		[FieldOffset(Offset = "0x18")]
		public float speed;

		[Token(Token = "0x40060FE")]
		[FieldOffset(Offset = "0x1C")]
		public float rot_speed;

		[Token(Token = "0x40060FF")]
		[FieldOffset(Offset = "0x20")]
		public float speed_offset;

		[Token(Token = "0x4006100")]
		[FieldOffset(Offset = "0x24")]
		public float scale;
	}
}
