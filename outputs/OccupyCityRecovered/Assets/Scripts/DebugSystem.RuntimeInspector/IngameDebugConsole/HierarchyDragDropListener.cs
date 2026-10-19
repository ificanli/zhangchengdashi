using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace IngameDebugConsole
{
	[Token(Token = "0x200000C")]
	public class HierarchyDragDropListener : MonoBehaviour, IDropHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
	{
		[Token(Token = "0x400006E")]
		private const float POINTER_VALIDATE_INTERVAL = 5f;

		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float siblingIndexModificationArea;

		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float scrollableArea;

		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x28")]
		private float _1OverScrollableArea;

		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float scrollSpeed;

		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Header("Internal Variables")]
		private RuntimeHierarchy hierarchy;

		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform content;

		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image dragDropTargetVisualization;

		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x48")]
		private Canvas canvas;

		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x50")]
		private RectTransform rectTransform;

		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x58")]
		private float height;

		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x60")]
		private PointerEventData pointer;

		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x68")]
		private Camera worldCamera;

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x70")]
		private float pointerLastYPos;

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x74")]
		private float nextPointerValidation;

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x4653BC0", Offset = "0x464FBC0", VA = "0x4653BC0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x4653C74", Offset = "0x464FC74", VA = "0x4653C74")]
		private void OnRectTransformDimensionsChange()
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x4653C7C", Offset = "0x464FC7C", VA = "0x4653C7C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x4654030", Offset = "0x4650030", VA = "0x4654030", Slot = "4")]
void IDropHandler.OnDrop(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x465476C", Offset = "0x465076C", VA = "0x465476C")]
		private bool DropTransformOnto(Transform droppedTransform, HierarchyData target, HierarchyDataRoot newScene, Transform newParent, int newSiblingIndex, out bool decrementSiblingIndex, out bool shouldFocusObjectInHierarchy)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED HierarchyDragDropListener.DropTransformOnto RVA=0x465476C Token=0x6000088");
}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x4654ED8", Offset = "0x4650ED8", VA = "0x4654ED8")]
		private int CompareHierarchySiblingIndices(Transform t1, Transform t2)
		{
			return default;
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x4655144", Offset = "0x4651144", VA = "0x4655144", Slot = "5")]
void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x4655308", Offset = "0x4651308", VA = "0x4655308", Slot = "6")]
void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x465536C", Offset = "0x465136C", VA = "0x465536C")]
		public HierarchyDragDropListener()
		{
		}
	}
}
