using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000B17")]
	public class BtnBuyCoinItem : BtnBuyCoinItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B19")]
		[CompilerGenerated]
		private struct _003CCheckAnimation_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x400511D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400511E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400511F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BtnBuyCoinItem _003C_003E4__this;

			[Token(Token = "0x600437B")]
			[Address(RVA = "0x41DD37C", Offset = "0x41D937C", VA = "0x41DD37C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600437C")]
			[Address(RVA = "0x41DD79C", Offset = "0x41D979C", VA = "0x41DD79C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B1A")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4005120")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005121")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005122")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BtnBuyCoinItem _003C_003E4__this;

			[Token(Token = "0x4005123")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GlobalShopInfo shopInfo;

			[Token(Token = "0x4005124")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isMostExpensive;

			[Token(Token = "0x4005125")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4005126")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600437D")]
			[Address(RVA = "0x41DD7A8", Offset = "0x41D97A8", VA = "0x41DD7A8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600437E")]
			[Address(RVA = "0x41DE810", Offset = "0x41DA810", VA = "0x41DE810", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B1B")]
		[CompilerGenerated]
		private struct _003CUpdateUI_FreeItem_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x4005127")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005128")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005129")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BtnBuyCoinItem _003C_003E4__this;

			[Token(Token = "0x600437F")]
			[Address(RVA = "0x41DE81C", Offset = "0x41DA81C", VA = "0x41DE81C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004380")]
			[Address(RVA = "0x41DEFF8", Offset = "0x41DAFF8", VA = "0x41DEFF8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private GlobalShopInfo shopInfo;

		[Token(Token = "0x4005118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int rewardCount;

		[Token(Token = "0x4005119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private string light;

		[Token(Token = "0x400511A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private GameObject lightObj;

		[Token(Token = "0x600436F")]
		[Address(RVA = "0x41DC8E8", Offset = "0x41D88E8", VA = "0x41DC8E8")]
		public void UpdateInfo()
		{
		}

		[Token(Token = "0x6004370")]
		[Address(RVA = "0x41DC8F4", Offset = "0x41D88F4", VA = "0x41DC8F4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__5))]
		public void Init(GlobalShopInfo shopInfo, bool isMostExpensive = false)
		{
		}

		[Token(Token = "0x6004371")]
		[Address(RVA = "0x41DC99C", Offset = "0x41D899C", VA = "0x41DC99C")]
		[AsyncStateMachine(typeof(_003CCheckAnimation_003Ed__6))]
		private void CheckAnimation()
		{
		}

		[Token(Token = "0x6004372")]
		[Address(RVA = "0x41DCA28", Offset = "0x41D8A28", VA = "0x41DCA28")]
		[AsyncStateMachine(typeof(_003CUpdateUI_FreeItem_003Ed__7))]
		private void UpdateUI_FreeItem()
		{
		}

		[Token(Token = "0x6004373")]
		[Address(RVA = "0x41DCAB4", Offset = "0x41D8AB4", VA = "0x41DCAB4", Slot = "12")]
		protected override void OnButtonExtendBtnBuyCoinItemClicked()
		{
		}

		[Token(Token = "0x6004374")]
		[Address(RVA = "0x41DCD48", Offset = "0x41D8D48", VA = "0x41DCD48")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6004375")]
		[Address(RVA = "0x41DCE1C", Offset = "0x41D8E1C", VA = "0x41DCE1C")]
		private void AdCallBack()
		{
		}

		[Token(Token = "0x6004376")]
		[Address(RVA = "0x41DD1C0", Offset = "0x41D91C0", VA = "0x41DD1C0")]
		private void TimeToZeroRefreshFreeResUI(object o)
		{
		}

		[Token(Token = "0x6004377")]
		[Address(RVA = "0x41DD250", Offset = "0x41D9250", VA = "0x41DD250")]
		public BtnBuyCoinItem()
		{
		}
	}
}
