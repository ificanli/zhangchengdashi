using Il2CppDummyDll;
using Pathfinding.Ionic.Zip;

namespace Pathfinding.Ionic
{
	[Token(Token = "0x200001E")]
	internal class CompoundCriterion : SelectionCriterion
	{
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x14")]
		internal LogicalConjunction Conjunction;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x18")]
		internal SelectionCriterion Left;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x20")]
		private SelectionCriterion _Right;

		[Token(Token = "0x17000010")]
		internal SelectionCriterion Right
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x783A7BC", Offset = "0x78367BC", VA = "0x783A7BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x783A7C4", Offset = "0x78367C4", VA = "0x783A7C4")]
			set
			{
			}
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x783A7B4", Offset = "0x78367B4", VA = "0x783A7B4")]
		public CompoundCriterion()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x783A7EC", Offset = "0x78367EC", VA = "0x783A7EC", Slot = "6")]
		internal override bool Evaluate(string filename)
		{
			return default;
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x783A8E0", Offset = "0x78368E0", VA = "0x783A8E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x783AAB4", Offset = "0x7836AB4", VA = "0x783AAB4", Slot = "7")]
		internal override bool Evaluate(ZipEntry entry)
		{
			return default;
		}
	}
}
