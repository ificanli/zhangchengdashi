using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace AnimationInstancing
{
	[Token(Token = "0x2000F59")]
	[AddComponentMenu("AnimationInstancing")]
	public class AnimationInstancing : MonoBehaviour, IAnimation
	{
		[Token(Token = "0x2000F5A")]
		public class LodInfo
		{
			[Token(Token = "0x4006A1F")]
			[FieldOffset(Offset = "0x10")]
			public int lodLevel;

			[Token(Token = "0x4006A20")]
			[FieldOffset(Offset = "0x18")]
			public SkinnedMeshRenderer[] skinnedMeshRenderer;

			[Token(Token = "0x4006A21")]
			[FieldOffset(Offset = "0x20")]
			public MeshRenderer[] meshRenderer;

			[Token(Token = "0x4006A22")]
			[FieldOffset(Offset = "0x28")]
			public MeshFilter[] meshFilter;

			[Token(Token = "0x4006A23")]
			[FieldOffset(Offset = "0x30")]
			public AnimationInstancingMgr.VertexCache[] vertexCacheList;

			[Token(Token = "0x4006A24")]
			[FieldOffset(Offset = "0x38")]
			public AnimationInstancingMgr.MaterialBlock[] materialBlockList;

			[Token(Token = "0x6005C18")]
			[Address(RVA = "0x43A6454", Offset = "0x43A2454", VA = "0x43A6454")]
			public LodInfo()
			{
			}
		}

		[Token(Token = "0x40069EF")]
		[FieldOffset(Offset = "0x20")]
		private Animator animator;

		[NonSerialized]
		[Token(Token = "0x40069F0")]
		[FieldOffset(Offset = "0x28")]
		public Transform worldTransform;

		[Token(Token = "0x40069F1")]
		[FieldOffset(Offset = "0x30")]
		public GameObject prototype;

		[Token(Token = "0x40069F2")]
		[FieldOffset(Offset = "0x38")]
		public BoundingSphere boundingSpere;

		[Token(Token = "0x40069F5")]
		[FieldOffset(Offset = "0x58")]
		public float playSpeed;

		[Token(Token = "0x40069F6")]
		[FieldOffset(Offset = "0x5C")]
		public ShadowCastingMode shadowCastingMode;

		[Token(Token = "0x40069F7")]
		[FieldOffset(Offset = "0x60")]
		public bool receiveShadow;

		[NonSerialized]
		[Token(Token = "0x40069F8")]
		[FieldOffset(Offset = "0x64")]
		public int layer;

		[Token(Token = "0x40069F9")]
		[FieldOffset(Offset = "0x68")]
		private float speedParameter;

		[Token(Token = "0x40069FA")]
		[FieldOffset(Offset = "0x6C")]
		private float cacheParameter;

		[Token(Token = "0x40069FB")]
		[FieldOffset(Offset = "0x70")]
		private WrapMode wrapMode;

		[Token(Token = "0x40069FC")]
		[FieldOffset(Offset = "0x74")]
		public bool applyRootMotion;

		[Token(Token = "0x40069FD")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private string initAnimation;

		[Token(Token = "0x40069FE")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TextAsset bakeData;

		[Token(Token = "0x40069FF")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Texture2D[] bakeTexture;

		[Token(Token = "0x4006A00")]
		[FieldOffset(Offset = "0x90")]
		[Range(1f, 4f)]
		public int bonePerVertex;

		[NonSerialized]
		[Token(Token = "0x4006A01")]
		[FieldOffset(Offset = "0x94")]
		public float curFrame;

		[NonSerialized]
		[Token(Token = "0x4006A02")]
		[FieldOffset(Offset = "0x98")]
		public float preAniFrame;

		[NonSerialized]
		[Token(Token = "0x4006A03")]
		[FieldOffset(Offset = "0x9C")]
		public int aniIndex;

		[NonSerialized]
		[Token(Token = "0x4006A04")]
		[FieldOffset(Offset = "0xA0")]
		public int preAniIndex;

		[NonSerialized]
		[Token(Token = "0x4006A05")]
		[FieldOffset(Offset = "0xA4")]
		public int aniTextureIndex;

		[Token(Token = "0x4006A06")]
		[FieldOffset(Offset = "0xA8")]
		private int preAniTextureIndex;

		[Token(Token = "0x4006A07")]
		[FieldOffset(Offset = "0xAC")]
		private float transitionDuration;

		[Token(Token = "0x4006A08")]
		[FieldOffset(Offset = "0xB0")]
		private bool isInTransition;

		[Token(Token = "0x4006A09")]
		[FieldOffset(Offset = "0xB4")]
		private float transitionTimer;

		[NonSerialized]
		[Token(Token = "0x4006A0A")]
		[FieldOffset(Offset = "0xB8")]
		public float transitionProgress;

		[Token(Token = "0x4006A0B")]
		[FieldOffset(Offset = "0xBC")]
		private int eventIndex;

		[Token(Token = "0x4006A0C")]
		[FieldOffset(Offset = "0xC0")]
		public List<AnimationInfo> aniInfo;

		[Token(Token = "0x4006A0D")]
		[FieldOffset(Offset = "0xC8")]
		private ComparerHash comparer;

		[Token(Token = "0x4006A0E")]
		[FieldOffset(Offset = "0xD0")]
		private AnimationInfo searchInfo;

		[Token(Token = "0x4006A0F")]
		[FieldOffset(Offset = "0xD8")]
		private AnimationEvent aniEvent;

		[NonSerialized]
		[Token(Token = "0x4006A10")]
		[FieldOffset(Offset = "0xE0")]
		public LodInfo[] lodInfo;

		[Token(Token = "0x4006A11")]
		[FieldOffset(Offset = "0xE8")]
		private float lodCalculateFrequency;

		[Token(Token = "0x4006A12")]
		[FieldOffset(Offset = "0xEC")]
		private float lodFrequencyCount;

		[NonSerialized]
		[Token(Token = "0x4006A13")]
		[FieldOffset(Offset = "0xF0")]
		public int lodLevel;

		[Token(Token = "0x4006A14")]
		[FieldOffset(Offset = "0xF8")]
		private Transform[] allTransforms;

		[Token(Token = "0x4006A15")]
		[FieldOffset(Offset = "0x100")]
		private bool isMeshRender;

		[NonSerialized]
		[Token(Token = "0x4006A16")]
		[FieldOffset(Offset = "0x108")]
		private List<AnimationInstancing> listAttachment;

		[Token(Token = "0x4006A17")]
		[FieldOffset(Offset = "0x110")]
		private readonly Dictionary<string, float> animationSpeedByName;

		[Token(Token = "0x4006A18")]
		[FieldOffset(Offset = "0x118")]
		private float currentAnimationSpeed;

		[Token(Token = "0x4006A19")]
		[FieldOffset(Offset = "0x11C")]
		private bool forceReplayCurrentAnimation;

		[Token(Token = "0x4006A1A")]
		[FieldOffset(Offset = "0x11D")]
		[SerializeField]
		private bool trimInitializedInstance;

		[Token(Token = "0x4006A1B")]
		[FieldOffset(Offset = "0x11E")]
		[SerializeField]
		private bool trimSkinnedMeshRendererAfterInit;

		[Token(Token = "0x4006A1C")]
		[FieldOffset(Offset = "0x11F")]
		[SerializeField]
		private bool trimBoneHierarchyAfterInit;

		[Token(Token = "0x4006A1D")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private List<string> preservedChildPaths;

		[NonSerialized]
		[Token(Token = "0x4006A1E")]
		[FieldOffset(Offset = "0x128")]
		private bool runtimeTrimApplied;

		[Token(Token = "0x17000F75")]
		public bool visible
		{
			[Token(Token = "0x6005BD3")]
			[Address(RVA = "0x43A0E1C", Offset = "0x439CE1C", VA = "0x43A0E1C")]
			[CompilerGenerated]
			get;
			[Token(Token = "0x6005BD4")]
			[Address(RVA = "0x43A0E24", Offset = "0x439CE24", VA = "0x43A0E24")]
			[CompilerGenerated]
			set;
		}

		[Token(Token = "0x17000F76")]
		public AnimationInstancing parentInstance
		{
			[Token(Token = "0x6005BD5")]
			[Address(RVA = "0x43A0E30", Offset = "0x439CE30", VA = "0x43A0E30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005BD6")]
			[Address(RVA = "0x43A0E38", Offset = "0x439CE38", VA = "0x43A0E38")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000F77")]
		public WrapMode Mode
		{
			[Token(Token = "0x6005BD7")]
			[Address(RVA = "0x43A0E40", Offset = "0x439CE40", VA = "0x43A0E40")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005BD8")]
			[Address(RVA = "0x43A0E48", Offset = "0x439CE48", VA = "0x43A0E48")]
			set
			{
			}
		}

		[Token(Token = "0x17000F78")]
		public TextAsset BakeData
		{
			[Token(Token = "0x6005BDB")]
			[Address(RVA = "0x43A0E70", Offset = "0x439CE70", VA = "0x43A0E70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005BDC")]
			[Address(RVA = "0x43A0E78", Offset = "0x439CE78", VA = "0x43A0E78")]
			set
			{
			}
		}

		[Token(Token = "0x17000F79")]
		public Texture2D[] BakeTexture
		{
			[Token(Token = "0x6005BDD")]
			[Address(RVA = "0x43A0E80", Offset = "0x439CE80", VA = "0x43A0E80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005BDE")]
			[Address(RVA = "0x43A0E88", Offset = "0x439CE88", VA = "0x43A0E88")]
			set
			{
			}
		}

		[Token(Token = "0x17000F7A")]
		public string InitAnimation
		{
			[Token(Token = "0x6005BF4")]
			[Address(RVA = "0x43A4868", Offset = "0x43A0868", VA = "0x43A4868")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F7B")]
		public float attackSpeed
		{
			[Token(Token = "0x6005C0E")]
			[Address(RVA = "0x43A5D2C", Offset = "0x43A1D2C", VA = "0x43A5D2C", Slot = "9")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005BD9")]
		[Address(RVA = "0x43A0E50", Offset = "0x439CE50", VA = "0x43A0E50")]
		public bool IsLoop()
		{
			return default;
		}

		[Token(Token = "0x6005BDA")]
		[Address(RVA = "0x43A0E60", Offset = "0x439CE60", VA = "0x43A0E60")]
		public bool IsPause()
		{
			return default;
		}

		[Token(Token = "0x6005BDF")]
		[Address(RVA = "0x43A0E90", Offset = "0x439CE90", VA = "0x43A0E90")]
		public void ConfigureRuntimeTrim(bool enableTrim, IEnumerable<string> preservePaths)
		{
		}

		[Token(Token = "0x6005BE0")]
		[Address(RVA = "0x43A1314", Offset = "0x439D314", VA = "0x43A1314")]
		private void Start()
		{
		}

		[Token(Token = "0x6005BE1")]
		[Address(RVA = "0x43A228C", Offset = "0x439E28C", VA = "0x43A228C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6005BE2")]
		[Address(RVA = "0x43A2584", Offset = "0x439E584", VA = "0x43A2584")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6005BE3")]
		[Address(RVA = "0x43A2630", Offset = "0x439E630", VA = "0x43A2630")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6005BE4")]
		[Address(RVA = "0x43A26D4", Offset = "0x439E6D4", VA = "0x43A26D4")]
		public bool InitializeAnimation()
		{
			return default;
		}

		[Token(Token = "0x6005BE5")]
		[Address(RVA = "0x43A2AA4", Offset = "0x439EAA4", VA = "0x43A2AA4")]
		public void Prepare(List<AnimationInfo> infoList, ExtraBoneInfo extraBoneInfo)
		{
		}

		[Token(Token = "0x6005BE6")]
		[Address(RVA = "0x43A2104", Offset = "0x439E104", VA = "0x43A2104")]
		private void TryTrimInitializedInstance()
		{
		}

		[Token(Token = "0x6005BE7")]
		[Address(RVA = "0x43A3140", Offset = "0x439F140", VA = "0x43A3140")]
		private void TrimInitializedInstance()
		{
		}

		[Token(Token = "0x6005BE8")]
		[Address(RVA = "0x43A3444", Offset = "0x439F444", VA = "0x43A3444")]
		private HashSet<Transform> CollectBoneTransforms()
		{
			return null;
		}

		[Token(Token = "0x6005BE9")]
		[Address(RVA = "0x43A31FC", Offset = "0x439F1FC", VA = "0x43A31FC")]
		private HashSet<Transform> CollectPreservedTransforms()
		{
			return null;
		}

		[Token(Token = "0x6005BEA")]
		[Address(RVA = "0x43A408C", Offset = "0x43A008C", VA = "0x43A408C")]
		private bool ShouldAutoPreserveTransform(Transform target)
		{
			return default;
		}

		[Token(Token = "0x6005BEB")]
		[Address(RVA = "0x43A3584", Offset = "0x439F584", VA = "0x43A3584")]
		private void ExpandPreservedHierarchyRoots(HashSet<Transform> preservedTransforms, HashSet<Transform> boneTransforms)
		{
		}

		[Token(Token = "0x6005BEC")]
		[Address(RVA = "0x43A432C", Offset = "0x43A032C", VA = "0x43A432C")]
		private Transform FindPreservedBranchRoot(Transform target, HashSet<Transform> boneTransforms)
		{
			return null;
		}

		[Token(Token = "0x6005BED")]
		[Address(RVA = "0x43A391C", Offset = "0x439F91C", VA = "0x43A391C")]
		private void ReparentPreservedTransforms(HashSet<Transform> preservedTransforms, HashSet<Transform> boneTransforms)
		{
		}

		[Token(Token = "0x6005BEE")]
		[Address(RVA = "0x43A446C", Offset = "0x43A046C", VA = "0x43A446C")]
		private bool HasPreservedAncestor(Transform target, HashSet<Transform> preservedTransforms)
		{
			return default;
		}

		[Token(Token = "0x6005BEF")]
		[Address(RVA = "0x43A45C8", Offset = "0x43A05C8", VA = "0x43A45C8")]
		private bool HasBoneAncestor(Transform target, HashSet<Transform> boneTransforms)
		{
			return default;
		}

		[Token(Token = "0x6005BF0")]
		[Address(RVA = "0x43A3B64", Offset = "0x439FB64", VA = "0x43A3B64")]
		private void RemoveSkinnedMeshRenderers(HashSet<Transform> preservedTransforms)
		{
		}

		[Token(Token = "0x6005BF1")]
		[Address(RVA = "0x43A3E08", Offset = "0x439FE08", VA = "0x43A3E08")]
		private void RemoveBoneHierarchy(HashSet<Transform> preservedTransforms)
		{
		}

		[Token(Token = "0x6005BF2")]
		[Address(RVA = "0x43A46D0", Offset = "0x43A06D0", VA = "0x43A46D0")]
		private bool IsTransformUnderPreservedSubtree(Transform target, HashSet<Transform> preservedTransforms)
		{
			return default;
		}

		[Token(Token = "0x6005BF3")]
		[Address(RVA = "0x43A4034", Offset = "0x43A0034", VA = "0x43A4034")]
		private Transform FindRelativeTransform(string relativePath)
		{
			return null;
		}

		[Token(Token = "0x6005BF5")]
		[Address(RVA = "0x43A4870", Offset = "0x43A0870", VA = "0x43A4870")]
		public void SetInitAnimation(string animationName)
		{
		}

		[Token(Token = "0x6005BF6")]
		[Address(RVA = "0x43A305C", Offset = "0x439F05C", VA = "0x43A305C")]
		public void PlayInitAnimation()
		{
		}

		[Token(Token = "0x6005BF7")]
		[Address(RVA = "0x43A1DE8", Offset = "0x439DDE8", VA = "0x43A1DE8")]
		private void CalcBoundingSphere()
		{
		}

		[Token(Token = "0x6005BF8")]
		[Address(RVA = "0x43A4B54", Offset = "0x43A0B54", VA = "0x43A4B54")]
		public void PlayAnimation(string name)
		{
		}

		[Token(Token = "0x6005BF9")]
		[Address(RVA = "0x43A49A4", Offset = "0x43A09A4", VA = "0x43A49A4")]
		public void PlayAnimation(int animationIndex)
		{
		}

		[Token(Token = "0x6005BFA")]
		[Address(RVA = "0x43A4D1C", Offset = "0x43A0D1C", VA = "0x43A4D1C")]
		public void CrossFade(string animationName, float duration)
		{
		}

		[Token(Token = "0x6005BFB")]
		[Address(RVA = "0x43A4D6C", Offset = "0x43A0D6C", VA = "0x43A4D6C")]
		public void CrossFade(int animationIndex, float duration)
		{
		}

		[Token(Token = "0x6005BFC")]
		[Address(RVA = "0x43A4DB0", Offset = "0x43A0DB0", VA = "0x43A4DB0")]
		public void Pause()
		{
		}

		[Token(Token = "0x6005BFD")]
		[Address(RVA = "0x43A4DC0", Offset = "0x43A0DC0", VA = "0x43A4DC0")]
		public void Resume()
		{
		}

		[Token(Token = "0x6005BFE")]
		[Address(RVA = "0x43A4DCC", Offset = "0x43A0DCC", VA = "0x43A4DCC")]
		public void Stop()
		{
		}

		[Token(Token = "0x6005BFF")]
		[Address(RVA = "0x43A4DEC", Offset = "0x43A0DEC", VA = "0x43A4DEC")]
		public bool IsPlaying()
		{
			return default;
		}

		[Token(Token = "0x6005C00")]
		[Address(RVA = "0x43A4E0C", Offset = "0x43A0E0C", VA = "0x43A4E0C")]
		public bool IsReady()
		{
			return default;
		}

		[Token(Token = "0x6005C01")]
		[Address(RVA = "0x43A4E1C", Offset = "0x43A0E1C", VA = "0x43A4E1C")]
		public AnimationInfo GetCurrentAnimationInfo()
		{
			return null;
		}

		[Token(Token = "0x6005C02")]
		[Address(RVA = "0x43A4E98", Offset = "0x43A0E98", VA = "0x43A4E98")]
		public AnimationInfo GetPreAnimationInfo()
		{
			return null;
		}

		[Token(Token = "0x6005C03")]
		[Address(RVA = "0x43A4F14", Offset = "0x43A0F14", VA = "0x43A4F14")]
		public void UpdateAnimation()
		{
		}

		[Token(Token = "0x6005C04")]
		[Address(RVA = "0x43A5338", Offset = "0x43A1338", VA = "0x43A5338")]
		public void UpdateLod(Vector3 cameraPosition)
		{
		}

		[Token(Token = "0x6005C05")]
		[Address(RVA = "0x43A5210", Offset = "0x43A1210", VA = "0x43A5210")]
		private void UpdateAnimationEvent()
		{
		}

		[Token(Token = "0x6005C06")]
		[Address(RVA = "0x43A5414", Offset = "0x43A1414", VA = "0x43A5414")]
		private int FindAnimationInfo(int hash)
		{
			return default;
		}

		[Token(Token = "0x6005C07")]
		[Address(RVA = "0x43A48DC", Offset = "0x43A08DC", VA = "0x43A48DC")]
		private int FindAnimationInfo(string animationName)
		{
			return default;
		}

		[Token(Token = "0x6005C08")]
		[Address(RVA = "0x43A5488", Offset = "0x43A1488", VA = "0x43A5488")]
		public void Attach(string boneName, AnimationInstancing attachment)
		{
		}

		[Token(Token = "0x6005C09")]
		[Address(RVA = "0x43A2514", Offset = "0x439E514", VA = "0x43A2514")]
		public void Deattach(AnimationInstancing attachment)
		{
		}

		[Token(Token = "0x6005C0A")]
		[Address(RVA = "0x43A5AC0", Offset = "0x43A1AC0", VA = "0x43A5AC0")]
		public int GetAnimationCount()
		{
			return default;
		}

		[Token(Token = "0x6005C0B")]
		[Address(RVA = "0x43A5B0C", Offset = "0x43A1B0C", VA = "0x43A5B0C")]
		public string GetAnimationName(int index)
		{
			return null;
		}

		[Token(Token = "0x6005C0C")]
		[Address(RVA = "0x43A5BB0", Offset = "0x43A1BB0", VA = "0x43A5BB0", Slot = "4")]
		public void ChangeAnimatorSpeed(GPUInstanceAnimationBehaviour.AnimationName animationName, float speed)
		{
		}

		[Token(Token = "0x6005C0D")]
		[Address(RVA = "0x43A5D0C", Offset = "0x43A1D0C", VA = "0x43A5D0C", Slot = "5")]
		public float GetAnimatorSpeed(GPUInstanceAnimationBehaviour.AnimationName animationName)
		{
			return default;
		}

		[Token(Token = "0x6005C0F")]
		[Address(RVA = "0x43A5CB8", Offset = "0x43A1CB8", VA = "0x43A5CB8", Slot = "7")]
		public bool GetCurrentAnimationIs(GPUInstanceAnimationBehaviour.AnimationName animationName)
		{
			return default;
		}

		[Token(Token = "0x6005C10")]
		[Address(RVA = "0x43A5D4C", Offset = "0x43A1D4C", VA = "0x43A5D4C", Slot = "6")]
		public GPUInstanceAnimationBehaviour.AnimationName GetCurrentAnimationName()
		{
			return default;
		}

		[Token(Token = "0x6005C11")]
		[Address(RVA = "0x43A5E00", Offset = "0x43A1E00", VA = "0x43A5E00", Slot = "8")]
		public float GetAnimationLength(GPUInstanceAnimationBehaviour.AnimationName animationName)
		{
			return default;
		}

		[Token(Token = "0x6005C12")]
		[Address(RVA = "0x43A5EE4", Offset = "0x43A1EE4", VA = "0x43A5EE4", Slot = "11")]
		public void SetAnimation(GPUInstanceAnimationBehaviour.AnimationName animationName)
		{
		}

		[Token(Token = "0x6005C13")]
		[Address(RVA = "0x43A5F10", Offset = "0x43A1F10", VA = "0x43A5F10", Slot = "10")]
		public void ResetState()
		{
		}

		[Token(Token = "0x6005C14")]
		[Address(RVA = "0x43A5C54", Offset = "0x43A1C54", VA = "0x43A5C54")]
		private static string ConvertAnimationName(GPUInstanceAnimationBehaviour.AnimationName animationName)
		{
			return null;
		}

		[Token(Token = "0x6005C15")]
		[Address(RVA = "0x43A4B70", Offset = "0x43A0B70", VA = "0x43A4B70")]
		private float GetAnimationSpeed(string animationName)
		{
			return default;
		}

		[Token(Token = "0x6005C16")]
		[Address(RVA = "0x43A4C00", Offset = "0x43A0C00", VA = "0x43A4C00")]
		private void RefreshAttachmentAnimation(int index)
		{
		}

		[Token(Token = "0x6005C17")]
		[Address(RVA = "0x43A5F1C", Offset = "0x43A1F1C", VA = "0x43A5F1C")]
		public AnimationInstancing()
		{
		}
	}
}
