using Il2CppDummyDll;
using UnityEngine;

namespace MalbersAnimations
{
	[Token(Token = "0x2000D53")]
	public class UseTransform : MonoBehaviour
	{
		[Token(Token = "0x2000D54")]
		public enum UpdateMode
		{
			[Token(Token = "0x4005F1E")]
			Update = 1,
			[Token(Token = "0x4005F1F")]
			FixedUpdate = 2,
			[Token(Token = "0x4005F20")]
			LateUpdate = 4
		}

		[Token(Token = "0x4005F19")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Transform to use the Position as Reference")]
		public Transform Reference;

		[Token(Token = "0x4005F1A")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Use the Reference's Rotation")]
		public bool rotation;

		[Token(Token = "0x4005F1B")]
		[FieldOffset(Offset = "0x29")]
		[Tooltip("Use the Reference's Position")]
		public bool position;

		[Token(Token = "0x4005F1C")]
		[FieldOffset(Offset = "0x2C")]
		public UpdateMode updateMode;

		[Token(Token = "0x600527A")]
		[Address(RVA = "0x43016F0", Offset = "0x42FD6F0", VA = "0x43016F0")]
		private void Update()
		{
		}

		[Token(Token = "0x600527B")]
		[Address(RVA = "0x43017EC", Offset = "0x42FD7EC", VA = "0x43017EC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600527C")]
		[Address(RVA = "0x4301800", Offset = "0x42FD800", VA = "0x4301800")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600527D")]
		[Address(RVA = "0x4301704", Offset = "0x42FD704", VA = "0x4301704")]
		private void SetTransformReference()
		{
		}

		[Token(Token = "0x600527E")]
		[Address(RVA = "0x4301814", Offset = "0x42FD814", VA = "0x4301814")]
		public UseTransform()
		{
		}
	}
}
