using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F34")]
	[Skip]
	public class PropAttrTypeConfig : BaseConfig
	{
		[Token(Token = "0x4006946")]
		[FieldOffset(Offset = "0x10")]
		public int ID;

		[Token(Token = "0x4006947")]
		[FieldOffset(Offset = "0x18")]
		public string Des;

		[Token(Token = "0x4006948")]
		[FieldOffset(Offset = "0x20")]
		public float Factor;

		[Token(Token = "0x17000F5F")]
		public override object UniqueID
		{
			[Token(Token = "0x6005B22")]
			[Address(RVA = "0x439B3CC", Offset = "0x43973CC", VA = "0x439B3CC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005B23")]
		[Address(RVA = "0x439B428", Offset = "0x4397428", VA = "0x439B428")]
		public PropAttrTypeConfig()
		{
		}
	}
}
