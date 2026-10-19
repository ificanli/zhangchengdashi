using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x20000EE")]
	public class MB_TexSet
	{
		[Token(Token = "0x20000EF")]
		private interface PipelineVariation
		{
			[Token(Token = "0x600052B")]
			void GetRectsForTextureBakeResults(out Rect allPropsUseSameTiling_encapsulatingSamplingRect, out Rect propsUseDifferntTiling_obUVRect);

			[Token(Token = "0x600052C")]
			void SetTilingTreatmentAndAdjustEncapsulatingSamplingRect(MB_TextureTilingTreatment newTilingTreatment);

			[Token(Token = "0x600052D")]
			Rect GetMaterialTilingRectForTextureBakerResults(int materialIndex);

			[Token(Token = "0x600052E")]
			void AdjustResultMaterialNonTextureProperties(Material resultMaterial, List<ShaderTextureProperty> props);
		}

		[Token(Token = "0x20000F0")]
		private class PipelineVariationAllTexturesUseSameMatTiling : PipelineVariation
		{
			[Token(Token = "0x400038D")]
			[FieldOffset(Offset = "0x10")]
			private MB_TexSet texSet;

			[Token(Token = "0x600052F")]
			[Address(RVA = "0x74953DC", Offset = "0x74913DC", VA = "0x74953DC")]
			public PipelineVariationAllTexturesUseSameMatTiling(MB_TexSet ts)
			{
			}

			[Token(Token = "0x6000530")]
			[Address(RVA = "0x7496294", Offset = "0x7492294", VA = "0x7496294", Slot = "4")]
			public void GetRectsForTextureBakeResults(out Rect allPropsUseSameTiling_encapsulatingSamplingRect, out Rect propsUseDifferntTiling_obUVRect)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MB_TexSet.PipelineVariationAllTexturesUseSameMatTiling.GetRectsForTextureBakeResults RVA=0x7496294 Token=0x6000530");
}

			[Token(Token = "0x6000531")]
			[Address(RVA = "0x7496324", Offset = "0x7492324", VA = "0x7496324", Slot = "5")]
			public void SetTilingTreatmentAndAdjustEncapsulatingSamplingRect(MB_TextureTilingTreatment newTilingTreatment)
			{
			}

			[Token(Token = "0x6000532")]
			[Address(RVA = "0x7496430", Offset = "0x7492430", VA = "0x7496430", Slot = "6")]
			public Rect GetMaterialTilingRectForTextureBakerResults(int materialIndex)
			{
				return default;
			}

			[Token(Token = "0x6000533")]
			[Address(RVA = "0x74964C8", Offset = "0x74924C8", VA = "0x74964C8", Slot = "7")]
			public void AdjustResultMaterialNonTextureProperties(Material resultMaterial, List<ShaderTextureProperty> props)
			{
			}
		}

		[Token(Token = "0x20000F1")]
		private class PipelineVariationSomeTexturesUseDifferentMatTiling : PipelineVariation
		{
			[Token(Token = "0x400038E")]
			[FieldOffset(Offset = "0x10")]
			private MB_TexSet texSet;

			[Token(Token = "0x6000534")]
			[Address(RVA = "0x7494DA0", Offset = "0x7490DA0", VA = "0x7494DA0")]
			public PipelineVariationSomeTexturesUseDifferentMatTiling(MB_TexSet ts)
			{
			}

			[Token(Token = "0x6000535")]
			[Address(RVA = "0x74964CC", Offset = "0x74924CC", VA = "0x74964CC", Slot = "4")]
			public void GetRectsForTextureBakeResults(out Rect allPropsUseSameTiling_encapsulatingSamplingRect, out Rect propsUseDifferntTiling_obUVRect)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MB_TexSet.PipelineVariationSomeTexturesUseDifferentMatTiling.GetRectsForTextureBakeResults RVA=0x74964CC Token=0x6000535");
}

			[Token(Token = "0x6000536")]
			[Address(RVA = "0x7496578", Offset = "0x7492578", VA = "0x7496578", Slot = "5")]
			public void SetTilingTreatmentAndAdjustEncapsulatingSamplingRect(MB_TextureTilingTreatment newTilingTreatment)
			{
			}

			[Token(Token = "0x6000537")]
			[Address(RVA = "0x7496684", Offset = "0x7492684", VA = "0x7496684", Slot = "6")]
			public Rect GetMaterialTilingRectForTextureBakerResults(int materialIndex)
			{
				return default;
			}

			[Token(Token = "0x6000538")]
			[Address(RVA = "0x7496698", Offset = "0x7492698", VA = "0x7496698", Slot = "7")]
			public void AdjustResultMaterialNonTextureProperties(Material resultMaterial, List<ShaderTextureProperty> props)
			{
			}
		}

		[Token(Token = "0x4000383")]
		[FieldOffset(Offset = "0x10")]
		public MeshBakerMaterialTexture[] ts;

		[Token(Token = "0x4000384")]
		[FieldOffset(Offset = "0x18")]
		public MatsAndGOs matsAndGOs;

		[Token(Token = "0x400038A")]
		[FieldOffset(Offset = "0x38")]
		public int idealWidth_pix;

		[Token(Token = "0x400038B")]
		[FieldOffset(Offset = "0x3C")]
		public int idealHeight_pix;

		[Token(Token = "0x400038C")]
		[FieldOffset(Offset = "0x40")]
		private PipelineVariation pipelineVariation;

		[Token(Token = "0x170000B6")]
		public bool allTexturesUseSameMatTiling
		{
			[Token(Token = "0x600050C")]
			[Address(RVA = "0x7494BA0", Offset = "0x7490BA0", VA = "0x7494BA0")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x600050D")]
			[Address(RVA = "0x7494BA8", Offset = "0x7490BA8", VA = "0x7494BA8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000B7")]
		public bool thisIsOnlyTexSetInAtlas
		{
			[Token(Token = "0x600050E")]
			[Address(RVA = "0x7494BB4", Offset = "0x7490BB4", VA = "0x7494BB4")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x600050F")]
			[Address(RVA = "0x7494BBC", Offset = "0x7490BBC", VA = "0x7494BBC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000B8")]
		public MB_TextureTilingTreatment tilingTreatment
		{
			[Token(Token = "0x6000510")]
			[Address(RVA = "0x7494BC8", Offset = "0x7490BC8", VA = "0x7494BC8")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000511")]
			[Address(RVA = "0x7494BD0", Offset = "0x7490BD0", VA = "0x7494BD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		public Vector2 obUVoffset
		{
			[Token(Token = "0x6000512")]
			[Address(RVA = "0x7494BD8", Offset = "0x7490BD8", VA = "0x7494BD8")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000513")]
			[Address(RVA = "0x7494BE0", Offset = "0x7490BE0", VA = "0x7494BE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000BA")]
		public Vector2 obUVscale
		{
			[Token(Token = "0x6000514")]
			[Address(RVA = "0x7494BE8", Offset = "0x7490BE8", VA = "0x7494BE8")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000515")]
			[Address(RVA = "0x7494BF0", Offset = "0x7490BF0", VA = "0x7494BF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000BB")]
		internal DRect obUVrect
		{
			[Token(Token = "0x6000516")]
			[Address(RVA = "0x7494BF8", Offset = "0x7490BF8", VA = "0x7494BF8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x7494C30", Offset = "0x7490C30", VA = "0x7494C30")]
		public MB_TexSet(MeshBakerMaterialTexture[] tss, Vector2 uvOffset, Vector2 uvScale, MB_TextureTilingTreatment treatment)
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x7494DC8", Offset = "0x7490DC8", VA = "0x7494DC8")]
		internal bool IsEqual(object obj, bool fixOutOfBoundsUVs, MB3_TextureCombinerNonTextureProperties resultMaterialTextureBlender)
		{
			return default;
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x74950B4", Offset = "0x74910B4", VA = "0x74950B4")]
		public Vector2 GetMaxRawTextureHeightWidth()
		{
			return default;
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x7495158", Offset = "0x7491158", VA = "0x7495158")]
		private Rect GetEncapsulatingSamplingRectIfTilingSame()
		{
			return default;
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x74951C0", Offset = "0x74911C0", VA = "0x74951C0")]
		public void SetEncapsulatingSamplingRectWhenMergingTexSets(DRect newEncapsulatingSamplingRect)
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x7495214", Offset = "0x7491214", VA = "0x7495214")]
		public void SetEncapsulatingSamplingRectForTesting(int propIdx, DRect newEncapsulatingSamplingRect)
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x7495250", Offset = "0x7491250", VA = "0x7495250")]
		public void SetEncapsulatingRect(int propIdx, bool considerMeshUVs)
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x74952D0", Offset = "0x74912D0", VA = "0x74952D0")]
		public void CreateColoredTexToReplaceNull(string propName, int propIdx, bool considerMeshUVs, MB3_TextureCombiner combiner, Color col, bool isLinear)
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x749536C", Offset = "0x749136C", VA = "0x749536C")]
		public void SetThisIsOnlyTexSetInAtlasTrue()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x7495378", Offset = "0x7491378", VA = "0x7495378")]
		public void SetAllTexturesUseSameMatTilingTrue()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x7495404", Offset = "0x7491404", VA = "0x7495404")]
		public void AdjustResultMaterialNonTextureProperties(Material resultMaterial, List<ShaderTextureProperty> props)
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x74954C0", Offset = "0x74914C0", VA = "0x74954C0")]
		public void SetTilingTreatmentAndAdjustEncapsulatingSamplingRect(MB_TextureTilingTreatment newTilingTreatment)
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x7495570", Offset = "0x7491570", VA = "0x7495570")]
		internal void GetRectsForTextureBakeResults(out Rect allPropsUseSameTiling_encapsulatingSamplingRect, out Rect propsUseDifferntTiling_obUVRect)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MB_TexSet.GetRectsForTextureBakeResults RVA=0x7495570 Token=0x6000523");
}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x7495628", Offset = "0x7491628", VA = "0x7495628")]
		internal Rect GetMaterialTilingRectForTextureBakerResults(int materialIndex)
		{
			return default;
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x74956D4", Offset = "0x74916D4", VA = "0x74956D4")]
		internal void CalcInitialFullSamplingRects(bool fixOutOfBoundsUVs)
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x749589C", Offset = "0x749189C", VA = "0x749589C")]
		internal void CalcMatAndUVSamplingRects()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x74959D8", Offset = "0x74919D8", VA = "0x74959D8")]
		public bool AllTexturesAreSameForMerge(MB_TexSet other, bool considerNonTextureProperties, MB3_TextureCombinerNonTextureProperties resultMaterialTextureBlender)
		{
			return default;
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x7495C10", Offset = "0x7491C10", VA = "0x7495C10")]
		public void DrawRectsToMergeGizmos(Color encC, Color innerC)
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x7495E84", Offset = "0x7491E84", VA = "0x7495E84")]
		internal string GetDescription()
		{
			return null;
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x7496128", Offset = "0x7492128", VA = "0x7496128")]
		internal string GetMatSubrectDescriptions()
		{
			return null;
		}
	}
}
