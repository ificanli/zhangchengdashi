using System.Collections.Generic;
using DataModule;
using Il2CppDummyDll;

namespace TutorModule
{
	[Token(Token = "0x20001F9")]
	public class FeatureUnlockCtrl
	{
		[Token(Token = "0x4001CCF")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, FeatureUnlockBase> _infoDic;

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x418ABA0", Offset = "0x4186BA0", VA = "0x418ABA0")]
		public FeatureUnlockCtrl()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x418B27C", Offset = "0x418727C", VA = "0x418B27C")]
		public void Init()
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x418B534", Offset = "0x4187534", VA = "0x418B534")]
		private void EnterGame()
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x418B6B0", Offset = "0x41876B0", VA = "0x418B6B0")]
		public bool IsUnlock(string infoId)
		{
			return default;
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x418B74C", Offset = "0x418774C", VA = "0x418B74C")]
		public UserFeatureUnlockData GetFeatureData(string infoId)
		{
			return null;
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x418B7F8", Offset = "0x41877F8", VA = "0x418B7F8")]
		public string GetUnlockTip(string infoId)
		{
			return null;
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x418B8B0", Offset = "0x41878B0", VA = "0x418B8B0")]
		public void ToUpdate()
		{
		}
	}
}
