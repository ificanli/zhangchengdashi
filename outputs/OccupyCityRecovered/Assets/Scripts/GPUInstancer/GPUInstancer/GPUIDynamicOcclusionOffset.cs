using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x200005B")]
	[DefaultExecutionOrder(-10)]
	[RequireComponent(typeof(Camera))]
	public class GPUIDynamicOcclusionOffset : MonoBehaviour
	{
		[Token(Token = "0x4000383")]
		[FieldOffset(Offset = "0x20")]
		public GPUInstancerManager[] managers;

		[Token(Token = "0x4000384")]
		[FieldOffset(Offset = "0x28")]
		public float offsetIntensity;

		[Token(Token = "0x4000385")]
		[FieldOffset(Offset = "0x30")]
		private Transform _cachedTransform;

		[Token(Token = "0x4000386")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 _position;

		[Token(Token = "0x4000387")]
		[FieldOffset(Offset = "0x44")]
		private Quaternion _rotation;

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x73F0FA0", Offset = "0x73ECFA0", VA = "0x73F0FA0")]
		public void Reset()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x73F0FFC", Offset = "0x73ECFFC", VA = "0x73F0FFC")]
		public void Start()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x73F1048", Offset = "0x73ED048", VA = "0x73F1048")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x73F138C", Offset = "0x73ED38C", VA = "0x73F138C")]
		public GPUIDynamicOcclusionOffset()
		{
		}
	}
}
