using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using GameModule;
using Il2CppDummyDll;
using SuperScrollView;

namespace UIModuleO
{
	[Token(Token = "0x200081D")]
	public class BackpackView : BackpackViewComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200081E")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4003E03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003E04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003E05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BackpackView _003C_003E4__this;

			[Token(Token = "0x4003E06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x4003E07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002D54")]
			[Address(RVA = "0x400CD64", Offset = "0x4008D64", VA = "0x400CD64", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002D55")]
			[Address(RVA = "0x400D174", Offset = "0x4009174", VA = "0x400D174", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003E00")]
		private const string ItemName = "BackpackItem";

		[Token(Token = "0x4003E01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<BackpackData> _backpackData;

		[Token(Token = "0x4003E02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _hasInitLoopView;

		[Token(Token = "0x6002D4D")]
		[Address(RVA = "0x400C684", Offset = "0x4008684", VA = "0x400C684", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002D4E")]
		[Address(RVA = "0x400C6BC", Offset = "0x40086BC", VA = "0x400C6BC", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__4))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002D4F")]
		[Address(RVA = "0x400C758", Offset = "0x4008758", VA = "0x400C758", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002D50")]
		[Address(RVA = "0x400C810", Offset = "0x4008810", VA = "0x400C810")]
		public void RefreshBackpack()
		{
		}

		[Token(Token = "0x6002D51")]
		[Address(RVA = "0x400CB50", Offset = "0x4008B50", VA = "0x400CB50")]
		private LoopGridViewItem OnGetItem(LoopGridView loopGridView, int index, int row, int column)
		{
			return null;
		}

		[Token(Token = "0x6002D52")]
		[Address(RVA = "0x400CCBC", Offset = "0x4008CBC", VA = "0x400CCBC")]
		public BackpackView()
		{
		}
	}
}
