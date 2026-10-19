using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using ljzs_lt;

namespace UIModuleO
{
	[Token(Token = "0x200068A")]
	public class WorldCupPointShopPanelView : ScaleTweenPanelViewBase
	{
		[Token(Token = "0x40034D6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _backButton;

		[Token(Token = "0x40034D7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _contentRoot;

		[Token(Token = "0x40034D8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _bannerImage;

		[Token(Token = "0x40034D9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _itemGrid;

		[Token(Token = "0x40034DA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private WorldCupPointShopItemView _itemTemplate;

		[Token(Token = "0x40034DB")]
		[FieldOffset(Offset = "0x50")]
		private readonly List<WorldCupPointShopItemView> _items;

		[Token(Token = "0x40034DC")]
		[FieldOffset(Offset = "0x58")]
		private Action _onClose;

		[Token(Token = "0x40034DD")]
		[FieldOffset(Offset = "0x60")]
		private Action<PointShopConfig> _onBuy;

		[Token(Token = "0x170001DF")]
		public Button BackButton
		{
			[Token(Token = "0x600228B")]
			[Address(RVA = "0x3F3B324", Offset = "0x3F37324", VA = "0x3F3B324")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001E0")]
		public RectTransform ContentRoot
		{
			[Token(Token = "0x600228C")]
			[Address(RVA = "0x3F3B32C", Offset = "0x3F3732C", VA = "0x3F3B32C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001E1")]
		public RectTransform ItemGrid
		{
			[Token(Token = "0x600228D")]
			[Address(RVA = "0x3F3B334", Offset = "0x3F37334", VA = "0x3F3B334")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001E2")]
		public WorldCupPointShopItemView ItemTemplate
		{
			[Token(Token = "0x600228E")]
			[Address(RVA = "0x3F3B33C", Offset = "0x3F3733C", VA = "0x3F3B33C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600228F")]
		[Address(RVA = "0x3F3B344", Offset = "0x3F37344", VA = "0x3F3B344")]
		public void Initialize(Action onClose, Action<PointShopConfig> onBuy)
		{
		}

		[Token(Token = "0x6002290")]
		[Address(RVA = "0x3F3B4E4", Offset = "0x3F374E4", VA = "0x3F3B4E4")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6002291")]
		[Address(RVA = "0x3F3B904", Offset = "0x3F37904", VA = "0x3F3B904", Slot = "8")]
		protected override RectTransform ResolveTweenTarget()
		{
			return null;
		}

		[Token(Token = "0x6002292")]
		[Address(RVA = "0x3F3B360", Offset = "0x3F37360", VA = "0x3F3B360")]
		private void BindBackButton()
		{
		}

		[Token(Token = "0x6002293")]
		[Address(RVA = "0x3F3B450", Offset = "0x3F37450", VA = "0x3F3B450")]
		private void HideItemTemplate()
		{
		}

		[Token(Token = "0x6002294")]
		[Address(RVA = "0x3F3B9B4", Offset = "0x3F379B4", VA = "0x3F3B9B4")]
		public WorldCupPointShopPanelView()
		{
		}
	}
}
