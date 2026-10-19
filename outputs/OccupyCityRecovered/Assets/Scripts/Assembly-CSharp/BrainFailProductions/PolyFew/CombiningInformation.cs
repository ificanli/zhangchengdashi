using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew
{
	[Token(Token = "0x2000CB4")]
	public class CombiningInformation
	{
		[Token(Token = "0x2000CB5")]
		public enum DiffuseColorSpace
		{
			[Token(Token = "0x4005B2D")]
			NON_LINEAR = 0,
			[Token(Token = "0x4005B2E")]
			LINEAR = 1
		}

		[Token(Token = "0x2000CB6")]
		public enum CompressionType
		{
			[Token(Token = "0x4005B30")]
			UNCOMPRESSED = 0,
			[Token(Token = "0x4005B31")]
			DXT1 = 1,
			[Token(Token = "0x4005B32")]
			ETC2_RGB = 2,
			[Token(Token = "0x4005B33")]
			PVRTC_RGB4 = 3,
			[Token(Token = "0x4005B34")]
			ASTC_RGB = 4
		}

		[Token(Token = "0x2000CB7")]
		public enum CompressionQuality
		{
			[Token(Token = "0x4005B36")]
			LOW = 0,
			[Token(Token = "0x4005B37")]
			MEDIUM = 1,
			[Token(Token = "0x4005B38")]
			HIGH = 2
		}

		[Serializable]
		[Token(Token = "0x2000CB8")]
		public struct Resolution
		{
			[Token(Token = "0x4005B39")]
			[FieldOffset(Offset = "0x0")]
			public int width;

			[Token(Token = "0x4005B3A")]
			[FieldOffset(Offset = "0x4")]
			public int height;
		}

		[Serializable]
		[Token(Token = "0x2000CB9")]
		public class TextureArrayUserSettings
		{
			[Token(Token = "0x4005B3B")]
			[FieldOffset(Offset = "0x10")]
			public Resolution resolution;

			[Token(Token = "0x4005B3C")]
			[FieldOffset(Offset = "0x18")]
			public FilterMode filteringMode;

			[Token(Token = "0x4005B3D")]
			[FieldOffset(Offset = "0x1C")]
			public CompressionType compressionType;

			[Token(Token = "0x4005B3E")]
			[FieldOffset(Offset = "0x20")]
			public CompressionQuality compressionQuality;

			[Token(Token = "0x4005B3F")]
			[FieldOffset(Offset = "0x24")]
			public int anisotropicFilteringLevel;

			[Token(Token = "0x4005B40")]
			[FieldOffset(Offset = "0x28")]
			public int choiceResolutionW;

			[Token(Token = "0x4005B41")]
			[FieldOffset(Offset = "0x2C")]
			public int choiceResolutionH;

			[Token(Token = "0x4005B42")]
			[FieldOffset(Offset = "0x30")]
			public int choiceFilteringMode;

			[Token(Token = "0x4005B43")]
			[FieldOffset(Offset = "0x34")]
			public int choiceCompressionQuality;

			[Token(Token = "0x4005B44")]
			[FieldOffset(Offset = "0x38")]
			public int choiceCompressionType;

			[Token(Token = "0x6004FCC")]
			[Address(RVA = "0x42BAFF8", Offset = "0x42B6FF8", VA = "0x42BAFF8")]
			public TextureArrayUserSettings(Resolution resolution, FilterMode filteringMode, CompressionType compressionType, CompressionQuality compressionQuality = CompressionQuality.MEDIUM, int anisotropicFilteringLevel = 1)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000CBA")]
		public class TextureArrayGroup
		{
			[Token(Token = "0x4005B45")]
			[FieldOffset(Offset = "0x10")]
			public TextureArrayUserSettings diffuseArraySettings;

			[Token(Token = "0x4005B46")]
			[FieldOffset(Offset = "0x18")]
			public TextureArrayUserSettings metallicArraySettings;

			[Token(Token = "0x4005B47")]
			[FieldOffset(Offset = "0x20")]
			public TextureArrayUserSettings specularArraySettings;

			[Token(Token = "0x4005B48")]
			[FieldOffset(Offset = "0x28")]
			public TextureArrayUserSettings normalArraySettings;

			[Token(Token = "0x4005B49")]
			[FieldOffset(Offset = "0x30")]
			public TextureArrayUserSettings heightArraySettings;

			[Token(Token = "0x4005B4A")]
			[FieldOffset(Offset = "0x38")]
			public TextureArrayUserSettings occlusionArraySettings;

			[Token(Token = "0x4005B4B")]
			[FieldOffset(Offset = "0x40")]
			public TextureArrayUserSettings emissiveArraySettings;

			[Token(Token = "0x4005B4C")]
			[FieldOffset(Offset = "0x48")]
			public TextureArrayUserSettings detailMaskArraySettings;

			[Token(Token = "0x4005B4D")]
			[FieldOffset(Offset = "0x50")]
			public TextureArrayUserSettings detailAlbedoArraySettings;

			[Token(Token = "0x4005B4E")]
			[FieldOffset(Offset = "0x58")]
			public TextureArrayUserSettings detailNormalArraySettings;

			[Token(Token = "0x6004FCD")]
			[Address(RVA = "0x42BB058", Offset = "0x42B7058", VA = "0x42BB058")]
			public void InitializeDefaultArraySettings(Resolution resolution, FilterMode filteringMode, CompressionType compressionType, CompressionQuality compressionQuality = CompressionQuality.MEDIUM, int anisotropicFilteringLevel = 1)
			{
			}

			[Token(Token = "0x6004FCE")]
			[Address(RVA = "0x42BAFF0", Offset = "0x42B6FF0", VA = "0x42BAFF0")]
			public TextureArrayGroup()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000CBB")]
		public class MaterialProperties
		{
			[Token(Token = "0x4005B4F")]
			[FieldOffset(Offset = "0x10")]
			public bool foldOut;

			[Token(Token = "0x4005B50")]
			[FieldOffset(Offset = "0x14")]
			public int texArrIndex;

			[Token(Token = "0x4005B51")]
			[FieldOffset(Offset = "0x18")]
			public int matIndex;

			[Token(Token = "0x4005B52")]
			[FieldOffset(Offset = "0x20")]
			public string materialName;

			[Token(Token = "0x4005B53")]
			[FieldOffset(Offset = "0x28")]
			public Material originalMaterial;

			[Token(Token = "0x4005B54")]
			[FieldOffset(Offset = "0x30")]
			public Color albedoTint;

			[Token(Token = "0x4005B55")]
			[FieldOffset(Offset = "0x40")]
			public Vector4 uvTileOffset;

			[Token(Token = "0x4005B56")]
			[FieldOffset(Offset = "0x50")]
			public float normalIntensity;

			[Token(Token = "0x4005B57")]
			[FieldOffset(Offset = "0x54")]
			public float occlusionIntensity;

			[Token(Token = "0x4005B58")]
			[FieldOffset(Offset = "0x58")]
			public float smoothnessIntensity;

			[Token(Token = "0x4005B59")]
			[FieldOffset(Offset = "0x5C")]
			public float glossMapScale;

			[Token(Token = "0x4005B5A")]
			[FieldOffset(Offset = "0x60")]
			public float metalIntensity;

			[Token(Token = "0x4005B5B")]
			[FieldOffset(Offset = "0x64")]
			public Color emissionColor;

			[Token(Token = "0x4005B5C")]
			[FieldOffset(Offset = "0x74")]
			public Vector4 detailUVTileOffset;

			[Token(Token = "0x4005B5D")]
			[FieldOffset(Offset = "0x84")]
			public float alphaCutoff;

			[Token(Token = "0x4005B5E")]
			[FieldOffset(Offset = "0x88")]
			public Color specularColor;

			[Token(Token = "0x4005B5F")]
			[FieldOffset(Offset = "0x98")]
			public float detailNormalScale;

			[Token(Token = "0x4005B60")]
			[FieldOffset(Offset = "0x9C")]
			public float heightIntensity;

			[Token(Token = "0x4005B61")]
			[FieldOffset(Offset = "0xA0")]
			public float uvSec;

			[Token(Token = "0x4005B62")]
			[FieldOffset(Offset = "0xA4")]
			public int alphaMode;

			[Token(Token = "0x4005B63")]
			[FieldOffset(Offset = "0xA8")]
			public bool specularWorkflow;

			[Token(Token = "0x6004FCF")]
			[Address(RVA = "0x42BB28C", Offset = "0x42B728C", VA = "0x42BB28C")]
			public bool IsSameAs(MaterialProperties toCompare)
			{
				return default;
			}

			[Token(Token = "0x6004FD0")]
			[Address(RVA = "0x42BB4D8", Offset = "0x42B74D8", VA = "0x42BB4D8")]
			public static Texture2D NewTexture()
			{
				return null;
			}

			[Token(Token = "0x6004FD1")]
			[Address(RVA = "0x42BB598", Offset = "0x42B7598", VA = "0x42BB598")]
			public void BurnAttrToImg(ref Texture2D burnOn, int index, int textureArrayIndex)
			{
			}

			[Token(Token = "0x6004FD2")]
			[Address(RVA = "0x42BB8D4", Offset = "0x42B78D4", VA = "0x42BB8D4")]
			public void FillPropertiesFromMaterial(Material material, CombiningInformation combineInfo)
			{
			}

			[Token(Token = "0x6004FD3")]
			[Address(RVA = "0x42BBEA8", Offset = "0x42B7EA8", VA = "0x42BBEA8")]
			public MaterialProperties()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000CBC")]
		public class MeshData
		{
			[Token(Token = "0x4005B64")]
			[FieldOffset(Offset = "0x10")]
			public List<MeshFilter> meshFilters;

			[Token(Token = "0x4005B65")]
			[FieldOffset(Offset = "0x18")]
			public List<MeshRenderer> meshRenderers;

			[Token(Token = "0x4005B66")]
			[FieldOffset(Offset = "0x20")]
			public List<SkinnedMeshRenderer> skinnedMeshRenderers;

			[Token(Token = "0x4005B67")]
			[FieldOffset(Offset = "0x28")]
			public Material[] originalMaterials;

			[Token(Token = "0x4005B68")]
			[FieldOffset(Offset = "0x30")]
			public Mesh[] outputMeshes;

			[Token(Token = "0x4005B69")]
			[FieldOffset(Offset = "0x38")]
			public Matrix4x4[] outputMatrices;

			[Token(Token = "0x6004FD4")]
			[Address(RVA = "0x42BBEF0", Offset = "0x42B7EF0", VA = "0x42BBEF0")]
			public MeshData()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000CBD")]
		public class CombineMetaData
		{
			[Token(Token = "0x4005B6A")]
			[FieldOffset(Offset = "0x10")]
			public Material material;

			[Token(Token = "0x4005B6B")]
			[FieldOffset(Offset = "0x18")]
			public MaterialProperties materialProperties;

			[Token(Token = "0x4005B6C")]
			[FieldOffset(Offset = "0x20")]
			public MaterialProperties tempMaterialProperties;

			[Token(Token = "0x4005B6D")]
			[FieldOffset(Offset = "0x28")]
			public List<MeshData> meshesData;

			[Token(Token = "0x6004FD5")]
			[Address(RVA = "0x42BBEF8", Offset = "0x42B7EF8", VA = "0x42BBEF8")]
			public CombineMetaData()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000CBE")]
		public class MaterialEntity
		{
			[Token(Token = "0x4005B6E")]
			[FieldOffset(Offset = "0x10")]
			public List<CombineMetaData> combinedMats;

			[Token(Token = "0x4005B6F")]
			[FieldOffset(Offset = "0x18")]
			public int textArrIndex;

			[Token(Token = "0x4005B70")]
			[FieldOffset(Offset = "0x20")]
			public Texture2D diffuseMap;

			[Token(Token = "0x4005B71")]
			[FieldOffset(Offset = "0x28")]
			public Texture2D metallicMap;

			[Token(Token = "0x4005B72")]
			[FieldOffset(Offset = "0x30")]
			public Texture2D specularMap;

			[Token(Token = "0x4005B73")]
			[FieldOffset(Offset = "0x38")]
			public Texture2D normalMap;

			[Token(Token = "0x4005B74")]
			[FieldOffset(Offset = "0x40")]
			public Texture2D heightMap;

			[Token(Token = "0x4005B75")]
			[FieldOffset(Offset = "0x48")]
			public Texture2D occlusionMap;

			[Token(Token = "0x4005B76")]
			[FieldOffset(Offset = "0x50")]
			public Texture2D emissionMap;

			[Token(Token = "0x4005B77")]
			[FieldOffset(Offset = "0x58")]
			public Texture2D detailMaskMap;

			[Token(Token = "0x4005B78")]
			[FieldOffset(Offset = "0x60")]
			public Texture2D detailAlbedoMap;

			[Token(Token = "0x4005B79")]
			[FieldOffset(Offset = "0x68")]
			public Texture2D detailNormalMap;

			[Token(Token = "0x6004FD6")]
			[Address(RVA = "0x42BBF74", Offset = "0x42B7F74", VA = "0x42BBF74")]
			public bool HasAnyTextures()
			{
				return default;
			}

			[Token(Token = "0x6004FD7")]
			[Address(RVA = "0x42BC14C", Offset = "0x42B814C", VA = "0x42BC14C")]
			public MaterialEntity()
			{
			}
		}

		[Token(Token = "0x4005B28")]
		[FieldOffset(Offset = "0x10")]
		public List<MaterialEntity> materialEntities;

		[Token(Token = "0x4005B29")]
		[FieldOffset(Offset = "0x18")]
		public TextureArrayGroup textureArraysSettings;

		[Token(Token = "0x4005B2A")]
		[FieldOffset(Offset = "0x20")]
		public DiffuseColorSpace diffuseColorSpace;

		[Token(Token = "0x4005B2B")]
		[FieldOffset(Offset = "0x28")]
		public Material[] combinedMaterials;

		[Token(Token = "0x6004FC2")]
		[Address(RVA = "0x42BA0CC", Offset = "0x42B60CC", VA = "0x42BA0CC")]
		public bool ShouldGenerateMetallicArray()
		{
			return default;
		}

		[Token(Token = "0x6004FC3")]
		[Address(RVA = "0x42BA268", Offset = "0x42B6268", VA = "0x42BA268")]
		public bool ShouldGenerateSpecularArray()
		{
			return default;
		}

		[Token(Token = "0x6004FC4")]
		[Address(RVA = "0x42BA404", Offset = "0x42B6404", VA = "0x42BA404")]
		public bool ShouldGenerateNormalArray()
		{
			return default;
		}

		[Token(Token = "0x6004FC5")]
		[Address(RVA = "0x42BA5A0", Offset = "0x42B65A0", VA = "0x42BA5A0")]
		public bool ShouldGenerateHeightArray()
		{
			return default;
		}

		[Token(Token = "0x6004FC6")]
		[Address(RVA = "0x42BA73C", Offset = "0x42B673C", VA = "0x42BA73C")]
		public bool ShouldGenerateOcclusionArray()
		{
			return default;
		}

		[Token(Token = "0x6004FC7")]
		[Address(RVA = "0x42BA8D8", Offset = "0x42B68D8", VA = "0x42BA8D8")]
		public bool ShouldGenerateEmissionArray()
		{
			return default;
		}

		[Token(Token = "0x6004FC8")]
		[Address(RVA = "0x42BAA74", Offset = "0x42B6A74", VA = "0x42BAA74")]
		public bool ShouldGenerateDetailMaskArray()
		{
			return default;
		}

		[Token(Token = "0x6004FC9")]
		[Address(RVA = "0x42BAC10", Offset = "0x42B6C10", VA = "0x42BAC10")]
		public bool ShouldGenerateDetailAlbedoArray()
		{
			return default;
		}

		[Token(Token = "0x6004FCA")]
		[Address(RVA = "0x42BADAC", Offset = "0x42B6DAC", VA = "0x42BADAC")]
		public bool ShouldGenerateDetailNormalArray()
		{
			return default;
		}

		[Token(Token = "0x6004FCB")]
		[Address(RVA = "0x42BAF48", Offset = "0x42B6F48", VA = "0x42BAF48")]
		public CombiningInformation()
		{
		}
	}
}
