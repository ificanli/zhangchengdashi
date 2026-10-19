using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

[Token(Token = "0x20000BD")]
[RequireComponent(typeof(Image))]
public class ClickDragDetector : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
{
	[Token(Token = "0x40003ED")]
	[FieldOffset(Offset = "0x20")]
	[Tooltip("最大点击距离（像素），超过这个距离算作拖动")]
	public float maxClickDistance;

	[Token(Token = "0x40003EE")]
	[FieldOffset(Offset = "0x28")]
	public UnityEvent onClick;

	[Token(Token = "0x40003EF")]
	[FieldOffset(Offset = "0x30")]
	public UnityEvent onDragStart;

	[Token(Token = "0x40003F0")]
	[FieldOffset(Offset = "0x38")]
	public UnityEvent onDragEnd;

	[Token(Token = "0x40003F1")]
	[FieldOffset(Offset = "0x40")]
	private Vector2 _pointerDownPosition;

	[Token(Token = "0x40003F2")]
	[FieldOffset(Offset = "0x48")]
	private bool _isPointerDown;

	[Token(Token = "0x40003F3")]
	[FieldOffset(Offset = "0x49")]
	private bool _isDragging;

	[Token(Token = "0x40003F4")]
	[FieldOffset(Offset = "0x4C")]
	private int _pointerId;

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x3E39604", Offset = "0x3E35604", VA = "0x3E39604")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003F7")]
	[Address(RVA = "0x3E39668", Offset = "0x3E35668", VA = "0x3E39668", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60003F8")]
	[Address(RVA = "0x3E39698", Offset = "0x3E35698", VA = "0x3E39698", Slot = "6")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60003F9")]
	[Address(RVA = "0x3E39764", Offset = "0x3E35764", VA = "0x3E39764", Slot = "5")]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60003FA")]
	[Address(RVA = "0x3E39838", Offset = "0x3E35838", VA = "0x3E39838")]
	public void AddClickListener(UnityAction callback)
	{
	}

	[Token(Token = "0x60003FB")]
	[Address(RVA = "0x3E39854", Offset = "0x3E35854", VA = "0x3E39854")]
	public void RemoveClickListener(UnityAction callback)
	{
	}

	[Token(Token = "0x60003FC")]
	[Address(RVA = "0x3E39870", Offset = "0x3E35870", VA = "0x3E39870")]
	public void AddDragStartListener(UnityAction callback)
	{
	}

	[Token(Token = "0x60003FD")]
	[Address(RVA = "0x3E3988C", Offset = "0x3E3588C", VA = "0x3E3988C")]
	public void RemoveDragStartListener(UnityAction callback)
	{
	}

	[Token(Token = "0x60003FE")]
	[Address(RVA = "0x3E398A8", Offset = "0x3E358A8", VA = "0x3E398A8")]
	public void AddDragEndListener(UnityAction callback)
	{
	}

	[Token(Token = "0x60003FF")]
	[Address(RVA = "0x3E398C4", Offset = "0x3E358C4", VA = "0x3E398C4")]
	public void RemoveDragEndListener(UnityAction callback)
	{
	}

	[Token(Token = "0x6000400")]
	[Address(RVA = "0x3E398E0", Offset = "0x3E358E0", VA = "0x3E398E0")]
	public void ClearAllListeners()
	{
	}

	[Token(Token = "0x6000401")]
	[Address(RVA = "0x3E39920", Offset = "0x3E35920", VA = "0x3E39920")]
	public ClickDragDetector()
	{
	}
}
