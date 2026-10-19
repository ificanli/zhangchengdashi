using Il2CppDummyDll;
using UnityEngine;

namespace ToonyColorsPro.Demo
{
	[Token(Token = "0x2000013")]
	public class TCP2_Demo_PBS_View : MonoBehaviour
	{
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x20")]
		public Transform Pivot;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x28")]
		[Header("Orbit")]
		public float OrbitStrg;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x2C")]
		public float OrbitClamp;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x30")]
		[Header("Panning")]
		public float PanStrg;

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x34")]
		public float PanClamp;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x38")]
		public float yMin;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x3C")]
		public float yMax;

		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x40")]
		[Header("Zooming")]
		public float ZoomStrg;

		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x44")]
		public float ZoomClamp;

		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x48")]
		public float ZoomDistMin;

		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x4C")]
		public float ZoomDistMax;

		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x50")]
		[Header("Misc")]
		public float Decceleration;

		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x54")]
		public Rect ignoreMouseRect;

		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x64")]
		private Vector3 mouseDelta;

		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x70")]
		private Vector3 orbitAcceleration;

		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x7C")]
		private Vector3 panAcceleration;

		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x88")]
		private Vector3 moveAcceleration;

		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x94")]
		private float zoomAcceleration;

		[Token(Token = "0x40000B1")]
		private const float XMax = 60f;

		[Token(Token = "0x40000B2")]
		private const float XMin = 300f;

		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x98")]
		private Vector3 mResetCamPos;

		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0xA4")]
		private Vector3 mResetPivotPos;

		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0xB0")]
		private Vector3 mResetCamRot;

		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0xBC")]
		private Vector3 mResetPivotRot;

		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0xC8")]
		private bool leftMouseHeld;

		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0xC9")]
		private bool rightMouseHeld;

		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0xCA")]
		private bool middleMouseHeld;

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x7D6A1BC", Offset = "0x7D661BC", VA = "0x7D6A1BC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x7D6A23C", Offset = "0x7D6623C", VA = "0x7D6A23C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x7D6A25C", Offset = "0x7D6625C", VA = "0x7D6A25C")]
		private void Update()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x7D6AA3C", Offset = "0x7D66A3C", VA = "0x7D6AA3C")]
		public void ResetView()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x7D6AB30", Offset = "0x7D66B30", VA = "0x7D6AB30")]
		public TCP2_Demo_PBS_View()
		{
		}
	}
}
