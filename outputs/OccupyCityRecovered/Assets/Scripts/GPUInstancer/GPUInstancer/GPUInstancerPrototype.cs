using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Serializable]
	[Token(Token = "0x200002B")]
	public abstract class GPUInstancerPrototype : ScriptableObject
	{
		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x18")]
		public GameObject prefabObject;

		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x20")]
		public bool isShadowCasting;

		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x21")]
		public bool useCustomShadowDistance;

		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x24")]
		public float shadowDistance;

		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x28")]
		public float[] shadowLODMap;

		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x30")]
		public bool useOriginalShaderForShadow;

		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x31")]
		public bool cullShadows;

		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x34")]
		public float minDistance;

		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x38")]
		public float maxDistance;

		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x3C")]
		public bool isFrustumCulling;

		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x3D")]
		public bool isOcclusionCulling;

		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x40")]
		public float frustumOffset;

		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x44")]
		public float minCullingDistance;

		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x48")]
		public float occlusionOffset;

		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x4C")]
		public int occlusionAccuracy;

		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x50")]
		public Vector3 boundsOffset;

		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x5C")]
		public bool isLODCrossFade;

		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x5D")]
		public bool isLODCrossFadeAnimate;

		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x60")]
		[Range(0.01f, 1f)]
		public float lodFadeTransitionWidth;

		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x64")]
		public float lodBiasAdjustment;

		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x68")]
		public GPUInstancerBillboard billboard;

		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x70")]
		public bool isBillboardDisabled;

		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x71")]
		public bool useGeneratedBillboard;

		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x72")]
		public bool checkedForBillboardExtensions;

		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x73")]
		public bool autoUpdateTransformData;

		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x74")]
		public GPUInstancerTreeType treeType;

		[NonSerialized]
		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x78")]
		public string warningText;

		[NonSerialized]
		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x80")]
		public Shader warningShader;

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x73D7590", Offset = "0x73D3590", VA = "0x73D7590", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x73D760C", Offset = "0x73D360C", VA = "0x73D760C", Slot = "4")]
		public virtual Texture2D GetPreviewTexture()
		{
			return null;
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x73D7614", Offset = "0x73D3614", VA = "0x73D7614")]
		protected GPUInstancerPrototype()
		{
		}
	}
}
