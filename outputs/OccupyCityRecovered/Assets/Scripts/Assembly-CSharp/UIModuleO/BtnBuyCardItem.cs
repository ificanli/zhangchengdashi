using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000B11")]
	public class BtnBuyCardItem : BtnBuyCardItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B12")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x40050F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40050F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40050FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BtnBuyCardItem _003C_003E4__this;

			[Token(Token = "0x40050FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public UserDailyShopCardData data;

			[Token(Token = "0x40050FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public GlobalShopInfo shopInfo;

			[Token(Token = "0x6004353")]
			[Address(RVA = "0x41DA2E4", Offset = "0x41D62E4", VA = "0x41DA2E4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004354")]
			[Address(RVA = "0x41DAEAC", Offset = "0x41D6EAC", VA = "0x41DAEAC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B13")]
		[CompilerGenerated]
		private struct _003CUpdateInfo_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x40050FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40050FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40050FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BtnBuyCardItem _003C_003E4__this;

			[Token(Token = "0x4005100")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public object[] args;

			[Token(Token = "0x4005101")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private GlobalHeroCardInfo _003Cinfo_003E5__2;

			[Token(Token = "0x4005102")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4005103")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6004355")]
			[Address(RVA = "0x41DAEB8", Offset = "0x41D6EB8", VA = "0x41DAEB8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004356")]
			[Address(RVA = "0x41DBFD0", Offset = "0x41D7FD0", VA = "0x41DBFD0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B14")]
		[CompilerGenerated]
		private struct _003CUpdateUI_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x4005104")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005105")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005106")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BtnBuyCardItem _003C_003E4__this;

			[Token(Token = "0x6004357")]
			[Address(RVA = "0x41DBFDC", Offset = "0x41D7FDC", VA = "0x41DBFDC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004358")]
			[Address(RVA = "0x41DC308", Offset = "0x41D8308", VA = "0x41DC308", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40050F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private UserDailyShopCardData data;

		[Token(Token = "0x40050F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private GlobalShopInfo shopInfo;

		[Token(Token = "0x40050F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private GameObject obj;

		[Token(Token = "0x40050F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool isListeningShopBuyCardSuccess;

		[Token(Token = "0x6004344")]
		[Address(RVA = "0x41D9508", Offset = "0x41D5508", VA = "0x41D9508")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__4))]
		public void Init(GlobalShopInfo shopInfo, UserDailyShopCardData data)
		{
		}

		[Token(Token = "0x6004345")]
		[Address(RVA = "0x41D95A8", Offset = "0x41D55A8", VA = "0x41D95A8", Slot = "9")]
		[AsyncStateMachine(typeof(_003CUpdateInfo_003Ed__5))]
		public override void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x6004346")]
		[Address(RVA = "0x41D9644", Offset = "0x41D5644", VA = "0x41D9644")]
		private void ShopBuyCardSuccess(object o)
		{
		}

		[Token(Token = "0x6004347")]
		[Address(RVA = "0x41D96E8", Offset = "0x41D56E8", VA = "0x41D96E8")]
		[AsyncStateMachine(typeof(_003CUpdateUI_003Ed__7))]
		public void UpdateUI()
		{
		}

		[Token(Token = "0x6004348")]
		[Address(RVA = "0x41D9774", Offset = "0x41D5774", VA = "0x41D9774", Slot = "12")]
		protected override void OnButtonExtendBtnBuyCardItemClicked()
		{
		}

		[Token(Token = "0x6004349")]
		[Address(RVA = "0x41D9994", Offset = "0x41D5994", VA = "0x41D9994")]
		private void DailyAdCallBack()
		{
		}

		[Token(Token = "0x600434A")]
		[Address(RVA = "0x41D9CF8", Offset = "0x41D5CF8", VA = "0x41D9CF8")]
		private void EpicCardCallBack()
		{
		}

		[Token(Token = "0x600434B")]
		[Address(RVA = "0x41D9F40", Offset = "0x41D5F40", VA = "0x41D9F40")]
		private void RegisterShopBuyCardSuccessEvent()
		{
		}

		[Token(Token = "0x600434C")]
		[Address(RVA = "0x41DA01C", Offset = "0x41D601C", VA = "0x41DA01C")]
		private void UnregisterShopBuyCardSuccessEvent()
		{
		}

		[Token(Token = "0x600434D")]
		[Address(RVA = "0x41DA11C", Offset = "0x41D611C", VA = "0x41DA11C")]
		private void StopGraphicColorTweens()
		{
		}

		[Token(Token = "0x600434E")]
		[Address(RVA = "0x41DA26C", Offset = "0x41D626C", VA = "0x41DA26C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600434F")]
		[Address(RVA = "0x41DA284", Offset = "0x41D6284", VA = "0x41DA284")]
		public BtnBuyCardItem()
		{
		}
	}
}
