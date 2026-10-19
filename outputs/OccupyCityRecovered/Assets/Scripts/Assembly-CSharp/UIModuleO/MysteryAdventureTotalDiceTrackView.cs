using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using ljzs_lt;

namespace UIModuleO
{
	[Token(Token = "0x2000A57")]
	public class MysteryAdventureTotalDiceTrackView
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A58")]
		[CompilerGenerated]
		private struct _003CEnsureBuiltAsync_003Ed__29 : IAsyncStateMachine
		{
			[Token(Token = "0x4004C93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004C94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004C95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventureTotalDiceTrackView _003C_003E4__this;

			[Token(Token = "0x4004C96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4004C97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6003E0F")]
			[Address(RVA = "0x4169514", Offset = "0x4165514", VA = "0x4169514", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003E10")]
			[Address(RVA = "0x4169DD0", Offset = "0x4165DD0", VA = "0x4169DD0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A59")]
		[CompilerGenerated]
		private struct _003CRefreshAsync_003Ed__34 : IAsyncStateMachine
		{
			[Token(Token = "0x4004C98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004C99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004C9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventureTotalDiceTrackView _003C_003E4__this;

			[Token(Token = "0x4004C9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlayerMysteryAdventureData data;

			[Token(Token = "0x4004C9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003E11")]
			[Address(RVA = "0x4169DDC", Offset = "0x4165DDC", VA = "0x4169DDC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003E12")]
			[Address(RVA = "0x416A5DC", Offset = "0x41665DC", VA = "0x416A5DC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A5A")]
		[CompilerGenerated]
		private struct _003CResetProgrammaticScrollFlag_003Ed__57 : IAsyncStateMachine
		{
			[Token(Token = "0x4004C9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004C9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004C9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MysteryAdventureTotalDiceTrackView _003C_003E4__this;

			[Token(Token = "0x4004CA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003E13")]
			[Address(RVA = "0x416A5E8", Offset = "0x41665E8", VA = "0x416A5E8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003E14")]
			[Address(RVA = "0x416A7AC", Offset = "0x41667AC", VA = "0x416A7AC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A5B")]
		[CompilerGenerated]
		private struct _003CScheduleScrollReturn_003Ed__55 : IAsyncStateMachine
		{
			[Token(Token = "0x4004CA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004CA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004CA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MysteryAdventureTotalDiceTrackView _003C_003E4__this;

			[Token(Token = "0x4004CA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private CancellationToken _003Ctoken_003E5__2;

			[Token(Token = "0x4004CA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private ScrollRect _003CscrollRect_003E5__3;

			[Token(Token = "0x4004CA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003E15")]
			[Address(RVA = "0x416A7B8", Offset = "0x41667B8", VA = "0x416A7B8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003E16")]
			[Address(RVA = "0x416AE80", Offset = "0x4166E80", VA = "0x416AE80", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004C7C")]
		private const float ItemWidth = 130f;

		[Token(Token = "0x4004C7D")]
		private const float ContentPadding = 16f;

		[Token(Token = "0x4004C7E")]
		private const float ScrollAutoReturnDelay = 3f;

		[Token(Token = "0x4004C7F")]
		private const float ScrollVelocityThreshold = 1f;

		[Token(Token = "0x4004C80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly MysteryAdventurePanelView _view;

		[Token(Token = "0x4004C81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<MysteryAdventureTotalDiceMilestoneItem> _items;

		[Token(Token = "0x4004C82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject _rewardItemPrefab;

		[Token(Token = "0x4004C83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _building;

		[Token(Token = "0x4004C84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Action<string> _statusCallback;

		[Token(Token = "0x4004C85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Action _onRefreshed;

		[Token(Token = "0x4004C86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool _scrollListenerRegistered;

		[Token(Token = "0x4004C87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool _isProgrammaticScroll;

		[Token(Token = "0x4004C88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		private bool _hasInitialScrolled;

		[Token(Token = "0x4004C89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x43")]
		private bool _userOverrideScroll;

		[Token(Token = "0x4004C8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int _lastConsumed;

		[Token(Token = "0x4004C8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _lastRefreshConsumed;

		[Token(Token = "0x4004C8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int _lastClaimedStateHash;

		[Token(Token = "0x4004C8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _trackInitialized;

		[Token(Token = "0x4004C8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float _lastFillRatio;

		[Token(Token = "0x4004C8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IReadOnlyList<TotalDiceConfig> _lastConfigs;

		[Token(Token = "0x4004C90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _lastScrollItemCount;

		[Token(Token = "0x4004C91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int _lastAppliedScrollConsumed;

		[Token(Token = "0x4004C92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CancellationTokenSource _scrollReturnCts;

		[Token(Token = "0x17000955")]
		public IReadOnlyList<MysteryAdventureTotalDiceMilestoneItem> Items
		{
			[Token(Token = "0x6003DED")]
			[Address(RVA = "0x4165950", Offset = "0x4161950", VA = "0x4165950")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000956")]
		public Action OnRefreshed
		{
			[Token(Token = "0x6003DEE")]
			[Address(RVA = "0x4165958", Offset = "0x4161958", VA = "0x4165958")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003DEF")]
			[Address(RVA = "0x4165960", Offset = "0x4161960", VA = "0x4165960")]
			set
			{
			}
		}

		[Token(Token = "0x6003DEC")]
		[Address(RVA = "0x41658A4", Offset = "0x41618A4", VA = "0x41658A4")]
		public MysteryAdventureTotalDiceTrackView(MysteryAdventurePanelView view, Action<string> statusCallback)
		{
		}

		[Token(Token = "0x6003DF0")]
		[Address(RVA = "0x4165968", Offset = "0x4161968", VA = "0x4165968")]
		[AsyncStateMachine(typeof(_003CEnsureBuiltAsync_003Ed__29))]
		public UniTask EnsureBuiltAsync()
		{
			return default;
		}

		[Token(Token = "0x6003DF1")]
		[Address(RVA = "0x4165A00", Offset = "0x4161A00", VA = "0x4165A00")]
		private void EnsureTrackEffectCulling()
		{
		}

		[Token(Token = "0x6003DF2")]
		[Address(RVA = "0x4165B4C", Offset = "0x4161B4C", VA = "0x4165B4C")]
		private void UpdateMilestoneEffectVisibility(bool forceCanvasUpdate = false)
		{
		}

		[Token(Token = "0x6003DF3")]
		[Address(RVA = "0x4165A1C", Offset = "0x4161A1C", VA = "0x4165A1C")]
		private void EnsureTrackLayering()
		{
		}

		[Token(Token = "0x6003DF4")]
		[Address(RVA = "0x4165C74", Offset = "0x4161C74", VA = "0x4165C74")]
		private void HideLegacyEndMilestoneItem()
		{
		}

		[Token(Token = "0x6003DF5")]
		[Address(RVA = "0x4165DAC", Offset = "0x4161DAC", VA = "0x4165DAC")]
		[AsyncStateMachine(typeof(_003CRefreshAsync_003Ed__34))]
		public UniTask RefreshAsync(PlayerMysteryAdventureData data)
		{
			return default;
		}

		[Token(Token = "0x6003DF6")]
		[Address(RVA = "0x4165E54", Offset = "0x4161E54", VA = "0x4165E54")]
		private void UpdateConsumedText(int consumed)
		{
		}

		[Token(Token = "0x6003DF7")]
		[Address(RVA = "0x4165F00", Offset = "0x4161F00", VA = "0x4165F00")]
		private static int ComputeClaimedStateHash(PlayerMysteryAdventureData data)
		{
			return default;
		}

		[Token(Token = "0x6003DF8")]
		[Address(RVA = "0x4165FAC", Offset = "0x4161FAC", VA = "0x4165FAC")]
		private void BindMilestoneItems(IReadOnlyList<TotalDiceConfig> configs, PlayerMysteryAdventureData data, int scrollItemCount)
		{
		}

		[Token(Token = "0x6003DF9")]
		[Address(RVA = "0x4166228", Offset = "0x4162228", VA = "0x4166228")]
		private void UpdateMilestoneStates(IReadOnlyList<TotalDiceConfig> configs, PlayerMysteryAdventureData data, int scrollItemCount)
		{
		}

		[Token(Token = "0x6003DFA")]
		[Address(RVA = "0x41661A8", Offset = "0x41621A8", VA = "0x41661A8")]
		private static bool IsSpecialRewardIndex(int configIndex)
		{
			return default;
		}

		[Token(Token = "0x6003DFB")]
		[Address(RVA = "0x4166364", Offset = "0x4162364", VA = "0x4166364")]
		private void EnsureItemCount(int count)
		{
		}

		[Token(Token = "0x6003DFC")]
		[Address(RVA = "0x41661CC", Offset = "0x41621CC", VA = "0x41661CC")]
		private static MysteryAdventureTotalDiceMilestoneState ResolveState(PlayerMysteryAdventureData data, TotalDiceConfig config)
		{
			return default;
		}

		[Token(Token = "0x6003DFD")]
		[Address(RVA = "0x41664C8", Offset = "0x41624C8", VA = "0x41664C8")]
		private void UpdateTrackSize(IReadOnlyList<TotalDiceConfig> configs, int consumed, int scrollItemCount, bool rebuildLayout)
		{
		}

		[Token(Token = "0x6003DFE")]
		[Address(RVA = "0x416688C", Offset = "0x416288C", VA = "0x416688C")]
		private float CalculateTrackFillRatio(IReadOnlyList<TotalDiceConfig> configs, int consumed, int scrollItemCount)
		{
			return default;
		}

		[Token(Token = "0x6003DFF")]
		[Address(RVA = "0x4166B60", Offset = "0x4162B60", VA = "0x4166B60")]
		private float CalculateTrackFillRatioFromLayout(IReadOnlyList<TotalDiceConfig> configs, int consumed, int scrollItemCount, RectTransform barRect)
		{
			return default;
		}

		[Token(Token = "0x6003E00")]
		[Address(RVA = "0x416729C", Offset = "0x416329C", VA = "0x416729C")]
		private float GetMilestoneCenterLocalX(int itemIndex, RectTransform barRect)
		{
			return default;
		}

		[Token(Token = "0x6003E01")]
		[Address(RVA = "0x4166E50", Offset = "0x4162E50", VA = "0x4166E50")]
		private static float CalculateTrackFillRatioEvenSegments(IReadOnlyList<TotalDiceConfig> configs, int consumed, int scrollItemCount)
		{
			return default;
		}

		[Token(Token = "0x6003E02")]
		[Address(RVA = "0x41673EC", Offset = "0x41633EC", VA = "0x41673EC")]
		private void UpdateMilestoneStatesForConsumedChange(IReadOnlyList<TotalDiceConfig> configs, PlayerMysteryAdventureData data, int scrollItemCount, int consumed)
		{
		}

		[Token(Token = "0x6003E03")]
		[Address(RVA = "0x4167584", Offset = "0x4163584", VA = "0x4167584")]
		private void UpdateTrackProgressIfChanged(IReadOnlyList<TotalDiceConfig> configs, int consumed, int scrollItemCount)
		{
		}

		[Token(Token = "0x6003E04")]
		[Address(RVA = "0x4166790", Offset = "0x4162790", VA = "0x4166790")]
		private void UpdateTrackProgress(IReadOnlyList<TotalDiceConfig> configs, int consumed, int scrollItemCount, bool forceCanvasUpdate)
		{
		}

		[Token(Token = "0x6003E05")]
		[Address(RVA = "0x416774C", Offset = "0x416374C", VA = "0x416774C")]
		private void ApplyTrackFill(float fillRatio)
		{
		}

		[Token(Token = "0x6003E06")]
		[Address(RVA = "0x41679B0", Offset = "0x41639B0", VA = "0x41679B0")]
		private void EnsureScrollListener()
		{
		}

		[Token(Token = "0x6003E07")]
		[Address(RVA = "0x4167AA8", Offset = "0x4163AA8", VA = "0x4167AA8")]
		private void ApplyScrollTargetIfNeeded(bool forceCanvasUpdate = true)
		{
		}

		[Token(Token = "0x6003E08")]
		[Address(RVA = "0x4167CD4", Offset = "0x4163CD4", VA = "0x4167CD4")]
		private void OnScrollValueChanged(Vector2 _)
		{
		}

		[Token(Token = "0x6003E09")]
		[Address(RVA = "0x4167D98", Offset = "0x4163D98", VA = "0x4167D98")]
		private void CancelScrollReturn()
		{
		}

		[Token(Token = "0x6003E0A")]
		[Address(RVA = "0x4167D1C", Offset = "0x4163D1C", VA = "0x4167D1C")]
		[AsyncStateMachine(typeof(_003CScheduleScrollReturn_003Ed__55))]
		private UniTaskVoid ScheduleScrollReturn()
		{
			return default;
		}

		[Token(Token = "0x6003E0B")]
		[Address(RVA = "0x4167B1C", Offset = "0x4163B1C", VA = "0x4167B1C")]
		private void ScrollToProgressCenter(bool forceCanvasUpdate = true)
		{
		}

		[Token(Token = "0x6003E0C")]
		[Address(RVA = "0x4167F20", Offset = "0x4163F20", VA = "0x4167F20")]
		[AsyncStateMachine(typeof(_003CResetProgrammaticScrollFlag_003Ed__57))]
		private UniTaskVoid ResetProgrammaticScrollFlag()
		{
			return default;
		}

		[Token(Token = "0x6003E0D")]
		[Address(RVA = "0x4167DCC", Offset = "0x4163DCC", VA = "0x4167DCC")]
		private float ResolveTrackFocusLocalX(float fillRatio)
		{
			return default;
		}

		[Token(Token = "0x6003E0E")]
		[Address(RVA = "0x4167F94", Offset = "0x4163F94", VA = "0x4167F94")]
		private void OnMilestoneClicked(TotalDiceConfig config)
		{
		}
	}
}
