using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using ToolModule;
using UIFramework;

namespace GameModule
{
	[Token(Token = "0x2000443")]
	public class GamePanelManager : ManagerBase<GamePanelManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000444")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__1 : IAsyncStateMachine
		{
			[Token(Token = "0x4002A18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002A19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002A1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GamePanelManager _003C_003E4__this;

			[Token(Token = "0x4002A1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<UIPanel>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60014AF")]
			[Address(RVA = "0x3E05334", Offset = "0x3E01334", VA = "0x3E05334", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60014B0")]
			[Address(RVA = "0x3E057B0", Offset = "0x3E017B0", VA = "0x3E057B0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002A17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private UIPanel _gamePanel;

		[Token(Token = "0x60014A8")]
		[Address(RVA = "0x3E050A4", Offset = "0x3E010A4", VA = "0x3E050A4", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__1))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x60014A9")]
		[Address(RVA = "0x3E05134", Offset = "0x3E01134", VA = "0x3E05134")]
		public void DoAni()
		{
		}

		[Token(Token = "0x60014AA")]
		[Address(RVA = "0x3E051B0", Offset = "0x3E011B0", VA = "0x3E051B0")]
		public void ShowGamePanel(RankItemData info, string proId)
		{
		}

		[Token(Token = "0x60014AB")]
		[Address(RVA = "0x3E0528C", Offset = "0x3E0128C", VA = "0x3E0528C")]
		public void HideGamePanel()
		{
		}

		[Token(Token = "0x60014AC")]
		[Address(RVA = "0x3E052AC", Offset = "0x3E012AC", VA = "0x3E052AC")]
		public void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x60014AD")]
		[Address(RVA = "0x3E052CC", Offset = "0x3E012CC", VA = "0x3E052CC")]
		private void Hide(object o)
		{
		}

		[Token(Token = "0x60014AE")]
		[Address(RVA = "0x3E052EC", Offset = "0x3E012EC", VA = "0x3E052EC")]
		public GamePanelManager()
		{
		}
	}
}
