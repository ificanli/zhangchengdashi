using System.Numerics;
using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000EEC")]
	public class UserProgressData : UserDataBase
	{
		[Token(Token = "0x40067AC")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x40067AD")]
		[FieldOffset(Offset = "0x20")]
		public int level;

		[Token(Token = "0x40067AE")]
		[FieldOffset(Offset = "0x28")]
		public string formulaId;

		[Token(Token = "0x6005A0B")]
		[Address(RVA = "0x43795F4", Offset = "0x43755F4", VA = "0x43795F4")]
		public UserProgressData()
		{
		}

		[Token(Token = "0x6005A0C")]
		[Address(RVA = "0x43795FC", Offset = "0x43755FC", VA = "0x43795FC")]
		public UserProgressData(GlobalProgressInfo info)
		{
		}

		[Token(Token = "0x6005A0D")]
		[Address(RVA = "0x4379648", Offset = "0x4375648", VA = "0x4379648", Slot = "4")]
		public virtual GlobalProgressInfo GetInfo()
		{
			return null;
		}

		[Token(Token = "0x6005A0E")]
		[Address(RVA = "0x437970C", Offset = "0x437570C", VA = "0x437970C")]
		public BigInteger GetPriceByLevel(int lv = -1)
		{
			return default;
		}

		[Token(Token = "0x6005A0F")]
		[Address(RVA = "0x4379850", Offset = "0x4375850", VA = "0x4379850")]
		public BigInteger GetValueByLevel(int lv = -1)
		{
			return default;
		}
	}
}
