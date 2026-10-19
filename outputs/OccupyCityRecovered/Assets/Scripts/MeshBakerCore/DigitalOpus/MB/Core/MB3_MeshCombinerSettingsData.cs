using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace DigitalOpus.MB.Core
{
	[Serializable]
	[Token(Token = "0x2000052")]
	public class MB3_MeshCombinerSettingsData : MB_IMeshBakerSettings
	{
		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected MB_RenderType _renderType;

		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected MB2_OutputOptions _outputOption;

		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected MB2_LightmapOptions _lightmapOption;

		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		protected bool _doNorm;

		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x1D")]
		[SerializeField]
		protected bool _doTan;

		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x1E")]
		[SerializeField]
		protected bool _doCol;

		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x1F")]
		[SerializeField]
		protected bool _doUV;

		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected bool _doUV3;

		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		protected bool _doUV4;

		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x22")]
		[SerializeField]
		protected bool _doUV5;

		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x23")]
		[SerializeField]
		protected bool _doUV6;

		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected bool _doUV7;

		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x25")]
		[SerializeField]
		protected bool _doUV8;

		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x26")]
		[SerializeField]
		protected bool _doBlendShapes;

		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("_recenterVertsToBoundsCenter")]
		protected MB_MeshPivotLocation _pivotLocationType;

		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		protected Vector3 _pivotLocation;

		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected bool _clearBuffersAfterBake;

		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x39")]
		[SerializeField]
		public bool _optimizeAfterBake;

		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		protected float _uv2UnwrappingParamsHardAngle;

		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected float _uv2UnwrappingParamsPackMargin;

		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		protected bool _smrNoExtraBonesWhenCombiningMeshRenderers;

		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x45")]
		[SerializeField]
		protected bool _smrMergeBlendShapesWithSameNames;

		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected UnityEngine.Object _assignToMeshCustomizer;

		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected MB_MeshCombineAPIType _meshAPItoUse;

		[Token(Token = "0x17000050")]
		public virtual MB_RenderType renderType
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x744EEDC", Offset = "0x744AEDC", VA = "0x744EEDC", Slot = "50")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x744EEE4", Offset = "0x744AEE4", VA = "0x744EEE4", Slot = "51")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public virtual MB2_OutputOptions outputOption
		{
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x744EEEC", Offset = "0x744AEEC", VA = "0x744EEEC", Slot = "52")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x744EEF4", Offset = "0x744AEF4", VA = "0x744EEF4", Slot = "53")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public virtual MB2_LightmapOptions lightmapOption
		{
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x744EEFC", Offset = "0x744AEFC", VA = "0x744EEFC", Slot = "54")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x744EF04", Offset = "0x744AF04", VA = "0x744EF04", Slot = "55")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public virtual bool doNorm
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x744EF0C", Offset = "0x744AF0C", VA = "0x744EF0C", Slot = "56")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x744EF14", Offset = "0x744AF14", VA = "0x744EF14", Slot = "57")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public virtual bool doTan
		{
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x744EF20", Offset = "0x744AF20", VA = "0x744EF20", Slot = "58")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x744EF28", Offset = "0x744AF28", VA = "0x744EF28", Slot = "59")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public virtual bool doCol
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x744EF34", Offset = "0x744AF34", VA = "0x744EF34", Slot = "60")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x744EF3C", Offset = "0x744AF3C", VA = "0x744EF3C", Slot = "61")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public virtual bool doUV
		{
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x744EF48", Offset = "0x744AF48", VA = "0x744EF48", Slot = "62")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x744EF50", Offset = "0x744AF50", VA = "0x744EF50", Slot = "63")]
			set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public virtual bool doUV3
		{
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x744EF5C", Offset = "0x744AF5C", VA = "0x744EF5C", Slot = "64")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x744EF64", Offset = "0x744AF64", VA = "0x744EF64", Slot = "65")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public virtual bool doUV4
		{
			[Token(Token = "0x6000209")]
			[Address(RVA = "0x744EF70", Offset = "0x744AF70", VA = "0x744EF70", Slot = "66")]
			get
			{
				return default;
			}
			[Token(Token = "0x600020A")]
			[Address(RVA = "0x744EF78", Offset = "0x744AF78", VA = "0x744EF78", Slot = "67")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public virtual bool doUV5
		{
			[Token(Token = "0x600020B")]
			[Address(RVA = "0x744EF84", Offset = "0x744AF84", VA = "0x744EF84", Slot = "68")]
			get
			{
				return default;
			}
			[Token(Token = "0x600020C")]
			[Address(RVA = "0x744EF8C", Offset = "0x744AF8C", VA = "0x744EF8C", Slot = "69")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public virtual bool doUV6
		{
			[Token(Token = "0x600020D")]
			[Address(RVA = "0x744EF98", Offset = "0x744AF98", VA = "0x744EF98", Slot = "70")]
			get
			{
				return default;
			}
			[Token(Token = "0x600020E")]
			[Address(RVA = "0x744EFA0", Offset = "0x744AFA0", VA = "0x744EFA0", Slot = "71")]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public virtual bool doUV7
		{
			[Token(Token = "0x600020F")]
			[Address(RVA = "0x744EFAC", Offset = "0x744AFAC", VA = "0x744EFAC", Slot = "72")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000210")]
			[Address(RVA = "0x744EFB4", Offset = "0x744AFB4", VA = "0x744EFB4", Slot = "73")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public virtual bool doUV8
		{
			[Token(Token = "0x6000211")]
			[Address(RVA = "0x744EFC0", Offset = "0x744AFC0", VA = "0x744EFC0", Slot = "74")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000212")]
			[Address(RVA = "0x744EFC8", Offset = "0x744AFC8", VA = "0x744EFC8", Slot = "75")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public virtual bool doBlendShapes
		{
			[Token(Token = "0x6000213")]
			[Address(RVA = "0x744EFD4", Offset = "0x744AFD4", VA = "0x744EFD4", Slot = "76")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000214")]
			[Address(RVA = "0x744EFDC", Offset = "0x744AFDC", VA = "0x744EFDC", Slot = "77")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public virtual MB_MeshPivotLocation pivotLocationType
		{
			[Token(Token = "0x6000215")]
			[Address(RVA = "0x744EFE8", Offset = "0x744AFE8", VA = "0x744EFE8", Slot = "78")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000216")]
			[Address(RVA = "0x744EFF0", Offset = "0x744AFF0", VA = "0x744EFF0", Slot = "79")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public virtual Vector3 pivotLocation
		{
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x744EFF8", Offset = "0x744AFF8", VA = "0x744EFF8", Slot = "80")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x744F004", Offset = "0x744B004", VA = "0x744F004", Slot = "81")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public bool clearBuffersAfterBake
		{
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x744F010", Offset = "0x744B010", VA = "0x744F010", Slot = "38")]
			get
			{
				return default;
			}
			[Token(Token = "0x600021A")]
			[Address(RVA = "0x744F018", Offset = "0x744B018", VA = "0x744F018", Slot = "39")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public bool optimizeAfterBake
		{
			[Token(Token = "0x600021B")]
			[Address(RVA = "0x744F024", Offset = "0x744B024", VA = "0x744F024", Slot = "32")]
			get
			{
				return default;
			}
			[Token(Token = "0x600021C")]
			[Address(RVA = "0x744F02C", Offset = "0x744B02C", VA = "0x744F02C", Slot = "33")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public float uv2UnwrappingParamsHardAngle
		{
			[Token(Token = "0x600021D")]
			[Address(RVA = "0x744F038", Offset = "0x744B038", VA = "0x744F038", Slot = "28")]
			get
			{
				return default;
			}
			[Token(Token = "0x600021E")]
			[Address(RVA = "0x744F040", Offset = "0x744B040", VA = "0x744F040", Slot = "29")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public float uv2UnwrappingParamsPackMargin
		{
			[Token(Token = "0x600021F")]
			[Address(RVA = "0x744F048", Offset = "0x744B048", VA = "0x744F048", Slot = "30")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x744F050", Offset = "0x744B050", VA = "0x744F050", Slot = "31")]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public bool smrNoExtraBonesWhenCombiningMeshRenderers
		{
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x744F058", Offset = "0x744B058", VA = "0x744F058", Slot = "42")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x744F060", Offset = "0x744B060", VA = "0x744F060", Slot = "43")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public bool smrMergeBlendShapesWithSameNames
		{
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x744F06C", Offset = "0x744B06C", VA = "0x744F06C", Slot = "44")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x744F074", Offset = "0x744B074", VA = "0x744F074", Slot = "45")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public IAssignToMeshCustomizer assignToMeshCustomizer
		{
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x744F080", Offset = "0x744B080", VA = "0x744F080", Slot = "46")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x744F104", Offset = "0x744B104", VA = "0x744F104", Slot = "47")]
			set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public MB_MeshCombineAPIType meshAPI
		{
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x744F1A8", Offset = "0x744B1A8", VA = "0x744F1A8", Slot = "48")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x744F1B0", Offset = "0x744B1B0", VA = "0x744F1B0", Slot = "49")]
			set
			{
			}
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x744F1B8", Offset = "0x744B1B8", VA = "0x744F1B8")]
		public MB3_MeshCombinerSettingsData()
		{
		}
	}
}
