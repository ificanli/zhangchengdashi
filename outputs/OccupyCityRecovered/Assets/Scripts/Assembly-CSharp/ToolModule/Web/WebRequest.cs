using Il2CppDummyDll;
using UnityEngine.Networking;

namespace ToolModule.Web
{
	[Token(Token = "0x20001BD")]
	public class WebRequest
	{
		[Token(Token = "0x4001B2B")]
		public const string METHOD_GET = "GET";

		[Token(Token = "0x4001B2C")]
		public const string METHOD_POST = "POST";

		[Token(Token = "0x4001B2D")]
		public const string METHOD_PATCH = "PATCH";

		[Token(Token = "0x4001B2E")]
		public const string METHOD_DELETE = "DELETE";

		[Token(Token = "0x4001B2F")]
		public const int timeout = 10;

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x407DFC0", Offset = "0x4079FC0", VA = "0x407DFC0")]
		public static UnityWebRequest Create(string url)
		{
			return null;
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x407CD80", Offset = "0x4078D80", VA = "0x407CD80")]
		public static UnityWebRequest Create(string url, string method, string json_data, string token)
		{
			return null;
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x407E0C8", Offset = "0x407A0C8", VA = "0x407E0C8")]
		public static UnityWebRequest CreateRaw(string url, string method, string contentType, byte[] data, string token)
		{
			return null;
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x407E274", Offset = "0x407A274", VA = "0x407E274")]
		public static UnityWebRequest CreateHeader(string url)
		{
			return null;
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x407E27C", Offset = "0x407A27C", VA = "0x407E27C")]
		public static UnityWebRequest CreateTexture(string url)
		{
			return null;
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x407E2FC", Offset = "0x407A2FC", VA = "0x407E2FC")]
		public static UnityWebRequest CreateImageUploadForm(string url, string path, byte[] data, string token)
		{
			return null;
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x407D36C", Offset = "0x407936C", VA = "0x407D36C")]
		public static WebResponse GetResponse(UnityWebRequest request)
		{
			return default;
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x407E584", Offset = "0x407A584", VA = "0x407E584")]
		public static HeadResponse GetHeadResponse(UnityWebRequest request)
		{
			return null;
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x407E714", Offset = "0x407A714", VA = "0x407E714")]
		public WebRequest()
		{
		}
	}
}
