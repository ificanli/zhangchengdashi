using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F25")]
	[Skip]
	public class CrystalPackConfig : BaseConfig
	{
		[Token(Token = "0x40068EB")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x40068EC")]
		[FieldOffset(Offset = "0x18")]
		public string PackDes;

		[Token(Token = "0x40068ED")]
		[FieldOffset(Offset = "0x20")]
		public int Benefit;

		[Token(Token = "0x40068EE")]
		[FieldOffset(Offset = "0x28")]
		public string PackID;

		[Token(Token = "0x40068EF")]
		[FieldOffset(Offset = "0x30")]
		public int LimitType;

		[Token(Token = "0x40068F0")]
		[FieldOffset(Offset = "0x34")]
		public int DailyCount;

		[Token(Token = "0x40068F1")]
		[FieldOffset(Offset = "0x38")]
		public string[] rewards;

		[Token(Token = "0x17000F50")]
		public override object UniqueID
		{
			[Token(Token = "0x6005B04")]
			[Address(RVA = "0x439ADF0", Offset = "0x4396DF0", VA = "0x439ADF0", Slot = "4")]
			get
			{
				return id;
			}
		}

		[Token(Token = "0x6005B05")]
		[Address(RVA = "0x439AE4C", Offset = "0x4396E4C", VA = "0x439AE4C")]
		public CrystalPackConfig()
		{
		}
	}
}
