using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using ToolModule;

namespace GameModule
{
	[Token(Token = "0x20005D1")]
	public class UpgradeMainTowerManager : ManagerBase<UpgradeMainTowerManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005D3")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x4003153")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003154")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003155")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UpgradeMainTowerManager _003C_003E4__this;

			[Token(Token = "0x6001E73")]
			[Address(RVA = "0x3EF8148", Offset = "0x3EF4148", VA = "0x3EF8148", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001E74")]
			[Address(RVA = "0x3EF84C8", Offset = "0x3EF44C8", VA = "0x3EF84C8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005D4")]
		[CompilerGenerated]
		private struct _003CShowUpgradeMainTowerPanel_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4003156")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003157")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003158")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public object obj;

			[Token(Token = "0x4003159")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public UpgradeMainTowerManager _003C_003E4__this;

			[Token(Token = "0x400315A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001E75")]
			[Address(RVA = "0x3EF84D4", Offset = "0x3EF44D4", VA = "0x3EF84D4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001E76")]
			[Address(RVA = "0x3EF89B0", Offset = "0x3EF49B0", VA = "0x3EF89B0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400314F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private UpgradeMainTowerAnimationType _animationType;

		[Token(Token = "0x4003150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int index;

		[Token(Token = "0x6001E67")]
		[Address(RVA = "0x3EF7668", Offset = "0x3EF3668", VA = "0x3EF7668", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__2))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6001E68")]
		[Address(RVA = "0x3EF76EC", Offset = "0x3EF36EC", VA = "0x3EF76EC")]
		private void HideUpgradeMainTowerPanel(object obj)
		{
		}

		[Token(Token = "0x6001E69")]
		[Address(RVA = "0x3EF76F0", Offset = "0x3EF36F0", VA = "0x3EF76F0")]
		[AsyncStateMachine(typeof(_003CShowUpgradeMainTowerPanel_003Ed__4))]
		private void ShowUpgradeMainTowerPanel(object obj)
		{
		}

		[Token(Token = "0x6001E6A")]
		[Address(RVA = "0x3EF778C", Offset = "0x3EF378C", VA = "0x3EF778C")]
		private void UpgradeMainTowerPanelDoAniEnd(object o)
		{
		}

		[Token(Token = "0x6001E6B")]
		[Address(RVA = "0x3EF7798", Offset = "0x3EF3798", VA = "0x3EF7798")]
		public void UpGradeMainTowerAnimationTypeChange(UpgradeMainTowerAnimationType aniType)
		{
		}

		[Token(Token = "0x6001E6C")]
		[Address(RVA = "0x3EF77A0", Offset = "0x3EF37A0", VA = "0x3EF77A0")]
		public void UpgradeTalent(string id)
		{
		}

		[Token(Token = "0x6001E6D")]
		[Address(RVA = "0x3EF79F4", Offset = "0x3EF39F4", VA = "0x3EF79F4")]
		public int GetMaxTalentLevel()
		{
			return default;
		}

		[Token(Token = "0x6001E6E")]
		[Address(RVA = "0x3EF7B7C", Offset = "0x3EF3B7C", VA = "0x3EF7B7C")]
		public int GetMainTowerTalentInfo()
		{
			return default;
		}

		[Token(Token = "0x6001E6F")]
		[Address(RVA = "0x3EF801C", Offset = "0x3EF401C", VA = "0x3EF801C")]
		public UpgradeMainTowerManager()
		{
		}
	}
}
