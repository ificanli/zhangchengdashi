using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Pathfinding.Clipper2Lib
{
	[Token(Token = "0x2000026")]
	public class ClipperD : ClipperBase
	{
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x88")]
		private readonly string precision_range_error;

		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x90")]
		private readonly double _scale;

		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x98")]
		private readonly double _invScale;

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x46199C8", Offset = "0x46159C8", VA = "0x46199C8")]
		public ClipperD(int roundingDecimalPrecision = 2)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x4619B14", Offset = "0x4615B14", VA = "0x4619B14")]
		public void AddPath(PathD path, PathType polytype, bool isOpen = false)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x4619BB0", Offset = "0x4615BB0", VA = "0x4619BB0")]
		public void AddPaths(PathsD paths, PathType polytype, bool isOpen = false)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x4619C60", Offset = "0x4615C60", VA = "0x4619C60")]
		public void AddSubject(PathD path)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x4619CE4", Offset = "0x4615CE4", VA = "0x4619CE4")]
		public void AddOpenSubject(PathD path)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x4619D68", Offset = "0x4615D68", VA = "0x4619D68")]
		public void AddClip(PathD path)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x4619DEC", Offset = "0x4615DEC", VA = "0x4619DEC")]
		public void AddSubject(PathsD paths)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x4619E78", Offset = "0x4615E78", VA = "0x4619E78")]
		public void AddOpenSubject(PathsD paths)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x4619F08", Offset = "0x4615F08", VA = "0x4619F08")]
		public void AddClip(PathsD paths)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x4619F94", Offset = "0x4615F94", VA = "0x4619F94")]
		public bool Execute(ClipType clipType, FillRule fillRule, PathsD solutionClosed, PathsD solutionOpen)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x461A4E0", Offset = "0x46164E0", VA = "0x461A4E0")]
		public bool Execute(ClipType clipType, FillRule fillRule, PathsD solutionClosed)
		{
			return default;
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x461A564", Offset = "0x4616564", VA = "0x461A564")]
		public bool Execute(ClipType clipType, FillRule fillRule, PolyTreeD polytree, PathsD openPaths)
		{
			return default;
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x461A958", Offset = "0x4616958", VA = "0x461A958")]
		public bool Execute(ClipType clipType, FillRule fillRule, PolyTreeD polytree)
		{
			return default;
		}
	}
}
