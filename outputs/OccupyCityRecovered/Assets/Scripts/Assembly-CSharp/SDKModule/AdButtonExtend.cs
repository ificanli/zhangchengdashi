using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using L_Tools;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine.Events;

namespace SDKModule
{
	[Token(Token = "0x2000185")]
	public class AdButtonExtend : ButtonExtend, UITweenerInterface
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000186")]
		[CompilerGenerated]
		private struct _003COnAdRewardedDelayed_003Ed__22 : IAsyncStateMachine
		{
			[Token(Token = "0x4001A8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001A8C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001A8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AdButtonExtend _003C_003E4__this;

			[Token(Token = "0x4001A8E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int rvID;

			[Token(Token = "0x4001A8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public bool isFree;

			[Token(Token = "0x4001A90")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600063F")]
			[Address(RVA = "0x3F78064", Offset = "0x3F74064", VA = "0x3F78064", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000640")]
			[Address(RVA = "0x3F786CC", Offset = "0x3F746CC", VA = "0x3F786CC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001A82")]
		private const float ClickBlockDuration = 0.3f;

		[Token(Token = "0x4001A83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private bool _isRegister;

		[Token(Token = "0x4001A84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int _rvID;

		[Token(Token = "0x4001A85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Func<bool> _canShowVideoFunc;

		[Token(Token = "0x4001A86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private readonly UnityEvent _onAdComplete;

		[Token(Token = "0x4001A87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private LTVideoButtonHook _videoButtonHook;

		[Token(Token = "0x4001A88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private bool _isRewardLocked;

		[Token(Token = "0x4001A89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		private float _nextAllowRewardTime;

		[Token(Token = "0x4001A8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private bool _isFree;

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x3F779B4", Offset = "0x3F739B4", VA = "0x3F779B4")]
		private void EnsureHook()
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x3F77B64", Offset = "0x3F73B64", VA = "0x3F77B64", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x3F77C1C", Offset = "0x3F73C1C", VA = "0x3F77C1C", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x3F77C3C", Offset = "0x3F73C3C", VA = "0x3F77C3C", Slot = "43")]
		public void ToOpen()
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x3F77C78", Offset = "0x3F73C78", VA = "0x3F77C78", Slot = "44")]
		public void ToClose()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x3F77B84", Offset = "0x3F73B84", VA = "0x3F77B84")]
		private void SetIsRegister(bool value)
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x3F76E58", Offset = "0x3F72E58", VA = "0x3F76E58")]
		public void SetVideoBtnInter(bool b)
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x3F77C80", Offset = "0x3F73C80", VA = "0x3F77C80")]
		public void SetInfo(int rvID, [Optional] UnityAction onAdComplete, [Optional] Func<bool> canShowVideo)
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x3F77D54", Offset = "0x3F73D54", VA = "0x3F77D54")]
		public void SetIsFree(bool free)
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x3F77E8C", Offset = "0x3F73E8C", VA = "0x3F77E8C")]
		private void OnClick()
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x3F77F10", Offset = "0x3F73F10", VA = "0x3F77F10")]
		private void OnDbtRVComplete(bool result)
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x3F77EA0", Offset = "0x3F73EA0", VA = "0x3F77EA0")]
		private void TryTriggerReward(bool isFree)
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x3F77F20", Offset = "0x3F73F20", VA = "0x3F77F20")]
		private bool CanTriggerReward()
		{
			return default;
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x3F77F58", Offset = "0x3F73F58", VA = "0x3F77F58")]
		[AsyncStateMachine(typeof(_003COnAdRewardedDelayed_003Ed__22))]
		private void OnAdRewardedDelayed(int rvID, bool isFree)
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x3F78004", Offset = "0x3F74004", VA = "0x3F78004")]
		public AdButtonExtend()
		{
		}
	}
}
