using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000B74")]
	public class SpecialOfferGiftPackPanel : SpecialOfferGiftPackPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B75")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x400538C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400538D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400538E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SpecialOfferGiftPackPanel _003C_003E4__this;

			[Token(Token = "0x400538F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004628")]
			[Address(RVA = "0x4211704", Offset = "0x420D704", VA = "0x4211704", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004629")]
			[Address(RVA = "0x4211B68", Offset = "0x420DB68", VA = "0x4211B68", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<RewardItemUI> allRewardItem;

		[Token(Token = "0x400538A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public GlobalIAPInfo iapInfo;

		[Token(Token = "0x400538B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private string _placement;

		[Token(Token = "0x600461C")]
		[Address(RVA = "0x421109C", Offset = "0x420D09C", VA = "0x421109C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600461D")]
		[Address(RVA = "0x42111BC", Offset = "0x420D1BC", VA = "0x42111BC", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__4))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600461E")]
		[Address(RVA = "0x4211250", Offset = "0x420D250", VA = "0x4211250")]
		public void InitIAPBtn()
		{
		}

		[Token(Token = "0x600461F")]
		[Address(RVA = "0x4211288", Offset = "0x420D288", VA = "0x4211288")]
		private void Update()
		{
		}

		[Token(Token = "0x6004620")]
		[Address(RVA = "0x421130C", Offset = "0x420D30C", VA = "0x421130C", Slot = "9")]
		public override void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x6004621")]
		[Address(RVA = "0x4211478", Offset = "0x420D478", VA = "0x4211478")]
		private void HidePanel(object o)
		{
		}

		[Token(Token = "0x6004622")]
		[Address(RVA = "0x4211500", Offset = "0x420D500", VA = "0x4211500", Slot = "12")]
		protected override void OnButtonExtendBGClicked()
		{
		}

		[Token(Token = "0x6004623")]
		[Address(RVA = "0x4211524", Offset = "0x420D524", VA = "0x4211524", Slot = "13")]
		protected override void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x6004624")]
		[Address(RVA = "0x4211548", Offset = "0x420D548", VA = "0x4211548", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004625")]
		[Address(RVA = "0x421164C", Offset = "0x420D64C", VA = "0x421164C")]
		public SpecialOfferGiftPackPanel()
		{
		}
	}
}
