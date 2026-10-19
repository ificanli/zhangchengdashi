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
	[Token(Token = "0x20004A5")]
	public class GiftChainManager2 : ManagerBase<GiftChainManager2>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004AC")]
		[CompilerGenerated]
		private struct _003CClearGiftChain_003Ed__14 : IAsyncStateMachine
		{
			[Token(Token = "0x4002BAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002BAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002BB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GiftChainManager2 _003C_003E4__this;

			[Token(Token = "0x4002BB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001750")]
			[Address(RVA = "0x3E58EE4", Offset = "0x3E54EE4", VA = "0x3E58EE4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001751")]
			[Address(RVA = "0x3E59584", Offset = "0x3E55584", VA = "0x3E59584", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004AD")]
		[CompilerGenerated]
		private struct _003CGiftChainBuySuccess_003Ed__11 : IAsyncStateMachine
		{
			[Token(Token = "0x4002BB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002BB3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002BB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public object o;

			[Token(Token = "0x4002BB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GiftChainManager2 _003C_003E4__this;

			[Token(Token = "0x4002BB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001752")]
			[Address(RVA = "0x3E59590", Offset = "0x3E55590", VA = "0x3E59590", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001753")]
			[Address(RVA = "0x3E5A024", Offset = "0x3E56024", VA = "0x3E5A024", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004AE")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x4002BB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002BB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002BB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GiftChainManager2 _003C_003E4__this;

			[Token(Token = "0x6001754")]
			[Address(RVA = "0x3E5A030", Offset = "0x3E56030", VA = "0x3E5A030", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001755")]
			[Address(RVA = "0x3E5A834", Offset = "0x3E56834", VA = "0x3E5A834", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002BA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool isInit;

		[Token(Token = "0x4002BA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TimeManager.Timer cutDown;

		[Token(Token = "0x4002BA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<GlobalGiftChainInfo2> globalGiftChianInfo2;

		[Token(Token = "0x600172F")]
		[Address(RVA = "0x3E57A4C", Offset = "0x3E53A4C", VA = "0x3E57A4C", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__3))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6001730")]
		[Address(RVA = "0x3E57AD0", Offset = "0x3E53AD0", VA = "0x3E57AD0")]
		private void Update()
		{
		}

		[Token(Token = "0x6001731")]
		[Address(RVA = "0x3E57B10", Offset = "0x3E53B10", VA = "0x3E57B10")]
		private void CheckTimeToOpenFridayGiftChain(object o)
		{
		}

		[Token(Token = "0x6001732")]
		[Address(RVA = "0x3E57D4C", Offset = "0x3E53D4C", VA = "0x3E57D4C")]
		public static bool IsCurrentTimeInWeekend()
		{
			return default;
		}

		[Token(Token = "0x6001733")]
		[Address(RVA = "0x3E57EF4", Offset = "0x3E53EF4", VA = "0x3E57EF4")]
		public string GetNowBuyLevel()
		{
			return null;
		}

		[Token(Token = "0x6001734")]
		[Address(RVA = "0x3E58140", Offset = "0x3E54140", VA = "0x3E58140")]
		private bool GetNowBuyIsFree()
		{
			return default;
		}

		[Token(Token = "0x6001735")]
		[Address(RVA = "0x3E58410", Offset = "0x3E54410", VA = "0x3E58410")]
		private void CheckGiftChain2RedDot()
		{
		}

		[Token(Token = "0x6001736")]
		[Address(RVA = "0x3E58488", Offset = "0x3E54488", VA = "0x3E58488")]
		private void BuyGiftChain(object o)
		{
		}

		[Token(Token = "0x6001737")]
		[Address(RVA = "0x3E58654", Offset = "0x3E54654", VA = "0x3E58654")]
		[AsyncStateMachine(typeof(_003CGiftChainBuySuccess_003Ed__11))]
		private void GiftChainBuySuccess(object o)
		{
		}

		[Token(Token = "0x6001738")]
		[Address(RVA = "0x3E586F0", Offset = "0x3E546F0", VA = "0x3E586F0")]
		private void RecordBuy(int level)
		{
		}

		[Token(Token = "0x6001739")]
		[Address(RVA = "0x3E588D0", Offset = "0x3E548D0", VA = "0x3E588D0")]
		public bool GetChainLevelIsBuy(int level)
		{
			return default;
		}

		[Token(Token = "0x600173A")]
		[Address(RVA = "0x3E57E68", Offset = "0x3E53E68", VA = "0x3E57E68")]
		[AsyncStateMachine(typeof(_003CClearGiftChain_003Ed__14))]
		private void ClearGiftChain()
		{
		}

		[Token(Token = "0x600173B")]
		[Address(RVA = "0x3E57AE0", Offset = "0x3E53AE0", VA = "0x3E57AE0")]
		private void CheckGiftChainIsActive()
		{
		}

		[Token(Token = "0x600173C")]
		[Address(RVA = "0x3E58A3C", Offset = "0x3E54A3C", VA = "0x3E58A3C")]
		public string GetGiftChain2CutDownStr()
		{
			return null;
		}

		[Token(Token = "0x600173D")]
		[Address(RVA = "0x3E58A54", Offset = "0x3E54A54", VA = "0x3E58A54")]
		public void ShowGiftChain2Panel([Optional] string placement)
		{
		}

		[Token(Token = "0x600173E")]
		[Address(RVA = "0x3E58B98", Offset = "0x3E54B98", VA = "0x3E58B98")]
		public GiftChainManager2()
		{
		}
	}
}
