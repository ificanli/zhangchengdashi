using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x200011D")]
	public class MB_TextureArrays
	{
		[Token(Token = "0x200011E")]
		internal class TexturePropertyData
		{
			[Token(Token = "0x400044B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool[] doMips;

			[Token(Token = "0x400044C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int[] numMipMaps;

			[Token(Token = "0x400044D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TextureFormat[] formats;

			[Token(Token = "0x400044E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MB_TextureCompressionQuality[] compressionQualities;

			[Token(Token = "0x400044F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2[] sizes;

			[Token(Token = "0x6000623")]
			[Address(RVA = "0x74AEF98", Offset = "0x74AAF98", VA = "0x74AEF98")]
			public TexturePropertyData()
			{
			}
		}

		[Token(Token = "0x200011F")]
		[CompilerGenerated]
		private sealed class _003C_CreateAtlasesCoroutineSingleResultMaterial_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000450")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000451")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000452")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MB3_TextureCombiner combiner;

			[Token(Token = "0x4000453")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int resMatIdx;

			[Token(Token = "0x4000454")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public MB_MultiMaterialTexArray resMatConfig;

			[Token(Token = "0x4000455")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public MB_TextureArrayResultMaterial bakedMatsAndSlicesResMat;

			[Token(Token = "0x4000456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public ProgressUpdateDelegate progressInfo;

			[Token(Token = "0x4000457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public List<GameObject> objsToMesh;

			[Token(Token = "0x4000458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public List<string> texPropNamesToIgnore;

			[Token(Token = "0x4000459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public MB2_EditorMethodsInterface editorMethods;

			[Token(Token = "0x400045A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public float maxTimePerFrame;

			[Token(Token = "0x400045B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public MB3_TextureCombiner.CreateAtlasesCoroutineResult coroutineResult;

			[Token(Token = "0x400045C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public bool saveAtlasesAsAssets;

			[Token(Token = "0x400045D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public List<ShaderTextureProperty> customShaderProperties;

			[Token(Token = "0x400045E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public MB_TextureArrayFormatSet[] textureArrayOutputFormats;

			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private MB2_LogLevel _003CLOG_LEVEL_003E5__2;

			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private List<MB3_TextureCombiner.TemporaryTexture> _003CgeneratedTemporaryAtlases_003E5__3;

			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private List<MB_TexArraySlice> _003CslicesConfig_003E5__4;

			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private int _003CsliceIdx_003E5__5;

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private List<MB_TexArraySliceRendererMatPair> _003CsrcMatAndObjPairs_003E5__6;

			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private MB3_TextureCombiner.CombineTexturesIntoAtlasesCoroutineResult _003CcoroutineResult2_003E5__7;

			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private MB_AtlasesAndRects _003CsliceAtlasesAndRectOutput_003E5__8;

			[Token(Token = "0x170000D8")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000627")]
				[Address(RVA = "0x74B0AFC", Offset = "0x74ACAFC", VA = "0x74B0AFC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170000D9")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000629")]
				[Address(RVA = "0x74B0B3C", Offset = "0x74ACB3C", VA = "0x74B0B3C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000624")]
			[Address(RVA = "0x74AEF68", Offset = "0x74AAF68", VA = "0x74AEF68")]
			[DebuggerHidden]
			public _003C_CreateAtlasesCoroutineSingleResultMaterial_003Ed__6(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000625")]
			[Address(RVA = "0x74AEFA0", Offset = "0x74AAFA0", VA = "0x74AEFA0", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000626")]
			[Address(RVA = "0x74AEFA4", Offset = "0x74AAFA4", VA = "0x74AEFA4", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000627")]
			[Address(RVA = "0x74B0AFC", Offset = "0x74ACAFC", VA = "0x74B0AFC", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000628")]
			[Address(RVA = "0x74B0B04", Offset = "0x74ACB04", VA = "0x74B0B04", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000629")]
			[Address(RVA = "0x74B0B3C", Offset = "0x74ACB3C", VA = "0x74B0B3C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x74AD44C", Offset = "0x74A944C", VA = "0x74AD44C")]
		internal static bool[] DetermineWhichPropertiesHaveTextures(MB_AtlasesAndRects[] resultAtlasesAndRectSlices)
		{
			return null;
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x74AD5DC", Offset = "0x74A95DC", VA = "0x74AD5DC")]
		private static bool IsLinearProperty(List<ShaderTextureProperty> shaderPropertyNames, string shaderProperty)
		{
			return default;
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x74AD6B0", Offset = "0x74A96B0", VA = "0x74AD6B0")]
		internal static Texture2DArray[] CreateTextureArraysForResultMaterial(TexturePropertyData texPropertyData, List<ShaderTextureProperty> masterListOfTexProperties, MB_AtlasesAndRects[] resultAtlasesAndRectSlices, bool[] hasTexForProperty, MB3_TextureCombiner combiner, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x74ADF18", Offset = "0x74A9F18", VA = "0x74ADF18")]
		internal static bool ConvertTexturesToReadableFormat(TexturePropertyData texturePropertyData, MB_AtlasesAndRects[] resultAtlasesAndRectSlices, bool[] hasTexForProperty, List<ShaderTextureProperty> textureShaderProperties, MB3_TextureCombiner combiner, MB2_LogLevel logLevel, List<Texture2D> createdTemporaryTextureAssets, MB2_EditorMethodsInterface textureEditorMethods)
		{
			return default;
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x74AE9D0", Offset = "0x74AA9D0", VA = "0x74AE9D0")]
		internal static void FindBestSizeAndMipCountAndFormatForTextureArrays(List<ShaderTextureProperty> texPropertyNames, int maxAtlasSize, MB_TextureArrayFormatSet targetFormatSet, MB_AtlasesAndRects[] resultAtlasesAndRectSlices, TexturePropertyData texturePropertyData)
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x74AEE74", Offset = "0x74AAE74", VA = "0x74AEE74")]
		[IteratorStateMachine(typeof(_003C_CreateAtlasesCoroutineSingleResultMaterial_003Ed__6))]
		public static IEnumerator _CreateAtlasesCoroutineSingleResultMaterial(int resMatIdx, MB_TextureArrayResultMaterial bakedMatsAndSlicesResMat, MB_MultiMaterialTexArray resMatConfig, List<GameObject> objsToMesh, MB3_TextureCombiner combiner, MB_TextureArrayFormatSet[] textureArrayOutputFormats, MB_MultiMaterialTexArray[] resultMaterialsTexArray, List<ShaderTextureProperty> customShaderProperties, List<string> texPropNamesToIgnore, ProgressUpdateDelegate progressInfo, MB3_TextureCombiner.CreateAtlasesCoroutineResult coroutineResult, [Optional][DefaultParameterValue(false)] bool saveAtlasesAsAssets, [Optional] MB2_EditorMethodsInterface editorMethods, float maxTimePerFrame = 0.01f)
		{
			return null;
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x74AEF90", Offset = "0x74AAF90", VA = "0x74AEF90")]
		public MB_TextureArrays()
		{
		}
	}
}
