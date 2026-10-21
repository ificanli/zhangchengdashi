using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.PID;
using Unity.Entities;
using UnityEngine;

namespace Pathfinding.ECS
{
	[Serializable]
	[Token(Token = "0x20002FF")]
	public struct MovementSettings : IComponentData, IQueryTypeParameter
	{
		[Token(Token = "0x4000DB5")]
		[FieldOffset(Offset = "0x0")]
		public PIDMovement follower;

		[Token(Token = "0x4000DB6")]
		[FieldOffset(Offset = "0x24")]
		public PIDMovement.DebugFlags debugFlags;

		[Token(Token = "0x4000DB7")]
		[FieldOffset(Offset = "0x28")]
		public float stopDistance;

		[Token(Token = "0x4000DB8")]
		[FieldOffset(Offset = "0x2C")]
		public float rotationSmoothing;

		[Token(Token = "0x4000DB9")]
		[FieldOffset(Offset = "0x30")]
		public float positionSmoothing;

		[Token(Token = "0x4000DBA")]
		[FieldOffset(Offset = "0x34")]
		public LayerMask groundMask;

		[field: Token(Token = "0x4000DBB")]
		[field: FieldOffset(Offset = "0x38")]
		[Token(Token = "0x1700030E")]
		[Obsolete("Use the AgentMovementPlaneSource component instead, or the movementPlaneSource property on the FollowerEntity component", true)]
		public MovementPlaneSource movementPlaneSource
		{
			[Token(Token = "0x60012DC")]
			[Address(RVA = "0x44B59A4", Offset = "0x44B19A4", VA = "0x44B59A4")]
			readonly get
			;
			[Token(Token = "0x60012DD")]
			[Address(RVA = "0x44B59AC", Offset = "0x44B19AC", VA = "0x44B59AC")]
			set
			;
		}

		[Token(Token = "0x4000DBC")]
		[FieldOffset(Offset = "0x39")]
		public bool isStopped;


	}
}
