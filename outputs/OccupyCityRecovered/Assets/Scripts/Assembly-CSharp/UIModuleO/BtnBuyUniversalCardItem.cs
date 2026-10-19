using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DataModule;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000754")]
	public class BtnBuyUniversalCardItem : BtnBuyUniversalCardItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000756")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x4003993")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003994")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003995")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GlobalShopInfo globalShopInfo;

			[Token(Token = "0x4003996")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public BtnBuyUniversalCardItem _003C_003E4__this;

			[Token(Token = "0x4003997")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<Spine.Unity.SkeletonDataAsset>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002827")]
			[Address(RVA = "0x3FAE93C", Offset = "0x3FAA93C", VA = "0x3FAE93C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002828")]
			[Address(RVA = "0x3FAF370", Offset = "0x3FAB370", VA = "0x3FAF370", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400398C")]
		private const string CommonCard_1 = "CommonCard_1";

		[Token(Token = "0x400398D")]
		private const string CommonCard_2 = "CommonCard_2";

		[Token(Token = "0x400398E")]
		private const string CommonCard_3 = "CommonCard_3";

		[Token(Token = "0x400398F")]
		private const string CommonCard_4 = "CommonCard_4";

		[Token(Token = "0x4003990")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GlobalIAPInfo productIapInfo;

		[Token(Token = "0x4003991")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GlobalShopInfo globalShopInfo;

		[Token(Token = "0x600281E")]
		[Address(RVA = "0x3FAE1D4", Offset = "0x3FAA1D4", VA = "0x3FAE1D4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__6))]
		public void Init(GlobalShopInfo globalShopInfo)
		{
		}

		[Token(Token = "0x600281F")]
		[Address(RVA = "0x3FAE270", Offset = "0x3FAA270", VA = "0x3FAE270")]
		private void UpdatePurchaseLimitation()
		{
		}

		[Token(Token = "0x6002820")]
		[Address(RVA = "0x3FAE524", Offset = "0x3FAA524", VA = "0x3FAE524")]
		private bool IsPurchaseLimitation()
		{
			return default;
		}

		[Token(Token = "0x6002821")]
		[Address(RVA = "0x3FAE548", Offset = "0x3FAA548", VA = "0x3FAE548")]
		private bool IsCanBePurchased()
		{
			return default;
		}

		[Token(Token = "0x6002822")]
		[Address(RVA = "0x3FAE5E8", Offset = "0x3FAA5E8", VA = "0x3FAE5E8", Slot = "12")]
		protected override void OnButtonExtendBtnBuyUniversalCardItemClicked()
		{
		}

		[Token(Token = "0x6002823")]
		[Address(RVA = "0x3FAE7E4", Offset = "0x3FAA7E4", VA = "0x3FAE7E4")]
		public BtnBuyUniversalCardItem()
		{
		}
	}
}
