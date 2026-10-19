using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000A56")]
	public static class MysteryAdventureTotalDiceTrackUiBuilder
	{
		[Token(Token = "0x4004C78")]
		private const float ItemWidth = 130f;

		[Token(Token = "0x4004C79")]
		private const float ItemHeight = 96f;

		[Token(Token = "0x4004C7A")]
		private const float TrackHeight = 18f;

		[Token(Token = "0x4004C7B")]
		private const float LeftInfoWidth = 96f;

		[Token(Token = "0x6003DE3")]
		[Address(RVA = "0x41640C4", Offset = "0x41600C4", VA = "0x41640C4")]
		public static void Build(MysteryAdventurePanelView view, [Optional] GameObject rewardItemPrefab)
		{
		}

		[Token(Token = "0x6003DE4")]
		[Address(RVA = "0x416482C", Offset = "0x416082C", VA = "0x416482C")]
		public static bool HasBuiltInHierarchy(Transform progressSection)
		{
			return default;
		}

		[Token(Token = "0x6003DE5")]
		[Address(RVA = "0x41651F8", Offset = "0x41611F8", VA = "0x41651F8")]
		public static MysteryAdventureTotalDiceMilestoneItem CreateMilestoneItem(RectTransform parent, MysteryAdventureTotalDiceMilestoneItem template, GameObject rewardItemPrefab)
		{
			return null;
		}

		[Token(Token = "0x6003DE6")]
		[Address(RVA = "0x41648F0", Offset = "0x41608F0", VA = "0x41648F0")]
		private static RectTransform CreateRect(string name, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6003DE7")]
		[Address(RVA = "0x4164F4C", Offset = "0x4160F4C", VA = "0x4164F4C")]
		private static Image CreateImage(string name, Transform parent, Vector2 anchor, Vector2 size)
		{
			return null;
		}

		[Token(Token = "0x6003DE8")]
		[Address(RVA = "0x4164B30", Offset = "0x4160B30", VA = "0x4164B30")]
		private static TextMeshProUGUI CreateText(string name, Transform parent, float fontSize, TextAlignmentOptions alignment)
		{
			return null;
		}

		[Token(Token = "0x6003DE9")]
		[Address(RVA = "0x4164E48", Offset = "0x4160E48", VA = "0x4164E48")]
		private static void StretchFull(RectTransform rect)
		{
		}

		[Token(Token = "0x6003DEA")]
		[Address(RVA = "0x4164A7C", Offset = "0x4160A7C", VA = "0x4164A7C")]
		private static void StretchLeftPanel(RectTransform rect, float width)
		{
		}

		[Token(Token = "0x6003DEB")]
		[Address(RVA = "0x4164DC8", Offset = "0x4160DC8", VA = "0x4164DC8")]
		private static void StretchRightPanel(RectTransform rect, float leftOffset)
		{
		}
	}
}
