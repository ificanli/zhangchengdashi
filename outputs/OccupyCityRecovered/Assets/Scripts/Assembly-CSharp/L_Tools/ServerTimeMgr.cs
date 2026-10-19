using System;
using GameFramework;
using Il2CppDummyDll;

namespace L_Tools
{
	[Token(Token = "0x2000F99")]
	[ControlRegister(1)]
	public class ServerTimeMgr : RichControlBase<ServerTimeMgr>, IControl
	{
		[Token(Token = "0x4006B40")]
		[FieldOffset(Offset = "0x0")]
		private static bool UpdateFinish;

		[Token(Token = "0x4006B41")]
		[FieldOffset(Offset = "0x8")]
		private static long lastServerTime;

		[Token(Token = "0x4006B42")]
		[FieldOffset(Offset = "0x10")]
		private static long lastGameTime;

		[Token(Token = "0x4006B43")]
		[FieldOffset(Offset = "0x18")]
		private static float WebglPassTime;

		[Token(Token = "0x4006B44")]
		[FieldOffset(Offset = "0x30")]
		public DateTime dateTime;

		[Token(Token = "0x4006B45")]
		[FieldOffset(Offset = "0x38")]
		private float CheckTime;

		[Token(Token = "0x4006B46")]
		[FieldOffset(Offset = "0x3C")]
		private float checkTimer;

		[Token(Token = "0x4006B47")]
		[FieldOffset(Offset = "0x40")]
		private int updateID;

		[Token(Token = "0x4006B48")]
		[FieldOffset(Offset = "0x44")]
		private float UpdateNowInterval;

		[Token(Token = "0x4006B49")]
		[FieldOffset(Offset = "0x48")]
		private float UpdateNowTimer;

		[Token(Token = "0x4006B4A")]
		[FieldOffset(Offset = "0x1C")]
		private static int HourOffset;

		[Token(Token = "0x17000F9B")]
		public static bool IsUpdateFinish
		{
			[Token(Token = "0x6005D6B")]
			[Address(RVA = "0x43B951C", Offset = "0x43B551C", VA = "0x43B951C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005D69")]
		[Address(RVA = "0x43B90A8", Offset = "0x43B50A8", VA = "0x43B90A8", Slot = "9")]
		public override void InitAfterLogin()
		{
		}

		[Token(Token = "0x6005D6A")]
		[Address(RVA = "0x43B94E8", Offset = "0x43B54E8", VA = "0x43B94E8")]
		public void TryCheck(bool state)
		{
		}

		[Token(Token = "0x6005D6C")]
		[Address(RVA = "0x43B9574", Offset = "0x43B5574", VA = "0x43B9574")]
		private void UpdateCheck()
		{
		}

		[Token(Token = "0x6005D6D")]
		[Address(RVA = "0x43B9504", Offset = "0x43B5504", VA = "0x43B9504")]
		private void MakeCheck()
		{
		}

		[Token(Token = "0x6005D6E")]
		[Address(RVA = "0x43B965C", Offset = "0x43B565C", VA = "0x43B965C")]
		public static long GetServerTime()
		{
			return default;
		}

		[Token(Token = "0x6005D6F")]
		[Address(RVA = "0x43B9308", Offset = "0x43B5308", VA = "0x43B9308")]
		private void CheatCode()
		{
		}

		[Token(Token = "0x6005D70")]
		[Address(RVA = "0x43B97B4", Offset = "0x43B57B4", VA = "0x43B97B4")]
		private void DayOffsetZero(string str)
		{
		}

		[Token(Token = "0x6005D71")]
		[Address(RVA = "0x43B980C", Offset = "0x43B580C", VA = "0x43B980C")]
		private void AddDayOffset(string str)
		{
		}

		[Token(Token = "0x6005D72")]
		[Address(RVA = "0x43B9888", Offset = "0x43B5888", VA = "0x43B9888")]
		private void SetDayOffset(string str)
		{
		}

		[Token(Token = "0x6005D73")]
		[Address(RVA = "0x43B9900", Offset = "0x43B5900", VA = "0x43B9900")]
		private void SetHourOffset(string str)
		{
		}

		[Token(Token = "0x6005D74")]
		[Address(RVA = "0x43B96FC", Offset = "0x43B56FC", VA = "0x43B96FC")]
		private void GetCurrentServerTime()
		{
		}

		[Token(Token = "0x6005D75")]
		[Address(RVA = "0x43B9970", Offset = "0x43B5970", VA = "0x43B9970")]
		private void ReceiveServerTime(object[] args)
		{
		}

		[Token(Token = "0x6005D76")]
		[Address(RVA = "0x43B9AAC", Offset = "0x43B5AAC", VA = "0x43B9AAC")]
		public static void ShowWait()
		{
		}

		[Token(Token = "0x6005D77")]
		[Address(RVA = "0x43B9AB0", Offset = "0x43B5AB0", VA = "0x43B9AB0")]
		public static void CloseWait()
		{
		}

		[Token(Token = "0x6005D78")]
		[Address(RVA = "0x43B9AB4", Offset = "0x43B5AB4", VA = "0x43B9AB4")]
		public ServerTimeMgr()
		{
		}
	}
}
