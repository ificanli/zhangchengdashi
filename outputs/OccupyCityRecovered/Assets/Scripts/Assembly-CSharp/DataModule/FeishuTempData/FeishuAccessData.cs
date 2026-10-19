using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using ToolModule.Web;

namespace DataModule.FeishuTempData
{
	[Token(Token = "0x2000EF6")]
	public class FeishuAccessData
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000EF7")]
		[CompilerGenerated]
		private struct _003CGetAccessToken_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x40067E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40067E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

			[Token(Token = "0x40067E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string appId;

			[Token(Token = "0x40067E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string appSecret;

			[Token(Token = "0x40067E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<WebResponse> _003C_003Eu__1;

			[Token(Token = "0x6005A39")]
			[Address(RVA = "0x438FD24", Offset = "0x438BD24", VA = "0x438FD24", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005A3A")]
			[Address(RVA = "0x439009C", Offset = "0x438C09C", VA = "0x439009C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40067DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string code;

		[Token(Token = "0x40067E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string msg;

		[Token(Token = "0x40067E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string tenant_access_token;

		[Token(Token = "0x40067E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int expire;

		[Token(Token = "0x40067E3")]
		private const string url = "https://open.feishu.cn/open-apis/auth/v3/tenant_access_token/internal";

		[Token(Token = "0x6005A37")]
		[Address(RVA = "0x438FC30", Offset = "0x438BC30", VA = "0x438FC30")]
		[AsyncStateMachine(typeof(_003CGetAccessToken_003Ed__5))]
		public static Task<string> GetAccessToken(string appId = "cli_a46f4bff99391013", string appSecret = "pw3dKA3OCM6UxMbLNRS4edkdpoOaEgOV")
		{
			return null;
		}

		[Token(Token = "0x6005A38")]
		[Address(RVA = "0x438FD1C", Offset = "0x438BD1C", VA = "0x438FD1C")]
		public FeishuAccessData()
		{
		}
	}
}
