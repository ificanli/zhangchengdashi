using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using DataModule;
using Il2CppDummyDll;
using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20006CD")]
	public class ArtifactEntryRefreshPanel : ArtifactEntryRefreshPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006CE")]
		[CompilerGenerated]
		private struct _003CHandleForgingAsync_003Ed__28 : IAsyncStateMachine
		{
			[Token(Token = "0x4003683")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArtifactEntryRefreshPanel _003C_003E4__this;

			[Token(Token = "0x4003686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002495")]
			[Address(RVA = "0x3F5D1C8", Offset = "0x3F591C8", VA = "0x3F5D1C8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002496")]
			[Address(RVA = "0x3F5DB0C", Offset = "0x3F59B0C", VA = "0x3F5DB0C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006CF")]
		[CompilerGenerated]
		private struct _003COnButtonExtendIntroduceClicked_003Ed__32 : IAsyncStateMachine
		{
			[Token(Token = "0x4003687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ArtifactEntryRefreshPanel _003C_003E4__this;

			[Token(Token = "0x400368A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002497")]
			[Address(RVA = "0x3F5DB18", Offset = "0x3F59B18", VA = "0x3F5DB18", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002498")]
			[Address(RVA = "0x3F5DEB4", Offset = "0x3F59EB4", VA = "0x3F5DEB4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006D0")]
		[CompilerGenerated]
		private struct _003CPlayBotEntryContentFadeAnimAsync_003Ed__41 : IAsyncStateMachine
		{
			[Token(Token = "0x400368B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400368C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400368D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float delay;

			[Token(Token = "0x400368E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int revealVersion;

			[Token(Token = "0x400368F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ArtifactEntryRefreshPanel _003C_003E4__this;

			[Token(Token = "0x4003690")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002499")]
			[Address(RVA = "0x3F5DEC0", Offset = "0x3F59EC0", VA = "0x3F5DEC0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600249A")]
			[Address(RVA = "0x3F5E540", Offset = "0x3F5A540", VA = "0x3F5E540", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006D1")]
		[CompilerGenerated]
		private struct _003CPlayBotEntryRevealSequenceAsync_003Ed__38 : IAsyncStateMachine
		{
			[Token(Token = "0x4003691")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003692")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArtifactEntryRefreshPanel _003C_003E4__this;

			[Token(Token = "0x4003694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int _003CrevealVersion_003E5__2;

			[Token(Token = "0x4003695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600249B")]
			[Address(RVA = "0x3F5E54C", Offset = "0x3F5A54C", VA = "0x3F5E54C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600249C")]
			[Address(RVA = "0x3F5EBC0", Offset = "0x3F5ABC0", VA = "0x3F5EBC0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006D2")]
		[CompilerGenerated]
		private struct _003CPlayBotEntrySweepEffectAsync_003Ed__40 : IAsyncStateMachine
		{
			[Token(Token = "0x4003696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArtifactEntryRefreshPanel _003C_003E4__this;

			[Token(Token = "0x4003699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float animationDuration;

			[Token(Token = "0x400369A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int revealVersion;

			[Token(Token = "0x400369B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private SkeletonGraphic _003CsweepSpine_003E5__2;

			[Token(Token = "0x400369C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600249D")]
			[Address(RVA = "0x3F5EBCC", Offset = "0x3F5ABCC", VA = "0x3F5EBCC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600249E")]
			[Address(RVA = "0x3F5F1E4", Offset = "0x3F5B1E4", VA = "0x3F5F1E4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006D3")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__21 : IAsyncStateMachine
		{
			[Token(Token = "0x400369D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400369E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400369F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArtifactEntryRefreshPanel _003C_003E4__this;

			[Token(Token = "0x40036A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x40036A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600249F")]
			[Address(RVA = "0x3F5F1F0", Offset = "0x3F5B1F0", VA = "0x3F5F1F0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60024A0")]
			[Address(RVA = "0x3F5F918", Offset = "0x3F5B918", VA = "0x3F5F918", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006D4")]
		[CompilerGenerated]
		private struct _003CUpdateUI_003Ed__23 : IAsyncStateMachine
		{
			[Token(Token = "0x40036A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40036A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40036A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArtifactEntryRefreshPanel _003C_003E4__this;

			[Token(Token = "0x40036A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool showNewEntryContent;

			[Token(Token = "0x40036A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private GlobalArtifactsForgeInfo _003CnewInfo_003E5__2;

			[Token(Token = "0x40036A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private bool _003ChasNewEntry_003E5__3;

			[Token(Token = "0x40036A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Image _003C_003E7__wrap3;

			[Token(Token = "0x40036A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60024A1")]
			[Address(RVA = "0x3F5F924", Offset = "0x3F5B924", VA = "0x3F5F924", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60024A2")]
			[Address(RVA = "0x3F60504", Offset = "0x3F5C504", VA = "0x3F60504", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400366F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private TextMeshProUGUI dailyLimit;

		[Token(Token = "0x4003670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private UserPropData data;

		[Token(Token = "0x4003671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private string entryId;

		[Token(Token = "0x4003672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private string newEntryId;

		[Token(Token = "0x4003673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private bool isForging;

		[Token(Token = "0x4003674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private int forgingLevel;

		[Token(Token = "0x4003675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private bool? isNewEntrySelected;

		[Token(Token = "0x4003676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFA")]
		private bool forgingCooldown;

		[Token(Token = "0x4003677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Sequence _botEntryRevealSequence;

		[Token(Token = "0x4003678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Vector3 _botEntryIconOriginalScale;

		[Token(Token = "0x4003679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _botEntryTextOriginalScale;

		[Token(Token = "0x400367A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Color _botEntryIconOriginalColor;

		[Token(Token = "0x400367B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Color _botEntryTextOriginalColor;

		[Token(Token = "0x400367C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private bool _botEntryAnimStateCached;

		[Token(Token = "0x400367D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		private int _botEntryRevealVersion;

		[Token(Token = "0x400367E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private bool _isBotEntryRevealPlaying;

		[Token(Token = "0x400367F")]
		private const string BotEntrySweepAnimationName = "DZ";

		[Token(Token = "0x4003680")]
		private const float BotEntryRevealFallbackDuration = 0.35f;

		[Token(Token = "0x4003681")]
		private const float BotEntryContentFadeDuration = 0.28f;

		[Token(Token = "0x4003682")]
		private const float BotEntryContentFadeLeadRatio = 0.75f;

		[Token(Token = "0x6002472")]
		[Address(RVA = "0x3F5B2C0", Offset = "0x3F572C0", VA = "0x3F5B2C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002473")]
		[Address(RVA = "0x3F5B4A8", Offset = "0x3F574A8", VA = "0x3F5B4A8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__21))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002474")]
		[Address(RVA = "0x3F5B544", Offset = "0x3F57544", VA = "0x3F5B544", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002475")]
		[Address(RVA = "0x3F5B7E0", Offset = "0x3F577E0", VA = "0x3F5B7E0")]
		[AsyncStateMachine(typeof(_003CUpdateUI_003Ed__23))]
		private UniTask UpdateUI(bool showNewEntryContent = true)
		{
			return default;
		}

		[Token(Token = "0x6002476")]
		[Address(RVA = "0x3F5B888", Offset = "0x3F57888", VA = "0x3F5B888")]
		private void RefreshDailyForgeTimesLimit()
		{
		}

		[Token(Token = "0x6002477")]
		[Address(RVA = "0x3F5B9C8", Offset = "0x3F579C8", VA = "0x3F5B9C8")]
		private string GetColoredTraitDescription(string traitId)
		{
			return null;
		}

		[Token(Token = "0x6002478")]
		[Address(RVA = "0x3F5BAAC", Offset = "0x3F57AAC", VA = "0x3F5BAAC")]
		private string GetQualityColorHex(int quality)
		{
			return null;
		}

		[Token(Token = "0x6002479")]
		[Address(RVA = "0x3F5BB3C", Offset = "0x3F57B3C", VA = "0x3F5BB3C", Slot = "16")]
		protected override void OnButtonExtendBtnForgingClicked()
		{
		}

		[Token(Token = "0x600247A")]
		[Address(RVA = "0x3F5BBE0", Offset = "0x3F57BE0", VA = "0x3F5BBE0")]
		[AsyncStateMachine(typeof(_003CHandleForgingAsync_003Ed__28))]
		private UniTask HandleForgingAsync()
		{
			return default;
		}

		[Token(Token = "0x600247B")]
		[Address(RVA = "0x3F5BC6C", Offset = "0x3F57C6C", VA = "0x3F5BC6C", Slot = "17")]
		protected override void OnButtonExtendBtnReplaceClicked()
		{
		}

		[Token(Token = "0x600247C")]
		[Address(RVA = "0x3F5BEB0", Offset = "0x3F57EB0", VA = "0x3F5BEB0", Slot = "14")]
		protected override void OnButtonExtendKeepClicked()
		{
		}

		[Token(Token = "0x600247D")]
		[Address(RVA = "0x3F5BFD0", Offset = "0x3F57FD0", VA = "0x3F5BFD0", Slot = "15")]
		protected override void OnButtonExtendBotEntryClicked()
		{
		}

		[Token(Token = "0x600247E")]
		[Address(RVA = "0x3F5C080", Offset = "0x3F58080", VA = "0x3F5C080", Slot = "18")]
		[AsyncStateMachine(typeof(_003COnButtonExtendIntroduceClicked_003Ed__32))]
		protected override void OnButtonExtendIntroduceClicked()
		{
		}

		[Token(Token = "0x600247F")]
		[Address(RVA = "0x3F5BF60", Offset = "0x3F57F60", VA = "0x3F5BF60")]
		private void SelectEntry(bool selectNew)
		{
		}

		[Token(Token = "0x6002480")]
		[Address(RVA = "0x3F5C10C", Offset = "0x3F5810C", VA = "0x3F5C10C")]
		private void UpdateSelectionVisual()
		{
		}

		[Token(Token = "0x6002481")]
		[Address(RVA = "0x3F5BEA8", Offset = "0x3F57EA8", VA = "0x3F5BEA8")]
		private void ClearSelection()
		{
		}

		[Token(Token = "0x6002482")]
		[Address(RVA = "0x3F5C350", Offset = "0x3F58350", VA = "0x3F5C350")]
		private void ResetSelectionVisual()
		{
		}

		[Token(Token = "0x6002483")]
		[Address(RVA = "0x3F5B3F0", Offset = "0x3F573F0", VA = "0x3F5B3F0")]
		private void CacheBotEntryAnimState()
		{
		}

		[Token(Token = "0x6002484")]
		[Address(RVA = "0x3F5C6C4", Offset = "0x3F586C4", VA = "0x3F5C6C4")]
		[AsyncStateMachine(typeof(_003CPlayBotEntryRevealSequenceAsync_003Ed__38))]
		private UniTask PlayBotEntryRevealSequenceAsync()
		{
			return default;
		}

		[Token(Token = "0x6002485")]
		[Address(RVA = "0x3F5C754", Offset = "0x3F58754", VA = "0x3F5C754")]
		private float GetBotEntrySweepDuration()
		{
			return default;
		}

		[Token(Token = "0x6002486")]
		[Address(RVA = "0x3F5C924", Offset = "0x3F58924", VA = "0x3F5C924")]
		[AsyncStateMachine(typeof(_003CPlayBotEntrySweepEffectAsync_003Ed__40))]
		private UniTask PlayBotEntrySweepEffectAsync(int revealVersion, float animationDuration)
		{
			return default;
		}

		[Token(Token = "0x6002487")]
		[Address(RVA = "0x3F5C9D0", Offset = "0x3F589D0", VA = "0x3F5C9D0")]
		[AsyncStateMachine(typeof(_003CPlayBotEntryContentFadeAnimAsync_003Ed__41))]
		private UniTask PlayBotEntryContentFadeAnimAsync(int revealVersion, float delay)
		{
			return default;
		}

		[Token(Token = "0x6002488")]
		[Address(RVA = "0x3F5CA80", Offset = "0x3F58A80", VA = "0x3F5CA80")]
		private void PlayBotEntryContentFadeAnim()
		{
		}

		[Token(Token = "0x6002489")]
		[Address(RVA = "0x3F5B62C", Offset = "0x3F5762C", VA = "0x3F5B62C")]
		private void StopBotEntryRevealAnim()
		{
		}

		[Token(Token = "0x600248A")]
		[Address(RVA = "0x3F5CDEC", Offset = "0x3F58DEC", VA = "0x3F5CDEC")]
		private void ResetBotEntryVisualState()
		{
		}

		[Token(Token = "0x600248B")]
		[Address(RVA = "0x3F5CEA0", Offset = "0x3F58EA0", VA = "0x3F5CEA0", Slot = "13")]
		protected override void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x600248C")]
		[Address(RVA = "0x3F5CF2C", Offset = "0x3F58F2C", VA = "0x3F5CF2C", Slot = "12")]
		protected override void OnButtonBackgroundClicked()
		{
		}

		[Token(Token = "0x600248D")]
		[Address(RVA = "0x3F5CFB8", Offset = "0x3F58FB8", VA = "0x3F5CFB8")]
		public ArtifactEntryRefreshPanel()
		{
		}
	}
}
