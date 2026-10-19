using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F3C")]
	[Skip]
	public class SubGameBuffConfig : BaseConfig
	{
		[Token(Token = "0x4006974")]
		[FieldOffset(Offset = "0x10")]
		public int ID;

		[Token(Token = "0x4006975")]
		[FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x4006976")]
		[FieldOffset(Offset = "0x20")]
		public int Rare;

		[Token(Token = "0x4006977")]
		[FieldOffset(Offset = "0x24")]
		public int Weight;

		[Token(Token = "0x4006978")]
		[FieldOffset(Offset = "0x28")]
		public string Icon;

		[Token(Token = "0x4006979")]
		[FieldOffset(Offset = "0x30")]
		public string Des;

		[Token(Token = "0x17000F67")]
		public override object UniqueID
		{
			[Token(Token = "0x6005B32")]
			[Address(RVA = "0x439B6EC", Offset = "0x43976EC", VA = "0x439B6EC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005B33")]
		[Address(RVA = "0x439B748", Offset = "0x4397748", VA = "0x439B748")]
		public SubGameBuffConfig()
		{
		}
	}
}
