using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x20009EA")]
	public static class MysteryAdventureLapRewardUiBuilder
	{
		[Token(Token = "0x40049A8")]
		private const float BlockWidth = 520f;

		[Token(Token = "0x40049A9")]
		private const float UpgradeBlockHeight = 420f;

		[Token(Token = "0x40049AA")]
		private const float LapBlockHeight = 360f;

		[Token(Token = "0x6003B0E")]
		[Address(RVA = "0x4120D44", Offset = "0x411CD44", VA = "0x4120D44")]
		public static void Build(MysteryAdventureLapRewardPopupView view)
		{
		}

		[Token(Token = "0x6003B0F")]
		[Address(RVA = "0x41239BC", Offset = "0x411F9BC", VA = "0x41239BC")]
		private static void BuildUpgradeBlock(RectTransform parent, MysteryAdventureLapRewardPopupView view)
		{
		}

		[Token(Token = "0x6003B10")]
		[Address(RVA = "0x4123FF0", Offset = "0x411FFF0", VA = "0x4123FF0")]
		private static void BuildLapBlock(RectTransform parent, MysteryAdventureLapRewardPopupView view)
		{
		}

		[Token(Token = "0x6003B11")]
		[Address(RVA = "0x41242F0", Offset = "0x41202F0", VA = "0x41242F0")]
		private static TextMeshProUGUI CreateText(string name, Transform parent, float fontSize, TextAlignmentOptions alignment)
		{
			return null;
		}

		[Token(Token = "0x6003B12")]
		[Address(RVA = "0x4123830", Offset = "0x411F830", VA = "0x4123830")]
		private static RectTransform CreateRect(string name, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6003B13")]
		[Address(RVA = "0x4123754", Offset = "0x411F754", VA = "0x4123754")]
		private static void Stretch(RectTransform rect, Vector2 offsetMin, Vector2 offsetMax)
		{
		}
	}
}
