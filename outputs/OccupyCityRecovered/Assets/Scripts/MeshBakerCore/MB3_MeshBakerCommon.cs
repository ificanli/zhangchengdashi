using System.Collections.Generic;
using System.Runtime.InteropServices;
using DigitalOpus.MB.Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

[Token(Token = "0x200001B")]
public abstract class MB3_MeshBakerCommon : MB3_MeshBakerRoot
{
	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int version;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[NonReorderable]
	public List<GameObject> objsToMesh;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool useObjsToMeshFromTexBaker;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	[HideInInspector]
	[FormerlySerializedAs("clearBuffersAfterBake")]
	[SerializeField]
	private bool _clearBuffersAfterBake;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string bakeAssetsInPlaceFolderPath;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public GameObject resultPrefab;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public bool resultPrefabLeaveInstanceInSceneAfterBake;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[HideInInspector]
	public Transform parentSceneObject;

	[Token(Token = "0x17000005")]
	public static int VERSION
	{
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x743F8E0", Offset = "0x743B8E0", VA = "0x743F8E0")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000006")]
	public abstract MB3_MeshCombiner meshCombiner
	{
		[Token(Token = "0x6000050")]
		get;
	}

	[Token(Token = "0x17000007")]
	public bool clearBuffersAfterBake
	{
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x743F8E8", Offset = "0x743B8E8", VA = "0x743F8E8")]
		get
		{
			return default;
		}
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x743F9A0", Offset = "0x743B9A0", VA = "0x743F9A0")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public override MB2_TextureBakeResults textureBakeResults
	{
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x743FA64", Offset = "0x743BA64", VA = "0x743FA64", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x743FA90", Offset = "0x743BA90", VA = "0x743FA90", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x743F700", Offset = "0x743B700", VA = "0x743F700")]
	public void UpgradeToCurrentVersionIfNecessary()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x743FAC8", Offset = "0x743BAC8", VA = "0x743FAC8", Slot = "6")]
	public override List<GameObject> GetObjectsToCombine()
	{
		return null;
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x743FD08", Offset = "0x743BD08", VA = "0x743FD08", Slot = "7")]
	[ContextMenu("Purge Objects to Combine of null references")]
	public override void PurgeNullsFromObjectsToCombine()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x7440078", Offset = "0x743C078", VA = "0x7440078")]
	public void EnableDisableSourceObjectRenderers(bool show)
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x7440310", Offset = "0x743C310", VA = "0x7440310", Slot = "9")]
	public virtual void ClearMesh()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x7440348", Offset = "0x743C348", VA = "0x7440348", Slot = "10")]
	public virtual void ClearMesh(MB2_EditorMethodsInterface editorMethods)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x7440390", Offset = "0x743C390", VA = "0x7440390", Slot = "11")]
	public virtual void DestroyMesh()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x74403C8", Offset = "0x743C3C8", VA = "0x74403C8", Slot = "12")]
	public virtual void DestroyMeshEditor(MB2_EditorMethodsInterface editorMethods)
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x7440400", Offset = "0x743C400", VA = "0x7440400", Slot = "13")]
	public virtual int GetNumObjectsInCombined()
	{
		return default;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x744042C", Offset = "0x743C42C", VA = "0x744042C")]
	public MB3_TextureBaker GetTextureBaker()
	{
		return null;
	}

	[Token(Token = "0x600005F")]
	public abstract bool AddDeleteGameObjects(GameObject[] gos, GameObject[] deleteGOs, bool disableRendererInSource = true);

	[Token(Token = "0x6000060")]
	public abstract bool AddDeleteGameObjectsByID(GameObject[] gos, int[] deleteGOinstanceIDs, bool disableRendererInSource = true);

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x7440594", Offset = "0x743C594", VA = "0x7440594", Slot = "16")]
	public virtual bool Apply([Optional] MB3_MeshCombiner.GenerateUV2Delegate uv2GenerationMethod)
	{
		return default;
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x7440728", Offset = "0x743C728", VA = "0x7440728", Slot = "17")]
	public virtual bool Apply(bool triangles, bool vertices, bool normals, bool tangents, bool uvs, bool uv2, bool uv3, bool uv4, bool colors, [Optional][DefaultParameterValue(false)] bool bones, [Optional][DefaultParameterValue(false)] bool blendShapesFlag, [Optional] MB3_MeshCombiner.GenerateUV2Delegate uv2GenerationMethod)
	{
		return default;
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x7440944", Offset = "0x743C944", VA = "0x7440944", Slot = "18")]
	public virtual bool CombinedMeshContains(GameObject go)
	{
		return default;
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x744097C", Offset = "0x743C97C", VA = "0x744097C", Slot = "19")]
	public virtual bool UpdateGameObjects(GameObject[] gos)
	{
		return default;
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x7440A78", Offset = "0x743CA78", VA = "0x7440A78", Slot = "20")]
	public virtual bool UpdateGameObjects(GameObject[] gos, bool updateBounds)
	{
		return default;
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x7440B74", Offset = "0x743CB74", VA = "0x7440B74", Slot = "21")]
	public virtual bool UpdateGameObjects(GameObject[] gos, bool recalcBounds, bool updateVertices, bool updateNormals, bool updateTangents, bool updateUV, bool updateUV1, bool updateUV2, bool updateColors, bool updateSkinningInfo)
	{
		return default;
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x7440C98", Offset = "0x743CC98", VA = "0x7440C98", Slot = "22")]
	public virtual bool UpdateGameObjects(GameObject[] gos, bool recalcBounds, bool updateVertices, bool updateNormals, bool updateTangents, bool updateUV, bool updateUV2, bool updateUV3, bool updateUV4, bool updateUV5, bool updateUV6, bool updateUV7, bool updateUV8, bool updateColors, bool updateSkinningInfo)
	{
		return default;
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x7440E08", Offset = "0x743CE08", VA = "0x7440E08", Slot = "23")]
	public virtual void UpdateSkinnedMeshApproximateBounds()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x7440E58", Offset = "0x743CE58", VA = "0x7440E58", Slot = "24")]
	public virtual void UpdateSkinnedMeshApproximateBoundsFromBones()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x7440EA8", Offset = "0x743CEA8", VA = "0x7440EA8", Slot = "25")]
	public virtual void UpdateSkinnedMeshApproximateBoundsFromBounds()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x7440EF8", Offset = "0x743CEF8", VA = "0x7440EF8", Slot = "26")]
	protected virtual bool _ValidateForUpdateSkinnedMeshBounds()
	{
		return default;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x743F8D0", Offset = "0x743B8D0", VA = "0x743F8D0")]
	protected MB3_MeshBakerCommon()
	{
	}
}
