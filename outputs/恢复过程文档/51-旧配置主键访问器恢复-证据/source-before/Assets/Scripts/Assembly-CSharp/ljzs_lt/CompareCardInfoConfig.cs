using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F23")]
	[Skip]
	public class CompareCardInfoConfig : BaseConfig
	{
		[Token(Token = "0x40068E4")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x40068E5")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x40068E6")]
		[FieldOffset(Offset = "0x20")]
		public int Rare;

		[Token(Token = "0x17000F4E")]
		public override object UniqueID
		{
			[Token(Token = "0x6005B00")]
			[Address(RVA = "0x439AD28", Offset = "0x4396D28", VA = "0x439AD28", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005B01")]
		[Address(RVA = "0x439AD84", Offset = "0x4396D84", VA = "0x439AD84")]
		public CompareCardInfoConfig()
		{
		}
	}
}
