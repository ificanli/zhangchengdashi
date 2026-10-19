using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using DataModule;
using Il2CppDummyDll;
using SuperScrollView;

namespace UIModuleO
{
	[Token(Token = "0x20008F5")]
	public class GiftChainPanel2 : GiftChainPanel2Components
	{
		[Token(Token = "0x20008F9")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass15_0
		{
			[Token(Token = "0x40043BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GiftChainPanel2 _003C_003E4__this;

			[Token(Token = "0x40043BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GiftChainItem2 first;

			[Token(Token = "0x60033B9")]
			[Address(RVA = "0x409E6D0", Offset = "0x409A6D0", VA = "0x409E6D0")]
			public _003C_003Ec__DisplayClass15_0()
			{
			}

			[Token(Token = "0x60033BA")]
			[Address(RVA = "0x409E6D8", Offset = "0x409A6D8", VA = "0x409E6D8")]
			internal void _003CMovePanelToItemIndexComplete_003Eb__4()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008FB")]
		[CompilerGenerated]
		private struct _003CMovePanelToItemIndexComplete_003Ed__15 : IAsyncStateMachine
		{
			[Token(Token = "0x40043C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40043C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40043C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GiftChainPanel2 _003C_003E4__this;

			[Token(Token = "0x40043C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float duration;

			[Token(Token = "0x40043C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private _003C_003Ec__DisplayClass15_0 _003C_003E8__1;

			[Token(Token = "0x40043C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60033BF")]
			[Address(RVA = "0x409EA60", Offset = "0x409AA60", VA = "0x409EA60", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60033C0")]
			[Address(RVA = "0x409FCD8", Offset = "0x409BCD8", VA = "0x409FCD8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008FC")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x40043C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40043C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40043C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GiftChainPanel2 _003C_003E4__this;

			[Token(Token = "0x40043C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60033C1")]
			[Address(RVA = "0x409FCE4", Offset = "0x409BCE4", VA = "0x409FCE4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60033C2")]
			[Address(RVA = "0x40A0080", Offset = "0x409C080", VA = "0x40A0080", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40043AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private List<GlobalGiftChainInfo2> giftChian2Info;

		[Token(Token = "0x40043AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private string preName;

		[Token(Token = "0x40043B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private string preName2;

		[Token(Token = "0x40043B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private string _placement;

		[Token(Token = "0x40043B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int buyLevel;

		[Token(Token = "0x40043B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private bool isSVInit;

		[Token(Token = "0x40043B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Sequence sq;

		[Token(Token = "0x60033A0")]
		[Address(RVA = "0x409C6D0", Offset = "0x40986D0", VA = "0x409C6D0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60033A1")]
		[Address(RVA = "0x409C8A8", Offset = "0x40988A8", VA = "0x409C8A8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__8))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60033A2")]
		[Address(RVA = "0x409C93C", Offset = "0x409893C", VA = "0x409C93C", Slot = "9")]
		public override void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x60033A3")]
		[Address(RVA = "0x409D0C4", Offset = "0x40990C4", VA = "0x409D0C4")]
		private void Update()
		{
		}

		[Token(Token = "0x60033A4")]
		[Address(RVA = "0x409D20C", Offset = "0x409920C", VA = "0x409D20C")]
		private void RefreshGiftChainBuyLevel(object o)
		{
		}

		[Token(Token = "0x60033A5")]
		[Address(RVA = "0x409D244", Offset = "0x4099244", VA = "0x409D244")]
		private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index)
		{
			return null;
		}

		[Token(Token = "0x60033A6")]
		[Address(RVA = "0x409D4C4", Offset = "0x40994C4", VA = "0x409D4C4")]
		private void GotoUnlockItemAndShowTip(object o)
		{
		}

		[Token(Token = "0x60033A7")]
		[Address(RVA = "0x409D5BC", Offset = "0x40995BC", VA = "0x409D5BC")]
		public void UnLockAnimation(object o)
		{
		}

		[Token(Token = "0x60033A8")]
		[Address(RVA = "0x409E07C", Offset = "0x409A07C", VA = "0x409E07C")]
		[AsyncStateMachine(typeof(_003CMovePanelToItemIndexComplete_003Ed__15))]
		private void MovePanelToItemIndexComplete(float duration)
		{
		}

		[Token(Token = "0x60033A9")]
		[Address(RVA = "0x409E124", Offset = "0x409A124", VA = "0x409E124", Slot = "16")]
		protected override void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x60033AA")]
		[Address(RVA = "0x409E1B0", Offset = "0x409A1B0", VA = "0x409E1B0", Slot = "12")]
		protected override void OnButtonExtendBtnCloseAllScreenClicked()
		{
		}

		[Token(Token = "0x60033AB")]
		[Address(RVA = "0x409E23C", Offset = "0x409A23C", VA = "0x409E23C")]
		public GiftChainPanel2()
		{
		}
	}
}
