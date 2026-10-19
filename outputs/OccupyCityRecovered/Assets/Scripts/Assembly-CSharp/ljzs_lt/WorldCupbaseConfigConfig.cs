using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F3F")]
	[Skip]
	public class WorldCupbaseConfigConfig : BaseConfig
	{
		[Token(Token = "0x4006982")]
		[FieldOffset(Offset = "0x10")]
		public int activity_id;

		[Token(Token = "0x4006983")]
		[FieldOffset(Offset = "0x14")]
		public int goalPoints;

		[Token(Token = "0x4006984")]
		[FieldOffset(Offset = "0x18")]
		public int ungoalPoints;

		[Token(Token = "0x4006985")]
		[FieldOffset(Offset = "0x1C")]
		public int goalProbability;

		[Token(Token = "0x4006986")]
		[FieldOffset(Offset = "0x20")]
		public int initBall;

		[Token(Token = "0x17000F6A")]
		public override object UniqueID
		{
			[Token(Token = "0x6005B38")]
			[Address(RVA = "0x439B818", Offset = "0x4397818", VA = "0x439B818", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005B39")]
		[Address(RVA = "0x439B874", Offset = "0x4397874", VA = "0x439B874")]
		public WorldCupbaseConfigConfig()
		{
		}
	}
}
