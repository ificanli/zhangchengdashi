using Il2CppDummyDll;
using UnityEngine;

namespace StylizedWater
{
	[Token(Token = "0x200000A")]
	[AddComponentMenu("Effects/Stylized Water")]
	[HelpURL("https://alexander-ameye.gitbook.io/stylized-water/")]
	[ExecuteAlways]
	[RequireComponent(typeof(MeshRenderer), typeof(MeshFilter))]
	public class StylizedWaterURP : MonoBehaviour
	{
		[Token(Token = "0x200000B")]
		public enum FoamMovement
		{
			[Token(Token = "0x400009D")]
			Directional = 0,
			[Token(Token = "0x400009E")]
			Shore = 1
		}

		[Token(Token = "0x200000C")]
		public enum Lighting
		{
			[Token(Token = "0x40000A0")]
			Enabled = 0,
			[Token(Token = "0x40000A1")]
			Disabled = 1
		}

		[Token(Token = "0x200000D")]
		public enum WaterUVs
		{
			[Token(Token = "0x40000A3")]
			Local = 0,
			[Token(Token = "0x40000A4")]
			World = 1
		}

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x20")]
		public bool refractionExpanded;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x21")]
		public bool vertexPaintingExpanded;

		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x22")]
		public bool surfaceFoamExpanded;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x23")]
		public bool foamShadowsExpanded;

		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x24")]
		public bool intersectionEffectsExpanded;

		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x25")]
		public bool planarReflectionsExpanded;

		[Token(Token = "0x400003F")]
		private const string shaderName = "Stylized Water";

		[Token(Token = "0x4000040")]
		private const string mobileShaderName = "Stylized Water Mobile";

