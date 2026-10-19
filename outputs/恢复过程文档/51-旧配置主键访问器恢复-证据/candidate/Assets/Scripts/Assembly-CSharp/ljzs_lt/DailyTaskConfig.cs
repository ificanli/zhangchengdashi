using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F28")]
	[Skip]
	public class DailyTaskConfig : BaseConfig
	{
		[Token(Token = "0x4006906")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x4006907")]
		[FieldOffset(Offset = "0x14")]
		public int taskType;

		[Token(Token = "0x4006908")]
		[FieldOffset(Offset = "0x18")]
		public string des;

		[Token(Token = "0x4006909")]
		[FieldOffset(Offset = "0x20")]
		public int parameter_progress;

		[Token(Token = "0x400690A")]
		[FieldOffset(Offset = "0x24")]
		public int parameter_nomal;

		[Token(Token = "0x400690B")]
		[FieldOffset(Offset = "0x28")]
		public int itemType;

		[Token(Token = "0x400690C")]
		[FieldOffset(Offset = "0x2C")]
		public int item;

		[Token(Token = "0x400690D")]
		[FieldOffset(Offset = "0x30")]
		public int count;

		[Token(Token = "0x400690E")]
		[FieldOffset(Offset = "0x34")]
		public int jump;

		[Token(Token = "0x17000F53")]
		public override object UniqueID
		{
			[Token(Token = "0x6005B0A")]
			[Address(RVA = "0x439AF1C", Offset = "0x4396F1C", VA = "0x439AF1C", Slot = "4")]
			get
			{
				return id;
			}
		}

		[Token(Token = "0x6005B0B")]
		[Address(RVA = "0x439AF78", Offset = "0x4396F78", VA = "0x439AF78")]
		public DailyTaskConfig()
		{
		}
	}
}
