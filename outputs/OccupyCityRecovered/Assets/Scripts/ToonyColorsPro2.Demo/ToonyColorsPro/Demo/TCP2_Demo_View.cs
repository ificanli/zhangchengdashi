using Il2CppDummyDll;
using UnityEngine;

namespace ToonyColorsPro.Demo
{
	[Token(Token = "0x2000014")]
	public class TCP2_Demo_View : MonoBehaviour
	{
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x20")]
		[Header("Orbit")]
		public float OrbitStrg;

		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x24")]
		public float OrbitClamp;

		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x28")]
		[Header("Panning")]
		public float PanStrg;

		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x2C")]
		public float PanClamp;

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x30")]
		[Header("Zooming")]
		public float ZoomStrg;

		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x34")]
		public float ZoomClamp;

		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x38")]
		[Header("Misc")]
		public float Decceleration;

		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x40")]
		public Transform CharacterTransform;

		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x48")]
		private Vector3 mouseDelta;

		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x54")]
		private Vector3 orbitAcceleration;

		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 panAcceleration;

		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 moveAcceleration;

		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x78")]
		private float zoomAcceleration;

		[Token(Token = "0x40000C7")]
		private const float XMax = 60f;

		[Token(Token = "0x40000C8")]
		private const float XMin = 300f;

		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x7C")]
		private Vector3 mResetCamPos;

		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x88")]
		private Vector3 mResetCamRot;

		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x94")]
		private bool mMouseDown;

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x7D6AB58", Offset = "0x7D66B58", VA = "0x7D6AB58")]
		private void Awake()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x7D6ABBC", Offset = "0x7D66BBC", VA = "0x7D6ABBC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x7D6ABDC", Offset = "0x7D66BDC", VA = "0x7D6ABDC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x7D6B2DC", Offset = "0x7D672DC", VA = "0x7D6B2DC")]
		public void ResetView()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x7D6B33C", Offset = "0x7D6733C", VA = "0x7D6B33C")]
		public TCP2_Demo_View()
		{
		}
	}
}
