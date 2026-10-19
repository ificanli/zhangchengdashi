using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F2A")]
	[Skip]
	public class GoalRewardConfig : BaseConfig
	{
		[Token(Token = "0x4006911")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x4006912")]
		[FieldOffset(Offset = "0x14")]
		public int itemType;

		[Token(Token = "0x4006913")]
		[FieldOffset(Offset = "0x18")]
		public int item;

		[Token(Token = "0x4006914")]
		[FieldOffset(Offset = "0x1C")]
		public int count;

		[Token(Token = "0x4006915")]
		[FieldOffset(Offset = "0x20")]
		public int weight;

		[Token(Token = "0x17000F55")]
		public override object UniqueID
		{
			[Token(Token = "0x6005B0E")]
			[Address(RVA = "0x439AFE4", Offset = "0x4396FE4", VA = "0x439AFE4", Slot = "4")]
			get
			{
				return id;
			}
		}

		[Token(Token = "0x6005B0F")]
		[Address(RVA = "0x439B040", Offset = "0x4397040", VA = "0x439B040")]
		public GoalRewardConfig()
		{
		}
	}
}
