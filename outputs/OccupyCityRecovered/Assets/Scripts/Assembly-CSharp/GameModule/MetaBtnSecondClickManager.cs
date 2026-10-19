using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using ToolModule;

namespace GameModule
{
	[Token(Token = "0x20004EA")]
	public class MetaBtnSecondClickManager : ManagerBase<MetaBtnSecondClickManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004EB")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4002CF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002CF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002CF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MetaBtnSecondClickManager _003C_003E4__this;

			[Token(Token = "0x60018E3")]
			[Address(RVA = "0x3E883DC", Offset = "0x3E843DC", VA = "0x3E883DC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60018E4")]
			[Address(RVA = "0x3E887D0", Offset = "0x3E847D0", VA = "0x3E887D0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004EC")]
		[CompilerGenerated]
		private struct _003CMetaBtnOnSecondClick_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x4002CF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002CF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002CF5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public object o;

			[Token(Token = "0x4002CF6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public MetaBtnSecondClickManager _003C_003E4__this;

			[Token(Token = "0x4002CF7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60018E5")]
			[Address(RVA = "0x3E887DC", Offset = "0x3E847DC", VA = "0x3E887DC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60018E6")]
			[Address(RVA = "0x3E892F8", Offset = "0x3E852F8", VA = "0x3E892F8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002CEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int ShopStep;

		[Token(Token = "0x4002CEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int CardStep;

		[Token(Token = "0x4002CED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int MainStep;

		[Token(Token = "0x4002CEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int CityStep;

		[Token(Token = "0x4002CEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int RankStep;

		[Token(Token = "0x60018DD")]
		[Address(RVA = "0x3E881CC", Offset = "0x3E841CC", VA = "0x3E881CC", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__5))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x60018DE")]
		[Address(RVA = "0x3E88250", Offset = "0x3E84250", VA = "0x3E88250")]
		[AsyncStateMachine(typeof(_003CMetaBtnOnSecondClick_003Ed__6))]
		private void MetaBtnOnSecondClick(object o)
		{
		}

		[Token(Token = "0x60018DF")]
		[Address(RVA = "0x3E882EC", Offset = "0x3E842EC", VA = "0x3E882EC")]
		private void UpdateRankStep(object o)
		{
		}

		[Token(Token = "0x60018E0")]
		[Address(RVA = "0x3E88324", Offset = "0x3E84324", VA = "0x3E88324")]
		private void UpdateCardStep(object o)
		{
		}

		[Token(Token = "0x60018E1")]
		[Address(RVA = "0x3E8835C", Offset = "0x3E8435C", VA = "0x3E8835C")]
		private void UpdateShopStep(object o)
		{
		}

		[Token(Token = "0x60018E2")]
		[Address(RVA = "0x3E88394", Offset = "0x3E84394", VA = "0x3E88394")]
		public MetaBtnSecondClickManager()
		{
		}
	}
}
