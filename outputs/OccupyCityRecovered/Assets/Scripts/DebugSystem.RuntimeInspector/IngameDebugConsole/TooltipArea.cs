using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace IngameDebugConsole
{
	[Token(Token = "0x200006E")]
	public class TooltipArea : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0x20")]
		private TooltipListener tooltipListener;

		[Token(Token = "0x4000223")]
		[FieldOffset(Offset = "0x28")]
		private ITooltipContent tooltipContent;

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x467A438", Offset = "0x4676438", VA = "0x467A438")]
		public void Initialize(TooltipListener tooltipListener, ITooltipContent tooltipContent)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x467A440", Offset = "0x4676440", VA = "0x467A440", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x467A5A4", Offset = "0x46765A4", VA = "0x467A5A4", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x467A5CC", Offset = "0x46765CC", VA = "0x467A5CC")]
		public TooltipArea()
		{
		}
	}
}
