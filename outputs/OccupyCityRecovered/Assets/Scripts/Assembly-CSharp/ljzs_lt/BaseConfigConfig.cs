using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F1D")]
	[Skip]
	public class BaseConfigConfig : BaseConfig
	{
		[Token(Token = "0x40068CB")]
		[FieldOffset(Offset = "0x10")]
		public int activity_id;

		[Token(Token = "0x40068CC")]
		[FieldOffset(Offset = "0x14")]
		public int duration_days;

		[Token(Token = "0x40068CD")]
		[FieldOffset(Offset = "0x18")]
		public int face_min;

		[Token(Token = "0x40068CE")]
		[FieldOffset(Offset = "0x1C")]
		public int face_max;

		[Token(Token = "0x40068CF")]
		[FieldOffset(Offset = "0x20")]
		public int recover_interval_hour;

		[Token(Token = "0x40068D0")]
		[FieldOffset(Offset = "0x24")]
		public int natural_cap;

		[Token(Token = "0x17000F48")]
		public override object UniqueID
		{
			[Token(Token = "0x6005AF4")]
			[Address(RVA = "0x439AAD0", Offset = "0x4396AD0", VA = "0x439AAD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005AF5")]
		[Address(RVA = "0x439AB2C", Offset = "0x4396B2C", VA = "0x439AB2C")]
		public BaseConfigConfig()
		{
		}
	}
}
