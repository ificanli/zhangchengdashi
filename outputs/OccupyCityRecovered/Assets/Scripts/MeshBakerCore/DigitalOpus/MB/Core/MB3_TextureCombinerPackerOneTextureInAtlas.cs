using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x200010F")]
	internal class MB3_TextureCombinerPackerOneTextureInAtlas : MB_ITextureCombinerPacker
	{
		[Token(Token = "0x2000110")]
		[CompilerGenerated]
		private sealed class _003CConvertTexturesToReadableFormats_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003FA")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40003FB")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x170000CB")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005D6")]
				[Address(RVA = "0x74A3C38", Offset = "0x749FC38", VA = "0x74A3C38", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170000CC")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005D8")]
				[Address(RVA = "0x74A3C78", Offset = "0x749FC78", VA = "0x74A3C78", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x74A3858", Offset = "0x749F858", VA = "0x74A3858")]
			[DebuggerHidden]
			public _003CConvertTexturesToReadableFormats_003Ed__1(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60005D4")]
			[Address(RVA = "0x74A3C1C", Offset = "0x749FC1C", VA = "0x74A3C1C", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x74A3C20", Offset = "0x749FC20", VA = "0x74A3C20", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60005D6")]
			[Address(RVA = "0x74A3C38", Offset = "0x749FC38", VA = "0x74A3C38", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x74A3C40", Offset = "0x749FC40", VA = "0x74A3C40", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x74A3C78", Offset = "0x749FC78", VA = "0x74A3C78", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2000111")]
		[CompilerGenerated]
		private sealed class _003CCreateAtlases_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003FC")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40003FD")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40003FE")]
			[FieldOffset(Offset = "0x20")]
			public MB2_LogLevel LOG_LEVEL;

			[Token(Token = "0x40003FF")]
			[FieldOffset(Offset = "0x28")]
			public MB3_TextureCombinerPipeline.TexturePipelineData data;

			[Token(Token = "0x4000400")]
			[FieldOffset(Offset = "0x30")]
			public Texture2D[] atlases;

			[Token(Token = "0x170000CD")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005DC")]
				[Address(RVA = "0x74A3F10", Offset = "0x749FF10", VA = "0x74A3F10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170000CE")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005DE")]
				[Address(RVA = "0x74A3F50", Offset = "0x749FF50", VA = "0x74A3F50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x74A3BEC", Offset = "0x749FBEC", VA = "0x74A3BEC")]
			[DebuggerHidden]
			public _003CCreateAtlases_003Ed__3(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x74A3C80", Offset = "0x749FC80", VA = "0x74A3C80", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x74A3C84", Offset = "0x749FC84", VA = "0x74A3C84", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x74A3F10", Offset = "0x749FF10", VA = "0x74A3F10", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x74A3F18", Offset = "0x749FF18", VA = "0x74A3F18", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x74A3F50", Offset = "0x749FF50", VA = "0x74A3F50", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x74A3770", Offset = "0x749F770", VA = "0x74A3770", Slot = "8")]
		public virtual bool Validate(MB3_TextureCombinerPipeline.TexturePipelineData data)
		{
			return default;
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x74A3800", Offset = "0x749F800", VA = "0x74A3800", Slot = "5")]
		[IteratorStateMachine(typeof(_003CConvertTexturesToReadableFormats_003Ed__1))]
		public IEnumerator ConvertTexturesToReadableFormats(ProgressUpdateDelegate progressInfo, MB3_TextureCombiner.CombineTexturesIntoAtlasesCoroutineResult result, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x74A3880", Offset = "0x749F880", VA = "0x74A3880", Slot = "6")]
		public AtlasPackingResult[] CalculateAtlasRectangles(MB3_TextureCombinerPipeline.TexturePipelineData data, bool doMultiAtlas, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x74A3B78", Offset = "0x749FB78", VA = "0x74A3B78", Slot = "7")]
		[IteratorStateMachine(typeof(_003CCreateAtlases_003Ed__3))]
		public IEnumerator CreateAtlases(ProgressUpdateDelegate progressInfo, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, AtlasPackingResult packedAtlasRects, Texture2D[] atlases, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x74A3C14", Offset = "0x749FC14", VA = "0x74A3C14")]
		public MB3_TextureCombinerPackerOneTextureInAtlas()
		{
		}
	}
}
