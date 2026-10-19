using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x2000112")]
	internal class MB3_TextureCombinerPackerUnity : MB3_TextureCombinerPackerRoot
	{
		[Token(Token = "0x2000113")]
		[CompilerGenerated]
		private sealed class _003CCreateAtlases_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000401")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000402")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000403")]
			[FieldOffset(Offset = "0x20")]
			public MB3_TextureCombinerPipeline.TexturePipelineData data;

			[Token(Token = "0x4000404")]
			[FieldOffset(Offset = "0x28")]
			public MB2_LogLevel LOG_LEVEL;

			[Token(Token = "0x4000405")]
			[FieldOffset(Offset = "0x30")]
			public MB3_TextureCombiner combiner;

			[Token(Token = "0x4000406")]
			[FieldOffset(Offset = "0x38")]
			public ProgressUpdateDelegate progressInfo;

			[Token(Token = "0x4000407")]
			[FieldOffset(Offset = "0x40")]
			public MB2_EditorMethodsInterface textureEditorMethods;

			[Token(Token = "0x4000408")]
			[FieldOffset(Offset = "0x48")]
			public Texture2D[] atlases;

			[Token(Token = "0x4000409")]
			[FieldOffset(Offset = "0x50")]
			public AtlasPackingResult packedAtlasRects;

			[Token(Token = "0x170000CF")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005E8")]
				[Address(RVA = "0x74A5860", Offset = "0x74A1860", VA = "0x74A5860", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170000D0")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005EA")]
				[Address(RVA = "0x74A58A0", Offset = "0x74A18A0", VA = "0x74A58A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x74A40EC", Offset = "0x74A00EC", VA = "0x74A40EC")]
			[DebuggerHidden]
			public _003CCreateAtlases_003Ed__2(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x74A4A40", Offset = "0x74A0A40", VA = "0x74A4A40", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x74A4A44", Offset = "0x74A0A44", VA = "0x74A4A44", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x74A5860", Offset = "0x74A1860", VA = "0x74A5860", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x74A5868", Offset = "0x74A1868", VA = "0x74A5868", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x74A58A0", Offset = "0x74A18A0", VA = "0x74A58A0", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x74A3F58", Offset = "0x749FF58", VA = "0x74A3F58", Slot = "8")]
		public override bool Validate(MB3_TextureCombinerPipeline.TexturePipelineData data)
		{
			return default;
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x74A3F60", Offset = "0x749FF60", VA = "0x74A3F60", Slot = "10")]
		public override AtlasPackingResult[] CalculateAtlasRectangles(MB3_TextureCombinerPipeline.TexturePipelineData data, bool doMultiAtlas, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x74A404C", Offset = "0x74A004C", VA = "0x74A404C", Slot = "11")]
		[IteratorStateMachine(typeof(_003CCreateAtlases_003Ed__2))]
		public override IEnumerator CreateAtlases(ProgressUpdateDelegate progressInfo, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, AtlasPackingResult packedAtlasRects, Texture2D[] atlases, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x74A4114", Offset = "0x74A0114", VA = "0x74A4114")]
		internal static Texture2D _copyTexturesIntoAtlas(ShaderTextureProperty prop, Texture2D[] texToPack, int padding, Rect[] rs, int w, int h, MB3_TextureCombiner combiner)
		{
			return null;
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x74A45F4", Offset = "0x74A05F4", VA = "0x74A45F4")]
		internal static Texture2D GetAdjustedForScaleAndOffset2(ShaderTextureProperty propertyName, MeshBakerMaterialTexture source, Vector2 obUVoffset, Vector2 obUVscale, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x74A4A38", Offset = "0x74A0A38", VA = "0x74A4A38")]
		public MB3_TextureCombinerPackerUnity()
		{
		}
	}
}
