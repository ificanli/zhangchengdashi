using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using GameModule;
using Il2CppDummyDll;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000899")]
	public class FundRewardItem : FundRewardItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200089C")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4004140")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004141")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004142")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FundRewardItem _003C_003E4__this;

			[Token(Token = "0x4004143")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60030BD")]
			[Address(RVA = "0x4052F94", Offset = "0x404EF94", VA = "0x4052F94", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60030BE")]
			[Address(RVA = "0x405362C", Offset = "0x404F62C", VA = "0x405362C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private string key;

		[Token(Token = "0x4004132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int level;

		[Token(Token = "0x4004133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private bool isActivityEnough;

		[Token(Token = "0x4004134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
		private bool isRewardAvailable;

		[Token(Token = "0x4004135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<FundManager.HWRewardItem> rewards;

		[Token(Token = "0x4004136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool canClaim;

		[Token(Token = "0x4004137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<GameObject> allItems;

		[Token(Token = "0x4004138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FundData fundData;

		[Token(Token = "0x4004139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private FundItem fundItem;

		[Token(Token = "0x60030AF")]
		[Address(RVA = "0x4051B20", Offset = "0x404DB20", VA = "0x4051B20", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60030B0")]
		[Address(RVA = "0x4051C80", Offset = "0x404DC80", VA = "0x4051C80", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__10))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60030B1")]
		[Address(RVA = "0x4051D14", Offset = "0x404DD14", VA = "0x4051D14")]
		private void ShowCollectTween(object o)
		{
		}

		[Token(Token = "0x60030B2")]
		[Address(RVA = "0x4052388", Offset = "0x404E388", VA = "0x4052388", Slot = "13")]
		protected override void OnButtonExtendClaimBtnClicked()
		{
		}

		[Token(Token = "0x60030B3")]
		[Address(RVA = "0x405240C", Offset = "0x404E40C", VA = "0x405240C")]
		private void Claim()
		{
		}

		[Token(Token = "0x60030B4")]
		[Address(RVA = "0x40524A0", Offset = "0x404E4A0", VA = "0x40524A0")]
		public void CreatItems()
		{
		}

		[Token(Token = "0x60030B5")]
		[Address(RVA = "0x4052B8C", Offset = "0x404EB8C", VA = "0x4052B8C")]
		public FundRewardItem()
		{
		}
	}
}
