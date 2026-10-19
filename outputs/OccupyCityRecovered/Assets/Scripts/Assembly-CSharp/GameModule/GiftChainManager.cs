using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using TimeModuleO;
using ToolModule;

namespace GameModule
{
	[Token(Token = "0x20004A3")]
	public class GiftChainManager : ManagerBase<GiftChainManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004A4")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x4002B9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002BA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002BA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GiftChainManager _003C_003E4__this;

			[Token(Token = "0x600172D")]
			[Address(RVA = "0x3E572FC", Offset = "0x3E532FC", VA = "0x3E572FC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600172E")]
			[Address(RVA = "0x3E57A40", Offset = "0x3E53A40", VA = "0x3E57A40", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002B9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Dictionary<string, TimeManager.Timer> curOpenGiftChain;

		[Token(Token = "0x4002B9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isInit;

		[Token(Token = "0x4002B9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float lastTriggerPurchaseProductTime;

		[Token(Token = "0x600171F")]
		[Address(RVA = "0x3E55F00", Offset = "0x3E51F00", VA = "0x3E55F00", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__2))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6001720")]
		[Address(RVA = "0x3E55F84", Offset = "0x3E51F84", VA = "0x3E55F84")]
		private void Update()
		{
		}

		[Token(Token = "0x6001721")]
		[Address(RVA = "0x3E56574", Offset = "0x3E52574", VA = "0x3E56574")]
		public bool GetGiftChainInfoById(string chainName, out int buyId, out List<GlobalGiftChainInfo> chainConfig)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED GiftChainManager.GetGiftChainInfoById RVA=0x3E56574 Token=0x6001721");
}

		[Token(Token = "0x6001722")]
		[Address(RVA = "0x3E566E4", Offset = "0x3E526E4", VA = "0x3E566E4")]
		public bool GetGiftChainBuyId(string chainName, out int buyId)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED GiftChainManager.GetGiftChainBuyId RVA=0x3E566E4 Token=0x6001722");
}

		[Token(Token = "0x6001723")]
		[Address(RVA = "0x3E56644", Offset = "0x3E52644", VA = "0x3E56644")]
		public bool GetGiftChainConfigById(string chainName, out List<GlobalGiftChainInfo> chainConfig)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED GiftChainManager.GetGiftChainConfigById RVA=0x3E56644 Token=0x6001723");
}

		[Token(Token = "0x6001724")]
		[Address(RVA = "0x3E56788", Offset = "0x3E52788", VA = "0x3E56788")]
		public void AddGiftChainBuyId(string chainName)
		{
		}

		[Token(Token = "0x6001725")]
		[Address(RVA = "0x3E55F94", Offset = "0x3E51F94", VA = "0x3E55F94")]
		private void CheckTimeToCloseGiftChain()
		{
		}

		[Token(Token = "0x6001726")]
		[Address(RVA = "0x3E568C0", Offset = "0x3E528C0", VA = "0x3E568C0")]
		public bool CheckTimeToOpenSaturdayGiftChain()
		{
			return default;
		}

		[Token(Token = "0x6001727")]
		[Address(RVA = "0x3E569BC", Offset = "0x3E529BC", VA = "0x3E569BC")]
		public void OpenGiftChain(string chainName, TimeSpan durationTime)
		{
		}

		[Token(Token = "0x6001728")]
		[Address(RVA = "0x3E56CA4", Offset = "0x3E52CA4", VA = "0x3E56CA4")]
		public List<string> GetAllOpenGiftChain()
		{
			return null;
		}

		[Token(Token = "0x6001729")]
		[Address(RVA = "0x3E56F14", Offset = "0x3E52F14", VA = "0x3E56F14")]
		public void GiftChainBuy(object o)
		{
		}

		[Token(Token = "0x600172A")]
		[Address(RVA = "0x3E5719C", Offset = "0x3E5319C", VA = "0x3E5719C")]
		public void GiftChainBuySuccess(object o)
		{
		}

		[Token(Token = "0x600172B")]
		[Address(RVA = "0x3E572B0", Offset = "0x3E532B0", VA = "0x3E572B0")]
		public GiftChainManager()
		{
		}
	}
}
