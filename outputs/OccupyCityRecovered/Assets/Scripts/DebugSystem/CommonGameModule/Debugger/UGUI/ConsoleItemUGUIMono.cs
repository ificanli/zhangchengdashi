using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x2000053")]
	public class ConsoleItemUGUIMono : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x20")]
		public IPointerClickHandler RealHandler;

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x4645C44", Offset = "0x4641C44", VA = "0x4645C44", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x4645CF4", Offset = "0x4641CF4", VA = "0x4645CF4")]
		public ConsoleItemUGUIMono()
		{
		}
	}
}
