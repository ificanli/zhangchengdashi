using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using GameModule;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x20007E1")]
	public class ChooseBoxItem : ChooseBoxItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007E2")]
		[CompilerGenerated]
		private struct _003CInitItem_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x4003CC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003CC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003CC7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ChooseBoxItem _003C_003E4__this;

			[Token(Token = "0x4003CC8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ChooseBoxData boxData;

			[Token(Token = "0x4003CC9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int ID;

			[Token(Token = "0x6002BF3")]
			[Address(RVA = "0x3FF3C88", Offset = "0x3FEFC88", VA = "0x3FF3C88", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002BF4")]
			[Address(RVA = "0x3FF4344", Offset = "0x3FF0344", VA = "0x3FF4344", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007E3")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x4003CCA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003CCB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003CCC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ChooseBoxItem _003C_003E4__this;

			[Token(Token = "0x4003CCD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002BF5")]
			[Address(RVA = "0x3FF4350", Offset = "0x3FF0350", VA = "0x3FF4350", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002BF6")]
			[Address(RVA = "0x3FF4530", Offset = "0x3FF0530", VA = "0x3FF4530", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003CC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int ChooseUI_ID;

		[Token(Token = "0x4003CC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ChooseBoxToUnlockPanel _parentPanel;

		[Token(Token = "0x6002BED")]
		[Address(RVA = "0x3FF37C8", Offset = "0x3FEF7C8", VA = "0x3FF37C8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__2))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002BEE")]
		[Address(RVA = "0x3FF385C", Offset = "0x3FEF85C", VA = "0x3FF385C")]
		[AsyncStateMachine(typeof(_003CInitItem_003Ed__3))]
		public void InitItem(ChooseBoxData boxData, int ID)
		{
		}

		[Token(Token = "0x6002BEF")]
		[Address(RVA = "0x3FF38FC", Offset = "0x3FEF8FC", VA = "0x3FF38FC")]
		public void SetSelected(bool isSelected)
		{
		}

		[Token(Token = "0x6002BF0")]
		[Address(RVA = "0x3FF3A78", Offset = "0x3FEFA78", VA = "0x3FF3A78", Slot = "12")]
		protected override void OnButtonExtendChooseBoxItemClicked()
		{
		}

		[Token(Token = "0x6002BF1")]
		[Address(RVA = "0x3FF3BE0", Offset = "0x3FEFBE0", VA = "0x3FF3BE0")]
		public ChooseBoxItem()
		{
		}
	}
}
