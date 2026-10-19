using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using DataModule;
using GameModule;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20008FF")]
	public class GoldCardAnimationPanel : GoldCardAnimationPanelComponents
	{
		[Token(Token = "0x2000901")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass9_0
		{
			[Token(Token = "0x40043E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GoldCardAniConfig config;

			[Token(Token = "0x60033E4")]
			[Address(RVA = "0x40A25B8", Offset = "0x409E5B8", VA = "0x40A25B8")]
			public _003C_003Ec__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60033E5")]
			[Address(RVA = "0x40A25C0", Offset = "0x409E5C0", VA = "0x40A25C0")]
			internal bool _003CShow_003Eb__0(GlobalHeroCardInfo x)
			{
				return default;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000902")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__9 : IAsyncStateMachine
		{
			[Token(Token = "0x40043E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40043E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40043E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GoldCardAnimationPanel _003C_003E4__this;

			[Token(Token = "0x40043E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x40043E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private _003C_003Ec__DisplayClass9_0 _003C_003E8__1;

			[Token(Token = "0x40043E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x40043E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x40043E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x60033E6")]
			[Address(RVA = "0x40A25E8", Offset = "0x409E5E8", VA = "0x40A25E8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60033E7")]
			[Address(RVA = "0x40A3E60", Offset = "0x409FE60", VA = "0x40A3E60", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40043D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Sequence _se;

		[Token(Token = "0x40043D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Sequence sequence1;

		[Token(Token = "0x40043DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Sequence sequence2;

		[Token(Token = "0x40043DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Sequence sequence3;

		[Token(Token = "0x40043DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Sequence sequence4;

		[Token(Token = "0x40043DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public AnimationCurve speedCurve;

		[Token(Token = "0x60033DA")]
		[Address(RVA = "0x40A0A40", Offset = "0x409CA40", VA = "0x40A0A40", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60033DB")]
		[Address(RVA = "0x40A0B1C", Offset = "0x409CB1C", VA = "0x40A0B1C")]
		public void Play(Sequence sequence, RectTransform rectTransform, TextMeshProUGUI textMeshProUGUI, Vector2 bornPos, Vector2 endPos, TextMeshProUGUI text)
		{
		}

		[Token(Token = "0x60033DC")]
		[Address(RVA = "0x40A0ECC", Offset = "0x409CECC", VA = "0x40A0ECC")]
		public void ResetUI(Vector2 bornPos, RectTransform rectTransform, TextMeshProUGUI textMeshProUGUI, TextMeshProUGUI text)
		{
		}

		[Token(Token = "0x60033DD")]
		[Address(RVA = "0x40A10A4", Offset = "0x409D0A4", VA = "0x40A10A4", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__9))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60033DE")]
		[Address(RVA = "0x40A1140", Offset = "0x409D140", VA = "0x40A1140")]
		private void GameEnd(object o)
		{
		}

		[Token(Token = "0x60033DF")]
		[Address(RVA = "0x40A114C", Offset = "0x409D14C", VA = "0x40A114C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60033E0")]
		[Address(RVA = "0x40A22FC", Offset = "0x409E2FC", VA = "0x40A22FC")]
		public GoldCardAnimationPanel()
		{
		}
	}
}
