using System;
using Il2CppDummyDll;

namespace L_Tools
{
	[Token(Token = "0x2000F87")]
	public class LTVideoButtonHookMult : LTVideoButtonHook
	{
		[Token(Token = "0x4006AE5")]
		[FieldOffset(Offset = "0x88")]
		private string MultVideoKey;

		[Token(Token = "0x4006AE6")]
		[FieldOffset(Offset = "0x90")]
		private int NeedCount;

		[Token(Token = "0x4006AE7")]
		[FieldOffset(Offset = "0x98")]
		private Action<int> onVideoProgressChange;

		[Token(Token = "0x6005D29")]
		[Address(RVA = "0x43B67FC", Offset = "0x43B27FC", VA = "0x43B67FC")]
		public void Init(string key, int needCount, Action<int> onVideoProgressChange)
		{
		}

		[Token(Token = "0x6005D2A")]
		[Address(RVA = "0x43B683C", Offset = "0x43B283C", VA = "0x43B683C")]
		private int GetCount()
		{
			return default;
		}

		[Token(Token = "0x6005D2B")]
		[Address(RVA = "0x43B6894", Offset = "0x43B2894", VA = "0x43B6894")]
		private void SetCount(int count)
		{
		}

		[Token(Token = "0x6005D2C")]
		[Address(RVA = "0x43B68F8", Offset = "0x43B28F8", VA = "0x43B68F8", Slot = "7")]
		protected override void CallLT_ADCenter(bool success, float clickTime)
		{
		}

		[Token(Token = "0x6005D2D")]
		[Address(RVA = "0x43B6DD0", Offset = "0x43B2DD0", VA = "0x43B6DD0")]
		public LTVideoButtonHookMult()
		{
		}
	}
}
