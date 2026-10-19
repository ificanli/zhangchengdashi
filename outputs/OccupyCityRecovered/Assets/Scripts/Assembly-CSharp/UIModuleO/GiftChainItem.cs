using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x20008E6")]
	public class GiftChainItem : GiftChainItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008E7")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4004361")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004362")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GiftChainItem _003C_003E4__this;

			[Token(Token = "0x4004364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003347")]
			[Address(RVA = "0x4096C7C", Offset = "0x4092C7C", VA = "0x4096C7C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003348")]
			[Address(RVA = "0x4096E5C", Offset = "0x4092E5C", VA = "0x4096E5C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008E8")]
		[CompilerGenerated]
		private struct _003CUpdateItemInfo_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x4004365")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GiftChainItem _003C_003E4__this;

			[Token(Token = "0x4004368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int index;

			[Token(Token = "0x4004369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string chainKey;

			[Token(Token = "0x400436A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string placement;

			[Token(Token = "0x400436B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string rewardData;

			[Token(Token = "0x400436C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string rewardName;

			[Token(Token = "0x400436D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public string iapId;

			[Token(Token = "0x6003349")]
			[Address(RVA = "0x4096E68", Offset = "0x4092E68", VA = "0x4096E68", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600334A")]
			[Address(RVA = "0x4097C24", Offset = "0x4093C24", VA = "0x4097C24", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400435C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int buyId;

		[Token(Token = "0x400435D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int index;

		[Token(Token = "0x400435E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private string chainKey;

		[Token(Token = "0x400435F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private string _placement;

		[Token(Token = "0x4004360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private List<GameObject> items;

		[Token(Token = "0x6003341")]
		[Address(RVA = "0x4095FC8", Offset = "0x4091FC8", VA = "0x4095FC8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__5))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003342")]
		[Address(RVA = "0x409605C", Offset = "0x409205C", VA = "0x409605C")]
		[AsyncStateMachine(typeof(_003CUpdateItemInfo_003Ed__6))]
		public void UpdateItemInfo(int index, string rewardData, string chainKey, string rewardName, string iapId, string placement)
		{
		}

		[Token(Token = "0x6003343")]
		[Address(RVA = "0x409612C", Offset = "0x409212C", VA = "0x409612C")]
		public void UpdateUI(int index)
		{
		}

		[Token(Token = "0x6003344")]
		[Address(RVA = "0x4096998", Offset = "0x4092998", VA = "0x4096998", Slot = "12")]
		protected override void OnButtonExtendBuyClicked()
		{
		}

		[Token(Token = "0x6003345")]
		[Address(RVA = "0x4096B44", Offset = "0x4092B44", VA = "0x4096B44")]
		public GiftChainItem()
		{
		}
	}
}
