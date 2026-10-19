using System;
using DataModule;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using ljzs_lt;

namespace UIModuleO
{
	[Token(Token = "0x20009CA")]
	public class MysteryAdventureDailyTaskItemView : MonoBehaviour
	{
		[Token(Token = "0x40048EF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _descText;

		[Token(Token = "0x40048F0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _progressText;

		[Token(Token = "0x40048F1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _progressFill;

		[Token(Token = "0x40048F2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RewardItemUI _rewardItemUi;

		[Token(Token = "0x40048F3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _claimButton;

		[Token(Token = "0x40048F4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _gotoButton;

		[Token(Token = "0x40048F5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TextMeshProUGUI _claimButtonText;

		[Token(Token = "0x40048F6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TextMeshProUGUI _gotoButtonText;

		[Token(Token = "0x40048F7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _claimedRoot;

		[Token(Token = "0x40048F8")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _redDot;

		[Token(Token = "0x40048F9")]
		[FieldOffset(Offset = "0x70")]
		private DailyTaskConfig _config;

		[Token(Token = "0x40048FA")]
		[FieldOffset(Offset = "0x78")]
		private Action<DailyTaskConfig> _onClaim;

		[Token(Token = "0x40048FB")]
		[FieldOffset(Offset = "0x80")]
		private Action<DailyTaskConfig> _onGoto;

		[Token(Token = "0x6003A43")]
		[Address(RVA = "0x4112B70", Offset = "0x410EB70", VA = "0x4112B70")]
		public void BindReferences(TextMeshProUGUI descText, TextMeshProUGUI progressText, Image progressFill, RewardItemUI rewardItemUi, Button claimButton, Button gotoButton, TextMeshProUGUI claimButtonText, TextMeshProUGUI gotoButtonText, GameObject claimedRoot, GameObject redDot)
		{
		}

		[Token(Token = "0x6003A44")]
		[Address(RVA = "0x4112B94", Offset = "0x410EB94", VA = "0x4112B94")]
		public void Bind(DailyTaskConfig config, MysteryAdventureDailyTaskRecord record, Action<DailyTaskConfig> onClaim, Action<DailyTaskConfig> onGoto)
		{
		}

		[Token(Token = "0x6003A45")]
		[Address(RVA = "0x4112F24", Offset = "0x410EF24", VA = "0x4112F24")]
		private void ResolveProgressFill()
		{
		}

		[Token(Token = "0x6003A46")]
		[Address(RVA = "0x4113014", Offset = "0x410F014", VA = "0x4113014")]
		private void ApplyProgressFill(float fillAmount)
		{
		}

		[Token(Token = "0x6003A47")]
		[Address(RVA = "0x4113180", Offset = "0x410F180", VA = "0x4113180")]
		private void BindReward(DailyTaskConfig config)
		{
		}

		[Token(Token = "0x6003A48")]
		[Address(RVA = "0x41136CC", Offset = "0x410F6CC", VA = "0x41136CC")]
		private void HideRedDot()
		{
		}

		[Token(Token = "0x6003A49")]
		[Address(RVA = "0x4113390", Offset = "0x410F390", VA = "0x4113390")]
		private void SetButtonState(bool completed, bool claimed)
		{
		}

		[Token(Token = "0x6003A4A")]
		[Address(RVA = "0x4112E00", Offset = "0x410EE00", VA = "0x4112E00")]
		private static string FormatDescription(DailyTaskConfig config)
		{
			return null;
		}

		[Token(Token = "0x6003A4B")]
		[Address(RVA = "0x41137EC", Offset = "0x410F7EC", VA = "0x41137EC")]
		private void OnClaimClicked()
		{
		}

		[Token(Token = "0x6003A4C")]
		[Address(RVA = "0x411380C", Offset = "0x410F80C", VA = "0x411380C")]
		private void OnGotoClicked()
		{
		}

		[Token(Token = "0x6003A4D")]
		[Address(RVA = "0x411382C", Offset = "0x410F82C", VA = "0x411382C")]
		public MysteryAdventureDailyTaskItemView()
		{
		}
	}
}
