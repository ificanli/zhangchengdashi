using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F24")]
	[Skip]
	public class CompareShenqiInfoConfig : BaseConfig
	{
		[Token(Token = "0x40068E7")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x40068E8")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x40068E9")]
		[FieldOffset(Offset = "0x20")]
		public int Rare;

		[Token(Token = "0x40068EA")]
		[FieldOffset(Offset = "0x28")]
		public string NameIconPath;

		[Token(Token = "0x17000F4F")]
		public override object UniqueID
		{
			[Token(Token = "0x6005B02")]
			[Address(RVA = "0x439AD8C", Offset = "0x4396D8C", VA = "0x439AD8C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005B03")]
		[Address(RVA = "0x439ADE8", Offset = "0x4396DE8", VA = "0x439ADE8")]
		public CompareShenqiInfoConfig()
		{
		}
	}
}
