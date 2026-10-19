using System.Collections.Generic;
using Il2CppDummyDll;

namespace BadgeGraph
{
	[Token(Token = "0x2000E07")]
	public class BadgeGraphService
	{
		[Token(Token = "0x40061E7")]
		[FieldOffset(Offset = "0x0")]
		private static BadgeNode s_RootNode;

		[Token(Token = "0x40061E8")]
		[FieldOffset(Offset = "0x8")]
		private static char s_SplitSymbol;

		[Token(Token = "0x40061E9")]
		[FieldOffset(Offset = "0x10")]
		private static Dictionary<string, string> s_PathMap;

		[Token(Token = "0x6005694")]
		[Address(RVA = "0x433E8E0", Offset = "0x433A8E0", VA = "0x433E8E0")]
		public static void Initialize(BadgeGraphScriptable scriptable)
		{
		}

		[Token(Token = "0x6005695")]
		[Address(RVA = "0x433E914", Offset = "0x433A914", VA = "0x433E914")]
		public static void Initialize(string rootName, char splitSymbol, List<string> pathList)
		{
		}

		[Token(Token = "0x6005696")]
		[Address(RVA = "0x433D788", Offset = "0x4339788", VA = "0x433D788")]
		public static void SetBadgeNodeCallback(string nodeName, bool subscribe, OnPointNumberChanged callback, bool invoke = false)
		{
		}

		[Token(Token = "0x6005697")]
		[Address(RVA = "0x433F040", Offset = "0x433B040", VA = "0x433F040")]
		public static void InvokeNode(string nodeName, int number)
		{
		}

		[Token(Token = "0x6005698")]
		[Address(RVA = "0x433D968", Offset = "0x4339968", VA = "0x433D968")]
		public static int GetNodeNumber(string nodeName)
		{
			return default;
		}

		[Token(Token = "0x6005699")]
		[Address(RVA = "0x433EDA4", Offset = "0x433ADA4", VA = "0x433EDA4")]
		private static void GetNodePath(string nodeName, out string[] nodes)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED BadgeGraphService.GetNodePath RVA=0x433EDA4 Token=0x6005699");
}

		[Token(Token = "0x600569A")]
		[Address(RVA = "0x433F1E8", Offset = "0x433B1E8", VA = "0x433F1E8")]
		public BadgeGraphService()
		{
		}
	}
}
