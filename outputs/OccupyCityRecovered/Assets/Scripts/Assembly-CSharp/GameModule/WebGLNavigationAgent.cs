using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x20002B5")]
	internal sealed class WebGLNavigationAgent
	{
		[Token(Token = "0x400218F")]
		[FieldOffset(Offset = "0x10")]
		public RoleBehaviour Role;

		[Token(Token = "0x4002190")]
		[FieldOffset(Offset = "0x18")]
		public Transform Transform;

		[Token(Token = "0x4002191")]
		[FieldOffset(Offset = "0x20")]
		public int Index;

		[Token(Token = "0x4002192")]
		[FieldOffset(Offset = "0x24")]
		public bool IsActive;

		[Token(Token = "0x4002193")]
		[FieldOffset(Offset = "0x25")]
		public bool IsMoving;

		[Token(Token = "0x4002194")]
		[FieldOffset(Offset = "0x26")]
		public bool IsSeparationOnly;

		[Token(Token = "0x4002195")]
		[FieldOffset(Offset = "0x27")]
		public bool EnableAvoidance;

		[Token(Token = "0x4002196")]
		[FieldOffset(Offset = "0x28")]
		public bool HasPath;

		[Token(Token = "0x4002197")]
		[FieldOffset(Offset = "0x29")]
		public bool IsEnemy;

		[Token(Token = "0x4002198")]
		[FieldOffset(Offset = "0x2C")]
		public float Radius;

		[Token(Token = "0x4002199")]
		[FieldOffset(Offset = "0x30")]
		public float MaxSpeed;

		[Token(Token = "0x400219A")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 PreferredVelocity;

		[Token(Token = "0x400219B")]
		[FieldOffset(Offset = "0x40")]
		public Vector3 Velocity;

		[Token(Token = "0x400219C")]
		[FieldOffset(Offset = "0x4C")]
		public Vector3 SmoothedVelocity;

		[Token(Token = "0x400219D")]
		[FieldOffset(Offset = "0x58")]
		public Vector3 AvoidanceVelocity;

		[Token(Token = "0x400219E")]
		[FieldOffset(Offset = "0x64")]
		public Vector3 SteeringPoint;

		[Token(Token = "0x400219F")]
		[FieldOffset(Offset = "0x70")]
		public HexBehaviour CurrentHex;

		[Token(Token = "0x40021A0")]
		[FieldOffset(Offset = "0x78")]
		public HexBehaviour NextHex;

		[Token(Token = "0x40021A1")]
		[FieldOffset(Offset = "0x80")]
		public HexBehaviour LastValidHex;

		[Token(Token = "0x40021A2")]
		[FieldOffset(Offset = "0x88")]
		public bool CurrentPositionOnHex;

		[Token(Token = "0x6000C37")]
		[Address(RVA = "0x3D36FB4", Offset = "0x3D32FB4", VA = "0x3D36FB4")]
		public void Reset(int index)
		{
		}

		[Token(Token = "0x6000C38")]
		[Address(RVA = "0x3D37080", Offset = "0x3D33080", VA = "0x3D37080")]
		public WebGLNavigationAgent()
		{
		}
	}
}
