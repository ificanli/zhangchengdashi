using Il2CppDummyDll;
using UnityEngine;

namespace YooAsset
{
	[Token(Token = "0x2000077")]
	public interface IResCallBackInfo
	{
		[Token(Token = "0x17000048")]
		Object mainObject
		{
			[Token(Token = "0x6000582")]
			get;
			[Token(Token = "0x6000583")]
			set;
		}

		[Token(Token = "0x6000584")]
		T GetArg<T>(int g_0097mKyÂ);

		[Token(Token = "0x6000585")]
		GameObject Instantiate(bool z_0094X_00A2_009C_0083 = true);

		[Token(Token = "0x6000586")]
		GameObject Instantiate(string _00B4M_0088_005B_0087_0093, bool z_0094X_00A2_009C_0083 = true);
	}
}
