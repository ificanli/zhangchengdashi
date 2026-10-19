using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000016")]
	public class RuntimeInspector : SkinnedWindow, ITooltipManager
	{
		[Token(Token = "0x2000017")]
		public enum VariableVisibility
		{
			[Token(Token = "0x40000D6")]
			None = 0,
			[Token(Token = "0x40000D7")]
			SerializableOnly = 1,
			[Token(Token = "0x40000D8")]
			All = 2
		}

		[Token(Token = "0x2000018")]
		public enum HeaderVisibility
		{
			[Token(Token = "0x40000DA")]
			Collapsible = 0,
			[Token(Token = "0x40000DB")]
			AlwaysVisible = 1,
			[Token(Token = "0x40000DC")]
			Hidden = 2
		}

		[Token(Token = "0x2000019")]
		public delegate object InspectedObjectChangingDelegate(object previousInspectedObject, object newInspectedObject);

		[Token(Token = "0x200001A")]
		public delegate void ComponentFilterDelegate(GameObject gameObject, List<Component> components);

		[Token(Token = "0x40000AE")]
		private const string POOL_OBJECT_NAME = "RuntimeInspectorPool";

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[FormerlySerializedAs("refreshInterval")]
		[SerializeField]
		private float m_refreshInterval;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float nextRefreshTime;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Space]
		private VariableVisibility m_exposeFields;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private VariableVisibility m_exposeProperties;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Space]
		[SerializeField]
		private bool m_arrayIndicesStartAtOne;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		[SerializeField]
		private bool m_useTitleCaseNaming;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
		[SerializeField]
		[Space]
		private bool m_showAddComponentButton;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F")]
		[SerializeField]
		private bool m_showRemoveComponentButton;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Space]
		private bool m_showTooltips;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float m_tooltipDelay;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Space]
		private int m_nestLimit;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private HeaderVisibility m_inspectedObjectHeaderVisibility;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private int poolCapacity;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform poolParent;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RuntimeHierarchy m_connectedHierarchy;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RuntimeInspectorSettings[] settings;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool m_isLocked;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Header("Internal Variables")]
		[SerializeField]
		private ScrollRect scrollView;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private RectTransform drawArea;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image background;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image scrollbar;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int aliveInspectors;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool initialized;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private readonly Dictionary<Type, InspectorField[]> typeToDrawers;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private readonly Dictionary<Type, InspectorField[]> typeToReferenceDrawers;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly List<InspectorField> eligibleDrawers;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<Type, List<InspectorField>> drawersPool;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private readonly List<VariableSet> hiddenVariables;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private readonly List<VariableSet> exposedVariables;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InspectorField currentDrawer;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool inspectLock;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		private bool isDirty;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private object m_inspectedObject;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Canvas m_canvas;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private PointerEventData nullPointerEventData;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public InspectedObjectChangingDelegate OnInspectedObjectChanging;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private ComponentFilterDelegate m_componentFilter;

		[Token(Token = "0x17000048")]
		public float RefreshInterval
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x4657C80", Offset = "0x4653C80", VA = "0x4657C80")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x4657C88", Offset = "0x4653C88", VA = "0x4657C88")]
			set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public VariableVisibility ExposeFields
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x4657C90", Offset = "0x4653C90", VA = "0x4657C90")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x4657C98", Offset = "0x4653C98", VA = "0x4657C98")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public VariableVisibility ExposeProperties
		{
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x4657CB4", Offset = "0x4653CB4", VA = "0x4657CB4")]
			get
			{
				return default;
			}
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x4657CBC", Offset = "0x4653CBC", VA = "0x4657CBC")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public bool ArrayIndicesStartAtOne
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x4657CD8", Offset = "0x4653CD8", VA = "0x4657CD8")]
			get
			{
				return default;
			}
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x4657CE0", Offset = "0x4653CE0", VA = "0x4657CE0")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public bool UseTitleCaseNaming
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x4657D00", Offset = "0x4653D00", VA = "0x4657D00")]
			get
			{
				return default;
			}
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x4657D08", Offset = "0x4653D08", VA = "0x4657D08")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public bool ShowAddComponentButton
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x4657D28", Offset = "0x4653D28", VA = "0x4657D28")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x4657D30", Offset = "0x4653D30", VA = "0x4657D30")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public bool ShowRemoveComponentButton
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x4657D50", Offset = "0x4653D50", VA = "0x4657D50")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x4657D58", Offset = "0x4653D58", VA = "0x4657D58")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public bool ShowTooltips
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x4657D78", Offset = "0x4653D78", VA = "0x4657D78")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000050")]
		public float TooltipDelay
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x4657D80", Offset = "0x4653D80", VA = "0x4657D80", Slot = "10")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x4657D88", Offset = "0x4653D88", VA = "0x4657D88")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		internal TooltipListener TooltipListener
		{
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x4657D90", Offset = "0x4653D90", VA = "0x4657D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x4657D98", Offset = "0x4653D98", VA = "0x4657D98")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public int NestLimit
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x4657DA0", Offset = "0x4653DA0", VA = "0x4657DA0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x4657DA8", Offset = "0x4653DA8", VA = "0x4657DA8")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public HeaderVisibility InspectedObjectHeaderVisibility
		{
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x4657DC4", Offset = "0x4653DC4", VA = "0x4657DC4")]
			get
			{
				return default;
			}
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x4657DCC", Offset = "0x4653DCC", VA = "0x4657DCC")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public RuntimeHierarchy ConnectedHierarchy
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x4657EA4", Offset = "0x4653EA4", VA = "0x4657EA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x4657EAC", Offset = "0x4653EAC", VA = "0x4657EAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public bool IsLocked
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x4657EB4", Offset = "0x4653EB4", VA = "0x4657EB4")]
			get
			{
				return default;
			}
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x4657EBC", Offset = "0x4653EBC", VA = "0x4657EBC")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public object InspectedObject
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x4657EC8", Offset = "0x4653EC8", VA = "0x4657EC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		public bool IsBound
		{
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x4657ED0", Offset = "0x4653ED0", VA = "0x4657ED0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000058")]
		public Canvas Canvas
		{
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x4657F38", Offset = "0x4653F38", VA = "0x4657F38", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		public ComponentFilterDelegate ComponentFilter
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x4657F40", Offset = "0x4653F40", VA = "0x4657F40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x4657F48", Offset = "0x4653F48", VA = "0x4657F48")]
			set
			{
			}
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x4657FEC", Offset = "0x4653FEC", VA = "0x4657FEC", Slot = "5")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x4658008", Offset = "0x4654008", VA = "0x4658008")]
		private void Initialize()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x46585D8", Offset = "0x46545D8", VA = "0x46585D8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x46587B4", Offset = "0x46547B4", VA = "0x46587B4")]
		private void OnTransformParentChanged()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x4658804", Offset = "0x4654804", VA = "0x4658804", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x4657F50", Offset = "0x4653F50", VA = "0x4657F50")]
		public void Refresh()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x4658FA4", Offset = "0x4654FA4", VA = "0x4658FA4")]
		public void RefreshDelayed()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x4658FAC", Offset = "0x4654FAC", VA = "0x4658FAC")]
		internal void EnsureScrollViewIsWithinBounds()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x4659044", Offset = "0x4655044", VA = "0x4659044", Slot = "7")]
		protected override void RefreshSkin()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x464DC38", Offset = "0x4649C38", VA = "0x464DC38")]
		public void Inspect(object obj)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x46589DC", Offset = "0x46549DC", VA = "0x46589DC")]
		internal void InspectInternal(object obj)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x46591D4", Offset = "0x46551D4", VA = "0x46591D4")]
		public void StopInspect()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x465890C", Offset = "0x465490C", VA = "0x465890C")]
		internal void StopInspectInternal()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x46590D4", Offset = "0x46550D4", VA = "0x46590D4")]
		public InspectorField CreateDrawerForType(Type type, Transform drawerParent, int depth, [Optional][DefaultParameterValue(true)] bool drawObjectsAsFields, [Optional] MemberInfo variable)
		{
			return null;
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x46594E4", Offset = "0x46554E4", VA = "0x46594E4")]
		private InspectorField InstantiateDrawer(InspectorField drawer, Transform drawerParent)
		{
			return null;
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x46591E4", Offset = "0x46551E4", VA = "0x46591E4")]
		private InspectorField[] GetDrawersForType(Type type, bool drawObjectsAsFields)
		{
			return null;
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x46596E8", Offset = "0x46556E8", VA = "0x46596E8")]
		internal void PoolDrawer(InspectorField drawer)
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x4659944", Offset = "0x4655944", VA = "0x4659944")]
		internal ExposedVariablesEnumerator GetExposedVariablesForType(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x4659C8C", Offset = "0x4655C8C", VA = "0x4659C8C")]
		public RuntimeInspector()
		{
		}
	}
}
