using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using GameModule;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20008A7")]
	public class SwitchFundBtn : SwitchFundBtnComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008A8")]
		[CompilerGenerated]
		private struct _003CSetBG_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x4004174")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004175")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004176")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SwitchFundBtn _003C_003E4__this;

			[Token(Token = "0x4004177")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public UniTask<Sprite> loadAssetAsync;

			[Token(Token = "0x4004178")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4004179")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60030FF")]
			[Address(RVA = "0x405670C", Offset = "0x405270C", VA = "0x405670C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003100")]
			[Address(RVA = "0x4056A48", Offset = "0x4052A48", VA = "0x4056A48", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008A9")]
		[CompilerGenerated]
		private struct _003CSetIcon_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x400417A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400417B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400417C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SwitchFundBtn _003C_003E4__this;

			[Token(Token = "0x400417D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public UniTask<Sprite> loadAssetAsync;

			[Token(Token = "0x400417E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x400417F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003101")]
			[Address(RVA = "0x4056A54", Offset = "0x4052A54", VA = "0x4056A54", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003102")]
			[Address(RVA = "0x4056DB4", Offset = "0x4052DB4", VA = "0x4056DB4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008AA")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__1 : IAsyncStateMachine
		{
			[Token(Token = "0x4004180")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004181")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004182")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SwitchFundBtn _003C_003E4__this;

			[Token(Token = "0x4004183")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003103")]
			[Address(RVA = "0x4056DC0", Offset = "0x4052DC0", VA = "0x4056DC0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003104")]
			[Address(RVA = "0x40572E0", Offset = "0x40532E0", VA = "0x40572E0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private FundManager.FundType fundType;

		[Token(Token = "0x60030F9")]
		[Address(RVA = "0x4056508", Offset = "0x4052508", VA = "0x4056508", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__1))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60030FA")]
		[Address(RVA = "0x405659C", Offset = "0x405259C", VA = "0x405659C", Slot = "12")]
		protected override void OnButtonExtendSwitchFundBtnClicked()
		{
		}

		[Token(Token = "0x60030FB")]
		[Address(RVA = "0x404FB18", Offset = "0x404BB18", VA = "0x404FB18")]
		[AsyncStateMachine(typeof(_003CSetBG_003Ed__3))]
		public void SetBG(UniTask<Sprite> loadAssetAsync)
		{
		}

		[Token(Token = "0x60030FC")]
		[Address(RVA = "0x404FBC8", Offset = "0x404BBC8", VA = "0x404FBC8")]
		[AsyncStateMachine(typeof(_003CSetIcon_003Ed__4))]
		public void SetIcon(UniTask<Sprite> loadAssetAsync)
		{
		}

		[Token(Token = "0x60030FD")]
		[Address(RVA = "0x4056664", Offset = "0x4052664", VA = "0x4056664")]
		public SwitchFundBtn()
		{
		}
	}
}
