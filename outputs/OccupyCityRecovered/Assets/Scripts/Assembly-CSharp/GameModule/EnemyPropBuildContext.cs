using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20002F9")]
	public struct EnemyPropBuildContext
	{
		[Token(Token = "0x40022DF")]
		[FieldOffset(Offset = "0x0")]
		public int equipRareTarget;

		[Token(Token = "0x40022E0")]
		[FieldOffset(Offset = "0x4")]
		public bool requireLegendaryPool;

		[Token(Token = "0x170000DE")]
		public static EnemyPropBuildContext Default
		{
			[Token(Token = "0x6000D3D")]
			[Address(RVA = "0x3D58774", Offset = "0x3D54774", VA = "0x3D58774")]
			get
			{
				return default;
			}
		}
	}
}
