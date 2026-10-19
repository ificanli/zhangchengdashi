using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x2000061")]
	public class DebuggerWindowIconMono : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x20")]
		private DebuggerWindowIcon _debuggerWindowIcon;

		[Token(Token = "0x17000057")]
		public DebuggerWindowIcon Icon
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x4681058", Offset = "0x467D058", VA = "0x4681058")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x46810CC", Offset = "0x467D0CC", VA = "0x46810CC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x46810E4", Offset = "0x467D0E4", VA = "0x46810E4", Slot = "4")]
void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x46810FC", Offset = "0x467D0FC", VA = "0x46810FC", Slot = "5")]
void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x4681118", Offset = "0x467D118", VA = "0x4681118")]
		public DebuggerWindowIconMono()
		{
		}
	}
}
