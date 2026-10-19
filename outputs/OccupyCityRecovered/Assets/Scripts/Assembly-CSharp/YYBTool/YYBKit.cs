using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace YYBTool
{
	[Token(Token = "0x2000653")]
	public static class YYBKit
	{
		[Token(Token = "0x6002144")]
		[Address(RVA = "0x3F2294C", Offset = "0x3F1E94C", VA = "0x3F2294C")]
		public static bool IsPointerOverUIObject(Vector2 screenPosition, out RaycastResult[] pointOverUI)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED YYBKit.IsPointerOverUIObject RVA=0x3F2294C Token=0x6002144");
}

		[Token(Token = "0x6002145")]
		[Address(RVA = "0x3F22A90", Offset = "0x3F1EA90", VA = "0x3F22A90")]
		public static Vector2 WorldToGUIPosition(this Vector3 position, [Optional] Camera mainCamera, [Optional] RectTransform canvasRectTransform)
		{
			return default;
		}

		[Token(Token = "0x6002146")]
		[Address(RVA = "0x3F22AAC", Offset = "0x3F1EAAC", VA = "0x3F22AAC")]
		public static Vector2 WorldToScreenPosition(this Vector3 position, [Optional] Camera mainCamera)
		{
			return default;
		}

		[Token(Token = "0x6002147")]
		[Address(RVA = "0x3F22B8C", Offset = "0x3F1EB8C", VA = "0x3F22B8C")]
		public static Vector2 ScreenToGuiPosition(this Vector2 screenPoint, [Optional] RectTransform canvasRectTransform, [Optional] Camera UICamera)
		{
			return default;
		}

		[Token(Token = "0x6002148")]
		[Address(RVA = "0x3F22CF0", Offset = "0x3F1ECF0", VA = "0x3F22CF0")]
		public static Transform FindChildByName(this Transform parent, string name)
		{
			return null;
		}
	}
}
