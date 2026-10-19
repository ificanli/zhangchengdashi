using Beebyte.Obfuscator;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Mathematics;

namespace RVO2
{
	[Token(Token = "0x2000F0C")]
	[Skip]
	[BurstCompile]
	public struct Obstacle
	{
		[Token(Token = "0x400684D")]
		[FieldOffset(Offset = "0x0")]
		internal unsafe Obstacle* next_;

		[Token(Token = "0x400684E")]
		[FieldOffset(Offset = "0x8")]
		internal unsafe Obstacle* previous_;

		[Token(Token = "0x400684F")]
		[FieldOffset(Offset = "0x10")]
		internal float2 direction_;

		[Token(Token = "0x4006850")]
		[FieldOffset(Offset = "0x18")]
		internal float2 point_;

		[Token(Token = "0x4006851")]
		[FieldOffset(Offset = "0x20")]
		internal int id_;

		[Token(Token = "0x4006852")]
		[FieldOffset(Offset = "0x24")]
		internal bool convex_;
	}
}
