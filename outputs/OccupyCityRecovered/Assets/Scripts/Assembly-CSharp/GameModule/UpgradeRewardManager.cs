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
	[Token(Token = "0x20005D5")]
	public class UpgradeRewardManager : ManagerBase<UpgradeRewardManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005D7")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__0 : IAsyncStateMachine
		{
			[Token(Token = "0x400315D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400315E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400315F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UpgradeRewardManager _003C_003E4__this;

			[Token(Token = "0x6001E84")]
			[Address(RVA = "0x3EF98A8", Offset = "0x3EF58A8", VA = "0x3EF98A8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001E85")]
			[Address(RVA = "0x3EF9DF8", Offset = "0x3EF5DF8", VA = "0x3EF9DF8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005D8")]
		[CompilerGenerated]
		private struct _003CShowUpgradeRewardsPanel_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x4003160")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003161")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003162")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001E86")]
			[Address(RVA = "0x3EF9E04", Offset = "0x3EF5E04", VA = "0x3EF9E04", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001E87")]
			[Address(RVA = "0x3EFA294", Offset = "0x3EF6294", VA = "0x3EFA294", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005D9")]
		[CompilerGenerated]
		private struct _003CShowUpgradeRewardsPreviewPanel_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x4003163")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003164")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003165")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isupgrad;

			[Token(Token = "0x4003166")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001E88")]
			[Address(RVA = "0x3EFA2A0", Offset = "0x3EF62A0", VA = "0x3EFA2A0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001E89")]
			[Address(RVA = "0x3EFA658", Offset = "0x3EF6658", VA = "0x3EFA658", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005DA")]
		[CompilerGenerated]
		private struct _003CUpgradeRewardPanelIsAnimation_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4003167")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003168")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

			[Token(Token = "0x4003169")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<UIFramework.UIPanel>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001E8A")]
			[Address(RVA = "0x3EFA664", Offset = "0x3EF6664", VA = "0x3EFA664", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001E8B")]
			[Address(RVA = "0x3EFAB04", Offset = "0x3EF6B04", VA = "0x3EFAB04", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400315B")]
		private const string Level_1 = "1";

		[Token(Token = "0x6001E77")]
		[Address(RVA = "0x3EF89BC", Offset = "0x3EF49BC", VA = "0x3EF89BC", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__0))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6001E78")]
		[Address(RVA = "0x3EF8A40", Offset = "0x3EF4A40", VA = "0x3EF8A40")]
		public void CheckRedDot()
		{
		}

		[Token(Token = "0x6001E79")]
		[Address(RVA = "0x3EF8DB8", Offset = "0x3EF4DB8", VA = "0x3EF8DB8")]
		[AsyncStateMachine(typeof(_003CShowUpgradeRewardsPreviewPanel_003Ed__2))]
		public void ShowUpgradeRewardsPreviewPanel(bool isupgrad = false)
		{
		}

		[Token(Token = "0x6001E7A")]
		[Address(RVA = "0x3EF8E48", Offset = "0x3EF4E48", VA = "0x3EF8E48")]
		[AsyncStateMachine(typeof(_003CShowUpgradeRewardsPanel_003Ed__3))]
		public UniTask ShowUpgradeRewardsPanel()
		{
			return default;
		}

		[Token(Token = "0x6001E7B")]
		[Address(RVA = "0x3EF8ECC", Offset = "0x3EF4ECC", VA = "0x3EF8ECC")]
		[AsyncStateMachine(typeof(_003CUpgradeRewardPanelIsAnimation_003Ed__4))]
		public UniTask<bool> UpgradeRewardPanelIsAnimation()
		{
			return default;
		}

		[Token(Token = "0x6001E7C")]
		[Address(RVA = "0x3EF8F7C", Offset = "0x3EF4F7C", VA = "0x3EF8F7C")]
		public bool IsGetLevelReward(string level)
		{
			return default;
		}

		[Token(Token = "0x6001E7D")]
		[Address(RVA = "0x3EF90A8", Offset = "0x3EF50A8", VA = "0x3EF90A8")]
		public void RewardsPreviewPanelGetLevelReward(GlobaUpgradeReward level)
		{
		}

		[Token(Token = "0x6001E7E")]
		[Address(RVA = "0x3EF9250", Offset = "0x3EF5250", VA = "0x3EF9250")]
		public void PlayerLevelUpPanelGetReward(int level)
		{
		}

		[Token(Token = "0x6001E7F")]
		[Address(RVA = "0x3EF8B14", Offset = "0x3EF4B14", VA = "0x3EF8B14")]
		public bool IsUnclaimedRewards()
		{
			return default;
		}

		[Token(Token = "0x6001E80")]
		[Address(RVA = "0x3EF9628", Offset = "0x3EF5628", VA = "0x3EF9628")]
		public bool ShouldShowLevelUpRewardObtainGuideWay()
		{
			return default;
		}

		[Token(Token = "0x6001E81")]
		[Address(RVA = "0x3EF9830", Offset = "0x3EF5830", VA = "0x3EF9830")]
		public UpgradeRewardManager()
		{
		}
	}
}
