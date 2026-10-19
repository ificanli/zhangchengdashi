using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F41")]
	[Skip]
	public class WorldCupdailyTaskConfig : BaseConfig
	{
		[Token(Token = "0x4006996")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x4006997")]
		[FieldOffset(Offset = "0x14")]
		public int taskType;

		[Token(Token = "0x4006998")]
		[FieldOffset(Offset = "0x18")]
		public string des;

		[Token(Token = "0x4006999")]
		[FieldOffset(Offset = "0x20")]
		public int parameter_progress;

		[Token(Token = "0x400699A")]
		[FieldOffset(Offset = "0x24")]
		public int parameter_nomal;

		[Token(Token = "0x400699B")]
		[FieldOffset(Offset = "0x28")]
		public int itemType;

		[Token(Token = "0x400699C")]
		[FieldOffset(Offset = "0x2C")]
		public int item;

		[Token(Token = "0x400699D")]
		[FieldOffset(Offset = "0x30")]
		public int count;

		[Token(Token = "0x400699E")]
		[FieldOffset(Offset = "0x34")]
		public int jump;

		[Token(Token = "0x17000F6C")]
		public override object UniqueID
		{
			[Token(Token = "0x6005B3C")]
			[Address(RVA = "0x439B8E0", Offset = "0x43978E0", VA = "0x439B8E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005B3D")]
		[Address(RVA = "0x439B93C", Offset = "0x439793C", VA = "0x439B93C")]
		public WorldCupdailyTaskConfig()
		{
		}
	}
}
