using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace ToonyColorsPro.Demo
{
	[Token(Token = "0x2000011")]
	public class TCP2_Demo_PBS : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000012")]
		public class SkyboxSetting
		{
			[Token(Token = "0x400009C")]
			[FieldOffset(Offset = "0x10")]
			public Material SkyMaterial;

			[Token(Token = "0x400009D")]
			[FieldOffset(Offset = "0x18")]
			public Color lightColor;

			[Token(Token = "0x400009E")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 DirLightEuler;

			[Token(Token = "0x6000057")]
			[Address(RVA = "0x7D6A1B4", Offset = "0x7D661B4", VA = "0x7D6A1B4")]
			public SkyboxSetting()
			{
			}
		}

		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x20")]
		public Light DirLight;

		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x28")]
		public GameObject PointLights;

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x30")]
		public MeshRenderer Robot;

		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Canvas;

		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x40")]
		public SkyboxSetting[] SkySettings;

		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x48")]
		public bool FlipLight;

		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x50")]
		public Texture2D[] RampTextures;

		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x58")]
		public Slider SmoothnessSlider;

		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x60")]
		public Text SmoothnessValue;

		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x68")]
		public Slider MetallicSlider;

		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x70")]
		public Text MetallicValue;

		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x78")]
		public Text BumpScaleValue;

		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x80")]
		public Text ShaderText;

		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x88")]
		public Text SkyboxValue;

		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x90")]
		public Text RampValue;

		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x98")]
		public Slider RampThresholdSlider;

		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0xA0")]
		public Text RampThresholdValue;

		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0xA8")]
		public Slider RampSmoothSlider;

		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0xB0")]
		public Text RampSmoothValue;

		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0xB8")]
		public Slider RampSmoothAddSlider;

		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0xC0")]
		public Text RampSmoothAddValue;

		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0xC8")]
		public RawImage RampImage;

		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0xD0")]
		private int currentSky;

		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0xD4")]
		private int currentRamp;

		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0xD8")]
		private Material robotMaterial;

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0xE0")]
		private bool mUseOutline;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0xE1")]
		private bool mRotatePointLights;

		[Token(Token = "0x17000006")]
		public bool ShowPointLights
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x7D69118", Offset = "0x7D65118", VA = "0x7D69118")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public bool ShowDirLight
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x7D69138", Offset = "0x7D65138", VA = "0x7D69138")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public bool RotatePointLights
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x7D69158", Offset = "0x7D65158", VA = "0x7D69158")]
			get
			{
				return default;
			}
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x7D69160", Offset = "0x7D65160", VA = "0x7D69160")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public bool UseOutline
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x7D6916C", Offset = "0x7D6516C", VA = "0x7D6916C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x7D69174", Offset = "0x7D65174", VA = "0x7D69174")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public bool UseRampTexture
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x7D692D8", Offset = "0x7D652D8", VA = "0x7D692D8")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public bool UseStylizedFresnel
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x7D69378", Offset = "0x7D65378", VA = "0x7D69378")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public bool UseStylizedSpecular
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x7D69418", Offset = "0x7D65418", VA = "0x7D69418")]
			set
			{
			}
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x7D694B8", Offset = "0x7D654B8", VA = "0x7D694B8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x7D69A00", Offset = "0x7D65A00", VA = "0x7D69A00")]
		private void Update()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x7D69B88", Offset = "0x7D65B88", VA = "0x7D69B88")]
		public void ToggleShader()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x7D69B20", Offset = "0x7D65B20", VA = "0x7D69B20")]
		public void NextSky()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x7D69B54", Offset = "0x7D65B54", VA = "0x7D69B54")]
		public void PrevSky()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x7D69CC0", Offset = "0x7D65CC0", VA = "0x7D69CC0")]
		public void NextRamp()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x7D69CF4", Offset = "0x7D65CF4", VA = "0x7D69CF4")]
		public void PrevRamp()
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x7D69D28", Offset = "0x7D65D28", VA = "0x7D69D28")]
		public void SetMetallic(float f)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x7D69DE0", Offset = "0x7D65DE0", VA = "0x7D69DE0")]
		public void SetSmoothness(float f)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x7D69E98", Offset = "0x7D65E98", VA = "0x7D69E98")]
		public void SetBumpScale(float f)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x7D69F50", Offset = "0x7D65F50", VA = "0x7D69F50")]
		public void SetRampThreshold(float f)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x7D6A008", Offset = "0x7D66008", VA = "0x7D6A008")]
		public void SetRampSmooth(float f)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x7D6A0C0", Offset = "0x7D660C0", VA = "0x7D6A0C0")]
		public void SetRampSmoothAdd(float f)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x7D698B4", Offset = "0x7D658B4", VA = "0x7D698B4")]
		private void UpdateRamp()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x7D696A4", Offset = "0x7D656A4", VA = "0x7D696A4")]
		private void UpdateSky()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x7D69C5C", Offset = "0x7D65C5C", VA = "0x7D69C5C")]
		private void ShowUnityStandardShader()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x7D69200", Offset = "0x7D65200", VA = "0x7D69200")]
		public void ShowTCP2Shader()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x7D6A178", Offset = "0x7D66178", VA = "0x7D6A178")]
		private void ToggleKeyword(Material m, bool enabled, string keyword)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x7D6A1A0", Offset = "0x7D661A0", VA = "0x7D6A1A0")]
		public TCP2_Demo_PBS()
		{
		}
	}
}
