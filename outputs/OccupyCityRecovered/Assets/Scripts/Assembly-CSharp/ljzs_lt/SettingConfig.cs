using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F3B")]
	[Skip]
	public class SettingConfig : BaseConfig
	{
		[Token(Token = "0x4006973")]
		[FieldOffset(Offset = "0x10")]
		public int AllMusic_PlayWaitTime;

		[Token(Token = "0x17000F66")]
		public override object UniqueID
		{
			[Token(Token = "0x6005B30")]
			[Address(RVA = "0x439B688", Offset = "0x4397688", VA = "0x439B688", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005B31")]
		[Address(RVA = "0x439B6E4", Offset = "0x43976E4", VA = "0x439B6E4")]
		public SettingConfig()
		{
		}
	}
}
