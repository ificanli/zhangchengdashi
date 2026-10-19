using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace GPUInstancer
{
	[Token(Token = "0x200000F")]
	public class DetailDemoSceneController : MonoBehaviour
	{
		[Token(Token = "0x2000010")]
		private enum CameraModes
		{
			[Token(Token = "0x40000AB")]
			FPMode = 0,
			[Token(Token = "0x40000AC")]
			SpaceshipMode = 1,
			[Token(Token = "0x40000AD")]
			MowerMode = 2
		}

		[Token(Token = "0x2000011")]
		private enum QualityMode
		{
			[Token(Token = "0x40000AF")]
			Low = 0,
			[Token(Token = "0x40000B0")]
			Mid = 1,
			[Token(Token = "0x40000B1")]
			High = 2
		}

		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x20")]
		public GameObject fpController;

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x28")]
		public GameObject spaceshipCamera;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x30")]
		public GameObject grassMowerCamera;

		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x38")]
		public GPUInstancerDetailManager detailManager;

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x40")]
		public bool persistRemoval;

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x48")]
		private GameObject _uiCanvas;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x50")]
		private GameObject _spaceShipControlsText;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x58")]
		private GameObject _grassMowerControlsText;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x60")]
		private GameObject _loadingTerrainDetailsText;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x68")]
		private Text _currentQualityModeText;

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x70")]
		private Transform _spaceShip;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x78")]
		private Transform _grassMower;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x80")]
		private GameObject _activeCameraGO;

		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x88")]
		private CameraModes _currentCameraMode;

		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x90")]
		private ParticleSystem _spaceShipThrusterGlow;

		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x98")]
		private QualityMode _currentQualityMode;

		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0xA0")]
		private List<int[,]> detailMapData;

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x73B0AE4", Offset = "0x73ACAE4", VA = "0x73B0AE4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x73B12AC", Offset = "0x73AD2AC", VA = "0x73B12AC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x73B1544", Offset = "0x73AD544", VA = "0x73B1544")]
		private void SwitchCameraMode()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x73B0D9C", Offset = "0x73ACD9C", VA = "0x73B0D9C")]
		private void SetCameraMode(CameraModes cameraMode)
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x73B1818", Offset = "0x73AD818", VA = "0x73B1818")]
		private void DisableLoadingTerrainDetailsText()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x73B16C8", Offset = "0x73AD6C8", VA = "0x73B16C8")]
		private void SetQualityMode(QualityMode qualityMode)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x73B1134", Offset = "0x73AD134", VA = "0x73B1134")]
		private void SetPrototypesByQuality(QualityMode qualityMode)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x73B18B4", Offset = "0x73AD8B4", VA = "0x73B18B4")]
		public DetailDemoSceneController()
		{
		}
	}
}
