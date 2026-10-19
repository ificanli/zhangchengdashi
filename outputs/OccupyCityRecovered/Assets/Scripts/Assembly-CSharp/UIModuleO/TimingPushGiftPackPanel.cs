using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using GameModule;
using Il2CppDummyDll;
using TimeModuleO;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000B9F")]
	public class TimingPushGiftPackPanel : TimingPushGiftPackPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BA1")]
		[CompilerGenerated]
		private struct _003CAwake_003Ed__11 : IAsyncStateMachine
		{
			[Token(Token = "0x4005471")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005472")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TimingPushGiftPackPanel _003C_003E4__this;

			[Token(Token = "0x4005474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004755")]
			[Address(RVA = "0x4221E10", Offset = "0x421DE10", VA = "0x4221E10", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004756")]
			[Address(RVA = "0x4222398", Offset = "0x421E398", VA = "0x4222398", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BA2")]
		[CompilerGenerated]
		private struct _003CBuyGiftPackSuccess_003Ed__27 : IAsyncStateMachine
		{
			[Token(Token = "0x4005475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005476")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005477")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TimingPushGiftPackPanel _003C_003E4__this;

			[Token(Token = "0x6004757")]
			[Address(RVA = "0x42223A4", Offset = "0x421E3A4", VA = "0x42223A4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004758")]
			[Address(RVA = "0x4222474", Offset = "0x421E474", VA = "0x4222474", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BA3")]
		[CompilerGenerated]
		private struct _003CRewardFlyCollectAnimation_003Ed__30 : IAsyncStateMachine
		{
			[Token(Token = "0x4005478")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005479")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400547A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TimingPushGiftPackPanel _003C_003E4__this;

			[Token(Token = "0x400547B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector2 _003CtarPos2_003E5__2;

			[Token(Token = "0x400547C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector2 _003CtarPos1_003E5__3;

			[Token(Token = "0x400547D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector2 _003CtarPos3_003E5__4;

			[Token(Token = "0x400547E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004759")]
			[Address(RVA = "0x4222480", Offset = "0x421E480", VA = "0x4222480", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600475A")]
			[Address(RVA = "0x4223354", Offset = "0x421F354", VA = "0x4223354", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BA4")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__12 : IAsyncStateMachine
		{
			[Token(Token = "0x400547F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005481")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TimingPushGiftPackPanel _003C_003E4__this;

			[Token(Token = "0x4005482")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x4005483")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4005484")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Image _003C_003E7__wrap2;

			[Token(Token = "0x4005485")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Image _003C_003E7__wrap3;

			[Token(Token = "0x4005486")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600475B")]
			[Address(RVA = "0x4223360", Offset = "0x421F360", VA = "0x4223360", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600475C")]
			[Address(RVA = "0x4225BF4", Offset = "0x4221BF4", VA = "0x4225BF4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400545F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private ShopManager.TimingPushGiftPackType nowPushGiftPackType;

		[Token(Token = "0x4005460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private string nowPushGiftPackIAPID;

		[Token(Token = "0x4005461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private string _placement;

		[Token(Token = "0x4005462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private TimeManager.Timer giftPackagePushCountdownTimer;

		[Token(Token = "0x4005463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private string lendaryID;

		[Token(Token = "0x4005464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private string epicID;

		[Token(Token = "0x4005465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private string rareID;

		[Token(Token = "0x4005466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private GameObject lendaryObj;

		[Token(Token = "0x4005467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private GameObject epicObj;

		[Token(Token = "0x4005468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private GameObject rareObj;

		[Token(Token = "0x4005469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private GameObject res;

		[Token(Token = "0x400546A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float cooldown;

		[Token(Token = "0x400546B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float timecount;

		[Token(Token = "0x6004737")]
		[Address(RVA = "0x422004C", Offset = "0x421C04C", VA = "0x422004C", Slot = "4")]
		[AsyncStateMachine(typeof(_003CAwake_003Ed__11))]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004738")]
		[Address(RVA = "0x42200DC", Offset = "0x421C0DC", VA = "0x42200DC", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__12))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004739")]
		[Address(RVA = "0x422017C", Offset = "0x421C17C", VA = "0x422017C")]
		private void PushGiftPackCutDownEnd(object o)
		{
		}

		[Token(Token = "0x600473A")]
		[Address(RVA = "0x422021C", Offset = "0x421C21C", VA = "0x422021C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600473B")]
		[Address(RVA = "0x4220224", Offset = "0x421C224", VA = "0x4220224")]
		private void Update()
		{
		}

		[Token(Token = "0x600473C")]
		[Address(RVA = "0x422037C", Offset = "0x421C37C", VA = "0x422037C", Slot = "14")]
		protected override void OnButtonExtendBtnChoose1Clicked()
		{
		}

		[Token(Token = "0x600473D")]
		[Address(RVA = "0x4220560", Offset = "0x421C560", VA = "0x4220560", Slot = "15")]
		protected override void OnButtonExtendBtnChoose2Clicked()
		{
		}

		[Token(Token = "0x600473E")]
		[Address(RVA = "0x4220744", Offset = "0x421C744", VA = "0x4220744", Slot = "16")]
		protected override void OnButtonExtendBtnChoose3Clicked()
		{
		}

		[Token(Token = "0x600473F")]
		[Address(RVA = "0x4220928", Offset = "0x421C928", VA = "0x4220928", Slot = "17")]
		protected override void OnButtonExtendBtnBuyClicked()
		{
		}

		[Token(Token = "0x6004740")]
		[Address(RVA = "0x4220B78", Offset = "0x421CB78", VA = "0x4220B78")]
		private string GetRewardCofig(bool isCard, string[] rewardId)
		{
			return null;
		}

		[Token(Token = "0x6004741")]
		[Address(RVA = "0x4220D5C", Offset = "0x421CD5C", VA = "0x4220D5C")]
		private void RecordSSSR(object o)
		{
		}

		[Token(Token = "0x6004742")]
		[Address(RVA = "0x42211E8", Offset = "0x421D1E8", VA = "0x42211E8")]
		private void RecordSSR(object o)
		{
		}

		[Token(Token = "0x6004743")]
		[Address(RVA = "0x4221350", Offset = "0x421D350", VA = "0x4221350")]
		private void RecordSR(object o)
		{
		}

		[Token(Token = "0x6004744")]
		[Address(RVA = "0x4220EC4", Offset = "0x421CEC4", VA = "0x4220EC4")]
		private void InitCard(string id, RareLevel rareLevel, ref GameObject obj)
		{
		}

		[Token(Token = "0x6004745")]
		[Address(RVA = "0x4221580", Offset = "0x421D580", VA = "0x4221580")]
		[AsyncStateMachine(typeof(_003CBuyGiftPackSuccess_003Ed__27))]
		private void BuyGiftPackSuccess(object o)
		{
		}

		[Token(Token = "0x6004746")]
		[Address(RVA = "0x422160C", Offset = "0x421D60C", VA = "0x422160C", Slot = "12")]
		protected override void OnButtonExtendBGClicked()
		{
		}

		[Token(Token = "0x6004747")]
		[Address(RVA = "0x4221698", Offset = "0x421D698", VA = "0x4221698", Slot = "13")]
		protected override void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x6004748")]
		[Address(RVA = "0x4221724", Offset = "0x421D724", VA = "0x4221724")]
		[AsyncStateMachine(typeof(_003CRewardFlyCollectAnimation_003Ed__30))]
		private UniTask RewardFlyCollectAnimation()
		{
			return default;
		}

		[Token(Token = "0x6004749")]
		[Address(RVA = "0x42217B4", Offset = "0x421D7B4", VA = "0x42217B4", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600474A")]
		[Address(RVA = "0x422197C", Offset = "0x421D97C", VA = "0x422197C")]
		private void Clear()
		{
		}

		[Token(Token = "0x600474B")]
		[Address(RVA = "0x4221A1C", Offset = "0x421DA1C", VA = "0x4221A1C")]
		public TimingPushGiftPackPanel()
		{
		}
	}
}
