using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Ionic.Zip;

namespace Pathfinding.Ionic
{
	[Token(Token = "0x200001F")]
	public class FileSelector
	{
		[Token(Token = "0x2000020")]
		private enum ParseState
		{
			[Token(Token = "0x4000051")]
			Start = 0,
			[Token(Token = "0x4000052")]
			OpenParen = 1,
			[Token(Token = "0x4000053")]
			CriterionDone = 2,
			[Token(Token = "0x4000054")]
			ConjunctionPending = 3,
			[Token(Token = "0x4000055")]
			Whitespace = 4
		}

		[Token(Token = "0x2000021")]
		private static class RegexAssertions
		{
			[Token(Token = "0x4000056")]
			[FieldOffset(Offset = "0x0")]
			public static readonly string PrecededByOddNumberOfSingleQuotes;

			[Token(Token = "0x4000057")]
			[FieldOffset(Offset = "0x8")]
			public static readonly string FollowedByOddNumberOfSingleQuotesAndLineEnd;

			[Token(Token = "0x4000058")]
			[FieldOffset(Offset = "0x10")]
			public static readonly string PrecededByEvenNumberOfSingleQuotes;

			[Token(Token = "0x4000059")]
			[FieldOffset(Offset = "0x18")]
			public static readonly string FollowedByEvenNumberOfSingleQuotesAndLineEnd;
		}

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x10")]
		internal SelectionCriterion _Criterion;

		[Token(Token = "0x17000011")]
		public string SelectionCriteria
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x783C1AC", Offset = "0x78381AC", VA = "0x783C1AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x783C1C4", Offset = "0x78381C4", VA = "0x783C1C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public bool TraverseReparsePoints
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x783C24C", Offset = "0x783824C", VA = "0x783C24C")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x783C254", Offset = "0x7838254", VA = "0x783C254")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x783AB60", Offset = "0x7836B60", VA = "0x783AB60")]
		public FileSelector(string selectionCriteria)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x783AB68", Offset = "0x7836B68", VA = "0x783AB68")]
		public FileSelector(string selectionCriteria, bool traverseDirectoryReparsePoints)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x783C260", Offset = "0x7838260", VA = "0x783C260")]
		private static string NormalizeCriteriaExpression(string source)
		{
			return null;
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x783ABB4", Offset = "0x7836BB4", VA = "0x783ABB4")]
		private static SelectionCriterion _ParseCriterion(string s)
		{
			return null;
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x783C8B8", Offset = "0x78388B8", VA = "0x783C8B8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x783C938", Offset = "0x7838938", VA = "0x783C938")]
		private bool Evaluate(string filename)
		{
			return default;
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x783C958", Offset = "0x7838958", VA = "0x783C958")]
		[Conditional("SelectorTrace")]
		private void SelectorTrace(string format, params object[] args)
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x783C9EC", Offset = "0x78389EC", VA = "0x783C9EC")]
		public ICollection<string> SelectFiles(string directory)
		{
			return null;
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x783C9F4", Offset = "0x78389F4", VA = "0x783C9F4")]
		public ReadOnlyCollection<string> SelectFiles(string directory, bool recurseDirectories)
		{
			return null;
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x783CDD0", Offset = "0x7838DD0", VA = "0x783CDD0")]
		private bool Evaluate(ZipEntry entry)
		{
			return default;
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x783CDF0", Offset = "0x7838DF0", VA = "0x783CDF0")]
		public ICollection<ZipEntry> SelectEntries(ZipFile zip)
		{
			return null;
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x783D188", Offset = "0x7839188", VA = "0x783D188")]
		public ICollection<ZipEntry> SelectEntries(ZipFile zip, string directoryPathInArchive)
		{
			return null;
		}
	}
}
