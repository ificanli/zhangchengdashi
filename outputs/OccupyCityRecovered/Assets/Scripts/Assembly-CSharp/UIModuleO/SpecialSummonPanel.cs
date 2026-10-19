using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using DataModule;
using GameModule;
using Il2CppDummyDll;
using Spine;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;
using ljzs_lt;

namespace UIModuleO
{
	[Token(Token = "0x2000B84")]
	public class SpecialSummonPanel : SpecialSummonPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B88")]
		[CompilerGenerated]
		private struct _003CHideWhiteMaskAfterPanelOpened_003Ed__65 : IAsyncStateMachine
		{
			[Token(Token = "0x40053FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40053FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40053FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpecialSummonPanel _003C_003E4__this;

			[Token(Token = "0x40053FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Image _003CsummonMaskImage_003E5__2;

			[Token(Token = "0x40053FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60046D1")]
			[Address(RVA = "0x421AE88", Offset = "0x4216E88", VA = "0x421AE88", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60046D2")]
			[Address(RVA = "0x421B104", Offset = "0x4217104", VA = "0x421B104", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B89")]
		[CompilerGenerated]
		private struct _003CHideWhiteMaskFallback_003Ed__66 : IAsyncStateMachine
		{
			[Token(Token = "0x40053FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005401")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float timeoutSeconds;

			[Token(Token = "0x4005402")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SpecialSummonPanel _003C_003E4__this;

			[Token(Token = "0x4005403")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int seqId;

			[Token(Token = "0x4005404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Image summonMaskImage;

			[Token(Token = "0x4005405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60046D3")]
			[Address(RVA = "0x421B110", Offset = "0x4217110", VA = "0x421B110", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60046D4")]
			[Address(RVA = "0x421B540", Offset = "0x4217540", VA = "0x421B540", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B8A")]
		[CompilerGenerated]
		private struct _003CRefreshIconLightEffect_003Ed__51 : IAsyncStateMachine
		{
			[Token(Token = "0x4005406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005407")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005408")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SpecialSummonPanel _003C_003E4__this;

			[Token(Token = "0x4005409")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int rareLevel;

			[Token(Token = "0x400540A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private SkeletonGraphic _003CspineGraphic_003E5__2;

			[Token(Token = "0x400540B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<SkeletonDataAsset>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60046D5")]
			[Address(RVA = "0x421B54C", Offset = "0x421754C", VA = "0x421B54C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60046D6")]
			[Address(RVA = "0x421BB60", Offset = "0x4217B60", VA = "0x421BB60", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B8B")]
		[CompilerGenerated]
		private struct _003CRefreshLimitedDisplay_003Ed__50 : IAsyncStateMachine
		{
			[Token(Token = "0x400540C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400540D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400540E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SpecialSummonPanel _003C_003E4__this;

			[Token(Token = "0x400540F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private GlobalPropInfo _003Cinfo_003E5__2;

			[Token(Token = "0x4005410")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4005411")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x60046D7")]
			[Address(RVA = "0x421BB6C", Offset = "0x4217B6C", VA = "0x421BB6C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60046D8")]
			[Address(RVA = "0x421C3F0", Offset = "0x42183F0", VA = "0x421C3F0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B8C")]
		[CompilerGenerated]
		private struct _003CSeSummonAnimeCallBack_003Ed__61 : IAsyncStateMachine
		{
			[Token(Token = "0x4005412")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005413")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005414")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SpecialSummonPanel _003C_003E4__this;

			[Token(Token = "0x4005415")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action callback;

			[Token(Token = "0x60046D9")]
			[Address(RVA = "0x421C3FC", Offset = "0x42183FC", VA = "0x421C3FC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60046DA")]
			[Address(RVA = "0x421C850", Offset = "0x4218850", VA = "0x421C850", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B8D")]
		[CompilerGenerated]
		private struct _003CTriggerSummonAnimationCompleteBeforeEnd_003Ed__63 : IAsyncStateMachine
		{
			[Token(Token = "0x4005416")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005417")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005418")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TrackEntry trackEntry;

			[Token(Token = "0x4005419")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float secondsBeforeEnd;

			[Token(Token = "0x400541A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int seqId;

			[Token(Token = "0x400541B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpecialSummonPanel _003C_003E4__this;

			[Token(Token = "0x400541C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Image summonMaskImage;

			[Token(Token = "0x400541D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60046DB")]
			[Address(RVA = "0x421C85C", Offset = "0x421885C", VA = "0x421C85C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60046DC")]
			[Address(RVA = "0x421CBBC", Offset = "0x4218BBC", VA = "0x421CBBC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40053D6")]
		private const string SummonAnimation2 = "action2";

		[Token(Token = "0x40053D7")]
		private const string SummonAnimation1 = "action1";

		[Token(Token = "0x40053D8")]
		private const int TicketCostSingle = 1;

		[Token(Token = "0x40053D9")]
		private const int TicketCostTen = 10;

		[Token(Token = "0x40053DA")]
		private const int LimitedSummonPityCount = 10;

		[Token(Token = "0x40053DB")]
		private const int LegendDisplayWeightMultiplier = 2;

		[Token(Token = "0x40053DC")]
		private const int LimitedPropItemLegend = 4;

		[Token(Token = "0x40053DD")]
		private const string TipNotEnoughTicket = "限定召唤券不足";

		[Token(Token = "0x40053DE")]
		private const string SpecialSummonTimesLimitTipText = "已达召唤次数上限";

		[Token(Token = "0x40053DF")]
		private const string PityTipsFormat = "再抽{0}次必出<color=#FFEF32>传说</color>品质神器";

		[Token(Token = "0x40053E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private readonly Color _costColorEnough;

		[Token(Token = "0x40053E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private readonly Color _costColorNotEnough;

		[Token(Token = "0x40053E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Action<string> _onSummonTicketResourceChanged;

		[Token(Token = "0x40053E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Action _summonAnimeCallBack;

		[Token(Token = "0x40053E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private int _summonSequenceId;

		[Token(Token = "0x40053E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private int _summonCompleteHandledSeqId;

		[Token(Token = "0x40053E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private bool _waitingPropLotteryPanelOpen;

		[Token(Token = "0x40053E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private ArtifactsSummonPanel _rootPanel;

		[Token(Token = "0x40053E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private List<GlobalPropInfo> _allCommonProp;

		[Token(Token = "0x40053E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private List<GlobalPropInfo> _allRareProp;

		[Token(Token = "0x40053EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private List<GlobalPropInfo> _allEpicProp;

		[Token(Token = "0x40053EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private List<GlobalPropInfo> _allLegendProp;

		[Token(Token = "0x40053EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Tween _iconFloatTween;

		[Token(Token = "0x40053ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector2 _iconOriginAnchoredPos;

		[Token(Token = "0x40053EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private bool _hasIconOriginAnchoredPos;

		[Token(Token = "0x40053EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x139")]
		private bool _hasIconOriginForCurrentPlay;

		[Token(Token = "0x40053F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private float _refreshTimeTimer;

		[Token(Token = "0x60046A1")]
		[Address(RVA = "0x4217770", Offset = "0x4213770", VA = "0x4217770", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60046A2")]
		[Address(RVA = "0x4217D80", Offset = "0x4213D80", VA = "0x4217D80")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60046A3")]
		[Address(RVA = "0x421894C", Offset = "0x421494C", VA = "0x421894C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60046A4")]
		[Address(RVA = "0x4218C20", Offset = "0x4214C20", VA = "0x4218C20")]
		private void OnUpdateResourcesUI(object obj)
		{
		}

		[Token(Token = "0x60046A5")]
		[Address(RVA = "0x4218C98", Offset = "0x4214C98", VA = "0x4218C98")]
		private void OnSummonTicketResourceChanged(string count)
		{
		}

		[Token(Token = "0x60046A6")]
		[Address(RVA = "0x4218C9C", Offset = "0x4214C9C", VA = "0x4218C9C")]
		private void OnLimitedSummonTimeToZero(object obj)
		{
		}

		[Token(Token = "0x60046A7")]
		[Address(RVA = "0x4218D08", Offset = "0x4214D08", VA = "0x4218D08")]
		private void Update()
		{
		}

		[Token(Token = "0x60046A8")]
		[Address(RVA = "0x4218D54", Offset = "0x4214D54", VA = "0x4218D54", Slot = "14")]
		protected override void OnButtonExtendSummonPackClicked()
		{
		}

		[Token(Token = "0x60046A9")]
		[Address(RVA = "0x4218E28", Offset = "0x4214E28", VA = "0x4218E28", Slot = "12")]
		protected override void OnButtonExtendSpecialDesBtnClicked()
		{
		}

		[Token(Token = "0x60046AA")]
		[Address(RVA = "0x4218EFC", Offset = "0x4214EFC", VA = "0x4218EFC", Slot = "13")]
		protected override void OnButtonExtendRefreshBtnClicked()
		{
		}

		[Token(Token = "0x60046AB")]
		[Address(RVA = "0x4214210", Offset = "0x4210210", VA = "0x4214210")]
		public void RefreshLimitedSummonDisplay()
		{
		}

		[Token(Token = "0x60046AC")]
		[Address(RVA = "0x4218FD0", Offset = "0x4214FD0", VA = "0x4218FD0", Slot = "15")]
		protected override void OnAdButtonExtendSpecialSummonOneClicked()
		{
		}

		[Token(Token = "0x60046AD")]
		[Address(RVA = "0x421917C", Offset = "0x421517C", VA = "0x421917C", Slot = "16")]
		protected override void OnButtonExtendSpecialSummonTenClicked()
		{
		}

		[Token(Token = "0x60046AE")]
		[Address(RVA = "0x4218FD8", Offset = "0x4214FD8", VA = "0x4218FD8")]
		private void TrySummon(int count)
		{
		}

		[Token(Token = "0x60046AF")]
		[Address(RVA = "0x4219228", Offset = "0x4215228", VA = "0x4219228")]
		private void SpecialLottery(int count)
		{
		}

		[Token(Token = "0x60046B0")]
		[Address(RVA = "0x4219754", Offset = "0x4215754", VA = "0x4219754")]
		private LimitedPropInfoConfig RollLimitedPropRow()
		{
			return null;
		}

		[Token(Token = "0x60046B1")]
		[Address(RVA = "0x4219714", Offset = "0x4215714", VA = "0x4219714")]
		private RewardConfigSingle BuildLegendPityReward(string displayPropId)
		{
			return null;
		}

		[Token(Token = "0x60046B2")]
		[Address(RVA = "0x4219B04", Offset = "0x4215B04", VA = "0x4219B04")]
		private static bool IsLegendReward(RewardConfigSingle reward)
		{
			return default;
		}

		[Token(Token = "0x60046B3")]
		[Address(RVA = "0x42199FC", Offset = "0x42159FC", VA = "0x42199FC")]
		private RewardConfigSingle BuildRewardFromLimitedPropRow(LimitedPropInfoConfig row, string displayPropId)
		{
			return null;
		}

		[Token(Token = "0x60046B4")]
		[Address(RVA = "0x4219BB8", Offset = "0x4215BB8", VA = "0x4219BB8")]
		private LimitedPropInfoConfig RollLimitedPropRowByItem(int itemType)
		{
			return null;
		}

		[Token(Token = "0x60046B5")]
		[Address(RVA = "0x4219E7C", Offset = "0x4215E7C", VA = "0x4219E7C")]
		private string ResolvePropIdByItemType(int itemType, string displayPropId)
		{
			return null;
		}

		[Token(Token = "0x60046B6")]
		[Address(RVA = "0x4219FDC", Offset = "0x4215FDC", VA = "0x4219FDC")]
		private string PickLegendPropIdWithDisplayBoost(string displayPropId)
		{
			return null;
		}

		[Token(Token = "0x60046B7")]
		[Address(RVA = "0x4219F38", Offset = "0x4215F38", VA = "0x4219F38")]
		private string PickRandomPropId(List<GlobalPropInfo> pool)
		{
			return null;
		}

		[Token(Token = "0x60046B8")]
		[Address(RVA = "0x4218798", Offset = "0x4214798", VA = "0x4218798")]
		[AsyncStateMachine(typeof(_003CRefreshLimitedDisplay_003Ed__50))]
		private UniTask RefreshLimitedDisplay()
		{
			return default;
		}

		[Token(Token = "0x60046B9")]
		[Address(RVA = "0x421A170", Offset = "0x4216170", VA = "0x421A170")]
		[AsyncStateMachine(typeof(_003CRefreshIconLightEffect_003Ed__51))]
		private UniTask RefreshIconLightEffect(int rareLevel)
		{
			return default;
		}

		[Token(Token = "0x60046BA")]
		[Address(RVA = "0x4218828", Offset = "0x4214828", VA = "0x4218828")]
		private void PlayIconFloatAnimation()
		{
		}

		[Token(Token = "0x60046BB")]
		[Address(RVA = "0x4218B54", Offset = "0x4214B54", VA = "0x4218B54")]
		private void StopIconFloatAnimation()
		{
		}

		[Token(Token = "0x60046BC")]
		[Address(RVA = "0x42182DC", Offset = "0x42142DC", VA = "0x42182DC")]
		private void RefreshSummonTicketCostColor()
		{
		}

		[Token(Token = "0x60046BD")]
		[Address(RVA = "0x4218514", Offset = "0x4214514", VA = "0x4218514")]
		private void RefreshSpecialSummonTimesLimit()
		{
		}

		[Token(Token = "0x60046BE")]
		[Address(RVA = "0x421869C", Offset = "0x421469C", VA = "0x421869C")]
		private void RefreshLimitedSummonPityTips()
		{
		}

		[Token(Token = "0x60046BF")]
		[Address(RVA = "0x4218258", Offset = "0x4214258", VA = "0x4218258")]
		private void RefreshRotateCountdown()
		{
		}

		[Token(Token = "0x60046C0")]
		[Address(RVA = "0x421A5F8", Offset = "0x42165F8", VA = "0x421A5F8")]
		private int GetDisplayOrderId()
		{
			return default;
		}

		[Token(Token = "0x60046C1")]
		[Address(RVA = "0x4219638", Offset = "0x4215638", VA = "0x4219638")]
		private string GetDisplayPropIdString()
		{
			return null;
		}

		[Token(Token = "0x60046C2")]
		[Address(RVA = "0x421787C", Offset = "0x421387C", VA = "0x421787C")]
		private void CachePropPools()
		{
		}

		[Token(Token = "0x60046C3")]
		[Address(RVA = "0x421918C", Offset = "0x421518C", VA = "0x421918C")]
		[AsyncStateMachine(typeof(_003CSeSummonAnimeCallBack_003Ed__61))]
		private void SeSummonAnimeCallBack(Action callback)
		{
		}

		[Token(Token = "0x60046C4")]
		[Address(RVA = "0x421A648", Offset = "0x4216648", VA = "0x421A648")]
		private void HandleSummonAnimationComplete(TrackEntry trackEntry, int seqId, Image summonMaskImage)
		{
		}

		[Token(Token = "0x60046C5")]
		[Address(RVA = "0x421A79C", Offset = "0x421679C", VA = "0x421A79C")]
		[AsyncStateMachine(typeof(_003CTriggerSummonAnimationCompleteBeforeEnd_003Ed__63))]
		private UniTaskVoid TriggerSummonAnimationCompleteBeforeEnd(TrackEntry trackEntry, int seqId, Image summonMaskImage, float secondsBeforeEnd)
		{
			return default;
		}

		[Token(Token = "0x60046C6")]
		[Address(RVA = "0x421A848", Offset = "0x4216848", VA = "0x421A848")]
		private void OnPropLotteryPanelChangeActive(object o)
		{
		}

		[Token(Token = "0x60046C7")]
		[Address(RVA = "0x421A98C", Offset = "0x421698C", VA = "0x421A98C")]
		[AsyncStateMachine(typeof(_003CHideWhiteMaskAfterPanelOpened_003Ed__65))]
		private UniTaskVoid HideWhiteMaskAfterPanelOpened()
		{
			return default;
		}

		[Token(Token = "0x60046C8")]
		[Address(RVA = "0x421AA04", Offset = "0x4216A04", VA = "0x421AA04")]
		[AsyncStateMachine(typeof(_003CHideWhiteMaskFallback_003Ed__66))]
		private UniTaskVoid HideWhiteMaskFallback(int seqId, Image summonMaskImage, float timeoutSeconds)
		{
			return default;
		}

		[Token(Token = "0x60046C9")]
		[Address(RVA = "0x421AAA4", Offset = "0x4216AA4", VA = "0x421AAA4")]
		private Image GetSummonMaskImage()
		{
			return null;
		}

		[Token(Token = "0x60046CA")]
		[Address(RVA = "0x421AB80", Offset = "0x4216B80", VA = "0x421AB80")]
		public SpecialSummonPanel()
		{
		}
	}
}
