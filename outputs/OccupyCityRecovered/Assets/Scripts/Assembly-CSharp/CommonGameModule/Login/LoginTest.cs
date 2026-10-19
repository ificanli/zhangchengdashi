using Il2CppDummyDll;
using UnityEngine;

namespace CommonGameModule.Login
{
	[Token(Token = "0x2000FE8")]
	public class LoginTest : MonoBehaviour
	{
		[Token(Token = "0x4006C76")]
		[FieldOffset(Offset = "0x20")]
		[Header("测试账号ID")]
		public string DeviceId;

		[Token(Token = "0x4006C77")]
		[FieldOffset(Offset = "0x28")]
		[Header("测试账号类型")]
		public string userType;

		[Token(Token = "0x4006C78")]
		[FieldOffset(Offset = "0x0")]
		private static LoginTest _Ins;

		[Token(Token = "0x17000FB7")]
		public static LoginTest Ins
		{
			[Token(Token = "0x6005F44")]
			[Address(RVA = "0x44049B0", Offset = "0x44009B0", VA = "0x44049B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005F45")]
		[Address(RVA = "0x44049F8", Offset = "0x44009F8", VA = "0x44049F8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005F46")]
		[Address(RVA = "0x4404A78", Offset = "0x4400A78", VA = "0x4404A78")]
		public LoginTest()
		{
		}
	}
}
