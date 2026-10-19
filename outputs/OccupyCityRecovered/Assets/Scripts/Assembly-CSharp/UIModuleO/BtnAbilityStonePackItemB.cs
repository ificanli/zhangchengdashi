using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DataModule;
using Il2CppDummyDll;
using TimeModuleO;

namespace UIModuleO
{
	[Token(Token = "0x200072B")]
	public class BtnAbilityStonePackItemB : BtnAbilityStonePackItemBComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200072D")]
		[CompilerGenerated]
		private struct _003CUpdateInfo_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x40038A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40038A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40038A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BtnAbilityStonePackItemB _003C_003E4__this;

			[Token(Token = "0x40038A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public object[] args;

			[Token(Token = "0x6002718")]
			[Address(RVA = "0x3F9D1C4", Offset = "0x3F991C4", VA = "0x3F9D1C4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002719")]
			[Address(RVA = "0x3F9DCA8", Offset = "0x3F99CA8", VA = "0x3F9DCA8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40038A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GlobalIAPInfo info;

		[Token(Token = "0x40038A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TimeManager.Timer toMondayTimer;

		[Token(Token = "0x6002710")]
		[Address(RVA = "0x3F9CE0C", Offset = "0x3F98E0C", VA = "0x3F9CE0C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002711")]
		[Address(RVA = "0x3F9CEB0", Offset = "0x3F98EB0", VA = "0x3F9CEB0", Slot = "9")]
		[AsyncStateMachine(typeof(_003CUpdateInfo_003Ed__3))]
		public override void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x6002712")]
		[Address(RVA = "0x3F9CF4C", Offset = "0x3F98F4C", VA = "0x3F9CF4C")]
		private void Update()
		{
		}

		[Token(Token = "0x6002713")]
		[Address(RVA = "0x3F9D080", Offset = "0x3F99080", VA = "0x3F9D080", Slot = "12")]
		protected override void OnButtonExtendBtnAbilityStonePackItemBClicked()
		{
		}

		[Token(Token = "0x6002714")]
		[Address(RVA = "0x3F9D180", Offset = "0x3F99180", VA = "0x3F9D180")]
		public BtnAbilityStonePackItemB()
		{
		}
	}
}
