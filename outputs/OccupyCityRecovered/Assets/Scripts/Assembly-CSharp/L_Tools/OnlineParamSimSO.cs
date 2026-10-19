using System.Collections.Generic;
using Il2CppDummyDll;

namespace L_Tools
{
	[Token(Token = "0x2000FA0")]
	public class OnlineParamSimSO : DailiScriptObject<OnlineParamSimSO>
	{
		[Token(Token = "0x4006B5B")]
		[FieldOffset(Offset = "0x18")]
		public ABGroupType CurGroup;

		[Token(Token = "0x4006B5C")]
		[FieldOffset(Offset = "0x20")]
		public List<SimOnlineParam> onlineParams;

		[Token(Token = "0x6005D98")]
		[Address(RVA = "0x43BA054", Offset = "0x43B6054", VA = "0x43BA054")]
		public string GetOnlineParam(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x6005D99")]
		[Address(RVA = "0x43BA2C4", Offset = "0x43B62C4", VA = "0x43BA2C4")]
		public OnlineParamSimSO()
		{
		}
	}
}
