using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Serializable]
	[Token(Token = "0x2000030")]
	public class BillboardAtlasBinding
	{
		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x10")]
		public GameObject prefab;

		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x18")]
		public int atlasResolution;

		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x1C")]
		public int frameCount;

		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x20")]
		public Texture2D albedoAtlasTexture;

		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x28")]
		public Texture2D normalAtlasTexture;

		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x30")]
		public float quadSize;

		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x34")]
		public float yPivotOffset;

		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x38")]
		public string modifiedDate;

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x73D8754", Offset = "0x73D4754", VA = "0x73D8754")]
		public BillboardAtlasBinding(GameObject prefab, int atlasResolution, int frameCount, Texture2D albedoAtlasTexture, Texture2D normalAtlasTexture, float quadSize, float yPivotOffset)
		{
		}
	}
}
