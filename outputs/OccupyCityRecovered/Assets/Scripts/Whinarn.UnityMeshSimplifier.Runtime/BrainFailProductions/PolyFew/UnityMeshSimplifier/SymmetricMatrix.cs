using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace BrainFailProductions.PolyFew.UnityMeshSimplifier
{
	[StructLayout((LayoutKind)0)]
	[Token(Token = "0x2000022")]
	public class SymmetricMatrix
	{
		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public double m0;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public double m1;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public double m2;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public double m3;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public double m4;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public double m5;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public double m6;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public double m7;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public double m8;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public double m9;

		[Token(Token = "0x1700003E")]
		public double this[int index]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x856B7F8", Offset = "0x85677F8", VA = "0x856B7F8")]
			get
			{
				return default;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x856B8C0", Offset = "0x85678C0", VA = "0x856B8C0")]
		public SymmetricMatrix(double c)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x856B8F8", Offset = "0x85678F8", VA = "0x856B8F8")]
		public SymmetricMatrix(double m0, double m1, double m2, double m3, double m4, double m5, double m6, double m7, double m8, double m9)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x856B978", Offset = "0x8567978", VA = "0x856B978")]
		public SymmetricMatrix(double a, double b, double c, double d)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x856B9EC", Offset = "0x85679EC", VA = "0x856B9EC")]
		public SymmetricMatrix(Vector3d n, Vector3d p)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x856BA88", Offset = "0x8567A88", VA = "0x856BA88")]
		public static SymmetricMatrix operator +(SymmetricMatrix a, SymmetricMatrix b)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x856BBE4", Offset = "0x8567BE4", VA = "0x856BBE4")]
		internal double Determinant1()
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x856BC3C", Offset = "0x8567C3C", VA = "0x856BC3C")]
		internal double Determinant2()
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x856BC98", Offset = "0x8567C98", VA = "0x856BC98")]
		internal double Determinant3()
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x856BCF0", Offset = "0x8567CF0", VA = "0x856BCF0")]
		internal double Determinant4()
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x856BD4C", Offset = "0x8567D4C", VA = "0x856BD4C")]
		internal bool ShapeIsGood()
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x856C1E4", Offset = "0x85681E4", VA = "0x856C1E4")]
		public double Determinant(int a11, int a12, int a13, int a21, int a22, int a23, int a31, int a32, int a33)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x856CAB0", Offset = "0x8568AB0", VA = "0x856CAB0")]
		public void Add(ref Vector3d n, ref Vector3d p, double scale = 1.0)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x856CBC4", Offset = "0x8568BC4", VA = "0x856CBC4")]
		public void Add(SymmetricMatrix b)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x856CC20", Offset = "0x8568C20", VA = "0x856CC20")]
		public void Subtract(ref Vector3d n, ref Vector3d p)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x856CD14", Offset = "0x8568D14", VA = "0x856CD14")]
		public void Subtract(SymmetricMatrix b)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x856CD70", Offset = "0x8568D70", VA = "0x856CD70")]
		public void Multiply(double a)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x856CDA0", Offset = "0x8568DA0", VA = "0x856CDA0")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x856CDB4", Offset = "0x8568DB4", VA = "0x856CDB4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
