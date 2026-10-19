using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace L_Tools
{
	[Serializable]
	[Token(Token = "0x2000FA2")]
	public class SimOnlineParam
	{
		[Token(Token = "0x4006B5E")]
		[FieldOffset(Offset = "0x10")]
		public string Description;

		[Token(Token = "0x4006B5F")]
		[FieldOffset(Offset = "0x18")]
		public string key;

		[Token(Token = "0x4006B60")]
		[FieldOffset(Offset = "0x20")]
		public List<OnlineParamData> onlineParams;

		[Token(Token = "0x6005D9C")]
		[Address(RVA = "0x43BA1EC", Offset = "0x43B61EC", VA = "0x43BA1EC")]
		public OnlineParamData GetOnlineParamData(ABGroupType abGroup)
		{
			return null;
		}

		[Token(Token = "0x6005D9D")]
		[Address(RVA = "0x43BA360", Offset = "0x43B6360", VA = "0x43BA360")]
		public SimOnlineParam()
		{
		}
	}
}
