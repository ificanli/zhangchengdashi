using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E48")]
	public class GlobalRoleInfo : GlobalInfoBase
	{
		[Token(Token = "0x4006361")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x4006362")]
		[FieldOffset(Offset = "0x20")]
		public string hp;

		[Token(Token = "0x4006363")]
		[FieldOffset(Offset = "0x28")]
		public string attack;

		[Token(Token = "0x4006364")]
		[FieldOffset(Offset = "0x30")]
		public string atkRange;

		[Token(Token = "0x4006365")]
		[FieldOffset(Offset = "0x38")]
		public string moveSpeed;

		[Token(Token = "0x4006366")]
		[FieldOffset(Offset = "0x40")]
		public string atkOffset;

		[Token(Token = "0x4006367")]
		[FieldOffset(Offset = "0x48")]
		public string attackDamageDelay;

		[Token(Token = "0x4006368")]
		[FieldOffset(Offset = "0x50")]
		public string atkType;

		[Token(Token = "0x4006369")]
		[FieldOffset(Offset = "0x58")]
		public string roleType;

		[Token(Token = "0x400636A")]
		[FieldOffset(Offset = "0x60")]
		public string showModelPath;

		[Token(Token = "0x400636B")]
		[FieldOffset(Offset = "0x68")]
		public string showModelCofig;

		[Token(Token = "0x400636C")]
		[FieldOffset(Offset = "0x70")]
		public string prefabPath;

		[Token(Token = "0x400636D")]
		[FieldOffset(Offset = "0x78")]
		public string attackAudioClipPath;

		[Token(Token = "0x400636E")]
		[FieldOffset(Offset = "0x80")]
		public string hitAudioClipPath;

		[Token(Token = "0x400636F")]
		[FieldOffset(Offset = "0x88")]
		public string unitsCountLimit;

		[Token(Token = "0x4006370")]
		[FieldOffset(Offset = "0x90")]
		public string gamePlayBTestAtkAniSpeed;

		[Token(Token = "0x4006371")]
		[FieldOffset(Offset = "0x98")]
		public string roleRunBornSpeed;

		[Token(Token = "0x4006372")]
		[FieldOffset(Offset = "0xA0")]
		public string roleRunAnimationBornSpeed;

		[Token(Token = "0x60057BC")]
		[Address(RVA = "0x4357BC8", Offset = "0x4353BC8", VA = "0x4357BC8")]
		public string GetPrefabPath(int enemy)
		{
			return null;
		}

		[Token(Token = "0x60057BD")]
		[Address(RVA = "0x4357C60", Offset = "0x4353C60", VA = "0x4357C60")]
		public GlobalRoleInfo()
		{
		}
	}
}
