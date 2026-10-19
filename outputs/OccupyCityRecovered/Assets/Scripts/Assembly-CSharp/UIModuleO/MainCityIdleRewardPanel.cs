using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TimeModuleO;

namespace UIModuleO
{
	[Token(Token = "0x200093A")]
	public class MainCityIdleRewardPanel : MainCityIdleRewardPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200093B")]
		[CompilerGenerated]
		private struct _003CRefreshLoopAsync_003Ed__18 : IAsyncStateMachine
		{
			[Token(Token = "0x4004527")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004528")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004529")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MainCityIdleRewardPanel _003C_003E4__this;

			[Token(Token = "0x400452A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CancellationToken token;

			[Token(Token = "0x400452B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003596")]
			[Address(RVA = "0x40BB978", Offset = "0x40B7978", VA = "0x40BB978", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003597")]
			[Address(RVA = "0x40BBFC0", Offset = "0x40B7FC0", VA = "0x40BBFC0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200093C")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__9 : IAsyncStateMachine
		{
			[Token(Token = "0x400452C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400452D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400452E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MainCityIdleRewardPanel _003C_003E4__this;

			[Token(Token = "0x400452F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003598")]
			[Address(RVA = "0x40BBFCC", Offset = "0x40B7FCC", VA = "0x40BBFCC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003599")]
			[Address(RVA = "0x40BC6DC", Offset = "0x40B86DC", VA = "0x40BC6DC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004520")]
		private const float RefreshIntervalSeconds = 1f;

		[Token(Token = "0x4004521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private readonly List<string> _rewardKeys;

		[Token(Token = "0x4004522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private readonly string[] _lastRewardTexts;

		[Token(Token = "0x4004523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private CancellationTokenSource _refreshCts;

		[Token(Token = "0x4004524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int _lastRewardMinute;

		[Token(Token = "0x4004525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private string _lastIdleTimeText;

		[Token(Token = "0x4004526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private string _maxIdleTimeFormat;

		[Token(Token = "0x6003582")]
		[Address(RVA = "0x40BA360", Offset = "0x40B6360", VA = "0x40BA360", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6003583")]
		[Address(RVA = "0x40BA4FC", Offset = "0x40B64FC", VA = "0x40BA4FC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6003584")]
		[Address(RVA = "0x40BA538", Offset = "0x40B6538", VA = "0x40BA538", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__9))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003585")]
		[Address(RVA = "0x40BA5CC", Offset = "0x40B65CC", VA = "0x40BA5CC")]
		public void UpdateUI()
		{
		}

		[Token(Token = "0x6003586")]
		[Address(RVA = "0x40BA5D0", Offset = "0x40B65D0", VA = "0x40BA5D0")]
		private void RefreshAll()
		{
		}

		[Token(Token = "0x6003587")]
		[Address(RVA = "0x40BA750", Offset = "0x40B6750", VA = "0x40BA750")]
		private void CacheRewardKeys()
		{
		}

		[Token(Token = "0x6003588")]
		[Address(RVA = "0x40BAA48", Offset = "0x40B6A48", VA = "0x40BAA48")]
		private void RefreshRewardUI(bool force = false)
		{
		}

		[Token(Token = "0x6003589")]
		[Address(RVA = "0x40BAC6C", Offset = "0x40B6C6C", VA = "0x40BAC6C")]
		private void SetRewardNumText(int index, string value, bool force)
		{
		}

		[Token(Token = "0x600358A")]
		[Address(RVA = "0x40BA97C", Offset = "0x40B697C", VA = "0x40BA97C")]
		private void RefreshIdleTimeText(TimeManager.Timer timer, bool force = false)
		{
		}

		[Token(Token = "0x600358B")]
		[Address(RVA = "0x40BB120", Offset = "0x40B7120", VA = "0x40BB120")]
		private void StartRefreshLoop()
		{
		}

		[Token(Token = "0x600358C")]
		[Address(RVA = "0x40BA500", Offset = "0x40B6500", VA = "0x40BA500")]
		private void StopRefreshLoop()
		{
		}

		[Token(Token = "0x600358D")]
		[Address(RVA = "0x40BB1A4", Offset = "0x40B71A4", VA = "0x40BB1A4")]
		[AsyncStateMachine(typeof(_003CRefreshLoopAsync_003Ed__18))]
		private UniTask RefreshLoopAsync(CancellationToken token)
		{
			return default;
		}

		[Token(Token = "0x600358E")]
		[Address(RVA = "0x40BB240", Offset = "0x40B7240", VA = "0x40BB240", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600358F")]
		[Address(RVA = "0x40BB48C", Offset = "0x40B748C", VA = "0x40BB48C", Slot = "15")]
		protected override void OnButtonExtendBtnCancelClicked()
		{
		}

		[Token(Token = "0x6003590")]
		[Address(RVA = "0x40BB518", Offset = "0x40B7518", VA = "0x40BB518", Slot = "12")]
		protected override void OnButtonExtendBtnExitClicked()
		{
		}

		[Token(Token = "0x6003591")]
		[Address(RVA = "0x40BB5A4", Offset = "0x40B75A4", VA = "0x40BB5A4")]
		private void AdCallBack()
		{
		}

		[Token(Token = "0x6003592")]
		[Address(RVA = "0x40BB60C", Offset = "0x40B760C", VA = "0x40BB60C", Slot = "14")]
		protected override void OnButtonExtendClaimClicked()
		{
		}

		[Token(Token = "0x6003593")]
		[Address(RVA = "0x40BB778", Offset = "0x40B7778", VA = "0x40BB778")]
		public MainCityIdleRewardPanel()
		{
		}
	}
}
