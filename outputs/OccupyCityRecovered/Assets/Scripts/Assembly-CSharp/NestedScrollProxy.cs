using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[Token(Token = "0x20000CC")]
public class NestedScrollProxy : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	[Token(Token = "0x400046C")]
	[FieldOffset(Offset = "0x20")]
	private ScrollRect childScrollRect;

	[Token(Token = "0x400046D")]
	[FieldOffset(Offset = "0x28")]
	private ScrollRect parentScrollRect;

	[Token(Token = "0x400046E")]
	[FieldOffset(Offset = "0x30")]
	private Vector2 dragStartPos;

	[Token(Token = "0x400046F")]
	[FieldOffset(Offset = "0x38")]
	private bool passToParent;

	[Token(Token = "0x4000470")]
	private const float DragThreshold = 10f;

	[Token(Token = "0x4000471")]
	[FieldOffset(Offset = "0x40")]
	private MeatScrollRectPageController pageController;

	[Token(Token = "0x6000461")]
	[Address(RVA = "0x3E3F3CC", Offset = "0x3E3B3CC", VA = "0x3E3F3CC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000462")]
	[Address(RVA = "0x3E3F544", Offset = "0x3E3B544", VA = "0x3E3F544", Slot = "4")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0x3E3F568", Offset = "0x3E3B568", VA = "0x3E3F568", Slot = "5")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000464")]
	[Address(RVA = "0x3E3F604", Offset = "0x3E3B604", VA = "0x3E3F604", Slot = "6")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000465")]
	[Address(RVA = "0x3E3F640", Offset = "0x3E3B640", VA = "0x3E3F640")]
	public NestedScrollProxy()
	{
	}
}
