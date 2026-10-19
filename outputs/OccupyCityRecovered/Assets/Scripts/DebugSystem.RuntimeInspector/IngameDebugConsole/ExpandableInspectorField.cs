using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000031")]
	public abstract class ExpandableInspectorField : InspectorField
	{
		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		protected RectTransform drawArea;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private PointerEventListener expandToggle;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private RectTransform expandToggleTransform;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private LayoutGroup layoutGroup;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Graphic expandArrow;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		protected readonly List<InspectorField> elements;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected readonly List<ExposedMethodField> exposedMethods;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool m_isExpanded;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private RuntimeInspector.HeaderVisibility m_headerVisibility;

		[Token(Token = "0x17000070")]
		protected virtual int Length
		{
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x4662CD8", Offset = "0x465ECD8", VA = "0x4662CD8", Slot = "17")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000071")]
		public override bool ShouldRefresh
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x4662D20", Offset = "0x465ED20", VA = "0x4662D20", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000072")]
		public bool IsExpanded
		{
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x4662D28", Offset = "0x465ED28", VA = "0x4662D28")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x465FC8C", Offset = "0x465BC8C", VA = "0x465FC8C")]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public RuntimeInspector.HeaderVisibility HeaderVisibility
		{
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x4662D30", Offset = "0x465ED30", VA = "0x4662D30")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x4662D38", Offset = "0x465ED38", VA = "0x4662D38")]
			set
			{
			}
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x465E80C", Offset = "0x465A80C", VA = "0x465E80C", Slot = "8")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x465EC08", Offset = "0x465AC08", VA = "0x465EC08", Slot = "12")]
		protected override void OnUnbound()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x466313C", Offset = "0x465F13C", VA = "0x466313C", Slot = "13")]
		protected override void OnInspectorChanged()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x46631D0", Offset = "0x465F1D0", VA = "0x46631D0", Slot = "14")]
		protected override void OnSkinChanged()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x466344C", Offset = "0x465F44C", VA = "0x466344C", Slot = "15")]
		protected override void OnDepthChanged()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x4663530", Offset = "0x465F530", VA = "0x4663530")]
		protected void RegenerateElements()
		{
		}

		[Token(Token = "0x60001EB")]
		protected abstract void GenerateElements();

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x4663630", Offset = "0x465F630", VA = "0x4663630")]
		private void GenerateExposedMethodButtons()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x465EE88", Offset = "0x465AE88", VA = "0x465EE88", Slot = "19")]
		protected virtual void ClearElements()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x4660208", Offset = "0x465C208", VA = "0x4660208", Slot = "16")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x465F990", Offset = "0x465B990", VA = "0x465F990")]
		public InspectorField CreateDrawerForComponent(Component component, [Optional] string variableName)
		{
			return null;
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x465F764", Offset = "0x465B764", VA = "0x465F764")]
		public InspectorField CreateDrawerForVariable(MemberInfo variable, [Optional] string variableName)
		{
			return null;
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x465F590", Offset = "0x465B590", VA = "0x465F590")]
		public InspectorField CreateDrawer(Type variableType, string variableName, Getter getter, Setter setter, bool drawObjectsAsFields = true)
		{
			return null;
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x465FDE4", Offset = "0x465BDE4", VA = "0x465FDE4")]
		public ExposedMethodField CreateExposedMethodButton(ExposedMethod method, Getter getter, Setter setter)
		{
			return null;
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x4661280", Offset = "0x465D280", VA = "0x4661280")]
		protected ExpandableInspectorField()
		{
		}
	}
}
