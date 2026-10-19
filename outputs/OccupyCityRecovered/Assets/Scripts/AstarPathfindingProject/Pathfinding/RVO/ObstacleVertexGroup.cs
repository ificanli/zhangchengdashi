using Il2CppDummyDll;
using Unity.Mathematics;

namespace Pathfinding.RVO
{
	[Token(Token = "0x20002C1")]
	public struct ObstacleVertexGroup
	{
		[Token(Token = "0x4000C7A")]
		[FieldOffset(Offset = "0x0")]
		public ObstacleType type;

		[Token(Token = "0x4000C7B")]
		[FieldOffset(Offset = "0x4")]
		public int vertexCount;

		[Token(Token = "0x4000C7C")]
		[FieldOffset(Offset = "0x8")]
		public float3 boundsMn;

		[Token(Token = "0x4000C7D")]
		[FieldOffset(Offset = "0x14")]
		public float3 boundsMx;
	}
}
