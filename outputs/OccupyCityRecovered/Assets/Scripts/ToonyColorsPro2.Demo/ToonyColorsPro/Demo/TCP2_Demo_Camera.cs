using Il2CppDummyDll;
using UnityEngine;

namespace ToonyColorsPro.Demo
{
	[Token(Token = "0x200000A")]
	public class TCP2_Demo_Camera : MonoBehaviour
	{
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x20")]
		public Transform Pivot;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 pivotOffset;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x34")]
		[Header("Orbit")]
		public float OrbitStrg;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x38")]
		public float OrbitClamp;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x3C")]
		[Header("Panning")]
		public float PanStrgMin;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x40")]
		public float PanStrgMax;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x44")]
		[Header("Zooming")]
		public float ZoomStrg;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x48")]
		public float ZoomClamp;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x4C")]
		public float ZoomDistMin;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x50")]
		public float ZoomDistMax;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x54")]
		[Header("Misc")]
		public float Decceleration;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x58")]
		public RectTransform ignoreMouseRect;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x60")]
		private Rect ignoreMouseActualRect;

		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x70")]
		private Vector3 mouseDelta;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x7C")]
		private Vector3 orbitAcceleration;

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x88")]
		private Vector3 panAcceleration;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x94")]
		private Vector3 moveAcceleration;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0xA0")]
		private float zoomAcceleration;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0xA4")]
		private float zoomDistance;

		[Token(Token = "0x4000030")]
		private const float XMax = 60f;

		[Token(Token = "0x4000031")]
		private const float XMin = 300f;

		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0xA8")]
		private Vector3 mResetCamPos;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0xB4")]
		private Vector3 mResetPivotPos;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0xC0")]
		private Vector3 mResetCamRot;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0xCC")]
		private Vector3 mResetPivotRot;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0xD8")]
		private bool leftMouseHeld;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0xD9")]
		private bool rightMouseHeld;

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0xDA")]
		private bool middleMouseHeld;

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x7D646C8", Offset = "0x7D606C8", VA = "0x7D646C8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x7D64748", Offset = "0x7D60748", VA = "0x7D64748")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x7D6481C", Offset = "0x7D6081C", VA = "0x7D6481C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x7D65034", Offset = "0x7D61034", VA = "0x7D65034")]
		public void ResetView()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x7D6513C", Offset = "0x7D6113C", VA = "0x7D6513C")]
		public TCP2_Demo_Camera()
		{
		}
	}
}
