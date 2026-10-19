using Il2CppDummyDll;
using UnityEngine;

namespace L_Tools
{
	[Token(Token = "0x2000F98")]
	public class ServerMgr : MonoBehaviour
	{
		[Token(Token = "0x4006B3E")]
		[FieldOffset(Offset = "0x20")]
		public PlatformEnum platform;

		[Token(Token = "0x4006B3F")]
		[FieldOffset(Offset = "0x0")]
		public static PlatformEnum _platform;

		[Token(Token = "0x6005D66")]
		[Address(RVA = "0x43B9048", Offset = "0x43B5048", VA = "0x43B9048")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005D67")]
		[Address(RVA = "0x43B6FC0", Offset = "0x43B2FC0", VA = "0x43B6FC0")]
		public static string GetFullURL(string url)
		{
			return null;
		}

		[Token(Token = "0x6005D68")]
		[Address(RVA = "0x43B9098", Offset = "0x43B5098", VA = "0x43B9098")]
		public ServerMgr()
		{
		}
	}
}
