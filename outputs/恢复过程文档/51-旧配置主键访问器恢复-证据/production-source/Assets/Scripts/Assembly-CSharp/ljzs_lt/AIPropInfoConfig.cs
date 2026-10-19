using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F1C")]
	[Skip]
	public class AIPropInfoConfig : BaseConfig
	{
		[Token(Token = "0x40068BE")]
		[FieldOffset(Offset = "0x10")]
		public int arnenaLevel;

		[Token(Token = "0x40068BF")]
		[FieldOffset(Offset = "0x18")]
		public int[] AIPropUpgrade1;

		[Token(Token = "0x40068C0")]
		[FieldOffset(Offset = "0x20")]
		public int[] AIPropUpgrade2;

		[Token(Token = "0x40068C1")]
		[FieldOffset(Offset = "0x28")]
		public int[] AIPropUpgrade3;

		[Token(Token = "0x40068C2")]
		[FieldOffset(Offset = "0x30")]
		public int[] AIPropUpgrade4;

		[Token(Token = "0x40068C3")]
		[FieldOffset(Offset = "0x38")]
		public int[] AIPropRank1;

		[Token(Token = "0x40068C4")]
		[FieldOffset(Offset = "0x40")]
		public int[] AIPropRank2;

		[Token(Token = "0x40068C5")]
		[FieldOffset(Offset = "0x48")]
		public int[] AIPropRank3;

		[Token(Token = "0x40068C6")]
		[FieldOffset(Offset = "0x50")]
		public int[] AIPropRank4;

		[Token(Token = "0x40068C7")]
		[FieldOffset(Offset = "0x58")]
		public int[] AIPropNum1;

		[Token(Token = "0x40068C8")]
		[FieldOffset(Offset = "0x60")]
		public int[] AIPropNum2;

		[Token(Token = "0x40068C9")]
		[FieldOffset(Offset = "0x68")]
		public int[] AIPropNum3;

		[Token(Token = "0x40068CA")]
		[FieldOffset(Offset = "0x70")]
		public int[] AIPropNum4;

		[Token(Token = "0x17000F47")]
		public override object UniqueID
		{
			[Token(Token = "0x6005AF2")]
			[Address(RVA = "0x439AA6C", Offset = "0x4396A6C", VA = "0x439AA6C", Slot = "4")]
			get
			{
				return arnenaLevel;
			}
		}

		[Token(Token = "0x6005AF3")]
		[Address(RVA = "0x439AAC8", Offset = "0x4396AC8", VA = "0x439AAC8")]
		public AIPropInfoConfig()
		{
		}
	}
}
