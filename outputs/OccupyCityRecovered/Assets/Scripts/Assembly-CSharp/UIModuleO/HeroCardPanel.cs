using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x20007AD")]
	public class HeroCardPanel : HeroCardPanelComponents, IPanelOnOnSecondClick
	{
		[Token(Token = "0x20007AE")]
		private enum ViewType
		{
			[Token(Token = "0x4003B76")]
			HeroCard = 0,
			[Token(Token = "0x4003B77")]
			Artifact = 1,
			[Token(Token = "0x4003B78")]
			Backpack = 2,
			[Token(Token = "0x4003B79")]
			Expression = 3
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007AF")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x4003B7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003B7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003B7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HeroCardPanel _003C_003E4__this;

			[Token(Token = "0x4003B7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002A6E")]
			[Address(RVA = "0x3FD7218", Offset = "0x3FD3218", VA = "0x3FD7218", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002A6F")]
			[Address(RVA = "0x3FD740C", Offset = "0x3FD340C", VA = "0x3FD740C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6002A5E")]
		[Address(RVA = "0x3FD5B14", Offset = "0x3FD1B14", VA = "0x3FD5B14", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002A5F")]
		[Address(RVA = "0x3FD5EE8", Offset = "0x3FD1EE8", VA = "0x3FD5EE8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__2))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002A60")]
		[Address(RVA = "0x3FD5F7C", Offset = "0x3FD1F7C", VA = "0x3FD5F7C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002A61")]
		[Address(RVA = "0x3FD669C", Offset = "0x3FD269C", VA = "0x3FD669C")]
		private void ShowView(ViewType viewType)
		{
		}

		[Token(Token = "0x6002A62")]
		[Address(RVA = "0x3FD6A1C", Offset = "0x3FD2A1C", VA = "0x3FD6A1C")]
		private void ShowHeroCardView()
		{
		}

		[Token(Token = "0x6002A63")]
		[Address(RVA = "0x3FD6C00", Offset = "0x3FD2C00", VA = "0x3FD6C00")]
		private void ShowArtifactView()
		{
		}

		[Token(Token = "0x6002A64")]
		[Address(RVA = "0x3FD6EC0", Offset = "0x3FD2EC0", VA = "0x3FD6EC0")]
		private void ShowBackpackView()
		{
		}

		[Token(Token = "0x6002A65")]
		[Address(RVA = "0x3FD6F98", Offset = "0x3FD2F98", VA = "0x3FD6F98")]
		private void ShowExpressionView()
		{
		}

		[Token(Token = "0x6002A66")]
		[Address(RVA = "0x3FD6564", Offset = "0x3FD2564", VA = "0x3FD6564", Slot = "18")]
		public void OnHide()
		{
		}

		[Token(Token = "0x6002A67")]
		[Address(RVA = "0x3FD688C", Offset = "0x3FD288C", VA = "0x3FD688C")]
		private void ApplyResourceBarVisibilityForCardView(bool showCrystal)
		{
		}

		[Token(Token = "0x6002A68")]
		[Address(RVA = "0x3FD7070", Offset = "0x3FD3070", VA = "0x3FD7070", Slot = "16")]
		public void PanelOnOnSecondClickInit()
		{
		}

		[Token(Token = "0x6002A69")]
		[Address(RVA = "0x3FD7074", Offset = "0x3FD3074", VA = "0x3FD7074", Slot = "17")]
		public void OnSecondClick(object o)
		{
		}

		[Token(Token = "0x6002A6A")]
		[Address(RVA = "0x3FD7164", Offset = "0x3FD3164", VA = "0x3FD7164")]
		public HeroCardPanel()
		{
		}
	}
}
