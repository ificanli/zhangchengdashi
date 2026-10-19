using System.Collections.Generic;
using Il2CppDummyDll;

namespace L_Tools
{
	[Token(Token = "0x2000F9F")]
	public class OnlineParamControl : Singleton<OnlineParamControl>
	{
		[Token(Token = "0x4006B59")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, string> _onlineParamCache;

		[Token(Token = "0x4006B5A")]
		[FieldOffset(Offset = "0x0")]
		private static bool UseBuildinData;

		[Token(Token = "0x6005D95")]
		[Address(RVA = "0x43B9DE4", Offset = "0x43B5DE4", VA = "0x43B9DE4")]
		public static void SwitchOnlineParamSim(bool isOpen)
		{
		}

		[Token(Token = "0x6005D96")]
		[Address(RVA = "0x43B9E68", Offset = "0x43B5E68", VA = "0x43B9E68")]
		public string GetOnlineParam(string key, string defaultValue = "")
		{
			return null;
		}

		[Token(Token = "0x6005D97")]
		[Address(RVA = "0x43BA154", Offset = "0x43B6154", VA = "0x43BA154")]
		public OnlineParamControl()
		{
		}
	}
}
