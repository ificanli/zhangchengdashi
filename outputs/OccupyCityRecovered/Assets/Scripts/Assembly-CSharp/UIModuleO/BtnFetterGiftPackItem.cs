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
	[Token(Token = "0x200076A")]
	public class BtnFetterGiftPackItem : BtnFetterGiftPackItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200076C")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4003A05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003A06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003A07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GlobalShopInfo info;

			[Token(Token = "0x4003A08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public BtnFetterGiftPackItem _003C_003E4__this;

			[Token(Token = "0x60028B7")]
			[Address(RVA = "0x3FB7038", Offset = "0x3FB3038", VA = "0x3FB7038", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60028B8")]
			[Address(RVA = "0x3FB7CC8", Offset = "0x3FB3CC8", VA = "0x3FB7CC8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200076D")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4003A09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003A0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003A0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BtnFetterGiftPackItem _003C_003E4__this;

			[Token(Token = "0x4003A0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60028B9")]
			[Address(RVA = "0x3FB7CD4", Offset = "0x3FB3CD4", VA = "0x3FB7CD4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60028BA")]
			[Address(RVA = "0x3FB7EB4", Offset = "0x3FB3EB4", VA = "0x3FB7EB4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200076E")]
		[CompilerGenerated]
		private struct _003CUpdateCardItem_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x4003A0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003A0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003A0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BtnFetterGiftPackItem _003C_003E4__this;

			[Token(Token = "0x60028BB")]
			[Address(RVA = "0x3FB7EC0", Offset = "0x3FB3EC0", VA = "0x3FB7EC0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60028BC")]
			[Address(RVA = "0x3FB86F8", Offset = "0x3FB46F8", VA = "0x3FB86F8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40039FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private GlobalShopInfo _info;

		[Token(Token = "0x4003A00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private string IAPID;

		[Token(Token = "0x4003A01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool InitStartEvevt;

		[Token(Token = "0x4003A02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private TimeManager.Timer toMondayTimer;

		[Token(Token = "0x60028A8")]
		[Address(RVA = "0x3FB5E88", Offset = "0x3FB1E88", VA = "0x3FB5E88", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__4))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60028A9")]
		[Address(RVA = "0x3FB5F1C", Offset = "0x3FB1F1C", VA = "0x3FB5F1C")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__5))]
		public void Init(GlobalShopInfo info)
		{
		}

		[Token(Token = "0x60028AA")]
		[Address(RVA = "0x3FB5FB8", Offset = "0x3FB1FB8", VA = "0x3FB5FB8")]
		[AsyncStateMachine(typeof(_003CUpdateCardItem_003Ed__6))]
		private void UpdateCardItem()
		{
		}

		[Token(Token = "0x60028AB")]
		[Address(RVA = "0x3FB6044", Offset = "0x3FB2044", VA = "0x3FB6044")]
		private void Update()
		{
		}

		[Token(Token = "0x60028AC")]
		[Address(RVA = "0x3FB61E8", Offset = "0x3FB21E8", VA = "0x3FB61E8")]
		private void TimeToMonDayZero(object o)
		{
		}

		[Token(Token = "0x60028AD")]
		[Address(RVA = "0x3FB650C", Offset = "0x3FB250C", VA = "0x3FB650C")]
		private void RefreshItem(object o)
		{
		}

		[Token(Token = "0x60028AE")]
		[Address(RVA = "0x3FB6524", Offset = "0x3FB2524", VA = "0x3FB6524")]
		private void RefreshBuyCount()
		{
		}

		[Token(Token = "0x60028AF")]
		[Address(RVA = "0x3FB61EC", Offset = "0x3FB21EC", VA = "0x3FB61EC")]
		private void UpdateBuyPackCountUI()
		{
		}

		[Token(Token = "0x60028B0")]
		[Address(RVA = "0x3FB68C8", Offset = "0x3FB28C8", VA = "0x3FB68C8")]
		private string[] BuildGiftPackPackRewardArray(Dictionary<string, int> packConfig)
		{
			return null;
		}

		[Token(Token = "0x60028B1")]
		[Address(RVA = "0x3FB6BEC", Offset = "0x3FB2BEC", VA = "0x3FB6BEC", Slot = "12")]
		protected override void OnButtonExtendBtnFetterGiftPackItemClicked()
		{
		}

		[Token(Token = "0x60028B2")]
		[Address(RVA = "0x3FB6F30", Offset = "0x3FB2F30", VA = "0x3FB6F30")]
		public BtnFetterGiftPackItem()
		{
		}
	}
}
