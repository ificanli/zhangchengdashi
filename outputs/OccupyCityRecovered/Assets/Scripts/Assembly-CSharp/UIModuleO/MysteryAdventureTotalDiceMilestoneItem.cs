using System;
using GameModule;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using ljzs_lt;

namespace UIModuleO
{
	[Token(Token = "0x2000A54")]
	public class MysteryAdventureTotalDiceMilestoneItem : MonoBehaviour
	{
		[Token(Token = "0x4004C65")]
		private const float SpecialRewardScale = 1.5f;

		[Token(Token = "0x4004C66")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _clickButton;

		[Token(Token = "0x4004C67")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _rewardRoot;

		[Token(Token = "0x4004C68")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RewardItemUI _rewardItemUi;

		[Token(Token = "0x4004C69")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _thresholdText;

		[Token(Token = "0x4004C6A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _checkmarkImage;

		[Token(Token = "0x4004C6B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _redDot;

		[Token(Token = "0x4004C6C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _claimableEffect;

		[Token(Token = "0x4004C6D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[Token(Token = "0x4004C6E")]
		[FieldOffset(Offset = "0x60")]
		private TotalDiceConfig _config;

		[Token(Token = "0x4004C6F")]
		[FieldOffset(Offset = "0x68")]
		private RewardConfigSingle _rewardData;

		[Token(Token = "0x4004C70")]
		[FieldOffset(Offset = "0x70")]
		private MysteryAdventureTotalDiceMilestoneState _state;

		[Token(Token = "0x4004C71")]
		[FieldOffset(Offset = "0x78")]
		private Action<TotalDiceConfig> _onClaim;

		[Token(Token = "0x4004C72")]
		[FieldOffset(Offset = "0x80")]
		private bool _stateApplied;

		[Token(Token = "0x4004C73")]
		[FieldOffset(Offset = "0x81")]
		private bool _claimableEffectWanted;

		[Token(Token = "0x4004C74")]
		[FieldOffset(Offset = "0x82")]
		private bool _claimableEffectVisible;

		[Token(Token = "0x4004C75")]
		[FieldOffset(Offset = "0x88")]
		private RectTransform _clipBounds;

		[Token(Token = "0x17000953")]
		public TotalDiceConfig Config
		{
			[Token(Token = "0x6003DCC")]
			[Address(RVA = "0x4162DA8", Offset = "0x415EDA8", VA = "0x4162DA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000954")]
		public MysteryAdventureTotalDiceMilestoneState State
		{
			[Token(Token = "0x6003DCD")]
			[Address(RVA = "0x4162DB0", Offset = "0x415EDB0", VA = "0x4162DB0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6003DCE")]
		[Address(RVA = "0x4162DB8", Offset = "0x415EDB8", VA = "0x4162DB8")]
		internal static void ConfigureRewardItemUi(RewardItemUI rewardItemUi, bool showPropDetails = false)
		{
		}

		[Token(Token = "0x6003DCF")]
		[Address(RVA = "0x4162DF4", Offset = "0x415EDF4", VA = "0x4162DF4")]
		internal static void BindRewardDetailClick(RectTransform clickRoot, RewardItemUI rewardItemUi, RewardConfigSingle rewardData)
		{
		}

		[Token(Token = "0x6003DD0")]
		[Address(RVA = "0x41631EC", Offset = "0x415F1EC", VA = "0x41631EC")]
		internal static void TryShowRewardDetails(RewardItemUI rewardItemUi, RewardConfigSingle rewardData)
		{
		}

		[Token(Token = "0x6003DD1")]
		[Address(RVA = "0x4163108", Offset = "0x415F108", VA = "0x4163108")]
		internal static void DisableRewardItemRaycast(RewardItemUI rewardItemUi)
		{
		}

		[Token(Token = "0x6003DD2")]
		[Address(RVA = "0x4163334", Offset = "0x415F334", VA = "0x4163334")]
		private void EnsureClickHitArea()
		{
		}

		[Token(Token = "0x6003DD3")]
		[Address(RVA = "0x4163550", Offset = "0x415F550", VA = "0x4163550")]
		public void BindReferences(Button clickButton, RectTransform rewardRoot, RewardItemUI rewardItemUi, TextMeshProUGUI thresholdText, Image checkmarkImage, GameObject redDot, CanvasGroup canvasGroup)
		{
		}

		[Token(Token = "0x6003DD4")]
		[Address(RVA = "0x4163634", Offset = "0x415F634", VA = "0x4163634")]
		public void BindStatic(TotalDiceConfig config, Action<TotalDiceConfig> onClaim)
		{
		}

		[Token(Token = "0x6003DD5")]
		[Address(RVA = "0x4163834", Offset = "0x415F834", VA = "0x4163834")]
		public void ApplyStateIfChanged(MysteryAdventureTotalDiceMilestoneState state)
		{
		}

		[Token(Token = "0x6003DD6")]
		[Address(RVA = "0x41639E4", Offset = "0x415F9E4", VA = "0x41639E4")]
		public void Bind(TotalDiceConfig config, MysteryAdventureTotalDiceMilestoneState state, Action<TotalDiceConfig> onClaim)
		{
		}

		[Token(Token = "0x6003DD7")]
		[Address(RVA = "0x4163A30", Offset = "0x415FA30", VA = "0x4163A30")]
		public void ApplyDisplayScale(bool isSpecialReward)
		{
		}

		[Token(Token = "0x6003DD8")]
		[Address(RVA = "0x4163850", Offset = "0x415F850", VA = "0x4163850")]
		public void ApplyState(MysteryAdventureTotalDiceMilestoneState state)
		{
		}

		[Token(Token = "0x6003DD9")]
		[Address(RVA = "0x4163CC0", Offset = "0x415FCC0", VA = "0x4163CC0")]
		private void OnClicked()
		{
		}

		[Token(Token = "0x6003DDA")]
		[Address(RVA = "0x4163D00", Offset = "0x415FD00", VA = "0x4163D00")]
		private void ShowRewardDetails()
		{
		}

		[Token(Token = "0x6003DDB")]
		[Address(RVA = "0x4163D10", Offset = "0x415FD10", VA = "0x4163D10")]
		private void EnsureClaimableEffect()
		{
		}

		[Token(Token = "0x6003DDC")]
		[Address(RVA = "0x4164014", Offset = "0x4160014", VA = "0x4164014")]
		public void SetClipBounds(RectTransform clipBounds)
		{
		}

		[Token(Token = "0x6003DDD")]
		[Address(RVA = "0x4163B28", Offset = "0x415FB28", VA = "0x4163B28")]
		public void RefreshClaimableEffectVisibility()
		{
		}

		[Token(Token = "0x6003DDE")]
		[Address(RVA = "0x416401C", Offset = "0x416001C", VA = "0x416401C")]
		private void EnsureClaimableEffectActive()
		{
		}

		[Token(Token = "0x6003DDF")]
		[Address(RVA = "0x4163E7C", Offset = "0x415FE7C", VA = "0x4163E7C")]
		private static GameObject FindClaimableEffectRoot(Transform root)
		{
			return null;
		}

		[Token(Token = "0x6003DE0")]
		[Address(RVA = "0x41640B0", Offset = "0x41600B0", VA = "0x41640B0")]
		public MysteryAdventureTotalDiceMilestoneItem()
		{
		}
	}
}
