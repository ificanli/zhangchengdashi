using System;
using Il2CppDummyDll;

namespace IngameDebugConsole
{
	[Token(Token = "0x200001C")]
	[AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
	public class RuntimeInspectorButtonAttribute : Attribute
	{
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x10")]
		private readonly string m_label;

		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x18")]
		private readonly bool m_isInitializer;

		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x1C")]
		private readonly ButtonVisibility m_visibility;

		[Token(Token = "0x1700005A")]
		public string Label
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x465A0E8", Offset = "0x46560E8", VA = "0x465A0E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		public bool IsInitializer
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x465A0F0", Offset = "0x46560F0", VA = "0x465A0F0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700005C")]
		public ButtonVisibility Visibility
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x465A0F8", Offset = "0x46560F8", VA = "0x465A0F8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x465A100", Offset = "0x4656100", VA = "0x465A100")]
		public RuntimeInspectorButtonAttribute(string label, bool isInitializer, ButtonVisibility visibility)
		{
		}
	}
}
