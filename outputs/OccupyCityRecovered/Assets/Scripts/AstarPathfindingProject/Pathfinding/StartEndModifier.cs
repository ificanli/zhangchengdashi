using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Serializable]
	[Token(Token = "0x2000127")]
	public class StartEndModifier : PathModifier
	{
		[Token(Token = "0x2000128")]
		public enum Exactness
		{
			[Token(Token = "0x4000653")]
			SnapToNode = 0,
			[Token(Token = "0x4000654")]
			Original = 1,
			[Token(Token = "0x4000655")]
			Interpolate = 2,
			[Token(Token = "0x4000656")]
			ClosestOnNode = 3,
			[Token(Token = "0x4000657")]
			NodeConnection = 4
		}

		[Token(Token = "0x4000649")]
		[FieldOffset(Offset = "0x18")]
		public bool addPoints;

		[Token(Token = "0x400064A")]
		[FieldOffset(Offset = "0x1C")]
		public Exactness exactStartPoint;

		[Token(Token = "0x400064B")]
		[FieldOffset(Offset = "0x20")]
		public Exactness exactEndPoint;

		[Token(Token = "0x400064C")]
		[FieldOffset(Offset = "0x28")]
		public Func<Vector3> adjustStartPoint;

		[Token(Token = "0x400064D")]
		[FieldOffset(Offset = "0x30")]
		public bool useRaycasting;

		[Token(Token = "0x400064E")]
		[FieldOffset(Offset = "0x34")]
		public LayerMask mask;

		[Token(Token = "0x400064F")]
		[FieldOffset(Offset = "0x38")]
		public bool useGraphRaycasting;

		[Token(Token = "0x4000650")]
		[FieldOffset(Offset = "0x40")]
		private List<GraphNode> connectionBuffer;

		[Token(Token = "0x4000651")]
		[FieldOffset(Offset = "0x48")]
		private Action<GraphNode> connectionBufferAddDelegate;

		[Token(Token = "0x170001C8")]
		public override int Order
		{
			[Token(Token = "0x60009CB")]
			[Address(RVA = "0x4558F38", Offset = "0x4554F38", VA = "0x4558F38", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x4558F40", Offset = "0x4554F40", VA = "0x4558F40", Slot = "9")]
		public override void Apply(Path _p)
		{
		}

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x4559258", Offset = "0x4555258", VA = "0x4559258")]
		private Vector3 Snap(ABPath path, Exactness mode, bool start, out bool forceAddPoint, out int closestConnectionIndex)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED StartEndModifier.Snap RVA=0x4559258 Token=0x60009CD");
}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x4559750", Offset = "0x4555750", VA = "0x4559750")]
		protected Vector3 GetClampedPoint(Vector3 from, Vector3 to, GraphNode hint)
		{
			return default;
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x4559944", Offset = "0x4555944", VA = "0x4559944")]
		public StartEndModifier()
		{
		}
	}
}
