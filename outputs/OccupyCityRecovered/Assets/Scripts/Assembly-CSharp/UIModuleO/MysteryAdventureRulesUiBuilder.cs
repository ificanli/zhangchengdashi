using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000A4D")]
	public static class MysteryAdventureRulesUiBuilder
	{
		[Token(Token = "0x4004C42")]
		private const float PanelWidth = 920f;

		[Token(Token = "0x4004C43")]
		private const float PanelHeight = 760f;

		[Token(Token = "0x4004C44")]
		private const float HeaderHeight = 96f;

		[Token(Token = "0x4004C45")]
		private const float TabBarHeight = 84f;

		[Token(Token = "0x4004C46")]
		private const float PaginationHeight = 56f;

		[Token(Token = "0x4004C47")]
		private const float HorizontalPadding = 22f;

		[Token(Token = "0x4004C48")]
		private const float ContentTop = 108f;

		[Token(Token = "0x4004C49")]
		private const float ContentBottom = 156f;

		[Token(Token = "0x4004C4A")]
		private const float ItemHeight = 168f;

		[Token(Token = "0x4004C4B")]
		private const float ItemSpacing = 14f;

		[Token(Token = "0x6003DAD")]
		[Address(RVA = "0x415FBC4", Offset = "0x415BBC4", VA = "0x415FBC4")]
		public static MysteryAdventureRulesPanelView Build(RectTransform parent)
		{
			return null;
		}

		[Token(Token = "0x6003DAE")]
		[Address(RVA = "0x4160F34", Offset = "0x415CF34", VA = "0x4160F34")]
		private static MysteryAdventureRulesItemView CreateItem(RectTransform parent, string name)
		{
			return null;
		}

		[Token(Token = "0x6003DAF")]
		[Address(RVA = "0x4161304", Offset = "0x415D304", VA = "0x4161304")]
		private static (Button, Image) CreateTabButton(string name, RectTransform parent, string text, bool isLeft)
		{
			return default;
		}

		[Token(Token = "0x6003DB0")]
		[Address(RVA = "0x41611E8", Offset = "0x415D1E8", VA = "0x41611E8")]
		private static Button CreateIconButton(string name, Transform parent, string fallbackText)
		{
			return null;
		}

		[Token(Token = "0x6003DB1")]
		[Address(RVA = "0x4160DB4", Offset = "0x415CDB4", VA = "0x4160DB4")]
		private static Button CreateButton(string name, Transform parent, string text, Vector2 pos)
		{
			return null;
		}

		[Token(Token = "0x6003DB2")]
		[Address(RVA = "0x4160A54", Offset = "0x415CA54", VA = "0x4160A54")]
		private static Image CreateImage(string name, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6003DB3")]
		[Address(RVA = "0x4160ABC", Offset = "0x415CABC", VA = "0x4160ABC")]
		private static TextMeshProUGUI CreateText(string name, Transform parent, float fontSize, TextAlignmentOptions alignment)
		{
			return null;
		}

		[Token(Token = "0x6003DB4")]
		[Address(RVA = "0x41607EC", Offset = "0x415C7EC", VA = "0x41607EC")]
		private static RectTransform CreateRect(string name, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6003DB5")]
		[Address(RVA = "0x4160978", Offset = "0x415C978", VA = "0x4160978")]
		private static void Stretch(RectTransform rect, Vector2 offsetMin, Vector2 offsetMax)
		{
		}
	}
}
