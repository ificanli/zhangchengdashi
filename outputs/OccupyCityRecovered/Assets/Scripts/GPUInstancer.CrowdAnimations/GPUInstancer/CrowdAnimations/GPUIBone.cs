using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GPUInstancer.CrowdAnimations
{
	[Serializable]
	[Token(Token = "0x2000022")]
	public class GPUIBone
	{
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x10")]
		public string boneTransformName;

		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x18")]
		public int boneIndex;

		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x1C")]
		public int parentBoneIndex;

		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x20")]
		public List<int> childBoneIndexes;

		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x28")]
		public bool dontDestroy;

		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x29")]
		public bool isRoot;

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x73CA28C", Offset = "0x73C628C", VA = "0x73CA28C")]
		public void AddChild(int childBoneIndex)
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x73CA5E4", Offset = "0x73C65E4", VA = "0x73CA5E4")]
		public void RemoveChild(int childBoneIndex)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x73CA644", Offset = "0x73C6644", VA = "0x73CA644")]
		public GPUIBone()
		{
		}
	}
}