		[Token(Token = "0x4000041")]
		private const string underwaterShaderName = "Stylized Water Underwater";

		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		public float reflectionStrength;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 7f)]
		public float reflectionFresnel;

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x30")]
		public bool useColorGradient;

		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x38")]
		[GradientUsage(true)]
		public Gradient colorGradient;

		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x40")]
		public Texture2D colorGradientTexture;

		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x48")]
		[ColorUsage(true, true)]
		public Color shallowColor;

		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x58")]
		[ColorUsage(true, true)]
		public Color deepColor;

		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x68")]
		[Range(0f, 4f)]
		public float colorDepth;

		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x6C")]
		[ColorUsage(true, true)]
		public Color horizonColor;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x7C")]
		[Range(0f, 20f)]
		public float horizonDistance;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float shoreFade;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x84")]
		[ColorUsage(false, false)]
		public Color shoreColor;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x94")]
		[Range(0f, 1f)]
		public float shoreStrength;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x98")]
		[Range(0f, 1f)]
		public float shoreBlend;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x9C")]
		[Range(0f, 3f)]
		public float shoreDepth;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0xA0")]
		[ColorUsage(false, false)]
		public Color waveColor;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0xB0")]
		[ColorUsage(false, false)]
		public Color underwaterColor;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0xC0")]
		[Range(0f, 1f)]
		public float underwaterColorStrength;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0xC4")]
		[Range(0f, 0.3f)]
		public float underwaterRefractionStrength;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0xC8")]
		public Texture surfaceFoamTexture;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0xD0")]
		public Vector2 surfaceFoamSampling;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0xD8")]
		[Range(0f, 1f)]
		public float surfaceFoamCutoff;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0xDC")]
		[Range(0f, 3f)]
		public float surfaceFoamDistortion;

		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0xE0")]
		[Range(0f, 1f)]
		public float surfaceFoamBlend;

		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0xE4")]
		[ColorUsage(true, false)]
		public Color surfaceFoamColor1;

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0xF4")]
		[ColorUsage(true, false)]
		public Color surfaceFoamColor2;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x104")]
		public Vector4 surfaceFoamMovement;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x114")]
		[Range(0f, 1f)]
		public float surfaceFoamDirection1;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x118")]
		[Range(0f, 1f)]
		public float surfaceFoamDirection2;

		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x11C")]
		[Range(0f, 2f)]
		public float surfaceFoamSpeed1;

		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x120")]
		[Range(0f, 2f)]
		public float surfaceFoamSpeed2;

		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x124")]
		public Vector4 surfaceFoamTilingAndOffset;

		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x134")]
		[Range(0f, 1f)]
		public float surfaceFoamOffsetX;

		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x138")]
		[Range(0f, 1f)]
		public float surfaceFoamOffsetY;

		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x13C")]
		[Range(0f, 2f)]
		public float surfaceFoamScale1;

		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x140")]
		[Range(0f, 2f)]
		public float surfaceFoamScale2;

		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x144")]
		public bool enableSurfaceFoam;

		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x148")]
		[Range(0f, 1f)]
		public float surfaceFoamHeightMask;

		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x14C")]
		[Range(0f, 1f)]
		public float surfaceFoamHeightMaskSmoothness;

		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x150")]
		public bool enableHeightMask;

		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x154")]
		[Range(0f, 1f)]
		public float foamShadowStrength;

		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x158")]
		[Range(0f, 10f)]
		public float foamShadowDepth;

		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x15C")]
		[Range(0f, 15f)]
		public float surfaceFoamShadowProjection;

		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x160")]
		[Range(0f, 15f)]
		public float intersectionFoamShadowProjection;

		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x164")]
		public FoamMovement foamMovement;

		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x168")]
		[Range(0f, 3f)]
		public float intersectionFoamDepth;

		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x170")]
		public Texture intersectionFoamTexture;

		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x178")]
		[ColorUsage(true, false)]
		public Color intersectionFoamColor;

		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x188")]
		public Vector2 intersectionFoamMovement;

		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x190")]
		[Range(0f, 1f)]
		public float intersectionFoamDirection;

		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x194")]
		[Range(0f, 2f)]
		public float intersectionFoamSpeed;

		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x198")]
		[Range(0f, 2f)]
		public float intersectionFoamScale;

		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x19C")]
		public Vector2 intersectionFoamSampling;

		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x1A4")]
		[Range(0f, 1f)]
		public float intersectionFoamCutoff;

		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x1A8")]
		[Range(0f, 3f)]
		public float intersectionFoamDistortion;

		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x1AC")]
		public bool enableIntersectionEffects;

		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x1B0")]
		[Range(0f, 1f)]
		public float intersectionFoamBlend;

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x1B4")]
		[Range(0f, 1f)]
		public float intersectionWaterBlend;

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x1B8")]
		[Range(-5f, 5f)]
		public float shoreFoamSpeed;

		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x1BC")]
		[Range(0f, 2f)]
		public float shoreFoamWidth;

		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x1C0")]
		[Range(0f, 40f)]
		public float shoreFoamFrequency;

		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x1C4")]
		[Range(0f, 5f)]
		public float shoreFoamBreakupStrength;

		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x1C8")]
		[Range(0f, 50f)]
		public float shoreFoamBreakupScale;

		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x1CC")]
		public Lighting lighting;

		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x1D0")]
		[Range(0f, 1f)]
		public float lightingSmoothness;

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x1D4")]
		[ColorUsage(false, true)]
		public Color lightingSpecularColor;

		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x1E4")]
		[ColorUsage(false, true)]
		public Color lightingDiffuseColor;

		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x1F4")]
		[Range(0f, 1f)]
		public float lightingHardness;

		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x1F8")]
		public Texture normalsTexture;

		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x200")]
		public Vector2 normalsMovement;

		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x208")]
		[Range(0f, 1f)]
		public float normalsStrength;

		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x20C")]
		[Range(0.01f, 2f)]
		public float normalsScale;

		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x210")]
		[Range(0f, 0.3f)]
		public float normalsSpeed;

		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x214")]
		[Range(0f, 0.3f)]
		public float refractionStrength;

		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x218")]
		public Vector3 waveVisuals;

		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x224")]
		[Range(0f, 0.5f)]
		public float waveSteepness;

		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x228")]
		[Range(0f, 20f)]
		public float waveLength;

		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x22C")]
		[Range(0f, 3f)]
		public float waveSpeed;

		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x230")]
		public Vector4 waveDirections;

		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x240")]
		[Range(0f, 1f)]
		public float waveDirection1;

		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x244")]
		[Range(0f, 1f)]
		public float waveDirection2;

		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x248")]
		[Range(0f, 1f)]
		public float waveDirection3;

		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x24C")]
		[Range(0f, 1f)]
		public float waveDirection4;

		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x250")]
		public WaterUVs waterUVs;

		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x254")]
		public bool hideComponents;

		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x255")]
		public bool enableFoamShadows;

		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x256")]
		public bool enableRefraction;

		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x258")]
		public MeshRenderer meshRenderer;

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x260")]
		public MeshFilter meshFilter;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x268")]
		public Material material;

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x78F7208", Offset = "0x78F3208", VA = "0x78F7208")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x78F9034", Offset = "0x78F5034", VA = "0x78F9034")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x78F9038", Offset = "0x78F5038", VA = "0x78F9038")]
		private void ResetHideFlags()
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x78F9168", Offset = "0x78F5168", VA = "0x78F9168")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x78F916C", Offset = "0x78F516C", VA = "0x78F916C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x78F9170", Offset = "0x78F5170", VA = "0x78F9170")]
		private void SafeDestroyObject(Object obj)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x78F7420", Offset = "0x78F3420", VA = "0x78F7420")]
		public void ReadMaterialProperties()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x78F81F0", Offset = "0x78F41F0", VA = "0x78F81F0")]
		public void WriteMaterialProperties()
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x78F920C", Offset = "0x78F520C", VA = "0x78F920C")]
		public float GetWaveSteepness()
		{
			return default;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x78F9214", Offset = "0x78F5214", VA = "0x78F9214")]
		public float GetWaveLength()
		{
			return default;
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x78F921C", Offset = "0x78F521C", VA = "0x78F921C")]
		public float GetWaveSpeed()
		{
			return default;
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x78F9224", Offset = "0x78F5224", VA = "0x78F9224")]
		public float[] GetWaveDirections()
		{
			return null;
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x78F92BC", Offset = "0x78F52BC", VA = "0x78F92BC")]
		public StylizedWaterURP()
		{
		}
	}
}
