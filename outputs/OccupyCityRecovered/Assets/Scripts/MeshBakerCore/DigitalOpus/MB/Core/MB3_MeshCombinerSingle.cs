using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace DigitalOpus.MB.Core
{
	[Serializable]
	[Token(Token = "0x2000054")]
	public class MB3_MeshCombinerSingle : MB3_MeshCombiner
	{
		[Token(Token = "0x2000055")]
		internal class MB_MeshCombinerSingle_BlendShapeProcessor
		{
			[Token(Token = "0x40001A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private MB3_MeshCombinerSingle combiner;

			[Token(Token = "0x40001A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private MBBlendShape[] nblendShapes;

			[Token(Token = "0x40001AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private bool _disposed;

			[Token(Token = "0x600026F")]
			[Address(RVA = "0x7459FC8", Offset = "0x7455FC8", VA = "0x7459FC8")]
			protected void Dispose(bool disposing)
			{
			}

			[Token(Token = "0x6000270")]
			[Address(RVA = "0x744F8D8", Offset = "0x744B8D8", VA = "0x744F8D8")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000271")]
			[Address(RVA = "0x7453134", Offset = "0x744F134", VA = "0x7453134")]
			public MB_MeshCombinerSingle_BlendShapeProcessor(MB3_MeshCombinerSingle cm)
			{
			}

			[Token(Token = "0x6000272")]
			[Address(RVA = "0x7459FE8", Offset = "0x7455FE8", VA = "0x7459FE8")]
			public static MBBlendShape[] GetBlendShapes(Mesh m, GameObject gameObject, Dictionary<int, MeshChannels> meshID2MeshChannels)
			{
				return null;
			}

			[Token(Token = "0x6000273")]
			[Address(RVA = "0x745A490", Offset = "0x7456490", VA = "0x745A490")]
			internal void ApplyBlendShapeFramesToMeshAndBuildMap(int newVertCount)
			{
			}

			[Token(Token = "0x6000274")]
			[Address(RVA = "0x745AD30", Offset = "0x7456D30", VA = "0x745AD30")]
			public void AllocateBlendShapeArrayIfNecessary(int nBlendShapeSize)
			{
			}

			[Token(Token = "0x6000275")]
			[Address(RVA = "0x745AE10", Offset = "0x7456E10", VA = "0x745AE10")]
			public void AssignNewBlendShapesToCombinerIfNecessary()
			{
			}

			[Token(Token = "0x6000276")]
			[Address(RVA = "0x745AED8", Offset = "0x7456ED8", VA = "0x745AED8")]
			public void CopyBlendShapesInCurrentMeshIfNecessary(ref int targBlendShapeIdx, MB_DynamicGameObject dgo)
			{
			}

			[Token(Token = "0x6000277")]
			[Address(RVA = "0x745AFE0", Offset = "0x7456FE0", VA = "0x745AFE0")]
			public void CopyBlendShapesForNewMeshIfNecessary(ref int targBlendShapeIdx, MB_DynamicGameObject dgo, Mesh mesh, IMeshChannelsCacheTaggingInterface meshChannelCache)
			{
			}

			[Token(Token = "0x6000278")]
			[Address(RVA = "0x745A9E8", Offset = "0x74569E8", VA = "0x745A9E8")]
			private static string _ConvertBlendShapeNameToOutputName(string bs)
			{
				return null;
			}

			[Token(Token = "0x6000279")]
			[Address(RVA = "0x745B190", Offset = "0x7457190", VA = "0x745B190")]
			internal void ApplyBlendShapeFramesToMeshAndBuildMap_MergeBlendShapesWithTheSameName(int newVertCount)
			{
			}

			[Token(Token = "0x600027A")]
			[Address(RVA = "0x745AADC", Offset = "0x7456ADC", VA = "0x745AADC")]
			private static void _BuildSrcShape2CombinedMap(MB3_MeshCombinerSingle combiner, SerializableSourceBlendShape2Combined map, MBBlendShape[] bs)
			{
			}

			[Token(Token = "0x600027B")]
			[Address(RVA = "0x745AA2C", Offset = "0x7456A2C", VA = "0x745AA2C")]
			private static void _ZeroArray(Vector3[] arr, int idx, int length)
			{
			}
		}

		[Token(Token = "0x2000056")]
		public class MB_MeshCombinerSingle_BoneProcessor : MB_IMeshCombinerSingle_BoneProcessor, IDisposable
		{
			[Token(Token = "0x40001AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private MB3_MeshCombinerSingle combiner;

			[Token(Token = "0x40001AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private List<MB_DynamicGameObject>[] boneIdx2dgoMap;

			[Token(Token = "0x40001AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private HashSet<int> boneIdxsToDelete;

			[Token(Token = "0x40001AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private HashSet<BoneAndBindpose> bonesToAdd;

			[Token(Token = "0x40001AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Dictionary<BoneAndBindpose, int> boneAndBindPose2idx;

			[Token(Token = "0x40001B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Transform[] oldBonesPreviousBake;

			[Token(Token = "0x40001B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Matrix4x4[] oldBindPosesPreviousBake;

			[Token(Token = "0x40001B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Transform[] nbones;

			[Token(Token = "0x40001B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Matrix4x4[] nbindPoses;

			[Token(Token = "0x40001B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private BoneWeight[] nboneWeights;

			[Token(Token = "0x40001B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private BoneWeight[] boneWeights;

			[Token(Token = "0x40001B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private int _newBonesStartAtIdx;

			[Token(Token = "0x40001B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			private bool _disposed;

			[Token(Token = "0x40001B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
			private bool _didSetup;

			[Token(Token = "0x600027C")]
			[Address(RVA = "0x745BD04", Offset = "0x7457D04", VA = "0x745BD04")]
			protected void Dispose(bool disposing)
			{
			}

			[Token(Token = "0x600027D")]
			[Address(RVA = "0x745BD30", Offset = "0x7457D30", VA = "0x745BD30", Slot = "21")]
			public void Dispose()
			{
			}

			[Token(Token = "0x600027E")]
			[Address(RVA = "0x745BD58", Offset = "0x7457D58", VA = "0x745BD58", Slot = "10")]
			public int GetNewBonesSize()
			{
				return default;
			}

			[Token(Token = "0x600027F")]
			[Address(RVA = "0x7459150", Offset = "0x7455150", VA = "0x7459150")]
			public MB_MeshCombinerSingle_BoneProcessor(MB3_MeshCombinerSingle cm)
			{
			}

			[Token(Token = "0x6000280")]
			[Address(RVA = "0x745BD70", Offset = "0x7457D70", VA = "0x745BD70")]
			public HashSet<BoneAndBindpose> GetBonesToAdd()
			{
				return null;
			}

			[Token(Token = "0x6000281")]
			[Address(RVA = "0x745BD78", Offset = "0x7457D78", VA = "0x745BD78")]
			public int GetNumBonesToDelete()
			{
				return default;
			}

			[Token(Token = "0x6000282")]
			[Address(RVA = "0x745BDC0", Offset = "0x7457DC0", VA = "0x745BDC0", Slot = "7")]
			public void BuildBoneIdx2DGOMapIfNecessary(int[] _goToDelete)
			{
			}

			[Token(Token = "0x6000283")]
			[Address(RVA = "0x745C1B0", Offset = "0x74581B0", VA = "0x745C1B0", Slot = "11")]
			public void RemoveBonesForDgosWeAreDeleting(MB_DynamicGameObject dgo)
			{
			}

			[Token(Token = "0x6000284")]
			[Address(RVA = "0x745C2DC", Offset = "0x74582DC", VA = "0x745C2DC", Slot = "6")]
			public void AllocateAndSetupSMRDataStructures(List<MB_DynamicGameObject> toAddDGOs, List<MB_DynamicGameObject> mbDynamicObjectsInCombinedMesh, int newVertSize, IVertexAndTriangleProcessor vertexAndTriangleProcessor)
			{
			}

			[Token(Token = "0x6000285")]
			[Address(RVA = "0x745C6D0", Offset = "0x74586D0", VA = "0x745C6D0", Slot = "18")]
			public void UpdateGameObjects_ReadBoneWeightInfoFromCombinedMesh()
			{
			}

			[Token(Token = "0x6000286")]
			[Address(RVA = "0x745C5C4", Offset = "0x74585C4", VA = "0x745C5C4")]
			public int GetNewBonesLength()
			{
				return default;
			}

			[Token(Token = "0x6000287")]
			[Address(RVA = "0x745C46C", Offset = "0x745846C", VA = "0x745C46C")]
			internal void _CollectSkinningDataForDGOsInCombinedMesh(List<MB_DynamicGameObject> objsToAdd)
			{
			}

			[Token(Token = "0x6000288")]
			[Address(RVA = "0x745CBC4", Offset = "0x7458BC4", VA = "0x745CBC4")]
			public bool CollectBonesToAddForDGO(MB_DynamicGameObject dgo, Renderer r, bool noExtraBonesForMeshRenderers)
			{
				return default;
			}

			[Token(Token = "0x6000289")]
			[Address(RVA = "0x745BF78", Offset = "0x7457F78", VA = "0x745BF78")]
			private List<MB_DynamicGameObject>[] _buildBoneIdx2dgoMap()
			{
				return null;
			}

			[Token(Token = "0x600028A")]
			[Address(RVA = "0x745D720", Offset = "0x7459720", VA = "0x745D720", Slot = "8")]
			public void CopyBonesWeAreKeepingToNewBonesArrayAndAdjustBWIndexes(int totalDeleteVerts)
			{
			}

			[Token(Token = "0x600028B")]
			[Address(RVA = "0x745DB94", Offset = "0x7459B94", VA = "0x745DB94", Slot = "9")]
			public void InsertNewBonesIntoBonesArray()
			{
			}

			[Token(Token = "0x600028C")]
			[Address(RVA = "0x745DE7C", Offset = "0x7459E7C", VA = "0x745DE7C", Slot = "5")]
			public void AddBonesToNewBonesArrayAndAdjustBWIndexes1(MB_DynamicGameObject dgo, int vertsIdx)
			{
			}

			[Token(Token = "0x600028D")]
			[Address(RVA = "0x745E388", Offset = "0x745A388", VA = "0x745E388", Slot = "19")]
			public void UpdateGameObjects_UpdateBWIndexes(MB_DynamicGameObject dgo)
			{
			}

			[Token(Token = "0x600028E")]
			[Address(RVA = "0x745E6BC", Offset = "0x745A6BC", VA = "0x745E6BC", Slot = "14")]
			public void CopyVertsNormsTansToBuffers(MB_DynamicGameObject dgo, MB_IMeshBakerSettings settings, int vertsIdx, NativeSlice<Vector3> nnorms, NativeSlice<Vector4> ntangs, NativeSlice<Vector3> nverts, NativeSlice<Vector3> normals, NativeSlice<Vector4> tangents, NativeSlice<Vector3> verts)
			{
			}

			[Token(Token = "0x600028F")]
			[Address(RVA = "0x745E724", Offset = "0x745A724", VA = "0x745E724", Slot = "13")]
			public void CopyVertsNormsTansToBuffers(MB_DynamicGameObject dgo, MB_IMeshBakerSettings settings, int vertsIdx, Vector3[] nnorms, Vector4[] ntangs, Vector3[] nverts, Vector3[] normals, Vector4[] tangents, Vector3[] verts)
			{
			}

			[Token(Token = "0x6000290")]
			[Address(RVA = "0x745EF40", Offset = "0x745AF40", VA = "0x745EF40", Slot = "15")]
			public void DisposeOfTemporarySMRData()
			{
			}

			[Token(Token = "0x6000291")]
			[Address(RVA = "0x745EFBC", Offset = "0x745AFBC", VA = "0x745EFBC", Slot = "12")]
			public void CopyBoneWeightsFromMeshForDGOsInCombined(MB_DynamicGameObject dgo, int targVidx)
			{
			}

			[Token(Token = "0x6000292")]
			[Address(RVA = "0x745EFEC", Offset = "0x745AFEC", VA = "0x745EFEC", Slot = "16")]
			public void ApplySMRdataToMeshToBuffer()
			{
			}

			[Token(Token = "0x6000293")]
			[Address(RVA = "0x745EFF0", Offset = "0x745AFF0", VA = "0x745EFF0", Slot = "17")]
			public void ApplySMRdataToMesh(MB3_MeshCombinerSingle combiner, Mesh mesh)
			{
			}

			[Token(Token = "0x6000294")]
			[Address(RVA = "0x745F034", Offset = "0x745B034", VA = "0x745F034", Slot = "4")]
			public bool GetCachedSMRMeshData(MB_DynamicGameObject dgo)
			{
				return default;
			}

			[Token(Token = "0x6000295")]
			[Address(RVA = "0x745F03C", Offset = "0x745B03C", VA = "0x745F03C", Slot = "20")]
			public bool DB_CheckIntegrity()
			{
				return default;
			}
		}

		[Token(Token = "0x2000057")]
		public class MB_MeshCombinerSingle_BoneProcessorNewAPI : MB_IMeshCombinerSingle_BoneProcessor, IDisposable
		{
			[Token(Token = "0x40001B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private MB2_LogLevel LOG_LEVEL;

			[Token(Token = "0x40001BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private bool _initialized;

			[Token(Token = "0x40001BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			private bool _disposed;

			[Token(Token = "0x40001BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private MB3_MeshCombinerSingle combiner;

			[Token(Token = "0x40001BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private HashSet<BoneAndBindpose> bonesToAddAndInCombined;

			[Token(Token = "0x40001BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<BoneAndBindpose> masterList;

			[Token(Token = "0x40001BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Matrix4x4[] nBindPoses;

			[Token(Token = "0x40001C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Transform[] nbones;

			[Token(Token = "0x40001C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int boneWeightSize;

			[Token(Token = "0x40001C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private int targBoneWeightIdx;

			[Token(Token = "0x40001C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Dictionary<MB_DynamicGameObject, int> dgo2firstIdxInBoneWeightsArray;

			[Token(Token = "0x40001C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private NativeArray<byte> bonesPerVertex_nvarr;

			[Token(Token = "0x40001C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private NativeArray<BoneWeight1> boneWeight1s_nvarr;

			[Token(Token = "0x6000296")]
			[Address(RVA = "0x7459014", Offset = "0x7455014", VA = "0x7459014")]
			public MB_MeshCombinerSingle_BoneProcessorNewAPI(MB3_MeshCombinerSingle cm)
			{
			}

			[Token(Token = "0x6000297")]
			[Address(RVA = "0x745F4CC", Offset = "0x745B4CC", VA = "0x745F4CC", Slot = "10")]
			public int GetNewBonesSize()
			{
				return default;
			}

			[Token(Token = "0x6000298")]
			[Address(RVA = "0x745F514", Offset = "0x745B514", VA = "0x745F514", Slot = "7")]
			public void BuildBoneIdx2DGOMapIfNecessary(int[] _goToDelete)
			{
			}

			[Token(Token = "0x6000299")]
			[Address(RVA = "0x745F618", Offset = "0x745B618", VA = "0x745F618", Slot = "11")]
			public void RemoveBonesForDgosWeAreDeleting(MB_DynamicGameObject dgo)
			{
			}

			[Token(Token = "0x600029A")]
			[Address(RVA = "0x745F61C", Offset = "0x745B61C", VA = "0x745F61C", Slot = "4")]
			public bool GetCachedSMRMeshData(MB_DynamicGameObject dgo)
			{
				return default;
			}

			[Token(Token = "0x600029B")]
			[Address(RVA = "0x745FD38", Offset = "0x745BD38", VA = "0x745FD38", Slot = "6")]
			public void AllocateAndSetupSMRDataStructures(List<MB_DynamicGameObject> dgosToAdd, List<MB_DynamicGameObject> dgosInCombinedMesh, int newVertSize, IVertexAndTriangleProcessor vertexAndTriangleProcessor)
			{
			}

			[Token(Token = "0x600029C")]
			[Address(RVA = "0x7460DE0", Offset = "0x745CDE0", VA = "0x7460DE0", Slot = "18")]
			public void UpdateGameObjects_ReadBoneWeightInfoFromCombinedMesh()
			{
			}

			[Token(Token = "0x600029D")]
			[Address(RVA = "0x746111C", Offset = "0x745D11C", VA = "0x746111C", Slot = "12")]
			public void CopyBoneWeightsFromMeshForDGOsInCombined(MB_DynamicGameObject dgo, int targVidx)
			{
			}

			[Token(Token = "0x600029E")]
			[Address(RVA = "0x7461120", Offset = "0x745D120", VA = "0x7461120", Slot = "5")]
			public void AddBonesToNewBonesArrayAndAdjustBWIndexes1(MB_DynamicGameObject dgo, int firstVertexIdxForThisDGO)
			{
			}

			[Token(Token = "0x600029F")]
			[Address(RVA = "0x7461394", Offset = "0x745D394", VA = "0x7461394", Slot = "8")]
			public void CopyBonesWeAreKeepingToNewBonesArrayAndAdjustBWIndexes(int totalDeleteVerts)
			{
			}

			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x7461398", Offset = "0x745D398", VA = "0x7461398", Slot = "13")]
			public void CopyVertsNormsTansToBuffers(MB_DynamicGameObject dgo, MB_IMeshBakerSettings settings, int vertsIdx, Vector3[] nnorms, Vector4[] ntangs, Vector3[] nverts, Vector3[] normals, Vector4[] tangents, Vector3[] verts)
			{
			}

			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x7461400", Offset = "0x745D400", VA = "0x7461400", Slot = "14")]
			public void CopyVertsNormsTansToBuffers(MB_DynamicGameObject dgo, MB_IMeshBakerSettings settings, int vertsIdx, NativeSlice<Vector3> nnorms, NativeSlice<Vector4> ntangs, NativeSlice<Vector3> nverts, NativeSlice<Vector3> normals, NativeSlice<Vector4> tangents, NativeSlice<Vector3> verts)
			{
			}

			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x7461CCC", Offset = "0x745DCCC", VA = "0x7461CCC", Slot = "9")]
			public void InsertNewBonesIntoBonesArray()
			{
			}

			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x7461E70", Offset = "0x745DE70", VA = "0x7461E70", Slot = "16")]
			public void ApplySMRdataToMeshToBuffer()
			{
			}

			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x7461EF4", Offset = "0x745DEF4", VA = "0x7461EF4", Slot = "17")]
			public void ApplySMRdataToMesh(MB3_MeshCombinerSingle combiner, Mesh mesh)
			{
			}

			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x7461FB0", Offset = "0x745DFB0", VA = "0x7461FB0", Slot = "19")]
			public void UpdateGameObjects_UpdateBWIndexes(MB_DynamicGameObject dgo)
			{
			}

			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x74620AC", Offset = "0x745E0AC", VA = "0x74620AC")]
			protected void Dispose(bool disposing)
			{
			}

			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x7462158", Offset = "0x745E158", VA = "0x7462158", Slot = "21")]
			public void Dispose()
			{
			}

			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x7462160", Offset = "0x745E160", VA = "0x7462160", Slot = "15")]
			public void DisposeOfTemporarySMRData()
			{
			}

			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x74609D4", Offset = "0x745C9D4", VA = "0x74609D4")]
			internal void _AllocateNewArraysForCombinedMesh(int newVertSize, IVertexAndTriangleProcessor vertexAndTriangleProcessor)
			{
			}

			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x746229C", Offset = "0x745E29C", VA = "0x746229C")]
			private bool _CollectBonesToAddForDGO_Pass2(MB_DynamicGameObject dgo, bool noExtraBonesForMeshRenderers)
			{
				return default;
			}

			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x746016C", Offset = "0x745C16C", VA = "0x746016C")]
			private int _BuildMasterBonesArray(List<MB_DynamicGameObject> dgosToAdd, List<MB_DynamicGameObject> dgosInCombinedMesh)
			{
				return default;
			}

			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x745FE98", Offset = "0x745BE98", VA = "0x745FE98")]
			internal void _CollectSkinningDataForDGOsInCombinedMesh(List<MB_DynamicGameObject> dgosAdding, List<MB_DynamicGameObject> dgosInCombinedMesh, MeshChannelsCache_NativeArray meshChannelsCache)
			{
			}

			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x74626B0", Offset = "0x745E6B0", VA = "0x74626B0", Slot = "20")]
			public bool DB_CheckIntegrity()
			{
				return default;
			}
		}

		[Token(Token = "0x2000058")]
		public enum MeshCreationConditions
		{
			[Token(Token = "0x40001C7")]
			NoMesh = 0,
			[Token(Token = "0x40001C8")]
			CreatedInEditor = 1,
			[Token(Token = "0x40001C9")]
			CreatedAtRuntime = 2,
			[Token(Token = "0x40001CA")]
			AssignedByUser = 3
		}

		[Serializable]
		[Token(Token = "0x2000059")]
		public struct BufferDataFromPreviousBake
		{
			[Token(Token = "0x40001CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int numVertsBaked;

			[Token(Token = "0x40001CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Vector3 meshVerticesShift;

			[Token(Token = "0x40001CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool meshVerticiesWereShifted;
		}

		[Serializable]
		[Token(Token = "0x200005A")]
		public class SerializableIntArray
		{
			[Token(Token = "0x40001CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			public int[] data;

			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x7450CBC", Offset = "0x744CCBC", VA = "0x7450CBC")]
			public SerializableIntArray()
			{
			}

			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x74626B8", Offset = "0x745E6B8", VA = "0x74626B8")]
			public SerializableIntArray(int len)
			{
			}
		}

		[Token(Token = "0x200005B")]
		public struct BoneWeightDataForMesh
		{
			[Token(Token = "0x40001CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private bool _disposed;

			[Token(Token = "0x40001D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool initialized;

			[Token(Token = "0x40001D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public bool weMustDispose;

			[Token(Token = "0x40001D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public NativeArray<byte> bonesPerVertex;

			[Token(Token = "0x40001D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public NativeArray<BoneWeight1> boneWeights;

			[Token(Token = "0x40001D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool[] UsedBoneIdxsInSrcMesh;

			[Token(Token = "0x40001D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int numUsedbones;

			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x7462294", Offset = "0x745E294", VA = "0x7462294")]
			internal void Dispose()
			{
			}

			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x7462720", Offset = "0x745E720", VA = "0x7462720")]
			private void Dispose(bool disposing)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200005C")]
		public class MB_DynamicGameObject : IComparable<MB_DynamicGameObject>
		{
			[Token(Token = "0x40001D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int instanceID;

			[Token(Token = "0x40001D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameObject gameObject;

			[Token(Token = "0x40001D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string name;

			[Token(Token = "0x40001D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int vertIdx;

			[Token(Token = "0x40001DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int blendShapeIdx;

			[Token(Token = "0x40001DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int numVerts;

			[Token(Token = "0x40001DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int numBlendShapes;

			[Token(Token = "0x40001DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int numBoneWeights;

			[Token(Token = "0x40001DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public bool isSkinnedMeshWithBones;

			[Token(Token = "0x40001DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public int[] indexesOfBonesUsed;

			[Token(Token = "0x40001E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public int lightmapIndex;

			[Token(Token = "0x40001E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public Vector4 lightmapTilingOffset;

			[Token(Token = "0x40001E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 meshSize;

			[Token(Token = "0x40001E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public bool show;

			[Token(Token = "0x40001E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
			public bool invertTriangles;

			[Token(Token = "0x40001E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public int[] submeshTriIdxs;

			[Token(Token = "0x40001E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public int[] submeshNumTris;

			[Token(Token = "0x40001E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public int[] targetSubmeshIdxs;

			[Token(Token = "0x40001E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public Rect[] uvRects;

			[Token(Token = "0x40001E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Rect[] encapsulatingRect;

			[Token(Token = "0x40001EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public Rect[] sourceMaterialTiling;

			[Token(Token = "0x40001EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public Rect[] obUVRects;

			[Token(Token = "0x40001EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public int[] textureArraySliceIdx;

			[Token(Token = "0x40001ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public Material[] sourceSharedMaterials;

			[NonSerialized]
			[Token(Token = "0x40001EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			internal bool _initialized;

			[NonSerialized]
			[Token(Token = "0x40001EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
			internal bool _beingDeleted;

			[NonSerialized]
			[Token(Token = "0x40001F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			internal Mesh _mesh;

			[NonSerialized]
			[Token(Token = "0x40001F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			internal Renderer _renderer;

			[NonSerialized]
			[Token(Token = "0x40001F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			internal SerializableIntArray[] _tmpSubmeshTris;

			[NonSerialized]
			[Token(Token = "0x40001F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			internal Transform[] _tmpSMR_CachedBones;

			[NonSerialized]
			[Token(Token = "0x40001F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			internal List<Matrix4x4> _tmpSMR_CachedBindposes;

			[NonSerialized]
			[Token(Token = "0x40001F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			internal BoneAndBindpose[] _tmpSMR_CachedBoneAndBindPose;

			[NonSerialized]
			[Token(Token = "0x40001F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			internal int[] _tmpSMR_srcMeshBoneIdx2masterListBoneIdx;

			[NonSerialized]
			[Token(Token = "0x40001F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			internal BoneWeight[] _tmpSMR_CachedBoneWeights;

			[NonSerialized]
			[Token(Token = "0x40001F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			internal BoneWeightDataForMesh _tmpSMR_CachedBoneWeightData;

			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x7454EB8", Offset = "0x7450EB8", VA = "0x7454EB8")]
			public bool Initialize(bool beingDeleted)
			{
				return default;
			}

			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x7454D7C", Offset = "0x7450D7C", VA = "0x7454D7C")]
			public bool InitializeNew(bool beingDeleted, GameObject go)
			{
				return default;
			}

			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x74627DC", Offset = "0x745E7DC", VA = "0x74627DC")]
			public void UnInitialize()
			{
			}

			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x74627E8", Offset = "0x745E7E8", VA = "0x74627E8", Slot = "4")]
			public int CompareTo(MB_DynamicGameObject b)
			{
				return default;
			}

			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x7454CC8", Offset = "0x7450CC8", VA = "0x7454CC8")]
			public MB_DynamicGameObject()
			{
			}
		}

		[Token(Token = "0x200005D")]
		public class MeshChannels : IDisposable
		{
			[Token(Token = "0x40001F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private bool _disposed;

			[Token(Token = "0x40001FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3[] vertices;

			[Token(Token = "0x40001FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3[] normals;

			[Token(Token = "0x40001FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector4[] tangents;

			[Token(Token = "0x40001FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2[] uv0raw;

			[Token(Token = "0x40001FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector2[] uv0modified;

			[Token(Token = "0x40001FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Vector2[] uv2raw;

			[Token(Token = "0x4000200")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector2[] uv2modified;

			[Token(Token = "0x4000201")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector2[] uv3;

			[Token(Token = "0x4000202")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector2[] uv4;

			[Token(Token = "0x4000203")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector2[] uv5;

			[Token(Token = "0x4000204")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Vector2[] uv6;

			[Token(Token = "0x4000205")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Vector2[] uv7;

			[Token(Token = "0x4000206")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Vector2[] uv8;

			[Token(Token = "0x4000207")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public Color[] colors;

			[Token(Token = "0x4000208")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public BoneWeight[] boneWeights;

			[Token(Token = "0x4000209")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public List<Matrix4x4> bindPoses;

			[Token(Token = "0x400020A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public int[] triangles;

			[Token(Token = "0x400020B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public MBBlendShape[] blendShapes;

			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x7462808", Offset = "0x745E808", VA = "0x7462808", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x7462818", Offset = "0x745E818", VA = "0x7462818")]
			public bool IsDisposed()
			{
				return default;
			}

			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x7462820", Offset = "0x745E820", VA = "0x7462820", Slot = "5")]
			protected virtual void Dispose(bool disposing)
			{
			}

			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x745A400", Offset = "0x7456400", VA = "0x745A400")]
			public MeshChannels()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200005E")]
		public class MBBlendShapeFrame
		{
			[Token(Token = "0x400020C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float frameWeight;

			[Token(Token = "0x400020D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3[] vertices;

			[Token(Token = "0x400020E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3[] normals;

			[Token(Token = "0x400020F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3[] tangents;

			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x745A488", Offset = "0x7456488", VA = "0x745A488")]
			public MBBlendShapeFrame()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200005F")]
		public class MBBlendShape
		{
			[Token(Token = "0x4000210")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject gameObject;

			[Token(Token = "0x4000211")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x4000212")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int indexInSource;

			[Token(Token = "0x4000213")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MBBlendShapeFrame[] frames;

			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x745A480", Offset = "0x7456480", VA = "0x745A480")]
			public MBBlendShape()
			{
			}
		}

		[Token(Token = "0x2000060")]
		public struct BoneAndBindpose
		{
			[Token(Token = "0x4000214")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform bone;

			[Token(Token = "0x4000215")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Matrix4x4 bindPose;

			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x745C190", Offset = "0x7458190", VA = "0x745C190")]
			public BoneAndBindpose(Transform t, Matrix4x4 bp)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MB3_MeshCombinerSingle.BoneAndBindpose..ctor RVA=0x745C190 Token=0x60002BD");
}

			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x746284C", Offset = "0x745E84C", VA = "0x746284C", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default;
			}

			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x746299C", Offset = "0x745E99C", VA = "0x746299C", Slot = "2")]
			public override int GetHashCode()
			{
				return default;
			}
		}

		[Token(Token = "0x2000061")]
		public interface IMeshChannelsCacheTaggingInterface
		{
			[Token(Token = "0x60002C0")]
			void Dispose();

			[Token(Token = "0x60002C1")]
			bool HasCollectedMeshData();

			[Token(Token = "0x60002C2")]
			void CollectChannelDataForAllMeshesInList(List<MB_DynamicGameObject> toUpdateDGOs, List<MB_DynamicGameObject> toAddDGOs, MB_MeshVertexChannelFlags newChannels, MB_RenderType renderType, bool doBlendShapes);

			[Token(Token = "0x60002C3")]
			MBBlendShape[] GetBlendShapes(Mesh mesh, int instanceID, GameObject gameObject);

			[Token(Token = "0x60002C4")]
			bool hasOutOfBoundsUVs(Mesh m, ref MB_Utility.MeshAnalysisResult mar, int submeshIdx);
		}

		[Token(Token = "0x2000062")]
		public class MeshChannelsCache : IDisposable, IMeshChannelsCacheTaggingInterface
		{
			[Token(Token = "0x4000216")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private MB2_LogLevel LOG_LEVEL;

			[Token(Token = "0x4000217")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private MB2_LightmapOptions lightmapOption;

			[Token(Token = "0x4000218")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			protected Dictionary<int, MeshChannels> meshID2MeshChannels;

			[Token(Token = "0x4000219")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private bool _collectedMeshData;

			[Token(Token = "0x400021A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
			private bool _disposed;

			[Token(Token = "0x400021B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Vector2 _HALF_UV;

			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x74592AC", Offset = "0x74552AC", VA = "0x74592AC")]
			public MeshChannelsCache(MB2_LogLevel ll, MB2_LightmapOptions lo)
			{
			}

			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x7462A14", Offset = "0x745EA14", VA = "0x7462A14", Slot = "5")]
			public void Dispose()
			{
			}

			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x7462A24", Offset = "0x745EA24", VA = "0x7462A24", Slot = "10")]
			protected virtual void Dispose(bool disposing)
			{
			}

			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x7462BA8", Offset = "0x745EBA8", VA = "0x7462BA8", Slot = "6")]
			public bool HasCollectedMeshData()
			{
				return default;
			}

			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x7462BB0", Offset = "0x745EBB0", VA = "0x7462BB0", Slot = "9")]
			public bool hasOutOfBoundsUVs(Mesh m, ref MB_Utility.MeshAnalysisResult mar, int submeshIdx)
			{
				return default;
			}

			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x7462C70", Offset = "0x745EC70", VA = "0x7462C70")]
			internal Vector3[] GetVertices(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x7462D70", Offset = "0x745ED70", VA = "0x7462D70")]
			internal Vector3[] GetNormals(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x7462DFC", Offset = "0x745EDFC", VA = "0x7462DFC")]
			internal Vector4[] GetTangents(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x7462BE4", Offset = "0x745EBE4", VA = "0x7462BE4")]
			internal Vector2[] GetUv0Raw(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x7462E88", Offset = "0x745EE88", VA = "0x7462E88")]
			internal Vector2[] GetUv0Modified(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x7462F14", Offset = "0x745EF14", VA = "0x7462F14")]
			internal Vector2[] GetUv2Modified(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x7462FA0", Offset = "0x745EFA0", VA = "0x7462FA0")]
			internal Vector2[] GetUVChannel(int channel, Mesh m)
			{
				return null;
			}

			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x746315C", Offset = "0x745F15C", VA = "0x746315C")]
			internal Color[] GetColors(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x74631E8", Offset = "0x745F1E8", VA = "0x74631E8", Slot = "7")]
			public void CollectChannelDataForAllMeshesInList(List<MB_DynamicGameObject> toUpdateDGOs, List<MB_DynamicGameObject> toAddDGOs, MB_MeshVertexChannelFlags newChannels, MB_RenderType renderType, bool doBlendShapes)
			{
			}

			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x745D564", Offset = "0x7459564", VA = "0x745D564")]
			internal List<Matrix4x4> GetBindposes(Renderer r, out bool isSkinnedMeshWithBones)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MB3_MeshCombinerSingle.MeshChannelsCache.GetBindposes RVA=0x745D564 Token=0x60002D3");
}

			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x745D680", Offset = "0x7459680", VA = "0x745D680")]
			internal BoneWeight[] GetBoneWeights(Renderer r, int numVertsInMeshBeingAdded, bool isSkinnedMeshWithBones)
			{
				return null;
			}

			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x74645BC", Offset = "0x74605BC", VA = "0x74645BC", Slot = "8")]
			public MBBlendShape[] GetBlendShapes(Mesh m, int gameObjectID, GameObject gameObject)
			{
				return null;
			}

			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x7463DF0", Offset = "0x745FDF0", VA = "0x7463DF0")]
			private Color[] _getMeshColors(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x7463950", Offset = "0x745F950", VA = "0x7463950")]
			private Vector3[] _getMeshNormals(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x7463B74", Offset = "0x745FB74", VA = "0x7463B74")]
			private Vector4[] _getMeshTangents(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x74637C0", Offset = "0x745F7C0", VA = "0x74637C0")]
			private Vector2[] _getMeshUVs(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x7463880", Offset = "0x745F880", VA = "0x7463880")]
			private Vector2[] _getMeshUV2s(Mesh m, ref Vector2[] uv2modified)
			{
				return null;
			}

			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x7464010", Offset = "0x7460010", VA = "0x7464010")]
			private static void _getBindPoses(Renderer r, List<Matrix4x4> poses, out bool isSkinnedMeshWithBones)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MB3_MeshCombinerSingle.MeshChannelsCache._getBindPoses RVA=0x7464010 Token=0x60002DB");
}

			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x746435C", Offset = "0x746035C", VA = "0x746435C")]
			private static BoneWeight[] _getBoneWeights(Renderer r, int numVertsInMeshBeingAdded, bool isSkinnedMeshWithBones)
			{
				return null;
			}

			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x7464768", Offset = "0x7460768", VA = "0x7464768")]
			private void _generateTangents(int[] triangles, Vector3[] verts, Vector2[] uvs, Vector3[] normals, Vector4[] outTangents)
			{
			}
		}

		[Token(Token = "0x2000063")]
		public interface IVertexAndTriangleProcessor : IDisposable
		{
			[Token(Token = "0x1700006B")]
			MB_MeshVertexChannelFlags channels
			{
				[Token(Token = "0x60002DE")]
				get;
			}

			[Token(Token = "0x60002DF")]
			bool IsInitialized();

			[Token(Token = "0x60002E0")]
			bool IsDisposed();

			[Token(Token = "0x60002E1")]
			void Init(MB3_MeshCombinerSingle combiner, MB_MeshVertexChannelFlags newChannels, int vertexCount, int[] newSubmeshTrisSize, int uvChannelWithExtraParameter, IMeshChannelsCacheTaggingInterface meshChannelsCache, bool loadDataFromCombinedMesh, MB2_LogLevel logLevel);

			[Token(Token = "0x60002E2")]
			void InitShowHide(MB3_MeshCombinerSingle combiner);

			[Token(Token = "0x60002E3")]
			void InitFromMeshCombiner(MB3_MeshCombinerSingle combiner, MB_MeshVertexChannelFlags newChannels, int uvChannelWithExtraParameter);

			[Token(Token = "0x60002E4")]
			int GetVertexCount();

			[Token(Token = "0x60002E5")]
			int GetSubmeshCount();

			[Token(Token = "0x60002E6")]
			void TransferOwnershipOfSerializableBuffersToCombiner(MB3_MeshCombinerSingle c, MB_MeshVertexChannelFlags channelsToTransfer, BufferDataFromPreviousBake serializableBufferData);

			[Token(Token = "0x60002E7")]
			void CopyArraysFromPreviousBakeBuffersToNewBuffers(MB_DynamicGameObject dgo, ref IVertexAndTriangleProcessor iOldBuffers, int destStartVertIdx, int triangleIdxAdjustment, int[] targSubmeshTidx, MB2_LogLevel LOG_LEVEL);

			[Token(Token = "0x60002E8")]
			void CopyFromDGOMeshToBuffers(MB_DynamicGameObject dgo, int destStartVertsIdx, MB_MeshVertexChannelFlags channelsToUpdate, bool updateTris, bool updateBWdata, MB_IMeshBakerSettings settings, MB_IMeshCombinerSingle_BoneProcessor boneProcessor, int[] targSubmeshTidx, MB2_TextureBakeResults textureBakeResults, UVAdjuster_Atlas uvAdjuster, MB2_LogLevel LOG_LEVEL, IMeshChannelsCacheTaggingInterface meshChannelCache);

			[Token(Token = "0x60002E9")]
			void AssignBuffersToMesh(Mesh mesh, MB_IMeshBakerSettings settings, MB2_TextureBakeResults textureBakeResults, MB_MeshVertexChannelFlags channelsToWriteToMesh, bool doWriteTrisToMesh, IAssignToMeshCustomizer assignToMeshCustomizer, List<MB_DynamicGameObject> mbDynamicObjectsInCombinedMesh, out BufferDataFromPreviousBake serializableBufferData, out SerializableIntArray[] submeshTrisToUse, out int numNonZeroLengthSubmeshes);

			[Token(Token = "0x60002EA")]
			void AssignTriangleDataForSubmeshes(Mesh mesh, List<MB_DynamicGameObject> mbDynamicObjectsInCombinedMesh, ref BufferDataFromPreviousBake serializableBufferData, out SerializableIntArray[] submeshTrisToUse, out int numNonZeroLengthSubmeshes);

			[Token(Token = "0x60002EB")]
			void AssignTriangleDataForSubmeshes_ShowHide(Mesh mesh, List<MB_DynamicGameObject> mbDynamicObjectsInCombinedMesh, ref BufferDataFromPreviousBake serializableBufferData, out SerializableIntArray[] submeshTrisToUse, out int numNonZeroLengthSubmeshes);

			[Token(Token = "0x60002EC")]
			void CopyUV2unchangedToSeparateRects(List<MB_DynamicGameObject> mbDynamicObjectsInCombinedMesh, float uv2UnwrappingParamsPackMargin);

			[Token(Token = "0x60002ED")]
			int[] GetTriangleSizes();
		}

		[Token(Token = "0x2000064")]
		public class MB_MeshCombinerSingle_SubCombiner
		{
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x7464CCC", Offset = "0x7460CCC", VA = "0x7464CCC")]
			public static void instance2Combined_MapAdd(ref Dictionary<GameObject, MB_DynamicGameObject> _instance2combined_map, GameObject gameObjectID, MB_DynamicGameObject dgo)
			{
			}

			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x7464D34", Offset = "0x7460D34", VA = "0x7464D34")]
			public static void instance2Combined_MapRemove(ref Dictionary<GameObject, MB_DynamicGameObject> _instance2combined_map, GameObject gameObjectID)
			{
			}

			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x7464D8C", Offset = "0x7460D8C", VA = "0x7464D8C")]
			internal static bool _ShowHideGameObjects(MB3_MeshCombinerSingle c)
			{
				return default;
			}

			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x7464E40", Offset = "0x7460E40", VA = "0x7464E40")]
			internal static bool _AddToCombined(MB3_MeshCombinerSingle c, MB_MeshVertexChannelFlags newChannels, int totalAddVerts, int totalDeleteVerts, int numResultMats, int totalAddBlendShapes, int totalDeleteBlendShapes, int[] totalAddSubmeshTris, int[] totalDeleteSubmeshTris, int[] _goToDelete, List<MB_DynamicGameObject> toAddDGOs, GameObject[] _goToAdd, UVAdjuster_Atlas uvAdjuster, ref IVertexAndTriangleProcessor oldMeshData, Stopwatch sw)
			{
				return default;
			}

			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x7466DF0", Offset = "0x7462DF0", VA = "0x7466DF0")]
			public static bool _UpdateGameObjects(MB3_MeshCombinerSingle combiner, List<MB_DynamicGameObject> dgosToUpdate, MB_MeshVertexChannelFlags newChannels, bool updateVertices, bool updateNormals, bool updateTangents, bool updateUV, bool updateUV2, bool updateUV3, bool updateUV4, bool updateUV5, bool updateUV6, bool updateUV7, bool updateUV8, bool updateColors, bool updateSkinningInfo, UVAdjuster_Atlas uVAdjuster, MB2_LogLevel LOG_LEVEL)
			{
				return default;
			}

			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x746766C", Offset = "0x746366C", VA = "0x746766C")]
			public static bool Apply(MB3_MeshCombinerSingle combiner, GenerateUV2Delegate uv2GenerationMethod)
			{
				return default;
			}

			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x7469CC4", Offset = "0x7465CC4", VA = "0x7469CC4")]
			public static bool Apply(MB3_MeshCombinerSingle combiner, bool triangles, bool vertices, bool normals, bool tangents, bool uvs, bool uv2, bool uv3, bool uv4, bool colors, [Optional][DefaultParameterValue(false)] bool bones, [Optional][DefaultParameterValue(false)] bool blendShapesFlag, [Optional] GenerateUV2Delegate uv2GenerationMethod)
			{
				return default;
			}

			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x7467C78", Offset = "0x7463C78", VA = "0x7467C78")]
			internal static bool Apply(MB3_MeshCombinerSingle combiner, bool triangles, bool vertices, bool normals, bool tangents, bool uvs, bool uv2, bool uv3, bool uv4, bool uv5, bool uv6, bool uv7, bool uv8, bool colors, [Optional][DefaultParameterValue(false)] bool bones, [Optional][DefaultParameterValue(false)] bool blendShapesFlag, [Optional][DefaultParameterValue(false)] bool suppressClearMesh, [Optional] GenerateUV2Delegate uv2GenerationMethod)
			{
				return default;
			}

			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x7469D48", Offset = "0x7465D48", VA = "0x7469D48")]
			public static bool ApplyShowHide(MB3_MeshCombinerSingle combiner)
			{
				return default;
			}

			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x746A3C4", Offset = "0x74663C4", VA = "0x746A3C4")]
			public MB_MeshCombinerSingle_SubCombiner()
			{
			}
		}

		[Token(Token = "0x2000065")]
		public class UVAdjuster_Atlas
		{
			[Token(Token = "0x400021C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private MB2_TextureBakeResults textureBakeResults;

			[Token(Token = "0x400021D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private MB2_LogLevel LOG_LEVEL;

			[Token(Token = "0x400021E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int[] numTimesMatAppearsInAtlas;

			[Token(Token = "0x400021F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private MB_MaterialAndUVRect[] matsAndSrcUVRect;

			[Token(Token = "0x4000220")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private bool compareNamesWhenComparingMaterials;

			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x746A3CC", Offset = "0x74663CC", VA = "0x746A3CC")]
			public UVAdjuster_Atlas(MB2_TextureBakeResults tbr, MB2_LogLevel ll)
			{
			}

			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x746A66C", Offset = "0x746666C", VA = "0x746A66C")]
			public bool MapSharedMaterialsToAtlasRects(Material[] sharedMaterials, bool checkTargetSubmeshIdxsFromPreviousBake, Mesh m, IMeshChannelsCacheTaggingInterface meshChannelsCache, Dictionary<int, MB_Utility.MeshAnalysisResult[]> meshAnalysisResultsCache, OrderedDictionary sourceMats2submeshIdx_map, GameObject go, MB_DynamicGameObject dgoOut)
			{
				return default;
			}

			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x746AF24", Offset = "0x7466F24", VA = "0x746AF24")]
			public bool IsSameMaterialInTextureBakeResult(Material a, Material b)
			{
				return default;
			}

			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x746B034", Offset = "0x7467034", VA = "0x746B034")]
			public bool TryMapMaterialToUVRect(Material mat, Mesh m, int submeshIdx, int idxInResultMats, IMeshChannelsCacheTaggingInterface meshChannelCache, Dictionary<int, MB_Utility.MeshAnalysisResult[]> meshAnalysisCache, out MB_TextureTilingTreatment tilingTreatment, out Rect rectInAtlas, out Rect encapsulatingRectOut, out Rect sourceMaterialTilingOut, out int sliceIdx, ref string errorMsg, MB2_LogLevel logLevel)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MB3_MeshCombinerSingle.UVAdjuster_Atlas.TryMapMaterialToUVRect RVA=0x746B034 Token=0x60002FB");
}
		}

		[Token(Token = "0x2000066")]
		public struct VertexAndTriangleProcessor : IVertexAndTriangleProcessor, IDisposable
		{
			[Token(Token = "0x4000221")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private bool _disposed;

			[Token(Token = "0x4000222")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			private bool _isInitialized;

			[Token(Token = "0x4000223")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal MB2_LogLevel LOG_LEVEL;

			[Token(Token = "0x4000225")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Vector3[] verticies;

			[Token(Token = "0x4000226")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3[] normals;

			[Token(Token = "0x4000227")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector4[] tangents;

			[Token(Token = "0x4000228")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Color[] colors;

			[Token(Token = "0x4000229")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector2[] uv0s;

			[Token(Token = "0x400022A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float[] uvsSliceIdx;

			[Token(Token = "0x400022B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector2[] uv2s;

			[Token(Token = "0x400022C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector2[] uv3s;

			[Token(Token = "0x400022D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Vector2[] uv4s;

			[Token(Token = "0x400022E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Vector2[] uv5s;

			[Token(Token = "0x400022F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Vector2[] uv6s;

			[Token(Token = "0x4000230")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Vector2[] uv7s;

			[Token(Token = "0x4000231")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private Vector2[] uv8s;

			[Token(Token = "0x4000232")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private SerializableIntArray[] submeshTris;

			[Token(Token = "0x1700006C")]
			public MB_MeshVertexChannelFlags channels
			{
				[Token(Token = "0x60002FC")]
				[Address(RVA = "0x746BA00", Offset = "0x7467A00", VA = "0x746BA00", Slot = "4")]
				[CompilerGenerated]
				readonly get
				{
					return default;
				}
				[Token(Token = "0x60002FD")]
				[Address(RVA = "0x746BA08", Offset = "0x7467A08", VA = "0x746BA08")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x746BA10", Offset = "0x7467A10", VA = "0x746BA10", Slot = "20")]
			public void Dispose()
			{
			}

			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x746BA40", Offset = "0x7467A40", VA = "0x746BA40", Slot = "5")]
			public bool IsInitialized()
			{
				return default;
			}

			[Token(Token = "0x6000300")]
			[Address(RVA = "0x746BA48", Offset = "0x7467A48", VA = "0x746BA48", Slot = "6")]
			public bool IsDisposed()
			{
				return default;
			}

			[Token(Token = "0x6000301")]
			[Address(RVA = "0x746BA50", Offset = "0x7467A50", VA = "0x746BA50", Slot = "7")]
			public void Init(MB3_MeshCombinerSingle combiner, MB_MeshVertexChannelFlags newChannels, int vertexCount, int[] newSubmeshTrisSize, int uvChannelWithExtraParameter, IMeshChannelsCacheTaggingInterface meshChannelsCache, bool loadDataFromCombinedMesh, MB2_LogLevel logLevel)
			{
			}

			[Token(Token = "0x6000302")]
			[Address(RVA = "0x746BFE0", Offset = "0x7467FE0", VA = "0x746BFE0", Slot = "8")]
			public void InitShowHide(MB3_MeshCombinerSingle combiner)
			{
			}

			[Token(Token = "0x6000303")]
			[Address(RVA = "0x746BDB4", Offset = "0x7467DB4", VA = "0x746BDB4", Slot = "9")]
			public void InitFromMeshCombiner(MB3_MeshCombinerSingle combiner, MB_MeshVertexChannelFlags newChannels, int uvChannelWithExtraParameter)
			{
			}

			[Token(Token = "0x6000304")]
			[Address(RVA = "0x746C008", Offset = "0x7468008", VA = "0x746C008", Slot = "10")]
			public int GetVertexCount()
			{
				return default;
			}

			[Token(Token = "0x6000305")]
			[Address(RVA = "0x746C024", Offset = "0x7468024", VA = "0x746C024", Slot = "11")]
			public int GetSubmeshCount()
			{
				return default;
			}

			[Token(Token = "0x6000306")]
			[Address(RVA = "0x746C040", Offset = "0x7468040", VA = "0x746C040", Slot = "12")]
			public void TransferOwnershipOfSerializableBuffersToCombiner(MB3_MeshCombinerSingle c, MB_MeshVertexChannelFlags channelsToTransfer, BufferDataFromPreviousBake serializableBufferData)
			{
			}

			[Token(Token = "0x6000307")]
			[Address(RVA = "0x746C160", Offset = "0x7468160", VA = "0x746C160", Slot = "13")]
			public void CopyArraysFromPreviousBakeBuffersToNewBuffers(MB_DynamicGameObject dgo, ref IVertexAndTriangleProcessor iOldBuffers, int destStartVertIdx, int triangleIdxAdjustment, int[] targSubmeshTidx, MB2_LogLevel LOG_LEVEL)
			{
			}

			[Token(Token = "0x6000308")]
			[Address(RVA = "0x746C7C0", Offset = "0x74687C0", VA = "0x746C7C0", Slot = "14")]
			public void CopyFromDGOMeshToBuffers(MB_DynamicGameObject dgo, int destStartVertsIdx, MB_MeshVertexChannelFlags channelsToUpdate, bool updateTris, bool updateBWdata, MB_IMeshBakerSettings settings, MB_IMeshCombinerSingle_BoneProcessor boneProcessor, int[] targSubmeshTidx, MB2_TextureBakeResults textureBakeResults, UVAdjuster_Atlas uvAdjuster, MB2_LogLevel LOG_LEVEL, IMeshChannelsCacheTaggingInterface meshChannelCacheParam)
			{
			}

			[Token(Token = "0x6000309")]
			[Address(RVA = "0x746DB9C", Offset = "0x7469B9C", VA = "0x746DB9C", Slot = "15")]
			public void AssignBuffersToMesh(Mesh mesh, MB_IMeshBakerSettings settings, MB2_TextureBakeResults textureBakeResults, MB_MeshVertexChannelFlags channelsToWriteToMesh, bool doWriteTrisToMesh, IAssignToMeshCustomizer assignToMeshCustomizer, List<MB_DynamicGameObject> mbDynamicObjectsInCombinedMesh, out BufferDataFromPreviousBake serializableBufferData, out SerializableIntArray[] submeshTrisToUse, out int numNonZeroLengthSubmeshes)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MB3_MeshCombinerSingle.VertexAndTriangleProcessor.AssignBuffersToMesh RVA=0x746DB9C Token=0x6000309");
}

			[Token(Token = "0x600030A")]
			[Address(RVA = "0x746E764", Offset = "0x746A764", VA = "0x746E764", Slot = "16")]
			public void AssignTriangleDataForSubmeshes(Mesh mesh, List<MB_DynamicGameObject> mbDynamicObjectsInCombinedMesh, ref BufferDataFromPreviousBake serializableBufferData, out SerializableIntArray[] submeshTrisToUse, out int numNonZeroLengthSubmeshes)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MB3_MeshCombinerSingle.VertexAndTriangleProcessor.AssignTriangleDataForSubmeshes RVA=0x746E764 Token=0x600030A");
}

			[Token(Token = "0x600030B")]
			[Address(RVA = "0x746EC54", Offset = "0x746AC54", VA = "0x746EC54", Slot = "17")]
			public void AssignTriangleDataForSubmeshes_ShowHide(Mesh mesh, List<MB_DynamicGameObject> mbDynamicObjectsInCombinedMesh, ref BufferDataFromPreviousBake serializableBufferData, out SerializableIntArray[] submeshTrisToUse, out int numNonZeroLengthSubmeshes)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MB3_MeshCombinerSingle.VertexAndTriangleProcessor.AssignTriangleDataForSubmeshes_ShowHide RVA=0x746EC54 Token=0x600030B");
}

			[Token(Token = "0x600030C")]
			[Address(RVA = "0x746E484", Offset = "0x746A484", VA = "0x746E484")]
			private void AdjustVertsToWriteAccordingToPivotPositionIfNecessary(MB_MeshPivotLocation pivotLocationType, MB_RenderType renderType, bool clearBuffersAfterBake, Vector3 pivotLocation_wld, out BufferDataFromPreviousBake serializableBufferData, out Vector3[] verts2Write)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MB3_MeshCombinerSingle.VertexAndTriangleProcessor.AdjustVertsToWriteAccordingToPivotPositionIfNecessary RVA=0x746E484 Token=0x600030C");
}

			[Token(Token = "0x600030D")]
			[Address(RVA = "0x746EBD8", Offset = "0x746ABD8", VA = "0x746EBD8")]
			private static int _NumNonZeroLengthSubmeshTris(SerializableIntArray[] subTris, out int numIndexes)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MB3_MeshCombinerSingle.VertexAndTriangleProcessor._NumNonZeroLengthSubmeshTris RVA=0x746EBD8 Token=0x600030D");
}

			[Token(Token = "0x600030E")]
			[Address(RVA = "0x746D1A8", Offset = "0x74691A8", VA = "0x746D1A8")]
			private void _copyAndAdjustUVsFromMesh(MB2_TextureBakeResults tbr, MB_DynamicGameObject dgo, Mesh mesh, int uvChannel, int vertsIdx, Vector2[] uvsOut, float[] uvsSliceIdx, MeshChannelsCache meshChannelsCache, MB2_LogLevel LOG_LEVEL, MB2_TextureBakeResults textureBakeResults)
			{
			}

			[Token(Token = "0x600030F")]
			[Address(RVA = "0x746D704", Offset = "0x7469704", VA = "0x746D704")]
			private void _CopyAndAdjustUV2FromMesh(MB_IMeshBakerSettings settings, MeshChannelsCache meshChannelsCache, MB_DynamicGameObject dgo, int vertsIdx, MB2_LogLevel LOG_LEVEL)
			{
			}

			[Token(Token = "0x6000310")]
			[Address(RVA = "0x746EC58", Offset = "0x746AC58", VA = "0x746EC58", Slot = "18")]
			public void CopyUV2unchangedToSeparateRects(List<MB_DynamicGameObject> mbDynamicObjectsInCombinedMesh, float uv2UnwrappingParamsPackMargin)
			{
			}

			[Token(Token = "0x6000311")]
			[Address(RVA = "0x746E824", Offset = "0x746A824", VA = "0x746E824")]
			private SerializableIntArray[] GetSubmeshTrisWithShowHideApplied(List<MB_DynamicGameObject> mbDynamicObjectsInCombinedMesh)
			{
				return null;
			}

			[Token(Token = "0x6000312")]
			[Address(RVA = "0x746F2D4", Offset = "0x746B2D4", VA = "0x746F2D4", Slot = "19")]
			public int[] GetTriangleSizes()
			{
				return null;
			}

			[Token(Token = "0x6000313")]
			[Address(RVA = "0x746CF00", Offset = "0x7468F00", VA = "0x746CF00")]
			private void _LocalToWorld(Transform t, bool doNorm, bool doTan, int destStartVertsIdx, Vector3[] dgoMeshVerts, Vector3[] dgoMeshNorms, Vector4[] dgoMeshTans, Vector3[] verticies, Vector3[] normals, Vector4[] tangents)
			{
			}

			[Token(Token = "0x6000314")]
			[Address(RVA = "0x746F598", Offset = "0x746B598", VA = "0x746F598")]
			private static void _LocalToWorldMatrix_TRS(ref Matrix4x4 wld_X_local, bool doNorm, bool doTan, int destStartVertsIdx, Vector3[] dgoMeshVerts, Vector3[] dgoMeshNorms, Vector4[] dgoMeshTans, Vector3[] verticies, Vector3[] normals, Vector4[] tangents)
			{
			}

			[Token(Token = "0x6000315")]
			[Address(RVA = "0x746F390", Offset = "0x746B390", VA = "0x746F390")]
			private static void _LocalToWorld_TR(Quaternion wld_Rot_local, Vector3 position_wld, bool doNorm, bool doTan, int destStartVertsIdx, Vector3[] dgoMeshVerts_local, Vector3[] dgoMeshNorms_local, Vector4[] dgoMeshTans_local, Vector3[] verticies, Vector3[] normals, Vector4[] tangents)
			{
			}

			[Token(Token = "0x6000316")]
			[Address(RVA = "0x746F994", Offset = "0x746B994", VA = "0x746F994")]
			private static void _LocalToWorld_TRS(Quaternion wld_Rot_local, Vector3 position_wld, Vector3 scale, bool doNorm, bool doTan, int destStartVertsIdx, Vector3[] dgoMeshVerts_local, Vector3[] dgoMeshNorms_local, Vector4[] dgoMeshTans_local, Vector3[] verticies, Vector3[] normals, Vector4[] tangents)
			{
			}
		}

		[Token(Token = "0x2000067")]
		public class MeshChannelsCache_NativeArray : IDisposable, IMeshChannelsCacheTaggingInterface
		{
			[Token(Token = "0x4000233")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private MB2_LogLevel LOG_LEVEL;

			[Token(Token = "0x4000234")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private MB2_LightmapOptions lightmapOption;

			[Token(Token = "0x4000235")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			protected Dictionary<int, MeshChannelsNativeArray> meshID2MeshChannels;

			[Token(Token = "0x4000236")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private bool _collectedMeshData;

			[Token(Token = "0x4000237")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
			private bool _disposed;

			[Token(Token = "0x4000238")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Vector2 _HALF_UV;

			[Token(Token = "0x6000317")]
			[Address(RVA = "0x746FE60", Offset = "0x746BE60", VA = "0x746FE60")]
			public MeshChannelsCache_NativeArray(MB2_LogLevel ll, MB2_LightmapOptions lo)
			{
			}

			[Token(Token = "0x6000318")]
			[Address(RVA = "0x746FEFC", Offset = "0x746BEFC", VA = "0x746FEFC", Slot = "5")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000319")]
			[Address(RVA = "0x746FF0C", Offset = "0x746BF0C", VA = "0x746FF0C", Slot = "10")]
			protected virtual void Dispose(bool disposing)
			{
			}

			[Token(Token = "0x600031A")]
			[Address(RVA = "0x74700A0", Offset = "0x746C0A0", VA = "0x74700A0", Slot = "6")]
			public bool HasCollectedMeshData()
			{
				return default;
			}

			[Token(Token = "0x600031B")]
			[Address(RVA = "0x74700A8", Offset = "0x746C0A8", VA = "0x74700A8", Slot = "9")]
			public bool hasOutOfBoundsUVs(Mesh m, ref MB_Utility.MeshAnalysisResult mar, int submeshIdx)
			{
				return default;
			}

			[Token(Token = "0x600031C")]
			[Address(RVA = "0x7470168", Offset = "0x746C168", VA = "0x7470168")]
			internal NativeArray<Vector3> GetVerticiesAsNativeArray(Mesh m)
			{
				return default;
			}

			[Token(Token = "0x600031D")]
			[Address(RVA = "0x7470268", Offset = "0x746C268", VA = "0x7470268")]
			internal NativeArray<Vector3> GetNormalsAsNativeArray(Mesh m)
			{
				return default;
			}

			[Token(Token = "0x600031E")]
			[Address(RVA = "0x7470368", Offset = "0x746C368", VA = "0x7470368")]
			internal NativeArray<Vector4> GetTangentsAsNativeArray(Mesh m)
			{
				return default;
			}

			[Token(Token = "0x600031F")]
			[Address(RVA = "0x74700DC", Offset = "0x746C0DC", VA = "0x74700DC")]
			internal NativeArray<Vector2> GetUv0RawAsNativeArray(Mesh m)
			{
				return default;
			}

			[Token(Token = "0x6000320")]
			[Address(RVA = "0x7470468", Offset = "0x746C468", VA = "0x7470468")]
			internal NativeArray<Vector2> GetUv0ModifiedAsNativeArray(Mesh m)
			{
				return default;
			}

			[Token(Token = "0x6000321")]
			[Address(RVA = "0x747054C", Offset = "0x746C54C", VA = "0x747054C")]
			internal NativeArray<Vector2> GetUv2ModifiedAsNativeArray(Mesh m)
			{
				return default;
			}

			[Token(Token = "0x6000322")]
			[Address(RVA = "0x7470630", Offset = "0x746C630", VA = "0x7470630")]
			internal NativeArray<Vector2> GetUVChannelAsNativeArray(int channel, Mesh m)
			{
				return default;
			}

			[Token(Token = "0x6000323")]
			[Address(RVA = "0x74707F4", Offset = "0x746C7F4", VA = "0x74707F4")]
			internal NativeArray<Color> GetColorsAsNativeArray(Mesh m)
			{
				return default;
			}

			[Token(Token = "0x6000324")]
			[Address(RVA = "0x7470880", Offset = "0x746C880", VA = "0x7470880", Slot = "7")]
			public void CollectChannelDataForAllMeshesInList(List<MB_DynamicGameObject> toUpdateDGOs, List<MB_DynamicGameObject> toAddDGOs, MB_MeshVertexChannelFlags newChannels, MB_RenderType renderType, bool doBlendShapes)
			{
			}

			[Token(Token = "0x6000325")]
			[Address(RVA = "0x7471FDC", Offset = "0x746DFDC", VA = "0x7471FDC")]
			internal List<Matrix4x4> GetBindposes(Renderer r, out bool isSkinnedMeshWithBones)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MB3_MeshCombinerSingle.MeshChannelsCache_NativeArray.GetBindposes RVA=0x7471FDC Token=0x6000325");
}

			[Token(Token = "0x6000326")]
			[Address(RVA = "0x74720F8", Offset = "0x746E0F8", VA = "0x74720F8")]
			internal BoneWeightDataForMesh GetBoneWeightData(Renderer r, int numbones, bool isSkinnedMeshWithBones)
			{
				return default;
			}

			[Token(Token = "0x6000327")]
			[Address(RVA = "0x74721B0", Offset = "0x746E1B0", VA = "0x74721B0", Slot = "8")]
			public MBBlendShape[] GetBlendShapes(Mesh m, int gameObjectID, GameObject gameObject)
			{
				return null;
			}

			[Token(Token = "0x6000328")]
			[Address(RVA = "0x74716F0", Offset = "0x746D6F0", VA = "0x74716F0")]
			private Color[] _getMeshColors(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x6000329")]
			[Address(RVA = "0x7471248", Offset = "0x746D248", VA = "0x7471248")]
			private Vector3[] _getMeshNormals(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x600032A")]
			[Address(RVA = "0x747146C", Offset = "0x746D46C", VA = "0x747146C")]
			private Vector4[] _getMeshTangents(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x600032B")]
			[Address(RVA = "0x74710AC", Offset = "0x746D0AC", VA = "0x74710AC")]
			private Vector2[] _getMeshUVs(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x600032C")]
			[Address(RVA = "0x747116C", Offset = "0x746D16C", VA = "0x747116C")]
			private Vector2[] _getMeshUV2s(Mesh m, ref NativeArray<Vector2> uv2modified)
			{
				return null;
			}

			[Token(Token = "0x600032D")]
			[Address(RVA = "0x7471910", Offset = "0x746D910", VA = "0x7471910")]
			private static void _getBindPoses(Renderer r, List<Matrix4x4> poses, out bool isSkinnedMeshWithBones)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MB3_MeshCombinerSingle.MeshChannelsCache_NativeArray._getBindPoses RVA=0x7471910 Token=0x600032D");
}

			[Token(Token = "0x600032E")]
			[Address(RVA = "0x7471C5C", Offset = "0x746DC5C", VA = "0x7471C5C")]
			private static void _getBoneWeightData(ref BoneWeightDataForMesh bwd, Renderer r, int numBones, bool isSkinnedMeshWithBones)
			{
			}

			[Token(Token = "0x600032F")]
			[Address(RVA = "0x747235C", Offset = "0x746E35C", VA = "0x747235C")]
			internal NativeArray<Vector2> GetUv0Raw(Mesh m)
			{
				return default;
			}

			[Token(Token = "0x6000330")]
			[Address(RVA = "0x7472928", Offset = "0x746E928", VA = "0x7472928")]
			private static BoneWeight[] _getBoneWeights(Renderer r, int numVertsInMeshBeingAdded, bool isSkinnedMeshWithBones)
			{
				return null;
			}

			[Token(Token = "0x6000331")]
			[Address(RVA = "0x74723E8", Offset = "0x746E3E8", VA = "0x74723E8")]
			private void _generateTangents(int[] triangles, Vector3[] verts, NativeArray<Vector2> uvs, Vector3[] normals, Vector4[] outTangents)
			{
			}
		}

		[Token(Token = "0x2000068")]
		public class MeshChannelsNativeArray : IDisposable
		{
			[Token(Token = "0x4000239")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private bool _disposed;

			[Token(Token = "0x400023A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public NativeArray<Vector3> vertcies_NativeArray;

			[Token(Token = "0x400023B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public NativeArray<Vector3> normals_NativeArray;

			[Token(Token = "0x400023C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public NativeArray<Vector4> tangents_NativeArray;

			[Token(Token = "0x400023D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public NativeArray<Color> colors_NativeArray;

			[Token(Token = "0x400023E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public NativeArray<Vector2> uv0raw_NativeArray;

			[Token(Token = "0x400023F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public NativeArray<Vector2> uv0modified_NativeArray;

			[Token(Token = "0x4000240")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public NativeArray<Vector2> uv2raw_NativeArray;

			[Token(Token = "0x4000241")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public NativeArray<Vector2> uv2modified_NativeArray;

			[Token(Token = "0x4000242")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public NativeArray<Vector2> uv3_NativeArray;

			[Token(Token = "0x4000243")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public NativeArray<Vector2> uv4_NativeArray;

			[Token(Token = "0x4000244")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			public NativeArray<Vector2> uv5_NativeArray;

			[Token(Token = "0x4000245")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			public NativeArray<Vector2> uv6_NativeArray;

			[Token(Token = "0x4000246")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			public NativeArray<Vector2> uv7_NativeArray;

			[Token(Token = "0x4000247")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			public NativeArray<Vector2> uv8_NativeArray;

			[Token(Token = "0x4000248")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			public List<Matrix4x4> bindPoses;

			[Token(Token = "0x4000249")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			public BoneWeightDataForMesh boneWeightData;

			[Token(Token = "0x400024A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			public MBBlendShape[] blendShapes;

			[Token(Token = "0x6000332")]
			[Address(RVA = "0x7470090", Offset = "0x746C090", VA = "0x7470090", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000333")]
			[Address(RVA = "0x7472B88", Offset = "0x746EB88", VA = "0x7472B88")]
			public bool IsDisposed()
			{
				return default;
			}

			[Token(Token = "0x6000334")]
			[Address(RVA = "0x7472B90", Offset = "0x746EB90", VA = "0x7472B90", Slot = "5")]
			protected virtual void Dispose(bool disposing)
			{
			}

			[Token(Token = "0x6000335")]
			[Address(RVA = "0x747102C", Offset = "0x746D02C", VA = "0x747102C")]
			public MeshChannelsNativeArray()
			{
			}
		}

		[Token(Token = "0x2000069")]
		public struct MB_MeshCombinerSingle_MeshNativeArrayHelper
		{
			[Token(Token = "0x200006A")]
			public struct SIZER_4
			{
				[Token(Token = "0x400024F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[4];
			}

			[Token(Token = "0x200006C")]
			public struct SIZER_8
			{
				[Token(Token = "0x4000251")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[8];
			}

			[Token(Token = "0x200006E")]
			public struct SIZER_12
			{
				[Token(Token = "0x4000253")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[12];
			}

			[Token(Token = "0x2000070")]
			public struct SIZER_16
			{
				[Token(Token = "0x4000255")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[16];
			}

			[Token(Token = "0x2000072")]
			public struct SIZER_20
			{
				[Token(Token = "0x4000257")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[20];
			}

			[Token(Token = "0x2000074")]
			public struct SIZER_24
			{
				[Token(Token = "0x4000259")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[24];
			}

			[Token(Token = "0x2000076")]
			public struct SIZER_28
			{
				[Token(Token = "0x400025B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[28];
			}

			[Token(Token = "0x2000078")]
			public struct SIZER_32
			{
				[Token(Token = "0x400025D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[32];
			}

			[Token(Token = "0x200007A")]
			public struct SIZER_36
			{
				[Token(Token = "0x400025F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[36];
			}

			[Token(Token = "0x200007C")]
			public struct SIZER_40
			{
				[Token(Token = "0x4000261")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[40];
			}

			[Token(Token = "0x200007E")]
			public struct SIZER_44
			{
				[Token(Token = "0x4000263")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[44];
			}

			[Token(Token = "0x2000080")]
			public struct SIZER_48
			{
				[Token(Token = "0x4000265")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[48];
			}

			[Token(Token = "0x2000082")]
			public struct SIZER_52
			{
				[Token(Token = "0x4000267")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[52];
			}

			[Token(Token = "0x2000084")]
			public struct SIZER_56
			{
				[Token(Token = "0x4000269")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[56];
			}

			[Token(Token = "0x2000086")]
			public struct SIZER_60
			{
				[Token(Token = "0x400026B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[60];
			}

			[Token(Token = "0x2000088")]
			public struct SIZER_64
			{
				[Token(Token = "0x400026D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[64];
			}

			[Token(Token = "0x200008A")]
			public struct SIZER_68
			{
				[Token(Token = "0x400026F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[68];
			}

			[Token(Token = "0x200008C")]
			public struct SIZER_72
			{
				[Token(Token = "0x4000271")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[72];
			}

			[Token(Token = "0x200008E")]
			public struct SIZER_76
			{
				[Token(Token = "0x4000273")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[72];
			}

			[Token(Token = "0x2000090")]
			public struct SIZER_80
			{
				[Token(Token = "0x4000275")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[80];
			}

			[Token(Token = "0x2000092")]
			public struct SIZER_84
			{
				[Token(Token = "0x4000277")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[84];
			}

			[Token(Token = "0x2000094")]
			public struct SIZER_88
			{
				[Token(Token = "0x4000279")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[88];
			}

			[Token(Token = "0x2000096")]
			public struct SIZER_92
			{
				[Token(Token = "0x400027B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[92];
			}

			[Token(Token = "0x2000098")]
			public struct SIZER_96
			{
				[Token(Token = "0x400027D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[96];
			}

			[Token(Token = "0x200009A")]
			public struct SIZER_100
			{
				[Token(Token = "0x400027F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[100];
			}

			[Token(Token = "0x200009C")]
			public struct SIZER_104
			{
				[Token(Token = "0x4000281")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[104];
			}

			[Token(Token = "0x200009E")]
			public struct SIZER_108
			{
				[Token(Token = "0x4000283")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[108];
			}

			[Token(Token = "0x20000A0")]
			public struct SIZER_112
			{
				[Token(Token = "0x4000285")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[112];
			}

			[Token(Token = "0x20000A2")]
			public struct SIZER_116
			{
				[Token(Token = "0x4000287")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[116];
			}

			[Token(Token = "0x20000A4")]
			public struct SIZER_120
			{
				[Token(Token = "0x4000289")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[120];
			}

			[Token(Token = "0x20000A6")]
			public struct SIZER_124
			{
				[Token(Token = "0x400028B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[124];
			}

			[Token(Token = "0x20000A8")]
			public struct SIZER_128
			{
				[Token(Token = "0x400028D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[128];
			}

			[Token(Token = "0x20000AA")]
			public struct SIZER_132
			{
				[Token(Token = "0x400028F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[132];
			}

			[Token(Token = "0x20000AC")]
			public struct SIZER_136
			{
				[Token(Token = "0x4000291")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[136];
			}

			[Token(Token = "0x20000AE")]
			public struct SIZER_140
			{
				[Token(Token = "0x4000293")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[140];
			}

			[Token(Token = "0x20000B0")]
			public struct SIZER_144
			{
				[Token(Token = "0x4000295")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[144];
			}

			[Token(Token = "0x20000B2")]
			public struct SIZER_148
			{
				[Token(Token = "0x4000297")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[148];
			}

			[Token(Token = "0x20000B4")]
			public struct SIZER_152
			{
				[Token(Token = "0x4000299")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public unsafe fixed byte data[152];
			}

			[Token(Token = "0x400024B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static Type[] _TypeForStride;

			[Token(Token = "0x400024C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Mesh.MeshDataArray dataArray;

			[Token(Token = "0x400024D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Mesh.MeshData data;

			[Token(Token = "0x400024E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int vertexCount;

			[Token(Token = "0x6000336")]
			[Address(RVA = "0x7472DC8", Offset = "0x746EDC8", VA = "0x7472DC8")]
			[Preserve]
			public void _ENSURE_IL2CPP_CREATES_NECESSARY_CODE(ref Mesh.MeshData m)
			{
			}

			[Token(Token = "0x6000337")]
			[Address(RVA = "0x7475144", Offset = "0x7471144", VA = "0x7475144")]
			public static int CalcStride(MB_MeshVertexChannelFlags channels, int uvChannelWithExtraParameter, out int strideVertexBuffer, out int strideUVbuffer)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MB3_MeshCombinerSingle.MB_MeshCombinerSingle_MeshNativeArrayHelper.CalcStride RVA=0x7475144 Token=0x6000337");
}

			[Token(Token = "0x6000338")]
			[Address(RVA = "0x7475258", Offset = "0x7471258", VA = "0x7475258")]
			public static void Init(MB_MeshVertexChannelFlags channels, VertexAttributeDescriptor[] vertexAttributes, ref VertexAndTriangleProcessorNativeArray nativeSlices, int vertexCount, int[] submeshCount, int uvChannelWithExtraParameter)
			{
			}

			[Token(Token = "0x6000339")]
			[Address(RVA = "0x7475760", Offset = "0x7471760", VA = "0x7475760")]
			public static void AllocateWriteableMeshData(ref VertexAndTriangleProcessorNativeArray nativeSlices, VertexAttributeDescriptor[] channels, int vertexCount, int numBuffers)
			{
			}

			[Token(Token = "0x600033A")]
			[Address(RVA = "0x74758C8", Offset = "0x74718C8", VA = "0x74758C8")]
			public static void SetupNativeSlices(ref VertexAndTriangleProcessorNativeArray nativeSlices, int strideVertexData, int strideUVdata, int uvChannelWithExtraParameter)
			{
			}

			[Token(Token = "0x600033B")]
			[Address(RVA = "0x74783F0", Offset = "0x74743F0", VA = "0x74783F0")]
			public static void NativeSliceCopyFrom(object toHereSlice, Type toHereSizerType, object fromHereSlice, Type fromHereSizerType)
			{
			}

			[Token(Token = "0x600033C")]
			public static void NativeSliceCopy<T>(NativeSlice<T> srcArray, int srcStartIdx, NativeSlice<T> destArray, int destStartIdx, int length) where T : struct
			{
			}

			[Token(Token = "0x600033D")]
			public static void NativeSliceCopyTo<T>(NativeSlice<T> srcArray, NativeSlice<T> destArray, int destStartIdx) where T : struct
			{
			}
		}

		[Token(Token = "0x20000B6")]
		public struct VertexAndTriangleProcessorNativeArray : IVertexAndTriangleProcessor, IDisposable
		{
			[Token(Token = "0x400029B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private bool _disposed;

			[Token(Token = "0x400029C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			private bool _isInitialized;

			[Token(Token = "0x400029D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal MB2_LogLevel LOG_LEVEL;

			[Token(Token = "0x400029F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal VertexAttributeDescriptor[] vertexAttributes;

			[Token(Token = "0x40002A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal bool dataArrayAllocated;

			[Token(Token = "0x40002A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Mesh.MeshDataArray dataArray;

			[Token(Token = "0x40002A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal Mesh.MeshData data;

			[Token(Token = "0x40002A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal int vertexCount;

			[Token(Token = "0x40002A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal NativeArray<Vector3> verticiesModified;

			[Token(Token = "0x40002A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal NativeSlice<Vector3> verticies;

			[Token(Token = "0x40002A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal NativeSlice<Vector3> normals;

			[Token(Token = "0x40002A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			internal NativeSlice<Vector4> tangents;

			[Token(Token = "0x40002A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			internal NativeSlice<Color> colors;

			[Token(Token = "0x40002A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			internal NativeSlice<Vector2> uv0s;

			[Token(Token = "0x40002AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			internal NativeSlice<Vector2> uv2s;

			[Token(Token = "0x40002AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			internal NativeSlice<Vector2> uv3s;

			[Token(Token = "0x40002AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			internal NativeSlice<Vector2> uv4s;

			[Token(Token = "0x40002AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			internal NativeSlice<Vector2> uv5s;

			[Token(Token = "0x40002AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			internal NativeSlice<Vector2> uv6s;

			[Token(Token = "0x40002AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			internal NativeSlice<Vector2> uv7s;

			[Token(Token = "0x40002B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			internal NativeSlice<Vector2> uv8s;

			[Token(Token = "0x40002B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			internal NativeSlice<float> uvsSliceIdx;

			[Token(Token = "0x40002B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			internal NativeSlice<Vector3> uvsWithExtraIndex;

			[Token(Token = "0x40002B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			private SerializableIntArray[] submeshTris;

			[Token(Token = "0x40002B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			internal NativeArray<ushort> triangleBuffer;

			[Token(Token = "0x40002B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
			internal int bufferStride_0;

			[Token(Token = "0x40002B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			internal int bufferStride_1;

			[Token(Token = "0x40002B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			internal int bufferStride_2;

			[Token(Token = "0x40002B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			internal Type rawSliceSizerType_0;

			[Token(Token = "0x40002B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
			internal Type rawSliceSizerType_1;

			[Token(Token = "0x40002BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			internal object rawSliceVertexStream_0;

			[Token(Token = "0x40002BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
			internal object rawSliceVertexStream_1;

			[Token(Token = "0x1700006D")]
			public MB_MeshVertexChannelFlags channels
			{
				[Token(Token = "0x600033F")]
				[Address(RVA = "0x74791E0", Offset = "0x74751E0", VA = "0x74791E0", Slot = "4")]
				[CompilerGenerated]
				readonly get
				{
					return default;
				}
				[Token(Token = "0x6000340")]
				[Address(RVA = "0x74791E8", Offset = "0x74751E8", VA = "0x74791E8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000341")]
			[Address(RVA = "0x74791F0", Offset = "0x74751F0", VA = "0x74791F0", Slot = "20")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000342")]
			[Address(RVA = "0x7479284", Offset = "0x7475284", VA = "0x7479284", Slot = "5")]
			public bool IsInitialized()
			{
				return default;
			}

			[Token(Token = "0x6000343")]
			[Address(RVA = "0x747928C", Offset = "0x747528C", VA = "0x747928C", Slot = "6")]
			public bool IsDisposed()
			{
				return default;
			}

			[Token(Token = "0x6000344")]
			[Address(RVA = "0x7479294", Offset = "0x7475294", VA = "0x7479294", Slot = "7")]
			public void Init(MB3_MeshCombinerSingle combiner, MB_MeshVertexChannelFlags newChannels, int vertexCount, int[] newSubmeshTrisSize, int uvChannelWithExtraParameter, IMeshChannelsCacheTaggingInterface meshChannelsCache, bool loadDataFromCombinedMesh, MB2_LogLevel logLevel)
			{
			}

			[Token(Token = "0x6000345")]
			[Address(RVA = "0x7479C30", Offset = "0x7475C30", VA = "0x7479C30", Slot = "8")]
			public void InitShowHide(MB3_MeshCombinerSingle combiner)
			{
			}

			[Token(Token = "0x6000346")]
			[Address(RVA = "0x74797B4", Offset = "0x74757B4", VA = "0x74797B4", Slot = "9")]
			public void InitFromMeshCombiner(MB3_MeshCombinerSingle combiner, MB_MeshVertexChannelFlags newChannels, int uvChannelWithExtraParameter)
			{
			}

			[Token(Token = "0x6000347")]
			[Address(RVA = "0x7479C5C", Offset = "0x7475C5C", VA = "0x7479C5C")]
			public void ApplyDataBufferToMesh(Mesh m)
			{
			}

			[Token(Token = "0x6000348")]
			[Address(RVA = "0x7479D0C", Offset = "0x7475D0C", VA = "0x7479D0C", Slot = "10")]
			public int GetVertexCount()
			{
				return default;
			}

			[Token(Token = "0x6000349")]
			[Address(RVA = "0x7479D54", Offset = "0x7475D54", VA = "0x7479D54", Slot = "11")]
			public int GetSubmeshCount()
			{
				return default;
			}

			[Token(Token = "0x600034A")]
			[Address(RVA = "0x7479D70", Offset = "0x7475D70", VA = "0x7479D70", Slot = "12")]
			public void TransferOwnershipOfSerializableBuffersToCombiner(MB3_MeshCombinerSingle c, MB_MeshVertexChannelFlags channelsToTransfer, BufferDataFromPreviousBake serializableBufferData)
			{
			}

			[Token(Token = "0x600034B")]
			[Address(RVA = "0x7479DB0", Offset = "0x7475DB0", VA = "0x7479DB0", Slot = "13")]
			public void CopyArraysFromPreviousBakeBuffersToNewBuffers(MB_DynamicGameObject dgo, ref IVertexAndTriangleProcessor iOldBuffers, int destStartVertIdx, int triangleIdxAdjustment, int[] targSubmeshTidx, MB2_LogLevel LOG_LEVEL)
			{
			}

			[Token(Token = "0x600034C")]
			[Address(RVA = "0x747A700", Offset = "0x7476700", VA = "0x747A700", Slot = "14")]
			public void CopyFromDGOMeshToBuffers(MB_DynamicGameObject dgo, int destStartVertsIdx, MB_MeshVertexChannelFlags channelsToUpdate, bool updateTris, bool updateBWdata, MB_IMeshBakerSettings settings, MB_IMeshCombinerSingle_BoneProcessor boneProcessor, int[] targSubmeshTidx, MB2_TextureBakeResults textureBakeResults, UVAdjuster_Atlas uvAdjuster, MB2_LogLevel LOG_LEVEL, IMeshChannelsCacheTaggingInterface meshChannelCacheParam)
			{
			}

			[Token(Token = "0x600034D")]
			[Address(RVA = "0x747BF38", Offset = "0x7477F38", VA = "0x747BF38", Slot = "15")]
			public void AssignBuffersToMesh(Mesh mesh, MB_IMeshBakerSettings settings, MB2_TextureBakeResults textureBakeResults, MB_MeshVertexChannelFlags channelsToWriteToMesh, bool doWriteTrisToMesh, IAssignToMeshCustomizer assignToMeshCustomizer, List<MB_DynamicGameObject> mbDynamicObjectsInCombinedMesh, out BufferDataFromPreviousBake serializableBufferData, out SerializableIntArray[] submeshTrisToUse, out int numNonZeroLengthSubmeshes)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MB3_MeshCombinerSingle.VertexAndTriangleProcessorNativeArray.AssignBuffersToMesh RVA=0x747BF38 Token=0x600034D");
}

			[Token(Token = "0x600034E")]
			[Address(RVA = "0x747CA80", Offset = "0x7478A80", VA = "0x747CA80", Slot = "16")]
			public void AssignTriangleDataForSubmeshes(Mesh mmesh, List<MB_DynamicGameObject> mbDynamicObjectsInCombinedMesh, ref BufferDataFromPreviousBake serializableBufferData, out SerializableIntArray[] submeshTrisToUse, out int numNonZeroLengthSubmeshes)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MB3_MeshCombinerSingle.VertexAndTriangleProcessorNativeArray.AssignTriangleDataForSubmeshes RVA=0x747CA80 Token=0x600034E");
}

			[Token(Token = "0x600034F")]
			[Address(RVA = "0x747D140", Offset = "0x7479140", VA = "0x747D140", Slot = "17")]
			public void AssignTriangleDataForSubmeshes_ShowHide(Mesh mesh, List<MB_DynamicGameObject> mbDynamicObjectsInCombinedMesh, ref BufferDataFromPreviousBake serializableBufferData, out SerializableIntArray[] submeshTrisToUse, out int numNonZeroLengthSubmeshes)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MB3_MeshCombinerSingle.VertexAndTriangleProcessorNativeArray.AssignTriangleDataForSubmeshes_ShowHide RVA=0x747D140 Token=0x600034F");
}

			[Token(Token = "0x6000350")]
			[Address(RVA = "0x747C778", Offset = "0x7478778", VA = "0x747C778")]
			private void AdjustVertsToWriteAccordingToPivotPositionIfNecessary(MB_MeshPivotLocation pivotLocationType, MB_RenderType renderType, bool clearBuffersAfterBake, Vector3 pivotLocation_wld, out BufferDataFromPreviousBake serializableBufferData)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MB3_MeshCombinerSingle.VertexAndTriangleProcessorNativeArray.AdjustVertsToWriteAccordingToPivotPositionIfNecessary RVA=0x747C778 Token=0x6000350");
}

			[Token(Token = "0x6000351")]
			[Address(RVA = "0x747D0C4", Offset = "0x74790C4", VA = "0x747D0C4")]
			private static int _NumNonZeroLengthSubmeshTris(SerializableIntArray[] subTris, out int numIndexes)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MB3_MeshCombinerSingle.VertexAndTriangleProcessorNativeArray._NumNonZeroLengthSubmeshTris RVA=0x747D0C4 Token=0x6000351");
}

			[Token(Token = "0x6000352")]
			[Address(RVA = "0x747B4F0", Offset = "0x74774F0", VA = "0x747B4F0")]
			private void _copyAndAdjustUVsFromMesh(MB2_TextureBakeResults tbr, MB_DynamicGameObject dgo, Mesh mesh, int uvChannel, int vertsIdx, NativeSlice<Vector2> uvsOut, NativeSlice<float> uvsSliceIdx, MeshChannelsCache_NativeArray meshChannelsCache, MB2_LogLevel LOG_LEVEL, MB2_TextureBakeResults textureBakeResults)
			{
			}

			[Token(Token = "0x6000353")]
			[Address(RVA = "0x747BA68", Offset = "0x7477A68", VA = "0x747BA68")]
			private void _CopyAndAdjustUV2FromMesh(MB_IMeshBakerSettings settings, MeshChannelsCache_NativeArray meshChannelsCache, MB_DynamicGameObject dgo, int vertsIdx, MB2_LogLevel LOG_LEVEL)
			{
			}

			[Token(Token = "0x6000354")]
			[Address(RVA = "0x747D4E0", Offset = "0x74794E0", VA = "0x747D4E0", Slot = "18")]
			public void CopyUV2unchangedToSeparateRects(List<MB_DynamicGameObject> mbDynamicObjectsInCombinedMesh, float uv2UnwrappingParamsPackMargin)
			{
			}

			[Token(Token = "0x6000355")]
			[Address(RVA = "0x747CD10", Offset = "0x7478D10", VA = "0x747CD10")]
			private SerializableIntArray[] GetSubmeshTrisWithShowHideApplied(List<MB_DynamicGameObject> mbDynamicObjectsInCombinedMesh)
			{
				return null;
			}

			[Token(Token = "0x6000356")]
			[Address(RVA = "0x747DC14", Offset = "0x7479C14", VA = "0x747DC14", Slot = "19")]
			public int[] GetTriangleSizes()
			{
				return null;
			}

			[Token(Token = "0x6000357")]
			[Address(RVA = "0x747B0D4", Offset = "0x74770D4", VA = "0x747B0D4")]
			private void _LocalToWorld(Transform t, bool doNorm, bool doTan, int destStartVertsIdx, NativeArray<Vector3> dgoMeshVerts, NativeArray<Vector3> dgoMeshNorms, NativeArray<Vector4> dgoMeshTans, NativeSlice<Vector3> verticies, NativeSlice<Vector3> normals, NativeSlice<Vector4> tangents)
			{
			}

			[Token(Token = "0x6000358")]
			[Address(RVA = "0x747DF38", Offset = "0x7479F38", VA = "0x747DF38")]
			private static void _LocalToWorldMatrix_TRS(ref Matrix4x4 wld_X_local, bool doNorm, bool doTan, int destStartVertsIdx, NativeSlice<Vector3> dgoMeshVerts, NativeSlice<Vector3> dgoMeshNorms, NativeSlice<Vector4> dgoMeshTans, NativeSlice<Vector3> verticies, NativeSlice<Vector3> normals, NativeSlice<Vector4> tangents)
			{
			}

			[Token(Token = "0x6000359")]
			[Address(RVA = "0x747DCD0", Offset = "0x7479CD0", VA = "0x747DCD0")]
			private static void _LocalToWorld_TR(Quaternion wld_Rot_local, Vector3 position_wld, bool doNorm, bool doTan, int destStartVertsIdx, NativeSlice<Vector3> dgoMeshVerts_local, NativeSlice<Vector3> dgoMeshNorms_local, NativeSlice<Vector4> dgoMeshTans_local, NativeSlice<Vector3> verticies, NativeSlice<Vector3> normals, NativeSlice<Vector4> tangents)
			{
			}

			[Token(Token = "0x600035A")]
			[Address(RVA = "0x747E334", Offset = "0x747A334", VA = "0x747E334")]
			private static void _LocalToWorld_TRS(Quaternion wld_Rot_local, Vector3 position_wld, Vector3 scale, bool doNorm, bool doTan, int destStartVertsIdx, NativeSlice<Vector3> dgoMeshVerts_local, NativeSlice<Vector3> dgoMeshNorms_local, NativeSlice<Vector4> dgoMeshTans_local, NativeSlice<Vector3> verticies, NativeSlice<Vector3> normals, NativeSlice<Vector4> tangents)
			{
			}
		}

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Stopwatch db_showHideGameObjects;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Stopwatch db_addDeleteGameObjects;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Stopwatch db_addDeleteGameObjects_CollectMeshData;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Stopwatch db_addDeleteGameObjects_CollectMeshData_a;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Stopwatch db_addDeleteGameObjects_CollectMeshData_b;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Stopwatch db_addDeleteGameObjects_CollectMeshData_c;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Stopwatch db_addDeleteGameObjects_InitFromMeshCombiner;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Stopwatch db_addDeleteGameObjects_Init;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Stopwatch db_addDeleteGameObjects_CopyArraysFromPreviousBakeBuffersToNewBuffers;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Stopwatch db_addDeleteGameObjects_CopyFromDGOMeshToBuffers;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Stopwatch db_apply;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public Stopwatch db_applyShowHide;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Stopwatch db_updateGameObjects;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		protected List<GameObject> objectsInCombinedMesh;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		private int lightmapIndex;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		public List<MB_DynamicGameObject> mbDynamicObjectsInCombinedMesh;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Dictionary<GameObject, MB_DynamicGameObject> _instance2combined_map;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private MB_MeshVertexChannelFlags channelsLastBake;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private Vector3[] verts;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		private Vector3[] normals;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		private Vector4[] tangents;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		private Vector2[] uvs;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[SerializeField]
		private float[] uvsSliceIdx;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[SerializeField]
		private Vector2[] uv2s;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[SerializeField]
		private Vector2[] uv3s;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[SerializeField]
		private Vector2[] uv4s;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		[SerializeField]
		private Vector2[] uv5s;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[SerializeField]
		private Vector2[] uv6s;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[SerializeField]
		private Vector2[] uv7s;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[SerializeField]
		private Vector2[] uv8s;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[SerializeField]
		private Color[] colors;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		[SerializeField]
		private SerializableIntArray[] submeshTris;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		[SerializeField]
		private Matrix4x4[] bindPoses;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		[SerializeField]
		private Transform[] bones;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		internal MBBlendShape[] blendShapes;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		internal BufferDataFromPreviousBake bufferDataFromPrevious;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		[SerializeField]
		private MeshCreationConditions _meshBirth;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private Mesh _mesh;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		internal IVertexAndTriangleProcessor _vertexAndTriProcessor;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		protected MB_IMeshCombinerSingle_BoneProcessor _boneProcessor;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		internal MB_MeshCombinerSingle_BlendShapeProcessor _blendShapeProcessor;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		protected IMeshChannelsCacheTaggingInterface _meshChannelsCache;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private GameObject[] empty;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private int[] emptyIDs;

		[Token(Token = "0x17000068")]
		public override MB2_TextureBakeResults textureBakeResults
		{
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x744F8F4", Offset = "0x744B8F4", VA = "0x744F8F4", Slot = "55")]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public override MB_RenderType renderType
		{
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x744FA28", Offset = "0x744BA28", VA = "0x744FA28", Slot = "67")]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public override GameObject resultSceneObject
		{
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x744FADC", Offset = "0x744BADC", VA = "0x744FADC", Slot = "57")]
			set
			{
			}
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x744F254", Offset = "0x744B254", VA = "0x744F254")]
		public void StartProfile()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x744F2B4", Offset = "0x744B2B4", VA = "0x744F2B4")]
		public void PrintProfileInfo()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x744F694", Offset = "0x744B694", VA = "0x744F694", Slot = "102")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x744FA0C", Offset = "0x744BA0C", VA = "0x744FA0C")]
		public int GetVertexCount()
		{
			return default;
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x744FC08", Offset = "0x744BC08", VA = "0x744FC08")]
		private MB_DynamicGameObject instance2Combined_MapGet(GameObject gameObjectID)
		{
			return null;
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x744FC60", Offset = "0x744BC60", VA = "0x744FC60")]
		private void instance2Combined_MapAdd(GameObject gameObjectID, MB_DynamicGameObject dgo)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x744FCC8", Offset = "0x744BCC8", VA = "0x744FCC8")]
		private void instance2Combined_MapRemove(GameObject gameObjectID)
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x744FD20", Offset = "0x744BD20", VA = "0x744FD20")]
		private bool instance2Combined_MapTryGetValue(GameObject gameObjectID, out MB_DynamicGameObject dgo)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MB3_MeshCombinerSingle.instance2Combined_MapTryGetValue RVA=0x744FD20 Token=0x6000237");
}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x744FD88", Offset = "0x744BD88", VA = "0x744FD88")]
		private int instance2Combined_MapCount()
		{
			return default;
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x744FDD8", Offset = "0x744BDD8", VA = "0x744FDD8")]
		private void instance2Combined_MapClear()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x744FE28", Offset = "0x744BE28", VA = "0x744FE28")]
		private bool instance2Combined_MapContainsKey(GameObject gameObjectID)
		{
			return default;
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x744FE80", Offset = "0x744BE80", VA = "0x744FE80")]
		public bool InstanceID2DGO(int instanceID, out MB_DynamicGameObject dgoGameObject)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MB3_MeshCombinerSingle.InstanceID2DGO RVA=0x744FE80 Token=0x600023B");
}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x7450054", Offset = "0x744C054", VA = "0x7450054", Slot = "111")]
		public override int GetNumObjectsInCombined()
		{
			return default;
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x745009C", Offset = "0x744C09C", VA = "0x745009C", Slot = "110")]
		public override List<GameObject> GetObjectsInCombined()
		{
			return null;
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x745013C", Offset = "0x744C13C", VA = "0x745013C")]
		public Mesh GetMesh()
		{
			return null;
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x745024C", Offset = "0x744C24C", VA = "0x745024C")]
		public MeshCreationConditions SetMesh(Mesh m)
		{
			return default;
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x74502CC", Offset = "0x744C2CC", VA = "0x74502CC")]
		public Transform[] GetBones()
		{
			return null;
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x74502D4", Offset = "0x744C2D4", VA = "0x74502D4", Slot = "103")]
		public override int GetLightmapIndex()
		{
			return default;
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x7450410", Offset = "0x744C410", VA = "0x7450410")]
		private bool _Initialize(int numResultMats)
		{
			return default;
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x7450740", Offset = "0x744C740", VA = "0x7450740")]
		private bool _collectMaterialTriangles(Mesh m, MB_DynamicGameObject dgo, Material[] sharedMaterials, OrderedDictionary sourceMats2submeshIdx_map)
		{
			return default;
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x7450D18", Offset = "0x744CD18", VA = "0x7450D18")]
		private bool _collectOutOfBoundsUVRects2(Mesh m, MB_DynamicGameObject dgo, Material[] sharedMaterials, OrderedDictionary sourceMats2submeshIdx_map, Dictionary<int, MB_Utility.MeshAnalysisResult[]> meshAnalysisResults)
		{
			return default;
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x7451080", Offset = "0x744D080", VA = "0x7451080")]
		private bool _validateTextureBakeResults()
		{
			return default;
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x74511C0", Offset = "0x744D1C0", VA = "0x74511C0")]
		internal bool _ShowHide(GameObject[] goToShow, GameObject[] goToHide)
		{
			return default;
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x74517F0", Offset = "0x744D7F0", VA = "0x74517F0")]
		internal bool _AddToCombined(GameObject[] goToAdd, int[] goToDelete, bool disableRendererInSource)
		{
			return default;
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x74531E8", Offset = "0x744F1E8", VA = "0x74531E8")]
		internal bool __AddToCombined(GameObject[] _goToAdd, int[] _goToDelete, bool disableRendererInSource, int numResultMats, OrderedDictionary sourceMats2submeshIdx_map, ref IVertexAndTriangleProcessor oldMeshData, MB_MeshVertexChannelFlags newChannels, Stopwatch sw)
		{
			return default;
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x745524C", Offset = "0x745124C", VA = "0x745524C")]
		private Transform[] _getBones(Renderer r, bool isSkinnedMeshWithBones)
		{
			return null;
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x7455260", Offset = "0x7451260", VA = "0x7455260", Slot = "113")]
		public override bool Apply(GenerateUV2Delegate uv2GenerationMethod)
		{
			return default;
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x74552BC", Offset = "0x74512BC", VA = "0x74552BC", Slot = "129")]
		public virtual void ApplyShowHide()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x7455318", Offset = "0x7451318", VA = "0x7455318", Slot = "115")]
		public override bool Apply(bool triangles, bool vertices, bool normals, bool tangents, bool uvs, bool uv2, bool uv3, bool uv4, bool colors, [Optional][DefaultParameterValue(false)] bool bones, [Optional][DefaultParameterValue(false)] bool blendShapesFlag, [Optional] GenerateUV2Delegate uv2GenerationMethod)
		{
			return default;
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x7455404", Offset = "0x7451404", VA = "0x7455404", Slot = "114")]
		public override bool Apply(bool triangles, bool vertices, bool normals, bool tangents, bool uvs, bool uv2, bool uv3, bool uv4, bool uv5, bool uv6, bool uv7, bool uv8, bool colors, [Optional][DefaultParameterValue(false)] bool bones, [Optional][DefaultParameterValue(false)] bool blendShapesFlag, [Optional] GenerateUV2Delegate uv2GenerationMethod)
		{
			return default;
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x745552C", Offset = "0x745152C", VA = "0x745552C", Slot = "118")]
		public override bool UpdateGameObjects(GameObject[] gos, bool recalcBounds, bool updateVertices, bool updateNormals, bool updateTangents, bool updateUV, bool updateUV2, bool updateUV3, bool updateUV4, bool updateColors, bool updateSkinningInfo)
		{
			return default;
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x7456078", Offset = "0x7452078", VA = "0x7456078", Slot = "119")]
		public override bool UpdateGameObjects(GameObject[] gos, bool recalcBounds, bool updateVertices, bool updateNormals, bool updateTangents, bool updateUV, bool updateUV2, bool updateUV3, bool updateUV4, bool updateUV5, bool updateUV6, bool updateUV7, bool updateUV8, bool updateColors, bool updateSkinningInfo)
		{
			return default;
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x7455620", Offset = "0x7451620", VA = "0x7455620")]
		internal bool _UpdateGameObjects(GameObject[] gos, bool recalcBounds, bool updateVertices, bool updateNormals, bool updateTangents, bool updateUV, bool updateUV2, bool updateUV3, bool updateUV4, bool updateUV5, bool updateUV6, bool updateUV7, bool updateUV8, bool updateColors, bool updateSkinningInfo)
		{
			return default;
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x7456190", Offset = "0x7452190", VA = "0x7456190")]
		private bool __UpdateGameObjects(GameObject[] gos, bool recalcBounds, MB_MeshVertexChannelFlags newChannels, bool updateVertices, bool updateNormals, bool updateTangents, bool updateUV, bool updateUV2, bool updateUV3, bool updateUV4, bool updateUV5, bool updateUV6, bool updateUV7, bool updateUV8, bool updateColors, bool updateSkinningInfo, Dictionary<int, MB_Utility.MeshAnalysisResult[]> meshAnalysisResultsCache, OrderedDictionary sourceMats2submeshIdx_map, UVAdjuster_Atlas uVAdjuster)
		{
			return default;
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x7456950", Offset = "0x7452950", VA = "0x7456950")]
		public bool ShowHideGameObjects(GameObject[] toShow, GameObject[] toHide)
		{
			return default;
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x7456A6C", Offset = "0x7452A6C", VA = "0x7456A6C", Slot = "120")]
		public override bool AddDeleteGameObjects(GameObject[] gos, GameObject[] deleteGOs, bool disableRendererInSource = true)
		{
			return default;
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x7456C84", Offset = "0x7452C84", VA = "0x7456C84", Slot = "121")]
		public override bool AddDeleteGameObjectsByID(GameObject[] gos, int[] deleteGOinstanceIDs, bool disableRendererInSource)
		{
			return default;
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x74573C0", Offset = "0x74533C0", VA = "0x74573C0", Slot = "122")]
		public override bool CombinedMeshContains(GameObject go)
		{
			return default;
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x7457418", Offset = "0x7453418", VA = "0x7457418", Slot = "104")]
		public override void ClearBuffers()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x74501B8", Offset = "0x744C1B8", VA = "0x74501B8")]
		private Mesh _NewMesh()
		{
			return null;
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x74578D8", Offset = "0x74538D8", VA = "0x74578D8", Slot = "105")]
		public override void ClearMesh()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x7457970", Offset = "0x7453970", VA = "0x7457970", Slot = "106")]
		public override void ClearMesh(MB2_EditorMethodsInterface editorMethods)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x7457980", Offset = "0x7453980", VA = "0x7457980", Slot = "107")]
		internal override void _DisposeRuntimeCreated()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x7457A58", Offset = "0x7453A58", VA = "0x7457A58", Slot = "108")]
		public override void DestroyMesh()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x7457B80", Offset = "0x7453B80", VA = "0x7457B80", Slot = "109")]
		public override void DestroyMeshEditor(MB2_EditorMethodsInterface editorMethods)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x74529BC", Offset = "0x744E9BC", VA = "0x74529BC")]
		public bool ValidateTargRendererAndMeshAndResultSceneObj()
		{
			return default;
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x7452E50", Offset = "0x744EE50", VA = "0x7452E50")]
		private OrderedDictionary BuildSourceMatsToSubmeshIdxMap(int numResultMats)
		{
			return null;
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x7457D50", Offset = "0x7453D50", VA = "0x7457D50")]
		internal Renderer BuildSceneHierarchPreBake(MB3_MeshCombinerSingle mom, GameObject root, Mesh m, [Optional][DefaultParameterValue(false)] bool createNewChild, [Optional] GameObject[] objsToBeAdded)
		{
			return null;
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x7458718", Offset = "0x7454718", VA = "0x7458718")]
		private static void _ConfigureSceneHierarch(MB3_MeshCombinerSingle mom, GameObject root, MeshRenderer mr, MeshFilter mf, SkinnedMeshRenderer smr, Mesh m, [Optional] GameObject[] objsToBeAdded)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x7458B50", Offset = "0x7454B50", VA = "0x7458B50")]
		private void _SetLightmapIndexIfPreserveLightmapping(Renderer tr)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x74572BC", Offset = "0x74532BC", VA = "0x74572BC")]
		public void BuildSceneMeshObject([Optional] GameObject[] gos, bool createNewChild = false)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x7454F98", Offset = "0x7450F98", VA = "0x7454F98")]
		private bool IsMirrored(Matrix4x4 tm)
		{
			return default;
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x7458D14", Offset = "0x7454D14", VA = "0x7458D14", Slot = "125")]
		public override void CheckIntegrity()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x7458F28", Offset = "0x7454F28", VA = "0x7458F28", Slot = "128")]
		public override List<Material> GetMaterialsOnTargetRenderer()
		{
			return null;
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x745169C", Offset = "0x744D69C", VA = "0x745169C")]
		private bool _UseNativeArrayAPIorNot()
		{
			return default;
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x745315C", Offset = "0x744F15C", VA = "0x745315C")]
		public MB_IMeshCombinerSingle_BoneProcessor Create_BoneProcessor(bool doNativeArrays)
		{
			return null;
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x7451758", Offset = "0x744D758", VA = "0x7451758")]
		public static IVertexAndTriangleProcessor Create_VertexAndTriangleProcessor(bool doNativeArrays)
		{
			return null;
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x7453090", Offset = "0x744F090", VA = "0x7453090")]
		public static IMeshChannelsCacheTaggingInterface Create_MeshChannelsCache(bool doNativeArrays, MB2_LogLevel LOG_LEVEL, MB2_LightmapOptions lightmapOption)
		{
			return null;
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x7459348", Offset = "0x7455348", VA = "0x7459348", Slot = "123")]
		public override void UpdateSkinnedMeshApproximateBounds()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x7459358", Offset = "0x7455358", VA = "0x7459358", Slot = "124")]
		public override void UpdateSkinnedMeshApproximateBoundsFromBones()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x7459650", Offset = "0x7455650", VA = "0x7459650", Slot = "126")]
		public override void UpdateSkinnedMeshApproximateBoundsFromBounds()
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x7459958", Offset = "0x7455958", VA = "0x7459958")]
		private static void _UpdateMaterialsOnTargetRenderer(MB2_TextureBakeResults textureBakeResults, Renderer targetRenderer, SerializableIntArray[] subTris, int numNonZeroLengthSubmeshTris)
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x7459B54", Offset = "0x7455B54", VA = "0x7459B54")]
		public MB3_MeshCombinerSingle()
		{
		}
	}
}
