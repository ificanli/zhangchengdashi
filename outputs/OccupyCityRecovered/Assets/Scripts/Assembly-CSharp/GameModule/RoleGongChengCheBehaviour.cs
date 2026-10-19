using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000377")]
	public class RoleGongChengCheBehaviour : MachineBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200037A")]
		[CompilerGenerated]
		private struct _003CChargeToNearestBuilding_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x40025AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40025AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40025AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RoleGongChengCheBehaviour _003C_003E4__this;

			[Token(Token = "0x40025B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000FCD")]
			[Address(RVA = "0x3D95A3C", Offset = "0x3D91A3C", VA = "0x3D95A3C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000FCE")]
			[Address(RVA = "0x3D96338", Offset = "0x3D92338", VA = "0x3D96338", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200037B")]
		[CompilerGenerated]
		private struct _003CStartChargeIfHasSkill_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x40025B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40025B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40025B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RoleGongChengCheBehaviour _003C_003E4__this;

			[Token(Token = "0x40025B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000FCF")]
			[Address(RVA = "0x3D96344", Offset = "0x3D92344", VA = "0x3D96344", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000FD0")]
			[Address(RVA = "0x3D966B8", Offset = "0x3D926B8", VA = "0x3D966B8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40025A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private bool _charging;

		[Token(Token = "0x40025A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E1")]
		private bool _trailEnd;

		[Token(Token = "0x40025A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E2")]
		private bool _chargeSpeedBoostApplied;

		[Token(Token = "0x40025A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E4")]
		private float _chargeOriginalMoveSpeed;

		[Token(Token = "0x6000FC1")]
		[Address(RVA = "0x3D95468", Offset = "0x3D91468", VA = "0x3D95468", Slot = "20")]
		public override void Init(GlobalRoleInfo info, bool isEnemy, int cardLevel, RareLevel rareLevel, [Optional] string relativeCardID, CardFettersType fettersType = CardFettersType.Null, AtkWayType atkWayType = AtkWayType.Null)
		{
		}

		[Token(Token = "0x6000FC2")]
		[Address(RVA = "0x3D954A4", Offset = "0x3D914A4", VA = "0x3D954A4")]
		[AsyncStateMachine(typeof(_003CStartChargeIfHasSkill_003Ed__5))]
		private UniTaskVoid StartChargeIfHasSkill()
		{
			return default;
		}

		[Token(Token = "0x6000FC3")]
		[Address(RVA = "0x3D9551C", Offset = "0x3D9151C", VA = "0x3D9551C")]
		[AsyncStateMachine(typeof(_003CChargeToNearestBuilding_003Ed__6))]
		private UniTaskVoid ChargeToNearestBuilding()
		{
			return default;
		}

		[Token(Token = "0x6000FC4")]
		[Address(RVA = "0x3D95590", Offset = "0x3D91590", VA = "0x3D95590")]
		private void ApplyChargeSpeedBoostIfNeeded()
		{
		}

		[Token(Token = "0x6000FC5")]
		[Address(RVA = "0x3D95680", Offset = "0x3D91680", VA = "0x3D95680")]
		private void RestoreChargeSpeedIfNeeded()
		{
		}

		[Token(Token = "0x6000FC6")]
		[Address(RVA = "0x3D95710", Offset = "0x3D91710", VA = "0x3D95710")]
		public RoleGongChengCheBehaviour()
		{
		}
	}
}
