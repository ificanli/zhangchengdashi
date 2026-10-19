using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Serializable]
	[Token(Token = "0x20000B8")]
	public class MB3_MultiMeshCombiner : MB3_MeshCombiner
	{
		[Serializable]
		[Token(Token = "0x20000B9")]
		public class CombinedMesh
		{
			[Token(Token = "0x40002C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MB3_MeshCombinerSingle combinedMesh;

			[Token(Token = "0x40002C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int extraSpace;

			[Token(Token = "0x40002C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int numVertsInListToDelete;

			[Token(Token = "0x40002C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int numVertsInListToAdd;

			[Token(Token = "0x40002C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<GameObject> gosToAdd;

			[Token(Token = "0x40002C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public List<int> gosToDelete;

			[Token(Token = "0x40002CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public List<GameObject> gosToUpdate;

			[Token(Token = "0x40002CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool isDirty;

			[Token(Token = "0x6000380")]
			[Address(RVA = "0x7482218", Offset = "0x747E218", VA = "0x7482218")]
			public CombinedMesh(int maxNumVertsInMesh, GameObject resultSceneObject, MB2_LogLevel ll)
			{
			}

			[Token(Token = "0x6000381")]
			[Address(RVA = "0x7482F84", Offset = "0x747EF84", VA = "0x7482F84")]
			public bool isEmpty()
			{
				return default;
			}
		}

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static GameObject[] empty;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int[] emptyIDs;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Dictionary<int, CombinedMesh> obj2MeshCombinerMap;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		public List<CombinedMesh> meshCombiners;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private int _maxVertsInMesh;

		[Token(Token = "0x1700006E")]
		public override MB2_LogLevel LOG_LEVEL
		{
			[Token(Token = "0x600035D")]
			[Address(RVA = "0x747E884", Offset = "0x747A884", VA = "0x747E884", Slot = "60")]
			get
			{
				return default;
			}
			[Token(Token = "0x600035E")]
			[Address(RVA = "0x747E88C", Offset = "0x747A88C", VA = "0x747E88C", Slot = "61")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public override MB2_ValidationLevel validationLevel
		{
			[Token(Token = "0x6000360")]
			[Address(RVA = "0x747E9E4", Offset = "0x747A9E4", VA = "0x747E9E4", Slot = "52")]
			get
			{
				return default;
			}
			[Token(Token = "0x600035F")]
			[Address(RVA = "0x747E93C", Offset = "0x747A93C", VA = "0x747E93C", Slot = "53")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public int maxVertsInMesh
		{
			[Token(Token = "0x6000361")]
			[Address(RVA = "0x747E9EC", Offset = "0x747A9EC", VA = "0x747E9EC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x747E9F4", Offset = "0x747A9F4", VA = "0x747E9F4")]
			set
			{
			}
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x747EB58", Offset = "0x747AB58", VA = "0x747EB58", Slot = "111")]
		public override int GetNumObjectsInCombined()
		{
			return default;
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x747EBA8", Offset = "0x747ABA8", VA = "0x747EBA8", Slot = "110")]
		public override List<GameObject> GetObjectsInCombined()
		{
			return null;
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x747ECB4", Offset = "0x747ACB4", VA = "0x747ECB4", Slot = "103")]
		public override int GetLightmapIndex()
		{
			return default;
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x747ED4C", Offset = "0x747AD4C", VA = "0x747ED4C", Slot = "122")]
		public override bool CombinedMeshContains(GameObject go)
		{
			return default;
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x747EDB8", Offset = "0x747ADB8", VA = "0x747EDB8")]
		private bool _validateTextureBakeResults()
		{
			return default;
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x747EEF8", Offset = "0x747AEF8", VA = "0x747EEF8", Slot = "113")]
		public override bool Apply(GenerateUV2Delegate uv2GenerationMethod)
		{
			return default;
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x747F108", Offset = "0x747B108", VA = "0x747F108", Slot = "115")]
		public override bool Apply(bool triangles, bool vertices, bool normals, bool tangents, bool uvs, bool uv2, bool uv3, bool uv4, bool colors, [Optional][DefaultParameterValue(false)] bool bones, [Optional][DefaultParameterValue(false)] bool blendShapeFlag, [Optional] GenerateUV2Delegate uv2GenerationMethod)
		{
			return default;
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x747F194", Offset = "0x747B194", VA = "0x747F194", Slot = "114")]
		public override bool Apply(bool triangles, bool vertices, bool normals, bool tangents, bool uvs, bool uv2, bool uv3, bool uv4, bool uv5, bool uv6, bool uv7, bool uv8, bool colors, [Optional][DefaultParameterValue(false)] bool bones, [Optional][DefaultParameterValue(false)] bool blendShapesFlag, [Optional] GenerateUV2Delegate uv2GenerationMethod)
		{
			return default;
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x747F450", Offset = "0x747B450", VA = "0x747F450", Slot = "123")]
		public override void UpdateSkinnedMeshApproximateBounds()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x747F4EC", Offset = "0x747B4EC", VA = "0x747F4EC", Slot = "124")]
		public override void UpdateSkinnedMeshApproximateBoundsFromBones()
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x747F588", Offset = "0x747B588", VA = "0x747F588", Slot = "126")]
		public override void UpdateSkinnedMeshApproximateBoundsFromBounds()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x747F624", Offset = "0x747B624", VA = "0x747F624", Slot = "118")]
		public override bool UpdateGameObjects(GameObject[] gos, bool recalcBounds, bool updateVertices, bool updateNormals, bool updateTangents, bool updateUV, bool updateUV2, bool updateUV3, bool updateUV4, bool updateColors, bool updateSkinningInfo)
		{
			return default;
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x747F6A8", Offset = "0x747B6A8", VA = "0x747F6A8", Slot = "119")]
		public override bool UpdateGameObjects(GameObject[] gos, bool recalcBounds, bool updateVertices, bool updateNormals, bool updateTangents, bool updateUV, bool updateUV2, bool updateUV3, bool updateUV4, bool updateUV5, bool updateUV6, bool updateUV7, bool updateUV8, bool updateColors, bool updateSkinningInfo)
		{
			return default;
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x747FC08", Offset = "0x747BC08", VA = "0x747FC08", Slot = "120")]
		public override bool AddDeleteGameObjects(GameObject[] gos, GameObject[] deleteGOs, bool disableRendererInSource = true)
		{
			return default;
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x747FDF8", Offset = "0x747BDF8", VA = "0x747FDF8", Slot = "121")]
		public override bool AddDeleteGameObjectsByID(GameObject[] gos, int[] deleteGOinstanceIDs, bool disableRendererInSource = true)
		{
			return default;
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x7480300", Offset = "0x747C300", VA = "0x7480300")]
		private bool _validate(GameObject[] gos, int[] deleteGOinstanceIDs)
		{
			return default;
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x7480AC0", Offset = "0x747CAC0", VA = "0x7480AC0")]
		private void _distributeAmongBakers(GameObject[] gos, int[] deleteGOinstanceIDs)
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x74813FC", Offset = "0x747D3FC", VA = "0x74813FC")]
		private bool _bakeStep1(GameObject[] gos, int[] deleteGOinstanceIDs, bool disableRendererInSource)
		{
			return default;
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x74826D4", Offset = "0x747E6D4", VA = "0x74826D4", Slot = "104")]
		public override void ClearBuffers()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x74827A4", Offset = "0x747E7A4", VA = "0x74827A4", Slot = "105")]
		public override void ClearMesh()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x74827D4", Offset = "0x747E7D4", VA = "0x74827D4", Slot = "106")]
		public override void ClearMesh(MB2_EditorMethodsInterface editorMethods)
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x7482804", Offset = "0x747E804", VA = "0x7482804", Slot = "107")]
		internal override void _DisposeRuntimeCreated()
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x74828A0", Offset = "0x747E8A0", VA = "0x74828A0", Slot = "108")]
		public override void DestroyMesh()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x7482A64", Offset = "0x747EA64", VA = "0x7482A64", Slot = "109")]
		public override void DestroyMeshEditor(MB2_EditorMethodsInterface editorMethods)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x748237C", Offset = "0x747E37C", VA = "0x748237C")]
		private void _setMBValues(MB3_MeshCombinerSingle targ)
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x7482C08", Offset = "0x747EC08", VA = "0x7482C08", Slot = "128")]
		public override List<Material> GetMaterialsOnTargetRenderer()
		{
			return null;
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x7482D5C", Offset = "0x747ED5C", VA = "0x7482D5C", Slot = "125")]
		public override void CheckIntegrity()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x7482E1C", Offset = "0x747EE1C", VA = "0x7482E1C")]
		public MB3_MultiMeshCombiner()
		{
		}
	}
}
