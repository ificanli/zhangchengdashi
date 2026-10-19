using System;
using Il2CppDummyDll;
using Pathfinding.Drawing;
using Pathfinding.Util;
using UnityEngine;
using UnityEngine.Serialization;

namespace Pathfinding
{
	[Serializable]
	[Token(Token = "0x2000072")]
	public class AutoRepathPolicy
	{
		[Token(Token = "0x2000073")]
		public enum Mode : byte
		{
			[Token(Token = "0x400029B")]
			Never = 0,
			[Token(Token = "0x400029C")]
			EveryNSeconds = 1,
			[Token(Token = "0x400029D")]
			Dynamic = 2
		}

		[Token(Token = "0x4000293")]
		[FieldOffset(Offset = "0x10")]
		public Mode mode;

		[Token(Token = "0x4000294")]
		[FieldOffset(Offset = "0x14")]
		[FormerlySerializedAs("interval")]
		public float period;

		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0x18")]
		public float sensitivity;

		[Token(Token = "0x4000296")]
		[FieldOffset(Offset = "0x1C")]
		[FormerlySerializedAs("maximumInterval")]
		public float maximumPeriod;

		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0x20")]
		public bool visualizeSensitivity;

		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x24")]
		private Vector3 lastDestination;

		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0x30")]
		private float lastRepathTime;

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x44FDB58", Offset = "0x44F9B58", VA = "0x44FDB58", Slot = "4")]
		public virtual bool ShouldRecalculatePath(Vector3 position, float radius, Vector3 destination, float time)
		{
			return default;
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x44FDC28", Offset = "0x44F9C28", VA = "0x44FDC28", Slot = "5")]
		public virtual void Reset()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x44FDC34", Offset = "0x44F9C34", VA = "0x44FDC34", Slot = "6")]
		public virtual void DidRecalculatePath(Vector3 destination, float time)
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x44FDC98", Offset = "0x44F9C98", VA = "0x44FDC98")]
		public void DrawGizmos(CommandBuilder draw, Vector3 position, float radius, NativeMovementPlane movementPlane)
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x44FDE0C", Offset = "0x44F9E0C", VA = "0x44FDE0C")]
		public AutoRepathPolicy Clone()
		{
			return null;
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x44FDE90", Offset = "0x44F9E90", VA = "0x44FDE90")]
		public AutoRepathPolicy()
		{
		}
	}
}
