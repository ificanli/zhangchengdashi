using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Serializable]
	[Token(Token = "0x2000031")]
	public class GPUInstancerCameraData
	{
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x10")]
		public Camera mainCamera;

		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x18")]
		public bool renderOnlySelectedCamera;

		[NonSerialized]
		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x20")]
		public GPUInstancerHiZOcclusionGenerator hiZOcclusionGenerator;

		[NonSerialized]
		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x28")]
		public Matrix4x4 mvpMatrix;

		[NonSerialized]
		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x68")]
		public Matrix4x4 mvpMatrix2;

		[NonSerialized]
		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0xA8")]
		public Vector3 cameraPosition;

		[NonSerialized]
		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0xB4")]
		public bool hasOcclusionGenerator;

		[NonSerialized]
		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0xB8")]
		public float halfAngle;

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x73D8A7C", Offset = "0x73D4A7C", VA = "0x73D8A7C")]
		public GPUInstancerCameraData()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x73D8A84", Offset = "0x73D4A84", VA = "0x73D8A84")]
		public GPUInstancerCameraData(Camera mainCamera)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x73D8B8C", Offset = "0x73D4B8C", VA = "0x73D8B8C")]
		public void SetCamera(Camera mainCamera)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x73D8B94", Offset = "0x73D4B94", VA = "0x73D8B94")]
		public void CalculateCameraData()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x73D8AF4", Offset = "0x73D4AF4", VA = "0x73D8AF4")]
		public void CalculateHalfAngle()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x73D8EE8", Offset = "0x73D4EE8", VA = "0x73D8EE8")]
		public Camera GetRenderingCamera()
		{
			return null;
		}
	}
}
