using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x200002A")]
	public readonly struct NNInfo
	{
		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x0")]
		public readonly GraphNode node;

		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x8")]
		public readonly Vector3 position;

		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x14")]
		public readonly float distanceCostSqr;

		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x0")]
		public static readonly NNInfo Empty;

		[Token(Token = "0x170000B7")]
		[Obsolete("This field has been renamed to 'position'", true)]
		public Vector3 clampedPosition
		{
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x445D54C", Offset = "0x445954C", VA = "0x445D54C")]
			get
			{
				return default;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x445D558", Offset = "0x4459558", VA = "0x445D558")]
		public NNInfo(GraphNode node, Vector3 position, float distanceCostSqr)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NNInfo..ctor RVA=0x445D558 Token=0x6000253");
}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x445D5C0", Offset = "0x44595C0", VA = "0x445D5C0")]
		public static explicit operator Vector3(NNInfo ob)
		{
			return default;
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x445D5CC", Offset = "0x44595CC", VA = "0x445D5CC")]
		public static explicit operator GraphNode(NNInfo ob)
		{
			return null;
		}
	}
}
