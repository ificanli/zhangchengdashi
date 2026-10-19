using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000BB9")]
	public class TrophyProgressItem_Expression : TrophyProgressItem_ExpressionComponents
	{
		[Token(Token = "0x2000BBB")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass10_0
		{
			[Token(Token = "0x4005548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string expressionId;

			[Token(Token = "0x6004856")]
			[Address(RVA = "0x4237CF0", Offset = "0x4233CF0", VA = "0x4237CF0")]
			public _003C_003Ec__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6004857")]
			[Address(RVA = "0x4237CF8", Offset = "0x4233CF8", VA = "0x4237CF8")]
			internal bool _003CLoadExpressionSpine_003Eb__0(GlobalExpression e)
			{
				return default;
			}
		}

		[Token(Token = "0x2000BBC")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass9_0
		{
			[Token(Token = "0x4005549")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GlobalTrophyProgressInfo config;

			[Token(Token = "0x6004858")]
			[Address(RVA = "0x4237D1C", Offset = "0x4233D1C", VA = "0x4237D1C")]
			public _003C_003Ec__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6004859")]
			[Address(RVA = "0x4237D24", Offset = "0x4233D24", VA = "0x4237D24")]
			internal bool _003CLoadExpressionResourcesAsync_003Eb__0(GlobalBoxInfo x)
			{
				return default;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BBD")]
		[CompilerGenerated]
		private struct _003CClaimNormalReward_003Ed__23 : IAsyncStateMachine
		{
			[Token(Token = "0x400554A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400554B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400554C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TrophyProgressItem_Expression _003C_003E4__this;

			[Token(Token = "0x400554D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private GlobalTrophyProgressInfo _003Cconfig_003E5__2;

			[Token(Token = "0x400554E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600485A")]
			[Address(RVA = "0x4237D5C", Offset = "0x4233D5C", VA = "0x4237D5C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600485B")]
			[Address(RVA = "0x4238D50", Offset = "0x4234D50", VA = "0x4238D50", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BBE")]
		[CompilerGenerated]
		private struct _003CLoadExpressionResourcesAsync_003Ed__9 : IAsyncStateMachine
		{
			[Token(Token = "0x400554F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TrophyProgressItem_Expression _003C_003E4__this;

			[Token(Token = "0x4005552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private _003C_003Ec__DisplayClass9_0 _003C_003E8__1;

			[Token(Token = "0x4005553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private bool _003CisUnlocked_003E5__2;

			[Token(Token = "0x4005554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private string[] _003CexpressionEntries_003E5__3;

			[Token(Token = "0x4005555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4005556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Image _003C_003E7__wrap3;

			[Token(Token = "0x4005557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x600485C")]
			[Address(RVA = "0x4238D5C", Offset = "0x4234D5C", VA = "0x4238D5C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600485D")]
			[Address(RVA = "0x4239948", Offset = "0x4235948", VA = "0x4239948", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BBF")]
		[CompilerGenerated]
		private struct _003CLoadExpressionSpine_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4005558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400555A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string expressionId;

			[Token(Token = "0x400555B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrophyProgressItem_Expression _003C_003E4__this;

			[Token(Token = "0x400555C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private _003C_003Ec__DisplayClass10_0 _003C_003E8__1;

			[Token(Token = "0x400555D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public SkeletonGraphic skeletonGraphic;

			[Token(Token = "0x400555E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isUnlocked;

			[Token(Token = "0x400555F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private string _003CcurrentConfigId_003E5__2;

			[Token(Token = "0x4005560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<SkeletonDataAsset>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600485E")]
			[Address(RVA = "0x4239954", Offset = "0x4235954", VA = "0x4239954", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600485F")]
			[Address(RVA = "0x423A0CC", Offset = "0x42360CC", VA = "0x423A0CC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BC0")]
		[CompilerGenerated]
		private struct _003CUpdateProgressBar_003Ed__15 : IAsyncStateMachine
		{
			[Token(Token = "0x4005561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TrophyProgressItem_Expression _003C_003E4__this;

			[Token(Token = "0x4005564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int targetTrophy;

			[Token(Token = "0x4005565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int prevTrophyRequire;

			[Token(Token = "0x4005566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BigInteger currentTrophy;

			[Token(Token = "0x4005567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public BigInteger historyTrophy;

			[Token(Token = "0x4005568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float _003Cprogress_003E5__2;

			[Token(Token = "0x4005569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private int _003Crange_003E5__3;

			[Token(Token = "0x400556A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private string _003CcurrentConfigId_003E5__4;

			[Token(Token = "0x400556B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004860")]
			[Address(RVA = "0x423A0D8", Offset = "0x42360D8", VA = "0x423A0D8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004861")]
			[Address(RVA = "0x423AFBC", Offset = "0x4236FBC", VA = "0x423AFBC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private TrophyProgressRewardData _rewardData;

		[Token(Token = "0x4005541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private int _index;

		[Token(Token = "0x4005542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private string _lastExpressionConfig;

		[Token(Token = "0x4005543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private bool _needLoadSpineResources;

		[Token(Token = "0x4005544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private string _currentConfigId;

		[Token(Token = "0x600483E")]
		[Address(RVA = "0x423426C", Offset = "0x423026C", VA = "0x423426C")]
		public void Show(TrophyProgressRewardData rewardData, int index)
		{
		}

		[Token(Token = "0x600483F")]
		[Address(RVA = "0x42344B8", Offset = "0x42304B8", VA = "0x42344B8")]
		private bool IsDataValid(string configId)
		{
			return default;
		}

		[Token(Token = "0x6004840")]
		[Address(RVA = "0x423428C", Offset = "0x423028C", VA = "0x423428C")]
		private void UpdateUI()
		{
		}

		[Token(Token = "0x6004841")]
		[Address(RVA = "0x42345DC", Offset = "0x42305DC", VA = "0x42345DC")]
		private void UpdateExpressionRewardSync(GlobalTrophyProgressInfo config, bool isUnlocked, bool isClaimed)
		{
		}

		[Token(Token = "0x6004842")]
		[Address(RVA = "0x423517C", Offset = "0x423117C", VA = "0x423517C")]
		[AsyncStateMachine(typeof(_003CLoadExpressionResourcesAsync_003Ed__9))]
		private UniTaskVoid LoadExpressionResourcesAsync()
		{
			return default;
		}

		[Token(Token = "0x6004843")]
		[Address(RVA = "0x4235FF4", Offset = "0x4231FF4", VA = "0x4235FF4")]
		[AsyncStateMachine(typeof(_003CLoadExpressionSpine_003Ed__10))]
		private UniTask LoadExpressionSpine(string expressionId, SkeletonGraphic skeletonGraphic, bool isUnlocked)
		{
			return default;
		}

		[Token(Token = "0x6004844")]
		[Address(RVA = "0x4235450", Offset = "0x4231450", VA = "0x4235450")]
		private void UpdateSpineColor(SkeletonGraphic skeletonGraphic, bool isUnlocked)
		{
		}

		[Token(Token = "0x6004845")]
		[Address(RVA = "0x42360AC", Offset = "0x42320AC", VA = "0x42360AC")]
		private void PlayExpressionSpineAnimation(SkeletonGraphic skeletonGraphic)
		{
		}

		[Token(Token = "0x6004846")]
		[Address(RVA = "0x42349D0", Offset = "0x42309D0", VA = "0x42349D0")]
		private void UpdateNormalReward(GlobalTrophyProgressInfo config, bool isUnlocked, bool isClaimed)
		{
		}

		[Token(Token = "0x6004847")]
		[Address(RVA = "0x42350DC", Offset = "0x42310DC", VA = "0x42350DC")]
		private void UpdateProgressBar(int prevTrophyRequire, int targetTrophy, BigInteger currentTrophy)
		{
		}

		[Token(Token = "0x6004848")]
		[Address(RVA = "0x4237328", Offset = "0x4233328", VA = "0x4237328")]
		[AsyncStateMachine(typeof(_003CUpdateProgressBar_003Ed__15))]
		private UniTask UpdateProgressBar(int prevTrophyRequire, int targetTrophy, BigInteger currentTrophy, BigInteger historyTrophy)
		{
			return default;
		}

		[Token(Token = "0x6004849")]
		[Address(RVA = "0x42365F4", Offset = "0x42325F4", VA = "0x42365F4")]
		private void StopAllAnimations()
		{
		}

		[Token(Token = "0x600484A")]
		[Address(RVA = "0x4235AD4", Offset = "0x4231AD4", VA = "0x4235AD4")]
		private void StopExpressionAnimations()
		{
		}

		[Token(Token = "0x600484B")]
		[Address(RVA = "0x4235C7C", Offset = "0x4231C7C", VA = "0x4235C7C")]
		private void PlayExpressionClaimableAnimations(bool show1, bool show2)
		{
		}

		[Token(Token = "0x600484C")]
		[Address(RVA = "0x42370B0", Offset = "0x42330B0", VA = "0x42370B0")]
		private void PlayClaimableAnimations(bool hasGold, bool hasDiamond, bool hasBox)
		{
		}

		[Token(Token = "0x600484D")]
		[Address(RVA = "0x42377E0", Offset = "0x42337E0", VA = "0x42377E0", Slot = "12")]
		protected override void OnButtonExtendBackgroundClicked()
		{
		}

		[Token(Token = "0x600484E")]
		[Address(RVA = "0x4237A74", Offset = "0x4233A74", VA = "0x4237A74", Slot = "13")]
		protected override void OnButtonExtendBtnClaimCompleteRewardClicked()
		{
		}

		[Token(Token = "0x600484F")]
		[Address(RVA = "0x4237864", Offset = "0x4233864", VA = "0x4237864")]
		private void ClaimExpressionReward()
		{
		}

		[Token(Token = "0x6004850")]
		[Address(RVA = "0x4237AF8", Offset = "0x4233AF8", VA = "0x4237AF8")]
		[AsyncStateMachine(typeof(_003CClaimNormalReward_003Ed__23))]
		private void ClaimNormalReward()
		{
		}

		[Token(Token = "0x6004851")]
		[Address(RVA = "0x4237B88", Offset = "0x4233B88", VA = "0x4237B88")]
		public TrophyProgressItem_Expression()
		{
		}
	}
}
