using System;
using Il2CppDummyDll;

namespace L_Tools
{
	[Token(Token = "0x2000F81")]
	public class ADHookCenter
	{
		[Token(Token = "0x4006ABF")]
		[FieldOffset(Offset = "0x0")]
		private static float lastTriggerTime;

		[Token(Token = "0x4006AC0")]
		[FieldOffset(Offset = "0x4")]
		private static float lastVideoButtonTriigerTime;

		[Token(Token = "0x4006AC1")]
		[FieldOffset(Offset = "0x8")]
		private static bool lastVideoButtonSuccess;

		[Token(Token = "0x4006AC2")]
		[FieldOffset(Offset = "0x10")]
		private static Action<bool> Tempcallback;

		[Token(Token = "0x4006AC3")]
		[FieldOffset(Offset = "0x18")]
		private static bool init;

		[Token(Token = "0x6005CF4")]
		[Address(RVA = "0x43B4A64", Offset = "0x43B0A64", VA = "0x43B4A64")]
		public static void ShowInterstitial()
		{
		}

		[Token(Token = "0x6005CF5")]
		[Address(RVA = "0x43B4CC4", Offset = "0x43B0CC4", VA = "0x43B4CC4")]
		public static void GameLogic_TryPlayVideo(Action<bool> callback)
		{
		}

		[Token(Token = "0x6005CF6")]
		[Address(RVA = "0x43B4DCC", Offset = "0x43B0DCC", VA = "0x43B4DCC")]
		public static void LTVideoButton_TryPlayVideo(bool isSuccess, float clickTime)
		{
		}

		[Token(Token = "0x6005CF7")]
		[Address(RVA = "0x43B4F30", Offset = "0x43B0F30", VA = "0x43B4F30")]
		public ADHookCenter()
		{
		}
	}
}
