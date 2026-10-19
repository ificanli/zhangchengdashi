using DataModule;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000BC3")]
	public class TrophyProgressItem_Training : TrophyProgressItem_TrainingComponents
	{
		[Token(Token = "0x4005599")]
		[FieldOffset(Offset = "0x80")]
		private TrophyProgressRewardData _rewardData;

		[Token(Token = "0x400559A")]
		[FieldOffset(Offset = "0x88")]
		private int _index;

		[Token(Token = "0x6004895")]
		[Address(RVA = "0x423B48C", Offset = "0x423748C", VA = "0x423B48C")]
		public void Show(TrophyProgressRewardData rewardData, int index)
		{
		}

		[Token(Token = "0x6004896")]
		[Address(RVA = "0x423B508", Offset = "0x4237508", VA = "0x423B508")]
		private void UpdateUI()
		{
		}

		[Token(Token = "0x6004897")]
		[Address(RVA = "0x423B6B8", Offset = "0x42376B8", VA = "0x423B6B8")]
		private void UpdateUniversalCardReward(GlobalTrophyProgressInfo config)
		{
		}

		[Token(Token = "0x6004898")]
		[Address(RVA = "0x423B84C", Offset = "0x423784C", VA = "0x423B84C")]
		private void UpdateFullProgressBar()
		{
		}

		[Token(Token = "0x6004899")]
		[Address(RVA = "0x423BA3C", Offset = "0x4237A3C", VA = "0x423BA3C")]
		private void UpdateDuiHaoVisibility()
		{
		}

		[Token(Token = "0x600489A")]
		[Address(RVA = "0x423BFE8", Offset = "0x4237FE8", VA = "0x423BFE8", Slot = "12")]
		protected override void OnButtonExtendBtnClaimCompleteRewardClicked()
		{
		}

		[Token(Token = "0x600489B")]
		[Address(RVA = "0x423C06C", Offset = "0x423806C", VA = "0x423C06C")]
		private void ClaimNormalReward()
		{
		}

		[Token(Token = "0x600489C")]
		[Address(RVA = "0x423C2BC", Offset = "0x42382BC", VA = "0x423C2BC")]
		public TrophyProgressItem_Training()
		{
		}
	}
}
