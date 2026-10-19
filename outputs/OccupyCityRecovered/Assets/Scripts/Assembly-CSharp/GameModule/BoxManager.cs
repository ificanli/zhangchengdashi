using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using ToolModule;

namespace GameModule
{
	[Token(Token = "0x2000489")]
	public class BoxManager : ManagerBase<BoxManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200048E")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__0 : IAsyncStateMachine
		{
			[Token(Token = "0x4002B26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002B27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002B28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BoxManager _003C_003E4__this;

			[Token(Token = "0x6001664")]
			[Address(RVA = "0x3E2DC58", Offset = "0x3E29C58", VA = "0x3E2DC58", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001665")]
			[Address(RVA = "0x3E2F0A0", Offset = "0x3E2B0A0", VA = "0x3E2F0A0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002B1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, GlobalBoxInfo> allBoxInfos;

		[Token(Token = "0x4002B1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<string, GlobalBoxInfo> _globalBoxInfos;

		[Token(Token = "0x6001638")]
		[Address(RVA = "0x3E28510", Offset = "0x3E24510", VA = "0x3E28510", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__0))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6001639")]
		[Address(RVA = "0x3E28594", Offset = "0x3E24594", VA = "0x3E28594")]
		public static bool TryPatchBoxRewardCrystalOnly(UserBoxData box, bool forceRewrite = false)
		{
			return default;
		}

		[Token(Token = "0x600163A")]
		[Address(RVA = "0x3E28838", Offset = "0x3E24838", VA = "0x3E28838")]
		private static int GetCrystalCountFromBoxConfig(GlobalBoxInfo boxInfo, string arenaId, float customFold = 1f)
		{
			return default;
		}

		[Token(Token = "0x600163B")]
		[Address(RVA = "0x3E28790", Offset = "0x3E24790", VA = "0x3E28790")]
		private static GlobalBoxInfo GetBoxInfoByIndexSafe(int boxIndex)
		{
			return null;
		}

		[Token(Token = "0x600163C")]
		[Address(RVA = "0x3E289C0", Offset = "0x3E249C0", VA = "0x3E289C0")]
		private void MigrateAllBoxRewardCrystal()
		{
		}

		[Token(Token = "0x600163D")]
		[Address(RVA = "0x3E28A80", Offset = "0x3E24A80", VA = "0x3E28A80")]
		private static void PatchBoxListCrystal(List<UserBoxData> boxList)
		{
		}

		[Token(Token = "0x600163E")]
		[Address(RVA = "0x3E28B08", Offset = "0x3E24B08", VA = "0x3E28B08")]
		public void AddStayOpenBox(UserBoxData boxData)
		{
		}

		[Token(Token = "0x600163F")]
		[Address(RVA = "0x3E28C04", Offset = "0x3E24C04", VA = "0x3E28C04")]
		public void RemoveStayOpenBox(UserBoxData boxData)
		{
		}

		[Token(Token = "0x6001640")]
		[Address(RVA = "0x3E28CBC", Offset = "0x3E24CBC", VA = "0x3E28CBC")]
		public UserBoxData GetOneBoxDataByArenaId(string arneaId, int customBoxId = -1, int customFold = 1)
		{
			return null;
		}

		[Token(Token = "0x6001641")]
		[Address(RVA = "0x3E292D8", Offset = "0x3E252D8", VA = "0x3E292D8")]
		public GlobalBoxInfo GetBoxInfoById(string boxId)
		{
			return null;
		}

		[Token(Token = "0x6001642")]
		[Address(RVA = "0x3E29440", Offset = "0x3E25440", VA = "0x3E29440")]
		public UserBoxData GetOneBoxDataByBoxId(string boxId)
		{
			return null;
		}

		[Token(Token = "0x6001643")]
		[Address(RVA = "0x3E29A08", Offset = "0x3E25A08", VA = "0x3E29A08")]
		private string GeneralBoxUnlockTimeKey()
		{
			return null;
		}

		[Token(Token = "0x6001644")]
		[Address(RVA = "0x3E29C94", Offset = "0x3E25C94", VA = "0x3E29C94")]
		public void StartOpenBox(UserBoxData _data)
		{
		}

		[Token(Token = "0x6001645")]
		[Address(RVA = "0x3E29F3C", Offset = "0x3E25F3C", VA = "0x3E29F3C")]
		private bool IsBoxInSlot(UserBoxData boxData)
		{
			return default;
		}

		[Token(Token = "0x6001646")]
		[Address(RVA = "0x3E29FDC", Offset = "0x3E25FDC", VA = "0x3E29FDC")]
		public void OpenBoxComplete(UserBoxData _data)
		{
		}

		[Token(Token = "0x6001647")]
		[Address(RVA = "0x3E2A310", Offset = "0x3E26310", VA = "0x3E2A310")]
		public RewardConfig GetBoxReward(string cardRewardNumCofig, CurrencyTransactionSceneType type, int boxId = 0)
		{
			return null;
		}

		[Token(Token = "0x6001648")]
		[Address(RVA = "0x3E2A67C", Offset = "0x3E2667C", VA = "0x3E2A67C")]
		public List<RewardConfigSingle> GetBoxRewardList(string cardRewardNumCofig, int boxId = 0)
		{
			return null;
		}

		[Token(Token = "0x6001649")]
		[Address(RVA = "0x3E2A980", Offset = "0x3E26980", VA = "0x3E2A980")]
		private void GetBoxCardCofigReward(List<RewardConfigSingle> userAssetDatas, string cardRewardCofig, int boxId = 0, bool onlyEquipCard = false)
		{
		}

		[Token(Token = "0x600164A")]
		[Address(RVA = "0x3E2C014", Offset = "0x3E28014", VA = "0x3E2C014")]
		private static List<int> SplitNumber(int number, int parts)
		{
			return null;
		}

		[Token(Token = "0x600164B")]
		[Address(RVA = "0x3E2C4EC", Offset = "0x3E284EC", VA = "0x3E2C4EC")]
		public void GetOneBox(UserBoxData box)
		{
		}

		[Token(Token = "0x600164C")]
		[Address(RVA = "0x3E2C7B0", Offset = "0x3E287B0", VA = "0x3E2C7B0")]
		public (bool, int) GetBoxByNowPlayEdArenaID()
		{
			return default;
		}

		[Token(Token = "0x600164D")]
		[Address(RVA = "0x3E2A41C", Offset = "0x3E2641C", VA = "0x3E2A41C")]
		public void LoseBox(UserBoxData boxData)
		{
		}

		[Token(Token = "0x600164E")]
		[Address(RVA = "0x3E2CAA8", Offset = "0x3E28AA8", VA = "0x3E2CAA8")]
		public UserBoxData ExpUpChestCofig()
		{
			return null;
		}

		[Token(Token = "0x600164F")]
		[Address(RVA = "0x3E2CD5C", Offset = "0x3E28D5C", VA = "0x3E2CD5C")]
		public bool HasBoxUnLockIng()
		{
			return default;
		}

		[Token(Token = "0x6001650")]
		[Address(RVA = "0x3E2CE88", Offset = "0x3E28E88", VA = "0x3E2CE88")]
		public bool BoxIsUnLockEd(int index = 0)
		{
			return default;
		}

		[Token(Token = "0x6001651")]
		[Address(RVA = "0x3E2CF60", Offset = "0x3E28F60", VA = "0x3E2CF60")]
		public GlobalBoxInfo GetGlobalBoInfo(string boxId)
		{
			return null;
		}

		[Token(Token = "0x6001652")]
		[Address(RVA = "0x3E2D0F8", Offset = "0x3E290F8", VA = "0x3E2D0F8")]
		public static int GetBoxRewardCrystalCount(UserBoxData boxData)
		{
			return default;
		}

		[Token(Token = "0x6001653")]
		[Address(RVA = "0x3E2D188", Offset = "0x3E29188", VA = "0x3E2D188")]
		public string GetBoxRewardUIText(UserBoxData boxData)
		{
			return null;
		}

		[Token(Token = "0x6001654")]
		[Address(RVA = "0x3E2D574", Offset = "0x3E29574", VA = "0x3E2D574")]
		private void OnFeatureCheatSlot2Unlocked(object o)
		{
		}

		[Token(Token = "0x6001655")]
		[Address(RVA = "0x3E2D67C", Offset = "0x3E2967C", VA = "0x3E2D67C")]
		private void OnBuyChestSlot03Success(object o)
		{
		}

		[Token(Token = "0x6001656")]
		[Address(RVA = "0x3E2D7B4", Offset = "0x3E297B4", VA = "0x3E2D7B4")]
		private void OnBuyChestSlot04Success(object o)
		{
		}

		[Token(Token = "0x6001657")]
		[Address(RVA = "0x3E2D8EC", Offset = "0x3E298EC", VA = "0x3E2D8EC")]
		public string GetDailyChestString()
		{
			return null;
		}

		[Token(Token = "0x6001658")]
		[Address(RVA = "0x3E2D9CC", Offset = "0x3E299CC", VA = "0x3E2D9CC")]
		public BoxManager()
		{
		}
	}
}
