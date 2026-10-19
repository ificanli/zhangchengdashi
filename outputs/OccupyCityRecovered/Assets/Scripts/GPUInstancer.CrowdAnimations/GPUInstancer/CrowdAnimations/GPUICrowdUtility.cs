using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer.CrowdAnimations
{
	[Token(Token = "0x200002F")]
	public static class GPUICrowdUtility
	{
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x73CB57C", Offset = "0x73C757C", VA = "0x73CB57C")]
		public static void SetAnimationData(GPUICrowdRuntimeData runtimeData)
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x73C65E0", Offset = "0x73C25E0", VA = "0x73C65E0")]
		public static void SetAppendBuffers(GPUICrowdRuntimeData runtimeData)
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x73CC144", Offset = "0x73C8144", VA = "0x73CC144")]
		public static void SetMeshUVs(GPUICrowdRuntimeData runtimeData)
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x73D09E0", Offset = "0x73CC9E0", VA = "0x73D09E0")]
		public static Mesh GenerateMeshWithUVs(Mesh originalMesh, GPUISkinnedMeshData smd)
		{
			return null;
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x73D076C", Offset = "0x73CC76C", VA = "0x73D076C")]
		public static void ReadBakedBoneDataFromTexture(GPUICrowdPrototype prototype, GPUICrowdRuntimeData runtimeData)
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x73D0E84", Offset = "0x73CCE84", VA = "0x73D0E84")]
		public static void SetCrowdPrefabPrototypes(GameObject gameObject, List<GPUInstancerPrototype> prototypeList, List<GameObject> prefabList, bool forceNew)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x73D112C", Offset = "0x73CD12C", VA = "0x73D112C")]
		public static GPUICrowdPrototype GenerateCrowdPrototype(GameObject go, bool forceNew, [Optional][DefaultParameterValue(true)] bool attachScript, [Optional] GPUICrowdPrototype copySettingsFrom)
		{
			return null;
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x73D1620", Offset = "0x73CD620", VA = "0x73D1620")]
		public static GPUICrowdAnimationData GenerateCrowdAnimationData(GPUICrowdPrototype prototype)
		{
			return null;
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x73D16B8", Offset = "0x73CD6B8", VA = "0x73D16B8")]
		public static bool IsShaderInstanced(Shader shader)
		{
			return default;
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x73D16C0", Offset = "0x73CD6C0", VA = "0x73D16C0")]
		public static void GenerateInstancedShadersForGameObject(GPUInstancerPrototype prototype)
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x73D1A78", Offset = "0x73CDA78", VA = "0x73D1A78")]
		public static Transform FindDeepChild(this Transform aParent, string aName)
		{
			return null;
		}
	}
}
