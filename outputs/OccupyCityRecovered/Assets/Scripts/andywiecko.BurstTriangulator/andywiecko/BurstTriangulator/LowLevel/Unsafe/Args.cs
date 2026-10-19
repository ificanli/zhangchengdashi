using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace andywiecko.BurstTriangulator.LowLevel.Unsafe
{
	[Token(Token = "0x2000017")]
	public readonly struct Args
	{
		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly Preprocessor Preprocessor;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public readonly int SloanMaxIters;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly bool AutoHolesAndBoundary;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		public readonly bool RefineMesh;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public readonly bool RestoreBoundary;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
		public readonly bool ValidateInput;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public readonly bool Verbose;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly float RefinementThresholdAngle;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public readonly float RefinementThresholdArea;

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x3CF3D7C", Offset = "0x3CEFD7C", VA = "0x3CF3D7C")]
		public Args(Preprocessor preprocessor, int sloanMaxIters, bool autoHolesAndBoundary, bool refineMesh, bool restoreBoundary, bool validateInput, bool verbose, float refinementThresholdAngle, float refinementThresholdArea)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Args..ctor RVA=0x3CF3D7C Token=0x600006B");
}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x3CF3DB0", Offset = "0x3CEFDB0", VA = "0x3CF3DB0")]
		public static Args Default(Preprocessor preprocessor = Preprocessor.None, int sloanMaxIters = 1000000, bool autoHolesAndBoundary = false, bool refineMesh = false, bool restoreBoundary = false, bool validateInput = true, bool verbose = true, float refinementThresholdAngle = 0.08726646f, float refinementThresholdArea = 1f)
		{
			return default;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x3CF38F8", Offset = "0x3CEF8F8", VA = "0x3CF38F8")]
		public static implicit operator Args(TriangulationSettings settings)
		{
			return default;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x3CF3DE8", Offset = "0x3CEFDE8", VA = "0x3CF3DE8")]
		public Args With([Optional] Preprocessor? preprocessor, [Optional] int? sloanMaxIters, [Optional] bool? autoHolesAndBoundary, [Optional] bool? refineMesh, [Optional] bool? restoreBoundary, [Optional] bool? validateInput, [Optional] bool? verbose, [Optional] float? refinementThresholdAngle, [Optional] float? refinementThresholdArea)
		{
			return default;
		}
	}
}
