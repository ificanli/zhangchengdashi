using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using ToolModule;
using UIFramework;

namespace GameModule
{
	[Token(Token = "0x2000474")]
	public class ArenaProgressManager : ManagerBase<ArenaProgressManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000476")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4002AF7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002AF8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002AF9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArenaProgressManager _003C_003E4__this;

			[Token(Token = "0x4002AFA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4002AFB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<UIPanel>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x60015E5")]
			[Address(RVA = "0x3E21C70", Offset = "0x3E1DC70", VA = "0x3E21C70", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60015E6")]
			[Address(RVA = "0x3E22BB8", Offset = "0x3E1EBB8", VA = "0x3E22BB8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000477")]
		[CompilerGenerated]
		private struct _003CShowArenaProgressPanel_003Ed__15 : IAsyncStateMachine
		{
			[Token(Token = "0x4002AFC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002AFD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002AFE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArenaProgressManager _003C_003E4__this;

			[Token(Token = "0x4002AFF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60015E7")]
			[Address(RVA = "0x3E22BC4", Offset = "0x3E1EBC4", VA = "0x3E22BC4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60015E8")]
			[Address(RVA = "0x3E23180", Offset = "0x3E1F180", VA = "0x3E23180", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002AF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _arenaProgressAnimationIng;

		[Token(Token = "0x4002AF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float ProgressScrollNowTime;

		[Token(Token = "0x4002AF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UIPanel panel;

		[Token(Token = "0x17000148")]
		public bool ArenaProgressAnimationIng
		{
			[Token(Token = "0x60015D0")]
			[Address(RVA = "0x3E20C9C", Offset = "0x3E1CC9C", VA = "0x3E20C9C")]
			get
			{
				return _arenaProgressAnimationIng;
			}
		}

		[Token(Token = "0x60015D1")]
		[Address(RVA = "0x3E20CA4", Offset = "0x3E1CCA4", VA = "0x3E20CA4", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__5))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x60015D2")]
		[Address(RVA = "0x3E20D34", Offset = "0x3E1CD34", VA = "0x3E20D34")]
		public void BeginAnimation()
		{
		}

		[Token(Token = "0x60015D3")]
		[Address(RVA = "0x3E20D40", Offset = "0x3E1CD40", VA = "0x3E20D40")]
		public void AnimationEnd()
		{
		}

		[Token(Token = "0x60015D4")]
		[Address(RVA = "0x3E20D48", Offset = "0x3E1CD48", VA = "0x3E20D48")]
		public void PanelUpdateInfo()
		{
		}

		[Token(Token = "0x60015D5")]
		[Address(RVA = "0x3E20DF0", Offset = "0x3E1CDF0", VA = "0x3E20DF0")]
		public void ArenaProgressPlayerTrophyRefreshSync()
		{
		}

		[Token(Token = "0x60015D6")]
		[Address(RVA = "0x3E20FC8", Offset = "0x3E1CFC8", VA = "0x3E20FC8")]
		public bool GetArenaIsChainProgressReward(string id)
		{
			return default;
		}

		[Token(Token = "0x60015D7")]
		[Address(RVA = "0x3E210E8", Offset = "0x3E1D0E8", VA = "0x3E210E8")]
		public string GetArenaChainProgressRewardCofig(string id)
		{
			return null;
		}

		[Token(Token = "0x60015D8")]
		[Address(RVA = "0x3E21240", Offset = "0x3E1D240", VA = "0x3E21240")]
		public string GetArenaProgressRewardCofig(string id)
		{
			return null;
		}

		[Token(Token = "0x60015D9")]
		[Address(RVA = "0x3E212C8", Offset = "0x3E1D2C8", VA = "0x3E212C8")]
		public void GetArenaProgressReward(string cofig, string arenaId)
		{
		}

		[Token(Token = "0x60015DA")]
		[Address(RVA = "0x3E20FE4", Offset = "0x3E1CFE4", VA = "0x3E20FE4")]
		public UserArenaData GetArenaData(string id)
		{
			return null;
		}

		[Token(Token = "0x60015DB")]
		[Address(RVA = "0x3E213B8", Offset = "0x3E1D3B8", VA = "0x3E213B8")]
		[AsyncStateMachine(typeof(_003CShowArenaProgressPanel_003Ed__15))]
		public UniTask ShowArenaProgressPanel()
		{
			return default;
		}

		[Token(Token = "0x60015DC")]
		[Address(RVA = "0x3E21444", Offset = "0x3E1D444", VA = "0x3E21444")]
		public void ShowUnLockArenaTipPanel()
		{
		}

		[Token(Token = "0x60015DD")]
		[Address(RVA = "0x3E2154C", Offset = "0x3E1D54C", VA = "0x3E2154C")]
		private void CheckArenaProgressBool(object o)
		{
		}

		[Token(Token = "0x60015DE")]
		[Address(RVA = "0x3E2182C", Offset = "0x3E1D82C", VA = "0x3E2182C")]
		public bool ArtifactsIsUnLock()
		{
			return default;
		}

		[Token(Token = "0x60015DF")]
		[Address(RVA = "0x3E218CC", Offset = "0x3E1D8CC", VA = "0x3E218CC")]
		public int GetArenaStayChainReward()
		{
			return default;
		}

		[Token(Token = "0x60015E0")]
		[Address(RVA = "0x3E21A0C", Offset = "0x3E1DA0C", VA = "0x3E21A0C")]
		public bool HasArenaUnlockNoChainProgressReward()
		{
			return default;
		}

		[Token(Token = "0x60015E1")]
		[Address(RVA = "0x3E21B08", Offset = "0x3E1DB08", VA = "0x3E21B08")]
		public bool HasArenaCollectAllTrophyNoChainCompleteReward()
		{
			return default;
		}

		[Token(Token = "0x60015E2")]
		[Address(RVA = "0x3E21C04", Offset = "0x3E1DC04", VA = "0x3E21C04")]
		public ArenaProgressManager()
		{
		}
	}
}
