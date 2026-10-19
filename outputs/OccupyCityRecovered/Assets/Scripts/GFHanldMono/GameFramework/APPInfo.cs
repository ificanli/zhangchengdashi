using Il2CppDummyDll;
using UnityEngine;

namespace GameFramework
{
	[Token(Token = "0x200000F")]
	public class APPInfo
	{
		[Token(Token = "0x400002C")]
		private const string WeixinMiniGamePlatform = "WeixinMiniGamePlayer";

		[Token(Token = "0x1700000C")]
		public static EReleasePlatform releasePlatform
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x7068944", Offset = "0x7064944", VA = "0x7068944")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x7068248", Offset = "0x7064248", VA = "0x7068248")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		public static void InitializeApp()
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x7068358", Offset = "0x7064358", VA = "0x7068358")]
		private static void ScriptingDefineSymbols()
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x706894C", Offset = "0x706494C", VA = "0x706894C")]
		public APPInfo()
		{
		}
	}
}
