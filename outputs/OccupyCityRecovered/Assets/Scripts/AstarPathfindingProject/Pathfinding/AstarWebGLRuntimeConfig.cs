using Il2CppDummyDll;

namespace Pathfinding
{
	[Token(Token = "0x2000071")]
	public static class AstarWebGLRuntimeConfig
	{
		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0x0")]
		public static bool IsWebGLBuild;

		[Token(Token = "0x4000292")]
		public const bool EnableWebGLRuntimeReplacement = true;

		[Token(Token = "0x170000E7")]
		public static bool IsRuntimeEnabled
		{
			[Token(Token = "0x600042E")]
			[Address(RVA = "0x44FDACC", Offset = "0x44F9ACC", VA = "0x44FDACC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000E8")]
		public static bool UseWebGLNavigation
		{
			[Token(Token = "0x600042F")]
			[Address(RVA = "0x44FDB50", Offset = "0x44F9B50", VA = "0x44FDB50")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000E9")]
		public static bool DisableAstarRuntime
		{
			[Token(Token = "0x6000430")]
			[Address(RVA = "0x44FDB54", Offset = "0x44F9B54", VA = "0x44FDB54")]
			get
			{
				return default;
			}
		}
	}
}
