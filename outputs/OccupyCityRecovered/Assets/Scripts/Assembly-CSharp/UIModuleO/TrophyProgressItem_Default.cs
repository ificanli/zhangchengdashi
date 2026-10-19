using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000BB1")]
	public class TrophyProgressItem_Default : TrophyProgressItem_DefaultComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BB4")]
		[CompilerGenerated]
		private struct _003CClaimReward_003Ed__23 : IAsyncStateMachine
		{
			[Token(Token = "0x400550D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400550E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400550F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TrophyProgressItem_Default _003C_003E4__this;

			[Token(Token = "0x4005510")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private GlobalTrophyProgressInfo _003Cconfig_003E5__2;

			[Token(Token = "0x4005511")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004815")]
			[Address(RVA = "0x423268C", Offset = "0x422E68C", VA = "0x423268C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004816")]
			[Address(RVA = "0x4233680", Offset = "0x422F680", VA = "0x4233680", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BB5")]
		[CompilerGenerated]
		private struct _003CLoadResourcesAsync_003Ed__16 : IAsyncStateMachine
		{
			[Token(Token = "0x4005512")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool hasBox;

			[Token(Token = "0x4005515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TrophyProgressItem_Default _003C_003E4__this;

			[Token(Token = "0x4005516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GlobalTrophyProgressInfo config;

			[Token(Token = "0x4005517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string configId;

			[Token(Token = "0x4005518")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string _003CboxIconPath_003E5__2;

			[Token(Token = "0x4005519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004817")]
			[Address(RVA = "0x423368C", Offset = "0x422F68C", VA = "0x423368C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004818")]
			[Address(RVA = "0x4233B84", Offset = "0x422FB84", VA = "0x4233B84", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BB6")]
		[CompilerGenerated]
		private struct _003CRetryRefreshProgressBarAfterLayoutAsync_003Ed__14 : IAsyncStateMachine
		{
			[Token(Token = "0x400551A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400551B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400551C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TrophyProgressItem_Default _003C_003E4__this;

			[Token(Token = "0x400551D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string configId;

			[Token(Token = "0x400551E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int prevTrophyRequire;

			[Token(Token = "0x400551F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int targetTrophy;

			[Token(Token = "0x4005520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BigInteger currentTrophy;

			[Token(Token = "0x4005521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004819")]
			[Address(RVA = "0x4233B90", Offset = "0x422FB90", VA = "0x4233B90", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600481A")]
			[Address(RVA = "0x4233DE8", Offset = "0x422FDE8", VA = "0x4233DE8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private TrophyProgressRewardData _rewardData;

		[Token(Token = "0x4005505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private int _index;

		[Token(Token = "0x4005506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private string _currentConfigId;

		[Token(Token = "0x4005507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private string _cachedBoxIconPath;

		[Token(Token = "0x4005508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private string _pendingProgressRetryConfigId;

		[Token(Token = "0x60047FB")]
		[Address(RVA = "0x422F550", Offset = "0x422B550", VA = "0x422F550")]
		public void Show(TrophyProgressRewardData rewardData, int index)
		{
		}

		[Token(Token = "0x60047FC")]
		[Address(RVA = "0x422F570", Offset = "0x422B570", VA = "0x422F570")]
		private void UpdateUI()
		{
		}

		[Token(Token = "0x60047FD")]
		[Address(RVA = "0x422F860", Offset = "0x422B860", VA = "0x422F860")]
		private void RefreshTrophyRequireText(GlobalTrophyProgressInfo config)
		{
		}

		[Token(Token = "0x60047FE")]
		[Address(RVA = "0x422F928", Offset = "0x422B928", VA = "0x422F928")]
		private void RefreshRewardVisibility(bool hasGold, bool hasDiamond, bool hasBox)
		{
		}

		[Token(Token = "0x60047FF")]
		[Address(RVA = "0x422FAA0", Offset = "0x422BAA0", VA = "0x422FAA0")]
		private void RefreshRewardCounts(GlobalTrophyProgressInfo config, bool hasGold, bool hasDiamond, bool hasBox)
		{
		}

		[Token(Token = "0x6004800")]
		[Address(RVA = "0x423032C", Offset = "0x422C32C", VA = "0x423032C")]
		private void RefreshClaimButton(bool isUnlocked, bool isClaimed, bool hasAnyReward)
		{
		}

		[Token(Token = "0x6004801")]
		[Address(RVA = "0x4230AD4", Offset = "0x422CAD4", VA = "0x4230AD4")]
		private bool IsDataValid(string configId)
		{
			return default;
		}

		[Token(Token = "0x6004802")]
		[Address(RVA = "0x4230B30", Offset = "0x422CB30", VA = "0x4230B30")]
		private int GetPrevTrophyRequire()
		{
			return default;
		}

		[Token(Token = "0x6004803")]
		[Address(RVA = "0x422F724", Offset = "0x422B724", VA = "0x422F724")]
		private void RefreshProgressBar(GlobalTrophyProgressInfo config, BigInteger currentTrophy, string configId)
		{
		}

		[Token(Token = "0x6004804")]
		[Address(RVA = "0x4230CC8", Offset = "0x422CCC8", VA = "0x4230CC8")]
		[AsyncStateMachine(typeof(_003CRetryRefreshProgressBarAfterLayoutAsync_003Ed__14))]
		private UniTaskVoid RetryRefreshProgressBarAfterLayoutAsync(string configId, int prevTrophyRequire, int targetTrophy, BigInteger currentTrophy)
		{
			return default;
		}

		[Token(Token = "0x6004805")]
		[Address(RVA = "0x4230E14", Offset = "0x422CE14", VA = "0x4230E14")]
		private bool TryGetBoxIconPath(GlobalTrophyProgressInfo config, out string iconPath)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TrophyProgressItem_Default.TryGetBoxIconPath RVA=0x4230E14 Token=0x6004805");
}

		[Token(Token = "0x6004806")]
		[Address(RVA = "0x42303F0", Offset = "0x422C3F0", VA = "0x42303F0")]
		[AsyncStateMachine(typeof(_003CLoadResourcesAsync_003Ed__16))]
		private UniTaskVoid LoadResourcesAsync(GlobalTrophyProgressInfo config, string configId, bool hasBox)
		{
			return default;
		}

		[Token(Token = "0x6004807")]
		[Address(RVA = "0x4230D74", Offset = "0x422CD74", VA = "0x4230D74")]
		private void UpdateProgressBar(int prevTrophyRequire, int targetTrophy, BigInteger currentTrophy)
		{
		}

		[Token(Token = "0x6004808")]
		[Address(RVA = "0x4230F6C", Offset = "0x422CF6C", VA = "0x4230F6C")]
		private void UpdateProgressBar(int prevTrophyRequire, int targetTrophy, BigInteger currentTrophy, BigInteger historyTrophy)
		{
		}

		[Token(Token = "0x6004809")]
		[Address(RVA = "0x422FC60", Offset = "0x422BC60", VA = "0x422FC60")]
		private void StopAllAnimations()
		{
		}

		[Token(Token = "0x600480A")]
		[Address(RVA = "0x422FF4C", Offset = "0x422BF4C", VA = "0x422FF4C")]
		private void UpdateRewardState(bool isUnlocked, bool isClaimed, bool hasGold, bool hasDiamond, bool hasBox)
		{
		}

		[Token(Token = "0x600480B")]
		[Address(RVA = "0x4232174", Offset = "0x422E174", VA = "0x4232174")]
		private void PlayClaimableAnimations(bool hasGold, bool hasDiamond, bool hasBox)
		{
		}

		[Token(Token = "0x600480C")]
		[Address(RVA = "0x42323EC", Offset = "0x422E3EC", VA = "0x42323EC", Slot = "12")]
		protected override void OnButtonExtendBtnClaimCompleteRewardClicked()
		{
		}

		[Token(Token = "0x600480D")]
		[Address(RVA = "0x4232470", Offset = "0x422E470", VA = "0x4232470")]
		[AsyncStateMachine(typeof(_003CClaimReward_003Ed__23))]
		private void ClaimReward()
		{
		}

		[Token(Token = "0x600480E")]
		[Address(RVA = "0x4232500", Offset = "0x422E500", VA = "0x4232500")]
		public TrophyProgressItem_Default()
		{
		}
	}
}
