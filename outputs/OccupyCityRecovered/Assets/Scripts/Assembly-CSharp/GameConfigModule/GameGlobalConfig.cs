using Il2CppDummyDll;

namespace GameConfigModule
{
	[Token(Token = "0x2000218")]
	public sealed class GameGlobalConfig
	{
		[Token(Token = "0x4001D39")]
		[FieldOffset(Offset = "0x10")]
		public readonly bool IsEnableCameraScreenAdaptation;

		[Token(Token = "0x4001D3A")]
		[FieldOffset(Offset = "0x11")]
		public readonly bool IsEnableDebug;

		[Token(Token = "0x4001D3B")]
		[FieldOffset(Offset = "0x12")]
		public readonly bool useNewFloatingText;

		[Token(Token = "0x4001D3C")]
		[FieldOffset(Offset = "0x13")]
		public readonly bool OpenUploadDataLogic;

		[Token(Token = "0x4001D3D")]
		[FieldOffset(Offset = "0x14")]
		public readonly bool enableReduceArena12EnemyDifficulty;

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x41966D8", Offset = "0x41926D8", VA = "0x41966D8")]
		public GameGlobalConfig()
		{
		}
	}
}
