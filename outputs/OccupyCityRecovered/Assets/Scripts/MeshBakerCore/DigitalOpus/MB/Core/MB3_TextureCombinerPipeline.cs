using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x2000114")]
	public class MB3_TextureCombinerPipeline
	{
		[Token(Token = "0x2000115")]
		public struct CreateAtlasForProperty
		{
			[Token(Token = "0x400040C")]
			[FieldOffset(Offset = "0x0")]
			public bool allTexturesAreNull;

			[Token(Token = "0x400040D")]
			[FieldOffset(Offset = "0x1")]
			public bool allTexturesAreSame;

			[Token(Token = "0x400040E")]
			[FieldOffset(Offset = "0x2")]
			public bool allNonTexturePropsAreSame;

			[Token(Token = "0x400040F")]
			[FieldOffset(Offset = "0x3")]
			public bool allSrcMatsOmittedTextureProperty;

			[Token(Token = "0x6000601")]
			[Address(RVA = "0x74A91E4", Offset = "0x74A51E4", VA = "0x74A91E4", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x2000116")]
		internal class TexturePipelineData
		{
			[Token(Token = "0x4000410")]
			[FieldOffset(Offset = "0x10")]
			internal MB2_TextureBakeResults _textureBakeResults;

			[Token(Token = "0x4000411")]
			[FieldOffset(Offset = "0x18")]
			internal int _atlasPadding_pix;

			[Token(Token = "0x4000412")]
			[FieldOffset(Offset = "0x1C")]
			internal int _maxAtlasWidth;

			[Token(Token = "0x4000413")]
			[FieldOffset(Offset = "0x20")]
			internal int _maxAtlasHeight;

			[Token(Token = "0x4000414")]
			[FieldOffset(Offset = "0x24")]
			internal bool _useMaxAtlasHeightOverride;

			[Token(Token = "0x4000415")]
			[FieldOffset(Offset = "0x25")]
			internal bool _useMaxAtlasWidthOverride;

			[Token(Token = "0x4000416")]
			[FieldOffset(Offset = "0x26")]
			internal bool _resizePowerOfTwoTextures;

			[Token(Token = "0x4000417")]
			[FieldOffset(Offset = "0x27")]
			internal bool _fixOutOfBoundsUVs;

			[Token(Token = "0x4000418")]
			[FieldOffset(Offset = "0x28")]
			internal int _maxTilingBakeSize;

			[Token(Token = "0x4000419")]
			[FieldOffset(Offset = "0x2C")]
			internal bool _saveAtlasesAsAssets;

			[Token(Token = "0x400041A")]
			[FieldOffset(Offset = "0x30")]
			internal MB2_PackingAlgorithmEnum _packingAlgorithm;

			[Token(Token = "0x400041B")]
			[FieldOffset(Offset = "0x34")]
			internal int _layerTexturePackerFastV2;

			[Token(Token = "0x400041C")]
			[FieldOffset(Offset = "0x38")]
			internal bool _meshBakerTexturePackerForcePowerOfTwo;

			[Token(Token = "0x400041D")]
			[FieldOffset(Offset = "0x40")]
			internal List<ShaderTextureProperty> _customShaderPropNames;

			[Token(Token = "0x400041E")]
			[FieldOffset(Offset = "0x48")]
			internal bool _normalizeTexelDensity;

			[Token(Token = "0x400041F")]
			[FieldOffset(Offset = "0x49")]
			internal bool _considerNonTextureProperties;

			[Token(Token = "0x4000420")]
			[FieldOffset(Offset = "0x4A")]
			internal bool doMergeDistinctMaterialTexturesThatWouldExceedAtlasSize;

			[Token(Token = "0x4000421")]
			[FieldOffset(Offset = "0x4C")]
			internal ColorSpace colorSpace;

			[Token(Token = "0x4000422")]
			[FieldOffset(Offset = "0x50")]
			internal MB3_TextureCombinerNonTextureProperties nonTexturePropertyBlender;

			[Token(Token = "0x4000423")]
			[FieldOffset(Offset = "0x58")]
			internal List<MB_TexSet> distinctMaterialTextures;

			[Token(Token = "0x4000424")]
			[FieldOffset(Offset = "0x60")]
			internal List<GameObject> allObjsToMesh;

			[Token(Token = "0x4000425")]
			[FieldOffset(Offset = "0x68")]
			internal List<Material> allowedMaterialsFilter;

			[Token(Token = "0x4000426")]
			[FieldOffset(Offset = "0x70")]
			internal List<ShaderTextureProperty> texPropertyNames;

			[Token(Token = "0x4000427")]
			[FieldOffset(Offset = "0x78")]
			internal List<string> texPropNamesToIgnore;

			[Token(Token = "0x4000428")]
			[FieldOffset(Offset = "0x80")]
			internal CreateAtlasForProperty[] allTexturesAreNullAndSameColor;

			[Token(Token = "0x4000429")]
			[FieldOffset(Offset = "0x88")]
			internal MB2_TextureBakeResults.ResultType resultType;

			[Token(Token = "0x400042A")]
			[FieldOffset(Offset = "0x90")]
			internal Material resultMaterial;

			[Token(Token = "0x170000D1")]
			internal int numAtlases
			{
				[Token(Token = "0x6000602")]
				[Address(RVA = "0x74A7C1C", Offset = "0x74A3C1C", VA = "0x74A7C1C")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000603")]
			[Address(RVA = "0x74A9390", Offset = "0x74A5390", VA = "0x74A9390")]
			internal bool OnlyOneTextureInAtlasReuseTextures()
			{
				return default;
			}

			[Token(Token = "0x6000604")]
			[Address(RVA = "0x74A9428", Offset = "0x74A5428", VA = "0x74A9428")]
			public TexturePipelineData()
			{
			}
		}

		[Token(Token = "0x200011A")]
		[CompilerGenerated]
		private sealed class _003CCalculateIdealSizesForTexturesInAtlasAndPadding_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000431")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000432")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000433")]
			[FieldOffset(Offset = "0x20")]
			public TexturePipelineData data;

			[Token(Token = "0x4000434")]
			[FieldOffset(Offset = "0x28")]
			public MB2_LogLevel LOG_LEVEL;

			[Token(Token = "0x170000D2")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600060D")]
				[Address(RVA = "0x74AACC4", Offset = "0x74A6CC4", VA = "0x74AACC4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170000D3")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600060F")]
				[Address(RVA = "0x74AAD04", Offset = "0x74A6D04", VA = "0x74AAD04", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600060A")]
			[Address(RVA = "0x74A64F4", Offset = "0x74A24F4", VA = "0x74A64F4")]
			[DebuggerHidden]
			public _003CCalculateIdealSizesForTexturesInAtlasAndPadding_003Ed__11(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600060B")]
			[Address(RVA = "0x74A958C", Offset = "0x74A558C", VA = "0x74A958C", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600060C")]
			[Address(RVA = "0x74A9590", Offset = "0x74A5590", VA = "0x74A9590", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600060D")]
			[Address(RVA = "0x74AACC4", Offset = "0x74A6CC4", VA = "0x74AACC4", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600060E")]
			[Address(RVA = "0x74AACCC", Offset = "0x74A6CCC", VA = "0x74AACCC", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600060F")]
			[Address(RVA = "0x74AAD04", Offset = "0x74A6D04", VA = "0x74AAD04", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x200011B")]
		[CompilerGenerated]
		private sealed class _003C__Step1_CollectDistinctMatTexturesAndUsedObjects_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000435")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000436")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000437")]
			[FieldOffset(Offset = "0x20")]
			public TexturePipelineData data;

			[Token(Token = "0x4000438")]
			[FieldOffset(Offset = "0x28")]
			public ProgressUpdateDelegate progressInfo;

			[Token(Token = "0x4000439")]
			[FieldOffset(Offset = "0x30")]
			public MB2_LogLevel LOG_LEVEL;

			[Token(Token = "0x400043A")]
			[FieldOffset(Offset = "0x38")]
			public MB3_TextureCombiner.CombineTexturesIntoAtlasesCoroutineResult result;

			[Token(Token = "0x400043B")]
			[FieldOffset(Offset = "0x40")]
			public MB2_EditorMethodsInterface textureEditorMethods;

			[Token(Token = "0x400043C")]
			[FieldOffset(Offset = "0x48")]
			public List<GameObject> usedObjsToMesh;

			[Token(Token = "0x170000D4")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000613")]
				[Address(RVA = "0x74AC958", Offset = "0x74A8958", VA = "0x74AC958", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170000D5")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000615")]
				[Address(RVA = "0x74AC998", Offset = "0x74A8998", VA = "0x74AC998", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000610")]
			[Address(RVA = "0x74A5EAC", Offset = "0x74A1EAC", VA = "0x74A5EAC")]
			[DebuggerHidden]
			public _003C__Step1_CollectDistinctMatTexturesAndUsedObjects_003Ed__9(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000611")]
			[Address(RVA = "0x74AAD0C", Offset = "0x74A6D0C", VA = "0x74AAD0C", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000612")]
			[Address(RVA = "0x74AAD10", Offset = "0x74A6D10", VA = "0x74AAD10", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000613")]
			[Address(RVA = "0x74AC958", Offset = "0x74A8958", VA = "0x74AC958", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000614")]
			[Address(RVA = "0x74AC960", Offset = "0x74A8960", VA = "0x74AC960", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000615")]
			[Address(RVA = "0x74AC998", Offset = "0x74A8998", VA = "0x74AC998", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x200011C")]
		[CompilerGenerated]
		private sealed class _003C__Step3_BuildAndSaveAtlasesAndStoreResults_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400043D")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400043E")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400043F")]
			[FieldOffset(Offset = "0x20")]
			public TexturePipelineData data;

			[Token(Token = "0x4000440")]
			[FieldOffset(Offset = "0x28")]
			public MB2_LogLevel LOG_LEVEL;

			[Token(Token = "0x4000441")]
			[FieldOffset(Offset = "0x30")]
			public MB_ITextureCombinerPacker packer;

			[Token(Token = "0x4000442")]
			[FieldOffset(Offset = "0x38")]
			public ProgressUpdateDelegate progressInfo;

			[Token(Token = "0x4000443")]
			[FieldOffset(Offset = "0x40")]
			public MB3_TextureCombiner combiner;

			[Token(Token = "0x4000444")]
			[FieldOffset(Offset = "0x48")]
			public AtlasPackingResult atlasPackingResult;

			[Token(Token = "0x4000445")]
			[FieldOffset(Offset = "0x50")]
			public MB2_EditorMethodsInterface textureEditorMethods;

			[Token(Token = "0x4000446")]
			[FieldOffset(Offset = "0x58")]
			public StringBuilder report;

			[Token(Token = "0x4000447")]
			[FieldOffset(Offset = "0x60")]
			public MB3_TextureCombinerPipeline _003C_003E4__this;

			[Token(Token = "0x4000448")]
			[FieldOffset(Offset = "0x68")]
			public MB_AtlasesAndRects resultAtlasesAndRects;

			[Token(Token = "0x4000449")]
			[FieldOffset(Offset = "0x70")]
			private Stopwatch _003Csw_003E5__2;

			[Token(Token = "0x400044A")]
			[FieldOffset(Offset = "0x78")]
			private Texture2D[] _003Catlases_003E5__3;

			[Token(Token = "0x170000D6")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000619")]
				[Address(RVA = "0x74AD404", Offset = "0x74A9404", VA = "0x74AD404", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170000D7")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600061B")]
				[Address(RVA = "0x74AD444", Offset = "0x74A9444", VA = "0x74AD444", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000616")]
			[Address(RVA = "0x74A710C", Offset = "0x74A310C", VA = "0x74A710C")]
			[DebuggerHidden]
			public _003C__Step3_BuildAndSaveAtlasesAndStoreResults_003Ed__14(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000617")]
			[Address(RVA = "0x74AC9A0", Offset = "0x74A89A0", VA = "0x74AC9A0", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000618")]
			[Address(RVA = "0x74AC9A4", Offset = "0x74A89A4", VA = "0x74AC9A4", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000619")]
			[Address(RVA = "0x74AD404", Offset = "0x74A9404", VA = "0x74AD404", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600061A")]
			[Address(RVA = "0x74AD40C", Offset = "0x74A940C", VA = "0x74AD40C", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600061B")]
			[Address(RVA = "0x74AD444", Offset = "0x74A9444", VA = "0x74AD444", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400040A")]
		[FieldOffset(Offset = "0x0")]
		public static bool USE_EXPERIMENTAL_HOIZONTALVERTICAL;

		[Token(Token = "0x400040B")]
		[FieldOffset(Offset = "0x8")]
		public static ShaderTextureProperty[] shaderTexPropertyNames;

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x74A58A8", Offset = "0x74A18A8", VA = "0x74A58A8")]
		internal static bool _ShouldWeCreateAtlasForThisProperty(int propertyIndex, bool considerNonTextureProperties, CreateAtlasForProperty[] allTexturesAreNullAndSameColor)
		{
			return default;
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x74A58F4", Offset = "0x74A18F4", VA = "0x74A58F4")]
		internal static bool _DoAnySrcMatsHaveProperty(int propertyIndex, CreateAtlasForProperty[] allTexturesAreNullAndSameColor)
		{
			return default;
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x74A5928", Offset = "0x74A1928", VA = "0x74A5928")]
		internal static bool _CollectPropertyNames(TexturePipelineData data, MB2_LogLevel LOG_LEVEL)
		{
			return default;
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x74A59AC", Offset = "0x74A19AC", VA = "0x74A59AC")]
		internal static bool _CollectPropertyNames(List<ShaderTextureProperty> texPropertyNames, List<ShaderTextureProperty> _customShaderPropNames, List<string> texPropsToIgnore, Material resultMaterial, MB2_LogLevel LOG_LEVEL)
		{
			return default;
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x74A5CDC", Offset = "0x74A1CDC", VA = "0x74A5CDC")]
		public static Texture GetTextureConsideringStandardShaderKeywords(string shaderName, Material mat, string propertyName)
		{
			return null;
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x74A5E14", Offset = "0x74A1E14", VA = "0x74A5E14", Slot = "4")]
		[IteratorStateMachine(typeof(_003C__Step1_CollectDistinctMatTexturesAndUsedObjects_003Ed__9))]
		internal virtual IEnumerator __Step1_CollectDistinctMatTexturesAndUsedObjects(ProgressUpdateDelegate progressInfo, MB3_TextureCombiner.CombineTexturesIntoAtlasesCoroutineResult result, TexturePipelineData data, MB3_TextureCombiner combiner, MB2_EditorMethodsInterface textureEditorMethods, List<GameObject> usedObjsToMesh, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x74A5ED4", Offset = "0x74A1ED4", VA = "0x74A5ED4")]
		private static CreateAtlasForProperty[] CalculateAllTexturesAreNullAndSameColor(TexturePipelineData data, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x74A6484", Offset = "0x74A2484", VA = "0x74A6484", Slot = "5")]
		[IteratorStateMachine(typeof(_003CCalculateIdealSizesForTexturesInAtlasAndPadding_003Ed__11))]
		internal virtual IEnumerator CalculateIdealSizesForTexturesInAtlasAndPadding(ProgressUpdateDelegate progressInfo, MB3_TextureCombiner.CombineTexturesIntoAtlasesCoroutineResult result, TexturePipelineData data, MB3_TextureCombiner combiner, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x74A651C", Offset = "0x74A251C", VA = "0x74A651C", Slot = "6")]
		internal virtual AtlasPackingResult[] RunTexturePackerOnly(TexturePipelineData data, bool doSplitIntoMultiAtlasIfTooBig, MB_AtlasesAndRects resultAtlasesAndRects, MB_ITextureCombinerPacker texturePacker, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x74A6DBC", Offset = "0x74A2DBC", VA = "0x74A6DBC", Slot = "7")]
		internal virtual MB_ITextureCombinerPacker CreatePacker(bool onlyOneTextureInAtlasReuseTextures, MB2_PackingAlgorithmEnum packingAlgorithm)
		{
			return null;
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x74A7050", Offset = "0x74A3050", VA = "0x74A7050", Slot = "8")]
		[IteratorStateMachine(typeof(_003C__Step3_BuildAndSaveAtlasesAndStoreResults_003Ed__14))]
		internal virtual IEnumerator __Step3_BuildAndSaveAtlasesAndStoreResults(MB3_TextureCombiner.CombineTexturesIntoAtlasesCoroutineResult result, ProgressUpdateDelegate progressInfo, TexturePipelineData data, MB3_TextureCombiner combiner, MB_ITextureCombinerPacker packer, AtlasPackingResult atlasPackingResult, MB2_EditorMethodsInterface textureEditorMethods, MB_AtlasesAndRects resultAtlasesAndRects, StringBuilder report, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x74A6660", Offset = "0x74A2660", VA = "0x74A6660")]
		private void FillAtlasPackingResultAuxillaryData(TexturePipelineData data, AtlasPackingResult[] atlasPackingResults)
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x74A6A34", Offset = "0x74A2A34", VA = "0x74A6A34")]
		private void FillResultAtlasesAndRects(TexturePipelineData data, AtlasPackingResult atlasPackingResult, MB_AtlasesAndRects resultAtlasesAndRects, Texture2D[] atlases)
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x74A7134", Offset = "0x74A3134", VA = "0x74A7134", Slot = "9")]
		internal virtual StringBuilder GenerateReport(TexturePipelineData data)
		{
			return null;
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x74A7C68", Offset = "0x74A3C68", VA = "0x74A7C68")]
		internal static MB2_TexturePacker CreateTexturePacker(MB2_PackingAlgorithmEnum _packingAlgorithm)
		{
			return null;
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x74A7D94", Offset = "0x74A3D94", VA = "0x74A7D94")]
		internal static Vector2 GetAdjustedForScaleAndOffset2Dimensions(MeshBakerMaterialTexture source, Vector2 obUVoffset, Vector2 obUVscale, TexturePipelineData data, MB2_LogLevel LOG_LEVEL)
		{
			return default;
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x74A8048", Offset = "0x74A4048", VA = "0x74A8048")]
		internal static Color32 ConvertNormalFormatFromUnity_ToStandard(Color32 c)
		{
			return default;
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x74A810C", Offset = "0x74A410C", VA = "0x74A810C")]
		internal static void GetMaterialScaleAndOffset(Material mat, string propertyName, out Vector2 offset, out Vector2 scale)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MB3_TextureCombinerPipeline.GetMaterialScaleAndOffset RVA=0x74A810C Token=0x60005FC");
}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x74A8260", Offset = "0x74A4260", VA = "0x74A8260")]
		internal static float GetSubmeshArea(Mesh m, int submeshIdx)
		{
			return default;
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x74A8458", Offset = "0x74A4458", VA = "0x74A8458")]
		internal static bool IsPowerOfTwo(int x)
		{
			return default;
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x74A8468", Offset = "0x74A4468", VA = "0x74A8468")]
		public MB3_TextureCombinerPipeline()
		{
		}
	}
}
