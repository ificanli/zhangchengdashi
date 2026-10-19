using Beebyte.Obfuscator;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Mathematics;

namespace RVO2
{
	[Token(Token = "0x2000F0B")]
	[Skip]
	[BurstCompile]
	public struct Line
	{
		[Token(Token = "0x400684B")]
		[FieldOffset(Offset = "0x0")]
		public float2 direction;

		[Token(Token = "0x400684C")]
		[FieldOffset(Offset = "0x8")]
		public float2 point;
	}
}
