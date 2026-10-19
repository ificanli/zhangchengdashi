using GameModule;
using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E8E")]
	public class RolePropertyTemp : BasePropertyTemp
	{
		[Token(Token = "0x4006576")]
		[FieldOffset(Offset = "0x20")]
		public int attack;

		[Token(Token = "0x4006577")]
		[FieldOffset(Offset = "0x24")]
		public float atkRange;

		[Token(Token = "0x4006578")]
		[FieldOffset(Offset = "0x28")]
		public float moveSpeed;

		[Token(Token = "0x4006579")]
		[FieldOffset(Offset = "0x2C")]
		public float atkOffset;

		[Token(Token = "0x400657A")]
		[FieldOffset(Offset = "0x30")]
		public AtkType atkType;

		[Token(Token = "0x400657B")]
		[FieldOffset(Offset = "0x38")]
		public string roleType;

		[Token(Token = "0x400657C")]
		[FieldOffset(Offset = "0x40")]
		public float missObb;

		[Token(Token = "0x400657D")]
		[FieldOffset(Offset = "0x44")]
		public float critObb;

		[Token(Token = "0x400657E")]
		[FieldOffset(Offset = "0x48")]
		public float vampireObb;

		[Token(Token = "0x400657F")]
		[FieldOffset(Offset = "0x4C")]
		public float damageReduceObb;

		[Token(Token = "0x4006580")]
		[FieldOffset(Offset = "0x50")]
		public RareLevel rareLevel;

		[Token(Token = "0x4006581")]
		[FieldOffset(Offset = "0x58")]
		public string attackAudioClipPath;

		[Token(Token = "0x4006582")]
		[FieldOffset(Offset = "0x60")]
		public string hitAudioClipPath;

		[Token(Token = "0x60058B7")]
		[Address(RVA = "0x4364E4C", Offset = "0x4360E4C", VA = "0x4364E4C")]
		public RolePropertyTemp(GlobalRoleInfo info, int cardLevel, RareLevel rareLevel)
		{
		}
	}
}
