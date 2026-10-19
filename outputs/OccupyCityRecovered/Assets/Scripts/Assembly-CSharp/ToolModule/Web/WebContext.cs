using System.Net;
using Il2CppDummyDll;

namespace ToolModule.Web
{
	[Token(Token = "0x20001BC")]
	public class WebContext
	{
		[Token(Token = "0x4001B26")]
		[FieldOffset(Offset = "0x10")]
		public HttpListenerContext http;

		[Token(Token = "0x4001B27")]
		[FieldOffset(Offset = "0x18")]
		public string method;

		[Token(Token = "0x4001B28")]
		[FieldOffset(Offset = "0x20")]
		public string token;

		[Token(Token = "0x4001B29")]
		[FieldOffset(Offset = "0x28")]
		public string path;

		[Token(Token = "0x4001B2A")]
		[FieldOffset(Offset = "0x30")]
		public string data;

		[Token(Token = "0x600070E")]
		public void SendResponse<T>(T value)
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x407D4E8", Offset = "0x40794E8", VA = "0x407D4E8")]
		public void SendResponse(ulong value)
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x407D568", Offset = "0x4079568", VA = "0x407D568")]
		public void SendResponse(int value)
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x407D59C", Offset = "0x407959C", VA = "0x407D59C")]
		public void SendResponse(bool value)
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x407D51C", Offset = "0x407951C", VA = "0x407D51C")]
		public void SendResponse(string value)
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x407D784", Offset = "0x4079784", VA = "0x407D784")]
		public void SendError(string value)
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x407D7D0", Offset = "0x40797D0", VA = "0x407D7D0")]
		public void SendResponse()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x407D614", Offset = "0x4079614", VA = "0x407D614")]
		public void SendResponse(byte[] bytes, int code)
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x407D8D0", Offset = "0x40798D0", VA = "0x407D8D0")]
		private void WriteHeader()
		{
		}

		[Token(Token = "0x6000717")]
		public T GetData<T>()
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WebContext.GetData RVA= Token=0x6000717");
}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x407DA04", Offset = "0x4079A04", VA = "0x407DA04")]
		public ulong GetInt64()
		{
			return default;
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x407DA30", Offset = "0x4079A30", VA = "0x407DA30")]
		public int GetInt()
		{
			return default;
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x407DA5C", Offset = "0x4079A5C", VA = "0x407DA5C")]
		public bool GetBool()
		{
			return default;
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x407DADC", Offset = "0x4079ADC", VA = "0x407DADC")]
		public ulong GetClientID()
		{
			return default;
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x407DB08", Offset = "0x4079B08", VA = "0x407DB08")]
		public string GetIP()
		{
			return null;
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x407DB44", Offset = "0x4079B44", VA = "0x407DB44")]
		public string GetKey()
		{
			return null;
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x407DB4C", Offset = "0x4079B4C", VA = "0x407DB4C")]
		public bool IsKeyValid(string key)
		{
			return default;
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x407DB58", Offset = "0x4079B58", VA = "0x407DB58")]
		public string GetQuery(string key)
		{
			return null;
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x407DC7C", Offset = "0x4079C7C", VA = "0x407DC7C")]
		public void Close()
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x407DD44", Offset = "0x4079D44", VA = "0x407DD44")]
		public static WebContext Create(HttpListenerContext http)
		{
			return null;
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x407DFB8", Offset = "0x4079FB8", VA = "0x407DFB8")]
		public WebContext()
		{
		}
	}
}
