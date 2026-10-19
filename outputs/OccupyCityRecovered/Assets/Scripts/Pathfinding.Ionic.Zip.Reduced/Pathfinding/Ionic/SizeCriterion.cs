using Il2CppDummyDll;
using Pathfinding.Ionic.Zip;

namespace Pathfinding.Ionic
{
	[Token(Token = "0x200001A")]
	internal class SizeCriterion : SelectionCriterion
	{
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x14")]
		internal ComparisonOperator Operator;

		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x18")]
		internal long Size;

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x7839728", Offset = "0x7835728", VA = "0x7839728")]
		public SizeCriterion()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x7839730", Offset = "0x7835730", VA = "0x7839730", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x7839998", Offset = "0x7835998", VA = "0x7839998", Slot = "6")]
		internal override bool Evaluate(string filename)
		{
			return default;
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x7839A18", Offset = "0x7835A18", VA = "0x7839A18")]
		private bool _Evaluate(long Length)
		{
			return default;
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x7839AEC", Offset = "0x7835AEC", VA = "0x7839AEC", Slot = "7")]
		internal override bool Evaluate(ZipEntry entry)
		{
			return default;
		}
	}
}
