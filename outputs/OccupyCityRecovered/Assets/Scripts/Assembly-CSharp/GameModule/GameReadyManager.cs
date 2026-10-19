using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BadgeGraph;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using ToolModule;

namespace GameModule
{
	[Token(Token = "0x20004A0")]
	public class GameReadyManager : ManagerBase<GameReadyManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004A1")]
		[CompilerGenerated]
		private struct _003CEndAnimation_003Ed__11 : IAsyncStateMachine
		{
			[Token(Token = "0x4002B96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002B97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002B98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameReadyManager _003C_003E4__this;

			[Token(Token = "0x600171B")]
			[Address(RVA = "0x3E557C0", Offset = "0x3E517C0", VA = "0x3E557C0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600171C")]
			[Address(RVA = "0x3E55A98", Offset = "0x3E51A98", VA = "0x3E55A98", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004A2")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x4002B99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002B9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002B9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameReadyManager _003C_003E4__this;

			[Token(Token = "0x600171D")]
			[Address(RVA = "0x3E55AA4", Offset = "0x3E51AA4", VA = "0x3E55AA4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600171E")]
			[Address(RVA = "0x3E55EF4", Offset = "0x3E51EF4", VA = "0x3E55EF4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002B90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<GlobalSubMetaModuleInfo> _subMetaModuleInfos;

		[Token(Token = "0x4002B91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isAnimation;

		[Token(Token = "0x4002B92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool isCompleteReward;

		[Token(Token = "0x4002B93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public RewardConfig rewardCofig;

		[Token(Token = "0x4002B94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool isVictory;

		[Token(Token = "0x4002B95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ThrottleTrigger redDotThrottleTrigger;

		[Token(Token = "0x6001711")]
		[Address(RVA = "0x3E543AC", Offset = "0x3E503AC", VA = "0x3E543AC", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__6))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6001712")]
		[Address(RVA = "0x3E54430", Offset = "0x3E50430", VA = "0x3E54430")]
		private void CheckRedDot()
		{
		}

		[Token(Token = "0x6001713")]
		[Address(RVA = "0x3E54F08", Offset = "0x3E50F08", VA = "0x3E54F08")]
		private void ShowMainPanel(object obj)
		{
		}

		[Token(Token = "0x6001714")]
		[Address(RVA = "0x3E55070", Offset = "0x3E51070", VA = "0x3E55070")]
		private void HideMainPanel(object obj)
		{
		}

		[Token(Token = "0x6001715")]
		[Address(RVA = "0x3E550DC", Offset = "0x3E510DC", VA = "0x3E550DC")]
		public void DoAnimation(RewardConfig cofig, bool isVictory)
		{
		}

		[Token(Token = "0x6001716")]
		[Address(RVA = "0x3E55170", Offset = "0x3E51170", VA = "0x3E55170")]
		[AsyncStateMachine(typeof(_003CEndAnimation_003Ed__11))]
		public UniTask EndAnimation()
		{
			return default;
		}

		[Token(Token = "0x6001717")]
		[Address(RVA = "0x3E551F4", Offset = "0x3E511F4", VA = "0x3E551F4")]
		private void GetExpReward(object o)
		{
		}

		[Token(Token = "0x6001718")]
		[Address(RVA = "0x3E553F0", Offset = "0x3E513F0", VA = "0x3E553F0")]
		public (int, int) GetBTestExpNumber()
		{
			return default;
		}

		[Token(Token = "0x6001719")]
		[Address(RVA = "0x3E556B8", Offset = "0x3E516B8", VA = "0x3E556B8")]
		public GameReadyManager()
		{
		}
	}
}
