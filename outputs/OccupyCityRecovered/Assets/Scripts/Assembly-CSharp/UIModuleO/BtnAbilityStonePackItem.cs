using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using TimeModuleO;

namespace UIModuleO
{
	[Token(Token = "0x2000727")]
	public class BtnAbilityStonePackItem : BtnAbilityStonePackItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000729")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x400389A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400389B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400389C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BtnAbilityStonePackItem _003C_003E4__this;

			[Token(Token = "0x400389D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600270C")]
			[Address(RVA = "0x3F9C2B4", Offset = "0x3F982B4", VA = "0x3F9C2B4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600270D")]
			[Address(RVA = "0x3F9C498", Offset = "0x3F98498", VA = "0x3F9C498", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200072A")]
		[CompilerGenerated]
		private struct _003CUpdateInfo_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x400389E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400389F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40038A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BtnAbilityStonePackItem _003C_003E4__this;

			[Token(Token = "0x40038A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public object[] args;

			[Token(Token = "0x600270E")]
			[Address(RVA = "0x3F9C4A4", Offset = "0x3F984A4", VA = "0x3F9C4A4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600270F")]
			[Address(RVA = "0x3F9CE00", Offset = "0x3F98E00", VA = "0x3F9CE00", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GlobalIAPInfo info;

		[Token(Token = "0x4003895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TimeManager.Timer toMondayTimer;

		[Token(Token = "0x4003896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private RewardItemUI itemUI;

		[Token(Token = "0x4003897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float cooldown;

		[Token(Token = "0x4003898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float timecount;

		[Token(Token = "0x6002700")]
		[Address(RVA = "0x3F9B954", Offset = "0x3F97954", VA = "0x3F9B954", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002701")]
		[Address(RVA = "0x3F9BA04", Offset = "0x3F97A04", VA = "0x3F9BA04", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__4))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002702")]
		[Address(RVA = "0x3F9BAA4", Offset = "0x3F97AA4", VA = "0x3F9BAA4", Slot = "9")]
		[AsyncStateMachine(typeof(_003CUpdateInfo_003Ed__5))]
		public override void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x6002703")]
		[Address(RVA = "0x3F9BB40", Offset = "0x3F97B40", VA = "0x3F9BB40")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6002704")]
		[Address(RVA = "0x3F9BB48", Offset = "0x3F97B48", VA = "0x3F9BB48")]
		private void Update()
		{
		}

		[Token(Token = "0x6002705")]
		[Address(RVA = "0x3F9BBE8", Offset = "0x3F97BE8", VA = "0x3F9BBE8", Slot = "12")]
		protected override void OnButtonExtendBtnAbilityStonePackItemClicked()
		{
		}

		[Token(Token = "0x6002706")]
		[Address(RVA = "0x3F9BE20", Offset = "0x3F97E20", VA = "0x3F9BE20")]
		public BtnAbilityStonePackItem()
		{
		}
	}
}
