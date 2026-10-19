using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x200084C")]
	public class ConfirmPanel : ConfirmPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200084D")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__1 : IAsyncStateMachine
		{
			[Token(Token = "0x4003F2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003F2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003F2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ConfirmPanel _003C_003E4__this;

			[Token(Token = "0x4003F2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002EB3")]
			[Address(RVA = "0x40247A0", Offset = "0x40207A0", VA = "0x40247A0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002EB4")]
			[Address(RVA = "0x4024EEC", Offset = "0x4020EEC", VA = "0x4024EEC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003F2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Action<bool> onClick;

		[Token(Token = "0x6002EAE")]
		[Address(RVA = "0x4024514", Offset = "0x4020514", VA = "0x4024514", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__1))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002EAF")]
		[Address(RVA = "0x40245A8", Offset = "0x40205A8", VA = "0x40245A8", Slot = "12")]
		protected override void OnButtonExtendBlackClicked()
		{
		}

		[Token(Token = "0x6002EB0")]
		[Address(RVA = "0x4024650", Offset = "0x4020650", VA = "0x4024650", Slot = "13")]
		protected override void OnButtonExtendDoneBtnClicked()
		{
		}

		[Token(Token = "0x6002EB1")]
		[Address(RVA = "0x40246F8", Offset = "0x40206F8", VA = "0x40246F8")]
		public ConfirmPanel()
		{
		}
	}
}
