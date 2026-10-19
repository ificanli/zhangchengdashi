using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace Unity.Entities.CodeGeneratedRegistry
{
	[Token(Token = "0x20003C7")]
	[Preserve]
	public class AssemblyTypeRegistry
	{
		[StructLayout((LayoutKind)2)]
		[Token(Token = "0x20003C8")]
		public struct ConstantData0
		{
		}

		[StructLayout((LayoutKind)2)]
		[Token(Token = "0x20003C9")]
		public struct ConstantData1
		{
		}

		[Token(Token = "0x4000FD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly TypeRegistry TypeRegistry;

		[Token(Token = "0x4000FD9")]
		[MetadataOffset(Offset = "0xBD25B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly ConstantData0 Value0/* Not supported: data() */;

		[Token(Token = "0x4000FDA")]
		[MetadataOffset(Offset = "0xBD46A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20F0")]
		private static readonly ConstantData1 Value1/* Not supported: data() */;

		[Token(Token = "0x60017F6")]
		[Address(RVA = "0x44E9AD0", Offset = "0x44E5AD0", VA = "0x44E9AD0")]
		public static bool Equals(object lhs, object rhs, int typeIndex)
		{
			return default;
		}

		[Token(Token = "0x60017F7")]
		[Address(RVA = "0x44EA880", Offset = "0x44E6880", VA = "0x44EA880")]
		public unsafe static bool Equals(object lhs, void* rhs, int typeIndex)
		{
			return default;
		}

		[Token(Token = "0x60017F8")]
		[Address(RVA = "0x44EB37C", Offset = "0x44E737C", VA = "0x44EB37C")]
		public static int BoxedGetHashCode(object val, int typeIndex)
		{
			return default;
		}

		[Token(Token = "0x60017F9")]
		[Address(RVA = "0x44EBE60", Offset = "0x44E7E60", VA = "0x44EBE60")]
		public static Attribute[] GetSystemAttributes(Type systemType)
		{
			return null;
		}

		[Token(Token = "0x60017FA")]
		[Address(RVA = "0x44ED2F8", Offset = "0x44E92F8", VA = "0x44ED2F8")]
		public unsafe static void SetSharedStaticTypeIndices(int* pTypeInfos, int count)
		{
		}
	}
}
