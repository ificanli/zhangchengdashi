using System;
using Il2CppDummyDll;

namespace IngameDebugConsole
{
	[Token(Token = "0x200001D")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false, AllowMultiple = true)]
	public class RuntimeInspectorCustomEditorAttribute : Attribute, IComparable<RuntimeInspectorCustomEditorAttribute>
	{
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x10")]
		private readonly Type m_inspectedType;

		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x18")]
		private readonly bool m_editorForChildClasses;

		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x1C")]
		private readonly int m_inspectedTypeDepth;

		[Token(Token = "0x1700005D")]
		public Type InspectedType
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x465A140", Offset = "0x4656140", VA = "0x465A140")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005E")]
		public bool EditorForChildClasses
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x465A148", Offset = "0x4656148", VA = "0x465A148")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x465A150", Offset = "0x4656150", VA = "0x465A150")]
		public RuntimeInspectorCustomEditorAttribute(Type inspectedType, bool editorForChildClasses = false)
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x465A230", Offset = "0x4656230", VA = "0x465A230", Slot = "7")]
int System.IComparable<IngameDebugConsole.RuntimeInspectorCustomEditorAttribute>.CompareTo(RuntimeInspectorCustomEditorAttribute other)
		{
			return default;
		}
	}
}
