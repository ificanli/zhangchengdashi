using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x20007DB")]
	public class ChooseArenaProgressRewardPanel : ChooseArenaProgressRewardPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007DD")]
		[CompilerGenerated]
		private struct _003COnButtonExtendBTnConfirmClicked_003Ed__15 : IAsyncStateMachine
		{
			[Token(Token = "0x4003CAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003CAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003CAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ChooseArenaProgressRewardPanel _003C_003E4__this;

			[Token(Token = "0x4003CAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002BD1")]
			[Address(RVA = "0x3FF22F0", Offset = "0x3FEE2F0", VA = "0x3FF22F0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002BD2")]
			[Address(RVA = "0x3FF2AD8", Offset = "0x3FEEAD8", VA = "0x3FF2AD8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007DE")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x4003CB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003CB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003CB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ChooseArenaProgressRewardPanel _003C_003E4__this;

			[Token(Token = "0x4003CB3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002BD3")]
			[Address(RVA = "0x3FF2AE4", Offset = "0x3FEEAE4", VA = "0x3FF2AE4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002BD4")]
			[Address(RVA = "0x3FF2EF4", Offset = "0x3FEEEF4", VA = "0x3FF2EF4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003CA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private string arenaId;

		[Token(Token = "0x4003CA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private string progressRewardCofig;

		[Token(Token = "0x4003CA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private List<RewardItemUI> allRewardItemUI;

		[Token(Token = "0x4003CA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private string[] rewardCofigAll;

		[Token(Token = "0x4003CA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int nowChoose;

		[Token(Token = "0x4003CA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private bool _isNewTrophyProgress;

		[Token(Token = "0x4003CA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private string _trophyProgressConfigId;

		[Token(Token = "0x6002BC1")]
		[Address(RVA = "0x3FF1468", Offset = "0x3FED468", VA = "0x3FF1468", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002BC2")]
		[Address(RVA = "0x3FF15D8", Offset = "0x3FED5D8", VA = "0x3FF15D8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__8))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002BC3")]
		[Address(RVA = "0x3FF166C", Offset = "0x3FED66C", VA = "0x3FF166C", Slot = "9")]
		public override void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x6002BC4")]
		[Address(RVA = "0x3FF1AD8", Offset = "0x3FEDAD8", VA = "0x3FF1AD8")]
		private void UpdateEff()
		{
		}

		[Token(Token = "0x6002BC5")]
		[Address(RVA = "0x3FF1DC0", Offset = "0x3FEDDC0", VA = "0x3FF1DC0", Slot = "12")]
		protected override void OnButtonExtendBGClicked()
		{
		}

		[Token(Token = "0x6002BC6")]
		[Address(RVA = "0x3FF1E4C", Offset = "0x3FEDE4C", VA = "0x3FF1E4C", Slot = "14")]
		protected override void OnButtonExtendBtnChooseOneClicked()
		{
		}

		[Token(Token = "0x6002BC7")]
		[Address(RVA = "0x3FF1ED4", Offset = "0x3FEDED4", VA = "0x3FF1ED4", Slot = "15")]
		protected override void OnButtonExtendBtnChooseTwoClicked()
		{
		}

		[Token(Token = "0x6002BC8")]
		[Address(RVA = "0x3FF1F60", Offset = "0x3FEDF60", VA = "0x3FF1F60", Slot = "16")]
		protected override void OnButtonExtendBtnChooseThereClicked()
		{
		}

		[Token(Token = "0x6002BC9")]
		[Address(RVA = "0x3FF1FEC", Offset = "0x3FEDFEC", VA = "0x3FF1FEC", Slot = "13")]
		[AsyncStateMachine(typeof(_003COnButtonExtendBTnConfirmClicked_003Ed__15))]
		protected override void OnButtonExtendBTnConfirmClicked()
		{
		}

		[Token(Token = "0x6002BCA")]
		[Address(RVA = "0x3FF2078", Offset = "0x3FEE078", VA = "0x3FF2078")]
		public ChooseArenaProgressRewardPanel()
		{
		}
	}
}
