using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer.CrowdAnimations
{
	[Serializable]
	[Token(Token = "0x2000021")]
	public class GPUISkinnedMeshData
	{
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x10")]
		public string transformName;

		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x18")]
		public int[] boneIndexes;

		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x20")]
		public int rootBoneIndex;

		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x24")]
		public bool hasBindPoseOffset;

		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x28")]
		public Matrix4x4 bindPoseOffset;

		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x68")]
		public bool isOptional;

		[NonSerialized]
		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x69")]
		public bool isOptionalPrototypeGenerated;

		[NonSerialized]
		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x70")]
		public GPUICrowdPrototype optionalPrototype;

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x73CA580", Offset = "0x73C6580", VA = "0x73CA580")]
		public int GetArrayIndexOfBone(GPUIBone bone)
		{
			return default;
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x73CA5DC", Offset = "0x73C65DC", VA = "0x73CA5DC")]
		public GPUISkinnedMeshData()
		{
		}
	}
}
