using Il2CppDummyDll;

namespace GameFramework.Net.Http
{
	[Token(Token = "0x2000469")]
	public class RequestForcedBind : IRequesData
	{
		[Token(Token = "0x4001E76")]
		[FieldOffset(Offset = "0x10")]
		public string userId;

		[Token(Token = "0x4001E77")]
		[FieldOffset(Offset = "0x18")]
		public string guestUserId;

		[Token(Token = "0x6006BBC")]
		[Address(RVA = "0x7285F30", Offset = "0x7281F30", VA = "0x7285F30")]
		public RequestForcedBind()
		{
		}
	}
}
