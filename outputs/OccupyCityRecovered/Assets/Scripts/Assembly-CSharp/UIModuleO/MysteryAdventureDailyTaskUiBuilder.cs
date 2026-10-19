using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20009D0")]
	public static class MysteryAdventureDailyTaskUiBuilder
	{
		[Token(Token = "0x400491C")]
		private const float PanelWidth = 920f;

		[Token(Token = "0x400491D")]
		private const float PanelHeight = 700f;

		[Token(Token = "0x400491E")]
		private const float TabBarHeight = 84f;

		[Token(Token = "0x400491F")]
		private const float HeaderHeight = 96f;

		[Token(Token = "0x4004920")]
		private const float RefreshRowHeight = 34f;

		[Token(Token = "0x4004921")]
		private const float HorizontalPadding = 22f;

		[Token(Token = "0x4004922")]
		private const float ContentTop = 140f;

		[Token(Token = "0x4004923")]
		private const float ContentBottom = 90f;

		[Token(Token = "0x6003A7B")]
		[Address(RVA = "0x4115868", Offset = "0x4111868", VA = "0x4115868")]
		public static void Build(MysteryAdventureDailyTaskPanelView view, [Optional] GameObject rewardItemPrefab)
		{
		}

		[Token(Token = "0x6003A7C")]
		[Address(RVA = "0x4116848", Offset = "0x4112848", VA = "0x4116848")]
		private static void BuildTaskScroll(RectTransform taskPage, GameObject rewardItemPrefab, MysteryAdventureDailyTaskPageView pageView)
		{
		}

		[Token(Token = "0x6003A7D")]
		[Address(RVA = "0x4116B0C", Offset = "0x4112B0C", VA = "0x4116B0C")]
		private static (Button, Image) CreateTabButton(string name, RectTransform parent, string text, bool isLeft)
		{
			return default;
		}

		[Token(Token = "0x6003A7E")]
		[Address(RVA = "0x4116CDC", Offset = "0x4112CDC", VA = "0x4116CDC")]
		private static MysteryAdventureDailyTaskItemView CreateTaskItem(RectTransform parent, GameObject rewardItemPrefab)
		{
			return null;
		}

		[Token(Token = "0x6003A7F")]
		[Address(RVA = "0x4116610", Offset = "0x4112610", VA = "0x4116610")]
		private static Button CreateButton(string name, Transform parent, string text, Vector2 pos)
		{
			return null;
		}

		[Token(Token = "0x6003A80")]
		[Address(RVA = "0x4116318", Offset = "0x4112318", VA = "0x4116318")]
		private static TextMeshProUGUI CreateText(string name, Transform parent, float fontSize, TextAlignmentOptions alignment)
		{
			return null;
		}

		[Token(Token = "0x6003A81")]
		[Address(RVA = "0x411618C", Offset = "0x411218C", VA = "0x411618C")]
		private static RectTransform CreateRect(string name, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6003A82")]
		[Address(RVA = "0x411676C", Offset = "0x411276C", VA = "0x411676C")]
		private static void Stretch(RectTransform rect, Vector2 offsetMin, Vector2 offsetMax)
		{
		}
	}
}
