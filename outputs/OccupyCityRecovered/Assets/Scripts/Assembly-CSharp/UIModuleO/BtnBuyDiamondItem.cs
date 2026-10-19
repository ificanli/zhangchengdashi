using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DataModule;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000B1E")]
	public class BtnBuyDiamondItem : BtnBuyDiamondItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B20")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x4005140")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005141")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005142")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GlobalShopInfo shopInfo;

			[Token(Token = "0x4005143")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public BtnBuyDiamondItem _003C_003E4__this;

			[Token(Token = "0x4005144")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4005145")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60043A3")]
			[Address(RVA = "0x41DFD64", Offset = "0x41DBD64", VA = "0x41DFD64", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60043A4")]
			[Address(RVA = "0x41E09E0", Offset = "0x41DC9E0", VA = "0x41E09E0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400513C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool isFirstRecharge;

		[Token(Token = "0x400513D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private GlobalShopInfo shopInfo;

		[Token(Token = "0x400513E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float lastTriggerPurchaseProductTime;

		[Token(Token = "0x6004399")]
		[Address(RVA = "0x41DF5D8", Offset = "0x41DB5D8", VA = "0x41DF5D8")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__2))]
		public void Init(GlobalShopInfo shopInfo)
		{
		}

		[Token(Token = "0x600439A")]
		[Address(RVA = "0x41DF678", Offset = "0x41DB678", VA = "0x41DF678", Slot = "12")]
		protected override void OnButtonExtendBtnBuyDiamondItemClicked()
		{
		}

		[Token(Token = "0x600439B")]
		[Address(RVA = "0x41DF8C8", Offset = "0x41DB8C8", VA = "0x41DF8C8")]
		private void ShowDoubleReward(object o)
		{
		}

		[Token(Token = "0x600439C")]
		[Address(RVA = "0x41DFAA4", Offset = "0x41DBAA4", VA = "0x41DFAA4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600439D")]
		[Address(RVA = "0x41DFB6C", Offset = "0x41DBB6C", VA = "0x41DFB6C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600439E")]
		[Address(RVA = "0x41DFC34", Offset = "0x41DBC34", VA = "0x41DFC34")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600439F")]
		[Address(RVA = "0x41DFCFC", Offset = "0x41DBCFC", VA = "0x41DFCFC")]
		public BtnBuyDiamondItem()
		{
		}
	}
}
