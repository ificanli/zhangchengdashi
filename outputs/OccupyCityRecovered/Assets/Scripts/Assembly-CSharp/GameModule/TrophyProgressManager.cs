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
	[Token(Token = "0x2000478")]
	public class TrophyProgressManager : ManagerBase<TrophyProgressManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200047E")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__0 : IAsyncStateMachine
		{
			[Token(Token = "0x4002B06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002B07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002B08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TrophyProgressManager _003C_003E4__this;

			[Token(Token = "0x6001605")]
			[Address(RVA = "0x3E24F8C", Offset = "0x3E20F8C", VA = "0x3E24F8C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001606")]
			[Address(RVA = "0x3E25164", Offset = "0x3E21164", VA = "0x3E25164", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x60015E9")]
		[Address(RVA = "0x3E2318C", Offset = "0x3E1F18C", VA = "0x3E2318C", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__0))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x60015EA")]
		[Address(RVA = "0x3E23210", Offset = "0x3E1F210", VA = "0x3E23210")]
		private void InitTrophyProgressRewardData()
		{
		}

		[Token(Token = "0x60015EB")]
		[Address(RVA = "0x3E23E70", Offset = "0x3E1FE70", VA = "0x3E23E70")]
		public string BuildTrainingRewardString(GlobalTrophyProgressInfo config)
		{
			return null;
		}

		[Token(Token = "0x60015EC")]
		[Address(RVA = "0x3E23A80", Offset = "0x3E1FA80", VA = "0x3E23A80")]
		private void MigrateOldRewardData(PlayerArenaData playerArenaData)
		{
		}

		[Token(Token = "0x60015ED")]
		[Address(RVA = "0x3E24224", Offset = "0x3E20224", VA = "0x3E24224")]
		public void ShowTrophyProgressPanel()
		{
		}

		[Token(Token = "0x60015EE")]
		[Address(RVA = "0x3E242F8", Offset = "0x3E202F8", VA = "0x3E242F8")]
		public bool HasClaimableReward()
		{
			return default;
		}

		[Token(Token = "0x60015EF")]
		[Address(RVA = "0x3E24520", Offset = "0x3E20520", VA = "0x3E24520")]
		public int GetFirstClaimableIndex()
		{
			return default;
		}

		[Token(Token = "0x60015F0")]
		[Address(RVA = "0x3E24678", Offset = "0x3E20678", VA = "0x3E24678")]
		public int GetClaimableRewardCount()
		{
			return default;
		}

		[Token(Token = "0x60015F1")]
		[Address(RVA = "0x3E2488C", Offset = "0x3E2088C", VA = "0x3E2488C")]
		public float GetCurrentProgressPercent()
		{
			return default;
		}

		[Token(Token = "0x60015F2")]
		[Address(RVA = "0x3E249E8", Offset = "0x3E209E8", VA = "0x3E249E8")]
		public TrophyProgressRewardData GetRewardDataByIndex(int index)
		{
			return null;
		}

		[Token(Token = "0x60015F3")]
		[Address(RVA = "0x3E24AA0", Offset = "0x3E20AA0", VA = "0x3E24AA0")]
		public TrophyProgressRewardData GetRewardDataByConfigId(string configId)
		{
			return null;
		}

		[Token(Token = "0x60015F4")]
		[Address(RVA = "0x3E24BC8", Offset = "0x3E20BC8", VA = "0x3E24BC8")]
		public void ClaimCardReward(string cardRewardConfig, string configId)
		{
		}

		[Token(Token = "0x60015F5")]
		[Address(RVA = "0x3E24CDC", Offset = "0x3E20CDC", VA = "0x3E24CDC")]
		public void RefreshPanel()
		{
		}

		[Token(Token = "0x60015F6")]
		[Address(RVA = "0x3E24D78", Offset = "0x3E20D78", VA = "0x3E24D78")]
		public TrophyProgressManager()
		{
		}
	}
}
