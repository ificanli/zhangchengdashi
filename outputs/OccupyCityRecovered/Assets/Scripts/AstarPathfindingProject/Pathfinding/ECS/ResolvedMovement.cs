using Il2CppDummyDll;
using Unity.Entities;
using Unity.Mathematics;

namespace Pathfinding.ECS
{
	[Token(Token = "0x2000304")]
	public struct ResolvedMovement : IComponentData, IQueryTypeParameter
	{
		[Token(Token = "0x4000DD4")]
		[FieldOffset(Offset = "0x0")]
		public float3 targetPoint;

		[Token(Token = "0x4000DD5")]
		[FieldOffset(Offset = "0xC")]
		public float speed;

		[Token(Token = "0x4000DD6")]
		[FieldOffset(Offset = "0x10")]
		public float turningRadiusMultiplier;

		[Token(Token = "0x4000DD7")]
		[FieldOffset(Offset = "0x14")]
		public float targetRotation;

		[Token(Token = "0x4000DD8")]
		[FieldOffset(Offset = "0x18")]
		public float targetRotationHint;

		[Token(Token = "0x4000DD9")]
		[FieldOffset(Offset = "0x1C")]
		public float targetRotationOffset;

		[Token(Token = "0x4000DDA")]
		[FieldOffset(Offset = "0x20")]
		public float rotationSpeed;
	}
}
