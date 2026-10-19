using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x200077F")]
	public class BtnShowProp : BtnShowPropComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000780")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__1 : IAsyncStateMachine
		{
			[Token(Token = "0x4003A6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003A6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003A6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BtnShowProp _003C_003E4__this;

			[Token(Token = "0x4003A70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002932")]
			[Address(RVA = "0x3FBFCE8", Offset = "0x3FBBCE8", VA = "0x3FBFCE8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002933")]
			[Address(RVA = "0x3FC02A0", Offset = "0x3FBC2A0", VA = "0x3FC02A0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000781")]
		[CompilerGenerated]
		private struct _003CUpdatePropUI_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x4003A71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003A72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003A73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BtnShowProp _003C_003E4__this;

			[Token(Token = "0x4003A74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public object o;

			[Token(Token = "0x4003A75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4003A76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002934")]
			[Address(RVA = "0x3FC02AC", Offset = "0x3FBC2AC", VA = "0x3FC02AC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002935")]
			[Address(RVA = "0x3FC0724", Offset = "0x3FBC724", VA = "0x3FC0724", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x600292C")]
		[Address(RVA = "0x3FBF81C", Offset = "0x3FBB81C", VA = "0x3FBF81C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600292D")]
		[Address(RVA = "0x3FBF914", Offset = "0x3FBB914", VA = "0x3FBF914", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__1))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600292E")]
		[Address(RVA = "0x3FBF9A8", Offset = "0x3FBB9A8", VA = "0x3FBF9A8", Slot = "12")]
		protected override void OnButtonExtendBtnShowPropClicked()
		{
		}

		[Token(Token = "0x600292F")]
		[Address(RVA = "0x3FBFBA0", Offset = "0x3FBBBA0", VA = "0x3FBFBA0")]
		[AsyncStateMachine(typeof(_003CUpdatePropUI_003Ed__3))]
		private void UpdatePropUI(object o)
		{
		}

		[Token(Token = "0x6002930")]
		[Address(RVA = "0x3FBFC40", Offset = "0x3FBBC40", VA = "0x3FBFC40")]
		public BtnShowProp()
		{
		}
	}
}
