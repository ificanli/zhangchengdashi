using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x200077A")]
	public class BtnShowCardDeck : BtnShowCardDeckComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200077B")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__1 : IAsyncStateMachine
		{
			[Token(Token = "0x4003A5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003A5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003A5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BtnShowCardDeck _003C_003E4__this;

			[Token(Token = "0x4003A5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600291B")]
			[Address(RVA = "0x3FBE828", Offset = "0x3FBA828", VA = "0x3FBE828", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600291C")]
			[Address(RVA = "0x3FBEC28", Offset = "0x3FBAC28", VA = "0x3FBEC28", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200077C")]
		[CompilerGenerated]
		private struct _003CUpdateCardDeckUI_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x4003A5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003A60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003A61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BtnShowCardDeck _003C_003E4__this;

			[Token(Token = "0x4003A62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public object o;

			[Token(Token = "0x4003A63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4003A64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600291D")]
			[Address(RVA = "0x3FBEC34", Offset = "0x3FBAC34", VA = "0x3FBEC34", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600291E")]
			[Address(RVA = "0x3FBF3A4", Offset = "0x3FBB3A4", VA = "0x3FBF3A4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6002915")]
		[Address(RVA = "0x3FBE348", Offset = "0x3FBA348", VA = "0x3FBE348", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002916")]
		[Address(RVA = "0x3FBE440", Offset = "0x3FBA440", VA = "0x3FBE440", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__1))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002917")]
		[Address(RVA = "0x3FBE4D4", Offset = "0x3FBA4D4", VA = "0x3FBE4D4", Slot = "12")]
		protected override void OnButtonExtendBtnShowCardDeckClicked()
		{
		}

		[Token(Token = "0x6002918")]
		[Address(RVA = "0x3FBE6E0", Offset = "0x3FBA6E0", VA = "0x3FBE6E0")]
		[AsyncStateMachine(typeof(_003CUpdateCardDeckUI_003Ed__3))]
		private void UpdateCardDeckUI(object o)
		{
		}

		[Token(Token = "0x6002919")]
		[Address(RVA = "0x3FBE780", Offset = "0x3FBA780", VA = "0x3FBE780")]
		public BtnShowCardDeck()
		{
		}
	}
}
