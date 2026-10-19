using Il2CppDummyDll;
using Unity.Entities;
using Unity.Mathematics;

namespace Pathfinding.ECS
{
	[Token(Token = "0x20002FD")]
	public struct MovementControl : IComponentData, IQueryTypeParameter
	{
		[Token(Token = "0x4000DA7")]
		[FieldOffset(Offset = "0x0")]
		public float3 targetPoint;

		[Token(Token = "0x4000DA8")]
		[FieldOffset(Offset = "0xC")]
		public float3 endOfPath;

		[Token(Token = "0x4000DA9")]
		[FieldOffset(Offset = "0x18")]
		public float speed;

		[Token(Token = "0x4000DAA")]
		[FieldOffset(Offset = "0x1C")]
		public float maxSpeed;

		[Token(Token = "0x4000DAB")]
		[FieldOffset(Offset = "0x20")]
		public int hierarchicalNodeIndex;

		[Token(Token = "0x4000DAC")]
		[FieldOffset(Offset = "0x24")]
		public float targetRotation;

		[Token(Token = "0x4000DAD")]
		[FieldOffset(Offset = "0x28")]
		public float targetRotationHint;

		[Token(Token = "0x4000DAE")]
		[FieldOffset(Offset = "0x2C")]
		public float targetRotationOffset;

		[Token(Token = "0x4000DAF")]
		[FieldOffset(Offset = "0x30")]
		public float rotationSpeed;

		[Token(Token = "0x4000DB0")]
		[FieldOffset(Offset = "0x34")]
		public bool overrideLocalAvoidance;
	}
}
