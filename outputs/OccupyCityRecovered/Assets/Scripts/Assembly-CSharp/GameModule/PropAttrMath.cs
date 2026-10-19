using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000313")]
	internal static class PropAttrMath
	{
		[Token(Token = "0x6000DF5")]
		[Address(RVA = "0x3D67780", Offset = "0x3D63780", VA = "0x3D67780")]
		public static void ApplyPercentToInt(ref int value, float percent)
		{
		}

		[Token(Token = "0x6000DF6")]
		[Address(RVA = "0x3D67890", Offset = "0x3D63890", VA = "0x3D67890")]
		public static void ApplyPercentToFloat(ref float value, float percent)
		{
		}

		[Token(Token = "0x6000DF7")]
		[Address(RVA = "0x3D678BC", Offset = "0x3D638BC", VA = "0x3D678BC")]
		public static void ApplySpawnEfficiencyToSpawnTime(ref float spawnTimeMs, float percent)
		{
		}

		[Token(Token = "0x6000DF8")]
		[Address(RVA = "0x3D678F4", Offset = "0x3D638F4", VA = "0x3D678F4")]
		public static void ApplyAttackSpeedToAtkOffset(ref float atkOffset, float percent)
		{
		}
	}
}
