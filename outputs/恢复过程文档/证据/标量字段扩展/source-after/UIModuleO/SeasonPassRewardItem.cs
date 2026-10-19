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
	[Token(Token = "0x2000AFC")]
	public class SeasonPassRewardItem : SeasonPassRewardItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AFD")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__11 : IAsyncStateMachine
		{
			[Token(Token = "0x400508F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005090")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005091")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SeasonPassRewardItem _003C_003E4__this;

			[Token(Token = "0x4005092")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004294")]
			[Address(RVA = "0x41D0BA0", Offset = "0x41CCBA0", VA = "0x41D0BA0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004295")]
			[Address(RVA = "0x41D14DC", Offset = "0x41CD4DC", VA = "0x41D14DC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Sprite bg_Color;

		[Token(Token = "0x4005088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Sprite bg_gray;

		[Token(Token = "0x4005089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool autoUpdateBG;

		[Token(Token = "0x400508A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		public bool showRewardState;

		[Token(Token = "0x400508B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
		public bool showCanClaimAnimation;

		[Token(Token = "0x400508C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private string iapId;

		[Token(Token = "0x400508D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int itemLevel;

		[Token(Token = "0x400508E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private FundManager.HWRewardItem currentShowItem;

		[Token(Token = "0x17000AB5")]
		public int ItemLevel
		{
			[Token(Token = "0x600428C")]
			[Address(RVA = "0x41D03B8", Offset = "0x41CC3B8", VA = "0x41D03B8")]
			get
			{
				return itemLevel;
			}
		}

		[Token(Token = "0x600428D")]
		[Address(RVA = "0x41D03C0", Offset = "0x41CC3C0", VA = "0x41D03C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600428E")]
		[Address(RVA = "0x41D04B8", Offset = "0x41CC4B8", VA = "0x41D04B8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__11))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600428F")]
		[Address(RVA = "0x41D054C", Offset = "0x41CC54C", VA = "0x41D054C")]
		private void UpdateRewardItem(FundManager.HWRewardItem firstOrDefault, bool canClaim, bool hadClaimed)
		{
		}

		[Token(Token = "0x6004290")]
		[Address(RVA = "0x41D06BC", Offset = "0x41CC6BC", VA = "0x41D06BC")]
		private void UpdateItemState(bool levelEnough, bool hadBuy, bool canClaim)
		{
		}

		[Token(Token = "0x6004291")]
		[Address(RVA = "0x41D09F0", Offset = "0x41CC9F0", VA = "0x41D09F0", Slot = "13")]
		protected override void OnButtonExtendClaimBtn1Clicked()
		{
		}

		[Token(Token = "0x6004292")]
		[Address(RVA = "0x41D0AE8", Offset = "0x41CCAE8", VA = "0x41D0AE8")]
		public SeasonPassRewardItem()
		{
		}
	}
}
