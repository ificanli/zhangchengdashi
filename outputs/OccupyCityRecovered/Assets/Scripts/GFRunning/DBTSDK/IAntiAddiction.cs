using Il2CppDummyDll;
using UnityEngine;

namespace DBTSDK
{
	[Token(Token = "0x20001F6")]
	public interface IAntiAddiction
	{
		[Token(Token = "0x60019E2")]
		void InitAntiAddiction(Transform parent, Rect UIrect, bool isTop, float OffsetY);

		[Token(Token = "0x60019E3")]
		void ShowAntiAddiction(string ContentCorlor = "", string txtContent = "");

		[Token(Token = "0x60019E4")]
		void CloseAntiAddiction();
	}
}
