using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using ljzs_lt;

namespace UIModuleO
{
	[Token(Token = "0x2000689")]
	public class WorldCupPointShopItemView : MonoBehaviour
	{
		[Token(Token = "0x40034CA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _backgroundImage;

		[Token(Token = "0x40034CB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _titleText;

		[Token(Token = "0x40034CC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RewardItemUI _rewardItemUi;

		[Token(Token = "0x40034CD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _limitText;

		[Token(Token = "0x40034CE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _buyButton;

		[Token(Token = "0x40034CF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TextMeshProUGUI _priceText;

		[Token(Token = "0x40034D0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _soldOutRoot;

		[Token(Token = "0x40034D1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TextMeshProUGUI _newBannerTagText;

		[Token(Token = "0x40034D2")]
		private const int PointShopItemTypeBanner = 6;

		[Token(Token = "0x40034D3")]
		private const int PointShopItemTypeExpression = 7;

		[Token(Token = "0x40034D4")]
		[FieldOffset(Offset = "0x60")]
		private PointShopConfig _config;

		[Token(Token = "0x40034D5")]
		[FieldOffset(Offset = "0x68")]
		private Action<PointShopConfig> _onBuy;

		[Token(Token = "0x6002281")]
		[Address(RVA = "0x3F3A858", Offset = "0x3F36858", VA = "0x3F3A858")]
		public void Bind(PointShopConfig config, int boughtCount, Action<PointShopConfig> onBuy)
		{
		}

		[Token(Token = "0x6002282")]
		[Address(RVA = "0x3F3A918", Offset = "0x3F36918", VA = "0x3F3A918")]
		private void RefreshTitle(PointShopConfig config)
		{
		}

		[Token(Token = "0x6002283")]
		[Address(RVA = "0x3F3ABE8", Offset = "0x3F36BE8", VA = "0x3F3ABE8")]
		private void RefreshReward(PointShopConfig config)
		{
		}

		[Token(Token = "0x6002284")]
		[Address(RVA = "0x3F3ADA0", Offset = "0x3F36DA0", VA = "0x3F3ADA0")]
		private void RefreshCount(PointShopConfig config)
		{
		}

		[Token(Token = "0x6002285")]
		[Address(RVA = "0x3F3ADD4", Offset = "0x3F36DD4", VA = "0x3F3ADD4")]
		private void RefreshLimit(PointShopConfig config, int boughtCount)
		{
		}

		[Token(Token = "0x6002286")]
		[Address(RVA = "0x3F3AF28", Offset = "0x3F36F28", VA = "0x3F3AF28")]
		private void RefreshPrice(PointShopConfig config)
		{
		}

		[Token(Token = "0x6002287")]
		[Address(RVA = "0x3F3AFDC", Offset = "0x3F36FDC", VA = "0x3F3AFDC")]
		private void RefreshButtonState(PointShopConfig config, int boughtCount)
		{
		}

		[Token(Token = "0x6002288")]
		[Address(RVA = "0x3F3B1AC", Offset = "0x3F371AC", VA = "0x3F3B1AC")]
		private void RefreshNewBannerTag(PointShopConfig config)
		{
		}

		[Token(Token = "0x6002289")]
		[Address(RVA = "0x3F3B260", Offset = "0x3F37260", VA = "0x3F3B260")]
		private void OnBuyClicked()
		{
		}

		[Token(Token = "0x600228A")]
		[Address(RVA = "0x3F3B31C", Offset = "0x3F3731C", VA = "0x3F3B31C")]
		public WorldCupPointShopItemView()
		{
		}
	}
}
