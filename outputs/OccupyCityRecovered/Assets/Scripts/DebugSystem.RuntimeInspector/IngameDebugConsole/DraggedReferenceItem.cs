using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000048")]
	public class DraggedReferenceItem : PopupBase, IDragHandler, IEventSystemHandler, IEndDragHandler
	{
		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x68")]
		private object[] m_references;

		[Token(Token = "0x17000085")]
		public object[] References
		{
			[Token(Token = "0x600029B")]
			[Address(RVA = "0x466DE00", Offset = "0x4669E00", VA = "0x466DE00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x466DE08", Offset = "0x4669E08", VA = "0x466DE08")]
		public void SetContent(object[] references, PointerEventData draggingPointer)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x466DF7C", Offset = "0x4669F7C", VA = "0x466DF7C", Slot = "4")]
		protected override void DestroySelf()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x466DFD4", Offset = "0x4669FD4", VA = "0x466DFD4", Slot = "5")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x466E0B8", Offset = "0x466A0B8", VA = "0x466E0B8", Slot = "6")]
		public void OnEndDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x466E0C4", Offset = "0x466A0C4", VA = "0x466E0C4")]
		public DraggedReferenceItem()
		{
		}
	}
}
