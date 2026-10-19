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
	[Token(Token = "0x2000869")]
	public class ElitePackGiftPackPanel : ElitePackGiftPackPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200086A")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4003FAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003FAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003FB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ElitePackGiftPackPanel _003C_003E4__this;

			[Token(Token = "0x4003FB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002F49")]
			[Address(RVA = "0x402DCA0", Offset = "0x4029CA0", VA = "0x402DCA0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002F4A")]
			[Address(RVA = "0x402E1C0", Offset = "0x402A1C0", VA = "0x402E1C0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003FAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<RewardItemUI> allRewardItem;

		[Token(Token = "0x4003FAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public GlobalIAPInfo iapInfo;

		[Token(Token = "0x4003FAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private string _placement;

		[Token(Token = "0x6002F3D")]
		[Address(RVA = "0x402CFFC", Offset = "0x4028FFC", VA = "0x402CFFC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002F3E")]
		[Address(RVA = "0x402D140", Offset = "0x4029140", VA = "0x402D140", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__4))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002F3F")]
		[Address(RVA = "0x402D1D4", Offset = "0x40291D4", VA = "0x402D1D4")]
		private void Update()
		{
		}

		[Token(Token = "0x6002F40")]
		[Address(RVA = "0x402D31C", Offset = "0x402931C", VA = "0x402D31C")]
		public void InitIAPBtn()
		{
		}

		[Token(Token = "0x6002F41")]
		[Address(RVA = "0x402D418", Offset = "0x4029418", VA = "0x402D418", Slot = "9")]
		public override void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x6002F42")]
		[Address(RVA = "0x402D738", Offset = "0x4029738", VA = "0x402D738")]
		private void HidePanel(object o)
		{
		}

		[Token(Token = "0x6002F43")]
		[Address(RVA = "0x402D7C0", Offset = "0x40297C0", VA = "0x402D7C0", Slot = "12")]
		protected override void OnButtonExtendBGClicked()
		{
		}

		[Token(Token = "0x6002F44")]
		[Address(RVA = "0x402D84C", Offset = "0x402984C", VA = "0x402D84C", Slot = "13")]
		protected override void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x6002F45")]
		[Address(RVA = "0x402D8D8", Offset = "0x40298D8", VA = "0x402D8D8", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002F46")]
		[Address(RVA = "0x402DAA0", Offset = "0x4029AA0", VA = "0x402DAA0")]
		public ElitePackGiftPackPanel()
		{
		}
	}
}
