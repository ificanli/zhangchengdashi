using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace DigitalOpus.MB.Core
{
	[Serializable]
	[Token(Token = "0x200004C")]
	public abstract class MB3_MeshCombiner : MB_IMeshBakerSettings, IDisposable
	{
		[Token(Token = "0x200004D")]
		public enum MeshCombiningStatus
		{
			[Token(Token = "0x4000159")]
			preAddDeleteOrUpdate = 0,
			[Token(Token = "0x400015A")]
			readyForApply = 1
		}

		[Token(Token = "0x200004E")]
		public delegate void GenerateUV2Delegate(Mesh m, float hardAngle, float packMargin);

		[Token(Token = "0x200004F")]
		public class MBBlendShapeKey
		{
			[Token(Token = "0x400015B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject gameObject;

			[Token(Token = "0x400015C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int blendShapeIndexInSrc;

			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x744ED94", Offset = "0x744AD94", VA = "0x744ED94")]
			public MBBlendShapeKey(GameObject srcSkinnedMeshRenderGameObject, int blendShapeIndexInSource)
			{
			}

			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x744EDC4", Offset = "0x744ADC4", VA = "0x744EDC4", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default;
			}

			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x744EE98", Offset = "0x744AE98", VA = "0x744EE98", Slot = "2")]
			public override int GetHashCode()
			{
				return default;
			}
		}

		[Token(Token = "0x2000050")]
		public class MBBlendShapeValue
		{
			[Token(Token = "0x400015D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject combinedMeshGameObject;

			[Token(Token = "0x400015E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int blendShapeIndex;

			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x744EED4", Offset = "0x744AED4", VA = "0x744EED4")]
			public MBBlendShapeValue()
			{
			}
		}

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected MeshCombiningStatus _bakeStatus;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected MB2_ValidationLevel _validationLevel;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected string _name;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected MB2_TextureBakeResults _textureBakeResults;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected GameObject _resultSceneObject;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Renderer _targetRenderer;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected MB2_LogLevel _LOG_LEVEL;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected UnityEngine.Object _settingsHolder;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected MB2_OutputOptions _outputOption;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		protected MB_RenderType _renderType;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected MB2_LightmapOptions _lightmapOption;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		protected bool _doNorm;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
		[SerializeField]
		protected bool _doTan;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
		[SerializeField]
		protected bool _doCol;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x57")]
		[SerializeField]
		protected bool _doUV;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected bool _doUV3;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		[SerializeField]
		protected bool _doUV4;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		[SerializeField]
		protected bool _doUV5;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B")]
		[SerializeField]
		protected bool _doUV6;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		protected bool _doUV7;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		[SerializeField]
		protected bool _doUV8;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
		[SerializeField]
		protected bool _doBlendShapes;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[FormerlySerializedAs("_recenterVertsToBoundsCenter")]
		protected MB_MeshPivotLocation _pivotLocationType;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		protected Vector3 _pivotLocation;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		protected bool _clearBuffersAfterBake;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		[SerializeField]
		public bool _optimizeAfterBake;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		[FormerlySerializedAs("uv2UnwrappingParamsHardAngle")]
		protected float _uv2UnwrappingParamsHardAngle;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[FormerlySerializedAs("uv2UnwrappingParamsPackMargin")]
		[SerializeField]
		protected float _uv2UnwrappingParamsPackMargin;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		protected bool _smrNoExtraBonesWhenCombiningMeshRenderers;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
		[SerializeField]
		protected bool _smrMergeBlendShapesWithSameNames;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		protected UnityEngine.Object _assignToMeshCustomizer;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		protected MB_MeshCombineAPIType _meshAPItoUse;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		protected bool _usingTemporaryTextureBakeResult;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8D")]
		private bool _disposed;

		[Token(Token = "0x1700002D")]
		public static bool EVAL_VERSION
		{
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x744DFE0", Offset = "0x7449FE0", VA = "0x744DFE0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700002E")]
		public virtual MeshCombiningStatus bakeStatus
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x744DFE8", Offset = "0x7449FE8", VA = "0x744DFE8", Slot = "51")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700002F")]
		public virtual MB2_ValidationLevel validationLevel
		{
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x744DFF0", Offset = "0x7449FF0", VA = "0x744DFF0", Slot = "52")]
			get
			{
				return default;
			}
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x744DFF8", Offset = "0x7449FF8", VA = "0x744DFF8", Slot = "53")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public string name
		{
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x744E000", Offset = "0x744A000", VA = "0x744E000")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x744E008", Offset = "0x744A008", VA = "0x744E008")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public virtual MB2_TextureBakeResults textureBakeResults
		{
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x744E010", Offset = "0x744A010", VA = "0x744E010", Slot = "54")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x744E018", Offset = "0x744A018", VA = "0x744E018", Slot = "55")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public virtual GameObject resultSceneObject
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x744E020", Offset = "0x744A020", VA = "0x744E020", Slot = "56")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x744E028", Offset = "0x744A028", VA = "0x744E028", Slot = "57")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public virtual Renderer targetRenderer
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x744E030", Offset = "0x744A030", VA = "0x744E030", Slot = "58")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x744E038", Offset = "0x744A038", VA = "0x744E038", Slot = "59")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public virtual MB2_LogLevel LOG_LEVEL
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x744E1CC", Offset = "0x744A1CC", VA = "0x744E1CC", Slot = "60")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x744E1D4", Offset = "0x744A1D4", VA = "0x744E1D4", Slot = "61")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public MB_IMeshBakerSettings settings
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x743F4E8", Offset = "0x743B4E8", VA = "0x743F4E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public virtual MB_IMeshBakerSettingsHolder settingsHolder
		{
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x744E1DC", Offset = "0x744A1DC", VA = "0x744E1DC", Slot = "62")]
			get
			{
				return null;
			}
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x744E2A4", Offset = "0x744A2A4", VA = "0x744E2A4", Slot = "63")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public virtual MB2_OutputOptions outputOption
		{
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x744E390", Offset = "0x744A390", VA = "0x744E390", Slot = "64")]
			get
			{
				return default;
			}
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x744E398", Offset = "0x744A398", VA = "0x744E398", Slot = "65")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public virtual MB_RenderType renderType
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x744E3A0", Offset = "0x744A3A0", VA = "0x744E3A0", Slot = "66")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x744E3A8", Offset = "0x744A3A8", VA = "0x744E3A8", Slot = "67")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public virtual MB2_LightmapOptions lightmapOption
		{
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x744E3B0", Offset = "0x744A3B0", VA = "0x744E3B0", Slot = "68")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x744E3B8", Offset = "0x744A3B8", VA = "0x744E3B8", Slot = "69")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public virtual bool doNorm
		{
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x744E3C0", Offset = "0x744A3C0", VA = "0x744E3C0", Slot = "70")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x744E3C8", Offset = "0x744A3C8", VA = "0x744E3C8", Slot = "71")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public virtual bool doTan
		{
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x744E3D4", Offset = "0x744A3D4", VA = "0x744E3D4", Slot = "72")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x744E3DC", Offset = "0x744A3DC", VA = "0x744E3DC", Slot = "73")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public virtual bool doCol
		{
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x744E3E8", Offset = "0x744A3E8", VA = "0x744E3E8", Slot = "74")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x744E3F0", Offset = "0x744A3F0", VA = "0x744E3F0", Slot = "75")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public virtual bool doUV
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x744E3FC", Offset = "0x744A3FC", VA = "0x744E3FC", Slot = "76")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x744E404", Offset = "0x744A404", VA = "0x744E404", Slot = "77")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public virtual bool doUV1
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x744E410", Offset = "0x744A410", VA = "0x744E410", Slot = "78")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x744E418", Offset = "0x744A418", VA = "0x744E418", Slot = "79")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public virtual bool doUV3
		{
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x744E5C0", Offset = "0x744A5C0", VA = "0x744E5C0", Slot = "81")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x744E5C8", Offset = "0x744A5C8", VA = "0x744E5C8", Slot = "82")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public virtual bool doUV4
		{
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x744E5D4", Offset = "0x744A5D4", VA = "0x744E5D4", Slot = "83")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x744E5DC", Offset = "0x744A5DC", VA = "0x744E5DC", Slot = "84")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public virtual bool doUV5
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x744E5E8", Offset = "0x744A5E8", VA = "0x744E5E8", Slot = "85")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x744E5F0", Offset = "0x744A5F0", VA = "0x744E5F0", Slot = "86")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public virtual bool doUV6
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x744E5FC", Offset = "0x744A5FC", VA = "0x744E5FC", Slot = "87")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x744E604", Offset = "0x744A604", VA = "0x744E604", Slot = "88")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public virtual bool doUV7
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x744E610", Offset = "0x744A610", VA = "0x744E610", Slot = "89")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x744E618", Offset = "0x744A618", VA = "0x744E618", Slot = "90")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public virtual bool doUV8
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x744E624", Offset = "0x744A624", VA = "0x744E624", Slot = "91")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x744E62C", Offset = "0x744A62C", VA = "0x744E62C", Slot = "92")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public virtual bool doBlendShapes
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x744E638", Offset = "0x744A638", VA = "0x744E638", Slot = "93")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x744E640", Offset = "0x744A640", VA = "0x744E640", Slot = "94")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public virtual MB_MeshPivotLocation pivotLocationType
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x744E64C", Offset = "0x744A64C", VA = "0x744E64C", Slot = "95")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x744E654", Offset = "0x744A654", VA = "0x744E654", Slot = "96")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public virtual Vector3 pivotLocation
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x744E65C", Offset = "0x744A65C", VA = "0x744E65C", Slot = "97")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x744E668", Offset = "0x744A668", VA = "0x744E668", Slot = "98")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public virtual bool clearBuffersAfterBake
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x744E674", Offset = "0x744A674", VA = "0x744E674", Slot = "99")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x744E67C", Offset = "0x744A67C", VA = "0x744E67C", Slot = "100")]
			set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public bool optimizeAfterBake
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x744E688", Offset = "0x744A688", VA = "0x744E688", Slot = "32")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x744E690", Offset = "0x744A690", VA = "0x744E690", Slot = "33")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public float uv2UnwrappingParamsHardAngle
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x744E69C", Offset = "0x744A69C", VA = "0x744E69C", Slot = "28")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x744E6A4", Offset = "0x744A6A4", VA = "0x744E6A4", Slot = "29")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public float uv2UnwrappingParamsPackMargin
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x744E6AC", Offset = "0x744A6AC", VA = "0x744E6AC", Slot = "30")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x744E6B4", Offset = "0x744A6B4", VA = "0x744E6B4", Slot = "31")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public bool smrNoExtraBonesWhenCombiningMeshRenderers
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x744E6BC", Offset = "0x744A6BC", VA = "0x744E6BC", Slot = "42")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x744E6C4", Offset = "0x744A6C4", VA = "0x744E6C4", Slot = "43")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public bool smrMergeBlendShapesWithSameNames
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x744E6D0", Offset = "0x744A6D0", VA = "0x744E6D0", Slot = "44")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x744E6D8", Offset = "0x744A6D8", VA = "0x744E6D8", Slot = "45")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public IAssignToMeshCustomizer assignToMeshCustomizer
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x744E6E4", Offset = "0x744A6E4", VA = "0x744E6E4", Slot = "46")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x744E768", Offset = "0x744A768", VA = "0x744E768", Slot = "47")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public MB_MeshCombineAPIType meshAPI
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x744E80C", Offset = "0x744A80C", VA = "0x744E80C", Slot = "48")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x744E814", Offset = "0x744A814", VA = "0x744E814", Slot = "49")]
			set
			{
			}
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x744E41C", Offset = "0x744A41C", VA = "0x744E41C", Slot = "80")]
		public virtual bool doUV2()
		{
			return default;
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x744E81C", Offset = "0x744A81C", VA = "0x744E81C", Slot = "101")]
		public virtual void DisposeRuntimeCreated()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x743F854", Offset = "0x743B854", VA = "0x743F854", Slot = "50")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x744E830", Offset = "0x744A830", VA = "0x744E830")]
		public bool IsDisposed()
		{
			return default;
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x744E838", Offset = "0x744A838", VA = "0x744E838", Slot = "102")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x60001D4")]
		public abstract int GetLightmapIndex();

		[Token(Token = "0x60001D5")]
		public abstract void ClearBuffers();

		[Token(Token = "0x60001D6")]
		public abstract void ClearMesh();

		[Token(Token = "0x60001D7")]
		public abstract void ClearMesh(MB2_EditorMethodsInterface editorMethods);

		[Token(Token = "0x60001D8")]
		internal abstract void _DisposeRuntimeCreated();

		[Token(Token = "0x60001D9")]
		public abstract void DestroyMesh();

		[Token(Token = "0x60001DA")]
		public abstract void DestroyMeshEditor(MB2_EditorMethodsInterface editorMethods);

		[Token(Token = "0x60001DB")]
		public abstract List<GameObject> GetObjectsInCombined();

		[Token(Token = "0x60001DC")]
		public abstract int GetNumObjectsInCombined();

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x744E868", Offset = "0x744A868", VA = "0x744E868", Slot = "112")]
		public virtual bool Apply()
		{
			return default;
		}

		[Token(Token = "0x60001DE")]
		public abstract bool Apply(GenerateUV2Delegate uv2GenerationMethod);

		[Token(Token = "0x60001DF")]
		public abstract bool Apply(bool triangles, bool vertices, bool normals, bool tangents, bool uvs, bool uv2, bool uv3, bool uv4, bool uv5, bool uv6, bool uv7, bool uv8, bool colors, [Optional][DefaultParameterValue(false)] bool bones, [Optional][DefaultParameterValue(false)] bool blendShapeFlag, [Optional] GenerateUV2Delegate uv2GenerationMethod);

		[Token(Token = "0x60001E0")]
		public abstract bool Apply(bool triangles, bool vertices, bool normals, bool tangents, bool uvs, bool uv2, bool uv3, bool uv4, bool colors, [Optional][DefaultParameterValue(false)] bool bones, [Optional][DefaultParameterValue(false)] bool blendShapeFlag, [Optional] GenerateUV2Delegate uv2GenerationMethod);

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x744E87C", Offset = "0x744A87C", VA = "0x744E87C", Slot = "116")]
		public virtual bool UpdateGameObjects(GameObject[] gos)
		{
			return default;
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x744E8E0", Offset = "0x744A8E0", VA = "0x744E8E0", Slot = "117")]
		public virtual bool UpdateGameObjects(GameObject[] gos, bool updateBounds)
		{
			return default;
		}

		[Token(Token = "0x60001E3")]
		public abstract bool UpdateGameObjects(GameObject[] gos, bool recalcBounds, bool updateVertices, bool updateNormals, bool updateTangents, bool updateUV, bool updateUV2, bool updateUV3, bool updateUV4, bool updateColors, bool updateSkinningInfo);

		[Token(Token = "0x60001E4")]
		public abstract bool UpdateGameObjects(GameObject[] gos, bool recalcBounds, bool updateVertices, bool updateNormals, bool updateTangents, bool updateUV, bool updateUV2, bool updateUV3, bool updateUV4, bool updateUV5, bool updateUV6, bool updateUV7, bool updateUV8, bool updateColors, bool updateSkinningInfo);

		[Token(Token = "0x60001E5")]
		public abstract bool AddDeleteGameObjects(GameObject[] gos, GameObject[] deleteGOs, bool disableRendererInSource = true);

		[Token(Token = "0x60001E6")]
		public abstract bool AddDeleteGameObjectsByID(GameObject[] gos, int[] deleteGOinstanceIDs, bool disableRendererInSource);

		[Token(Token = "0x60001E7")]
		public abstract bool CombinedMeshContains(GameObject go);

		[Token(Token = "0x60001E8")]
		public abstract void UpdateSkinnedMeshApproximateBounds();

		[Token(Token = "0x60001E9")]
		public abstract void UpdateSkinnedMeshApproximateBoundsFromBones();

		[Token(Token = "0x60001EA")]
		public abstract void CheckIntegrity();

		[Token(Token = "0x60001EB")]
		public abstract void UpdateSkinnedMeshApproximateBoundsFromBounds();

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x743E148", Offset = "0x743A148", VA = "0x743E148")]
		public static void UpdateSkinnedMeshApproximateBoundsFromBonesStatic(Transform[] bs, SkinnedMeshRenderer smr)
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x743E67C", Offset = "0x743A67C", VA = "0x743E67C")]
		public static void UpdateSkinnedMeshApproximateBoundsFromBoundsStatic(List<GameObject> objectsInCombined, SkinnedMeshRenderer smr)
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x744E944", Offset = "0x744A944", VA = "0x744E944", Slot = "127")]
		protected virtual bool _CreateTemporaryTextrueBakeResult(GameObject[] gos, List<Material> matsOnTargetRenderer)
		{
			return default;
		}

		[Token(Token = "0x60001EF")]
		public abstract List<Material> GetMaterialsOnTargetRenderer();

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x744EA08", Offset = "0x744AA08", VA = "0x744EA08")]
		protected MB3_MeshCombiner()
		{
		}
	}
}
