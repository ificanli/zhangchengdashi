using Il2CppDummyDll;
using UnityEngine;

namespace IngameDebugConsole
{
	[Token(Token = "0x200006B")]
	[CreateAssetMenu(fileName = "Inspector Settings", menuName = "yasirkula/RuntimeInspector/Settings", order = 111)]
	public class RuntimeInspectorSettings : ScriptableObject
	{
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SkinnedWindow[] m_pickerDrawers;

		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private InspectorField[] m_standardDrawers;

		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private InspectorField[] m_referenceDrawers;

		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private VariableSet[] m_hiddenVariables;

		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private VariableSet[] m_exposedVariables;

		[Token(Token = "0x170000B6")]
		public SkinnedWindow[] PickerDrawers
		{
			[Token(Token = "0x6000394")]
			[Address(RVA = "0x467467C", Offset = "0x467067C", VA = "0x467467C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B7")]
		public InspectorField[] StandardDrawers
		{
			[Token(Token = "0x6000395")]
			[Address(RVA = "0x4674684", Offset = "0x4670684", VA = "0x4674684")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B8")]
		public InspectorField[] ReferenceDrawers
		{
			[Token(Token = "0x6000396")]
			[Address(RVA = "0x467468C", Offset = "0x467068C", VA = "0x467468C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B9")]
		public VariableSet[] HiddenVariables
		{
			[Token(Token = "0x6000397")]
			[Address(RVA = "0x4674694", Offset = "0x4670694", VA = "0x4674694")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BA")]
		public VariableSet[] ExposedVariables
		{
			[Token(Token = "0x6000398")]
			[Address(RVA = "0x467469C", Offset = "0x467069C", VA = "0x467469C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x46746A4", Offset = "0x46706A4", VA = "0x46746A4")]
		public RuntimeInspectorSettings()
		{
		}
	}
}
