using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using GameModule;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000703")]
	public class BattleResultItem : BattleResultItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000704")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__1 : IAsyncStateMachine
		{
			[Token(Token = "0x40037C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40037C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40037C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BattleResultItem _003C_003E4__this;

			[Token(Token = "0x40037CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002610")]
			[Address(RVA = "0x3F8C5BC", Offset = "0x3F885BC", VA = "0x3F8C5BC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002611")]
			[Address(RVA = "0x3F8C79C", Offset = "0x3F8879C", VA = "0x3F8C79C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000705")]
		[CompilerGenerated]
		private struct _003CUpdateInfo_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x40037CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40037CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40037CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BattleResultItem _003C_003E4__this;

			[Token(Token = "0x40037CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public object[] args;

			[Token(Token = "0x40037CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x40037D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002612")]
			[Address(RVA = "0x3F8C7A8", Offset = "0x3F887A8", VA = "0x3F8C7A8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002613")]
			[Address(RVA = "0x3F8D6AC", Offset = "0x3F896AC", VA = "0x3F8D6AC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40037C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private RewardConfigSingle configSingle;

		[Token(Token = "0x600260A")]
		[Address(RVA = "0x3F8C250", Offset = "0x3F88250", VA = "0x3F8C250", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__1))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600260B")]
		[Address(RVA = "0x3F8C2E4", Offset = "0x3F882E4", VA = "0x3F8C2E4", Slot = "9")]
		[AsyncStateMachine(typeof(_003CUpdateInfo_003Ed__2))]
		public override void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x600260C")]
		[Address(RVA = "0x3F8C384", Offset = "0x3F88384", VA = "0x3F8C384", Slot = "12")]
		protected override void OnButtonExtendBattleResultItemClicked()
		{
		}

		[Token(Token = "0x600260D")]
		[Address(RVA = "0x3F8C50C", Offset = "0x3F8850C", VA = "0x3F8C50C")]
		public BattleResultItem()
		{
		}
	}
}
