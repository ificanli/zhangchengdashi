using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000B7D")]
	public class SpecialSummonGiftPanel : SpecialSummonGiftPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B7E")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x40053C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40053C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40053C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SpecialSummonGiftPanel _003C_003E4__this;

			[Token(Token = "0x40053C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x40053C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600467E")]
			[Address(RVA = "0x4215E80", Offset = "0x4211E80", VA = "0x4215E80", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600467F")]
			[Address(RVA = "0x42163C8", Offset = "0x42123C8", VA = "0x42163C8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40053BD")]
		private const float WeeklyCountdownRefreshInterval = 1f;

		[Token(Token = "0x40053BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly List<SpecialSummonGiftItem> _giftItems;

		[Token(Token = "0x40053BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float _weeklyCountdownRefreshTimer;

		[Token(Token = "0x6004673")]
		[Address(RVA = "0x42154B4", Offset = "0x42114B4", VA = "0x42154B4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004674")]
		[Address(RVA = "0x4215770", Offset = "0x4211770", VA = "0x4215770", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__4))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004675")]
		[Address(RVA = "0x421580C", Offset = "0x421180C", VA = "0x421580C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004676")]
		[Address(RVA = "0x42159F0", Offset = "0x42119F0", VA = "0x42159F0", Slot = "12")]
		protected override void OnButtonExtendMaskClicked()
		{
		}

		[Token(Token = "0x6004677")]
		[Address(RVA = "0x42159FC", Offset = "0x42119FC", VA = "0x42159FC", Slot = "13")]
		protected override void OnButtonExtendCloseBtnClicked()
		{
		}

		[Token(Token = "0x6004678")]
		[Address(RVA = "0x4215A08", Offset = "0x4211A08", VA = "0x4215A08")]
		private void Update()
		{
		}

		[Token(Token = "0x6004679")]
		[Address(RVA = "0x42154F4", Offset = "0x42114F4", VA = "0x42154F4")]
		private void BuildGiftItemList()
		{
		}

		[Token(Token = "0x600467A")]
		[Address(RVA = "0x4215C74", Offset = "0x4211C74", VA = "0x4215C74")]
		private void RefreshAll()
		{
		}

		[Token(Token = "0x600467B")]
		[Address(RVA = "0x4215D00", Offset = "0x4211D00", VA = "0x4215D00")]
		private void OnPackScheduleChanged(object obj)
		{
		}

		[Token(Token = "0x600467C")]
		[Address(RVA = "0x4215D64", Offset = "0x4211D64", VA = "0x4215D64")]
		public SpecialSummonGiftPanel()
		{
		}
	}
}
