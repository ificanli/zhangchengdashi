using Il2CppDummyDll;
using UnityEngine;

namespace PolygonArsenal
{
	[Token(Token = "0x2000CAB")]
	[AddComponentMenu("Camera-Control/Mouse drag Orbit with zoom")]
	public class PolygonOrbit : MonoBehaviour
	{
		[Token(Token = "0x4005AE6")]
		[FieldOffset(Offset = "0x20")]
		public Transform target;

		[Token(Token = "0x4005AE7")]
		[FieldOffset(Offset = "0x28")]
		public float distance;

		[Token(Token = "0x4005AE8")]
		[FieldOffset(Offset = "0x2C")]
		public float xSpeed;

		[Token(Token = "0x4005AE9")]
		[FieldOffset(Offset = "0x30")]
		public float ySpeed;

		[Token(Token = "0x4005AEA")]
		[FieldOffset(Offset = "0x34")]
		public float yMinLimit;

		[Token(Token = "0x4005AEB")]
		[FieldOffset(Offset = "0x38")]
		public float yMaxLimit;

		[Token(Token = "0x4005AEC")]
		[FieldOffset(Offset = "0x3C")]
		public float distanceMin;

		[Token(Token = "0x4005AED")]
		[FieldOffset(Offset = "0x40")]
		public float distanceMax;

		[Token(Token = "0x4005AEE")]
		[FieldOffset(Offset = "0x44")]
		public float smoothTime;

		[Token(Token = "0x4005AEF")]
		[FieldOffset(Offset = "0x48")]
		private float rotationYAxis;

		[Token(Token = "0x4005AF0")]
		[FieldOffset(Offset = "0x4C")]
		private float rotationXAxis;

		[Token(Token = "0x4005AF1")]
		[FieldOffset(Offset = "0x50")]
		private float velocityX;

		[Token(Token = "0x4005AF2")]
		[FieldOffset(Offset = "0x54")]
		private float velocityY;

		[Token(Token = "0x6004F70")]
		[Address(RVA = "0x42B632C", Offset = "0x42B232C", VA = "0x42B632C")]
		private void Start()
		{
		}

		[Token(Token = "0x6004F71")]
		[Address(RVA = "0x42B63F8", Offset = "0x42B23F8", VA = "0x42B63F8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6004F72")]
		[Address(RVA = "0x42B6788", Offset = "0x42B2788", VA = "0x42B6788")]
		public static float ClampAngle(float angle, float min, float max)
		{
			return default;
		}

		[Token(Token = "0x6004F73")]
		[Address(RVA = "0x42B67C4", Offset = "0x42B27C4", VA = "0x42B67C4")]
		public PolygonOrbit()
		{
		}
	}
}
