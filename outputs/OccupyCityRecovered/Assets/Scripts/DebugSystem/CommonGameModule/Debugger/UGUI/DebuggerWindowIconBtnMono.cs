using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x2000060")]
	public class DebuggerWindowIconBtnMono : MonoBehaviour, IPointerUpHandler, IEventSystemHandler, IPointerDownHandler
	{
		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x20")]
		public IPointerUpHandler parentUpHandler;

		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x28")]
		public IPointerDownHandler parentDownHandler;

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x4680EF0", Offset = "0x467CEF0", VA = "0x4680EF0", Slot = "4")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x4680FA0", Offset = "0x467CFA0", VA = "0x4680FA0", Slot = "5")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x4681050", Offset = "0x467D050", VA = "0x4681050")]
		public DebuggerWindowIconBtnMono()
		{
		}
	}
}
