using Il2CppDummyDll;
using Pathfinding.Collections;
using Unity.Collections;
using Unity.Mathematics;

namespace Pathfinding.Jobs
{
	[Token(Token = "0x2000176")]
	public readonly struct Slice3D
	{
		[Token(Token = "0x4000780")]
		[FieldOffset(Offset = "0x0")]
		public readonly int3 outerSize;

		[Token(Token = "0x4000781")]
		[FieldOffset(Offset = "0xC")]
		public readonly IntBounds slice;

		[Token(Token = "0x170001EC")]
		public int length
		{
			[Token(Token = "0x6000B90")]
			[Address(RVA = "0x4581760", Offset = "0x457D760", VA = "0x4581760")]
			get
			{ var size=slice.size;return unchecked(size.x*size.y*size.z); }
		}

		[Token(Token = "0x170001ED")]
		public (int, int, int) outerStrides
		{
			[Token(Token = "0x6000B91")]
			[Address(RVA = "0x45816EC", Offset = "0x457D6EC", VA = "0x45816EC")]
			get
			{ return (1,unchecked(outerSize.x*outerSize.z),outerSize.x); }
		}

		[Token(Token = "0x170001EE")]
		public (int, int, int) innerStrides
		{
			[Token(Token = "0x6000B92")]
			[Address(RVA = "0x45817E4", Offset = "0x457D7E4", VA = "0x45817E4")]
			get
			{ var size=slice.size;return (1,unchecked(size.x*size.z),size.x); }
		}

		[Token(Token = "0x170001EF")]
		public int outerStartIndex
		{
			[Token(Token = "0x6000B93")]
			[Address(RVA = "0x45818B8", Offset = "0x457D8B8", VA = "0x45818B8")]
			get
			{ var strides=outerStrides;return unchecked(slice.min.x*strides.Item1+slice.min.y*strides.Item2+slice.min.z*strides.Item3); }
		}

		[Token(Token = "0x170001F0")]
		public bool coversEverything
		{
			[Token(Token = "0x6000B94")]
			[Address(RVA = "0x45818E4", Offset = "0x457D8E4", VA = "0x45818E4")]
			get
			{ return Unity.Mathematics.math.all(slice.size==outerSize); }
		}

		[Token(Token = "0x6000B89")]
		[Address(RVA = "0x45815E8", Offset = "0x457D5E8", VA = "0x45815E8")]
		public Slice3D(IntBounds outer, IntBounds slice)
		{ outerSize=outer.size;this.slice=slice.Offset(-outer.min); }

		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0x4581678", Offset = "0x457D678", VA = "0x4581678")]
		public Slice3D(int3 outerSize, IntBounds slice)
		{ this.outerSize=outerSize;this.slice=slice; }

		[Token(Token = "0x6000B8B")]
		public void AssertMatchesOuter<T>(UnsafeSpan<T> values) where T : unmanaged
		{
		}

		[Token(Token = "0x6000B8C")]
		public void AssertMatchesOuter<T>(NativeArray<T> values) where T : struct
		{}

		[Token(Token = "0x6000B8D")]
		public void AssertMatchesInner<T>(NativeArray<T> values) where T : struct
		{
		}

		[Token(Token = "0x6000B8E")]
		[Address(RVA = "0x4581694", Offset = "0x457D694", VA = "0x4581694")]
		public void AssertSameSize(Slice3D other)
		{
		}

		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x4581698", Offset = "0x457D698", VA = "0x4581698")]
		public int InnerCoordinateToOuterIndex(int x, int y, int z)
		{
 var strides = outerStrides;
 return unchecked((x + slice.min.x) * strides.Item1 + (y + slice.min.y) * strides.Item2 + (z + slice.min.z) * strides.Item3);
}
	}
}
