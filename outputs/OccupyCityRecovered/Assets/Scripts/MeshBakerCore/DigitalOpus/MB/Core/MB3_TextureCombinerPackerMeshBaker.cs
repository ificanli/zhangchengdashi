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
	[Token(Token = "0x20000FE")]
	internal class MB3_TextureCombinerPackerMeshBaker : MB3_TextureCombinerPackerRoot
	{
		[Token(Token = "0x20000FF")]
		[CompilerGenerated]
		private sealed class _003CCopyScaledAndTiledToAtlas_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40003AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40003AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MeshBakerMaterialTexture source;

			[Token(Token = "0x40003B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MB2_LogLevel LOG_LEVEL;

			[Token(Token = "0x40003B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int targX;

			[Token(Token = "0x40003B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int targY;

			[Token(Token = "0x40003B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int targW;

			[Token(Token = "0x40003B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int targH;

			[Token(Token = "0x40003B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public AtlasPadding padding;

			[Token(Token = "0x40003B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public DRect srcSamplingRect;

			[Token(Token = "0x40003B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public MB3_TextureCombinerPipeline.TexturePipelineData data;

			[Token(Token = "0x40003B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public MB3_TextureCombiner combiner;

			[Token(Token = "0x40003B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public ShaderTextureProperty shaderPropertyName;

			[Token(Token = "0x40003BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public MB_TexSet sourceMaterial;

			[Token(Token = "0x40003BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public ProgressUpdateDelegate progressInfo;

			[Token(Token = "0x40003BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Color[][] atlasPixels;

			[Token(Token = "0x40003BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private int _003Cw_003E5__2;

			[Token(Token = "0x40003BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private int _003Ch_003E5__3;

			[Token(Token = "0x40003BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private int _003Ci_003E5__4;

			[Token(Token = "0x40003C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private int _003Cj_003E5__5;

			[Token(Token = "0x170000BF")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600057F")]
				[Address(RVA = "0x749C824", Offset = "0x7498824", VA = "0x749C824", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170000C0")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000581")]
				[Address(RVA = "0x749C864", Offset = "0x7498864", VA = "0x749C864", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600057C")]
			[Address(RVA = "0x749BE14", Offset = "0x7497E14", VA = "0x749BE14")]
			[DebuggerHidden]
			public _003CCopyScaledAndTiledToAtlas_003Ed__2(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600057D")]
			[Address(RVA = "0x749BE44", Offset = "0x7497E44", VA = "0x749BE44", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600057E")]
			[Address(RVA = "0x749BE48", Offset = "0x7497E48", VA = "0x749BE48", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600057F")]
			[Address(RVA = "0x749C824", Offset = "0x7498824", VA = "0x749C824", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000580")]
			[Address(RVA = "0x749C82C", Offset = "0x749882C", VA = "0x749C82C", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000581")]
			[Address(RVA = "0x749C864", Offset = "0x7498864", VA = "0x749C864", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2000100")]
		[CompilerGenerated]
		private sealed class _003CCreateAtlases_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40003C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40003C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AtlasPackingResult packedAtlasRects;

			[Token(Token = "0x40003C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MB2_LogLevel LOG_LEVEL;

			[Token(Token = "0x40003C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public MB3_TextureCombinerPipeline.TexturePipelineData data;

			[Token(Token = "0x40003C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public MB3_TextureCombiner combiner;

			[Token(Token = "0x40003C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public ProgressUpdateDelegate progressInfo;

			[Token(Token = "0x40003C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public MB2_EditorMethodsInterface textureEditorMethods;

			[Token(Token = "0x40003C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Texture2D[] atlases;

			[Token(Token = "0x40003CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Rect[] _003CuvRects_003E5__2;

			[Token(Token = "0x40003CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private int _003CatlasSizeX_003E5__3;

			[Token(Token = "0x40003CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private int _003CatlasSizeY_003E5__4;

			[Token(Token = "0x40003CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private int _003CpropIdx_003E5__5;

			[Token(Token = "0x40003CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private ShaderTextureProperty _003Cproperty_003E5__6;

			[Token(Token = "0x40003CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private Color[][] _003CatlasPixels_003E5__7;

			[Token(Token = "0x40003D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private bool _003CisNormalMap_003E5__8;

			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private int _003CtexSetIdx_003E5__9;

			[Token(Token = "0x170000C1")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000585")]
				[Address(RVA = "0x749D880", Offset = "0x7499880", VA = "0x749D880", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170000C2")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000587")]
				[Address(RVA = "0x749D8C0", Offset = "0x74998C0", VA = "0x749D8C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000582")]
			[Address(RVA = "0x749BCE8", Offset = "0x7497CE8", VA = "0x749BCE8")]
			[DebuggerHidden]
			public _003CCreateAtlases_003Ed__1(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000583")]
			[Address(RVA = "0x749C86C", Offset = "0x749886C", VA = "0x749C86C", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000584")]
			[Address(RVA = "0x749C870", Offset = "0x7498870", VA = "0x749C870", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000585")]
			[Address(RVA = "0x749D880", Offset = "0x7499880", VA = "0x749D880", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000586")]
			[Address(RVA = "0x749D888", Offset = "0x7499888", VA = "0x749D888", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000587")]
			[Address(RVA = "0x749D8C0", Offset = "0x74998C0", VA = "0x749D8C0", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x749BC40", Offset = "0x7497C40", VA = "0x749BC40", Slot = "8")]
		public override bool Validate(MB3_TextureCombinerPipeline.TexturePipelineData data)
		{
			return default;
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x749BC48", Offset = "0x7497C48", VA = "0x749BC48", Slot = "11")]
		[IteratorStateMachine(typeof(_003CCreateAtlases_003Ed__1))]
		public override IEnumerator CreateAtlases(ProgressUpdateDelegate progressInfo, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, AtlasPackingResult packedAtlasRects, Texture2D[] atlases, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x749BD10", Offset = "0x7497D10", VA = "0x749BD10")]
		[IteratorStateMachine(typeof(_003CCopyScaledAndTiledToAtlas_003Ed__2))]
		internal static IEnumerator CopyScaledAndTiledToAtlas(MeshBakerMaterialTexture source, MB_TexSet sourceMaterial, ShaderTextureProperty shaderPropertyName, DRect srcSamplingRect, int targX, int targY, int targW, int targH, AtlasPadding padding, Color[][] atlasPixels, bool isNormalMap, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, [Optional] ProgressUpdateDelegate progressInfo, MB2_LogLevel LOG_LEVEL = MB2_LogLevel.info)
		{
			return null;
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x749BE3C", Offset = "0x7497E3C", VA = "0x749BE3C")]
		public MB3_TextureCombinerPackerMeshBaker()
		{
		}
	}
}
