using System.Collections.Generic;
using System.Runtime.InteropServices;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x20004AF")]
	public class GoldCardGiftPackController : MonoBehaviour
	{
		[Token(Token = "0x6001756")]
		[Address(RVA = "0x3E5A840", Offset = "0x3E56840", VA = "0x3E5A840")]
		public void Init()
		{
		}

		[Token(Token = "0x6001757")]
		[Address(RVA = "0x3E5ACD4", Offset = "0x3E56CD4", VA = "0x3E5ACD4")]
		private void GoldCardWeeklyGiftPackBuySuccess(object o)
		{
		}

		[Token(Token = "0x6001758")]
		[Address(RVA = "0x3E5AF78", Offset = "0x3E56F78", VA = "0x3E5AF78")]
		public List<GlobalIAPInfo> GetGiftPackIapInfo()
		{
			return null;
		}

		[Token(Token = "0x6001759")]
		[Address(RVA = "0x3E5B19C", Offset = "0x3E5719C", VA = "0x3E5B19C")]
		public void ClearGiftPackData()
		{
		}

		[Token(Token = "0x600175A")]
		[Address(RVA = "0x3E5B2A4", Offset = "0x3E572A4", VA = "0x3E5B2A4")]
		public string GetSkillVideoPath(WeeklyCardActivityManager.CycleCardType cycleCardType)
		{
			return null;
		}

		[Token(Token = "0x600175B")]
		[Address(RVA = "0x3E5B2EC", Offset = "0x3E572EC", VA = "0x3E5B2EC")]
		public void ShowGoldCardWeekGiftPack([Optional][DefaultParameterValue(false)] bool fromGameEnd, [Optional] string placement)
		{
		}

		[Token(Token = "0x600175C")]
		[Address(RVA = "0x3E5B494", Offset = "0x3E57494", VA = "0x3E5B494")]
		public GoldCardGiftPackController()
		{
		}
	}
}
