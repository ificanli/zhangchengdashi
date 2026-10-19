using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace GPUInstancer
{
	[Token(Token = "0x2000006")]
	public class TerrainGenerator : MonoBehaviour
	{
		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Texture2D groundTexture;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture2D detailTexture;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject FpsController;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject FixedCamera;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int terrainSize;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int terrainCounter;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 terrainShiftX;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 terrainShiftZ;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Terrain[] terrainArray;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool isCurrentCameraFixed;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[,,] alphaMap;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Color _healthyColor;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Color _dryColor;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _noiseSpread;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float _ambientOcclusion;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _gradientPower;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float _windIdleSway;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool _windWavesOn;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private float _windWaveTint;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float _windWaveSize;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float _windWaveSway;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Color _windWaveTintColor;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool _isBillboard;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
		private bool _useCrossQuads;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int _crossQuadCount;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float _crossQuadBillboardDistance;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector4 _scale;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private bool _isShadowCasting;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE5")]
		private bool _isFrustumCulling;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float _frustumOffset;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float _maxDistance;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector2 _windVector;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Image _healthyColorImage;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Image _dryColorImage;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Slider _noiseSpreadSlider;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Slider _ambientOcclusionSlider;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Slider _gradientPowerSlider;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Slider _windIdleSwaySlider;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Toggle _windWavesOnToggle;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Slider _windWavesTintSlider;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Slider _windWavesSizeSlider;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Slider _windWavesSwaySlider;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Image _windWavesTintColorImage;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Toggle _billboardToggle;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Toggle _crossQuadsToggle;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Slider _crossQuadsCountSlider;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Slider _crossQuadsBillboardDistanceSlider;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private InputField _scaleMinWidthInput;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private InputField _scaleMaxWidthInput;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private InputField _scaleMinHeightInput;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private InputField _scaleMaxHeightInput;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private Toggle _isShadowCastingToggle;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private Toggle _isFrustumCullingToggle;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private Slider _frustumOffsetSlider;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private Slider _maxDistanceSlider;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private InputField _windVectorXInput;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private InputField _windVectorZInput;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private Text _helpDescriptionText;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Text _helpDescriptionTitleText;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Selectable _addTerrainButton;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private Selectable _removeTerrainButton;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private Canvas _uiCanvas;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly string HELPTEXT_detailHealthyColor;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly string HELPTEXT_detailDryColor;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly string HELPTEXT_noiseSpread;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly string HELPTEXT_ambientOcclusion;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly string HELPTEXT_gradientPower;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly string HELPTEXT_windIdleSway;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly string HELPTEXT_windWavesOn;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static readonly string HELPTEXT_windWaveTintColor;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static readonly string HELPTEXT_windWaveSize;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static readonly string HELPTEXT_windWaveSway;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static readonly string HELPTEXT_windWaveTint;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static readonly string HELPTEXT_isBillboard;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static readonly string HELPTEXT_crossQuads;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static readonly string HELPTEXT_quadCount;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static readonly string HELPTEXT_billboardDistance;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static readonly string HELPTEXT_detailScale;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static readonly string HELPTEXT_isShadowCasting;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static readonly string HELPTEXT_isFrustumCulling;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public static readonly string HELPTEXT_frustumOffset;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public static readonly string HELPTEXT_maxDetailDistance;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public static readonly string HELPTEXT_windVector;

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x73AB778", Offset = "0x73A7778", VA = "0x73AB778")]
		private void Start()
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x73AC130", Offset = "0x73A8130", VA = "0x73AC130")]
		private void Update()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x73AC0C8", Offset = "0x73A80C8", VA = "0x73AC0C8")]
		public void AddTerrain()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x73AC1F8", Offset = "0x73A81F8", VA = "0x73AC1F8")]
		public void RemoveTerrain()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x73AC758", Offset = "0x73A8758", VA = "0x73AC758")]
		private void AddInstancer(Terrain terrain)
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x73AC9B8", Offset = "0x73A89B8", VA = "0x73AC9B8")]
		private void UpdateManagers()
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x73ACC1C", Offset = "0x73A8C1C", VA = "0x73ACC1C")]
		public void ReInitializeManagers()
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x73AB880", Offset = "0x73A7880", VA = "0x73AB880")]
		private void SetupUI()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x73ACCC8", Offset = "0x73A8CC8", VA = "0x73ACCC8")]
		public void UpdateDetailSettings()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x73AD0D4", Offset = "0x73A90D4", VA = "0x73AD0D4")]
		public void ShowHelpDescription(Text itemTitle)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x73ADB4C", Offset = "0x73A9B4C", VA = "0x73ADB4C")]
		public void HideHelpDescription()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x73AC92C", Offset = "0x73A892C", VA = "0x73AC92C")]
		private void ManageButtons()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x73AC2B4", Offset = "0x73A82B4", VA = "0x73AC2B4")]
		private void SwitchCameras()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x73AC444", Offset = "0x73A8444", VA = "0x73AC444")]
		private void GenerateTerrain()
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x73ADBE8", Offset = "0x73A9BE8", VA = "0x73ADBE8")]
		private Terrain InitializeTerrainObject(Vector3 position, int terrainSize, float terrainHeight, [Optional][DefaultParameterValue(16)] int baseTextureResolution, [Optional][DefaultParameterValue(16)] int detailResolutionPerPatch, [Optional] TerrainLayer[] terrainLayers, [Optional] DetailPrototype[] detailPrototypes)
		{
			return null;
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x73AE108", Offset = "0x73AA108", VA = "0x73AE108")]
		private TerrainData CreateTerrainData(int terrainSize, float terrainHeight, [Optional][DefaultParameterValue(16)] int baseTextureResolution, [Optional][DefaultParameterValue(16)] int detailResolutionPerPatch, [Optional] TerrainLayer[] terrainLayers, [Optional] DetailPrototype[] detailPrototypes)
		{
			return null;
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x73ADF30", Offset = "0x73A9F30", VA = "0x73ADF30")]
		private void SetDetailMap(Terrain terrain)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x73AE210", Offset = "0x73AA210", VA = "0x73AE210")]
		public TerrainGenerator()
		{
		}
	}
}
