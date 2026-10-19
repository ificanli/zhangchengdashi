using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000686")]
	public class WorldCupShootResultPopup : ScaleTweenPanelViewBase
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000687")]
		[CompilerGenerated]
		private struct _003CShowAsync_003Ed__12 : IAsyncStateMachine
		{
			[Token(Token = "0x40034BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40034C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40034C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WorldCupShootResultPopup _003C_003E4__this;

			[Token(Token = "0x40034C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WorldCupShootResultPayload payload;

			[Token(Token = "0x40034C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action onClosed;

			[Token(Token = "0x40034C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600227E")]
			[Address(RVA = "0x3F37A7C", Offset = "0x3F33A7C", VA = "0x3F37A7C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600227F")]
			[Address(RVA = "0x3F37E84", Offset = "0x3F33E84", VA = "0x3F37E84", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40034B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _titleImage;

		[Token(Token = "0x40034B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite _goalTitleSprite;

		[Token(Token = "0x40034B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Sprite _missTitleSprite;

		[Token(Token = "0x40034B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Sprite _blockedTitleSprite;

		[Token(Token = "0x40034B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[FormerlySerializedAs("_footballRewardItem")]
		[SerializeField]
		private RewardItemUI _extraRewardItem;

		[Token(Token = "0x40034BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RewardItemUI _scoreRewardItem;

		[Token(Token = "0x40034BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _confirmButton;

		[Token(Token = "0x40034BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TextMeshProUGUI _confirmButtonText;

		[Token(Token = "0x40034BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Action _onClosed;

		[Token(Token = "0x40034BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private WorldCupShootOutcome _currentOutcome;

		[Token(Token = "0x600226E")]
		[Address(RVA = "0x3F37148", Offset = "0x3F33148", VA = "0x3F37148", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600226F")]
		[Address(RVA = "0x3F3710C", Offset = "0x3F3310C", VA = "0x3F3710C")]
		public void Show(WorldCupShootResultPayload payload, Action onClosed)
		{
		}

		[Token(Token = "0x6002270")]
		[Address(RVA = "0x3F372D8", Offset = "0x3F332D8", VA = "0x3F372D8")]
		[AsyncStateMachine(typeof(_003CShowAsync_003Ed__12))]
		public UniTask ShowAsync(WorldCupShootResultPayload payload, Action onClosed)
		{
			return default;
		}

		[Token(Token = "0x6002271")]
		[Address(RVA = "0x3F37378", Offset = "0x3F33378", VA = "0x3F37378", Slot = "7")]
		protected override bool ShouldPlayShowTween()
		{
			return default;
		}

		[Token(Token = "0x6002272")]
		[Address(RVA = "0x3F373D8", Offset = "0x3F333D8", VA = "0x3F373D8", Slot = "9")]
		protected override UniTask OnBeforeShowAsync()
		{
			return default;
		}

		[Token(Token = "0x6002273")]
		[Address(RVA = "0x3F37584", Offset = "0x3F33584", VA = "0x3F37584", Slot = "10")]
		protected override UniTask OnAfterShowAsync()
		{
			return default;
		}

		[Token(Token = "0x6002274")]
		[Address(RVA = "0x3F375EC", Offset = "0x3F335EC", VA = "0x3F375EC", Slot = "11")]
		protected override UniTask OnBeforeHideAsync()
		{
			return default;
		}

		[Token(Token = "0x6002275")]
		[Address(RVA = "0x3F37654", Offset = "0x3F33654", VA = "0x3F37654", Slot = "12")]
		protected override UniTask OnAfterHideAsync()
		{
			return default;
		}

		[Token(Token = "0x6002276")]
		[Address(RVA = "0x3F376CC", Offset = "0x3F336CC", VA = "0x3F376CC")]
		private void ApplyPayload(WorldCupShootResultPayload payload)
		{
		}

		[Token(Token = "0x6002277")]
		[Address(RVA = "0x3F377A8", Offset = "0x3F337A8", VA = "0x3F377A8")]
		private void ApplyTitle(WorldCupShootOutcome outcome)
		{
		}

		[Token(Token = "0x6002278")]
		[Address(RVA = "0x3F3789C", Offset = "0x3F3389C", VA = "0x3F3789C")]
		private static void ApplyRewardItem(RewardItemUI rewardItem, string rewardRaw)
		{
		}

		[Token(Token = "0x6002279")]
		[Address(RVA = "0x3F374E0", Offset = "0x3F334E0", VA = "0x3F374E0")]
		private void PlayResultSfx()
		{
		}

		[Token(Token = "0x600227A")]
		[Address(RVA = "0x3F37448", Offset = "0x3F33448", VA = "0x3F37448")]
		private void SetConfirmInteractable(bool interactable)
		{
		}

		[Token(Token = "0x600227B")]
		[Address(RVA = "0x3F37A40", Offset = "0x3F33A40", VA = "0x3F37A40")]
		private void OnConfirmClicked()
		{
		}

		[Token(Token = "0x600227C")]
		[Address(RVA = "0x3F37A6C", Offset = "0x3F33A6C", VA = "0x3F37A6C")]
		public WorldCupShootResultPopup()
		{
		}
	}
}
