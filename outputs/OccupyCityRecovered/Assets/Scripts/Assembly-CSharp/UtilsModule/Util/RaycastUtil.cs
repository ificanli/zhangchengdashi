using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UtilsModule.Util
{
	[Token(Token = "0x200020A")]
	public class RaycastUtil
	{
		[Token(Token = "0x4001CF5")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<RaycastResult> UIRaycastResults;

		[Token(Token = "0x4001CF6")]
		[FieldOffset(Offset = "0x8")]
		private static PointerEventData _pointerEventData;

		[Token(Token = "0x4001CF7")]
		[FieldOffset(Offset = "0x10")]
		private static EventSystem _pointerEventSystem;

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x41907A0", Offset = "0x418C7A0", VA = "0x41907A0")]
		public static bool PointerIsOverUI(Vector2 screenPos)
		{
			return default;
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x4190A0C", Offset = "0x418CA0C", VA = "0x4190A0C")]
		public static GameObject UIRaycast(PointerEventData pointerData)
		{
			return null;
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x4190C20", Offset = "0x418CC20", VA = "0x4190C20")]
		public static bool UIRaycastEmoji(Vector2 screenPos)
		{
			return default;
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x4190840", Offset = "0x418C840", VA = "0x4190840")]
		private static PointerEventData ScreenPosToPointerData(Vector2 screenPos)
		{
			return null;
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x4190EA0", Offset = "0x418CEA0", VA = "0x4190EA0")]
		public RaycastUtil()
		{
		}
	}
}
