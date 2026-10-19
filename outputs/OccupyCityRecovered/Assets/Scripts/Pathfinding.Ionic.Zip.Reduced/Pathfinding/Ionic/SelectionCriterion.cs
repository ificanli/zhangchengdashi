using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Ionic.Zip;

namespace Pathfinding.Ionic
{
	[Token(Token = "0x2000019")]
	internal abstract class SelectionCriterion
	{
		[Token(Token = "0x1700000D")]
		internal virtual bool Verbose
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x7839710", Offset = "0x7835710", VA = "0x7839710", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x7839718", Offset = "0x7835718", VA = "0x7839718", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x7839708", Offset = "0x7835708", VA = "0x7839708")]
		protected SelectionCriterion()
		{
		}

		[Token(Token = "0x600005D")]
		internal abstract bool Evaluate(string filename);

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x7839724", Offset = "0x7835724", VA = "0x7839724")]
		[Conditional("SelectorTrace")]
		protected static void CriterionTrace(string format, params object[] args)
		{
		}

		[Token(Token = "0x600005F")]
		internal abstract bool Evaluate(ZipEntry entry);
	}
}
