using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace IngameDebugConsole
{
	[Token(Token = "0x200006D")]
	public class Tooltip : PopupBase
	{
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x46758C4", Offset = "0x46718C4", VA = "0x46758C4")]
		public void SetContent(string tooltip, PointerEventData pointer)
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x467A40C", Offset = "0x467640C", VA = "0x467A40C", Slot = "4")]
		protected override void DestroySelf()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x467A430", Offset = "0x4676430", VA = "0x467A430")]
		public Tooltip()
		{
		}
	}
}
