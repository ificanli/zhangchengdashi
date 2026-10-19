using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer.CrowdAnimations
{
	[Serializable]
	[Token(Token = "0x200001D")]
	public class GPUICrowdAnimationData : ScriptableObject
	{
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x18")]
		public float bakedCAVersion;

		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x20")]
		public List<GPUIAnimationClipData> clipDataList;

		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x28")]
		public List<GPUISkinnedMeshData> skinnedMeshDataList;

		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x30")]
		public List<GPUIBone> bones;

		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x38")]
		public List<GPUIAnimatorState> states;

		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x40")]
		public Texture2D animationTexture;

		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x48")]
		public int totalFrameCount;

		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x4C")]
		public int totalBoneCount;

		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x50")]
		public int textureSizeX;

		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x54")]
		public int textureSizeY;

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x58")]
		public bool optimizeGameObjects;

		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x59")]
		public bool useCrowdAnimator;

		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x5C")]
		public int crowdAnimatorDefaultClip;

		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x60")]
		public bool applyRootMotion;

		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x68")]
		public GPUIRootMotion[] rootMotions;

		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x70")]
		public bool applyBoneUpdates;

		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x71")]
		public bool isSynchronousBoneUpdates;

		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x78")]
		public Matrix4x4[] bindPoses;

		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x80")]
		public string[] exposedTransforms;

		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x88")]
		public int[] exposedBoneIndexes;

		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x90")]
		public int asyncBoneUpdateMaxLatency;

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x73C9F6C", Offset = "0x73C5F6C", VA = "0x73C9F6C")]
		public GPUICrowdAnimationData()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x73CA094", Offset = "0x73C6094", VA = "0x73CA094")]
		public GPUIBone GetBoneByTransform(string boneTransformName)
		{
			return null;
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x73CA1B8", Offset = "0x73C61B8", VA = "0x73CA1B8")]
		public int GetBoneIndexByTransform(string boneTransformName)
		{
			return default;
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x73CA260", Offset = "0x73C6260", VA = "0x73CA260")]
		public void BoneSetParent(GPUIBone child, GPUIBone parent)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x73CA3A4", Offset = "0x73C63A4", VA = "0x73CA3A4")]
		public bool IsOptimizeGameObjects()
		{
			return default;
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x73CA3D4", Offset = "0x73C63D4", VA = "0x73CA3D4")]
		public GPUISkinnedMeshData GetSkinnedMeshDataByName(string transformName)
		{
			return null;
		}
	}
}
