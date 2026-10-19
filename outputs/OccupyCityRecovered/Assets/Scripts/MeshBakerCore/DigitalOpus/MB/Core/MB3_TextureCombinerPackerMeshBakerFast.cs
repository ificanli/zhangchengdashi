using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x2000101")]
	internal class MB3_TextureCombinerPackerMeshBakerFast : MB_ITextureCombinerPacker
	{
		[Token(Token = "0x2000102")]
		[CompilerGenerated]
		private sealed class _003CConvertTexturesToReadableFormats_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003D2")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40003D3")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x170000C3")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000590")]
				[Address(RVA = "0x749DA54", Offset = "0x7499A54", VA = "0x749DA54", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170000C4")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000592")]
				[Address(RVA = "0x749DA94", Offset = "0x7499A94", VA = "0x749DA94", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600058D")]
			[Address(RVA = "0x749D928", Offset = "0x7499928", VA = "0x749D928")]
			[DebuggerHidden]
			public _003CConvertTexturesToReadableFormats_003Ed__1(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600058E")]
			[Address(RVA = "0x749DA38", Offset = "0x7499A38", VA = "0x749DA38", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600058F")]
			[Address(RVA = "0x749DA3C", Offset = "0x7499A3C", VA = "0x749DA3C", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000590")]
			[Address(RVA = "0x749DA54", Offset = "0x7499A54", VA = "0x749DA54", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000591")]
			[Address(RVA = "0x749DA5C", Offset = "0x7499A5C", VA = "0x749DA5C", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000592")]
			[Address(RVA = "0x749DA94", Offset = "0x7499A94", VA = "0x749DA94", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2000103")]
		[CompilerGenerated]
		private sealed class _003CCreateAtlases_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003D4")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40003D5")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40003D6")]
			[FieldOffset(Offset = "0x20")]
			public AtlasPackingResult packedAtlasRects;

			[Token(Token = "0x40003D7")]
			[FieldOffset(Offset = "0x28")]
			public MB2_LogLevel LOG_LEVEL;

			[Token(Token = "0x40003D8")]
			[FieldOffset(Offset = "0x30")]
			public MB3_TextureCombinerPipeline.TexturePipelineData data;

			[Token(Token = "0x40003D9")]
			[FieldOffset(Offset = "0x38")]
			public MB3_TextureCombiner combiner;

			[Token(Token = "0x40003DA")]
			[FieldOffset(Offset = "0x40")]
			public ProgressUpdateDelegate progressInfo;

			[Token(Token = "0x40003DB")]
			[FieldOffset(Offset = "0x48")]
			public Texture2D[] atlases;

			[Token(Token = "0x40003DC")]
			[FieldOffset(Offset = "0x50")]
			public MB2_EditorMethodsInterface textureEditorMethods;

			[Token(Token = "0x170000C5")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000596")]
				[Address(RVA = "0x749E72C", Offset = "0x749A72C", VA = "0x749E72C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170000C6")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000598")]
				[Address(RVA = "0x749E76C", Offset = "0x749A76C", VA = "0x749E76C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000593")]
			[Address(RVA = "0x749DA08", Offset = "0x7499A08", VA = "0x749DA08")]
			[DebuggerHidden]
			public _003CCreateAtlases_003Ed__3(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000594")]
			[Address(RVA = "0x749DA9C", Offset = "0x7499A9C", VA = "0x749DA9C", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000595")]
			[Address(RVA = "0x749DAA0", Offset = "0x7499AA0", VA = "0x749DAA0", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000596")]
			[Address(RVA = "0x749E72C", Offset = "0x749A72C", VA = "0x749E72C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000597")]
			[Address(RVA = "0x749E734", Offset = "0x749A734", VA = "0x749E734", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000598")]
			[Address(RVA = "0x749E76C", Offset = "0x749A76C", VA = "0x749E76C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x749D8C8", Offset = "0x74998C8", VA = "0x749D8C8", Slot = "4")]
		public bool Validate(MB3_TextureCombinerPipeline.TexturePipelineData data)
		{
			return default;
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x749D8D0", Offset = "0x74998D0", VA = "0x749D8D0", Slot = "5")]
		[IteratorStateMachine(typeof(_003CConvertTexturesToReadableFormats_003Ed__1))]
		public IEnumerator ConvertTexturesToReadableFormats(ProgressUpdateDelegate progressInfo, MB3_TextureCombiner.CombineTexturesIntoAtlasesCoroutineResult result, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x749D950", Offset = "0x7499950", VA = "0x749D950", Slot = "8")]
		public virtual AtlasPackingResult[] CalculateAtlasRectangles(MB3_TextureCombinerPipeline.TexturePipelineData data, bool doMultiAtlas, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x749D968", Offset = "0x7499968", VA = "0x749D968", Slot = "7")]
		[IteratorStateMachine(typeof(_003CCreateAtlases_003Ed__3))]
		public IEnumerator CreateAtlases(ProgressUpdateDelegate progressInfo, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, AtlasPackingResult packedAtlasRects, Texture2D[] atlases, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x749DA30", Offset = "0x7499A30", VA = "0x749DA30")]
		public MB3_TextureCombinerPackerMeshBakerFast()
		{
		}
	}
}
