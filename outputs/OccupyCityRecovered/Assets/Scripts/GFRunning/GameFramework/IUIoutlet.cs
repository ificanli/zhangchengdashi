using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GameFramework
{
	[Token(Token = "0x20003C1")]
	public interface IUIoutlet
	{
		[Token(Token = "0x1700113F")]
		GameObject MgameObject
		{
			[Token(Token = "0x6005E9F")]
			get;
		}

		[Token(Token = "0x17001140")]
		List<OutletInfo> OutletInfos
		{
			[Token(Token = "0x6005EA0")]
			get;
		}
	}
}
