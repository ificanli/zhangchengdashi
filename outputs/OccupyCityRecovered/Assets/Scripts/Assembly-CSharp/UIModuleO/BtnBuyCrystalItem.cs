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
	[Token(Token = "0x200074F")]
	public class BtnBuyCrystalItem : BtnBuyCrystalItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000751")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4003973")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003974")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003975")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BtnBuyCrystalItem _003C_003E4__this;

			[Token(Token = "0x4003976")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GlobalShopInfo shopInfo;

			[Token(Token = "0x4003977")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isMostExpensive;

			[Token(Token = "0x4003978")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4003979")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002804")]
			[Address(RVA = "0x3FACFA8", Offset = "0x3FA8FA8", VA = "0x3FACFA8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002805")]
			[Address(RVA = "0x3FADBF4", Offset = "0x3FA9BF4", VA = "0x3FADBF4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400396D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private GlobalShopInfo shopInfo;

		[Token(Token = "0x400396E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private string light;

		[Token(Token = "0x400396F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private GameObject lightObj;

		[Token(Token = "0x4003970")]
		private const int AdRewardCount = 25;

		[Token(Token = "0x60027F9")]
		[Address(RVA = "0x3FABBB4", Offset = "0x3FA7BB4", VA = "0x3FABBB4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__4))]
		public void Init(GlobalShopInfo shopInfo, bool isMostExpensive = false)
		{
		}

		[Token(Token = "0x60027FA")]
		[Address(RVA = "0x3FABC5C", Offset = "0x3FA7C5C", VA = "0x3FABC5C")]
		private void UpdateUI()
		{
		}

		[Token(Token = "0x60027FB")]
		[Address(RVA = "0x3FAC438", Offset = "0x3FA8438", VA = "0x3FAC438")]
		private void CheckAnimation()
		{
		}

		[Token(Token = "0x60027FC")]
		[Address(RVA = "0x3FAC700", Offset = "0x3FA8700", VA = "0x3FAC700", Slot = "12")]
		protected override void OnButtonExtendBtnBuyCrystalItemClicked()
		{
		}

		[Token(Token = "0x60027FD")]
		[Address(RVA = "0x3FAC97C", Offset = "0x3FA897C", VA = "0x3FAC97C")]
		private void AdCallBack()
		{
		}

		[Token(Token = "0x60027FE")]
		[Address(RVA = "0x3FACD18", Offset = "0x3FA8D18", VA = "0x3FACD18")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60027FF")]
		[Address(RVA = "0x3FACDEC", Offset = "0x3FA8DEC", VA = "0x3FACDEC")]
		private void TimeToZeroRefreshFreeResUI(object o)
		{
		}

		[Token(Token = "0x6002800")]
		[Address(RVA = "0x3FACE7C", Offset = "0x3FA8E7C", VA = "0x3FACE7C")]
		public BtnBuyCrystalItem()
		{
		}
	}
}
