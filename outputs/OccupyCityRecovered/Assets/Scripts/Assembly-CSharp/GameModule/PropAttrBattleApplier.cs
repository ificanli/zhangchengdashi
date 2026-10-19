using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000314")]
	public static class PropAttrBattleApplier
	{
		[Token(Token = "0x6000DF9")]
		[Address(RVA = "0x3D67928", Offset = "0x3D63928", VA = "0x3D67928")]
		public static PropAttrSnapshot ResolveBattlePropAttrSnapshot(bool isEnemy)
		{
			return null;
		}

		[Token(Token = "0x6000DFA")]
		[Address(RVA = "0x3D67AD0", Offset = "0x3D63AD0", VA = "0x3D67AD0")]
		public static void ApplyToRole(PropAttrSnapshot snapshot, RolePropertyTemp temp)
		{
		}

		[Token(Token = "0x6000DFB")]
		[Address(RVA = "0x3D67CB0", Offset = "0x3D63CB0", VA = "0x3D67CB0")]
		public static void ApplyToArchitecture(PropAttrSnapshot snapshot, ArchitecturePropertyTemp temp, string archType)
		{
		}

		[Token(Token = "0x6000DFC")]
		[Address(RVA = "0x3D67DA8", Offset = "0x3D63DA8", VA = "0x3D67DA8")]
		public static void ApplyToDefenseAttack(PropAttrSnapshot snapshot, ref int attack)
		{
		}

		[Token(Token = "0x6000DFD")]
		[Address(RVA = "0x3D67E28", Offset = "0x3D63E28", VA = "0x3D67E28")]
		public static void ApplyToMainTowerHp(PropAttrSnapshot snapshot, ref int maxHp, ref int hp)
		{
		}

		[Token(Token = "0x6000DFE")]
		[Address(RVA = "0x3D67EB4", Offset = "0x3D63EB4", VA = "0x3D67EB4")]
		public static void ApplyToMainTowerAttack(PropAttrSnapshot snapshot, ref int damage)
		{
		}
	}
}
