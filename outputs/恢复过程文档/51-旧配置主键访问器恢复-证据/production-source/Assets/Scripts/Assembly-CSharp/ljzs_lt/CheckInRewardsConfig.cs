using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F20")]
	[Skip]
	public class CheckInRewardsConfig : BaseConfig
	{
		[Token(Token = "0x40068DB")]
		[FieldOffset(Offset = "0x10")]
		public int ID;

		[Token(Token = "0x40068DC")]
		[FieldOffset(Offset = "0x14")]
		public int RewardType;

		[Token(Token = "0x40068DD")]
		[FieldOffset(Offset = "0x18")]
		public int RewardID;

		[Token(Token = "0x40068DE")]
		[FieldOffset(Offset = "0x1C")]
		public int Num;

		[Token(Token = "0x17000F4B")]
		public override object UniqueID
		{
			[Token(Token = "0x6005AFA")]
			[Address(RVA = "0x439ABFC", Offset = "0x4396BFC", VA = "0x439ABFC", Slot = "4")]
			get
			{
				return ID;
			}
		}

		[Token(Token = "0x6005AFB")]
		[Address(RVA = "0x439AC58", Offset = "0x4396C58", VA = "0x439AC58")]
		public CheckInRewardsConfig()
		{
		}
	}
}
