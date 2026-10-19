using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using ToolModule;

namespace GameModule
{
	[Token(Token = "0x200054E")]
	public class PanelPopHandleManager : ManagerBase<PanelPopHandleManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000554")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4002F4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002F50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002F51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PanelPopHandleManager _003C_003E4__this;

			[Token(Token = "0x6001B83")]
			[Address(RVA = "0x3EBD2D8", Offset = "0x3EB92D8", VA = "0x3EBD2D8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001B84")]
			[Address(RVA = "0x3EBD4B8", Offset = "0x3EB94B8", VA = "0x3EBD4B8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002F34")]
		private const int ArenaProgressAnimationWaitSeconds = 3;

		[Token(Token = "0x4002F35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Action climbTiming;

		[Token(Token = "0x4002F36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Action arenaTiming;

		[Token(Token = "0x4002F37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Action levelUpTiming;

		[Token(Token = "0x4002F38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Action allEndTiming;

		[Token(Token = "0x4002F39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int climbTimingTempPriority;

		[Token(Token = "0x4002F3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int arenaTimingTempPriority;

		[Token(Token = "0x4002F3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int levelUpTimingTempPriority;

		[Token(Token = "0x4002F3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int allEndTimingTempPriority;

		[Token(Token = "0x4002F3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<string, int> panelGroupDic;

		[Token(Token = "0x6001B69")]
		[Address(RVA = "0x3EBB524", Offset = "0x3EB7524", VA = "0x3EBB524", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__10))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6001B6A")]
		[Address(RVA = "0x3EBB5A8", Offset = "0x3EB75A8", VA = "0x3EBB5A8")]
		public void GameEndPanelPopHandle()
		{
		}

		[Token(Token = "0x6001B6B")]
		[Address(RVA = "0x3EBBDA0", Offset = "0x3EB7DA0", VA = "0x3EBBDA0")]
		public void MoraleStageTipPanelPopHandle(int moraleNum)
		{
		}

		[Token(Token = "0x6001B6C")]
		[Address(RVA = "0x3EB4E9C", Offset = "0x3EB0E9C", VA = "0x3EB4E9C")]
		public void RegisterPanelPop(GameEndPanelPopType type, Func<bool> showPanel, string panelPath, Func<UniTask> showTask, [Optional] string panelGroupName)
		{
		}

		[Token(Token = "0x6001B6D")]
		[Address(RVA = "0x3EBBD90", Offset = "0x3EB7D90", VA = "0x3EBBD90")]
		private void ResetTempIndex()
		{
		}

		[Token(Token = "0x6001B6E")]
		[Address(RVA = "0x3EBBDAC", Offset = "0x3EB7DAC", VA = "0x3EBBDAC")]
		public void PanelPopPlay()
		{
		}

		[Token(Token = "0x6001B6F")]
		[Address(RVA = "0x3EBBF24", Offset = "0x3EB7F24", VA = "0x3EBBF24")]
		private void ExecuteClimbRankPanelHideLogic()
		{
		}

		[Token(Token = "0x6001B70")]
		[Address(RVA = "0x3EBBF74", Offset = "0x3EB7F74", VA = "0x3EBBF74")]
		public void SpecialShowInterstitialPanel()
		{
		}

		[Token(Token = "0x6001B71")]
		[Address(RVA = "0x3EBC0D8", Offset = "0x3EB80D8", VA = "0x3EBC0D8")]
		public PanelPopHandleManager()
		{
		}
	}
}
