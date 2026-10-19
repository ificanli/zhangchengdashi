using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20009DC")]
	public static class MysteryAdventureDiscountShopUiBuilder
	{
		[Token(Token = "0x4004968")]
		private const float PanelWidth = 640f;

		[Token(Token = "0x4004969")]
		private const float PanelHeight = 760f;

		[Token(Token = "0x400496A")]
		private const float ItemCellWidth = 280f;

		[Token(Token = "0x400496B")]
		private const float ItemCellHeight = 300f;

		[Token(Token = "0x6003ACD")]
		[Address(RVA = "0x411C89C", Offset = "0x411889C", VA = "0x411C89C")]
		public static MysteryAdventureDiscountShopPanelView Build(RectTransform parent)
		{
			return null;
		}

		[Token(Token = "0x6003ACE")]
		[Address(RVA = "0x411DB4C", Offset = "0x4119B4C", VA = "0x411DB4C")]
		private static MysteryAdventureDiscountShopItemView CreateShopItem(RectTransform parent)
		{
			return null;
		}

		[Token(Token = "0x6003ACF")]
		[Address(RVA = "0x411D4D0", Offset = "0x41194D0", VA = "0x411D4D0")]
		private static Image CreateImage(string name, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6003AD0")]
		[Address(RVA = "0x411D708", Offset = "0x4119708", VA = "0x411D708")]
		private static TextMeshProUGUI CreateText(string name, Transform parent, float fontSize, TextAlignmentOptions alignment)
		{
			return null;
		}

		[Token(Token = "0x6003AD1")]
		[Address(RVA = "0x411DA20", Offset = "0x4119A20", VA = "0x411DA20")]
		private static Button CreateButton(string name, Transform parent, string label, Vector2 anchoredPos)
		{
			return null;
		}

		[Token(Token = "0x6003AD2")]
		[Address(RVA = "0x411D268", Offset = "0x4119268", VA = "0x411D268")]
		private static RectTransform CreateRect(string name, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6003AD3")]
		[Address(RVA = "0x411D3F4", Offset = "0x41193F4", VA = "0x411D3F4")]
		private static void Stretch(RectTransform rect, Vector2 offsetMin, Vector2 offsetMax)
		{
		}
	}
}
