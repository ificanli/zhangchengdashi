using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Serialization
{
	[Token(Token = "0x2000251")]
	public class TinyJsonSerializer
	{
		[Token(Token = "0x4000AEF")]
		[FieldOffset(Offset = "0x10")]
		private StringBuilder output;

		[Token(Token = "0x4000AF0")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<Type, Action<object>> serializers;

		[Token(Token = "0x4000AF1")]
		[FieldOffset(Offset = "0x0")]
		private static readonly CultureInfo invariantCulture;

		[Token(Token = "0x6000E9A")]
		[Address(RVA = "0x447F1BC", Offset = "0x447B1BC", VA = "0x447F1BC")]
		public static void Serialize(object obj, StringBuilder output)
		{
		}

		[Token(Token = "0x6000E9B")]
		[Address(RVA = "0x4483000", Offset = "0x447F000", VA = "0x4483000")]
		private TinyJsonSerializer()
		{
		}

		[Token(Token = "0x6000E9C")]
		[Address(RVA = "0x448353C", Offset = "0x447F53C", VA = "0x448353C")]
		private void Serialize(object obj, bool serializePrivateFieldsByDefault = false)
		{
		}

		[Token(Token = "0x6000E9D")]
		[Address(RVA = "0x4484034", Offset = "0x4480034", VA = "0x4484034")]
		private void QuotedField(string name, string contents)
		{
		}

		[Token(Token = "0x6000E9E")]
		[Address(RVA = "0x4483C70", Offset = "0x447FC70", VA = "0x4483C70")]
		private void SerializeUnityObject(UnityEngine.Object obj)
		{
		}
	}
}
