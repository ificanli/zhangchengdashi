using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x20000E0")]
	internal abstract class MB3_TextureCombinerPackerRoot : MB_ITextureCombinerPacker
	{
		[Token(Token = "0x20000E1")]
		[CompilerGenerated]
		private sealed class _003CConvertTexturesToReadableFormats_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400031B")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400031C")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400031D")]
			[FieldOffset(Offset = "0x20")]
			public MB3_TextureCombinerPipeline.TexturePipelineData data;

			[Token(Token = "0x400031E")]
			[FieldOffset(Offset = "0x28")]
			public MB2_EditorMethodsInterface textureEditorMethods;

			[Token(Token = "0x400031F")]
			[FieldOffset(Offset = "0x30")]
			public ProgressUpdateDelegate progressInfo;

			[Token(Token = "0x17000091")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000494")]
				[Address(RVA = "0x748F868", Offset = "0x748B868", VA = "0x748F868", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000092")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000496")]
				[Address(RVA = "0x748F8A8", Offset = "0x748B8A8", VA = "0x748F8A8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000491")]
			[Address(RVA = "0x748F5A0", Offset = "0x748B5A0", VA = "0x748F5A0")]
			[DebuggerHidden]
			public _003CConvertTexturesToReadableFormats_003Ed__6(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000492")]
			[Address(RVA = "0x748F5E0", Offset = "0x748B5E0", VA = "0x748F5E0", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000493")]
			[Address(RVA = "0x748F5E4", Offset = "0x748B5E4", VA = "0x748F5E4", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000494")]
			[Address(RVA = "0x748F868", Offset = "0x748B868", VA = "0x748F868", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000495")]
			[Address(RVA = "0x748F870", Offset = "0x748B870", VA = "0x748F870", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000496")]
			[Address(RVA = "0x748F8A8", Offset = "0x748B8A8", VA = "0x748F8A8", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x6000487")]
		public abstract bool Validate(MB3_TextureCombinerPipeline.TexturePipelineData data);

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x748EDC4", Offset = "0x748ADC4", VA = "0x748EDC4")]
		internal static void CreateTemporaryTexturesForAtlas(List<MB_TexSet> distinctMaterialTextures, MB3_TextureCombiner combiner, int propIdx, MB3_TextureCombinerPipeline.TexturePipelineData data)
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x748F030", Offset = "0x748B030", VA = "0x748F030")]
		internal static void SaveAtlasAndConfigureResultMaterial(MB3_TextureCombinerPipeline.TexturePipelineData data, MB2_EditorMethodsInterface textureEditorMethods, Texture2D atlas, ShaderTextureProperty property, int propIdx)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x748F228", Offset = "0x748B228", VA = "0x748F228")]
		internal static void SetPropertyOnMaterial(Material mat, string propertyName, Texture2D atlas)
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x748F23C", Offset = "0x748B23C", VA = "0x748F23C")]
		public static AtlasPackingResult[] CalculateAtlasRectanglesStatic(MB3_TextureCombinerPipeline.TexturePipelineData data, bool doMultiAtlas, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x748F528", Offset = "0x748B528", VA = "0x748F528")]
		public static void MakeProceduralTexturesReadable(ProgressUpdateDelegate progressInfo, MB3_TextureCombiner.CombineTexturesIntoAtlasesCoroutineResult result, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL)
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x748F52C", Offset = "0x748B52C", VA = "0x748F52C", Slot = "9")]
		[IteratorStateMachine(typeof(_003CConvertTexturesToReadableFormats_003Ed__6))]
		public virtual IEnumerator ConvertTexturesToReadableFormats(ProgressUpdateDelegate progressInfo, MB3_TextureCombiner.CombineTexturesIntoAtlasesCoroutineResult result, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x748F5C8", Offset = "0x748B5C8", VA = "0x748F5C8", Slot = "10")]
		public virtual AtlasPackingResult[] CalculateAtlasRectangles(MB3_TextureCombinerPipeline.TexturePipelineData data, bool doMultiAtlas, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x600048F")]
		public abstract IEnumerator CreateAtlases(ProgressUpdateDelegate progressInfo, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, AtlasPackingResult packedAtlasRects, Texture2D[] atlases, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL);

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x748F5D8", Offset = "0x748B5D8", VA = "0x748F5D8")]
		protected MB3_TextureCombinerPackerRoot()
		{
		}
	}
}
