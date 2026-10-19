using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000B39")]
	public class BuyResCardTwoSurePanel : BuyResCardTwoSurePanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B3A")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x40051DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40051DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40051DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BuyResCardTwoSurePanel _003C_003E4__this;

			[Token(Token = "0x40051DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x40051DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x40051E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x40051E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6004476")]
			[Address(RVA = "0x41ECF1C", Offset = "0x41E8F1C", VA = "0x41ECF1C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004477")]
			[Address(RVA = "0x41EEC60", Offset = "0x41EAC60", VA = "0x41EEC60", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40051D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private UserDailyShopCardData data;

		[Token(Token = "0x40051D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private GlobalShopInfo shopInfo;

		[Token(Token = "0x40051D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private GameObject obj;

		[Token(Token = "0x40051D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool isCard;

		[Token(Token = "0x40051DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private string cofig;

		[Token(Token = "0x600446D")]
		[Address(RVA = "0x41EBEB4", Offset = "0x41E7EB4", VA = "0x41EBEB4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600446E")]
		[Address(RVA = "0x41EBFCC", Offset = "0x41E7FCC", VA = "0x41EBFCC", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__6))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600446F")]
		[Address(RVA = "0x41EC068", Offset = "0x41E8068", VA = "0x41EC068", Slot = "13")]
		protected override void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x6004470")]
		[Address(RVA = "0x41EC0F4", Offset = "0x41E80F4", VA = "0x41EC0F4", Slot = "14")]
		protected override void OnButtonExtendBtnBuyClicked()
		{
		}

		[Token(Token = "0x6004471")]
		[Address(RVA = "0x41ECB10", Offset = "0x41E8B10", VA = "0x41ECB10", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004472")]
		[Address(RVA = "0x41ECBD4", Offset = "0x41E8BD4", VA = "0x41ECBD4", Slot = "12")]
		protected override void OnButtonBGClicked()
		{
		}

		[Token(Token = "0x6004473")]
		[Address(RVA = "0x41ECC60", Offset = "0x41E8C60", VA = "0x41ECC60")]
		private static string GetShopResIconSpritePath(GlobalShopInfo shopInfo)
		{
			return null;
		}

		[Token(Token = "0x6004474")]
		[Address(RVA = "0x41ECE74", Offset = "0x41E8E74", VA = "0x41ECE74")]
		public BuyResCardTwoSurePanel()
		{
		}
	}
}
