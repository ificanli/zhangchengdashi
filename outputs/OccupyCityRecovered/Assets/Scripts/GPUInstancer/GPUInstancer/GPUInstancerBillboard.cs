using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Serializable]
	[Token(Token = "0x200002C")]
	public class GPUInstancerBillboard
	{
		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x10")]
		public BillboardQuality billboardQuality;

		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x14")]
		public int atlasResolution;

		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x18")]
		public int frameCount;

		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x1C")]
		public bool replaceLODCullWithBillboard;

		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x1D")]
		public bool isOverridingOriginalCutoff;

		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x20")]
		public float cutoffOverride;

		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x24")]
		[Range(0f, 1f)]
		public float billboardBrightness;

		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x28")]
		[Range(0.01f, 1f)]
		public float billboardDistance;

		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x2C")]
		public float quadSize;

		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x30")]
		public float yPivotOffset;

		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x38")]
		public Texture2D albedoAtlasTexture;

		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x40")]
		public Texture2D normalAtlasTexture;

		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x48")]
		public bool customBillboardInLODGroup;

		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x49")]
		public bool useCustomBillboard;

		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x50")]
		public Mesh customBillboardMesh;

		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x58")]
		public Material customBillboardMaterial;

		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x60")]
		public bool isBillboardShadowCasting;

		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x61")]
		public bool billboardFaceCamPos;

		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x64")]
		public float normalStrength;

		[NonSerialized]
		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x68")]
		public bool isBeingDeleted;

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x73D76D0", Offset = "0x73D36D0", VA = "0x73D76D0")]
		public GPUInstancerBillboard()
		{
		}
	}
}
