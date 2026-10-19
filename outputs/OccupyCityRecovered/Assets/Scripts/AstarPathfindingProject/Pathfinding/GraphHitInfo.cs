using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x2000028")]
	public struct GraphHitInfo
	{
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 origin;

		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0xC")]
		public Vector3 point;

		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x18")]
		public GraphNode node;

		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 tangentOrigin;

		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 tangent;

		[Token(Token = "0x170000B5")]
		public readonly float distance
		{
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x445D318", Offset = "0x4459318", VA = "0x445D318")]
			get
			{
				return default;
			}
		}
	}
}
