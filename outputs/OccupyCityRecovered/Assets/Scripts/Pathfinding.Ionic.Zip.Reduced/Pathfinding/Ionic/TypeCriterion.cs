using Il2CppDummyDll;
using Pathfinding.Ionic.Zip;

namespace Pathfinding.Ionic
{
	[Token(Token = "0x200001D")]
	internal class TypeCriterion : SelectionCriterion
	{
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x12")]
		private char ObjectType;

		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x14")]
		internal ComparisonOperator Operator;

		[Token(Token = "0x1700000F")]
		internal string AttributeString
		{
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x783A4F4", Offset = "0x78364F4", VA = "0x783A4F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x783A54C", Offset = "0x783654C", VA = "0x783A54C")]
			set
			{
			}
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x783A4EC", Offset = "0x78364EC", VA = "0x783A4EC")]
		public TypeCriterion()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x783A610", Offset = "0x7836610", VA = "0x783A610", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x783A730", Offset = "0x7836730", VA = "0x783A730", Slot = "6")]
		internal override bool Evaluate(string filename)
		{
			return default;
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x783A774", Offset = "0x7836774", VA = "0x783A774", Slot = "7")]
		internal override bool Evaluate(ZipEntry entry)
		{
			return default;
		}
	}
}
