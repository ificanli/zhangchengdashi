using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL
{
	[Token(Token = "0x2000CE0")]
	public class ObjectBuilder
	{
		[Token(Token = "0x2000CE1")]
		public class ProgressInfo
		{
			[Token(Token = "0x4005C20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int materialsLoaded;

			[Token(Token = "0x4005C21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int objectsLoaded;

			[Token(Token = "0x4005C22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int groupsLoaded;

			[Token(Token = "0x4005C23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int numGroups;

			[Token(Token = "0x6005070")]
			[Address(RVA = "0x42C8D10", Offset = "0x42C4D10", VA = "0x42C8D10")]
			public ProgressInfo()
			{
			}
		}

		[Token(Token = "0x2000CE2")]
		private class BuildStatus
		{
			[Token(Token = "0x4005C24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool newObject;

			[Token(Token = "0x4005C25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int objCount;

			[Token(Token = "0x4005C26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int subObjCount;

			[Token(Token = "0x4005C27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int idxCount;

			[Token(Token = "0x4005C28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int grpIdx;

			[Token(Token = "0x4005C29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int numGroups;

			[Token(Token = "0x4005C2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int grpFaceIdx;

			[Token(Token = "0x4005C2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int meshPartIdx;

			[Token(Token = "0x4005C2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int totFaceIdxCount;

			[Token(Token = "0x4005C2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public GameObject currObjGameObject;

			[Token(Token = "0x4005C2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal GameObject subObjParent;

			[Token(Token = "0x6005071")]
			[Address(RVA = "0x42C8CA8", Offset = "0x42C4CA8", VA = "0x42C8CA8")]
			public BuildStatus()
			{
			}
		}

		[Token(Token = "0x4005C17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ImportOptions buildOptions;

		[Token(Token = "0x4005C18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private BuildStatus buildStatus;

		[Token(Token = "0x4005C19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private DataSet currDataSet;

		[Token(Token = "0x4005C1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject currParentObj;

		[Token(Token = "0x4005C1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<string, Material> currMaterials;

		[Token(Token = "0x4005C1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<MaterialData> materialData;

		[Token(Token = "0x4005C1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int MAX_VERTICES_LIMIT_FOR_A_MESH;

		[Token(Token = "0x4005C1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static int MAX_INDICES_LIMIT_FOR_A_MESH;

		[Token(Token = "0x4005C1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int MAX_VERT_COUNT;

		[Token(Token = "0x17000E38")]
		public Dictionary<string, Material> ImportedMaterials
		{
			[Token(Token = "0x6005062")]
			[Address(RVA = "0x42C56D8", Offset = "0x42C16D8", VA = "0x42C56D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000E39")]
		public int NumImportedMaterials
		{
			[Token(Token = "0x6005063")]
			[Address(RVA = "0x42C56E0", Offset = "0x42C16E0", VA = "0x42C56E0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005064")]
		[Address(RVA = "0x42C5738", Offset = "0x42C1738", VA = "0x42C5738")]
		public void InitBuildMaterials(List<MaterialData> materialData, bool hasColors)
		{
		}

		[Token(Token = "0x6005065")]
		[Address(RVA = "0x42C5990", Offset = "0x42C1990", VA = "0x42C5990")]
		public bool BuildMaterials(ProgressInfo info)
		{
			return default;
		}

		[Token(Token = "0x6005066")]
		[Address(RVA = "0x42C670C", Offset = "0x42C270C", VA = "0x42C670C")]
		public void StartBuildObjectAsync(DataSet dataSet, GameObject parentObj, [Optional] Dictionary<string, Material> materials)
		{
		}

		[Token(Token = "0x6005067")]
		[Address(RVA = "0x42C671C", Offset = "0x42C271C", VA = "0x42C671C")]
		public bool BuildObjectAsync(ref ProgressInfo info)
		{
			return default;
		}

		[Token(Token = "0x6005068")]
		[Address(RVA = "0x42C7348", Offset = "0x42C3348", VA = "0x42C7348")]
		public static void Solve(Mesh origMesh)
		{
		}

		[Token(Token = "0x6005069")]
		[Address(RVA = "0x42C7A8C", Offset = "0x42C3A8C", VA = "0x42C7A8C")]
		public static void BuildMeshCollider(GameObject targetObject, bool convex = false, bool isTrigger = false, bool inflateMesh = false, float skinWidth = 0.01f)
		{
		}

		[Token(Token = "0x600506A")]
		[Address(RVA = "0x42C676C", Offset = "0x42C276C", VA = "0x42C676C")]
		protected bool BuildNextObject(GameObject parentObj, Dictionary<string, Material> mats)
		{
			return default;
		}

		[Token(Token = "0x600506B")]
		[Address(RVA = "0x42C7C88", Offset = "0x42C3C88", VA = "0x42C7C88")]
		private GameObject ImportSubObject(GameObject parentObj, DataSet.ObjectData objData, Dictionary<string, Material> mats)
		{
			return null;
		}

		[Token(Token = "0x600506C")]
		[Address(RVA = "0x42C5B60", Offset = "0x42C1B60", VA = "0x42C5B60")]
		private Material BuildMaterial(MaterialData md)
		{
			return null;
		}

		[Token(Token = "0x600506D")]
		[Address(RVA = "0x42C7BE0", Offset = "0x42C3BE0", VA = "0x42C7BE0")]
		private bool Using32bitIndices()
		{
			return default;
		}

		[Token(Token = "0x600506E")]
		[Address(RVA = "0x42C8C40", Offset = "0x42C4C40", VA = "0x42C8C40")]
		public ObjectBuilder()
		{
		}
	}
}
