using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F1B")]
	[Skip]
	public class AIPropInfoCConfig : BaseConfig
	{
		[Token(Token = "0x40068B1")]
		[FieldOffset(Offset = "0x10")]
		public int arnenaLevel;

		[Token(Token = "0x40068B2")]
		[FieldOffset(Offset = "0x18")]
		public int[] AIPropUpgrade1;

		[Token(Token = "0x40068B3")]
		[FieldOffset(Offset = "0x20")]
		public int[] AIPropUpgrade2;

		[Token(Token = "0x40068B4")]
		[FieldOffset(Offset = "0x28")]
		public int[] AIPropUpgrade3;

		[Token(Token = "0x40068B5")]
		[FieldOffset(Offset = "0x30")]
		public int[] AIPropUpgrade4;

		[Token(Token = "0x40068B6")]
		[FieldOffset(Offset = "0x38")]
		public int[] AIPropRank1;

		[Token(Token = "0x40068B7")]
		[FieldOffset(Offset = "0x40")]
		public int[] AIPropRank2;

		[Token(Token = "0x40068B8")]
		[FieldOffset(Offset = "0x48")]
		public int[] AIPropRank3;

		[Token(Token = "0x40068B9")]
		[FieldOffset(Offset = "0x50")]
		public int[] AIPropRank4;

		[Token(Token = "0x40068BA")]
		[FieldOffset(Offset = "0x58")]
		public int[] AIPropNum1;

		[Token(Token = "0x40068BB")]
		[FieldOffset(Offset = "0x60")]
		public int[] AIPropNum2;

		[Token(Token = "0x40068BC")]
		[FieldOffset(Offset = "0x68")]
		public int[] AIPropNum3;

		[Token(Token = "0x40068BD")]
		[FieldOffset(Offset = "0x70")]
		public int[] AIPropNum4;

		[Token(Token = "0x17000F46")]
		public override object UniqueID
		{
			[Token(Token = "0x6005AF0")]
			[Address(RVA = "0x439AA08", Offset = "0x4396A08", VA = "0x439AA08", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005AF1")]
		[Address(RVA = "0x439AA64", Offset = "0x4396A64", VA = "0x439AA64")]
		public AIPropInfoCConfig()
		{
		}
	}
}
