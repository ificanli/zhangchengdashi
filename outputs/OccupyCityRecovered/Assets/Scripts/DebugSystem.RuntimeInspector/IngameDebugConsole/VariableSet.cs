using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace IngameDebugConsole
{
	[Serializable]
	[Token(Token = "0x2000072")]
	public class VariableSet
	{
		[Token(Token = "0x4000228")]
		private const string INCLUDE_ALL_VARIABLES = "*";

		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string m_type;

		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x18")]
		public Type type;

		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string[] m_variables;

		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x28")]
		public HashSet<string> variables;

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x467A8F0", Offset = "0x46768F0", VA = "0x467A8F0")]
		public bool Init()
		{
			return default;
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x467AA84", Offset = "0x4676A84", VA = "0x467AA84")]
		private void AddAllVariablesToSet()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x467AB6C", Offset = "0x4676B6C", VA = "0x467AB6C")]
		public VariableSet()
		{
		}
	}
}
