using Il2CppDummyDll;
using UnityEngine;

namespace ToolModule
{
	[Token(Token = "0x2000190")]
	public static class CanvasGroupExtend
	{
		[Token(Token = "0x600065F")]
		[Address(RVA = "0x3F7C2C4", Offset = "0x3F782C4", VA = "0x3F7C2C4")]
		public static void HideCanvasGroup(this CanvasGroup self)
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x3F7C2F4", Offset = "0x3F782F4", VA = "0x3F7C2F4")]
		public static void ShowCanvasGroup(this CanvasGroup self)
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x3F7C324", Offset = "0x3F78324", VA = "0x3F7C324")]
		public static bool IsActive(this CanvasGroup self)
		{
			return default;
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x3F7C354", Offset = "0x3F78354", VA = "0x3F7C354")]
		public static void SetActive(this CanvasGroup self, bool isActive)
		{
		}
	}
}
