using Il2CppDummyDll;
using UnityEngine;

namespace PolygonArsenal
{
	[Token(Token = "0x2000CAE")]
	public class PolygonBeamStatic : MonoBehaviour
	{
		[Token(Token = "0x4005B03")]
		[FieldOffset(Offset = "0x20")]
		[Header("Prefabs")]
		public GameObject beamLineRendererPrefab;

		[Token(Token = "0x4005B04")]
		[FieldOffset(Offset = "0x28")]
		public GameObject beamStartPrefab;

		[Token(Token = "0x4005B05")]
		[FieldOffset(Offset = "0x30")]
		public GameObject beamEndPrefab;

		[Token(Token = "0x4005B06")]
		[FieldOffset(Offset = "0x38")]
		private GameObject beamStart;

		[Token(Token = "0x4005B07")]
		[FieldOffset(Offset = "0x40")]
		private GameObject beamEnd;

		[Token(Token = "0x4005B08")]
		[FieldOffset(Offset = "0x48")]
		private GameObject beam;

		[Token(Token = "0x4005B09")]
		[FieldOffset(Offset = "0x50")]
		private LineRenderer line;

		[Token(Token = "0x4005B0A")]
		[FieldOffset(Offset = "0x58")]
		[Header("Beam Options")]
		public bool beamCollides;

		[Token(Token = "0x4005B0B")]
		[FieldOffset(Offset = "0x5C")]
		public float beamLength;

		[Token(Token = "0x4005B0C")]
		[FieldOffset(Offset = "0x60")]
		public float beamEndOffset;

		[Token(Token = "0x4005B0D")]
		[FieldOffset(Offset = "0x64")]
		public float textureScrollSpeed;

		[Token(Token = "0x4005B0E")]
		[FieldOffset(Offset = "0x68")]
		public float textureLengthScale;

		[Token(Token = "0x4005B0F")]
		[FieldOffset(Offset = "0x6C")]
		[Header("Width Pulse Options")]
		public float widthMultiplier;

		[Token(Token = "0x4005B10")]
		[FieldOffset(Offset = "0x70")]
		private float customWidth;

		[Token(Token = "0x4005B11")]
		[FieldOffset(Offset = "0x74")]
		private float originalWidth;

		[Token(Token = "0x4005B12")]
		[FieldOffset(Offset = "0x78")]
		private float lerpValue;

		[Token(Token = "0x4005B13")]
		[FieldOffset(Offset = "0x7C")]
		public float pulseSpeed;

		[Token(Token = "0x4005B14")]
		[FieldOffset(Offset = "0x80")]
		private bool pulseExpanding;

		[Token(Token = "0x6004FB2")]
		[Address(RVA = "0x42B8EB0", Offset = "0x42B4EB0", VA = "0x42B8EB0")]
		private void Start()
		{
		}

		[Token(Token = "0x6004FB3")]
		[Address(RVA = "0x42B91E4", Offset = "0x42B51E4", VA = "0x42B91E4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6004FB4")]
		[Address(RVA = "0x42B8EE4", Offset = "0x42B4EE4", VA = "0x42B8EE4")]
		public void SpawnBeam()
		{
		}

		[Token(Token = "0x6004FB5")]
		[Address(RVA = "0x42B9750", Offset = "0x42B5750", VA = "0x42B9750")]
		public PolygonBeamStatic()
		{
		}
	}
}
