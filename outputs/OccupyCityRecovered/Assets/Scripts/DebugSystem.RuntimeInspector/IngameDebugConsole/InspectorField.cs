using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace IngameDebugConsole
{
	[Token(Token = "0x200002B")]
	public abstract class InspectorField : MonoBehaviour, ITooltipContent
	{
		[Token(Token = "0x200002C")]
		public delegate object Getter();

		[Token(Token = "0x200002D")]
		public delegate void Setter(object value);

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected LayoutElement layoutElement;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected Text variableNameText;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Image variableNameMask;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MaskableGraphic visibleArea;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RuntimeInspector m_inspector;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int m_skinVersion;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private UISkin m_skin;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Type m_boundVariableType;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private object m_value;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int m_depth;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool m_isVisible;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Getter getter;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Setter setter;

		[Token(Token = "0x17000064")]
		public RuntimeInspector Inspector
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x4661D60", Offset = "0x465DD60", VA = "0x4661D60")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x4661D68", Offset = "0x465DD68", VA = "0x4661D68")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public UISkin Skin
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x4661E00", Offset = "0x465DE00", VA = "0x4661E00")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x4661E08", Offset = "0x465DE08", VA = "0x4661E08")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		protected Type BoundVariableType
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x4661EDC", Offset = "0x465DEDC", VA = "0x4661EDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		public object Value
		{
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x4661EE4", Offset = "0x465DEE4", VA = "0x4661EE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x465E3D8", Offset = "0x465A3D8", VA = "0x465E3D8")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public int Depth
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x4661EEC", Offset = "0x465DEEC", VA = "0x4661EEC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x4661EF4", Offset = "0x465DEF4", VA = "0x4661EF4")]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public bool IsVisible
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x4661F18", Offset = "0x465DF18", VA = "0x4661F18")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700006A")]
		public string Name
		{
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x4661F20", Offset = "0x465DF20", VA = "0x4661F20")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x4661FC8", Offset = "0x465DFC8", VA = "0x4661FC8")]
			set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		public string NameRaw
		{
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x46620AC", Offset = "0x465E0AC", VA = "0x46620AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x465E1D4", Offset = "0x465A1D4", VA = "0x465E1D4")]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
bool ITooltipContent.IsActive
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x4662154", Offset = "0x465E154", VA = "0x4662154", Slot = "4")]
			get
			{
				return IngameDebugConsole_002EITooltipContent_002Eget_IsActive();
			}
		}

		[Token(Token = "0x1700006D")]
string ITooltipContent.TooltipText
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x46621DC", Offset = "0x465E1DC", VA = "0x46621DC", Slot = "5")]
			get
			{
				return IngameDebugConsole_002EITooltipContent_002Eget_TooltipText();
			}
		}

		[Token(Token = "0x1700006E")]
		public virtual bool ShouldRefresh
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x46621E0", Offset = "0x465E1E0", VA = "0x46621E0", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700006F")]
		protected virtual float HeightMultiplier
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x46621E8", Offset = "0x465E1E8", VA = "0x46621E8", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x4662154", Offset = "0x465E154", VA = "0x4662154", Slot = "4")]
		private bool IngameDebugConsole_002EITooltipContent_002Eget_IsActive()
		{
			return default;
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x46621DC", Offset = "0x465E1DC", VA = "0x46621DC", Slot = "5")]
		private string IngameDebugConsole_002EITooltipContent_002Eget_TooltipText()
		{
			return null;
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x465DEC8", Offset = "0x4659EC8", VA = "0x465DEC8", Slot = "8")]
		public virtual void Initialize()
		{
		}

		[Token(Token = "0x60001BE")]
		public abstract bool SupportsType(Type type);

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x46621F0", Offset = "0x465E1F0", VA = "0x46621F0", Slot = "10")]
		public virtual bool CanBindTo(Type type, MemberInfo variable)
		{
			return default;
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x46621F8", Offset = "0x465E1F8", VA = "0x46621F8")]
		public void BindTo(InspectorField parent, MemberInfo variable, [Optional] string variableName)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x46626A8", Offset = "0x465E6A8", VA = "0x46626A8")]
		public void BindTo(Type variableType, string variableName, Getter getter, Setter setter, [Optional] MemberInfo variable)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x46626FC", Offset = "0x465E6FC", VA = "0x46626FC")]
		public void Unbind()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x465EB74", Offset = "0x465AB74", VA = "0x465EB74", Slot = "11")]
		protected virtual void OnBound(MemberInfo variable)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x466280C", Offset = "0x465E80C", VA = "0x466280C", Slot = "12")]
		protected virtual void OnUnbound()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x4662814", Offset = "0x465E814", VA = "0x4662814", Slot = "13")]
		protected virtual void OnInspectorChanged()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x465DFD0", Offset = "0x4659FD0", VA = "0x465DFD0", Slot = "14")]
		protected virtual void OnSkinChanged()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x4662990", Offset = "0x465E990", VA = "0x4662990", Slot = "15")]
		protected virtual void OnDepthChanged()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x4662A3C", Offset = "0x465EA3C", VA = "0x4662A3C", Slot = "16")]
		public virtual void Refresh()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x4662734", Offset = "0x465E734", VA = "0x4662734")]
		private void RefreshValue()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x465E598", Offset = "0x465A598", VA = "0x465E598")]
		protected InspectorField()
		{
		}
	}
}
