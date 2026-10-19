using System.Collections.Generic;
using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E3C")]
	public class GlobalArchitectureInfo : GlobalInfoBase
	{
		[Token(Token = "0x400630F")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x4006310")]
		[FieldOffset(Offset = "0x20")]
		public string type;

		[Token(Token = "0x4006311")]
		[FieldOffset(Offset = "0x28")]
		public string hp;

		[Token(Token = "0x4006312")]
		[FieldOffset(Offset = "0x30")]
		public string defenceRatio;

		[Token(Token = "0x4006313")]
		[FieldOffset(Offset = "0x38")]
		public string spawnTime;

		[Token(Token = "0x4006314")]
		[FieldOffset(Offset = "0x40")]
		public string prefabPath;

		[Token(Token = "0x4006315")]
		[FieldOffset(Offset = "0x48")]
		public string attack;

		[Token(Token = "0x4006316")]
		[FieldOffset(Offset = "0x50")]
		public string range;

		[Token(Token = "0x4006317")]
		[FieldOffset(Offset = "0x58")]
		public string roleID;

		[Token(Token = "0x4006318")]
		[FieldOffset(Offset = "0x60")]
		public string cardID;

		[Token(Token = "0x600577F")]
		[Address(RVA = "0x4353A6C", Offset = "0x434FA6C", VA = "0x4353A6C")]
		public string GetPath(bool play, int index = 0)
		{
			return null;
		}

		[Token(Token = "0x6005780")]
		[Address(RVA = "0x4353BA4", Offset = "0x434FBA4", VA = "0x4353BA4")]
		public List<string> GetAllPath(bool play)
		{
			return null;
		}

		[Token(Token = "0x6005781")]
		[Address(RVA = "0x4353D48", Offset = "0x434FD48", VA = "0x4353D48")]
		public GlobalArchitectureInfo()
		{
		}
	}
}
