using System.Collections.Generic;
using DigitalOpus.MB.Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200001D")]
public class MB3_MeshBakerGrouper : MonoBehaviour, MB_IMeshBakerSettingsHolder
{
	[Token(Token = "0x200001E")]
	public enum ClusterType
	{
		[Token(Token = "0x4000077")]
		none = 0,
		[Token(Token = "0x4000078")]
		grid = 1,
		[Token(Token = "0x4000079")]
		pie = 2,
		[Token(Token = "0x400007A")]
		agglomerative = 3
	}

	[Token(Token = "0x400006B")]
	[FieldOffset(Offset = "0x0")]
	public static readonly Color WHITE_TRANSP;

	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0x20")]
	public MB3_MeshBakerGrouperBehaviour grouper;

	[Token(Token = "0x400006D")]
	[FieldOffset(Offset = "0x28")]
	public ClusterType clusterType;

	[Token(Token = "0x400006E")]
	[FieldOffset(Offset = "0x30")]
	public Transform parentSceneObject;

	[Token(Token = "0x400006F")]
	[FieldOffset(Offset = "0x38")]
	public GrouperData data;

	[Token(Token = "0x4000070")]
	[FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public Bounds sourceObjectBounds;

	[Token(Token = "0x4000071")]
	[FieldOffset(Offset = "0x58")]
	public string prefabOptions_outputFolder;

	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0x60")]
	public bool prefabOptions_autoGeneratePrefabs;

	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0x61")]
	public bool prefabOptions_mergeOutputIntoSinglePrefab;

	[Token(Token = "0x4000074")]
	[FieldOffset(Offset = "0x68")]
	public MB3_MeshCombinerSettings meshBakerSettingsAsset;

	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0x70")]
	public MB3_MeshCombinerSettingsData meshBakerSettings;

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x74411A0", Offset = "0x743D1A0", VA = "0x74411A0", Slot = "4")]
	public MB_IMeshBakerSettings GetMeshBakerSettings()
	{
		return null;
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x7441254", Offset = "0x743D254", VA = "0x7441254", Slot = "5")]
	public void GetMeshBakerSettingsAsSerializedProperty(out string propertyName, out Object targetObj)
	{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MB3_MeshBakerGrouper.GetMeshBakerSettingsAsSerializedProperty RVA=0x7441254 Token=0x6000071");
}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x7441308", Offset = "0x743D308", VA = "0x7441308")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x7441394", Offset = "0x743D394", VA = "0x7441394")]
	public MB3_MeshBakerGrouperBehaviour CreateGrouper(ClusterType t)
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x74414A4", Offset = "0x743D4A4", VA = "0x74414A4")]
	public void DeleteAllChildMeshBakers()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x7441574", Offset = "0x743D574", VA = "0x7441574")]
	public List<MB3_MeshBakerCommon> GenerateMeshBakers()
	{
		return null;
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x7441A30", Offset = "0x743DA30", VA = "0x7441A30")]
	public MB3_MeshBakerGrouper()
	{
	}
}
