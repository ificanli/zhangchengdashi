using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using TimeModuleO;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20006AC")]
	public class ArenaGiftPackPanel : ArenaGiftPackPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006AD")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x400356B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400356C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400356D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArenaGiftPackPanel _003C_003E4__this;

			[Token(Token = "0x400356E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x400356F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4003570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002359")]
			[Address(RVA = "0x3F4472C", Offset = "0x3F4072C", VA = "0x3F4472C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600235A")]
			[Address(RVA = "0x3F45958", Offset = "0x3F41958", VA = "0x3F45958", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _elapsed;

		[Token(Token = "0x4003566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private ShopArenaPackInfos _config;

		[Token(Token = "0x4003567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private ArenaPackageData _data;

		[Token(Token = "0x4003568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private GlobalIAPInfo iapInfo;

		[Token(Token = "0x4003569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private string _placement;

		[Token(Token = "0x400356A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private TimeManager.Timer _timer;

		[Token(Token = "0x6002350")]
		[Address(RVA = "0x3F43FB8", Offset = "0x3F3FFB8", VA = "0x3F43FB8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002351")]
		[Address(RVA = "0x3F440D0", Offset = "0x3F400D0", VA = "0x3F440D0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__7))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002352")]
		[Address(RVA = "0x3F4416C", Offset = "0x3F4016C", VA = "0x3F4416C")]
		private void Update()
		{
		}

		[Token(Token = "0x6002353")]
		[Address(RVA = "0x3F44364", Offset = "0x3F40364", VA = "0x3F44364")]
		private void PurchaseCallBack(bool result)
		{
		}

		[Token(Token = "0x6002354")]
		[Address(RVA = "0x3F443F8", Offset = "0x3F403F8", VA = "0x3F443F8", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002355")]
		[Address(RVA = "0x3F4451C", Offset = "0x3F4051C", VA = "0x3F4451C", Slot = "12")]
		protected override void OnButtonBackgroundClicked()
		{
		}

		[Token(Token = "0x6002356")]
		[Address(RVA = "0x3F445A8", Offset = "0x3F405A8", VA = "0x3F445A8", Slot = "13")]
		protected override void OnButtonExtendCloseClicked()
		{
		}

		[Token(Token = "0x6002357")]
		[Address(RVA = "0x3F44634", Offset = "0x3F40634", VA = "0x3F44634")]
		public ArenaGiftPackPanel()
		{
		}
	}
}
