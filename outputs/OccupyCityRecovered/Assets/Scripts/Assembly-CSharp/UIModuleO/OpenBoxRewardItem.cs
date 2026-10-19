using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using GameModule;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000A8C")]
	public class OpenBoxRewardItem : OpenBoxRewardItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A8D")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__1 : IAsyncStateMachine
		{
			[Token(Token = "0x4004DF8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004DF9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004DFA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public OpenBoxRewardItem _003C_003E4__this;

			[Token(Token = "0x4004DFB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public RewardConfigSingle rewardConfig;

			[Token(Token = "0x6003FB6")]
			[Address(RVA = "0x419CC34", Offset = "0x4198C34", VA = "0x419CC34", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003FB7")]
			[Address(RVA = "0x419CE3C", Offset = "0x4198E3C", VA = "0x419CE3C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A8E")]
		[CompilerGenerated]
		private struct _003CShowRewardAnime_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x4004DFC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004DFD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004DFE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public OpenBoxRewardItem _003C_003E4__this;

			[Token(Token = "0x6003FB8")]
			[Address(RVA = "0x419CE48", Offset = "0x4198E48", VA = "0x419CE48", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003FB9")]
			[Address(RVA = "0x419D1A8", Offset = "0x41991A8", VA = "0x419D1A8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004DF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RareLevel rare;

		[Token(Token = "0x6003FB2")]
		[Address(RVA = "0x419C8C4", Offset = "0x41988C4", VA = "0x419C8C4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__1))]
		public void Init(RewardConfigSingle rewardConfig)
		{
		}

		[Token(Token = "0x6003FB3")]
		[Address(RVA = "0x419C960", Offset = "0x4198960", VA = "0x419C960")]
		[AsyncStateMachine(typeof(_003CShowRewardAnime_003Ed__2))]
		public void ShowRewardAnime()
		{
		}

		[Token(Token = "0x6003FB4")]
		[Address(RVA = "0x419C9EC", Offset = "0x41989EC", VA = "0x419C9EC")]
		public void ShowReward()
		{
		}

		[Token(Token = "0x6003FB5")]
		[Address(RVA = "0x419CC24", Offset = "0x4198C24", VA = "0x419CC24")]
		public OpenBoxRewardItem()
		{
		}
	}
}
