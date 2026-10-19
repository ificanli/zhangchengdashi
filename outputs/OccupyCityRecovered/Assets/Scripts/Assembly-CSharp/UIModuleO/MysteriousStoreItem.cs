using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using GameModule;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x20009AC")]
	public class MysteriousStoreItem : MysteriousStoreItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009AD")]
		[CompilerGenerated]
		private struct _003COnButtonExtendMysteriousStoreItemClicked_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4004849")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400484A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400484B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MysteriousStoreItem _003C_003E4__this;

			[Token(Token = "0x400484C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003988")]
			[Address(RVA = "0x4105DD0", Offset = "0x4101DD0", VA = "0x4105DD0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003989")]
			[Address(RVA = "0x4106230", Offset = "0x4102230", VA = "0x4106230", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private MysteriousStoreData _data;

		[Token(Token = "0x4004847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private RewardConfig _rewardConfig;

		[Token(Token = "0x4004848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int price;

		[Token(Token = "0x6003984")]
		[Address(RVA = "0x4105178", Offset = "0x4101178", VA = "0x4105178")]
		public void InitItem(MysteriousStoreData data)
		{
		}

		[Token(Token = "0x6003985")]
		[Address(RVA = "0x4105CC4", Offset = "0x4101CC4", VA = "0x4105CC4", Slot = "12")]
		[AsyncStateMachine(typeof(_003COnButtonExtendMysteriousStoreItemClicked_003Ed__4))]
		protected override void OnButtonExtendMysteriousStoreItemClicked()
		{
		}

		[Token(Token = "0x6003986")]
		[Address(RVA = "0x4105D50", Offset = "0x4101D50", VA = "0x4105D50")]
		public MysteriousStoreItem()
		{
		}
	}
}
