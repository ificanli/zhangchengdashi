using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000ACA")]
	public class RankPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000ACB")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__99 : IAsyncStateMachine
		{
			[Token(Token = "0x4004F4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004F4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004F4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public RankPanelComponents _003C_003E4__this;

			[Token(Token = "0x4004F50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600413C")]
			[Address(RVA = "0x41B7F08", Offset = "0x41B3F08", VA = "0x41B7F08", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600413D")]
			[Address(RVA = "0x41B8180", Offset = "0x41B4180", VA = "0x41B8180", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004F49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Image _imageImgDanIcon;

		[Token(Token = "0x4004F4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI _textMeshProUGUITxtDanDes;

		[Token(Token = "0x4004F4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ScrollRect _scrollRectScrollView;

		[Token(Token = "0x4004F4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformContent;

		[Token(Token = "0x17000A4F")]
		public Image ImageImgDanIcon
		{
			[Token(Token = "0x6004131")]
			[Address(RVA = "0x41B7C14", Offset = "0x41B3C14", VA = "0x41B7C14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A50")]
		public TextMeshProUGUI TextMeshProUGUITxtDanDes
		{
			[Token(Token = "0x6004132")]
			[Address(RVA = "0x41B7B4C", Offset = "0x41B3B4C", VA = "0x41B7B4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A51")]
		public ScrollRect ScrollRectScrollView
		{
			[Token(Token = "0x6004133")]
			[Address(RVA = "0x41B69EC", Offset = "0x41B29EC", VA = "0x41B69EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A52")]
		public RectTransform RectTransformContent
		{
			[Token(Token = "0x6004134")]
			[Address(RVA = "0x41B7CDC", Offset = "0x41B3CDC", VA = "0x41B7CDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004135")]
		[Address(RVA = "0x41B7DB0", Offset = "0x41B3DB0", VA = "0x41B7DB0")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004136")]
		[Address(RVA = "0x41B7E4C", Offset = "0x41B3E4C", VA = "0x41B7E4C", Slot = "12")]
		protected virtual void OnScrollRectScrollViewValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x6004137")]
		[Address(RVA = "0x41B66E8", Offset = "0x41B26E8", VA = "0x41B66E8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004138")]
		[Address(RVA = "0x41B6BAC", Offset = "0x41B2BAC", VA = "0x41B6BAC", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__99))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004139")]
		[Address(RVA = "0x41B6894", Offset = "0x41B2894", VA = "0x41B6894", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600413A")]
		[Address(RVA = "0x41B6BA0", Offset = "0x41B2BA0", VA = "0x41B6BA0")]
		public RankPanelComponents()
		{
		}
	}
}
