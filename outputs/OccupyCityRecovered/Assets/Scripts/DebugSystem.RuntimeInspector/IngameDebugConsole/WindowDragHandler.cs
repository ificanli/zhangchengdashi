using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000073")]
	public class WindowDragHandler : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
	{
		[Token(Token = "0x400022D")]
		private const int NON_EXISTING_TOUCH = -98456;

		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x20")]
		private RectTransform rectTransform;

		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0x28")]
		private int pointerId;

		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x2C")]
		private Vector2 initialTouchPos;

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x467AB74", Offset = "0x4676B74", VA = "0x467AB74")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x467ABEC", Offset = "0x4676BEC", VA = "0x467ABEC", Slot = "4")]
		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x467ACB8", Offset = "0x4676CB8", VA = "0x467ACB8", Slot = "5")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x467ADAC", Offset = "0x4676DAC", VA = "0x467ADAC", Slot = "6")]
		public void OnEndDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x467ADDC", Offset = "0x4676DDC", VA = "0x467ADDC")]
		public WindowDragHandler()
		{
		}
	}
}
