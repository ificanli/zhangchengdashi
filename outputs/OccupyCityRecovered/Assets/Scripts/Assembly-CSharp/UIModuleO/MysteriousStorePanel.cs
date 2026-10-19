using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using SuperScrollView;

namespace UIModuleO
{
	[Token(Token = "0x20009B0")]
	public class MysteriousStorePanel : MysteriousStorePanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009B1")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x400485B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400485C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400485D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteriousStorePanel _003C_003E4__this;

			[Token(Token = "0x400485E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60039A2")]
			[Address(RVA = "0x4107048", Offset = "0x4103048", VA = "0x4107048", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60039A3")]
			[Address(RVA = "0x41072FC", Offset = "0x41032FC", VA = "0x41072FC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004858")]
		private const string ItemName = "MysteriousStoreItem";

		[Token(Token = "0x4004859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public List<MysteriousStoreData> _itemDatas;

		[Token(Token = "0x400485A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float _checkTimer;

		[Token(Token = "0x600399A")]
		[Address(RVA = "0x4106758", Offset = "0x4102758", VA = "0x4106758", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600399B")]
		[Address(RVA = "0x410698C", Offset = "0x410298C", VA = "0x410698C")]
		private void Update()
		{
		}

		[Token(Token = "0x600399C")]
		[Address(RVA = "0x4106B10", Offset = "0x4102B10", VA = "0x4106B10", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__5))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600399D")]
		[Address(RVA = "0x4106BA4", Offset = "0x4102BA4", VA = "0x4106BA4")]
		private void RefreshView(object o)
		{
		}

		[Token(Token = "0x600399E")]
		[Address(RVA = "0x4106E1C", Offset = "0x4102E1C", VA = "0x4106E1C", Slot = "13")]
		protected override void OnButtonExtendCloseClicked()
		{
		}

		[Token(Token = "0x600399F")]
		[Address(RVA = "0x4106EA8", Offset = "0x4102EA8", VA = "0x4106EA8")]
		private LoopGridViewItem OnGetItem(LoopGridView loopGridView, int index, int row, int column)
		{
			return null;
		}

		[Token(Token = "0x60039A0")]
		[Address(RVA = "0x4106FA0", Offset = "0x4102FA0", VA = "0x4106FA0")]
		public MysteriousStorePanel()
		{
		}
	}
}
