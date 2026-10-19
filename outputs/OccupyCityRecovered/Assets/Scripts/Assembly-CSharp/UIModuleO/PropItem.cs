using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using DataModule;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000AA8")]
	public class PropItem : PropItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AA9")]
		[CompilerGenerated]
		private struct _003CCardPanelPropShow_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x4004E7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004E7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004E7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PropItem _003C_003E4__this;

			[Token(Token = "0x6004057")]
			[Address(RVA = "0x41A6778", Offset = "0x41A2778", VA = "0x41A6778", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004058")]
			[Address(RVA = "0x41A6BE8", Offset = "0x41A2BE8", VA = "0x41A6BE8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AAA")]
		[CompilerGenerated]
		private struct _003CUpdateUI_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4004E7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004E7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004E7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PropItem _003C_003E4__this;

			[Token(Token = "0x4004E80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool refreshLight;

			[Token(Token = "0x4004E81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private GlobalPropInfo _003Cinfo_003E5__2;

			[Token(Token = "0x4004E82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Image _003C_003E7__wrap2;

			[Token(Token = "0x4004E83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004059")]
			[Address(RVA = "0x41A6BF4", Offset = "0x41A2BF4", VA = "0x41A6BF4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600405A")]
			[Address(RVA = "0x41A7FD0", Offset = "0x41A3FD0", VA = "0x41A7FD0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004E78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private UserPropData _data;

		[Token(Token = "0x4004E79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Sequence _se;

		[Token(Token = "0x600404B")]
		[Address(RVA = "0x41A5D44", Offset = "0x41A1D44", VA = "0x41A5D44", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600404C")]
		[Address(RVA = "0x41A5FF4", Offset = "0x41A1FF4", VA = "0x41A5FF4", Slot = "12")]
		protected override void OnButtonExtendPropItemClicked()
		{
		}

		[Token(Token = "0x600404D")]
		[Address(RVA = "0x41A60DC", Offset = "0x41A20DC", VA = "0x41A60DC", Slot = "9")]
		public override void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x600404E")]
		[Address(RVA = "0x41A618C", Offset = "0x41A218C", VA = "0x41A618C")]
		[AsyncStateMachine(typeof(_003CUpdateUI_003Ed__5))]
		public void UpdateUI(bool refreshLight = true)
		{
		}

		[Token(Token = "0x600404F")]
		[Address(RVA = "0x41A6230", Offset = "0x41A2230", VA = "0x41A6230")]
		private void UpdateSomeThingPropItemUI(object o)
		{
		}

		[Token(Token = "0x6004050")]
		[Address(RVA = "0x41A6294", Offset = "0x41A2294", VA = "0x41A6294")]
		[AsyncStateMachine(typeof(_003CCardPanelPropShow_003Ed__7))]
		private void CardPanelPropShow(object o)
		{
		}

		[Token(Token = "0x6004051")]
		[Address(RVA = "0x41A6320", Offset = "0x41A2320", VA = "0x41A6320")]
		private void UpdateLight(object o)
		{
		}

		[Token(Token = "0x6004052")]
		[Address(RVA = "0x41A6454", Offset = "0x41A2454", VA = "0x41A6454")]
		private void PropHideLight(object o)
		{
		}

		[Token(Token = "0x6004053")]
		[Address(RVA = "0x41A6480", Offset = "0x41A2480", VA = "0x41A6480")]
		private void CardPanelUnitsShow(object o)
		{
		}

		[Token(Token = "0x6004054")]
		[Address(RVA = "0x41A64A8", Offset = "0x41A24A8", VA = "0x41A64A8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6004055")]
		[Address(RVA = "0x41A6740", Offset = "0x41A2740", VA = "0x41A6740")]
		public PropItem()
		{
		}
	}
}
