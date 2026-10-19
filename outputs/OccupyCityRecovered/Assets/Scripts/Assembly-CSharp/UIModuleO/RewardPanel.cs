using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using GameModule;
using Il2CppDummyDll;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000AEA")]
	public class RewardPanel : RewardPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AEB")]
		[CompilerGenerated]
		private struct _003CRefreshRewardDisplay_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x400500A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400500B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<float> _003C_003Et__builder;

			[Token(Token = "0x400500C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RewardPanel _003C_003E4__this;

			[Token(Token = "0x400500D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int currentShowToken;

			[Token(Token = "0x400500E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float _003CdelayTime_003E5__2;

			[Token(Token = "0x400500F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private GameObject _003CrewardItemUIPrefab_003E5__3;

			[Token(Token = "0x4005010")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int _003Ci_003E5__4;

			[Token(Token = "0x4005011")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4005012")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6004201")]
			[Address(RVA = "0x41C6AD0", Offset = "0x41C2AD0", VA = "0x41C6AD0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004202")]
			[Address(RVA = "0x41C77C4", Offset = "0x41C37C4", VA = "0x41C77C4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AEC")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4005013")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005014")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005015")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public RewardPanel _003C_003E4__this;

			[Token(Token = "0x4005016")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x4005017")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int _003CcurrentShowToken_003E5__2;

			[Token(Token = "0x4005018")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<float>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4005019")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6004203")]
			[Address(RVA = "0x41C781C", Offset = "0x41C381C", VA = "0x41C781C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004204")]
			[Address(RVA = "0x41C80FC", Offset = "0x41C40FC", VA = "0x41C80FC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RewardConfig rewardConfig;

		[Token(Token = "0x4005006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private List<RewardItemUI> _rewardItemUis;

		[Token(Token = "0x4005007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private List<RewardConfigSingle> _sessionRewardItems;

		[Token(Token = "0x4005008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private int _showToken;

		[Token(Token = "0x4005009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private bool canClose;

		[Token(Token = "0x60041F7")]
		[Address(RVA = "0x41C4814", Offset = "0x41C0814", VA = "0x41C4814", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__5))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60041F8")]
		[Address(RVA = "0x41C48B0", Offset = "0x41C08B0", VA = "0x41C48B0", Slot = "16")]
		protected override void OnButtonExtendBGBtnClicked()
		{
		}

		[Token(Token = "0x60041F9")]
		[Address(RVA = "0x41C49A4", Offset = "0x41C09A4", VA = "0x41C49A4", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60041FA")]
		[Address(RVA = "0x41C50A0", Offset = "0x41C10A0", VA = "0x41C50A0")]
		private void Clear()
		{
		}

		[Token(Token = "0x60041FB")]
		[Address(RVA = "0x41C5278", Offset = "0x41C1278", VA = "0x41C5278")]
		private void AppendSessionRewards(List<RewardConfigSingle> sourceRewards)
		{
		}

		[Token(Token = "0x60041FC")]
		[Address(RVA = "0x41C5428", Offset = "0x41C1428", VA = "0x41C5428")]
		[AsyncStateMachine(typeof(_003CRefreshRewardDisplay_003Ed__10))]
		private UniTask<float> RefreshRewardDisplay(int currentShowToken)
		{
			return default;
		}

		[Token(Token = "0x60041FD")]
		[Address(RVA = "0x41C54F4", Offset = "0x41C14F4", VA = "0x41C54F4")]
		private void ShowSingleReward(RewardConfigSingle reward)
		{
		}

		[Token(Token = "0x60041FE")]
		[Address(RVA = "0x41C4AE4", Offset = "0x41C0AE4", VA = "0x41C4AE4")]
		private void KillAllAnimations()
		{
		}

		[Token(Token = "0x60041FF")]
		[Address(RVA = "0x41C69A8", Offset = "0x41C29A8", VA = "0x41C69A8")]
		public RewardPanel()
		{
		}
	}
}
