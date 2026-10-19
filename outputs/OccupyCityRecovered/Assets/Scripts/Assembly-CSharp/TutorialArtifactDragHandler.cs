using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

[Token(Token = "0x20000A9")]
public class TutorialArtifactDragHandler : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	[Token(Token = "0x4000371")]
	[FieldOffset(Offset = "0x20")]
	[Header("拖动目标区域（例如 GamePanel/ImgGuidArtifact）")]
	public RectTransform targetArea;

	[Token(Token = "0x4000372")]
	[FieldOffset(Offset = "0x28")]
	[Header("结束事件名，需要与引导表中 endTriggerEvent 一致")]
	public string endTriggerEvent;

	[Token(Token = "0x4000373")]
	[FieldOffset(Offset = "0x30")]
	private RectTransform _selfRect;

	[Token(Token = "0x4000374")]
	[FieldOffset(Offset = "0x38")]
	private Canvas _canvas;

	[Token(Token = "0x4000375")]
	[FieldOffset(Offset = "0x40")]
	private Vector2 _dragOffset;

	[Token(Token = "0x600036B")]
	[Address(RVA = "0x3D2F480", Offset = "0x3D2B480", VA = "0x3D2F480")]
	private void Awake()
	{
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0x3D2F4FC", Offset = "0x3D2B4FC", VA = "0x3D2F4FC", Slot = "4")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0x3D2F500", Offset = "0x3D2B500", VA = "0x3D2F500", Slot = "5")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0x3D2F504", Offset = "0x3D2B504", VA = "0x3D2F504", Slot = "6")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0x3D2F59C", Offset = "0x3D2B59C", VA = "0x3D2F59C")]
	public TutorialArtifactDragHandler()
	{
	}
}
