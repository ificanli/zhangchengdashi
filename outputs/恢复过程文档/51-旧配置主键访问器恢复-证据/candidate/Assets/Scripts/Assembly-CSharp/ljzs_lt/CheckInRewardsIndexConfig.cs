using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F21")]
	[Skip]
	public class CheckInRewardsIndexConfig : BaseConfig
	{
		[Token(Token = "0x40068DF")]
		[FieldOffset(Offset = "0x10")]
		public int ID;

		[Token(Token = "0x40068E0")]
		[FieldOffset(Offset = "0x18")]
		public int[] CheckInRewards;

		[Token(Token = "0x40068E1")]
		[FieldOffset(Offset = "0x20")]
		public int[] CumulativeRewards;

		[Token(Token = "0x17000F4C")]
		public override object UniqueID
		{
			[Token(Token = "0x6005AFC")]
			[Address(RVA = "0x439AC60", Offset = "0x4396C60", VA = "0x439AC60", Slot = "4")]
			get
			{
				return ID;
			}
		}

		[Token(Token = "0x6005AFD")]
		[Address(RVA = "0x439ACBC", Offset = "0x4396CBC", VA = "0x439ACBC")]
		public CheckInRewardsIndexConfig()
		{
		}
	}
}
