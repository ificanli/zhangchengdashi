using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F42")]
	[Skip]
	public class WorldCuphow2PlayConfig : BaseConfig
	{
		[Token(Token = "0x400699F")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x40069A0")]
		[FieldOffset(Offset = "0x18")]
		public string des;

		[Token(Token = "0x17000F6D")]
		public override object UniqueID
		{
			[Token(Token = "0x6005B3E")]
			[Address(RVA = "0x439B944", Offset = "0x4397944", VA = "0x439B944", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005B3F")]
		[Address(RVA = "0x439B9A0", Offset = "0x43979A0", VA = "0x439B9A0")]
		public WorldCuphow2PlayConfig()
		{
		}
	}
}
