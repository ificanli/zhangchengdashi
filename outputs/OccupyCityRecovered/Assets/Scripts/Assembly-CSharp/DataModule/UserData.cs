using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000EE0")]
	public class UserData
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000EE1")]
		[CompilerGenerated]
		private struct _003CGetUserDataByGuestId_003Ed__39 : IAsyncStateMachine
		{
			[Token(Token = "0x400674F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4006750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<UserData> _003C_003Et__builder;

			[Token(Token = "0x4006751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string guestId;

			[Token(Token = "0x4006752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter<UserData> _003C_003Eu__1;

			[Token(Token = "0x60059EA")]
			[Address(RVA = "0x43776A4", Offset = "0x43736A4", VA = "0x43776A4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60059EB")]
			[Address(RVA = "0x4377968", Offset = "0x4373968", VA = "0x4377968", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000EE2")]
		[CompilerGenerated]
		private struct _003CInitData_003Ed__38 : IAsyncStateMachine
		{
			[Token(Token = "0x4006753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4006754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<UserData> _003C_003Et__builder;

			[Token(Token = "0x4006755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string guestId;

			[Token(Token = "0x4006756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter<UserData> _003C_003Eu__1;

			[Token(Token = "0x60059EC")]
			[Address(RVA = "0x43779E4", Offset = "0x43739E4", VA = "0x43779E4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60059ED")]
			[Address(RVA = "0x4377C08", Offset = "0x4373C08", VA = "0x4377C08", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000EE3")]
		[CompilerGenerated]
		private struct _003CRegisterUser_003Ed__40 : IAsyncStateMachine
		{
			[Token(Token = "0x4006757")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4006758")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<UserData> _003C_003Et__builder;

			[Token(Token = "0x4006759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string guestId;

			[Token(Token = "0x60059EE")]
			[Address(RVA = "0x4377C84", Offset = "0x4373C84", VA = "0x4377C84", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60059EF")]
			[Address(RVA = "0x4377DE8", Offset = "0x4373DE8", VA = "0x4377DE8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400672A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x400672B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string username;

		[Token(Token = "0x400672C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string email;

		[Token(Token = "0x400672D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string avatar;

		[Token(Token = "0x400672E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string cardback;

		[Token(Token = "0x400672F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int permission_level;

		[Token(Token = "0x4006730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int validation_level;

		[Token(Token = "0x4006731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<UserAssetData> userResourcesDataList;

		[Token(Token = "0x4006732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public UserPrefData userPrefData;

		[Token(Token = "0x4006733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<UserProgressData> userProgressDataList;

		[Token(Token = "0x4006734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<UserArenaData> userArenaDataList;

		[Token(Token = "0x4006735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<UserHeroCardData> userHeroCardDataList;

		[Token(Token = "0x4006736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Dictionary<string, UserHeroCardData> userHeroCardDataDic;

		[Token(Token = "0x4006737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<int> hardIndexs;

		[Token(Token = "0x4006738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Dictionary<string, int> playerTalentLevel;

		[Token(Token = "0x4006739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<UserOutsiderHexData> HexDatas;

		[Token(Token = "0x400673A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool hadFixedHexData;

		[Token(Token = "0x400673B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<UserBoxData> userBoxData;

		[Token(Token = "0x400673C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public List<UserBoxData> userStayOpenBoxData;

		[Token(Token = "0x400673D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public List<string> userStayGetCardData;

		[Token(Token = "0x400673E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public List<int> nowExpProgressRewardConfig;

		[Token(Token = "0x400673F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public int WonTrophyCount;

		[Token(Token = "0x4006740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public int WatchDailyGiftPackAdCount;

		[Token(Token = "0x4006741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public int WatchCoinAdCount;

		[Token(Token = "0x4006742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public int WatchWoodAdCount;

		[Token(Token = "0x4006743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Dictionary<string, TimeInfo> timeInfoDic;

		[Token(Token = "0x4006744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Dictionary<string, int> userHumanPackCofig;

		[Token(Token = "0x4006745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public List<UserDailyShopCardData> daliyShopCardDataList;

		[Token(Token = "0x4006746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Dictionary<string, int> userOrcPackCofig;

		[Token(Token = "0x4006747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Dictionary<string, int> userUndeadPackCofig;

		[Token(Token = "0x4006748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public Dictionary<string, int> userArtifactPackCofig;

		[Token(Token = "0x4006749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public List<UserCardDeckData> UserCardDeckDataList;

		[Token(Token = "0x400674A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public int cardDeckIndex;

		[Token(Token = "0x400674B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public bool nowLingquReward;

		[Token(Token = "0x400674C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public int moraleNum;

		[Token(Token = "0x400674D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public List<UserPropData> userPropDataList;

		[Token(Token = "0x400674E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public string userEquipPropID;

		[Token(Token = "0x60059E6")]
		[Address(RVA = "0x437738C", Offset = "0x437338C", VA = "0x437738C")]
		public UserData()
		{
		}

		[Token(Token = "0x60059E7")]
		[Address(RVA = "0x43773F8", Offset = "0x43733F8", VA = "0x43773F8")]
		[AsyncStateMachine(typeof(_003CInitData_003Ed__38))]
		public static Task<UserData> InitData(string guestId)
		{
			return null;
		}

		[Token(Token = "0x60059E8")]
		[Address(RVA = "0x43774DC", Offset = "0x43734DC", VA = "0x43774DC")]
		[AsyncStateMachine(typeof(_003CGetUserDataByGuestId_003Ed__39))]
		private static Task<UserData> GetUserDataByGuestId(string guestId)
		{
			return null;
		}

		[Token(Token = "0x60059E9")]
		[Address(RVA = "0x43775C0", Offset = "0x43735C0", VA = "0x43775C0")]
		[AsyncStateMachine(typeof(_003CRegisterUser_003Ed__40))]
		private static Task<UserData> RegisterUser(string guestId)
		{
			return null;
		}
	}
}
