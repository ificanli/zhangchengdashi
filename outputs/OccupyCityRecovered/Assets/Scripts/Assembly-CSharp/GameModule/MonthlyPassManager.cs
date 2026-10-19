using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using ToolModule;

namespace GameModule
{
	[Token(Token = "0x20004F1")]
	public class MonthlyPassManager : ManagerBase<MonthlyPassManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004F3")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x4002D0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002D10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002D11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MonthlyPassManager _003C_003E4__this;

			[Token(Token = "0x600190B")]
			[Address(RVA = "0x3E8C418", Offset = "0x3E88418", VA = "0x3E8C418", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600190C")]
			[Address(RVA = "0x3E8C834", Offset = "0x3E88834", VA = "0x3E8C834", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004F4")]
		[CompilerGenerated]
		private struct _003CShowAdRemovalPassPanel_003Ed__12 : IAsyncStateMachine
		{
			[Token(Token = "0x4002D12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002D13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002D14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MonthlyPassManager _003C_003E4__this;

			[Token(Token = "0x4002D15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600190D")]
			[Address(RVA = "0x3E8C840", Offset = "0x3E88840", VA = "0x3E8C840", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600190E")]
			[Address(RVA = "0x3E8CCE8", Offset = "0x3E88CE8", VA = "0x3E8CCE8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004F5")]
		[CompilerGenerated]
		private struct _003CShowMonthlyPassPanel_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4002D16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002D17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002D18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MonthlyPassManager _003C_003E4__this;

			[Token(Token = "0x4002D19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string placement;

			[Token(Token = "0x4002D1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600190F")]
			[Address(RVA = "0x3E8CCF4", Offset = "0x3E88CF4", VA = "0x3E8CCF4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001910")]
			[Address(RVA = "0x3E8D1DC", Offset = "0x3E891DC", VA = "0x3E8D1DC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004F6")]
		[CompilerGenerated]
		private struct _003CTryShowMonthlyPassPanelAfterFirstDailyRewardedVideo_003Ed__11 : IAsyncStateMachine
		{
			[Token(Token = "0x4002D1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002D1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002D1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MonthlyPassManager _003C_003E4__this;

			[Token(Token = "0x4002D1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001911")]
			[Address(RVA = "0x3E8D1E8", Offset = "0x3E891E8", VA = "0x3E8D1E8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001912")]
			[Address(RVA = "0x3E8D730", Offset = "0x3E89730", VA = "0x3E8D730", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002D09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool waitShowRemoveAdPassPanel;

		[Token(Token = "0x4002D0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GlobalShopInfo monthlyPassInfo;

		[Token(Token = "0x4002D0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool waitIOSShowRemoveAdPanel;

		[Token(Token = "0x4002D0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool monthPassIsHad;

		[Token(Token = "0x17000153")]
		public bool HasClaimTodayReward
		{
			[Token(Token = "0x60018FD")]
			[Address(RVA = "0x3E8BBF0", Offset = "0x3E87BF0", VA = "0x3E8BBF0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60018FE")]
		[Address(RVA = "0x3E8BC58", Offset = "0x3E87C58", VA = "0x3E8BC58", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__6))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x60018FF")]
		[Address(RVA = "0x3E8BCDC", Offset = "0x3E87CDC", VA = "0x3E8BCDC")]
		private void Update()
		{
		}

		[Token(Token = "0x6001900")]
		[Address(RVA = "0x3E8BE10", Offset = "0x3E87E10", VA = "0x3E8BE10")]
		private void BuyMonthPass(object o)
		{
		}

		[Token(Token = "0x6001901")]
		[Address(RVA = "0x3E8BEC8", Offset = "0x3E87EC8", VA = "0x3E8BEC8")]
		public void ClaimTodayDailyReward(string monthPassBanner)
		{
		}

		[Token(Token = "0x6001902")]
		[Address(RVA = "0x3E8C098", Offset = "0x3E88098", VA = "0x3E8C098")]
		[AsyncStateMachine(typeof(_003CShowMonthlyPassPanel_003Ed__10))]
		public UniTask ShowMonthlyPassPanel([Optional] string placement)
		{
			return default;
		}

		[Token(Token = "0x6001903")]
		[Address(RVA = "0x3E8C134", Offset = "0x3E88134", VA = "0x3E8C134")]
		[AsyncStateMachine(typeof(_003CTryShowMonthlyPassPanelAfterFirstDailyRewardedVideo_003Ed__11))]
		public UniTask TryShowMonthlyPassPanelAfterFirstDailyRewardedVideo()
		{
			return default;
		}

		[Token(Token = "0x6001904")]
		[Address(RVA = "0x3E8C1C0", Offset = "0x3E881C0", VA = "0x3E8C1C0")]
		[AsyncStateMachine(typeof(_003CShowAdRemovalPassPanel_003Ed__12))]
		public UniTask ShowAdRemovalPassPanel()
		{
			return default;
		}

		[Token(Token = "0x6001905")]
		[Address(RVA = "0x3E8BDA4", Offset = "0x3E87DA4", VA = "0x3E8BDA4")]
		public bool HadBuyMonthPass()
		{
			return default;
		}

		[Token(Token = "0x6001906")]
		[Address(RVA = "0x3E8C24C", Offset = "0x3E8824C", VA = "0x3E8C24C")]
		public TimeSpan MonthPassRemainingTime()
		{
			return default;
		}

		[Token(Token = "0x6001907")]
		[Address(RVA = "0x3E8C318", Offset = "0x3E88318", VA = "0x3E8C318")]
		public MonthlyPassManager()
		{
		}
	}
}
