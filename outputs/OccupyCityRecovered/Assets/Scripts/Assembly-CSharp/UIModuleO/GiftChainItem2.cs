using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x20008E2")]
	public class GiftChainItem2 : GiftChainItem2Components
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008E3")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x4004340")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004341")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004342")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GiftChainItem2 _003C_003E4__this;

			[Token(Token = "0x4004343")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003321")]
			[Address(RVA = "0x40955D8", Offset = "0x40915D8", VA = "0x40955D8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003322")]
			[Address(RVA = "0x40959AC", Offset = "0x40919AC", VA = "0x40959AC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400433B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int buyLevel;

		[Token(Token = "0x400433C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private string rewardStr;

		[Token(Token = "0x400433D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private string iapId;

		[Token(Token = "0x400433E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private GlobalGiftChainInfo2 info;

		[Token(Token = "0x400433F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private string _placement;

		[Token(Token = "0x6003319")]
		[Address(RVA = "0x4093544", Offset = "0x408F544", VA = "0x4093544", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600331A")]
		[Address(RVA = "0x409363C", Offset = "0x408F63C", VA = "0x409363C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__6))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600331B")]
		[Address(RVA = "0x40936D0", Offset = "0x408F6D0", VA = "0x40936D0", Slot = "9")]
		public override void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x600331C")]
		[Address(RVA = "0x4094A2C", Offset = "0x4090A2C", VA = "0x4094A2C")]
		private void RefreshGiftChainBuyLevel(object o)
		{
		}

		[Token(Token = "0x600331D")]
		[Address(RVA = "0x4093FD0", Offset = "0x408FFD0", VA = "0x4093FD0")]
		private void UpdateUI()
		{
		}

		[Token(Token = "0x600331E")]
		[Address(RVA = "0x40953C4", Offset = "0x40913C4", VA = "0x40953C4", Slot = "12")]
		protected override void OnButtonExtendBuyClicked()
		{
		}

		[Token(Token = "0x600331F")]
		[Address(RVA = "0x40954E8", Offset = "0x40914E8", VA = "0x40954E8")]
		public GiftChainItem2()
		{
		}
	}
}
