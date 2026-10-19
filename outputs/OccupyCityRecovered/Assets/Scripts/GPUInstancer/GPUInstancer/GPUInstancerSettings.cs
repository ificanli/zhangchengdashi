using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x2000044")]
	public class GPUInstancerSettings : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x2000045")]
		public class GPUIRenderingSettings
		{
			[Token(Token = "0x4000330")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GPUIPlatform platform;

			[Token(Token = "0x4000331")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public GPUIMatrixHandlingType matrixHandlingType;

			[Token(Token = "0x4000332")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GPUIComputeThreadCount computeThreadCount;

			[Token(Token = "0x6000191")]
			[Address(RVA = "0x73DEC90", Offset = "0x73DAC90", VA = "0x73DEC90")]
			public GPUIRenderingSettings()
			{
			}
		}

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float versionNo;

		[NonSerialized]
		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GPUInstancerShaderBindings shaderBindings;

		[NonSerialized]
		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GPUInstancerBillboardAtlasBindings billboardAtlasBindings;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool packagesLoaded;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool isHDRP;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool isLWRP;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
		public bool isURP;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool isShaderGraphPresent;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int instancingBoundsSize;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool loadFromAddressables;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material _foliageHDRPTemplate;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float MAX_DETAIL_DISTANCE;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float MAX_TREE_DISTANCE;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float MAX_PREFAB_DISTANCE;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int MAX_PREFAB_EXTRA_BUFFER_SIZE;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool useCustomPreviewBackgroundColor;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Color previewBackgroundColor;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool disableAutoGenerateBillboards;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		public bool disableShaderVariantCollection;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E")]
		public bool disableInstanceCountWarning;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6F")]
		public bool disableAutoShaderConversion;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool disableAutoVariantHandling;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		public bool useOriginalMaterialWhenInstanced;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
		public bool testBothEyesForVROcclusion;

		[NonSerialized]
		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x73")]
		public bool isVREnabled;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<GPUInstancerSettingsExtension> extensionSettings;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<GPUIRenderingSettings> renderingSettingPresets;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool hasCustomRenderingSettings;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public GPUIRenderingSettings customRenderingSettings;

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x73DE45C", Offset = "0x73DA45C", VA = "0x73DE45C")]
		public Material GetFoliageHDRPTemplate()
		{
			return null;
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x73DE608", Offset = "0x73DA608", VA = "0x73DE608")]
		public void AddExtension(GPUInstancerSettingsExtension extension)
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x73D8F00", Offset = "0x73D4F00", VA = "0x73D8F00")]
		public static GPUInstancerSettings GetDefaultGPUInstancerSettings()
		{
			return null;
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x73DE834", Offset = "0x73DA834", VA = "0x73DE834", Slot = "4")]
		public virtual void SetDefultBindings()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x73DEC98", Offset = "0x73DAC98", VA = "0x73DEC98", Slot = "5")]
		public virtual void SetDefaultGPUInstancerShaderBindings()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x73DED14", Offset = "0x73DAD14", VA = "0x73DED14")]
		private static GPUInstancerShaderBindings GetDefaultGPUInstancerShaderBindings(bool createNewIfNull = true)
		{
			return null;
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x73DEE14", Offset = "0x73DAE14", VA = "0x73DEE14", Slot = "6")]
		public virtual void SetDefaultGPUInstancerBillboardAtlasBindings()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x73DEE90", Offset = "0x73DAE90", VA = "0x73DEE90")]
		private static GPUInstancerBillboardAtlasBindings GetDefaultGPUInstancerBillboardAtlasBindings(bool createNewIfNull = true)
		{
			return null;
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x73DEF88", Offset = "0x73DAF88", VA = "0x73DEF88", Slot = "7")]
		public virtual void SetDefaultShaderVariantCollection()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x73DEF8C", Offset = "0x73DAF8C", VA = "0x73DEF8C", Slot = "8")]
		public virtual void SetDefaultShaderVariants()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x73DF064", Offset = "0x73DB064", VA = "0x73DF064", Slot = "9")]
		public virtual void AddShaderVariantToCollection(string shaderName, [Optional] string extensionCode)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x73DF068", Offset = "0x73DB068", VA = "0x73DF068", Slot = "10")]
		public virtual void AddShaderVariantToCollection(Material material, [Optional] string extensionCode)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x73DF06C", Offset = "0x73DB06C", VA = "0x73DF06C")]
		public GPUIMatrixHandlingType GetMatrixHandlingType(GPUIPlatform platform)
		{
			return default;
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x73DF140", Offset = "0x73DB140", VA = "0x73DF140")]
		public GPUIComputeThreadCount GetComputeThreadCount(GPUIPlatform platform)
		{
			return default;
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x73DF03C", Offset = "0x73DB03C", VA = "0x73DF03C")]
		public bool IsStandardRenderPipeline()
		{
			return default;
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x73DD5F4", Offset = "0x73D95F4", VA = "0x73DD5F4")]
		public bool IsLODCrossFadeSupported()
		{
			return default;
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x73DF220", Offset = "0x73DB220", VA = "0x73DF220")]
		public bool GetDefaultCrossFadeValue()
		{
			return default;
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x73D8EC8", Offset = "0x73D4EC8", VA = "0x73D8EC8")]
		public bool IsUseBothEyesVRCulling()
		{
			return default;
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x73DF240", Offset = "0x73DB240", VA = "0x73DF240")]
		public bool IsBillboardsSupported()
		{
			return default;
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x73DF4C8", Offset = "0x73DB4C8", VA = "0x73DF4C8")]
		public GPUInstancerSettings()
		{
		}
	}
}
