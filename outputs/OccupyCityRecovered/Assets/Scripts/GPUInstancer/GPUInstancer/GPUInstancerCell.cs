using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x2000027")]
	public abstract class GPUInstancerCell
	{
		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly int[] _primes;

		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x10")]
		public Bounds cellBounds;

		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x28")]
		public Bounds cellInnerBounds;

		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x40")]
		public int coordX;

		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x44")]
		public int coordY;

		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x48")]
		public int coordZ;

		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x4C")]
		public bool isActive;

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x73B8E60", Offset = "0x73B4E60", VA = "0x73B8E60")]
		public int CalculateHash()
		{
			return default;
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x73B8EC4", Offset = "0x73B4EC4", VA = "0x73B8EC4")]
		public static int CalculateHash(int coordX, int coordY, int coordZ)
		{
			return default;
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x73B8F74", Offset = "0x73B4F74", VA = "0x73B8F74")]
		protected GPUInstancerCell()
		{
		}
	}
}
