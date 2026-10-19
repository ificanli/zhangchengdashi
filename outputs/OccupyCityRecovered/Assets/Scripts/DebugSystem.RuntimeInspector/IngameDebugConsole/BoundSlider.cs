using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000043")]
	public class BoundSlider : MonoBehaviour
	{
		[Token(Token = "0x2000044")]
		public delegate void OnValueChangedDelegate(BoundSlider source, float value);

		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Slider slider;

		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image sliderBackground;

		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image thumb;

		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x38")]
		private bool sliderFocused;

		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x3C")]
		private int m_skinVersion;

		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x40")]
		private UISkin m_skin;

		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x48")]
		public OnValueChangedDelegate OnValueChanged;

		[Token(Token = "0x1700007E")]
		public Slider BackingField
		{
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x466C480", Offset = "0x4668480", VA = "0x466C480")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		public bool IsFocused
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x466C488", Offset = "0x4668488", VA = "0x466C488")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000080")]
		public float Value
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x466C490", Offset = "0x4668490", VA = "0x466C490")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x4665B04", Offset = "0x4661B04", VA = "0x4665B04")]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public UISkin Skin
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x466C4B4", Offset = "0x46684B4", VA = "0x466C4B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x466593C", Offset = "0x466193C", VA = "0x466593C")]
			set
			{
			}
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x466C4BC", Offset = "0x46684BC", VA = "0x466C4BC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x466C760", Offset = "0x4668760", VA = "0x466C760")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x46654AC", Offset = "0x46614AC", VA = "0x46654AC")]
		public void SetRange(float min, float max)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x466C768", Offset = "0x4668768", VA = "0x466C768")]
		private void SliderValueChanged(float value)
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x466C790", Offset = "0x4668790", VA = "0x466C790")]
		public BoundSlider()
		{
		}
	}
}
