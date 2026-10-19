using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x2000104")]
	internal class MB3_TextureCombinerPackerMeshBakerFastV2 : MB_ITextureCombinerPacker
	{
		[Token(Token = "0x2000105")]
		[CompilerGenerated]
		private sealed class _003CConvertTexturesToReadableFormats_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003E0")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40003E1")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x170000C7")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005A2")]
				[Address(RVA = "0x749EDE0", Offset = "0x749ADE0", VA = "0x749EDE0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170000C8")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005A4")]
				[Address(RVA = "0x749EE20", Offset = "0x749AE20", VA = "0x749EE20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600059F")]
			[Address(RVA = "0x749E9B4", Offset = "0x749A9B4", VA = "0x749E9B4")]
			[DebuggerHidden]
			public _003CConvertTexturesToReadableFormats_003Ed__4(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x749EDC4", Offset = "0x749ADC4", VA = "0x749EDC4", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x749EDC8", Offset = "0x749ADC8", VA = "0x749EDC8", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x749EDE0", Offset = "0x749ADE0", VA = "0x749EDE0", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60005A3")]
			[Address(RVA = "0x749EDE8", Offset = "0x749ADE8", VA = "0x749EDE8", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x749EE20", Offset = "0x749AE20", VA = "0x749EE20", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2000106")]
		[CompilerGenerated]
		private sealed class _003CCreateAtlases_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003E2")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40003E3")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40003E4")]
			[FieldOffset(Offset = "0x20")]
			public AtlasPackingResult packedAtlasRects;

			[Token(Token = "0x40003E5")]
			[FieldOffset(Offset = "0x28")]
			public MB2_LogLevel LOG_LEVEL;

			[Token(Token = "0x40003E6")]
			[FieldOffset(Offset = "0x30")]
			public MB3_TextureCombinerPipeline.TexturePipelineData data;

			[Token(Token = "0x40003E7")]
			[FieldOffset(Offset = "0x38")]
			public MB3_TextureCombinerPackerMeshBakerFastV2 _003C_003E4__this;

			[Token(Token = "0x40003E8")]
			[FieldOffset(Offset = "0x40")]
			public ProgressUpdateDelegate progressInfo;

			[Token(Token = "0x40003E9")]
			[FieldOffset(Offset = "0x48")]
			public MB3_TextureCombiner combiner;

			[Token(Token = "0x40003EA")]
			[FieldOffset(Offset = "0x50")]
			public MB2_EditorMethodsInterface textureEditorMethods;

			[Token(Token = "0x40003EB")]
			[FieldOffset(Offset = "0x58")]
			public Texture2D[] atlases;

			[Token(Token = "0x170000C9")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005A8")]
				[Address(RVA = "0x74A0FA4", Offset = "0x749CFA4", VA = "0x74A0FA4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170000CA")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005AA")]
				[Address(RVA = "0x74A0FE4", Offset = "0x749CFE4", VA = "0x74A0FE4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x749EAA0", Offset = "0x749AAA0", VA = "0x749EAA0")]
			[DebuggerHidden]
			public _003CCreateAtlases_003Ed__6(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x749EE28", Offset = "0x749AE28", VA = "0x749EE28", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x749EE2C", Offset = "0x749AE2C", VA = "0x749EE2C", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x74A0FA4", Offset = "0x749CFA4", VA = "0x74A0FA4", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x74A0FAC", Offset = "0x749CFAC", VA = "0x74A0FAC", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x74A0FE4", Offset = "0x749CFE4", VA = "0x74A0FE4", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x40003DD")]
		[FieldOffset(Offset = "0x10")]
		private Mesh mesh;

		[Token(Token = "0x40003DE")]
		[FieldOffset(Offset = "0x18")]
		private GameObject renderAtlasesGO;

		[Token(Token = "0x40003DF")]
		[FieldOffset(Offset = "0x20")]
		private GameObject cameraGameObject;

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x749E774", Offset = "0x749A774", VA = "0x749E774", Slot = "4")]
		public bool Validate(MB3_TextureCombinerPipeline.TexturePipelineData data)
		{
			return default;
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x749E95C", Offset = "0x749A95C", VA = "0x749E95C", Slot = "5")]
		[IteratorStateMachine(typeof(_003CConvertTexturesToReadableFormats_003Ed__4))]
		public IEnumerator ConvertTexturesToReadableFormats(ProgressUpdateDelegate progressInfo, MB3_TextureCombiner.CombineTexturesIntoAtlasesCoroutineResult result, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x749E9DC", Offset = "0x749A9DC", VA = "0x749E9DC", Slot = "8")]
		public virtual AtlasPackingResult[] CalculateAtlasRectangles(MB3_TextureCombinerPipeline.TexturePipelineData data, bool doMultiAtlas, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x749E9F4", Offset = "0x749A9F4", VA = "0x749E9F4", Slot = "7")]
		[IteratorStateMachine(typeof(_003CCreateAtlases_003Ed__6))]
		public IEnumerator CreateAtlases(ProgressUpdateDelegate progressInfo, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, AtlasPackingResult packedAtlasRects, Texture2D[] atlases, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x749EAC8", Offset = "0x749AAC8", VA = "0x749EAC8")]
		private void OneTimeSetup(MB3_AtlasPackerRenderTextureUsingMesh atlasRenderer, GameObject atlasMesh, GameObject cameraGameObject, int atlasWidth, int atlasHeight, int padding, int layer, MB2_LogLevel logLevel)
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x749EDBC", Offset = "0x749ADBC", VA = "0x749EDBC")]
		public MB3_TextureCombinerPackerMeshBakerFastV2()
		{
		}
	}
}
