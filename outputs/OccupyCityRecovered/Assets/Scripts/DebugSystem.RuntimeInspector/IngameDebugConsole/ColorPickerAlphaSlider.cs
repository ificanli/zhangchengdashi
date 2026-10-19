using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000046")]
	public class ColorPickerAlphaSlider : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IDragHandler
	{
		[Token(Token = "0x2000047")]
		public delegate void OnValueChangedDelegate(float alpha);

		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x20")]
		private RectTransform rectTransform;

		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image alphaImage;

		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform selector;

		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x38")]
		private float m_value;

		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x40")]
		public OnValueChangedDelegate OnValueChanged;

		[Token(Token = "0x17000083")]
		public float Value
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x466DBB0", Offset = "0x4669BB0", VA = "0x466DBB0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000290")]
			[Address(RVA = "0x466D2CC", Offset = "0x46692CC", VA = "0x466D2CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public Color Color
		{
			[Token(Token = "0x6000291")]
			[Address(RVA = "0x466DBB8", Offset = "0x4669BB8", VA = "0x466DBB8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x466D2A4", Offset = "0x46692A4", VA = "0x466D2A4")]
			set
			{
			}
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x466DBDC", Offset = "0x4669BDC", VA = "0x466DBDC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x466DC54", Offset = "0x4669C54", VA = "0x466DC54", Slot = "4")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x466DC58", Offset = "0x4669C58", VA = "0x466DC58", Slot = "5")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x466DD54", Offset = "0x4669D54", VA = "0x466DD54")]
		public ColorPickerAlphaSlider()
		{
		}
	}
}
