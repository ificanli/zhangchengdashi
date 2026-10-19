using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace PolygonArsenal
{
	[Token(Token = "0x2000CA4")]
	public class PolygonBeamScript : MonoBehaviour
	{
		[Token(Token = "0x4005AB2")]
		[FieldOffset(Offset = "0x20")]
		[Header("Prefabs")]
		public GameObject[] beamLineRendererPrefab;

		[Token(Token = "0x4005AB3")]
		[FieldOffset(Offset = "0x28")]
		public GameObject[] beamStartPrefab;

		[Token(Token = "0x4005AB4")]
		[FieldOffset(Offset = "0x30")]
		public GameObject[] beamEndPrefab;

		[Token(Token = "0x4005AB5")]
		[FieldOffset(Offset = "0x38")]
		private int currentBeam;

		[Token(Token = "0x4005AB6")]
		[FieldOffset(Offset = "0x40")]
		private GameObject beamStart;

		[Token(Token = "0x4005AB7")]
		[FieldOffset(Offset = "0x48")]
		private GameObject beamEnd;

		[Token(Token = "0x4005AB8")]
		[FieldOffset(Offset = "0x50")]
		private GameObject beam;

		[Token(Token = "0x4005AB9")]
		[FieldOffset(Offset = "0x58")]
		private LineRenderer line;

		[Token(Token = "0x4005ABA")]
		[FieldOffset(Offset = "0x60")]
		[Header("Adjustable Variables")]
		public float beamEndOffset;

		[Token(Token = "0x4005ABB")]
		[FieldOffset(Offset = "0x64")]
		public float textureScrollSpeed;

		[Token(Token = "0x4005ABC")]
		[FieldOffset(Offset = "0x68")]
		public float textureLengthScale;

		[Token(Token = "0x4005ABD")]
		[FieldOffset(Offset = "0x70")]
		[Header("Put Sliders here (Optional)")]
		public Slider endOffSetSlider;

		[Token(Token = "0x4005ABE")]
		[FieldOffset(Offset = "0x78")]
		public Slider scrollSpeedSlider;

		[Token(Token = "0x4005ABF")]
		[FieldOffset(Offset = "0x80")]
		[Header("Put UI Text object here to show beam name")]
		public Text textBeamName;

		[Token(Token = "0x6004F46")]
		[Address(RVA = "0x42B3E20", Offset = "0x42AFE20", VA = "0x42B3E20")]
		private void Start()
		{
		}

		[Token(Token = "0x6004F47")]
		[Address(RVA = "0x42B3F60", Offset = "0x42AFF60", VA = "0x42B3F60")]
		private void Update()
		{
		}

		[Token(Token = "0x6004F48")]
		[Address(RVA = "0x42B47C0", Offset = "0x42B07C0", VA = "0x42B47C0")]
		public void nextBeam()
		{
		}

		[Token(Token = "0x6004F49")]
		[Address(RVA = "0x42B48A0", Offset = "0x42B08A0", VA = "0x42B48A0")]
		public void previousBeam()
		{
		}

		[Token(Token = "0x6004F4A")]
		[Address(RVA = "0x42B4980", Offset = "0x42B0980", VA = "0x42B4980")]
		public void UpdateEndOffset()
		{
		}

		[Token(Token = "0x6004F4B")]
		[Address(RVA = "0x42B49B0", Offset = "0x42B09B0", VA = "0x42B49B0")]
		public void UpdateScrollSpeed()
		{
		}

		[Token(Token = "0x6004F4C")]
		[Address(RVA = "0x42B4370", Offset = "0x42B0370", VA = "0x42B4370")]
		private void ShootBeamInDir(Vector3 start, Vector3 dir)
		{
		}

		[Token(Token = "0x6004F4D")]
		[Address(RVA = "0x42B49E0", Offset = "0x42B09E0", VA = "0x42B49E0")]
		public PolygonBeamScript()
		{
		}
	}
}
