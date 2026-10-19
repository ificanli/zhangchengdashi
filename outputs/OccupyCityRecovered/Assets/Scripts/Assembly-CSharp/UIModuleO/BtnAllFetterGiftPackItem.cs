using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using TimeModuleO;

namespace UIModuleO
{
	[Token(Token = "0x2000732")]
	public class BtnAllFetterGiftPackItem : BtnAllFetterGiftPackItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000734")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x40038C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40038C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40038C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GlobalShopInfo info;

			[Token(Token = "0x40038C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public BtnAllFetterGiftPackItem _003C_003E4__this;

			[Token(Token = "0x6002749")]
			[Address(RVA = "0x3FA0CB4", Offset = "0x3F9CCB4", VA = "0x3FA0CB4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600274A")]
			[Address(RVA = "0x3FA1578", Offset = "0x3F9D578", VA = "0x3FA1578", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000735")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x40038C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40038CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40038CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BtnAllFetterGiftPackItem _003C_003E4__this;

			[Token(Token = "0x40038CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600274B")]
			[Address(RVA = "0x3FA1584", Offset = "0x3F9D584", VA = "0x3FA1584", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600274C")]
			[Address(RVA = "0x3FA1764", Offset = "0x3F9D764", VA = "0x3FA1764", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40038BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private GlobalShopInfo _info;

		[Token(Token = "0x40038C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private string IAPID;

		[Token(Token = "0x40038C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private bool initStartEvent;

		[Token(Token = "0x40038C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private TimeManager.Timer toMondayTimer;

		[Token(Token = "0x600273A")]
		[Address(RVA = "0x3F9E80C", Offset = "0x3F9A80C", VA = "0x3F9E80C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__4))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600273B")]
		[Address(RVA = "0x3F9E8A0", Offset = "0x3F9A8A0", VA = "0x3F9E8A0")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__5))]
		public void Init(GlobalShopInfo info)
		{
		}

		[Token(Token = "0x600273C")]
		[Address(RVA = "0x3F9E93C", Offset = "0x3F9A93C", VA = "0x3F9E93C")]
		private void UpdateCardItem()
		{
		}

		[Token(Token = "0x600273D")]
		[Address(RVA = "0x3FA0134", Offset = "0x3F9C134", VA = "0x3FA0134")]
		private void Update()
		{
		}

		[Token(Token = "0x600273E")]
		[Address(RVA = "0x3FA0268", Offset = "0x3F9C268", VA = "0x3FA0268")]
		private void TimeToMonDayZero(object o)
		{
		}

		[Token(Token = "0x600273F")]
		[Address(RVA = "0x3FA0544", Offset = "0x3F9C544", VA = "0x3FA0544")]
		private void RefreshItem(object o)
		{
		}

		[Token(Token = "0x6002740")]
		[Address(RVA = "0x3FA055C", Offset = "0x3F9C55C", VA = "0x3FA055C")]
		private void RefreshBuyCount()
		{
		}

		[Token(Token = "0x6002741")]
		[Address(RVA = "0x3FA026C", Offset = "0x3F9C26C", VA = "0x3FA026C")]
		private void UpdateBuyPackCountUI()
		{
		}

		[Token(Token = "0x6002742")]
		[Address(RVA = "0x3F9FE10", Offset = "0x3F9BE10", VA = "0x3F9FE10")]
		private string[] BuildGiftPackRewardArray(Dictionary<string, int> packConfig)
		{
			return null;
		}

		[Token(Token = "0x6002743")]
		[Address(RVA = "0x3FA0900", Offset = "0x3F9C900", VA = "0x3FA0900", Slot = "12")]
		protected override void OnButtonExtendBtnAllFetterGiftPackItemClicked()
		{
		}

		[Token(Token = "0x6002744")]
		[Address(RVA = "0x3FA0BAC", Offset = "0x3F9CBAC", VA = "0x3FA0BAC")]
		public BtnAllFetterGiftPackItem()
		{
		}
	}
}
