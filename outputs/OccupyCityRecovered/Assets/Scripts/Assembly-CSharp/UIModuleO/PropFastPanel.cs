using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000A9F")]
	public class PropFastPanel : PropFastPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AA3")]
		[CompilerGenerated]
		private struct _003COnButtonExtendBtnReplaceClicked_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4004E56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004E57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004E58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PropFastPanel _003C_003E4__this;

			[Token(Token = "0x4004E59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600402B")]
			[Address(RVA = "0x41A3654", Offset = "0x419F654", VA = "0x41A3654", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600402C")]
			[Address(RVA = "0x41A39F4", Offset = "0x419F9F4", VA = "0x41A39F4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AA4")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__0 : IAsyncStateMachine
		{
			[Token(Token = "0x4004E5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004E5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004E5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PropFastPanel _003C_003E4__this;

			[Token(Token = "0x4004E5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600402D")]
			[Address(RVA = "0x41A3A00", Offset = "0x419FA00", VA = "0x41A3A00", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600402E")]
			[Address(RVA = "0x41A3CF8", Offset = "0x419FCF8", VA = "0x41A3CF8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AA5")]
		[CompilerGenerated]
		private struct _003CUpdatePropTopUI_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x4004E5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004E5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004E60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PropFastPanel _003C_003E4__this;

			[Token(Token = "0x4004E61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UserPropData _003CnowPropData_003E5__2;

			[Token(Token = "0x4004E62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private GlobalPropInfo _003CpropInfo_003E5__3;

			[Token(Token = "0x4004E63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Image _003C_003E7__wrap3;

			[Token(Token = "0x4004E64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600402F")]
			[Address(RVA = "0x41A3D04", Offset = "0x419FD04", VA = "0x41A3D04", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004030")]
			[Address(RVA = "0x41A57E8", Offset = "0x41A17E8", VA = "0x41A57E8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004E51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int UpgradeRequireNum;

		[Token(Token = "0x6004018")]
		[Address(RVA = "0x41A243C", Offset = "0x419E43C", VA = "0x41A243C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__0))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004019")]
		[Address(RVA = "0x41A24D0", Offset = "0x419E4D0", VA = "0x41A24D0")]
		private void HidePanel(object o)
		{
		}

		[Token(Token = "0x600401A")]
		[Address(RVA = "0x41A24DC", Offset = "0x419E4DC", VA = "0x41A24DC", Slot = "12")]
		protected override void OnButtonBtnCloseBgClicked()
		{
		}

		[Token(Token = "0x600401B")]
		[Address(RVA = "0x41A2568", Offset = "0x419E568", VA = "0x41A2568", Slot = "14")]
		protected override void OnButtonExtendBtnUpgradeClicked()
		{
		}

		[Token(Token = "0x600401C")]
		[Address(RVA = "0x41A2E50", Offset = "0x419EE50", VA = "0x41A2E50", Slot = "13")]
		[AsyncStateMachine(typeof(_003COnButtonExtendBtnReplaceClicked_003Ed__5))]
		protected override void OnButtonExtendBtnReplaceClicked()
		{
		}

		[Token(Token = "0x600401D")]
		[Address(RVA = "0x41A2DC0", Offset = "0x419EDC0", VA = "0x41A2DC0")]
		[AsyncStateMachine(typeof(_003CUpdatePropTopUI_003Ed__6))]
		private void UpdatePropTopUI()
		{
		}

		[Token(Token = "0x600401E")]
		[Address(RVA = "0x41A2EDC", Offset = "0x419EEDC", VA = "0x41A2EDC")]
		private void UpdateUpgradePropBtnActive()
		{
		}

		[Token(Token = "0x600401F")]
		[Address(RVA = "0x41A30FC", Offset = "0x419F0FC", VA = "0x41A30FC", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004020")]
		[Address(RVA = "0x41A3358", Offset = "0x419F358", VA = "0x41A3358")]
		public PropFastPanel()
		{
		}
	}
}
