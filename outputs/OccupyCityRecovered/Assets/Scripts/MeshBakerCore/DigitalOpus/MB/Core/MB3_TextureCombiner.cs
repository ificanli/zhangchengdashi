using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Serializable]
	[Token(Token = "0x20000E3")]
	public class MB3_TextureCombiner
	{
		[Token(Token = "0x20000E4")]
		public class CreateAtlasesCoroutineResult
		{
			[Token(Token = "0x400033D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool success;

			[Token(Token = "0x400033E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			public bool isFinished;

			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x7492934", Offset = "0x748E934", VA = "0x7492934")]
			public CreateAtlasesCoroutineResult()
			{
			}
		}

		[Token(Token = "0x20000E5")]
		internal class TemporaryTexture
		{
			[Token(Token = "0x400033F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal string property;

			[Token(Token = "0x4000340")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Texture2D texture;

			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x7492944", Offset = "0x748E944", VA = "0x7492944")]
			public TemporaryTexture(string prop, Texture2D tex)
			{
			}
		}

		[Token(Token = "0x20000E6")]
		public class CombineTexturesIntoAtlasesCoroutineResult
		{
			[Token(Token = "0x4000341")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool success;

			[Token(Token = "0x4000342")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			public bool isFinished;

			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x7492970", Offset = "0x748E970", VA = "0x7492970")]
			public CombineTexturesIntoAtlasesCoroutineResult()
			{
			}
		}

		[Token(Token = "0x20000E7")]
		[CompilerGenerated]
		private sealed class _003CCombineTexturesIntoAtlasesCoroutine_003Ed__84 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000343")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000344")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000345")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CombineTexturesIntoAtlasesCoroutineResult coroutineResult;

			[Token(Token = "0x4000346")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float maxTimePerFrame;

			[Token(Token = "0x4000347")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public MB3_TextureCombiner _003C_003E4__this;

			[Token(Token = "0x4000348")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public ProgressUpdateDelegate progressInfo;

			[Token(Token = "0x4000349")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public MB_AtlasesAndRects resultAtlasesAndRects;

			[Token(Token = "0x400034A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Material resultMaterial;

			[Token(Token = "0x400034B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public List<GameObject> objsToMesh;

			[Token(Token = "0x400034C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public List<Material> allowedMaterialsFilter;

			[Token(Token = "0x400034D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public List<string> texPropsToIgnore;

			[Token(Token = "0x400034E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public MB2_EditorMethodsInterface textureEditorMethods;

			[Token(Token = "0x400034F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public List<AtlasPackingResult> packingResults;

			[Token(Token = "0x4000350")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public bool onlyPackRects;

			[Token(Token = "0x4000351")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
			public bool splitAtlasWhenPackingIfTooBig;

			[Token(Token = "0x170000A5")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004DA")]
				[Address(RVA = "0x7492ACC", Offset = "0x748EACC", VA = "0x7492ACC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170000A6")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004DC")]
				[Address(RVA = "0x7492B0C", Offset = "0x748EB0C", VA = "0x7492B0C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x7492980", Offset = "0x748E980", VA = "0x7492980")]
			[DebuggerHidden]
			public _003CCombineTexturesIntoAtlasesCoroutine_003Ed__84(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x74929A8", Offset = "0x748E9A8", VA = "0x74929A8", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x74929AC", Offset = "0x748E9AC", VA = "0x74929AC", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x7492ACC", Offset = "0x748EACC", VA = "0x7492ACC", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x7492AD4", Offset = "0x748EAD4", VA = "0x7492AD4", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x7492B0C", Offset = "0x748EB0C", VA = "0x7492B0C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x20000E8")]
		[CompilerGenerated]
		private sealed class _003C_CombineTexturesIntoAtlases_003Ed__85 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000352")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000353")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000354")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MB3_TextureCombiner _003C_003E4__this;

			[Token(Token = "0x4000355")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MB2_EditorMethodsInterface textureEditorMethods;

			[Token(Token = "0x4000356")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool splitAtlasWhenPackingIfTooBig;

			[Token(Token = "0x4000357")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
			public bool onlyPackRects;

			[Token(Token = "0x4000358")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public CombineTexturesIntoAtlasesCoroutineResult result;

			[Token(Token = "0x4000359")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public List<GameObject> objsToMesh;

			[Token(Token = "0x400035A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public ProgressUpdateDelegate progressInfo;

			[Token(Token = "0x400035B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Material resultMaterial;

			[Token(Token = "0x400035C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public List<Material> allowedMaterialsFilter;

			[Token(Token = "0x400035D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public List<string> texPropsToIgnore;

			[Token(Token = "0x400035E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public MB_AtlasesAndRects resultAtlasesAndRects;

			[Token(Token = "0x400035F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public List<AtlasPackingResult> atlasPackingResult;

			[Token(Token = "0x4000360")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private Stopwatch _003Csw_003E5__2;

			[Token(Token = "0x170000A7")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004E1")]
				[Address(RVA = "0x749367C", Offset = "0x748F67C", VA = "0x749367C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170000A8")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004E3")]
				[Address(RVA = "0x74936BC", Offset = "0x748F6BC", VA = "0x74936BC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x7492B14", Offset = "0x748EB14", VA = "0x7492B14")]
			[DebuggerHidden]
			public _003C_CombineTexturesIntoAtlases_003Ed__85(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x7492B3C", Offset = "0x748EB3C", VA = "0x7492B3C", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x7492B68", Offset = "0x748EB68", VA = "0x7492B68", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x749342C", Offset = "0x748F42C", VA = "0x749342C")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x749367C", Offset = "0x748F67C", VA = "0x749367C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x7493684", Offset = "0x748F684", VA = "0x7493684", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x74936BC", Offset = "0x748F6BC", VA = "0x74936BC", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x20000E9")]
		[CompilerGenerated]
		private sealed class _003C__CombineTexturesIntoAtlases_003Ed__87 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000361")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000362")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MB3_TextureCombiner _003C_003E4__this;

			[Token(Token = "0x4000364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MB3_TextureCombinerPipeline.TexturePipelineData data;

			[Token(Token = "0x4000365")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ProgressUpdateDelegate progressInfo;

			[Token(Token = "0x4000366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public CombineTexturesIntoAtlasesCoroutineResult result;

			[Token(Token = "0x4000367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public MB2_EditorMethodsInterface textureEditorMethods;

			[Token(Token = "0x4000368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public MB_AtlasesAndRects resultAtlasesAndRects;

			[Token(Token = "0x4000369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private MB3_TextureCombinerPipeline _003Cpipeline_003E5__2;

			[Token(Token = "0x400036A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private StringBuilder _003Creport_003E5__3;

			[Token(Token = "0x400036B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private MB_ITextureCombinerPacker _003CtexturePaker_003E5__4;

			[Token(Token = "0x170000A9")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004E7")]
				[Address(RVA = "0x7493D04", Offset = "0x748FD04", VA = "0x7493D04", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170000AA")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004E9")]
				[Address(RVA = "0x7493D44", Offset = "0x748FD44", VA = "0x7493D44", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x74936C4", Offset = "0x748F6C4", VA = "0x74936C4")]
			[DebuggerHidden]
			public _003C__CombineTexturesIntoAtlases_003Ed__87(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x74936EC", Offset = "0x748F6EC", VA = "0x74936EC", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x74936F0", Offset = "0x748F6F0", VA = "0x74936F0", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x7493D04", Offset = "0x748FD04", VA = "0x7493D04", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x7493D0C", Offset = "0x748FD0C", VA = "0x7493D0C", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x7493D44", Offset = "0x748FD44", VA = "0x7493D44", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x20000EA")]
		[CompilerGenerated]
		private sealed class _003C__RunTexturePackerOnly_003Ed__88 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400036C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400036D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400036E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MB3_TextureCombiner _003C_003E4__this;

			[Token(Token = "0x400036F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MB3_TextureCombinerPipeline.TexturePipelineData data;

			[Token(Token = "0x4000370")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public CombineTexturesIntoAtlasesCoroutineResult result;

			[Token(Token = "0x4000371")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public MB2_EditorMethodsInterface textureEditorMethods;

			[Token(Token = "0x4000372")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool splitAtlasWhenPackingIfTooBig;

			[Token(Token = "0x4000373")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public MB_AtlasesAndRects resultAtlasesAndRects;

			[Token(Token = "0x4000374")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public List<AtlasPackingResult> packingResult;

			[Token(Token = "0x4000375")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private MB3_TextureCombinerPipeline _003Cpipeline_003E5__2;

			[Token(Token = "0x170000AB")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004ED")]
				[Address(RVA = "0x7494200", Offset = "0x7490200", VA = "0x7494200", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170000AC")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004EF")]
				[Address(RVA = "0x7494240", Offset = "0x7490240", VA = "0x7494240", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x7493D4C", Offset = "0x748FD4C", VA = "0x7493D4C")]
			[DebuggerHidden]
			public _003C__RunTexturePackerOnly_003Ed__88(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x7493D74", Offset = "0x748FD74", VA = "0x7493D74", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004EC")]
			[Address(RVA = "0x7493D78", Offset = "0x748FD78", VA = "0x7493D78", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60004ED")]
			[Address(RVA = "0x7494200", Offset = "0x7490200", VA = "0x7494200", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60004EE")]
			[Address(RVA = "0x7494208", Offset = "0x7490208", VA = "0x7494208", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x7494240", Offset = "0x7490240", VA = "0x7494240", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000324")]
		public const int TEMP_SOLID_COLOR_TEXTURE_SIZE = 16;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Color NEUTRAL_NORMAL_MAP_COLOR_SWIZZLED;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Color NEUTRAL_NORMAL_MAP_COLOR_NON_SWIZZLED;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MB2_LogLevel LOG_LEVEL;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected MB2_TextureBakeResults _textureBakeResults;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected int _atlasPadding;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected int _maxAtlasSize;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected int _maxAtlasWidthOverride;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		protected int _maxAtlasHeightOverride;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected bool _useMaxAtlasWidthOverride;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		[SerializeField]
		protected bool _useMaxAtlasHeightOverride;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		[SerializeField]
		protected bool _resizePowerOfTwoTextures;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
		[SerializeField]
		protected bool _fixOutOfBoundsUVs;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		protected int _layerTexturePackerFastMesh;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected int _maxTilingBakeSize;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		protected bool _saveAtlasesAsAssets;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected MB2_TextureBakeResults.ResultType _resultType;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		protected MB2_PackingAlgorithmEnum _packingAlgorithm;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected bool _meshBakerTexturePackerForcePowerOfTwo;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected List<ShaderTextureProperty> _customShaderPropNames;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected bool _normalizeTexelDensity;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		[SerializeField]
		protected bool _considerNonTextureProperties;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		protected bool _doMergeDistinctMaterialTexturesThatWouldExceedAtlasSize;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<TemporaryTexture> _temporaryTextures;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static bool _RunCorutineWithoutPauseIsRunning;

		[Token(Token = "0x17000093")]
		public MB2_TextureBakeResults textureBakeResults
		{
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x748FAC8", Offset = "0x748BAC8", VA = "0x748FAC8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x748FAD0", Offset = "0x748BAD0", VA = "0x748FAD0")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public int atlasPadding
		{
			[Token(Token = "0x600049E")]
			[Address(RVA = "0x748FAD8", Offset = "0x748BAD8", VA = "0x748FAD8")]
			get
			{
				return default;
			}
			[Token(Token = "0x600049F")]
			[Address(RVA = "0x748FAE0", Offset = "0x748BAE0", VA = "0x748FAE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public int maxAtlasSize
		{
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x748FAE8", Offset = "0x748BAE8", VA = "0x748FAE8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x748FAF0", Offset = "0x748BAF0", VA = "0x748FAF0")]
			set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public virtual int maxAtlasWidthOverride
		{
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x748FAF8", Offset = "0x748BAF8", VA = "0x748FAF8", Slot = "4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x748FB00", Offset = "0x748BB00", VA = "0x748FB00", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public virtual int maxAtlasHeightOverride
		{
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x748FB08", Offset = "0x748BB08", VA = "0x748FB08", Slot = "6")]
			get
			{
				return default;
			}
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x748FB10", Offset = "0x748BB10", VA = "0x748FB10", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public virtual bool useMaxAtlasWidthOverride
		{
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x748FB18", Offset = "0x748BB18", VA = "0x748FB18", Slot = "8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x748FB20", Offset = "0x748BB20", VA = "0x748FB20", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public virtual bool useMaxAtlasHeightOverride
		{
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x748FB2C", Offset = "0x748BB2C", VA = "0x748FB2C", Slot = "10")]
			get
			{
				return default;
			}
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x748FB34", Offset = "0x748BB34", VA = "0x748FB34", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public bool resizePowerOfTwoTextures
		{
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x748FB40", Offset = "0x748BB40", VA = "0x748FB40")]
			get
			{
				return default;
			}
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x748FB48", Offset = "0x748BB48", VA = "0x748FB48")]
			set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public bool fixOutOfBoundsUVs
		{
			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x748FB54", Offset = "0x748BB54", VA = "0x748FB54")]
			get
			{
				return default;
			}
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x748FB5C", Offset = "0x748BB5C", VA = "0x748FB5C")]
			set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public int layerTexturePackerFastMesh
		{
			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x748FB68", Offset = "0x748BB68", VA = "0x748FB68")]
			get
			{
				return default;
			}
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x748FB70", Offset = "0x748BB70", VA = "0x748FB70")]
			set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public int maxTilingBakeSize
		{
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x748FB78", Offset = "0x748BB78", VA = "0x748FB78")]
			get
			{
				return default;
			}
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x748FB80", Offset = "0x748BB80", VA = "0x748FB80")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public bool saveAtlasesAsAssets
		{
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x748FB88", Offset = "0x748BB88", VA = "0x748FB88")]
			get
			{
				return default;
			}
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x748FB90", Offset = "0x748BB90", VA = "0x748FB90")]
			set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public MB2_TextureBakeResults.ResultType resultType
		{
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x748FB9C", Offset = "0x748BB9C", VA = "0x748FB9C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x748FBA4", Offset = "0x748BBA4", VA = "0x748FBA4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public MB2_PackingAlgorithmEnum packingAlgorithm
		{
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x748FBAC", Offset = "0x748BBAC", VA = "0x748FBAC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x748FBB4", Offset = "0x748BBB4", VA = "0x748FBB4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public bool meshBakerTexturePackerForcePowerOfTwo
		{
			[Token(Token = "0x60004B8")]
			[Address(RVA = "0x748FBBC", Offset = "0x748BBBC", VA = "0x748FBBC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60004B9")]
			[Address(RVA = "0x748FBC4", Offset = "0x748BBC4", VA = "0x748FBC4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public List<ShaderTextureProperty> customShaderPropNames
		{
			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x748FBD0", Offset = "0x748BBD0", VA = "0x748FBD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x748FBD8", Offset = "0x748BBD8", VA = "0x748FBD8")]
			set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public bool considerNonTextureProperties
		{
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x748FBE0", Offset = "0x748BBE0", VA = "0x748FBE0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x748FBE8", Offset = "0x748BBE8", VA = "0x748FBE8")]
			set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public bool doMergeDistinctMaterialTexturesThatWouldExceedAtlasSize
		{
			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x748FBF4", Offset = "0x748BBF4", VA = "0x748FBF4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60004BF")]
			[Address(RVA = "0x748FBFC", Offset = "0x748BBFC", VA = "0x748FBFC")]
			set
			{
			}
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x748FC08", Offset = "0x748BC08", VA = "0x748FC08")]
		public static void RunCorutineWithoutPause(IEnumerator cor, int recursionDepth)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x748FEF4", Offset = "0x748BEF4", VA = "0x748FEF4")]
		public bool CombineTexturesIntoAtlases(ProgressUpdateDelegate progressInfo, MB_AtlasesAndRects resultAtlasesAndRects, Material resultMaterial, List<GameObject> objsToMesh, List<Material> allowedMaterialsFilter, List<string> texPropsToIgnore, [Optional] MB2_EditorMethodsInterface textureEditorMethods, [Optional] List<AtlasPackingResult> packingResults, bool onlyPackRects = false, bool splitAtlasWhenPackingIfTooBig = false)
		{
			return default;
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x7490148", Offset = "0x748C148", VA = "0x7490148")]
		[IteratorStateMachine(typeof(_003CCombineTexturesIntoAtlasesCoroutine_003Ed__84))]
		public IEnumerator CombineTexturesIntoAtlasesCoroutine(ProgressUpdateDelegate progressInfo, MB_AtlasesAndRects resultAtlasesAndRects, Material resultMaterial, List<GameObject> objsToMesh, List<Material> allowedMaterialsFilter, List<string> texPropsToIgnore, [Optional] MB2_EditorMethodsInterface textureEditorMethods, [Optional] CombineTexturesIntoAtlasesCoroutineResult coroutineResult, [Optional][DefaultParameterValue(0.01f)] float maxTimePerFrame, [Optional] List<AtlasPackingResult> packingResults, bool onlyPackRects = false, bool splitAtlasWhenPackingIfTooBig = false)
		{
			return null;
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x7490078", Offset = "0x748C078", VA = "0x7490078")]
		[IteratorStateMachine(typeof(_003C_CombineTexturesIntoAtlases_003Ed__85))]
		private IEnumerator _CombineTexturesIntoAtlases(ProgressUpdateDelegate progressInfo, CombineTexturesIntoAtlasesCoroutineResult result, MB_AtlasesAndRects resultAtlasesAndRects, Material resultMaterial, List<GameObject> objsToMesh, List<Material> allowedMaterialsFilter, List<string> texPropsToIgnore, MB2_EditorMethodsInterface textureEditorMethods, List<AtlasPackingResult> atlasPackingResult, bool onlyPackRects, bool splitAtlasWhenPackingIfTooBig)
		{
			return null;
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x749022C", Offset = "0x748C22C", VA = "0x749022C")]
		private MB3_TextureCombinerPipeline.TexturePipelineData LoadPipelineData(Material resultMaterial, List<ShaderTextureProperty> texPropertyNames, List<GameObject> objsToMesh, List<Material> allowedMaterialsFilter, List<string> texPropsToIgnore, List<MB_TexSet> distinctMaterialTextures)
		{
			return null;
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x74903E0", Offset = "0x748C3E0", VA = "0x74903E0")]
		[IteratorStateMachine(typeof(_003C__CombineTexturesIntoAtlases_003Ed__87))]
		private IEnumerator __CombineTexturesIntoAtlases(ProgressUpdateDelegate progressInfo, CombineTexturesIntoAtlasesCoroutineResult result, MB_AtlasesAndRects resultAtlasesAndRects, MB3_TextureCombinerPipeline.TexturePipelineData data, MB2_EditorMethodsInterface textureEditorMethods)
		{
			return null;
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x749047C", Offset = "0x748C47C", VA = "0x749047C")]
		[IteratorStateMachine(typeof(_003C__RunTexturePackerOnly_003Ed__88))]
		private IEnumerator __RunTexturePackerOnly(CombineTexturesIntoAtlasesCoroutineResult result, MB_AtlasesAndRects resultAtlasesAndRects, MB3_TextureCombinerPipeline.TexturePipelineData data, bool splitAtlasWhenPackingIfTooBig, MB2_EditorMethodsInterface textureEditorMethods, List<AtlasPackingResult> packingResult)
		{
			return null;
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x7490524", Offset = "0x748C524", VA = "0x7490524")]
		internal int _getNumTemporaryTextures()
		{
			return default;
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x749056C", Offset = "0x748C56C", VA = "0x749056C")]
		public Texture2D _createTemporaryTexture(string propertyName, int w, int h, TextureFormat texFormat, bool mipMaps, bool linear)
		{
			return null;
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x7490770", Offset = "0x748C770", VA = "0x7490770")]
		internal void AddTemporaryTexture(TemporaryTexture tt)
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x7490814", Offset = "0x748C814", VA = "0x7490814")]
		internal Texture2D _createTextureCopy(ShaderTextureProperty propertyName, Texture2D t)
		{
			return null;
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x74909F4", Offset = "0x748C9F4", VA = "0x74909F4")]
		internal Texture2D _resizeTexture(ShaderTextureProperty propertyName, Texture2D t, int w, int h)
		{
			return null;
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x7490BBC", Offset = "0x748CBBC", VA = "0x7490BBC")]
		internal void _destroyAllTemporaryTextures()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x7490D24", Offset = "0x748CD24", VA = "0x7490D24")]
		internal void _destroyTemporaryTextures(string propertyName)
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x7490F68", Offset = "0x748CF68", VA = "0x7490F68")]
		public void _restoreProceduralMaterials()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x7490F6C", Offset = "0x748CF6C", VA = "0x7490F6C")]
		public void SuggestTreatment(List<GameObject> objsToMesh, Material[] resultMaterials, List<ShaderTextureProperty> _customShaderPropNames, List<string> texPropsToIgnore)
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x748F000", Offset = "0x748B000", VA = "0x748F000")]
		public static bool ShouldTextureBeLinear(ShaderTextureProperty shaderTextureProperty)
		{
			return default;
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x74926B8", Offset = "0x748E6B8", VA = "0x74926B8")]
		private string PrintList(List<GameObject> gos)
		{
			return null;
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x74927DC", Offset = "0x748E7DC", VA = "0x74927DC")]
		public MB3_TextureCombiner()
		{
		}
	}
}
