using Il2CppDummyDll;
using UnityEngine;

namespace ToolModule
{
	[Token(Token = "0x20001AB")]
	public static class UITool
	{
		[Token(Token = "0x1700009A")]
		public static float ScreenRatio
		{
			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x3F83734", Offset = "0x3F7F734", VA = "0x3F83734")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x3F835D4", Offset = "0x3F7F5D4", VA = "0x3F835D4")]
		public static Vector2 WorldToUgui(Vector3 position, RectTransform canvasRectTransform)
		{
			return default;
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x3F836B8", Offset = "0x3F7F6B8", VA = "0x3F836B8")]
		public static Vector2 ScreenToUgui(Vector2 screenPoint, RectTransform canvasRectTransform)
		{
			return default;
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x3F83760", Offset = "0x3F7F760", VA = "0x3F83760")]
		public static Vector2 WorldToCanvas(this Vector3 position, RectTransform canvas)
		{
			return default;
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x3F82340", Offset = "0x3F7E340", VA = "0x3F82340")]
		public static Vector2 GetAnchoredPositionIgnoringAnchor(this Vector2 targetPosition, RectTransform targetRectTransform)
		{
			return default;
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x3F83350", Offset = "0x3F7F350", VA = "0x3F83350")]
		public static Vector2 CalPositionAt(RectTransform from, RectTransform at)
		{
			return default;
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x3F83840", Offset = "0x3F7F840", VA = "0x3F83840")]
		public static bool IsPointerOver()
		{
			return default;
		}
	}
}
