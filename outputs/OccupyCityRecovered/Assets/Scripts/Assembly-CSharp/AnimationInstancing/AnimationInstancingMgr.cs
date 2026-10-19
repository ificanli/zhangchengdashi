using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace AnimationInstancing
{
	[Token(Token = "0x2000F5B")]
	[AddComponentMenu("AnimationInstancingMgr")]
	public class AnimationInstancingMgr : SingletonAnimation<AnimationInstancingMgr>
	{
		[Token(Token = "0x2000F5C")]
		public class InstanceData
		{
			[Token(Token = "0x4006A31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<Matrix4x4[]>[] worldMatrix;

			[Token(Token = "0x4006A32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<float[]>[] frameIndex;

			[Token(Token = "0x4006A33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<float[]>[] preFrameIndex;

			[Token(Token = "0x4006A34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<float[]>[] transitionProgress;

			[Token(Token = "0x6005C48")]
			[Address(RVA = "0x43AAF08", Offset = "0x43A6F08", VA = "0x43AAF08")]
			public InstanceData()
			{
			}
		}

		[Token(Token = "0x2000F5D")]
		public class InstancingPackage
		{
			[Token(Token = "0x4006A35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material platShadowInstanceMaterial;

			[Token(Token = "0x4006A36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Material[] material;

			[Token(Token = "0x4006A37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int animationTextureIndex;

			[Token(Token = "0x4006A38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int subMeshCount;

			[Token(Token = "0x4006A39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int instancingCount;

			[Token(Token = "0x4006A3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int size;

			[Token(Token = "0x4006A3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public MaterialPropertyBlock propertyBlock;

			[Token(Token = "0x6005C49")]
			[Address(RVA = "0x43AA7B4", Offset = "0x43A67B4", VA = "0x43AA7B4")]
			public InstancingPackage()
			{
			}
		}

		[Token(Token = "0x2000F5E")]
		public class MaterialBlock
		{
			[Token(Token = "0x4006A3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InstanceData instanceData;

			[Token(Token = "0x4006A3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int[] runtimePackageIndex;

			[Token(Token = "0x4006A3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<InstancingPackage>[] packageList;

			[Token(Token = "0x6005C4A")]
			[Address(RVA = "0x43AC3E8", Offset = "0x43A83E8", VA = "0x43AC3E8")]
			public MaterialBlock()
			{
			}
		}

		[Token(Token = "0x2000F5F")]
		public class VertexCache
		{
			[Token(Token = "0x4006A3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int nameCode;

			[Token(Token = "0x4006A40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Mesh mesh;

			[Token(Token = "0x4006A41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Dictionary<int, MaterialBlock> instanceBlockList;

			[Token(Token = "0x4006A42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector4[] weight;

			[Token(Token = "0x4006A43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector4[] boneIndex;

			[Token(Token = "0x4006A44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Material[] materials;

			[Token(Token = "0x4006A45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Matrix4x4[] bindPose;

			[Token(Token = "0x4006A46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform[] bonePose;

			[Token(Token = "0x4006A47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public int boneTextureIndex;

			[Token(Token = "0x4006A48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public ShadowCastingMode shadowcastingMode;

			[Token(Token = "0x4006A49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public bool receiveShadow;

			[Token(Token = "0x4006A4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public int layer;

			[Token(Token = "0x6005C4B")]
			[Address(RVA = "0x43AC3F0", Offset = "0x43A83F0", VA = "0x43AC3F0")]
			public VertexCache()
			{
			}
		}

		[Token(Token = "0x2000F60")]
		public class AnimationTexture
		{
			[Token(Token = "0x17000F7E")]
			public string name
			{
				[Token(Token = "0x6005C4C")]
				[Address(RVA = "0x43ACEE8", Offset = "0x43A8EE8", VA = "0x43ACEE8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6005C4D")]
				[Address(RVA = "0x43ACEF0", Offset = "0x43A8EF0", VA = "0x43ACEF0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x17000F7F")]
			public Texture2D[] boneTexture
			{
				[Token(Token = "0x6005C4E")]
				[Address(RVA = "0x43ACEF8", Offset = "0x43A8EF8", VA = "0x43ACEF8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6005C4F")]
				[Address(RVA = "0x43ACF00", Offset = "0x43A8F00", VA = "0x43ACF00")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x17000F80")]
			public int blockWidth
			{
				[Token(Token = "0x6005C50")]
				[Address(RVA = "0x43ACF08", Offset = "0x43A8F08", VA = "0x43ACF08")]
				[CompilerGenerated]
				get;
				[Token(Token = "0x6005C51")]
				[Address(RVA = "0x43ACF10", Offset = "0x43A8F10", VA = "0x43ACF10")]
				[CompilerGenerated]
				set;
			}

			[Token(Token = "0x17000F81")]
			public int blockHeight
			{
				[Token(Token = "0x6005C52")]
				[Address(RVA = "0x43ACF18", Offset = "0x43A8F18", VA = "0x43ACF18")]
				[CompilerGenerated]
				get;
				[Token(Token = "0x6005C53")]
				[Address(RVA = "0x43ACF20", Offset = "0x43A8F20", VA = "0x43ACF20")]
				[CompilerGenerated]
				set;
			}

			[Token(Token = "0x6005C54")]
			[Address(RVA = "0x43AA7AC", Offset = "0x43A67AC", VA = "0x43AA7AC")]
			public AnimationTexture()
			{
			}
		}

		[Token(Token = "0x4006A25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<AnimationInstancing> aniInstancingList;

		[Token(Token = "0x4006A26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform cameraTransform;

		[Token(Token = "0x4006A27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<int, VertexCache> vertexCachePool;

		[Token(Token = "0x4006A28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<int, InstanceData> instanceDataPool;

		[Token(Token = "0x4006A29")]
		private const int InstancingSizePerPackage = 200;

		[Token(Token = "0x4006A2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int instancingPackageSize;

		[Token(Token = "0x4006A2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<AnimationTexture> animationTextureList;

		[Token(Token = "0x4006A2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool useInstancing;

		[Token(Token = "0x4006A2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoundingSphere[] boundingSphere;

		[Token(Token = "0x4006A2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int usedBoundingSphereCount;

		[Token(Token = "0x4006A2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CullingGroup cullingGroup;

		[Token(Token = "0x4006A30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Material platShadowInstanceMaterial;

		[Token(Token = "0x17000F7C")]
		public int InstancingPackageSize
		{
			[Token(Token = "0x6005C19")]
			[Address(RVA = "0x43A645C", Offset = "0x43A245C", VA = "0x43A645C")]
			get
			{
				return instancingPackageSize;
			}
			[Token(Token = "0x6005C1A")]
			[Address(RVA = "0x43A6464", Offset = "0x43A2464", VA = "0x43A6464")]
			set
			{
				instancingPackageSize = value;
			}
		}

		[Token(Token = "0x17000F7D")]
		public bool UseInstancing
		{
			[Token(Token = "0x6005C1B")]
			[Address(RVA = "0x43A646C", Offset = "0x43A246C", VA = "0x43A646C")]
			get
			{
				return useInstancing;
			}
			[Token(Token = "0x6005C1C")]
			[Address(RVA = "0x43A6474", Offset = "0x43A2474", VA = "0x43A6474")]
			set
			{
				useInstancing = value;
			}
		}

		[Token(Token = "0x6005C1D")]
		[Address(RVA = "0x43A6480", Offset = "0x43A2480", VA = "0x43A6480")]
		public static AnimationInstancingMgr GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6005C1E")]
		[Address(RVA = "0x43A64E4", Offset = "0x43A24E4", VA = "0x43A64E4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6005C1F")]
		[Address(RVA = "0x43A674C", Offset = "0x43A274C", VA = "0x43A674C")]
		private void Start()
		{
		}

		[Token(Token = "0x6005C20")]
		[Address(RVA = "0x43A6648", Offset = "0x43A2648", VA = "0x43A6648")]
		private void InitializeCullingGroup()
		{
		}

		[Token(Token = "0x6005C21")]
		[Address(RVA = "0x43A6750", Offset = "0x43A2750", VA = "0x43A6750")]
		private void Update()
		{
		}

		[Token(Token = "0x6005C22")]
		[Address(RVA = "0x43A7208", Offset = "0x43A3208", VA = "0x43A7208")]
		private void Render()
		{
		}

		[Token(Token = "0x6005C23")]
		[Address(RVA = "0x43A81A4", Offset = "0x43A41A4", VA = "0x43A81A4")]
		private void DestroyAllManagedResources()
		{
		}

		[Token(Token = "0x6005C24")]
		[Address(RVA = "0x43A86F4", Offset = "0x43A46F4", VA = "0x43A86F4")]
		public void Clear()
		{
		}

		[Token(Token = "0x6005C25")]
		[Address(RVA = "0x43A87C0", Offset = "0x43A47C0", VA = "0x43A87C0")]
		public GameObject CreateInstance(GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x6005C26")]
		[Address(RVA = "0x43A8934", Offset = "0x43A4934", VA = "0x43A8934")]
		public bool AddInstance(GameObject obj)
		{
			return default;
		}

		[Token(Token = "0x6005C27")]
		[Address(RVA = "0x43A8C24", Offset = "0x43A4C24", VA = "0x43A8C24")]
		public void RemoveInstance(AnimationInstancing instance)
		{
		}

		[Token(Token = "0x6005C28")]
		[Address(RVA = "0x43A8CDC", Offset = "0x43A4CDC", VA = "0x43A8CDC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6005C29")]
		[Address(RVA = "0x43A9244", Offset = "0x43A5244", VA = "0x43A9244")]
		private void RefreshMaterial()
		{
		}

		[Token(Token = "0x6005C2A")]
		[Address(RVA = "0x43A67A0", Offset = "0x43A27A0", VA = "0x43A67A0")]
		private void ApplyBoneMatrix()
		{
		}

		[Token(Token = "0x6005C2B")]
		[Address(RVA = "0x43A99C0", Offset = "0x43A59C0", VA = "0x43A99C0")]
		private void ApplyRootMotion(AnimationInstancing instance)
		{
		}

		[Token(Token = "0x6005C2C")]
		[Address(RVA = "0x43AA150", Offset = "0x43A6150", VA = "0x43AA150")]
		private int FindTexture_internal(string name)
		{
			return default;
		}

		[Token(Token = "0x6005C2D")]
		[Address(RVA = "0x43AA1FC", Offset = "0x43A61FC", VA = "0x43AA1FC")]
		public AnimationTexture FindTexture(string name)
		{
			return null;
		}

		[Token(Token = "0x6005C2E")]
		[Address(RVA = "0x43AA274", Offset = "0x43A6274", VA = "0x43AA274")]
		public AnimationTexture FindTexture(int index)
		{
			return null;
		}

		[Token(Token = "0x6005C2F")]
		[Address(RVA = "0x43AA2F8", Offset = "0x43A62F8", VA = "0x43AA2F8")]
		private int BuildVertexCacheKey(string prefabName, int renderName, int alias = 0)
		{
			return default;
		}

		[Token(Token = "0x6005C30")]
		[Address(RVA = "0x43AA360", Offset = "0x43A6360", VA = "0x43AA360")]
		private int BuildInstanceDataKey(string prefabName, int alias = 0)
		{
			return default;
		}

		[Token(Token = "0x6005C31")]
		[Address(RVA = "0x43AA3B8", Offset = "0x43A63B8", VA = "0x43AA3B8")]
		public VertexCache FindVertexCache(string prefabName, int renderName, int alias = 0)
		{
			return null;
		}

		[Token(Token = "0x6005C32")]
		[Address(RVA = "0x43AA44C", Offset = "0x43A644C", VA = "0x43AA44C")]
		public bool ImportAnimationTexture(string prefabName, Texture2D[] bakeTexture, int blockWidth, int blockHeight)
		{
			return default;
		}

		[Token(Token = "0x6005C33")]
		[Address(RVA = "0x43A8D08", Offset = "0x43A4D08", VA = "0x43A8D08")]
		private void ReleaseBuffer()
		{
		}

		[Token(Token = "0x6005C34")]
		[Address(RVA = "0x43A9C70", Offset = "0x43A5C70", VA = "0x43A9C70")]
		public InstancingPackage CreatePackage(InstanceData data, Mesh mesh, Material[] originalMaterial, int animationIndex)
		{
			return null;
		}

		[Token(Token = "0x6005C35")]
		[Address(RVA = "0x43AA7C4", Offset = "0x43A67C4", VA = "0x43AA7C4")]
		private Material CreateRuntimeInstancingMaterial(Material sourceMaterial)
		{
			return null;
		}

		[Token(Token = "0x6005C36")]
		[Address(RVA = "0x43AA96C", Offset = "0x43A696C", VA = "0x43AA96C")]
		private Shader ResolveRuntimeInstancingShader(Shader sourceShader)
		{
			return null;
		}

		[Token(Token = "0x6005C37")]
		[Address(RVA = "0x43AAC08", Offset = "0x43A6C08", VA = "0x43AAC08")]
		private int GetIdentify(Material[] mat)
		{
			return default;
		}

		[Token(Token = "0x6005C38")]
		[Address(RVA = "0x43AAC88", Offset = "0x43A6C88", VA = "0x43AAC88")]
		private InstanceData CreateInstanceData(int packageCount)
		{
			return null;
		}

		[Token(Token = "0x6005C39")]
		[Address(RVA = "0x43AAF10", Offset = "0x43A6F10", VA = "0x43AAF10")]
		public void AddMeshVertex(string prefabName, AnimationInstancing.LodInfo[] lodInfo, Transform[] bones, List<Matrix4x4> bindPose, int bonePerVertex, [Optional] string alias)
		{
		}

		[Token(Token = "0x6005C3A")]
		[Address(RVA = "0x43AC36C", Offset = "0x43A836C", VA = "0x43AC36C")]
		private int GetPackageCount(VertexCache vertexCache)
		{
			return default;
		}

		[Token(Token = "0x6005C3B")]
		[Address(RVA = "0x43AB730", Offset = "0x43A7730", VA = "0x43AB730")]
		private MaterialBlock CreateBlock(VertexCache cache, Material[] materials)
		{
			return null;
		}

		[Token(Token = "0x6005C3C")]
		[Address(RVA = "0x43AB98C", Offset = "0x43A798C", VA = "0x43AB98C")]
		private VertexCache CreateVertexCache(string prefabName, int renderName, int alias, Mesh mesh)
		{
			return null;
		}

		[Token(Token = "0x6005C3D")]
		[Address(RVA = "0x43ABB9C", Offset = "0x43A7B9C", VA = "0x43ABB9C")]
		private void SetupVertexCache(VertexCache vertexCache, MaterialBlock block, SkinnedMeshRenderer render, Transform[] boneTransform, int bonePerVertex)
		{
		}

		[Token(Token = "0x6005C3E")]
		[Address(RVA = "0x43AC400", Offset = "0x43A8400", VA = "0x43AC400")]
		private bool NeedBoneRemap(Transform[] renderBones, Transform[] boneTransform)
		{
			return default;
		}

		[Token(Token = "0x6005C3F")]
		[Address(RVA = "0x43AC65C", Offset = "0x43A865C", VA = "0x43AC65C")]
		private int FindBoneIndex(Transform bone, Transform[] boneTransform)
		{
			return default;
		}

		[Token(Token = "0x6005C40")]
		[Address(RVA = "0x43AC1C0", Offset = "0x43A81C0", VA = "0x43AC1C0")]
		private void SetupVertexCache(VertexCache vertexCache, MaterialBlock block, MeshRenderer render, Mesh mesh, Transform[] boneTransform, int bonePerVertex)
		{
		}

		[Token(Token = "0x6005C41")]
		[Address(RVA = "0x43AC4EC", Offset = "0x43A84EC", VA = "0x43AC4EC")]
		private int FindClosestBoneIndex(Transform renderTransform, Transform[] boneTransform)
		{
			return default;
		}

		[Token(Token = "0x6005C42")]
		[Address(RVA = "0x43AC7E4", Offset = "0x43A87E4", VA = "0x43AC7E4")]
		public void SetupAdditionalData(VertexCache vertexCache)
		{
		}

		[Token(Token = "0x6005C43")]
		[Address(RVA = "0x43A95D8", Offset = "0x43A55D8", VA = "0x43A95D8")]
		public void PreparePackageMaterial(InstancingPackage package, VertexCache vertexCache, int aniTextureIndex)
		{
		}

		[Token(Token = "0x6005C44")]
		[Address(RVA = "0x43ACC7C", Offset = "0x43A8C7C", VA = "0x43ACC7C")]
		public void AddBoundingSphere(AnimationInstancing instance)
		{
		}

		[Token(Token = "0x6005C45")]
		[Address(RVA = "0x43ACD04", Offset = "0x43A8D04", VA = "0x43ACD04")]
		private void CullingStateChanged(CullingGroupEvent evt)
		{
		}

		[Token(Token = "0x6005C46")]
		[Address(RVA = "0x43AC9C8", Offset = "0x43A89C8", VA = "0x43AC9C8")]
		public void BindAttachment(VertexCache parentCache, VertexCache attachmentCache, Mesh sharedMesh, int boneIndex)
		{
		}

		[Token(Token = "0x6005C47")]
		[Address(RVA = "0x43ACE24", Offset = "0x43A8E24", VA = "0x43ACE24")]
		public AnimationInstancingMgr()
		{
		}
	}
}
