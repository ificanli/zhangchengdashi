using System.Collections.Generic;
using DataModule;
using GameModule;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000777")]
	public class BtnMonthlyCardItemB : BtnMonthlyCardItemBComponents
	{
		[Token(Token = "0x4003A4D")]
		[FieldOffset(Offset = "0x80")]
		private GlobalShopInfo _info;

		[Token(Token = "0x4003A4E")]
		[FieldOffset(Offset = "0x88")]
		private string productId;

		[Token(Token = "0x60028FD")]
		[Address(RVA = "0x3FBD168", Offset = "0x3FB9168", VA = "0x3FBD168")]
		public void Init(GlobalShopInfo info)
		{
		}

		[Token(Token = "0x60028FE")]
		[Address(RVA = "0x3FBD72C", Offset = "0x3FB972C", VA = "0x3FBD72C")]
		private void UpdateRewardUI()
		{
		}

		[Token(Token = "0x60028FF")]
		[Address(RVA = "0x3FBD7AC", Offset = "0x3FB97AC", VA = "0x3FBD7AC")]
		private List<RewardConfigSingle> ParseRewardSingles(string reward)
		{
			return null;
		}

		[Token(Token = "0x6002900")]
		[Address(RVA = "0x3FBDA48", Offset = "0x3FB9A48", VA = "0x3FBDA48")]
		private void ApplyRewardToSlot(RewardItemUI slot, List<RewardConfigSingle> rewards, int index)
		{
		}

		[Token(Token = "0x6002901")]
		[Address(RVA = "0x3FBDD1C", Offset = "0x3FB9D1C", VA = "0x3FBDD1C", Slot = "12")]
		protected override void OnButtonExtendBtnMonthlyCardItemBClicked()
		{
		}

		[Token(Token = "0x6002902")]
		[Address(RVA = "0x3FBDDF4", Offset = "0x3FB9DF4", VA = "0x3FBDDF4")]
		public BtnMonthlyCardItemB()
		{
		}
	}
}
