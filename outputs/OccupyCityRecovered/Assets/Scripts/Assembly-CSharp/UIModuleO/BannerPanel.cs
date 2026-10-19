using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using SuperScrollView;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20006F5")]
	public class BannerPanel : BannerPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006F6")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x400376E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400376F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BannerPanel _003C_003E4__this;

			[Token(Token = "0x4003771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x4003772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4003773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60025A7")]
			[Address(RVA = "0x3F88AF8", Offset = "0x3F84AF8", VA = "0x3F88AF8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60025A8")]
			[Address(RVA = "0x3F89C2C", Offset = "0x3F85C2C", VA = "0x3F89C2C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400376D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<string> bannerList;

		[Token(Token = "0x600259D")]
		[Address(RVA = "0x3F881E4", Offset = "0x3F841E4", VA = "0x3F881E4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600259E")]
		[Address(RVA = "0x3F88500", Offset = "0x3F84500", VA = "0x3F88500", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__2))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600259F")]
		[Address(RVA = "0x3F8859C", Offset = "0x3F8459C", VA = "0x3F8859C", Slot = "8")]
		protected override void OnOpenAnimationComplete()
		{
		}

		[Token(Token = "0x60025A0")]
		[Address(RVA = "0x3F88708", Offset = "0x3F84708", VA = "0x3F88708", Slot = "12")]
		protected override void OnButtonBackgroundClicked()
		{
		}

		[Token(Token = "0x60025A1")]
		[Address(RVA = "0x3F88794", Offset = "0x3F84794", VA = "0x3F88794", Slot = "13")]
		protected override void OnButtonExtendCloseClicked()
		{
		}

		[Token(Token = "0x60025A2")]
		[Address(RVA = "0x3F88820", Offset = "0x3F84820", VA = "0x3F88820")]
		private LoopGridViewItem OnGetItemByRowColumn(LoopGridView gridView, int index, int row, int column)
		{
			return null;
		}

		[Token(Token = "0x60025A3")]
		[Address(RVA = "0x3F88910", Offset = "0x3F84910", VA = "0x3F88910")]
		private void ChangeBanner(object o)
		{
		}

		[Token(Token = "0x60025A4")]
		[Address(RVA = "0x3F8898C", Offset = "0x3F8498C", VA = "0x3F8898C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60025A5")]
		[Address(RVA = "0x3F88A50", Offset = "0x3F84A50", VA = "0x3F88A50")]
		public BannerPanel()
		{
		}
	}
}
