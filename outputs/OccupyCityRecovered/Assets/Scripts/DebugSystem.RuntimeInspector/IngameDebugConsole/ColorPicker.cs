using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000045")]
	public class ColorPicker : SkinnedWindow
	{
		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x0")]
		private static ColorPicker prefab;

		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x8")]
		private static Transform parent;

		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x10")]
		private static ColorPicker m_instance;

		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image panel;

		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ColorWheelControl colorWheel;

		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ColorPickerAlphaSlider alphaSlider;

		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text rgbaText;

		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BoundInputField rInput;

		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private BoundInputField gInput;

		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private BoundInputField bInput;

		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private BoundInputField aInput;

		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private LayoutElement rgbaLayoutElement;

		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private LayoutElement buttonsLayoutElement;

		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Button cancelButton;

		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Button okButton;

		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x90")]
		private Color initialValue;

		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0xA0")]
		private ColorWheelControl.OnColorChangedDelegate onColorChanged;

		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0xA8")]
		private ColorWheelControl.OnColorChangedDelegate onColorConfirmed;

		[Token(Token = "0x17000082")]
		public static ColorPicker Instance
		{
			[Token(Token = "0x6000281")]
			[Address(RVA = "0x466C860", Offset = "0x4668860", VA = "0x466C860")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x466C9D0", Offset = "0x46689D0", VA = "0x466C9D0", Slot = "5")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x466CAF4", Offset = "0x4668AF4", VA = "0x466CAF4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x466D10C", Offset = "0x466910C", VA = "0x466D10C")]
		public void Show(ColorWheelControl.OnColorChangedDelegate onColorChanged, ColorWheelControl.OnColorChangedDelegate onColorConfirmed, Color initialColor, Canvas referenceCanvas)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x466D30C", Offset = "0x466930C", VA = "0x466D30C")]
		public void Cancel()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x466D448", Offset = "0x4669448", VA = "0x466D448")]
		public void Close()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x466D470", Offset = "0x4669470", VA = "0x466D470", Slot = "7")]
		protected override void RefreshSkin()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x466CEEC", Offset = "0x4668EEC", VA = "0x466CEEC")]
		private void OnSelectedColorChanged(Color32 color)
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x466D564", Offset = "0x4669564", VA = "0x466D564")]
		private void OnAlphaChanged(float alpha)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x466D6F4", Offset = "0x46696F4", VA = "0x466D6F4")]
		private bool OnRGBAChanged(BoundInputField source, string input)
		{
			return default;
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x466D924", Offset = "0x4669924", VA = "0x466D924")]
		public static void DestroyInstance()
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x466DA4C", Offset = "0x4669A4C", VA = "0x466DA4C")]
		public static void SetPrefab(ColorPicker picker, Transform createParent)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x466DAB0", Offset = "0x4669AB0", VA = "0x466DAB0")]
		public ColorPicker()
		{
		}
	}
}
