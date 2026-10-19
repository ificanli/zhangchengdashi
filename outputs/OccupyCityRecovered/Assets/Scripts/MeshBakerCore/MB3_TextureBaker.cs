using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DigitalOpus.MB.Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000024")]
public class MB3_TextureBaker : MB3_MeshBakerRoot
{
	[Token(Token = "0x2000025")]
	public delegate void OnCombinedTexturesCoroutineSuccess();

	[Token(Token = "0x2000026")]
	public delegate void OnCombinedTexturesCoroutineFail();

	[Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class _003CCreateAtlasesCoroutine_003Ed__108 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MB3_TextureBaker _003C_003E4__this;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ProgressUpdateDelegate progressInfo;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public MB3_TextureCombiner.CreateAtlasesCoroutineResult coroutineResult;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool saveAtlasesAsAssets;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MB2_EditorMethodsInterface editorMethods;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float maxTimePerFrame;

		[Token(Token = "0x17000023")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x7445AEC", Offset = "0x7441AEC", VA = "0x7445AEC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000024")]
object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x7445B2C", Offset = "0x7441B2C", VA = "0x7445B2C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x7444144", Offset = "0x7440144", VA = "0x7444144")]
		[DebuggerHidden]
		public _003CCreateAtlasesCoroutine_003Ed__108(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x7445A20", Offset = "0x7441A20", VA = "0x7445A20", Slot = "5")]
		[DebuggerHidden]
void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x7445A24", Offset = "0x7441A24", VA = "0x7445A24", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x7445AEC", Offset = "0x7441AEC", VA = "0x7445AEC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x7445AF4", Offset = "0x7441AF4", VA = "0x7445AF4", Slot = "8")]
		[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x7445B2C", Offset = "0x7441B2C", VA = "0x7445B2C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class _003C_CreateAtlasesCoroutine_003Ed__111 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MB3_TextureBaker _003C_003E4__this;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float maxTimePerFrame;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public MB3_TextureCombiner.CreateAtlasesCoroutineResult coroutineResult;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool saveAtlasesAsAssets;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ProgressUpdateDelegate progressInfo;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MB2_EditorMethodsInterface editorMethods;

		[Token(Token = "0x17000025")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x74460D0", Offset = "0x74420D0", VA = "0x74460D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000026")]
object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x7446110", Offset = "0x7442110", VA = "0x7446110", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x74443A0", Offset = "0x74403A0", VA = "0x74443A0")]
		[DebuggerHidden]
		public _003C_CreateAtlasesCoroutine_003Ed__111(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x7445B34", Offset = "0x7441B34", VA = "0x7445B34", Slot = "5")]
		[DebuggerHidden]
void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x7445B38", Offset = "0x7441B38", VA = "0x7445B38", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x74460D0", Offset = "0x74420D0", VA = "0x74460D0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x74460D8", Offset = "0x74420D8", VA = "0x74460D8", Slot = "8")]
		[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x7446110", Offset = "0x7442110", VA = "0x7446110", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class _003C_CreateAtlasesCoroutineAtlases_003Ed__109 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MB3_TextureBaker _003C_003E4__this;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MB3_TextureCombiner combiner;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ProgressUpdateDelegate progressInfo;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MB2_EditorMethodsInterface editorMethods;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float maxTimePerFrame;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MB3_TextureCombiner.CreateAtlasesCoroutineResult coroutineResult;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MB3_TextureCombiner.CombineTexturesIntoAtlasesCoroutineResult _003CcoroutineResult2_003E5__3;

		[Token(Token = "0x17000027")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x7446740", Offset = "0x7442740", VA = "0x7446740", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000028")]
object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x7446780", Offset = "0x7442780", VA = "0x7446780", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x7444204", Offset = "0x7440204", VA = "0x7444204")]
		[DebuggerHidden]
		public _003C_CreateAtlasesCoroutineAtlases_003Ed__109(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x7446118", Offset = "0x7442118", VA = "0x7446118", Slot = "5")]
		[DebuggerHidden]
void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x744611C", Offset = "0x744211C", VA = "0x744611C", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x7446740", Offset = "0x7442740", VA = "0x7446740", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x7446748", Offset = "0x7442748", VA = "0x7446748", Slot = "8")]
		[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x7446780", Offset = "0x7442780", VA = "0x7446780", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class _003C_CreateAtlasesCoroutineTextureArray_003Ed__110 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MB3_TextureBaker _003C_003E4__this;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MB3_TextureCombiner.CreateAtlasesCoroutineResult coroutineResult;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public MB2_EditorMethodsInterface editorMethods;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MB3_TextureCombiner combiner;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ProgressUpdateDelegate progressInfo;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool saveAtlasesAsAssets;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float maxTimePerFrame;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private MB_TextureArrayResultMaterial[] _003CbakedMatsAndSlices_003E5__2;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int _003CresMatIdx_003E5__3;

		[Token(Token = "0x17000029")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x74470AC", Offset = "0x74430AC", VA = "0x74470AC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700002A")]
object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x74470EC", Offset = "0x74430EC", VA = "0x74470EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x74442D8", Offset = "0x74402D8", VA = "0x74442D8")]
		[DebuggerHidden]
		public _003C_CreateAtlasesCoroutineTextureArray_003Ed__110(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x7446788", Offset = "0x7442788", VA = "0x7446788", Slot = "5")]
		[DebuggerHidden]
void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x744678C", Offset = "0x744278C", VA = "0x744678C", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x74470AC", Offset = "0x74430AC", VA = "0x74470AC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x74470B4", Offset = "0x74430B4", VA = "0x74470B4", Slot = "8")]
		[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x74470EC", Offset = "0x74430EC", VA = "0x74470EC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public MB2_LogLevel LOG_LEVEL;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	protected MB2_TextureBakeResults _textureBakeResults;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	protected int _atlasPadding;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[SerializeField]
	protected int _maxAtlasSize;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	protected bool _useMaxAtlasWidthOverride;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	protected int _maxAtlasWidthOverride;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	protected bool _useMaxAtlasHeightOverride;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[SerializeField]
	protected int _maxAtlasHeightOverride;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	protected bool _resizePowerOfTwoTextures;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	[SerializeField]
	protected bool _fixOutOfBoundsUVs;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[SerializeField]
	protected int _maxTilingBakeSize;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	protected MB2_PackingAlgorithmEnum _packingAlgorithm;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[SerializeField]
	protected int _layerTexturePackerFastMesh;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	protected bool _meshBakerTexturePackerForcePowerOfTwo;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[NonReorderable]
	[SerializeField]
	protected List<ShaderTextureProperty> _customShaderProperties;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	[NonReorderable]
	protected List<string> _texturePropNamesToIgnore;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	protected List<string> _customShaderPropNames_Depricated;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	protected MB2_TextureBakeResults.ResultType _resultType;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[SerializeField]
	protected bool _doMultiMaterial;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
	[SerializeField]
	protected bool _doMultiMaterialSplitAtlasesIfTooBig;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x86")]
	[SerializeField]
	protected bool _doMultiMaterialSplitAtlasesIfOBUVs;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	protected Material _resultMaterial;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	protected bool _considerNonTextureProperties;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
	[SerializeField]
	protected bool _doSuggestTreatment;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private MB3_TextureCombiner.CreateAtlasesCoroutineResult _coroutineResult;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[NonReorderable]
	public MB_MultiMaterial[] resultMaterials;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[NonReorderable]
	public MB_MultiMaterialTexArray[] resultMaterialsTexArray;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[NonReorderable]
	public MB_TextureArrayFormatSet[] textureArrayOutputFormats;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[NonReorderable]
	public List<GameObject> objsToMesh;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public OnCombinedTexturesCoroutineSuccess onBuiltAtlasesSuccess;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public OnCombinedTexturesCoroutineFail onBuiltAtlasesFail;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public MB_AtlasesAndRects[] OnCombinedTexturesCoroutineAtlasesAndRects;

	[Token(Token = "0x1700000B")]
	public override MB2_TextureBakeResults textureBakeResults
	{
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x74439C0", Offset = "0x743F9C0", VA = "0x74439C0", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x74439C8", Offset = "0x743F9C8", VA = "0x74439C8", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public virtual int atlasPadding
	{
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x74439D0", Offset = "0x743F9D0", VA = "0x74439D0", Slot = "8")]
		get
		{
			return default;
		}
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x74439D8", Offset = "0x743F9D8", VA = "0x74439D8", Slot = "9")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public virtual int maxAtlasSize
	{
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x74439E0", Offset = "0x743F9E0", VA = "0x74439E0", Slot = "10")]
		get
		{
			return default;
		}
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x74439E8", Offset = "0x743F9E8", VA = "0x74439E8", Slot = "11")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public virtual bool useMaxAtlasWidthOverride
	{
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x74439F0", Offset = "0x743F9F0", VA = "0x74439F0", Slot = "12")]
		get
		{
			return default;
		}
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x74439F8", Offset = "0x743F9F8", VA = "0x74439F8", Slot = "13")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public virtual int maxAtlasWidthOverride
	{
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x7443A04", Offset = "0x743FA04", VA = "0x7443A04", Slot = "14")]
		get
		{
			return default;
		}
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x7443A0C", Offset = "0x743FA0C", VA = "0x7443A0C", Slot = "15")]
		set
		{
		}
	}

	[Token(Token = "0x17000010")]
	public virtual bool useMaxAtlasHeightOverride
	{
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x7443A14", Offset = "0x743FA14", VA = "0x7443A14", Slot = "16")]
		get
		{
			return default;
		}
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x7443A1C", Offset = "0x743FA1C", VA = "0x7443A1C", Slot = "17")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public virtual int maxAtlasHeightOverride
	{
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x7443A28", Offset = "0x743FA28", VA = "0x7443A28", Slot = "18")]
		get
		{
			return default;
		}
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x7443A30", Offset = "0x743FA30", VA = "0x7443A30", Slot = "19")]
		set
		{
		}
	}

	[Token(Token = "0x17000012")]
	public virtual bool resizePowerOfTwoTextures
	{
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x7443A38", Offset = "0x743FA38", VA = "0x7443A38", Slot = "20")]
		get
		{
			return default;
		}
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x7443A40", Offset = "0x743FA40", VA = "0x7443A40", Slot = "21")]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public virtual bool fixOutOfBoundsUVs
	{
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x7443A4C", Offset = "0x743FA4C", VA = "0x7443A4C", Slot = "22")]
		get
		{
			return default;
		}
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x7443A54", Offset = "0x743FA54", VA = "0x7443A54", Slot = "23")]
		set
		{
		}
	}

	[Token(Token = "0x17000014")]
	public virtual int maxTilingBakeSize
	{
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x7443A60", Offset = "0x743FA60", VA = "0x7443A60", Slot = "24")]
		get
		{
			return default;
		}
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x7443A68", Offset = "0x743FA68", VA = "0x7443A68", Slot = "25")]
		set
		{
		}
	}

	[Token(Token = "0x17000015")]
	public virtual MB2_PackingAlgorithmEnum packingAlgorithm
	{
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x7443A70", Offset = "0x743FA70", VA = "0x7443A70", Slot = "26")]
		get
		{
			return default;
		}
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x7443A78", Offset = "0x743FA78", VA = "0x7443A78", Slot = "27")]
		set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public virtual int layerForTexturePackerFastMesh
	{
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x7443A80", Offset = "0x743FA80", VA = "0x7443A80", Slot = "28")]
		get
		{
			return default;
		}
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x7443A88", Offset = "0x743FA88", VA = "0x7443A88", Slot = "29")]
		set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public bool meshBakerTexturePackerForcePowerOfTwo
	{
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x7443A90", Offset = "0x743FA90", VA = "0x7443A90")]
		get
		{
			return default;
		}
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x7443A98", Offset = "0x743FA98", VA = "0x7443A98")]
		set
		{
		}
	}

	[Token(Token = "0x17000018")]
	public virtual List<ShaderTextureProperty> customShaderProperties
	{
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x7443AA4", Offset = "0x743FAA4", VA = "0x7443AA4", Slot = "30")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x7443AAC", Offset = "0x743FAAC", VA = "0x7443AAC", Slot = "31")]
		set
		{
		}
	}

	[Token(Token = "0x17000019")]
	public virtual List<string> texturePropNamesToIgnore
	{
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x7443AB4", Offset = "0x743FAB4", VA = "0x7443AB4", Slot = "32")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x7443ABC", Offset = "0x743FABC", VA = "0x7443ABC", Slot = "33")]
		set
		{
		}
	}

	[Token(Token = "0x1700001A")]
	public virtual List<string> customShaderPropNames
	{
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x7443AC4", Offset = "0x743FAC4", VA = "0x7443AC4", Slot = "34")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x7443ACC", Offset = "0x743FACC", VA = "0x7443ACC", Slot = "35")]
		set
		{
		}
	}

	[Token(Token = "0x1700001B")]
	public virtual MB2_TextureBakeResults.ResultType resultType
	{
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x7443AD4", Offset = "0x743FAD4", VA = "0x7443AD4", Slot = "36")]
		get
		{
			return default;
		}
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x7443ADC", Offset = "0x743FADC", VA = "0x7443ADC", Slot = "37")]
		set
		{
		}
	}

	[Token(Token = "0x1700001C")]
	public virtual bool doMultiMaterial
	{
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x7443AE4", Offset = "0x743FAE4", VA = "0x7443AE4", Slot = "38")]
		get
		{
			return default;
		}
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x7443AEC", Offset = "0x743FAEC", VA = "0x7443AEC", Slot = "39")]
		set
		{
		}
	}

	[Token(Token = "0x1700001D")]
	public virtual bool doMultiMaterialSplitAtlasesIfTooBig
	{
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x7443AF8", Offset = "0x743FAF8", VA = "0x7443AF8", Slot = "40")]
		get
		{
			return default;
		}
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x7443B00", Offset = "0x743FB00", VA = "0x7443B00", Slot = "41")]
		set
		{
		}
	}

	[Token(Token = "0x1700001E")]
	public virtual bool doMultiMaterialSplitAtlasesIfOBUVs
	{
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x7443B0C", Offset = "0x743FB0C", VA = "0x7443B0C", Slot = "42")]
		get
		{
			return default;
		}
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x7443B14", Offset = "0x743FB14", VA = "0x7443B14", Slot = "43")]
		set
		{
		}
	}

	[Token(Token = "0x1700001F")]
	public virtual Material resultMaterial
	{
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x7443B20", Offset = "0x743FB20", VA = "0x7443B20", Slot = "44")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x7443B28", Offset = "0x743FB28", VA = "0x7443B28", Slot = "45")]
		set
		{
		}
	}

	[Token(Token = "0x17000020")]
	public bool considerNonTextureProperties
	{
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x7443B30", Offset = "0x743FB30", VA = "0x7443B30")]
		get
		{
			return default;
		}
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x7443B38", Offset = "0x743FB38", VA = "0x7443B38")]
		set
		{
		}
	}

	[Token(Token = "0x17000021")]
	public bool doSuggestTreatment
	{
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x7443B44", Offset = "0x743FB44", VA = "0x7443B44")]
		get
		{
			return default;
		}
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x7443B4C", Offset = "0x743FB4C", VA = "0x7443B4C")]
		set
		{
		}
	}

	[Token(Token = "0x17000022")]
	public MB3_TextureCombiner.CreateAtlasesCoroutineResult CoroutineResult
	{
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x7443B58", Offset = "0x743FB58", VA = "0x7443B58")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x7443B60", Offset = "0x743FB60", VA = "0x7443B60", Slot = "6")]
	public override List<GameObject> GetObjectsToCombine()
	{
		return null;
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x7443BD8", Offset = "0x743FBD8", VA = "0x7443BD8", Slot = "7")]
	[ContextMenu("Purge Objects to Combine of null references")]
	public override void PurgeNullsFromObjectsToCombine()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x7443DAC", Offset = "0x743FDAC", VA = "0x7443DAC")]
	public MB_AtlasesAndRects[] CreateAtlases()
	{
		return null;
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x74440A4", Offset = "0x74400A4", VA = "0x74440A4")]
	[IteratorStateMachine(typeof(_003CCreateAtlasesCoroutine_003Ed__108))]
	public IEnumerator CreateAtlasesCoroutine(ProgressUpdateDelegate progressInfo, MB3_TextureCombiner.CreateAtlasesCoroutineResult coroutineResult, [Optional][DefaultParameterValue(false)] bool saveAtlasesAsAssets, [Optional] MB2_EditorMethodsInterface editorMethods, float maxTimePerFrame = 0.01f)
	{
		return null;
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x744416C", Offset = "0x744016C", VA = "0x744416C")]
	[IteratorStateMachine(typeof(_003C_CreateAtlasesCoroutineAtlases_003Ed__109))]
	private IEnumerator _CreateAtlasesCoroutineAtlases(MB3_TextureCombiner combiner, ProgressUpdateDelegate progressInfo, MB3_TextureCombiner.CreateAtlasesCoroutineResult coroutineResult, [Optional][DefaultParameterValue(false)] bool saveAtlasesAsAssets, [Optional] MB2_EditorMethodsInterface editorMethods, float maxTimePerFrame = 0.01f)
	{
		return null;
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x744422C", Offset = "0x744022C", VA = "0x744422C")]
	[IteratorStateMachine(typeof(_003C_CreateAtlasesCoroutineTextureArray_003Ed__110))]
	internal IEnumerator _CreateAtlasesCoroutineTextureArray(MB3_TextureCombiner combiner, ProgressUpdateDelegate progressInfo, MB3_TextureCombiner.CreateAtlasesCoroutineResult coroutineResult, [Optional][DefaultParameterValue(false)] bool saveAtlasesAsAssets, [Optional] MB2_EditorMethodsInterface editorMethods, float maxTimePerFrame = 0.01f)
	{
		return null;
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x7444300", Offset = "0x7440300", VA = "0x7444300")]
	[IteratorStateMachine(typeof(_003C_CreateAtlasesCoroutine_003Ed__111))]
	private IEnumerator _CreateAtlasesCoroutine(ProgressUpdateDelegate progressInfo, MB3_TextureCombiner.CreateAtlasesCoroutineResult coroutineResult, [Optional][DefaultParameterValue(false)] bool saveAtlasesAsAssets, [Optional] MB2_EditorMethodsInterface editorMethods, float maxTimePerFrame = 0.01f)
	{
		return null;
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x7443DBC", Offset = "0x743FDBC", VA = "0x7443DBC")]
	public MB_AtlasesAndRects[] CreateAtlases(ProgressUpdateDelegate progressInfo, [Optional][DefaultParameterValue(false)] bool saveAtlasesAsAssets, [Optional] MB2_EditorMethodsInterface editorMethods)
	{
		return null;
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x74443C8", Offset = "0x74403C8", VA = "0x74443C8")]
	private void unpackMat2RectMap(MB_AtlasesAndRects[] rawResults)
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x74445C8", Offset = "0x74405C8", VA = "0x74445C8")]
	internal void unpackMat2RectMap(MB_TextureArrayResultMaterial[] rawResults)
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x7444808", Offset = "0x7440808", VA = "0x7444808")]
	public MB3_TextureCombiner CreateAndConfigureTextureCombiner()
	{
		return null;
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x7444910", Offset = "0x7440910", VA = "0x7444910")]
	public static void ConfigureNewMaterialToMatchOld(Material newMat, Material original)
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x7444BE0", Offset = "0x7440BE0", VA = "0x7444BE0")]
	private string PrintSet(HashSet<Material> s)
	{
		return null;
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x7444DD4", Offset = "0x7440DD4", VA = "0x7444DD4")]
	private bool _ValidateResultMaterials()
	{
		return default;
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x744565C", Offset = "0x744165C", VA = "0x744565C")]
	public MB3_TextureBaker()
	{
	}
}
