using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace ToolModule
{
	[Token(Token = "0x2000198")]
	public static class TMPExtend
	{
		[Token(Token = "0x6000686")]
		[Address(RVA = "0x3F7DF3C", Offset = "0x3F79F3C", VA = "0x3F7DF3C")]
		public static void SetTextAutoSizeToFit(this TextMeshProUGUI tex, RectTransform rectTrans, string content, float diff = 150f, float miniHeight = 0f)
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x3F7DFE0", Offset = "0x3F79FE0", VA = "0x3F7DFE0")]
		public static string GetSpriteString(string spriteName, bool includeBG = false)
		{
			return null;
		}
	}
}
