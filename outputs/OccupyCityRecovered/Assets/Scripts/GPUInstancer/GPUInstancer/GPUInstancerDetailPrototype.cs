using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Serializable]
	[Token(Token = "0x200003B")]
	public class GPUInstancerDetailPrototype : GPUInstancerPrototype
	{
		[Token(Token = "0x40002B8")]
		[FieldOffset(Offset = "0x88")]
		public int prototypeIndex;

		[Token(Token = "0x40002B9")]
		[FieldOffset(Offset = "0x8C")]
		public DetailRenderMode detailRenderMode;

		[Token(Token = "0x40002BA")]
		[FieldOffset(Offset = "0x90")]
		public bool usePrototypeMesh;

		[Token(Token = "0x40002BB")]
		[FieldOffset(Offset = "0x98")]
		public Texture2D prototypeTexture;

		[Token(Token = "0x40002BC")]
		[FieldOffset(Offset = "0xA0")]
		public bool useCustomMaterialForTextureDetail;

		[Token(Token = "0x40002BD")]
		[FieldOffset(Offset = "0xA8")]
		public Material textureDetailCustomMaterial;

		[Token(Token = "0x40002BE")]
		[FieldOffset(Offset = "0xB0")]
		[Range(0f, 1f)]
		public float detailDensity;

		[Token(Token = "0x40002BF")]
		[FieldOffset(Offset = "0xB4")]
		public bool useCrossQuads;

		[Token(Token = "0x40002C0")]
		[FieldOffset(Offset = "0xB8")]
		[Range(1f, 4f)]
		public int quadCount;

		[Token(Token = "0x40002C1")]
		[FieldOffset(Offset = "0xBC")]
		public bool isBillboard;

		[Token(Token = "0x40002C2")]
		[FieldOffset(Offset = "0xC0")]
		[Range(0.5f, 1f)]
		public float billboardDistance;

		[Token(Token = "0x40002C3")]
		[FieldOffset(Offset = "0xC4")]
		public bool billboardDistanceDebug;

		[Token(Token = "0x40002C4")]
		[FieldOffset(Offset = "0xC8")]
		public Color billboardDistanceDebugColor;

		[Token(Token = "0x40002C5")]
		[FieldOffset(Offset = "0xD8")]
		public bool billboardFaceCamPos;

		[Token(Token = "0x40002C6")]
		[FieldOffset(Offset = "0xDC")]
		public Color detailHealthyColor;

		[Token(Token = "0x40002C7")]
		[FieldOffset(Offset = "0xEC")]
		public Color detailDryColor;

		[Token(Token = "0x40002C8")]
		[FieldOffset(Offset = "0xFC")]
		public float noiseSpread;

		[Token(Token = "0x40002C9")]
		[FieldOffset(Offset = "0x100")]
		[Range(0f, 1f)]
		public float ambientOcclusion;

		[Token(Token = "0x40002CA")]
		[FieldOffset(Offset = "0x104")]
		[Range(0f, 1f)]
		public float gradientPower;

		[Token(Token = "0x40002CB")]
		[FieldOffset(Offset = "0x108")]
		public Color windWaveTintColor;

		[Token(Token = "0x40002CC")]
		[FieldOffset(Offset = "0x118")]
		[Range(0f, 1f)]
		public float windIdleSway;

		[Token(Token = "0x40002CD")]
		[FieldOffset(Offset = "0x11C")]
		public bool windWavesOn;

		[Token(Token = "0x40002CE")]
		[FieldOffset(Offset = "0x120")]
		[Range(0f, 1f)]
		public float windWaveSize;

		[Token(Token = "0x40002CF")]
		[FieldOffset(Offset = "0x124")]
		[Range(0f, 1f)]
		public float windWaveTint;

		[Token(Token = "0x40002D0")]
		[FieldOffset(Offset = "0x128")]
		[Range(0f, 1f)]
		public float windWaveSway;

		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x12C")]
		public Vector4 detailScale;

		[Token(Token = "0x40002D2")]
		[FieldOffset(Offset = "0x13C")]
		public bool useCustomHealthyDryNoiseTexture;

		[Token(Token = "0x40002D3")]
		[FieldOffset(Offset = "0x140")]
		public Texture2D healthyDryNoiseTexture;

		[Token(Token = "0x40002D4")]
		[FieldOffset(Offset = "0x148")]
		public float terrainNormalEffect;

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x73DB4C8", Offset = "0x73D74C8", VA = "0x73DB4C8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x73DB550", Offset = "0x73D7550", VA = "0x73DB550", Slot = "4")]
		public override Texture2D GetPreviewTexture()
		{
			return null;
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x73DB558", Offset = "0x73D7558", VA = "0x73DB558")]
		public GPUInstancerDetailPrototype()
		{
		}
	}
}
