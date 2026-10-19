using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x2000049")]
	public class MB3_CopyBoneWeights
	{
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x744BAC4", Offset = "0x7447AC4", VA = "0x744BAC4")]
		public static void CopyBoneWeightsFromSeamMeshToOtherMeshes(float radius, Mesh seamMesh, Mesh[] targetMeshes, Transform[][] newBonesForSMRs, Transform[] seamMeshBones, Transform[][] targMeshBones)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x744CD64", Offset = "0x7448D64", VA = "0x744CD64")]
		private static void RemapBoneWeightIndexes(string nm, ref BoneWeight seamMeshBw, int[] map_seamMeshIdx2targMeshIdx, Transform[] targBones, Dictionary<int, int> extraBones, Transform[] seamBones)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x744D064", Offset = "0x7449064", VA = "0x744D064")]
		public MB3_CopyBoneWeights()
		{
		}
	}
}
