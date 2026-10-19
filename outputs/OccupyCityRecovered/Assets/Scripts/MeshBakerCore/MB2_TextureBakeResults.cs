using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DigitalOpus.MB.Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000010")]
public class MB2_TextureBakeResults : ScriptableObject
{
	[Token(Token = "0x2000011")]
	public class CoroutineResult
	{
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x10")]
		public bool isComplete;

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x743DE6C", Offset = "0x7439E6C", VA = "0x743DE6C")]
		public CoroutineResult()
		{
		}
	}

	[Token(Token = "0x2000012")]
	public enum ResultType
	{
		[Token(Token = "0x400004B")]
		atlas = 0,
		[Token(Token = "0x400004C")]
		textureArray = 1
	}

	[Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class _003CFindRuntimeMaterialsFromAddresses_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x20")]
		public MB2_TextureBakeResults _003C_003E4__this;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x28")]
		public CoroutineResult isComplete;

		[Token(Token = "0x17000002")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x743DF4C", Offset = "0x7439F4C", VA = "0x743DF4C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000003")]
object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x743DF8C", Offset = "0x7439F8C", VA = "0x743DF8C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x743C9FC", Offset = "0x74389FC", VA = "0x743C9FC")]
		[DebuggerHidden]
		public _003CFindRuntimeMaterialsFromAddresses_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x743DE74", Offset = "0x7439E74", VA = "0x743DE74", Slot = "5")]
		[DebuggerHidden]
void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x743DE78", Offset = "0x7439E78", VA = "0x743DE78", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x743DF4C", Offset = "0x7439F4C", VA = "0x743DF4C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x743DF54", Offset = "0x7439F54", VA = "0x743DF54", Slot = "8")]
		[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x743DF8C", Offset = "0x7439F8C", VA = "0x743DF8C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x18")]
	public int version;

	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x1C")]
	public ResultType resultType;

	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x20")]
	[NonReorderable]
	public MB_MaterialAndUVRect[] materialsAndUVRects;

	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x28")]
	[NonReorderable]
	public MB_MultiMaterial[] resultMaterials;

	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x30")]
	[NonReorderable]
	public MB_MultiMaterialTexArray[] resultMaterialsTexArray;

	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x38")]
	public bool doMultiMaterial;

	[Token(Token = "0x17000001")]
	public static int VERSION
	{
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x743C888", Offset = "0x7438888", VA = "0x743C888")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x743C890", Offset = "0x7438890", VA = "0x743C890")]
	public MB2_TextureBakeResults()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x743C8B0", Offset = "0x74388B0", VA = "0x743C8B0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x743C918", Offset = "0x7438918", VA = "0x743C918")]
	public int NumResultMaterials()
	{
		return default;
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x743C944", Offset = "0x7438944", VA = "0x743C944")]
	public Material GetCombinedMaterialForSubmesh(int idx)
	{
		return null;
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x743C990", Offset = "0x7438990", VA = "0x743C990")]
	[IteratorStateMachine(typeof(_003CFindRuntimeMaterialsFromAddresses_003Ed__14))]
	public IEnumerator FindRuntimeMaterialsFromAddresses(CoroutineResult isComplete)
	{
		return null;
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x743CA24", Offset = "0x7438A24", VA = "0x743CA24")]
	public bool GetConsiderMeshUVs(int idxInSrcMats, Material srcMaterial)
	{
		return default;
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x743CB8C", Offset = "0x7438B8C", VA = "0x743CB8C")]
	public List<Material> GetSourceMaterialsUsedByResultMaterial(int resultMatIdx)
	{
		return null;
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x743CDC4", Offset = "0x7438DC4", VA = "0x743CDC4")]
	public static MB2_TextureBakeResults CreateForMaterialsOnRenderer(GameObject[] gos, List<Material> matsOnTargetRenderer)
	{
		return null;
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x743D510", Offset = "0x7439510", VA = "0x743D510")]
	public bool DoAnyResultMatsUseConsiderMeshUVs()
	{
		return default;
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x743D640", Offset = "0x7439640", VA = "0x743D640")]
	public bool ContainsMaterial(Material m)
	{
		return default;
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x743D704", Offset = "0x7439704", VA = "0x743D704")]
	public string GetDescription()
	{
		return null;
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x743DB20", Offset = "0x7439B20", VA = "0x743DB20")]
	public void UpgradeToCurrentVersion(MB2_TextureBakeResults tbr)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x743DB84", Offset = "0x7439B84", VA = "0x743DB84")]
	public static bool IsMeshAndMaterialRectEnclosedByAtlasRect(MB_TextureTilingTreatment tilingTreatment, Rect uvR, Rect sourceMaterialTiling, Rect samplingEncapsulatinRect, MB2_LogLevel logLevel)
	{
		return default;
	}
}
