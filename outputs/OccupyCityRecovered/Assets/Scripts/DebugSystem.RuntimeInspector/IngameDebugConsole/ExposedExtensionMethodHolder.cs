using System;
using System.Reflection;
using Il2CppDummyDll;

namespace IngameDebugConsole
{
	[Token(Token = "0x200004E")]
	public struct ExposedExtensionMethodHolder
	{
		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x0")]
		public readonly Type extendedType;

		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x8")]
		public readonly MethodInfo method;

		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x10")]
		public readonly RuntimeInspectorButtonAttribute properties;

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x466EEC8", Offset = "0x466AEC8", VA = "0x466EEC8")]
		public ExposedExtensionMethodHolder(Type extendedType, MethodInfo method, RuntimeInspectorButtonAttribute properties)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ExposedExtensionMethodHolder..ctor RVA=0x466EEC8 Token=0x60002BF");
}
	}
}
