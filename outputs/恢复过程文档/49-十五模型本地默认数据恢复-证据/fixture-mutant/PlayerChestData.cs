using System.Collections.Generic;
using Newtonsoft.Json;

namespace DataModule
{
	public class PlayerChestData : ServerBaseData
	{
		[JsonProperty("ubd")]
		public List<UserBoxData> userBoxData;
		[JsonProperty("usobd")]
		public List<UserBoxData> userStayOpenBoxData;
		public ChestSlotUnlockData chestSlotUnlockData;
		public List<UserBoxData> userHasAllBoxdata;
		public bool handleAToBBoxSlot;
		public bool handleBToABoxSlot;
		public int userGetBoxCount;
		public bool handleBoxRewardCrystal;
		public PlayerChestData()
		{
		}
	}
}
