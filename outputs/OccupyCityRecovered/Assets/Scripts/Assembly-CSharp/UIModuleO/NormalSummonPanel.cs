using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using Spine;
using TimeModuleO;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000A6C")]
	public class NormalSummonPanel : NormalSummonPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A71")]
		[CompilerGenerated]
		private struct _003CHideWhiteMaskAfterPanelOpened_003Ed__42 : IAsyncStateMachine
		{
			[Token(Token = "0x4004D1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004D1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004D1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public NormalSummonPanel _003C_003E4__this;

			[Token(Token = "0x4004D1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Image _003CsummonMaskImage_003E5__2;

			[Token(Token = "0x4004D20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003EC2")]
			[Address(RVA = "0x4173A98", Offset = "0x416FA98", VA = "0x4173A98", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003EC3")]
			[Address(RVA = "0x4173D14", Offset = "0x416FD14", VA = "0x4173D14", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A72")]
		[CompilerGenerated]
		private struct _003CHideWhiteMaskFallback_003Ed__43 : IAsyncStateMachine
		{
			[Token(Token = "0x4004D21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004D22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004D23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float timeoutSeconds;

			[Token(Token = "0x4004D24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public NormalSummonPanel _003C_003E4__this;

			[Token(Token = "0x4004D25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int seqId;

			[Token(Token = "0x4004D26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Image summonMaskImage;

			[Token(Token = "0x4004D27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003EC4")]
			[Address(RVA = "0x4173D20", Offset = "0x416FD20", VA = "0x4173D20", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003EC5")]
			[Address(RVA = "0x4174150", Offset = "0x4170150", VA = "0x4174150", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A73")]
		[CompilerGenerated]
		private struct _003CSeSummonAnimeCallBack_003Ed__38 : IAsyncStateMachine
		{
			[Token(Token = "0x4004D28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004D29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004D2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public NormalSummonPanel _003C_003E4__this;

			[Token(Token = "0x4004D2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action callback;

			[Token(Token = "0x6003EC6")]
			[Address(RVA = "0x417415C", Offset = "0x417015C", VA = "0x417415C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003EC7")]
			[Address(RVA = "0x41745B4", Offset = "0x41705B4", VA = "0x41745B4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A74")]
		[CompilerGenerated]
		private struct _003CTriggerSummonAnimationCompleteBeforeEnd_003Ed__40 : IAsyncStateMachine
		{
			[Token(Token = "0x4004D2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004D2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004D2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TrackEntry trackEntry;

			[Token(Token = "0x4004D2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float secondsBeforeEnd;

			[Token(Token = "0x4004D30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int seqId;

			[Token(Token = "0x4004D31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public NormalSummonPanel _003C_003E4__this;

			[Token(Token = "0x4004D32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Image summonMaskImage;

			[Token(Token = "0x4004D33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003EC8")]
			[Address(RVA = "0x41745C0", Offset = "0x41705C0", VA = "0x41745C0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003EC9")]
			[Address(RVA = "0x4174920", Offset = "0x4170920", VA = "0x4174920", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004CF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Action SummonAnimeCallBack;

		[Token(Token = "0x4004CFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private TimeManager.Timer lotteryTimer;

		[Token(Token = "0x4004CFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool summonRefreshEnd;

		[Token(Token = "0x4004CFC")]
		private const string summonAnimation_2 = "action2";

		[Token(Token = "0x4004CFD")]
		private const string summonAnimation_1 = "action1";

		[Token(Token = "0x4004CFE")]
		private const string NormalSummonTimesLimitTipText = "剩余次数不足";

		[Token(Token = "0x4004CFF")]
		private const int AdSummonCount = 10;

		[Token(Token = "0x4004D00")]
		private const int NormalSummonUnitCost = 5;

		[Token(Token = "0x4004D01")]
		private const int AdvancedSummonUnitCost = 5;

		[Token(Token = "0x4004D02")]
		private const int NormalSummonCount = 10;

		[Token(Token = "0x4004D03")]
		private const int AdvancedSummonCount = 100;

		[Token(Token = "0x4004D04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x129")]
		private bool _waitingPropLotteryPanelOpen;

		[Token(Token = "0x4004D05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private int _summonSequenceId;

		[Token(Token = "0x4004D06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private int _summonCompleteHandledSeqId;

		[Token(Token = "0x4004D07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private bool _isNormalTenSummon;

		[Token(Token = "0x4004D08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x135")]
		private bool _isAdvancedTenSummon;

		[Token(Token = "0x4004D09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private readonly Color _costColorEnough;

		[Token(Token = "0x4004D0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private readonly Color _costColorNotEnough;

		[Token(Token = "0x4004D0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Action<string> _onDiamondResourceChanged;

		[Token(Token = "0x4004D0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private ArtifactsSummonPanel _rootPanel;

		[Token(Token = "0x6003E9E")]
		[Address(RVA = "0x4170584", Offset = "0x416C584", VA = "0x4170584", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6003E9F")]
		[Address(RVA = "0x4170790", Offset = "0x416C790", VA = "0x4170790")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6003EA0")]
		[Address(RVA = "0x4171D58", Offset = "0x416DD58", VA = "0x4171D58")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6003EA1")]
		[Address(RVA = "0x4171F58", Offset = "0x416DF58", VA = "0x4171F58")]
		private void OnUpdateResourcesUI(object obj)
		{
		}

		[Token(Token = "0x6003EA2")]
		[Address(RVA = "0x4172178", Offset = "0x416E178", VA = "0x4172178")]
		private void OnDiamondResourceChanged(string count)
		{
		}

		[Token(Token = "0x6003EA3")]
		[Address(RVA = "0x4170D98", Offset = "0x416CD98", VA = "0x4170D98")]
		private void UpdateArtifacts(object o)
		{
		}

		[Token(Token = "0x6003EA4")]
		[Address(RVA = "0x4172560", Offset = "0x416E560", VA = "0x4172560")]
		private void Update()
		{
		}

		[Token(Token = "0x6003EA5")]
		[Address(RVA = "0x41727F4", Offset = "0x416E7F4", VA = "0x41727F4")]
		private void SummonAdCallBack()
		{
		}

		[Token(Token = "0x6003EA6")]
		[Address(RVA = "0x4172730", Offset = "0x416E730", VA = "0x4172730")]
		private bool CanUseAdSummon()
		{
			return default;
		}

		[Token(Token = "0x6003EA7")]
		[Address(RVA = "0x4172984", Offset = "0x416E984", VA = "0x4172984", Slot = "16")]
		protected override void OnButtonExtendBtnGemSummonClicked()
		{
		}

		[Token(Token = "0x6003EA8")]
		[Address(RVA = "0x4172BE8", Offset = "0x416EBE8", VA = "0x4172BE8", Slot = "14")]
		protected override void OnButtonExtendBtnGemSummonNormalClicked()
		{
		}

		[Token(Token = "0x6003EA9")]
		[Address(RVA = "0x4172BF8", Offset = "0x416EBF8", VA = "0x4172BF8", Slot = "17")]
		protected override void OnToggleSwitchSummonCountValueChanged(bool isOn)
		{
		}

		[Token(Token = "0x6003EAA")]
		[Address(RVA = "0x4172C04", Offset = "0x416EC04", VA = "0x4172C04", Slot = "15")]
		protected override void OnToggleSwitchSummonCountNormalValueChanged(bool isOn)
		{
		}

		[Token(Token = "0x6003EAB")]
		[Address(RVA = "0x4171B20", Offset = "0x416DB20", VA = "0x4171B20")]
		private void RefreshGemSummonUI()
		{
		}

		[Token(Token = "0x6003EAC")]
		[Address(RVA = "0x4171FD0", Offset = "0x416DFD0", VA = "0x4171FD0")]
		private void RefreshGemSummonCostColor()
		{
		}

		[Token(Token = "0x6003EAD")]
		[Address(RVA = "0x4172994", Offset = "0x416E994", VA = "0x4172994")]
		private void SummonByDiamond(int unitCost, int summonBaseCount, bool isTenSummon)
		{
		}

		[Token(Token = "0x6003EAE")]
		[Address(RVA = "0x417217C", Offset = "0x416E17C", VA = "0x417217C")]
		private void RefreshNormalSummonTimesLimit()
		{
		}

		[Token(Token = "0x6003EAF")]
		[Address(RVA = "0x4171C58", Offset = "0x416DC58", VA = "0x4171C58")]
		private void RefreshAdAndNormalSummonButtons()
		{
		}

		[Token(Token = "0x6003EB0")]
		[Address(RVA = "0x41728E8", Offset = "0x416E8E8", VA = "0x41728E8")]
		[AsyncStateMachine(typeof(_003CSeSummonAnimeCallBack_003Ed__38))]
		private void SeSummonAnimeCallBack(Action callback)
		{
		}

		[Token(Token = "0x6003EB1")]
		[Address(RVA = "0x4173000", Offset = "0x416F000", VA = "0x4173000")]
		private void HandleSummonAnimationComplete(TrackEntry trackEntry, int seqId, Image summonMaskImage)
		{
		}

		[Token(Token = "0x6003EB2")]
		[Address(RVA = "0x4173154", Offset = "0x416F154", VA = "0x4173154")]
		[AsyncStateMachine(typeof(_003CTriggerSummonAnimationCompleteBeforeEnd_003Ed__40))]
		private UniTaskVoid TriggerSummonAnimationCompleteBeforeEnd(TrackEntry trackEntry, int seqId, Image summonMaskImage, float secondsBeforeEnd)
		{
			return default;
		}

		[Token(Token = "0x6003EB3")]
		[Address(RVA = "0x4173200", Offset = "0x416F200", VA = "0x4173200")]
		private void OnPropLotteryPanelChangeActive(object o)
		{
		}

		[Token(Token = "0x6003EB4")]
		[Address(RVA = "0x4173344", Offset = "0x416F344", VA = "0x4173344")]
		[AsyncStateMachine(typeof(_003CHideWhiteMaskAfterPanelOpened_003Ed__42))]
		private UniTaskVoid HideWhiteMaskAfterPanelOpened()
		{
			return default;
		}

		[Token(Token = "0x6003EB5")]
		[Address(RVA = "0x41733BC", Offset = "0x416F3BC", VA = "0x41733BC")]
		[AsyncStateMachine(typeof(_003CHideWhiteMaskFallback_003Ed__43))]
		private UniTaskVoid HideWhiteMaskFallback(int seqId, Image summonMaskImage, float timeoutSeconds)
		{
			return default;
		}

		[Token(Token = "0x6003EB6")]
		[Address(RVA = "0x417345C", Offset = "0x416F45C", VA = "0x417345C", Slot = "12")]
		protected override void OnButtonExtendBtnSummonDesClicked()
		{
		}

		[Token(Token = "0x6003EB7")]
		[Address(RVA = "0x4173530", Offset = "0x416F530", VA = "0x4173530", Slot = "13")]
		protected override void OnAdButtonExtendBtnAdSummonClicked()
		{
		}

		[Token(Token = "0x6003EB8")]
		[Address(RVA = "0x4173534", Offset = "0x416F534", VA = "0x4173534")]
		private Image GetSummonMaskImage()
		{
			return null;
		}

		[Token(Token = "0x6003EB9")]
		[Address(RVA = "0x4173610", Offset = "0x416F610", VA = "0x4173610")]
		public NormalSummonPanel()
		{
		}
	}
}
