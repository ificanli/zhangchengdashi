using GameModule;
using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E8C")]
	public class ArchitecturePropertyTemp : BasePropertyTemp
	{
		[Token(Token = "0x4006568")]
		[FieldOffset(Offset = "0x20")]
		public string type;

		[Token(Token = "0x4006569")]
		[FieldOffset(Offset = "0x28")]
		public float spawnTime;

		[Token(Token = "0x400656A")]
		[FieldOffset(Offset = "0x2C")]
		public int attack;

		[Token(Token = "0x400656B")]
		[FieldOffset(Offset = "0x30")]
		public float range;

		[Token(Token = "0x400656C")]
		[FieldOffset(Offset = "0x38")]
		public string roleID;

		[Token(Token = "0x400656D")]
		[FieldOffset(Offset = "0x40")]
		public float defenceRatio;

		[Token(Token = "0x400656E")]
		[FieldOffset(Offset = "0x48")]
		public string cardID;

		[Token(Token = "0x400656F")]
		[FieldOffset(Offset = "0x50")]
		public float missObb;

		[Token(Token = "0x4006570")]
		[FieldOffset(Offset = "0x54")]
		public float critObb;

		[Token(Token = "0x4006571")]
		[FieldOffset(Offset = "0x58")]
		public float vampireObb;

		[Token(Token = "0x4006572")]
		[FieldOffset(Offset = "0x5C")]
		public float damageReduceObb;

		[Token(Token = "0x60058B5")]
		[Address(RVA = "0x4364A88", Offset = "0x4360A88", VA = "0x4364A88")]
		public ArchitecturePropertyTemp(GlobalArchitectureInfo info, int cardLevel, RareLevel rareLevel)
		{
		}
	}
}
