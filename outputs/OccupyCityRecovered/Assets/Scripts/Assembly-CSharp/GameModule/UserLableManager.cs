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
	[Token(Token = "0x20005DB")]
	public class UserLableManager : ManagerBase<UserLableManager>
	{
		[Token(Token = "0x20005DC")]
		public enum UserLable
		{
			[Token(Token = "0x400316C")]
			Rookie = 0,
			[Token(Token = "0x400316D")]
			NormalPlayer = 1,
			[Token(Token = "0x400316E")]
			Expert = 2,
			[Token(Token = "0x400316F")]
			WinningStreak = 3,
			[Token(Token = "0x4003170")]
			LosingStreak = 4,
			[Token(Token = "0x4003171")]
			PaidUser = 5,
			[Token(Token = "0x4003172")]
			AdUser = 6,
			[Token(Token = "0x4003173")]
			NoMoney = 7,
			[Token(Token = "0x4003174")]
			JustPaidUser = 8,
			[Token(Token = "0x4003175")]
			InactiveUser = 9,
			[Token(Token = "0x4003176")]
			FirstMatchUser = 10
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005DD")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__26 : IAsyncStateMachine
		{
			[Token(Token = "0x4003177")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003178")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003179")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UserLableManager _003C_003E4__this;

			[Token(Token = "0x6001EBC")]
			[Address(RVA = "0x3EFD158", Offset = "0x3EF9158", VA = "0x3EFD158", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001EBD")]
			[Address(RVA = "0x3EFD330", Offset = "0x3EF9330", VA = "0x3EFD330", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400316A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<UserLable> userAllLableType;

		[Token(Token = "0x17000187")]
		public bool UserIsRookie
		{
			[Token(Token = "0x6001E8C")]
			[Address(RVA = "0x3EFAB5C", Offset = "0x3EF6B5C", VA = "0x3EFAB5C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000188")]
		public bool UserIsNormalPlayer
		{
			[Token(Token = "0x6001E8D")]
			[Address(RVA = "0x3EFABB0", Offset = "0x3EF6BB0", VA = "0x3EFABB0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000189")]
		public bool UserIsExpert
		{
			[Token(Token = "0x6001E8E")]
			[Address(RVA = "0x3EFAC04", Offset = "0x3EF6C04", VA = "0x3EFAC04")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700018A")]
		public bool UserIsWinningStreak
		{
			[Token(Token = "0x6001E8F")]
			[Address(RVA = "0x3EFAC58", Offset = "0x3EF6C58", VA = "0x3EFAC58")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700018B")]
		public bool UserIsLosingStreak
		{
			[Token(Token = "0x6001E90")]
			[Address(RVA = "0x3EFACAC", Offset = "0x3EF6CAC", VA = "0x3EFACAC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700018C")]
		public bool UserIsPaidUser
		{
			[Token(Token = "0x6001E91")]
			[Address(RVA = "0x3EFAD00", Offset = "0x3EF6D00", VA = "0x3EFAD00")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700018D")]
		public bool UserIsAdUser
		{
			[Token(Token = "0x6001E92")]
			[Address(RVA = "0x3EFAD54", Offset = "0x3EF6D54", VA = "0x3EFAD54")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700018E")]
		public bool UserIsNoMoney
		{
			[Token(Token = "0x6001E93")]
			[Address(RVA = "0x3EFADA8", Offset = "0x3EF6DA8", VA = "0x3EFADA8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700018F")]
		public bool UserIsJustPaidUser
		{
			[Token(Token = "0x6001E94")]
			[Address(RVA = "0x3EFADFC", Offset = "0x3EF6DFC", VA = "0x3EFADFC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000190")]
		public bool UserIsInactiveUser
		{
			[Token(Token = "0x6001E95")]
			[Address(RVA = "0x3EFAE50", Offset = "0x3EF6E50", VA = "0x3EFAE50")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000191")]
		public bool UserIsFirstMatchUser
		{
			[Token(Token = "0x6001E96")]
			[Address(RVA = "0x3EFAF30", Offset = "0x3EF6F30", VA = "0x3EFAF30")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000192")]
		private UserLableData UserLableData
		{
			[Token(Token = "0x6001E97")]
			[Address(RVA = "0x3EFAEC8", Offset = "0x3EF6EC8", VA = "0x3EFAEC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001E98")]
		[Address(RVA = "0x3EFAF84", Offset = "0x3EF6F84", VA = "0x3EFAF84", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__26))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6001E99")]
		[Address(RVA = "0x3EFB008", Offset = "0x3EF7008", VA = "0x3EFB008")]
		private void InitUserLableData()
		{
		}

		[Token(Token = "0x6001E9A")]
		[Address(RVA = "0x3EFBD94", Offset = "0x3EF7D94", VA = "0x3EFBD94")]
		private void CheckUpdateUserAllLable()
		{
		}

		[Token(Token = "0x6001E9B")]
		[Address(RVA = "0x3EFC398", Offset = "0x3EF8398", VA = "0x3EFC398")]
		public int EnmeyDifficultyLevelHandle(int difficultyLevel)
		{
			return default;
		}

		[Token(Token = "0x6001E9C")]
		[Address(RVA = "0x3EFC64C", Offset = "0x3EF864C", VA = "0x3EFC64C")]
		public int EnmeyOpenHexOffsetHandle(int enemyOpenHexOffset)
		{
			return default;
		}

		[Token(Token = "0x6001E9D")]
		[Address(RVA = "0x3EFC6A0", Offset = "0x3EF86A0", VA = "0x3EFC6A0")]
		public int UserOpenLendaryCardOddHandle(bool userLableReset)
		{
			return default;
		}

		[Token(Token = "0x6001E9E")]
		[Address(RVA = "0x3EFC700", Offset = "0x3EF8700", VA = "0x3EFC700")]
		public int EnemyOpenLendaryCardOddHandle(bool UserLableEnemyReset)
		{
			return default;
		}

		[Token(Token = "0x6001E9F")]
		[Address(RVA = "0x3EFC724", Offset = "0x3EF8724", VA = "0x3EFC724")]
		private void HasArenaUnLock(object o)
		{
		}

		[Token(Token = "0x6001EA0")]
		[Address(RVA = "0x3EEC8F4", Offset = "0x3EE88F4", VA = "0x3EEC8F4")]
		public void RefreshUserLableHasPaidData()
		{
		}

		[Token(Token = "0x6001EA1")]
		[Address(RVA = "0x3EFB830", Offset = "0x3EF7830", VA = "0x3EFB830")]
		public void RefreshUserLableHasWatchedAdData()
		{
		}

		[Token(Token = "0x6001EA2")]
		[Address(RVA = "0x3EFC7F4", Offset = "0x3EF87F4", VA = "0x3EFC7F4")]
		public void RecordPlayerNear20GameSituation(bool isVictory)
		{
		}

		[Token(Token = "0x6001EA3")]
		[Address(RVA = "0x3EFB374", Offset = "0x3EF7374", VA = "0x3EFB374")]
		public void RefreshUserLableRecentWinRateData()
		{
		}

		[Token(Token = "0x6001EA4")]
		[Address(RVA = "0x3EFC924", Offset = "0x3EF8924", VA = "0x3EFC924")]
		public void RefreshUserLableWinStreakData()
		{
		}

		[Token(Token = "0x6001EA5")]
		[Address(RVA = "0x3EFC9C0", Offset = "0x3EF89C0", VA = "0x3EFC9C0")]
		public void RefreshUserLableLoseStreakData()
		{
		}

		[Token(Token = "0x6001EA6")]
		[Address(RVA = "0x3EFCA5C", Offset = "0x3EF8A5C", VA = "0x3EFCA5C")]
		public void RefreshUserLableFirstMatchData()
		{
		}

		[Token(Token = "0x6001EA7")]
		[Address(RVA = "0x3EEC864", Offset = "0x3EE8864", VA = "0x3EEC864")]
		public void RefreshUserLableJustNowPaidData()
		{
		}

		[Token(Token = "0x6001EA8")]
		[Address(RVA = "0x3EFCAF8", Offset = "0x3EF8AF8", VA = "0x3EFCAF8")]
		public void RefreshOrInitJustNowPaidUserBuff(bool isInit)
		{
		}

		[Token(Token = "0x6001EA9")]
		[Address(RVA = "0x3EFB978", Offset = "0x3EF7978", VA = "0x3EFB978")]
		public void RefreshUserLableLastLoginTimeData()
		{
		}

		[Token(Token = "0x6001EAA")]
		[Address(RVA = "0x3EFCC1C", Offset = "0x3EF8C1C", VA = "0x3EFCC1C")]
		public void RefreshOrInitInactiveUserBuff(bool isInit)
		{
		}

		[Token(Token = "0x6001EAB")]
		[Address(RVA = "0x3EFC268", Offset = "0x3EF8268", VA = "0x3EFC268")]
		public void RefreshUserInactiveUserLable()
		{
		}

		[Token(Token = "0x6001EAC")]
		[Address(RVA = "0x3EFBDF4", Offset = "0x3EF7DF4", VA = "0x3EFBDF4")]
		private void RefreshUserJustPaidUserLable()
		{
		}

		[Token(Token = "0x6001EAD")]
		[Address(RVA = "0x3EFBE1C", Offset = "0x3EF7E1C", VA = "0x3EFBE1C")]
		private void RefreshUserNoMoneyLable()
		{
		}

		[Token(Token = "0x6001EAE")]
		[Address(RVA = "0x3EFBEB0", Offset = "0x3EF7EB0", VA = "0x3EFBEB0")]
		private void RefreshUserAdUserLable()
		{
		}

		[Token(Token = "0x6001EAF")]
		[Address(RVA = "0x3EFBF48", Offset = "0x3EF7F48", VA = "0x3EFBF48")]
		private void RefreshUserPaidUserLable()
		{
		}

		[Token(Token = "0x6001EB0")]
		[Address(RVA = "0x3EFBFCC", Offset = "0x3EF7FCC", VA = "0x3EFBFCC")]
		private void RefreshUserLosingStreakLable()
		{
		}

		[Token(Token = "0x6001EB1")]
		[Address(RVA = "0x3EFBFFC", Offset = "0x3EF7FFC", VA = "0x3EFBFFC")]
		private void RefreshUserWinningStreakLable()
		{
		}

		[Token(Token = "0x6001EB2")]
		[Address(RVA = "0x3EFC02C", Offset = "0x3EF802C", VA = "0x3EFC02C")]
		private void RefreshUserExpertLable()
		{
		}

		[Token(Token = "0x6001EB3")]
		[Address(RVA = "0x3EFC0E0", Offset = "0x3EF80E0", VA = "0x3EFC0E0")]
		private void RefreshUserNormalPlayerLable()
		{
		}

		[Token(Token = "0x6001EB4")]
		[Address(RVA = "0x3EFC1C8", Offset = "0x3EF81C8", VA = "0x3EFC1C8")]
		private void RefreshUserRookieLable()
		{
		}

		[Token(Token = "0x6001EB5")]
		[Address(RVA = "0x3EFC370", Offset = "0x3EF8370", VA = "0x3EFC370")]
		private void RefreshUserFirstMatchUserLable()
		{
		}

		[Token(Token = "0x6001EB6")]
		[Address(RVA = "0x3EFCD54", Offset = "0x3EF8D54", VA = "0x3EFCD54")]
		private void RefreshUserSomeLable(bool judge, UserLable lable)
		{
		}

		[Token(Token = "0x6001EB7")]
		[Address(RVA = "0x3EFCEB0", Offset = "0x3EF8EB0", VA = "0x3EFCEB0")]
		public void ShowUserLableDebug()
		{
		}

		[Token(Token = "0x6001EB8")]
		[Address(RVA = "0x3EEC7F0", Offset = "0x3EE87F0", VA = "0x3EEC7F0")]
		public bool UserLableIsOpen()
		{
			return default;
		}

		[Token(Token = "0x6001EB9")]
		[Address(RVA = "0x3EFBA70", Offset = "0x3EF7A70", VA = "0x3EFBA70")]
		private void InitUserCategoryLevelDict()
		{
		}

		[Token(Token = "0x6001EBA")]
		[Address(RVA = "0x3EFD044", Offset = "0x3EF9044", VA = "0x3EFD044")]
		public UserLableManager()
		{
		}
	}
}
