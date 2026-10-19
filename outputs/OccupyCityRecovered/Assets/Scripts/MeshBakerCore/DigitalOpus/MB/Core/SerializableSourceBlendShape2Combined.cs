using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Serializable]
	[Token(Token = "0x20000CA")]
	public class SerializableSourceBlendShape2Combined
	{
		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0x10")]
		public GameObject[] srcGameObject;

		[Token(Token = "0x40002DF")]
		[FieldOffset(Offset = "0x18")]
		public int[] srcBlendShapeIdx;

		[Token(Token = "0x40002E0")]
		[FieldOffset(Offset = "0x20")]
		public GameObject[] combinedMeshTargetGameObject;

		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0x28")]
		public int[] blendShapeIdx;

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x74851C8", Offset = "0x74811C8", VA = "0x74851C8")]
		public void SetBuffers(GameObject[] srcGameObjs, int[] srcBlendShapeIdxs, GameObject[] targGameObjs, int[] targBlendShapeIdx)
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x74851D4", Offset = "0x74811D4", VA = "0x74851D4")]
		public void DebugPrint()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x748544C", Offset = "0x748144C", VA = "0x748544C")]
		public Dictionary<MB3_MeshCombiner.MBBlendShapeKey, MB3_MeshCombiner.MBBlendShapeValue> GenerateMapFromSerializedData()
		{
			return null;
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x7484900", Offset = "0x7480900", VA = "0x7484900")]
		public SerializableSourceBlendShape2Combined()
		{
		}
	}
}
