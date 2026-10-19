using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;

namespace IngameDebugConsole
{
	[Token(Token = "0x200004F")]
	public class ExposedVariablesEnumerator : IEnumerator<MemberInfo>, IEnumerator, IDisposable, IEnumerable<MemberInfo>, IEnumerable
	{
		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x10")]
		private int index;

		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x18")]
		private readonly MemberInfo[] variables;

		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<VariableSet> hiddenVariables;

		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x28")]
		private readonly List<VariableSet> exposedVariables;

		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x30")]
		private readonly RuntimeInspector.VariableVisibility fieldVisibility;

		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x34")]
		private readonly RuntimeInspector.VariableVisibility propertyVisibility;

		[Token(Token = "0x1700008D")]
		public MemberInfo Current
		{
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x466EED4", Offset = "0x466AED4", VA = "0x466EED4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008E")]
object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x466EF08", Offset = "0x466AF08", VA = "0x466EF08", Slot = "7")]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x466EF08", Offset = "0x466AF08", VA = "0x466EF08", Slot = "7")]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x466EF3C", Offset = "0x466AF3C", VA = "0x466EF3C")]
		public ExposedVariablesEnumerator(MemberInfo[] variables, List<VariableSet> hiddenVariables, List<VariableSet> exposedVariables, RuntimeInspector.VariableVisibility fieldVisibility, RuntimeInspector.VariableVisibility propertyVisibility)
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x466EF94", Offset = "0x466AF94", VA = "0x466EF94", Slot = "5")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x4666710", Offset = "0x4662710", VA = "0x4666710", Slot = "9")]
		public IEnumerator<MemberInfo> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x466EF98", Offset = "0x466AF98", VA = "0x466EF98", Slot = "10")]
IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x466EF9C", Offset = "0x466AF9C", VA = "0x466EF9C", Slot = "6")]
		public bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x466F27C", Offset = "0x466B27C", VA = "0x466F27C", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x466F014", Offset = "0x466B014", VA = "0x466F014")]
		private bool ShouldExposeVariable(MemberInfo variable)
		{
			return default;
		}
	}
}
