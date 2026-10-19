using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using ToolModule;

namespace GameModule
{
	[Token(Token = "0x2000501")]
	public class MysteriousStoreManager : ManagerBase<MysteriousStoreManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000503")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__0 : IAsyncStateMachine
		{
			[Token(Token = "0x4002D49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002D4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002D4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteriousStoreManager _003C_003E4__this;

			[Token(Token = "0x6001956")]
			[Address(RVA = "0x3E9229C", Offset = "0x3E8E29C", VA = "0x3E9229C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001957")]
			[Address(RVA = "0x3E92588", Offset = "0x3E8E588", VA = "0x3E92588", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6001940")]
		[Address(RVA = "0x3E902F0", Offset = "0x3E8C2F0", VA = "0x3E902F0", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__0))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6001941")]
		[Address(RVA = "0x3E90374", Offset = "0x3E8C374", VA = "0x3E90374")]
		public string GetMysteriousStoreRefreshTime()
		{
			return null;
		}

		[Token(Token = "0x6001942")]
		[Address(RVA = "0x3E903D0", Offset = "0x3E8C3D0", VA = "0x3E903D0")]
		public void BuyMysteriousStoreItem(int index)
		{
		}

		[Token(Token = "0x6001943")]
		[Address(RVA = "0x3E90494", Offset = "0x3E8C494", VA = "0x3E90494")]
		public void CraterShopCommodity()
		{
		}

		[Token(Token = "0x6001944")]
		[Address(RVA = "0x3E91DF8", Offset = "0x3E8DDF8", VA = "0x3E91DF8")]
		public bool WhetherUnlockedShop()
		{
			return default;
		}

		[Token(Token = "0x6001945")]
		[Address(RVA = "0x3E91EC0", Offset = "0x3E8DEC0", VA = "0x3E91EC0")]
		public int CalculateTheTotalValue(int num, int price, double discount)
		{
			return default;
		}

		[Token(Token = "0x6001946")]
		[Address(RVA = "0x3E910A8", Offset = "0x3E8D0A8", VA = "0x3E910A8")]
		public List<GlobalMysteriousStore> RandomConfigData(int count)
		{
			return null;
		}

		[Token(Token = "0x6001947")]
		[Address(RVA = "0x3E91444", Offset = "0x3E8D444", VA = "0x3E91444")]
		private IGlobalAssetsInfo RandomHeroCard(RareLevel cardLevel)
		{
			return null;
		}

		[Token(Token = "0x6001948")]
		[Address(RVA = "0x3E91A34", Offset = "0x3E8DA34", VA = "0x3E91A34")]
		private IGlobalAssetsInfo RandomArtifact(RareLevel cardLevel)
		{
			return null;
		}

		[Token(Token = "0x6001949")]
		[Address(RVA = "0x3E91F58", Offset = "0x3E8DF58", VA = "0x3E91F58")]
		public MysteriousStoreManager()
		{
		}
	}
}
