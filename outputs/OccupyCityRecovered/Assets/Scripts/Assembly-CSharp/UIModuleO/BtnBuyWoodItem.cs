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
	[Token(Token = "0x2000B23")]
	public class BtnBuyWoodItem : BtnBuyWoodItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B25")]
		[CompilerGenerated]
		private struct _003CCheckAnimation_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4005156")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005157")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005158")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BtnBuyWoodItem _003C_003E4__this;

			[Token(Token = "0x60043C0")]
			[Address(RVA = "0x41E17FC", Offset = "0x41DD7FC", VA = "0x41E17FC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60043C1")]
			[Address(RVA = "0x41E1A84", Offset = "0x41DDA84", VA = "0x41E1A84", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B26")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x4005159")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400515A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400515B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BtnBuyWoodItem _003C_003E4__this;

			[Token(Token = "0x400515C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GlobalShopInfo shopInfo;

			[Token(Token = "0x400515D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isMostExpensive;

			[Token(Token = "0x400515E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x400515F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60043C2")]
			[Address(RVA = "0x41E1A90", Offset = "0x41DDA90", VA = "0x41E1A90", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60043C3")]
			[Address(RVA = "0x41E23E0", Offset = "0x41DE3E0", VA = "0x41E23E0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B27")]
		[CompilerGenerated]
		private struct _003CUpdateUI_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4005160")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005161")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005162")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BtnBuyWoodItem _003C_003E4__this;

			[Token(Token = "0x60043C4")]
			[Address(RVA = "0x41E23EC", Offset = "0x41DE3EC", VA = "0x41E23EC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60043C5")]
			[Address(RVA = "0x41E2D7C", Offset = "0x41DED7C", VA = "0x41E2D7C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private GlobalShopInfo shopInfo;

		[Token(Token = "0x4005152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private string light;

		[Token(Token = "0x4005153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private GameObject lightObj;

		[Token(Token = "0x60043B5")]
		[Address(RVA = "0x41E0F08", Offset = "0x41DCF08", VA = "0x41E0F08")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__3))]
		public void Init(GlobalShopInfo shopInfo, bool isMostExpensive = false)
		{
		}

		[Token(Token = "0x60043B6")]
		[Address(RVA = "0x41E0FB0", Offset = "0x41DCFB0", VA = "0x41E0FB0")]
		[AsyncStateMachine(typeof(_003CUpdateUI_003Ed__4))]
		private void UpdateUI()
		{
		}

		[Token(Token = "0x60043B7")]
		[Address(RVA = "0x41E103C", Offset = "0x41DD03C", VA = "0x41E103C")]
		[AsyncStateMachine(typeof(_003CCheckAnimation_003Ed__5))]
		private void CheckAnimation()
		{
		}

		[Token(Token = "0x60043B8")]
		[Address(RVA = "0x41E10C8", Offset = "0x41DD0C8", VA = "0x41E10C8", Slot = "12")]
		protected override void OnButtonExtendBtnBuyWoodItemClicked()
		{
		}

		[Token(Token = "0x60043B9")]
		[Address(RVA = "0x41E12E0", Offset = "0x41DD2E0", VA = "0x41E12E0")]
		private void AdCallBack()
		{
		}

		[Token(Token = "0x60043BA")]
		[Address(RVA = "0x41E1570", Offset = "0x41DD570", VA = "0x41E1570")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60043BB")]
		[Address(RVA = "0x41E1644", Offset = "0x41DD644", VA = "0x41E1644")]
		private void TimeToZeroRefreshFreeResUI(object o)
		{
		}

		[Token(Token = "0x60043BC")]
		[Address(RVA = "0x41E16D8", Offset = "0x41DD6D8", VA = "0x41E16D8")]
		public BtnBuyWoodItem()
		{
		}
	}
}
