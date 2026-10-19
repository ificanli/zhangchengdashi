using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x200037E")]
	public class RoleValkyrieBehaviour : TerranBehaviour
	{
		[Token(Token = "0x200037F")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass10_0
		{
			[Token(Token = "0x40025C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Tween jumpTween;

			[Token(Token = "0x6000FDF")]
			[Address(RVA = "0x3D97764", Offset = "0x3D93764", VA = "0x3D97764")]
			public _003C_003Ec__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6000FE0")]
			[Address(RVA = "0x3D9776C", Offset = "0x3D9376C", VA = "0x3D9776C")]
			internal bool _003CValkyrieSkill_003Eb__0()
			{
				return default;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000380")]
		[CompilerGenerated]
		private struct _003CValkyrieSkill_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x40025C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40025C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40025C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RoleValkyrieBehaviour _003C_003E4__this;

			[Token(Token = "0x40025C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private _003C_003Ec__DisplayClass10_0 _003C_003E8__1;

			[Token(Token = "0x40025CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float _003CskillAnimationStartTime_003E5__2;

			[Token(Token = "0x40025CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float _003CskillAnimationDuration_003E5__3;

			[Token(Token = "0x40025CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private object _003C_003E7__wrap3;

			[Token(Token = "0x40025CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private int _003C_003E7__wrap4;

			[Token(Token = "0x40025CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000FE1")]
			[Address(RVA = "0x3D977A4", Offset = "0x3D937A4", VA = "0x3D977A4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000FE2")]
			[Address(RVA = "0x3D98828", Offset = "0x3D94828", VA = "0x3D98828", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40025BC")]
		private const float SkillSearchRadius = 5f;

		[Token(Token = "0x40025BD")]
		private const float SkillTargetSearchRange = 10f;

		[Token(Token = "0x40025BE")]
		private const float SkillDamageRadius = 5f;

		[Token(Token = "0x40025BF")]
		private const float SkillJumpMinDuration = 0.01f;

		[Token(Token = "0x40025C0")]
		private const int SkillJumpPathSampleCount = 12;

		[Token(Token = "0x40025C1")]
		private const float SkillDamageDelay = 0.5f;

		[Token(Token = "0x40025C2")]
		private const float SkillRetryDelayWhenNoEnemy = 1f;

		[Token(Token = "0x40025C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private float skillJumpDurationPerUnit;

		[Token(Token = "0x40025C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D4")]
		private float skillJumpArcHeight;

		[Token(Token = "0x6000FD9")]
		[Address(RVA = "0x3D973F8", Offset = "0x3D933F8", VA = "0x3D973F8", Slot = "31")]
		protected override void EmitSkill()
		{
		}

		[Token(Token = "0x6000FDA")]
		[Address(RVA = "0x3D97414", Offset = "0x3D93414", VA = "0x3D97414")]
		[AsyncStateMachine(typeof(_003CValkyrieSkill_003Ed__10))]
		private void ValkyrieSkill()
		{
		}

		[Token(Token = "0x6000FDB")]
		[Address(RVA = "0x3D974A4", Offset = "0x3D934A4", VA = "0x3D974A4")]
		private Tween CreateJumpTween(Vector3 landingPosition)
		{
			return null;
		}

		[Token(Token = "0x6000FDC")]
		[Address(RVA = "0x3D9753C", Offset = "0x3D9353C", VA = "0x3D9753C")]
		private float GetJumpDuration(Vector3 startPosition, Vector3 landingPosition)
		{
			return default;
		}

		[Token(Token = "0x6000FDD")]
		[Address(RVA = "0x3D97564", Offset = "0x3D93564", VA = "0x3D97564")]
		private float EstimateJumpPathLength(Vector3 startPosition, Vector3 landingPosition)
		{
			return default;
		}

		[Token(Token = "0x6000FDE")]
		[Address(RVA = "0x3D97748", Offset = "0x3D93748", VA = "0x3D97748")]
		public RoleValkyrieBehaviour()
		{
		}
	}
}
