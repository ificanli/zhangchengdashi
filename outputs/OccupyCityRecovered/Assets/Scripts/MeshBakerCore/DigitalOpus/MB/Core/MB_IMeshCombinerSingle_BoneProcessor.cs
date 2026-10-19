using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x20000C9")]
	public interface MB_IMeshCombinerSingle_BoneProcessor : IDisposable
	{
		[Token(Token = "0x600041B")]
		bool GetCachedSMRMeshData(MB3_MeshCombinerSingle.MB_DynamicGameObject dgo);

		[Token(Token = "0x600041C")]
		void AddBonesToNewBonesArrayAndAdjustBWIndexes1(MB3_MeshCombinerSingle.MB_DynamicGameObject dgo, int vertsIdx);

		[Token(Token = "0x600041D")]
		void AllocateAndSetupSMRDataStructures(List<MB3_MeshCombinerSingle.MB_DynamicGameObject> toAddDGOs, List<MB3_MeshCombinerSingle.MB_DynamicGameObject> mbDynamicObjectsInCombinedMesh, int newVertSize, MB3_MeshCombinerSingle.IVertexAndTriangleProcessor vertexAndTriangleProcessor);

		[Token(Token = "0x600041E")]
		void BuildBoneIdx2DGOMapIfNecessary(int[] _goToDelete);

		[Token(Token = "0x600041F")]
		void CopyBonesWeAreKeepingToNewBonesArrayAndAdjustBWIndexes(int totalDeleteVerts);

		[Token(Token = "0x6000420")]
		void InsertNewBonesIntoBonesArray();

		[Token(Token = "0x6000421")]
		int GetNewBonesSize();

		[Token(Token = "0x6000422")]
		void RemoveBonesForDgosWeAreDeleting(MB3_MeshCombinerSingle.MB_DynamicGameObject dgo);

		[Token(Token = "0x6000423")]
		void CopyBoneWeightsFromMeshForDGOsInCombined(MB3_MeshCombinerSingle.MB_DynamicGameObject dgo, int targVidx);

		[Token(Token = "0x6000424")]
		void CopyVertsNormsTansToBuffers(MB3_MeshCombinerSingle.MB_DynamicGameObject dgo, MB_IMeshBakerSettings settings, int vertsIdx, Vector3[] nnorms, Vector4[] ntangs, Vector3[] nverts, Vector3[] normals, Vector4[] tangents, Vector3[] verts);

		[Token(Token = "0x6000425")]
		void CopyVertsNormsTansToBuffers(MB3_MeshCombinerSingle.MB_DynamicGameObject dgo, MB_IMeshBakerSettings settings, int vertsIdx, NativeSlice<Vector3> nnorms, NativeSlice<Vector4> ntangs, NativeSlice<Vector3> nverts, NativeSlice<Vector3> normals, NativeSlice<Vector4> tangents, NativeSlice<Vector3> verts);

		[Token(Token = "0x6000426")]
		void DisposeOfTemporarySMRData();

		[Token(Token = "0x6000427")]
		void ApplySMRdataToMeshToBuffer();

		[Token(Token = "0x6000428")]
		void ApplySMRdataToMesh(MB3_MeshCombinerSingle combiner, Mesh mesh);

		[Token(Token = "0x6000429")]
		void UpdateGameObjects_ReadBoneWeightInfoFromCombinedMesh();

		[Token(Token = "0x600042A")]
		void UpdateGameObjects_UpdateBWIndexes(MB3_MeshCombinerSingle.MB_DynamicGameObject dgo);

		[Token(Token = "0x600042B")]
		bool DB_CheckIntegrity();
	}
}
