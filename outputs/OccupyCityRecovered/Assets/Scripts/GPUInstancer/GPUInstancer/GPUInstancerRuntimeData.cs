using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Jobs;

namespace GPUInstancer
{
	[Token(Token = "0x2000040")]
	public class GPUInstancerRuntimeData
	{
		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GPUInstancerPrototype prototype;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<GPUInstancerPrototypeLOD> instanceLODs;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Bounds instanceBounds;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float[] lodSizes;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float lodBiasApplied;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Obsolete("The instanceDataArray property is obsolete. Use instanceDataNativeArray instead.", true)]
		public Matrix4x4[] instanceDataArray;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public NativeArray<Matrix4x4> instanceDataNativeArray;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public TransformAccessArray instanceTransformAccessArray;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public JobHandle dependentJob;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int instanceCount;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public int bufferSize;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public ComputeBuffer transformationMatrixVisibilityBuffer;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public ComputeBuffer argsBuffer;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public ComputeBuffer instanceLODDataBuffer;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public RenderTexture instanceLODDataTexture;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public uint[] args;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool hasShadowCasterBuffer;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Material shadowCasterMaterial;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public ComputeBuffer shadowArgsBuffer;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public uint[] shadowArgs;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public bool transformDataModified;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private List<Material> _lodFadeMaterials;

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x73DB650", Offset = "0x73D7650", VA = "0x73DB650")]
		public GPUInstancerRuntimeData(GPUInstancerPrototype prototype)
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x73DB6E8", Offset = "0x73D76E8", VA = "0x73DB6E8", Slot = "4")]
		public virtual void InitializeData()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x73DB6EC", Offset = "0x73D76EC", VA = "0x73DB6EC", Slot = "5")]
		public virtual void ReleaseBuffers()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x73DB780", Offset = "0x73D7780", VA = "0x73DB780")]
		public void EnableLODFade(Material mat)
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x73DB904", Offset = "0x73D7904", VA = "0x73DB904")]
		public void DisableLODFade()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x73DBAE0", Offset = "0x73D7AE0", VA = "0x73DBAE0", Slot = "6")]
		public virtual void AddLodAndRenderer(Mesh mesh, List<Material> materials, MaterialPropertyBlock mpb, bool castShadows, [Optional][DefaultParameterValue(-1f)] float lodSize, [Optional] MaterialPropertyBlock shadowMPB, bool excludeBounds = false, int layer = 0, bool receiveShadows = true)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x73DBC1C", Offset = "0x73D7C1C", VA = "0x73DBC1C", Slot = "7")]
		public virtual void AddLod(float screenRelativeTransitionHeight = -1f, bool excludeBounds = false)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x73DBF38", Offset = "0x73D7F38", VA = "0x73DBF38", Slot = "8")]
		public virtual void AddRenderer(int lod, Mesh mesh, List<Material> materials, Matrix4x4 transformOffset, MaterialPropertyBlock mpb, bool castShadows, [Optional][DefaultParameterValue(0)] int layer, [Optional] MaterialPropertyBlock shadowMPB, [Optional] Renderer rendererRef, bool receiveShadows = true)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x73DC32C", Offset = "0x73D832C", VA = "0x73DC32C", Slot = "9")]
		public virtual void CalculateBounds()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x73DC974", Offset = "0x73D8974", VA = "0x73DC974", Slot = "10")]
		public virtual bool CreateRenderersFromGameObject(GPUInstancerPrototype prototype)
		{
			return default;
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x73DCB20", Offset = "0x73D8B20", VA = "0x73DCB20", Slot = "11")]
		public virtual bool GenerateLODsFromLODGroup(GPUInstancerPrototype prototype)
		{
			return default;
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x73DD5FC", Offset = "0x73D95FC", VA = "0x73DD5FC", Slot = "12")]
		public virtual bool CreateRenderersFromMeshRenderers(int lod, GPUInstancerPrototype prototype)
		{
			return default;
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x73DE064", Offset = "0x73DA064", VA = "0x73DE064", Slot = "13")]
		public virtual void GetMeshRenderersOfTransform(Transform objectTransform, List<MeshRenderer> meshRenderers)
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x73DE320", Offset = "0x73DA320", VA = "0x73DE320")]
		public bool IsLODShadowCasting(int lodLevel)
		{
			return default;
		}
	}
}
