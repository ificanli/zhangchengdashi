using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F1E")]
	[Skip]
	public class BuildConfigConfig : BaseConfig
	{
		[Token(Token = "0x40068D1")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x40068D2")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x40068D3")]
		[FieldOffset(Offset = "0x20")]
		public int build_type;

		[Token(Token = "0x40068D4")]
		[FieldOffset(Offset = "0x24")]
		public int pool_id;

		[Token(Token = "0x40068D5")]
		[FieldOffset(Offset = "0x28")]
		public string des;

		[Token(Token = "0x40068D6")]
		[FieldOffset(Offset = "0x30")]
		public int buildIndex;

		[Token(Token = "0x40068D7")]
		[FieldOffset(Offset = "0x38")]
		public string image;

		[Token(Token = "0x17000F49")]
		public override object UniqueID
		{
			[Token(Token = "0x6005AF6")]
			[Address(RVA = "0x439AB34", Offset = "0x4396B34", VA = "0x439AB34", Slot = "4")]
			get
			{
				return id;
			}
		}

		[Token(Token = "0x6005AF7")]
		[Address(RVA = "0x439AB90", Offset = "0x4396B90", VA = "0x439AB90")]
		public BuildConfigConfig()
		{
		}
	}
}
