using Il2CppDummyDll;

namespace L_Tools
{
	[Token(Token = "0x2000F8F")]
	public class ServerConfig
	{
		[Token(Token = "0x4006B1E")]
		[FieldOffset(Offset = "0x0")]
		public static IpConfig APP_NoServer;

		[Token(Token = "0x4006B1F")]
		[FieldOffset(Offset = "0x8")]
		public static IpConfig APP_Test;

		[Token(Token = "0x4006B20")]
		[FieldOffset(Offset = "0x10")]
		public static IpConfig APP_MailTest;

		[Token(Token = "0x4006B21")]
		[FieldOffset(Offset = "0x18")]
		public static IpConfig APP_PIANOMailTest;

		[Token(Token = "0x6005D4F")]
		[Address(RVA = "0x43B890C", Offset = "0x43B490C", VA = "0x43B890C")]
		public static IpConfig GetIpConfig(PlatformEnum platform)
		{
			return null;
		}

		[Token(Token = "0x6005D50")]
		[Address(RVA = "0x43B8AD4", Offset = "0x43B4AD4", VA = "0x43B8AD4")]
		public ServerConfig()
		{
		}
	}
}
