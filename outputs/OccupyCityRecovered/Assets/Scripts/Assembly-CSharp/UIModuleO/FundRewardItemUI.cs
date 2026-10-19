using GameModule;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x200089F")]
	public class FundRewardItemUI : FundRewardItemUIComponents
	{
		[Token(Token = "0x20008A0")]
		public enum RewardItemState
		{
			[Token(Token = "0x400414F")]
			Lock = 0,
			[Token(Token = "0x4004150")]
			CantClaim = 1,
			[Token(Token = "0x4004151")]
			CanClaim = 2,
			[Token(Token = "0x4004152")]
			HadClaim = 3
		}

		[Token(Token = "0x400414D")]
		[FieldOffset(Offset = "0x70")]
		private bool _isBoxType;

		[Token(Token = "0x60030CE")]
		[Address(RVA = "0x4052A90", Offset = "0x404EA90", VA = "0x4052A90")]
		public void UpdateInfo(RewardConfigSingle rewardConfigSingle, RewardItemState rewardItemState)
		{
		}

		[Token(Token = "0x60030CF")]
		[Address(RVA = "0x4053DBC", Offset = "0x404FDBC", VA = "0x4053DBC")]
		private void SetBoxAnimByState(RewardItemState rewardItemState)
		{
		}

		[Token(Token = "0x60030D0")]
		[Address(RVA = "0x4053BC4", Offset = "0x404FBC4", VA = "0x4053BC4")]
		public void ChangeState(RewardItemState rewardItemState)
		{
		}

		[Token(Token = "0x60030D1")]
		[Address(RVA = "0x40541B4", Offset = "0x40501B4", VA = "0x40541B4")]
		public FundRewardItemUI()
		{
		}
	}
}
