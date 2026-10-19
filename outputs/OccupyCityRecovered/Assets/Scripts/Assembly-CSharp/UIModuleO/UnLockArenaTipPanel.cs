using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using GameModule;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000BD2")]
	public class UnLockArenaTipPanel : UnLockArenaTipPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BD3")]
		[CompilerGenerated]
		private struct _003COnButtonExtendBtnClaimClicked_003Ed__9 : IAsyncStateMachine
		{
			[Token(Token = "0x40055D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40055D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40055D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UnLockArenaTipPanel _003C_003E4__this;

			[Token(Token = "0x40055D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UserBoxData _003Cbox_003E5__2;

			[Token(Token = "0x40055D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private RewardConfig _003Ccofig_003E5__3;

			[Token(Token = "0x40055D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004900")]
			[Address(RVA = "0x424056C", Offset = "0x423C56C", VA = "0x424056C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004901")]
			[Address(RVA = "0x4241528", Offset = "0x423D528", VA = "0x4241528", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BD4")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x40055D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40055DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40055DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UnLockArenaTipPanel _003C_003E4__this;

			[Token(Token = "0x40055DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004902")]
			[Address(RVA = "0x424208C", Offset = "0x423E08C", VA = "0x424208C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004903")]
			[Address(RVA = "0x42423E8", Offset = "0x423E3E8", VA = "0x42423E8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BD5")]
		[CompilerGenerated]
		private struct _003CUpdateInfo_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x40055DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40055DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40055DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UnLockArenaTipPanel _003C_003E4__this;

			[Token(Token = "0x40055E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public object[] args;

			[Token(Token = "0x40055E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x40055E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004904")]
			[Address(RVA = "0x42423F4", Offset = "0x423E3F4", VA = "0x42423F4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004905")]
			[Address(RVA = "0x4244770", Offset = "0x4240770", VA = "0x4244770", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40055CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private GlobalArenaInfo arenaInfo;

		[Token(Token = "0x40055D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private string progressRewardCofig;

		[Token(Token = "0x40055D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private string[] rewardCofigAll;

		[Token(Token = "0x40055D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private List<RewardItemUI> allRewardItemUI;

		[Token(Token = "0x60048F3")]
		[Address(RVA = "0x42400BC", Offset = "0x423C0BC", VA = "0x42400BC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60048F4")]
		[Address(RVA = "0x42401DC", Offset = "0x423C1DC", VA = "0x42401DC", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__5))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60048F5")]
		[Address(RVA = "0x424027C", Offset = "0x423C27C", VA = "0x424027C", Slot = "9")]
		[AsyncStateMachine(typeof(_003CUpdateInfo_003Ed__6))]
		public override void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x60048F6")]
		[Address(RVA = "0x424031C", Offset = "0x423C31C", VA = "0x424031C")]
		private void Update()
		{
		}

		[Token(Token = "0x60048F7")]
		[Address(RVA = "0x4240348", Offset = "0x423C348", VA = "0x4240348")]
		private void UpdateBtn(object o)
		{
		}

		[Token(Token = "0x60048F8")]
		[Address(RVA = "0x4240354", Offset = "0x423C354", VA = "0x4240354", Slot = "15")]
		[AsyncStateMachine(typeof(_003COnButtonExtendBtnClaimClicked_003Ed__9))]
		protected override void OnButtonExtendBtnClaimClicked()
		{
		}

		[Token(Token = "0x60048F9")]
		[Address(RVA = "0x42403E4", Offset = "0x423C3E4", VA = "0x42403E4", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60048FA")]
		[Address(RVA = "0x4240490", Offset = "0x423C490", VA = "0x4240490")]
		public UnLockArenaTipPanel()
		{
		}
	}
}
