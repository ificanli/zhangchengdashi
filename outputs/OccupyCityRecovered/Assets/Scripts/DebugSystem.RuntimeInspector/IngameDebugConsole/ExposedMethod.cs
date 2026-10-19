using System.Reflection;
using Il2CppDummyDll;

namespace IngameDebugConsole
{
	[Token(Token = "0x200004D")]
	public struct ExposedMethod
	{
		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x0")]
		private readonly MethodInfo method;

		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x8")]
		private readonly RuntimeInspectorButtonAttribute properties;

		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x10")]
		private readonly bool isExtensionMethod;

		[Token(Token = "0x17000089")]
		public string Label
		{
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x465E1B8", Offset = "0x465A1B8", VA = "0x465E1B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008A")]
		public bool IsInitializer
		{
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x465E2C0", Offset = "0x465A2C0", VA = "0x465E2C0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700008B")]
		public bool VisibleWhenInitialized
		{
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x4663A00", Offset = "0x465FA00", VA = "0x4663A00")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700008C")]
		public bool VisibleWhenUninitialized
		{
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x4663A20", Offset = "0x465FA20", VA = "0x4663A20")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x4661504", Offset = "0x465D504", VA = "0x4661504")]
		public ExposedMethod(MethodInfo method, RuntimeInspectorButtonAttribute properties, bool isExtensionMethod)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ExposedMethod..ctor RVA=0x4661504 Token=0x60002BC");
}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x465E488", Offset = "0x465A488", VA = "0x465E488")]
		public void Call(object source)
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x465E2DC", Offset = "0x465A2DC", VA = "0x465E2DC")]
		public object CallAndReturnValue(object source)
		{
			return null;
		}
	}
}
