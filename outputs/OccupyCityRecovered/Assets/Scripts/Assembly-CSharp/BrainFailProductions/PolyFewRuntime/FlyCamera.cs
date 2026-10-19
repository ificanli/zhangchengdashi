using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFewRuntime
{
	[Token(Token = "0x2000D15")]
	public class FlyCamera : MonoBehaviour
	{
		[Token(Token = "0x4005D84")]
		[FieldOffset(Offset = "0x20")]
		public Transform target;

		[Token(Token = "0x4005D85")]
		[FieldOffset(Offset = "0x28")]
		public float distance;

		[Token(Token = "0x4005D86")]
		[FieldOffset(Offset = "0x2C")]
		public float xSpeed;

		[Token(Token = "0x4005D87")]
		[FieldOffset(Offset = "0x30")]
		public float ySpeed;

		[Token(Token = "0x4005D88")]
		[FieldOffset(Offset = "0x34")]
		public float panSpeed;

		[Token(Token = "0x4005D89")]
		[FieldOffset(Offset = "0x38")]
		public float yMinLimit;

		[Token(Token = "0x4005D8A")]
		[FieldOffset(Offset = "0x3C")]
		public float yMaxLimit;

		[Token(Token = "0x4005D8B")]
		[FieldOffset(Offset = "0x40")]
		public float distanceMin;

		[Token(Token = "0x4005D8C")]
		[FieldOffset(Offset = "0x44")]
		public float distanceMax;

		[Token(Token = "0x4005D8D")]
		[FieldOffset(Offset = "0x48")]
		private Rigidbody rigidbody;

		[Token(Token = "0x4005D8E")]
		[FieldOffset(Offset = "0x50")]
		private float x;

		[Token(Token = "0x4005D8F")]
		[FieldOffset(Offset = "0x54")]
		private float y;

		[Token(Token = "0x4005D90")]
		[FieldOffset(Offset = "0x0")]
		public static bool deactivated;

		[Token(Token = "0x6005161")]
		[Address(RVA = "0x42DCA84", Offset = "0x42D8A84", VA = "0x42DCA84")]
		private void Start()
		{
		}

		[Token(Token = "0x6005162")]
		[Address(RVA = "0x42DCB4C", Offset = "0x42D8B4C", VA = "0x42DCB4C")]
		private void Update()
		{
		}

		[Token(Token = "0x6005163")]
		[Address(RVA = "0x42DCE84", Offset = "0x42D8E84", VA = "0x42DCE84")]
		public static float ClampAngle(float angle, float min, float max)
		{
			return default;
		}

		[Token(Token = "0x6005164")]
		[Address(RVA = "0x42DCEC0", Offset = "0x42D8EC0", VA = "0x42DCEC0")]
		public FlyCamera()
		{
		}
	}
}
