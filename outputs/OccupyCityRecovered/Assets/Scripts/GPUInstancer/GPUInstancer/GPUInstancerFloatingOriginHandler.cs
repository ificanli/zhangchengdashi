using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x2000065")]
	public class GPUInstancerFloatingOriginHandler : MonoBehaviour
	{
		[Token(Token = "0x40003DC")]
		[FieldOffset(Offset = "0x20")]
		public List<GPUInstancerManager> gPUIManagers;

		[Token(Token = "0x40003DD")]
		[FieldOffset(Offset = "0x28")]
		public bool applyRotationAndScale;

		[Token(Token = "0x40003DE")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 _previousPosition;

		[Token(Token = "0x40003DF")]
		[FieldOffset(Offset = "0x38")]
		private Matrix4x4 _previousMatrix;

		[Token(Token = "0x40003E0")]
		[FieldOffset(Offset = "0x78")]
		private Transform _cachedTransform;

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x73FB9D4", Offset = "0x73F79D4", VA = "0x73FB9D4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x73FBA58", Offset = "0x73F7A58", VA = "0x73FBA58")]
		private void Update()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x73FBEC4", Offset = "0x73F7EC4", VA = "0x73FBEC4")]
		public GPUInstancerFloatingOriginHandler()
		{
		}
	}
}
