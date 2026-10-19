using System;
using System.Reflection;
using Il2CppDummyDll;

namespace IngameDebugConsole
{
	[Token(Token = "0x200003D")]
	public class TransformField : ExpandableInspectorField
	{
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0xC0")]
		private PropertyInfo positionProp;

		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0xC8")]
		private PropertyInfo rotationProp;

		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0xD0")]
		private PropertyInfo scaleProp;

		[Token(Token = "0x17000079")]
		protected override int Length
		{
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x4669444", Offset = "0x4665444", VA = "0x4669444", Slot = "17")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x466944C", Offset = "0x466544C", VA = "0x466944C", Slot = "8")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x4669564", Offset = "0x4665564", VA = "0x4669564", Slot = "9")]
		public override bool SupportsType(Type type)
		{
			return default;
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x46695EC", Offset = "0x46655EC", VA = "0x46695EC", Slot = "18")]
		protected override void GenerateElements()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x4669688", Offset = "0x4665688", VA = "0x4669688")]
		public TransformField()
		{
		}
	}
}
