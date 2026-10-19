using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using GameModule;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000B96")]
	public class SubMetaSwitchBtn : SubMetaSwitchBtnComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B97")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x4005445")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005446")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005447")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SubMetaSwitchBtn _003C_003E4__this;

			[Token(Token = "0x4005448")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004715")]
			[Address(RVA = "0x421EEBC", Offset = "0x421AEBC", VA = "0x421EEBC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004716")]
			[Address(RVA = "0x421F09C", Offset = "0x421B09C", VA = "0x421F09C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Action onButtonDown;

		[Token(Token = "0x4005444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private FeatureUnlockEntity featureUnlockEntity;

		[Token(Token = "0x600470C")]
		[Address(RVA = "0x421E738", Offset = "0x421A738", VA = "0x421E738", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600470D")]
		[Address(RVA = "0x421E8E0", Offset = "0x421A8E0", VA = "0x421E8E0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__3))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600470E")]
		[Address(RVA = "0x421E974", Offset = "0x421A974", VA = "0x421E974")]
		public void UpdateName()
		{
		}

		[Token(Token = "0x600470F")]
		[Address(RVA = "0x421EB0C", Offset = "0x421AB0C", VA = "0x421EB0C")]
		public void RegisterOnMouseDown(Action action)
		{
		}

		[Token(Token = "0x6004710")]
		[Address(RVA = "0x421EB8C", Offset = "0x421AB8C", VA = "0x421EB8C")]
		public void UnRegisterOnMouseDown(Action action)
		{
		}

		[Token(Token = "0x6004711")]
		[Address(RVA = "0x421EC0C", Offset = "0x421AC0C", VA = "0x421EC0C", Slot = "12")]
		protected override void OnButtonExtendSubMetaSwitchBtnClicked()
		{
		}

		[Token(Token = "0x6004712")]
		[Address(RVA = "0x421ED1C", Offset = "0x421AD1C", VA = "0x421ED1C")]
		public SubMetaSwitchBtn()
		{
		}
	}
}
