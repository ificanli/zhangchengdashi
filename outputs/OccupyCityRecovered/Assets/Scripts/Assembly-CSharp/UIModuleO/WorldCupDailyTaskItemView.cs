using System;
using DataModule;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using ljzs_lt;

namespace UIModuleO
{
	[Token(Token = "0x2000662")]
	public class WorldCupDailyTaskItemView : MonoBehaviour
	{
		[Token(Token = "0x40033D4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _descText;

		[Token(Token = "0x40033D5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _progressText;

		[Token(Token = "0x40033D6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _progressFill;

		[Token(Token = "0x40033D7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RewardItemUI _rewardItemUi;

		[Token(Token = "0x40033D8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _claimButton;

		[Token(Token = "0x40033D9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _gotoButton;

		[Token(Token = "0x40033DA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TextMeshProUGUI _claimButtonText;

		[Token(Token = "0x40033DB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TextMeshProUGUI _gotoButtonText;

		[Token(Token = "0x40033DC")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _claimedRoot;

		[Token(Token = "0x40033DD")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _redDot;

		[Token(Token = "0x40033DE")]
		[FieldOffset(Offset = "0x70")]
		private WorldCupdailyTaskConfig _config;

		[Token(Token = "0x40033DF")]
		[FieldOffset(Offset = "0x78")]
		private Action<WorldCupdailyTaskConfig> _onClaim;

		[Token(Token = "0x40033E0")]
		[FieldOffset(Offset = "0x80")]
		private Action<WorldCupdailyTaskConfig> _onGoto;

		[Token(Token = "0x6002193")]
		[Address(RVA = "0x3F296AC", Offset = "0x3F256AC", VA = "0x3F296AC")]
		public void Bind(WorldCupdailyTaskConfig config, WorldCupDailyTaskRecord record, Action<WorldCupdailyTaskConfig> onClaim, Action<WorldCupdailyTaskConfig> onGoto)
		{
		}

		[Token(Token = "0x6002194")]
		[Address(RVA = "0x3F29A34", Offset = "0x3F25A34", VA = "0x3F29A34")]
		private void ApplyProgressFill(float fillAmount)
		{
		}

		[Token(Token = "0x6002195")]
		[Address(RVA = "0x3F29BA0", Offset = "0x3F25BA0", VA = "0x3F29BA0")]
		private void BindReward(WorldCupdailyTaskConfig config)
		{
		}

		[Token(Token = "0x6002196")]
		[Address(RVA = "0x3F2A074", Offset = "0x3F26074", VA = "0x3F2A074")]
		private void HideRedDot()
		{
		}

		[Token(Token = "0x6002197")]
		[Address(RVA = "0x3F29D38", Offset = "0x3F25D38", VA = "0x3F29D38")]
		private void SetButtonState(bool completed, bool claimed)
		{
		}

		[Token(Token = "0x6002198")]
		[Address(RVA = "0x3F29910", Offset = "0x3F25910", VA = "0x3F29910")]
		private static string FormatDescription(WorldCupdailyTaskConfig config)
		{
			return null;
		}

		[Token(Token = "0x6002199")]
		[Address(RVA = "0x3F2A0FC", Offset = "0x3F260FC", VA = "0x3F2A0FC")]
		private void OnClaimClicked()
		{
		}

		[Token(Token = "0x600219A")]
		[Address(RVA = "0x3F2A11C", Offset = "0x3F2611C", VA = "0x3F2A11C")]
		private void OnGotoClicked()
		{
		}

		[Token(Token = "0x600219B")]
		[Address(RVA = "0x3F2A13C", Offset = "0x3F2613C", VA = "0x3F2A13C")]
		public WorldCupDailyTaskItemView()
		{
		}
	}
}
