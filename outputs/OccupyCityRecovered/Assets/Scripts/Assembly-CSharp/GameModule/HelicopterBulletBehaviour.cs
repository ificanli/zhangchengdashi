using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000268")]
	public class HelicopterBulletBehaviour : BulletBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000269")]
		[CompilerGenerated]
		private struct _003CFollowBezierPath_003Ed__11 : IAsyncStateMachine
		{
			[Token(Token = "0x4001F1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001F1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001F20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HelicopterBulletBehaviour _003C_003E4__this;

			[Token(Token = "0x4001F21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 _003ClastPosition_003E5__2;

			[Token(Token = "0x4001F22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000A82")]
			[Address(RVA = "0x4387CB8", Offset = "0x4383CB8", VA = "0x4387CB8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000A83")]
			[Address(RVA = "0x438830C", Offset = "0x438430C", VA = "0x438830C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001F15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int curvePoints;

		[Token(Token = "0x4001F16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float flightDuration;

		[Token(Token = "0x4001F17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float height;

		[Token(Token = "0x4001F18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public int randomControlPoints;

		[Token(Token = "0x4001F19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float controlPointRadius;

		[Token(Token = "0x4001F1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<Vector3> curvePath;

		[Token(Token = "0x4001F1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float currentTime;

		[Token(Token = "0x4001F1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool isMoving;

		[Token(Token = "0x4001F1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float speedFactor;

		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x43872D4", Offset = "0x43832D4", VA = "0x43872D4", Slot = "4")]
		public override void InitInfo(EntityBase obj, int atk, bool isEnemy, bool isEffBullet, [Optional] EntityBase fireObj, bool isLand = true, CardFettersType fettersType = CardFettersType.Null)
		{
		}

		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x43873D0", Offset = "0x43833D0", VA = "0x43873D0")]
		private void GenerateRandomBezierPath()
		{
		}

		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0x4387784", Offset = "0x4383784", VA = "0x4387784")]
		[AsyncStateMachine(typeof(_003CFollowBezierPath_003Ed__11))]
		private UniTask FollowBezierPath()
		{
			return default;
		}

		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x4387810", Offset = "0x4383810", VA = "0x4387810")]
		public void RandomSpeedFactor()
		{
		}

		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x438783C", Offset = "0x438383C", VA = "0x438783C")]
		private Vector3 CalculateBezierPoint(float t, List<Vector3> points)
		{
			return default;
		}

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x4387AA8", Offset = "0x4383AA8", VA = "0x4387AA8", Slot = "10")]
		protected override void Clear()
		{
		}

		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x4387B08", Offset = "0x4383B08", VA = "0x4387B08")]
		private void OnTargetReached()
		{
		}

		[Token(Token = "0x6000A80")]
		[Address(RVA = "0x4387C08", Offset = "0x4383C08", VA = "0x4387C08", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x4387C0C", Offset = "0x4383C0C", VA = "0x4387C0C")]
		public HelicopterBulletBehaviour()
		{
		}
	}
}
