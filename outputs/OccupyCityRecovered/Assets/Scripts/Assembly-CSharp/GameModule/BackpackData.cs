using System.Numerics;
using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000483")]
	public class BackpackData
	{
		[Token(Token = "0x4002B0F")]
		[FieldOffset(Offset = "0x10")]
		public RewardConfigSingle RewardConfigSingle;

		[Token(Token = "0x4002B10")]
		[FieldOffset(Offset = "0x18")]
		public BigInteger Count;

		[Token(Token = "0x4002B11")]
		[FieldOffset(Offset = "0x28")]
		public UserBoxData BoxData;

		[Token(Token = "0x4002B12")]
		[FieldOffset(Offset = "0x30")]
		public int BoxCount;

		[Token(Token = "0x6001629")]
		[Address(RVA = "0x3E270B8", Offset = "0x3E230B8", VA = "0x3E270B8")]
		public BackpackData()
		{
		}
	}
}
