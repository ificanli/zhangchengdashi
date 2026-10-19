using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F26")]
	[Skip]
	public class CumulativeRewardConfig : BaseConfig
	{
		[Token(Token = "0x40068F2")]
		[FieldOffset(Offset = "0x10")]
		public int ID;

		[Token(Token = "0x40068F3")]
		[FieldOffset(Offset = "0x14")]
		public int RewardType;

		[Token(Token = "0x40068F4")]
		[FieldOffset(Offset = "0x18")]
		public int RewardID;

		[Token(Token = "0x40068F5")]
		[FieldOffset(Offset = "0x1C")]
		public int Num;

		[Token(Token = "0x40068F6")]
		[FieldOffset(Offset = "0x20")]
		public int NeedDays;

		[Token(Token = "0x17000F51")]
		public override object UniqueID
		{
			[Token(Token = "0x6005B06")]
			[Address(RVA = "0x439AE54", Offset = "0x4396E54", VA = "0x439AE54", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005B07")]
		[Address(RVA = "0x439AEB0", Offset = "0x4396EB0", VA = "0x439AEB0")]
		public CumulativeRewardConfig()
		{
		}
	}
}
