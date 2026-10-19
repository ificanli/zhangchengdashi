using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F37")]
	[Skip]
	public class PropUpgradeInfoConfig : BaseConfig
	{
		[Token(Token = "0x4006954")]
		[FieldOffset(Offset = "0x10")]
		public int Level;

		[Token(Token = "0x4006955")]
		[FieldOffset(Offset = "0x14")]
		public int NeedRank;

		[Token(Token = "0x4006956")]
		[FieldOffset(Offset = "0x18")]
		public int[] CrystalCost;

		[Token(Token = "0x4006957")]
		[FieldOffset(Offset = "0x20")]
		public float UpgradeAttrCurve;

		[Token(Token = "0x17000F62")]
		public override object UniqueID
		{
			[Token(Token = "0x6005B28")]
			[Address(RVA = "0x439B4F8", Offset = "0x43974F8", VA = "0x439B4F8", Slot = "4")]
			get
			{
				return Level;
			}
		}

		[Token(Token = "0x6005B29")]
		[Address(RVA = "0x439B554", Offset = "0x4397554", VA = "0x439B554")]
		public PropUpgradeInfoConfig()
		{
		}
	}
}
