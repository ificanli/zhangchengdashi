using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F39")]
	[Skip]
	public class RuinsConfigConfig : BaseConfig
	{
		[Token(Token = "0x4006961")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x4006962")]
		[FieldOffset(Offset = "0x14")]
		public int weight;

		[Token(Token = "0x4006963")]
		[FieldOffset(Offset = "0x18")]
		public string image;

		[Token(Token = "0x4006964")]
		[FieldOffset(Offset = "0x20")]
		public string image_txt;

		[Token(Token = "0x4006965")]
		[FieldOffset(Offset = "0x28")]
		public string option_txt1;

		[Token(Token = "0x4006966")]
		[FieldOffset(Offset = "0x30")]
		public string option_txt2;

		[Token(Token = "0x4006967")]
		[FieldOffset(Offset = "0x38")]
		public string option_txt3;

		[Token(Token = "0x4006968")]
		[FieldOffset(Offset = "0x40")]
		public string reward1;

		[Token(Token = "0x4006969")]
		[FieldOffset(Offset = "0x48")]
		public string reward2;

		[Token(Token = "0x400696A")]
		[FieldOffset(Offset = "0x50")]
		public string reward3;

		[Token(Token = "0x17000F64")]
		public override object UniqueID
		{
			[Token(Token = "0x6005B2C")]
			[Address(RVA = "0x439B5C0", Offset = "0x43975C0", VA = "0x439B5C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005B2D")]
		[Address(RVA = "0x439B61C", Offset = "0x439761C", VA = "0x439B61C")]
		public RuinsConfigConfig()
		{
		}
	}
}
