using Il2CppDummyDll;
using UnityEngine;

namespace FishFlock
{
	[Token(Token = "0x2000DD5")]
	public struct CollisionArea
	{
		[Token(Token = "0x40060F4")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 position;

		[Token(Token = "0x40060F5")]
		[FieldOffset(Offset = "0xC")]
		public Vector3 size;

		[Token(Token = "0x40060F6")]
		[FieldOffset(Offset = "0x18")]
		public int type;
	}
}
