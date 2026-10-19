using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F1A")]
	[Skip]
	public class AIPropInfoBConfig : BaseConfig
	{
		[Token(Token = "0x40068A4")]
		[FieldOffset(Offset = "0x10")]
		public int arnenaLevel;

		[Token(Token = "0x40068A5")]
		[FieldOffset(Offset = "0x18")]
		public int[] AIPropUpgrade1;

		[Token(Token = "0x40068A6")]
		[FieldOffset(Offset = "0x20")]
		public int[] AIPropUpgrade2;

		[Token(Token = "0x40068A7")]
		[FieldOffset(Offset = "0x28")]
		public int[] AIPropUpgrade3;

		[Token(Token = "0x40068A8")]
		[FieldOffset(Offset = "0x30")]
		public int[] AIPropUpgrade4;

		[Token(Token = "0x40068A9")]
		[FieldOffset(Offset = "0x38")]
		public int[] AIPropRank1;

		[Token(Token = "0x40068AA")]
		[FieldOffset(Offset = "0x40")]
		public int[] AIPropRank2;

		[Token(Token = "0x40068AB")]
		[FieldOffset(Offset = "0x48")]
		public int[] AIPropRank3;

		[Token(Token = "0x40068AC")]
		[FieldOffset(Offset = "0x50")]
		public int[] AIPropRank4;

		[Token(Token = "0x40068AD")]
		[FieldOffset(Offset = "0x58")]
		public int[] AIPropNum1;

		[Token(Token = "0x40068AE")]
		[FieldOffset(Offset = "0x60")]
		public int[] AIPropNum2;

		[Token(Token = "0x40068AF")]
		[FieldOffset(Offset = "0x68")]
		public int[] AIPropNum3;

		[Token(Token = "0x40068B0")]
		[FieldOffset(Offset = "0x70")]
		public int[] AIPropNum4;

		[Token(Token = "0x17000F45")]
		public override object UniqueID
		{
			[Token(Token = "0x6005AEE")]
			[Address(RVA = "0x439A9A4", Offset = "0x43969A4", VA = "0x439A9A4", Slot = "4")]
			get
			{
				return arnenaLevel;
			}
		}

		[Token(Token = "0x6005AEF")]
		[Address(RVA = "0x439AA00", Offset = "0x4396A00", VA = "0x439AA00")]
		public AIPropInfoBConfig()
		{
		}
	}
}
