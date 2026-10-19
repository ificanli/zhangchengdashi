using System;
using Il2CppDummyDll;

namespace Pathfinding.Graphs.Grid.Rules
{
	[Token(Token = "0x200020F")]
	public class CustomGridGraphRuleEditorAttribute : Attribute
	{
		[Token(Token = "0x40009C6")]
		[FieldOffset(Offset = "0x10")]
		public Type type;

		[Token(Token = "0x40009C7")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x6000DC8")]
		[Address(RVA = "0x4476E60", Offset = "0x4472E60", VA = "0x4476E60")]
		public CustomGridGraphRuleEditorAttribute(Type type, string name)
		{
		}
	}
}
