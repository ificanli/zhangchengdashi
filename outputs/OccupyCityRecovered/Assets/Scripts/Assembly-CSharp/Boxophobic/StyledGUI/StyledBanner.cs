using Il2CppDummyDll;
using UnityEngine;

namespace Boxophobic.StyledGUI
{
	[Token(Token = "0x2000DED")]
	public class StyledBanner : PropertyAttribute
	{
		[Token(Token = "0x4006192")]
		[FieldOffset(Offset = "0x10")]
		public float colorR;

		[Token(Token = "0x4006193")]
		[FieldOffset(Offset = "0x14")]
		public float colorG;

		[Token(Token = "0x4006194")]
		[FieldOffset(Offset = "0x18")]
		public float colorB;

		[Token(Token = "0x4006195")]
		[FieldOffset(Offset = "0x20")]
		public string title;

		[Token(Token = "0x4006196")]
		[FieldOffset(Offset = "0x28")]
		public string helpURL;

		[Token(Token = "0x600564C")]
		[Address(RVA = "0x433BE38", Offset = "0x4337E38", VA = "0x433BE38")]
		public StyledBanner(string title)
		{
		}

		[Token(Token = "0x600564D")]
		[Address(RVA = "0x433BEA0", Offset = "0x4337EA0", VA = "0x433BEA0")]
		public StyledBanner(float colorR, float colorG, float colorB, string title)
		{
		}

		[Token(Token = "0x600564E")]
		[Address(RVA = "0x433BF24", Offset = "0x4337F24", VA = "0x433BF24")]
		public StyledBanner(string title, string helpURL)
		{
		}

		[Token(Token = "0x600564F")]
		[Address(RVA = "0x433BF58", Offset = "0x4337F58", VA = "0x433BF58")]
		public StyledBanner(float colorR, float colorG, float colorB, string title, string helpURL)
		{
		}

		[Token(Token = "0x6005650")]
		[Address(RVA = "0x433BFA8", Offset = "0x4337FA8", VA = "0x433BFA8")]
		public StyledBanner(string title, string subtitle, string helpURL)
		{
		}

		[Token(Token = "0x6005651")]
		[Address(RVA = "0x433BFDC", Offset = "0x4337FDC", VA = "0x433BFDC")]
		public StyledBanner(float colorR, float colorG, float colorB, string title, string subtitle, string helpURL)
		{
		}
	}
}
