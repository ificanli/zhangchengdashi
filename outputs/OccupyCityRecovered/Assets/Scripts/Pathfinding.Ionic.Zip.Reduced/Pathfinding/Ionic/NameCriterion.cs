using System.Text.RegularExpressions;
using Il2CppDummyDll;
using Pathfinding.Ionic.Zip;

namespace Pathfinding.Ionic
{
	[Token(Token = "0x200001C")]
	internal class NameCriterion : SelectionCriterion
	{
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x18")]
		private Regex _re;

		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x20")]
		private string _regexString;

		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x28")]
		internal ComparisonOperator Operator;

		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x30")]
		private string _MatchingFileSpec;

		[Token(Token = "0x1700000E")]
		internal virtual string MatchingFileSpec
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x783A070", Offset = "0x7836070", VA = "0x783A070", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x783A068", Offset = "0x7836068", VA = "0x783A068")]
		public NameCriterion()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x783A288", Offset = "0x7836288", VA = "0x783A288", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x783A3BC", Offset = "0x78363BC", VA = "0x783A3BC", Slot = "6")]
		internal override bool Evaluate(string filename)
		{
			return default;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x783A3C0", Offset = "0x78363C0", VA = "0x783A3C0")]
		private bool _Evaluate(string fullpath)
		{
			return default;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x783A46C", Offset = "0x783646C", VA = "0x783A46C", Slot = "7")]
		internal override bool Evaluate(ZipEntry entry)
		{
			return default;
		}
	}
}
