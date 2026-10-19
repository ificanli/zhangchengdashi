using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace BrainFailProductions.PolyFew.UnityMeshSimplifier
{
	[Serializable]
	[Token(Token = "0x200000E")]
	public struct LODLevel
	{
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Range(0f, 1f)]
		[Tooltip("The screen relative height to use for the transition.")]
		private float screenRelativeTransitionHeight;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		[Range(0f, 1f)]
		[Tooltip("The width of the cross-fade transition zone (proportion to the current LOD's whole length).")]
		private float fadeTransitionWidth;

		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x8")]
		[Tooltip("The desired quality for this level.")]
		[Range(0f, 1f)]
		[SerializeField]
		private float quality;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0xC")]
		[Tooltip("If all renderers and meshes under this level should be combined into one, where possible.")]
		[SerializeField]
		private bool combineMeshes;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0xD")]
		[Tooltip("If all sub-meshes should be combined into one, where possible.")]
		[SerializeField]
		private bool combineSubMeshes;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x10")]
		[Tooltip("The renderers used in this level.")]
		[SerializeField]
		private Renderer[] renderers;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("The skin quality to use for renderers on this level.")]
		[SerializeField]
		private SkinQuality skinQuality;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x1C")]
		[Tooltip("The shadow casting mode for renderers on this level.")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("If renderers on this level should receive shadows.")]
		private bool receiveShadows;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Tooltip("The motion vector generation mode for renderers on this level.")]
		private MotionVectorGenerationMode motionVectorGenerationMode;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("If renderers on this level should use skinned motion vectors.")]
		private bool skinnedMotionVectors;

		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("The light probe usage for renderers on this level.")]
		[SerializeField]
		private LightProbeUsage lightProbeUsage;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("The reflection probe usage for renderers on this level.")]
		[SerializeField]
		private ReflectionProbeUsage reflectionProbeUsage;

		[Token(Token = "0x17000009")]
		public float ScreenRelativeTransitionHeight
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x8555518", Offset = "0x8551518", VA = "0x8555518")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x8555520", Offset = "0x8551520", VA = "0x8555520")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public float FadeTransitionWidth
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x855553C", Offset = "0x855153C", VA = "0x855553C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x8555544", Offset = "0x8551544", VA = "0x8555544")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public float Quality
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x8555560", Offset = "0x8551560", VA = "0x8555560")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x8555568", Offset = "0x8551568", VA = "0x8555568")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public bool CombineMeshes
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x8555584", Offset = "0x8551584", VA = "0x8555584")]
			get
			{
				return default;
			}
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x855558C", Offset = "0x855158C", VA = "0x855558C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public bool CombineSubMeshes
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x8555598", Offset = "0x8551598", VA = "0x8555598")]
			get
			{
				return default;
			}
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x85555A0", Offset = "0x85515A0", VA = "0x85555A0")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public Renderer[] Renderers
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x85555AC", Offset = "0x85515AC", VA = "0x85555AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x85555B4", Offset = "0x85515B4", VA = "0x85555B4")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public SkinQuality SkinQuality
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x85555BC", Offset = "0x85515BC", VA = "0x85555BC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x85555C4", Offset = "0x85515C4", VA = "0x85555C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public ShadowCastingMode ShadowCastingMode
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x85555CC", Offset = "0x85515CC", VA = "0x85555CC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x85555D4", Offset = "0x85515D4", VA = "0x85555D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public bool ReceiveShadows
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x85555DC", Offset = "0x85515DC", VA = "0x85555DC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x85555E4", Offset = "0x85515E4", VA = "0x85555E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public MotionVectorGenerationMode MotionVectorGenerationMode
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x85555F0", Offset = "0x85515F0", VA = "0x85555F0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x85555F8", Offset = "0x85515F8", VA = "0x85555F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public bool SkinnedMotionVectors
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x8555600", Offset = "0x8551600", VA = "0x8555600")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x8555608", Offset = "0x8551608", VA = "0x8555608")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public LightProbeUsage LightProbeUsage
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x8555614", Offset = "0x8551614", VA = "0x8555614")]
			get
			{
				return default;
			}
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x855561C", Offset = "0x855161C", VA = "0x855561C")]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public ReflectionProbeUsage ReflectionProbeUsage
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x8555624", Offset = "0x8551624", VA = "0x8555624")]
			get
			{
				return default;
			}
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x855562C", Offset = "0x855162C", VA = "0x855562C")]
			set
			{
			}
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x854F458", Offset = "0x854B458", VA = "0x854F458")]
		public LODLevel(float screenRelativeTransitionHeight, float quality)
			: this(screenRelativeTransitionHeight, 0f, quality, false, false, null)
		{
			// RVA 0x854F458 has the same assignments with these default arguments.
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x8555698", Offset = "0x8551698", VA = "0x8555698")]
		public LODLevel(float screenRelativeTransitionHeight, float fadeTransitionWidth, float quality, bool combineMeshes, bool combineSubMeshes)
			: this(screenRelativeTransitionHeight, fadeTransitionWidth, quality, combineMeshes, combineSubMeshes, null)
		{
			// RVA 0x8555698 uses a null renderer array.
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x8555634", Offset = "0x8551634", VA = "0x8555634")]
		public LODLevel(float screenRelativeTransitionHeight, float fadeTransitionWidth, float quality, bool combineMeshes, bool combineSubMeshes, Renderer[] renderers)
		{
			// Recovered from ARM64 RVA 0x8555634. Only height and quality are clamped.
			this.screenRelativeTransitionHeight = screenRelativeTransitionHeight < 0f ? 0f : screenRelativeTransitionHeight > 1f ? 1f : screenRelativeTransitionHeight;
			this.fadeTransitionWidth = fadeTransitionWidth;
			this.quality = quality < 0f ? 0f : quality > 1f ? 1f : quality;
			this.combineMeshes = combineMeshes;
			this.combineSubMeshes = combineSubMeshes;
			this.renderers = renderers;
			skinQuality = SkinQuality.Auto;
			shadowCastingMode = ShadowCastingMode.On;
			receiveShadows = true;
			motionVectorGenerationMode = MotionVectorGenerationMode.Camera;
			skinnedMotionVectors = true;
			lightProbeUsage = LightProbeUsage.BlendProbes;
			reflectionProbeUsage = ReflectionProbeUsage.BlendProbes;
		}
	}
}
