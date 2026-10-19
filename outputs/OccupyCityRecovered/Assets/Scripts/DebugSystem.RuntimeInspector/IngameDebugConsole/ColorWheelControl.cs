using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000004")]
	public class ColorWheelControl : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IDragHandler, IPointerUpHandler
	{
		[Token(Token = "0x2000005")]
		public delegate void OnColorChangedDelegate(Color32 color);

		[Token(Token = "0x4000006")]
		private const float RGB_CONST = 2f / (float)Math.PI;

		[Token(Token = "0x4000007")]
		private const float G_CONST = (float)Math.PI * 2f / 3f;

		[Token(Token = "0x4000008")]
		private const float B_CONST = 4.1887903f;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x20")]
		private Color m_color;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x38")]
		private RectTransform rectTransform;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform SelectorOut;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform SelectorIn;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private WindowDragHandler colorPickerWindow;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x58")]
		private float outer;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x5C")]
		private Vector2 inner;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x68")]
		private Material mat;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x70")]
		private bool draggingOuter;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x71")]
		private bool draggingInner;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x74")]
		private float halfSize;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x78")]
		private float halfSizeSqr;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x7C")]
		private float outerCirclePaddingSqr;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x80")]
		private float innerSquareHalfSize;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x84")]
		private int pointerId;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x88")]
		[CompilerGenerated]
		private OnColorChangedDelegate m_OnColorChanged;

		[Token(Token = "0x17000001")]
		public Color Color
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x464B080", Offset = "0x4647080", VA = "0x464B080")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x464B08C", Offset = "0x464708C", VA = "0x464B08C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float Alpha
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x464B114", Offset = "0x4647114", VA = "0x464B114")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x464B11C", Offset = "0x464711C", VA = "0x464B11C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public event OnColorChangedDelegate OnColorChanged
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x464B124", Offset = "0x4647124", VA = "0x464B124")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x464B1C0", Offset = "0x46471C0", VA = "0x464B1C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x464B25C", Offset = "0x464725C", VA = "0x464B25C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x464B3B4", Offset = "0x46473B4", VA = "0x464B3B4")]
		private void OnRectTransformDimensionsChange()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x464B36C", Offset = "0x464736C", VA = "0x464B36C")]
		private void UpdateProperties()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x464B4CC", Offset = "0x46474CC", VA = "0x464B4CC")]
		public void PickColor(Color c)
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x464B6A8", Offset = "0x46476A8", VA = "0x464B6A8", Slot = "4")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x464B8F0", Offset = "0x46478F0", VA = "0x464B8F0", Slot = "5")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x464B9E4", Offset = "0x46479E4", VA = "0x464B9E4", Slot = "6")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x464B7C0", Offset = "0x46477C0", VA = "0x464B7C0")]
		private void GetSelectedColor(Vector2 pointerPos)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x464BABC", Offset = "0x4647ABC", VA = "0x464BABC")]
		private void UpdateColor()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x464B5D8", Offset = "0x46475D8", VA = "0x464B5D8")]
		private Color GetCurrentBaseColor()
		{
			return default;
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x464B434", Offset = "0x4647434", VA = "0x464B434")]
		private void UpdateSelectors()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x464BB98", Offset = "0x4647B98", VA = "0x464BB98")]
		public ColorWheelControl()
		{
		}
	}
}
