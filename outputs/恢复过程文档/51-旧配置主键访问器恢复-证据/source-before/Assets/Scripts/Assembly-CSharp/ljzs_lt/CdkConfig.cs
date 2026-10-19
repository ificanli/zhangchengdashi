using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F1F")]
	[Skip]
	public class CdkConfig : BaseConfig
	{
		[Token(Token = "0x40068D8")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x40068D9")]
		[FieldOffset(Offset = "0x18")]
		public string cdk;

		[Token(Token = "0x40068DA")]
		[FieldOffset(Offset = "0x20")]
		public string content;

		[Token(Token = "0x17000F4A")]
		public override object UniqueID
		{
			[Token(Token = "0x6005AF8")]
			[Address(RVA = "0x439AB98", Offset = "0x4396B98", VA = "0x439AB98", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005AF9")]
		[Address(RVA = "0x439ABF4", Offset = "0x4396BF4", VA = "0x439ABF4")]
		public CdkConfig()
		{
		}
	}
}
