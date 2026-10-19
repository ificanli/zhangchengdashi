using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000788")]
	public class BuyBoxSlotPanel : BuyBoxSlotPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200078B")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x4003A99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003A9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003A9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BuyBoxSlotPanel _003C_003E4__this;

			[Token(Token = "0x4003A9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600296F")]
			[Address(RVA = "0x3FC3AB0", Offset = "0x3FBFAB0", VA = "0x3FC3AB0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002970")]
			[Address(RVA = "0x3FC4180", Offset = "0x3FC0180", VA = "0x3FC4180", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003A95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string _productId;

		[Token(Token = "0x4003A96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private string _placement;

		[Token(Token = "0x6002962")]
		[Address(RVA = "0x3FC32C0", Offset = "0x3FBF2C0", VA = "0x3FC32C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002963")]
		[Address(RVA = "0x3FC3418", Offset = "0x3FBF418", VA = "0x3FC3418", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__3))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002964")]
		[Address(RVA = "0x3FC34AC", Offset = "0x3FBF4AC", VA = "0x3FC34AC")]
		private void OnPurchaseSuccess(object o)
		{
		}

		[Token(Token = "0x6002965")]
		[Address(RVA = "0x3FC34B8", Offset = "0x3FBF4B8", VA = "0x3FC34B8")]
		private void InitIAPButton(string productId)
		{
		}

		[Token(Token = "0x6002966")]
		[Address(RVA = "0x3FC3730", Offset = "0x3FBF730", VA = "0x3FC3730", Slot = "13")]
		protected override void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x6002967")]
		[Address(RVA = "0x3FC37BC", Offset = "0x3FBF7BC", VA = "0x3FC37BC", Slot = "12")]
		protected override void OnButtonExtendBGClicked()
		{
		}

		[Token(Token = "0x6002968")]
		[Address(RVA = "0x3FC3848", Offset = "0x3FBF848", VA = "0x3FC3848")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6002969")]
		[Address(RVA = "0x3FC3970", Offset = "0x3FBF970", VA = "0x3FC3970")]
		public BuyBoxSlotPanel()
		{
		}
	}
}
