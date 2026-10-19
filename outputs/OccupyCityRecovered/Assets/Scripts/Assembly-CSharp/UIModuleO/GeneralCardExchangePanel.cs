using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x20008D1")]
	public class GeneralCardExchangePanel : GeneralCardExchangePanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008D2")]
		[CompilerGenerated]
		private struct _003COnButtonExtendAffirmBtnClicked_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x40042D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40042D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40042DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GeneralCardExchangePanel _003C_003E4__this;

			[Token(Token = "0x40042DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<UIFramework.UIPanel>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x40042DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x60032AF")]
			[Address(RVA = "0x4074558", Offset = "0x4070558", VA = "0x4074558", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60032B0")]
			[Address(RVA = "0x4074C64", Offset = "0x4070C64", VA = "0x4074C64", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008D3")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x40042DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40042DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40042DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GeneralCardExchangePanel _003C_003E4__this;

			[Token(Token = "0x40042E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60032B1")]
			[Address(RVA = "0x4074C70", Offset = "0x4070C70", VA = "0x4074C70", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60032B2")]
			[Address(RVA = "0x4075078", Offset = "0x4071078", VA = "0x4075078", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008D4")]
		[CompilerGenerated]
		private struct _003CUpdateView_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x40042E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40042E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40042E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GeneralCardExchangePanel _003C_003E4__this;

			[Token(Token = "0x40042E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60032B3")]
			[Address(RVA = "0x4075084", Offset = "0x4071084", VA = "0x4075084", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60032B4")]
			[Address(RVA = "0x4075AEC", Offset = "0x4071AEC", VA = "0x4075AEC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40042D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private UserHeroCardData data;

		[Token(Token = "0x40042D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int consumeNumber;

		[Token(Token = "0x60032A5")]
		[Address(RVA = "0x4073F94", Offset = "0x406FF94", VA = "0x4073F94", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60032A6")]
		[Address(RVA = "0x40740AC", Offset = "0x40700AC", VA = "0x40740AC", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__3))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60032A7")]
		[Address(RVA = "0x4074140", Offset = "0x4070140", VA = "0x4074140")]
		[AsyncStateMachine(typeof(_003CUpdateView_003Ed__4))]
		private void UpdateView()
		{
		}

		[Token(Token = "0x60032A8")]
		[Address(RVA = "0x40741D0", Offset = "0x40701D0", VA = "0x40741D0", Slot = "12")]
		protected override void OnButtonBackgroundClicked()
		{
		}

		[Token(Token = "0x60032A9")]
		[Address(RVA = "0x407425C", Offset = "0x407025C", VA = "0x407425C", Slot = "13")]
		protected override void OnButtonExtendCloseClicked()
		{
		}

		[Token(Token = "0x60032AA")]
		[Address(RVA = "0x40742E8", Offset = "0x40702E8", VA = "0x40742E8", Slot = "15")]
		[AsyncStateMachine(typeof(_003COnButtonExtendAffirmBtnClicked_003Ed__7))]
		protected override void OnButtonExtendAffirmBtnClicked()
		{
		}

		[Token(Token = "0x60032AB")]
		[Address(RVA = "0x407437C", Offset = "0x407037C", VA = "0x407437C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60032AC")]
		[Address(RVA = "0x4074440", Offset = "0x4070440", VA = "0x4074440")]
		public GeneralCardExchangePanel()
		{
		}
	}
}
