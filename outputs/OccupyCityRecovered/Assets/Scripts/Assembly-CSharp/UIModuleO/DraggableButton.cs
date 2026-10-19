using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x200068B")]
	public class DraggableButton : MonoBehaviour, IDragHandler, IEventSystemHandler, IEndDragHandler
	{
		[Token(Token = "0x40034DE")]
		private const float Diff = 10f;

		[Token(Token = "0x40034DF")]
		[FieldOffset(Offset = "0x20")]
		private RectTransform _rectTransform;

		[Token(Token = "0x40034E0")]
		[FieldOffset(Offset = "0x28")]
		private Canvas _canvas;

		[Token(Token = "0x40034E1")]
		[FieldOffset(Offset = "0x30")]
		private Button _button;

		[Token(Token = "0x40034E2")]
		[FieldOffset(Offset = "0x38")]
		private float _edgeX;

		[Token(Token = "0x6002296")]
		[Address(RVA = "0x3F3BA54", Offset = "0x3F37A54", VA = "0x3F3BA54")]
		private void Start()
		{
		}

		[Token(Token = "0x6002297")]
		[Address(RVA = "0x3F3BBB0", Offset = "0x3F37BB0", VA = "0x3F3BBB0", Slot = "4")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6002298")]
		[Address(RVA = "0x3F3BCB0", Offset = "0x3F37CB0", VA = "0x3F3BCB0", Slot = "5")]
		public void OnEndDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6002299")]
		[Address(RVA = "0x3F3BB9C", Offset = "0x3F37B9C", VA = "0x3F3BB9C")]
		private Vector2 GetNearestEdgePosition(Vector2 currentPosition)
		{
			return default;
		}

		[Token(Token = "0x600229A")]
		[Address(RVA = "0x3F3BD08", Offset = "0x3F37D08", VA = "0x3F3BD08")]
		public DraggableButton()
		{
		}
	}
}
