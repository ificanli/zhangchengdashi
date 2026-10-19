using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20002B8")]
	public static class WebGLBattlePerformanceConfig
	{
		[Token(Token = "0x40021BA")]
		public const bool IsWebGLBuild = false;

		[Token(Token = "0x40021BB")]
		public const int HeavyUnitCountThreshold = 60;

		[Token(Token = "0x40021BC")]
		public const int HudHeavyUpdateStride = 2;

		[Token(Token = "0x40021BD")]
		public const int AnimationVisibleUpdateStride = 2;

		[Token(Token = "0x40021BE")]
		public const int AnimationInvisibleUpdateStride = 6;

		[Token(Token = "0x40021BF")]
		public const int AnimationInvisibleCullingStride = 3;

		[Token(Token = "0x40021C0")]
		public const float HudViewportPadding = 0.08f;

		[Token(Token = "0x40021C1")]
		public const float ShadowViewportPadding = 0.12f;

		[Token(Token = "0x170000D9")]
		public static bool IsRuntimeEnabled
		{
			[Token(Token = "0x6000C5D")]
			[Address(RVA = "0x3D3AD28", Offset = "0x3D36D28", VA = "0x3D3AD28")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000C5E")]
		[Address(RVA = "0x3D3AD30", Offset = "0x3D36D30", VA = "0x3D3AD30")]
		public static bool IsHeavyCount(int count)
		{
			return default;
		}
	}
}
