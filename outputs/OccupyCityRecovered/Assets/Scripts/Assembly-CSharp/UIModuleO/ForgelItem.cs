using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x20007FF")]
	public class ForgelItem : ForgelItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000800")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4003D75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003D76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003D77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ForgelItem _003C_003E4__this;

			[Token(Token = "0x4003D78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UserPropData artifactData;

			[Token(Token = "0x4003D79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string traitId;

			[Token(Token = "0x4003D7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int unlockLevel;

			[Token(Token = "0x4003D7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002CAD")]
			[Address(RVA = "0x40017AC", Offset = "0x3FFD7AC", VA = "0x40017AC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002CAE")]
			[Address(RVA = "0x4001FD4", Offset = "0x3FFDFD4", VA = "0x4001FD4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000801")]
		[CompilerGenerated]
		private struct _003COnButtonExtendForgelItemClicked_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x4003D7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003D7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003D7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ForgelItem _003C_003E4__this;

			[Token(Token = "0x4003D7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002CAF")]
			[Address(RVA = "0x4001FE0", Offset = "0x3FFDFE0", VA = "0x4001FE0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002CB0")]
			[Address(RVA = "0x400243C", Offset = "0x3FFE43C", VA = "0x400243C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003D70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _isLevelUnlocked;

		[Token(Token = "0x4003D71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool _hasTraitInSlot;

		[Token(Token = "0x4003D72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private UserPropData _userData;

		[Token(Token = "0x4003D73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private string _currentTraitId;

		[Token(Token = "0x4003D74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int _unlockLevel;

		[Token(Token = "0x6002CA9")]
		[Address(RVA = "0x40015EC", Offset = "0x3FFD5EC", VA = "0x40015EC")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__5))]
		public UniTask Init(UserPropData artifactData, string traitId, int unlockLevel)
		{
			return default;
		}

		[Token(Token = "0x6002CAA")]
		[Address(RVA = "0x40016A0", Offset = "0x3FFD6A0", VA = "0x40016A0", Slot = "12")]
		[AsyncStateMachine(typeof(_003COnButtonExtendForgelItemClicked_003Ed__6))]
		protected override void OnButtonExtendForgelItemClicked()
		{
		}

		[Token(Token = "0x6002CAB")]
		[Address(RVA = "0x400172C", Offset = "0x3FFD72C", VA = "0x400172C")]
		public ForgelItem()
		{
		}
	}
}
