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
	[Token(Token = "0x2000C25")]
	public class WeeklyClashRewardPreviewItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C26")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__243 : IAsyncStateMachine
		{
			[Token(Token = "0x400578C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400578D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400578E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WeeklyClashRewardPreviewItemComponents _003C_003E4__this;

			[Token(Token = "0x400578F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004B34")]
			[Address(RVA = "0x4265DFC", Offset = "0x4261DFC", VA = "0x4265DFC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004B35")]
			[Address(RVA = "0x4266074", Offset = "0x4262074", VA = "0x4266074", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Image _imageRankImg;

		[Token(Token = "0x4005789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI _textMeshProUGUIRankText;

		[Token(Token = "0x400578A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ScrollRect _scrollRectRewardItemUIScrollView;

		[Token(Token = "0x400578B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RewardItemUIScrollView _rewardItemUIScrollViewRewardItemUIScrollView;

		[Token(Token = "0x17000D42")]
		public Image ImageRankImg
		{
			[Token(Token = "0x6004B29")]
			[Address(RVA = "0x426505C", Offset = "0x426105C", VA = "0x426505C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D43")]
		public TextMeshProUGUI TextMeshProUGUIRankText
		{
			[Token(Token = "0x6004B2A")]
			[Address(RVA = "0x4264F94", Offset = "0x4260F94", VA = "0x4264F94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D44")]
		public ScrollRect ScrollRectRewardItemUIScrollView
		{
			[Token(Token = "0x6004B2B")]
			[Address(RVA = "0x4265B0C", Offset = "0x4261B0C", VA = "0x4265B0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D45")]
		public RewardItemUIScrollView RewardItemUIScrollViewRewardItemUIScrollView
		{
			[Token(Token = "0x6004B2C")]
			[Address(RVA = "0x4265A38", Offset = "0x4261A38", VA = "0x4265A38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004B2D")]
		[Address(RVA = "0x4265BD4", Offset = "0x4261BD4", VA = "0x4265BD4")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004B2E")]
		[Address(RVA = "0x4265C70", Offset = "0x4261C70", VA = "0x4265C70", Slot = "12")]
		protected virtual void OnScrollRectRewardItemUIScrollViewValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x6004B2F")]
		[Address(RVA = "0x4265D24", Offset = "0x4261D24", VA = "0x4265D24", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004B30")]
		[Address(RVA = "0x42651D8", Offset = "0x42611D8", VA = "0x42651D8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__243))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004B31")]
		[Address(RVA = "0x4265D40", Offset = "0x4261D40", VA = "0x4265D40", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004B32")]
		[Address(RVA = "0x42651CC", Offset = "0x42611CC", VA = "0x42651CC")]
		public WeeklyClashRewardPreviewItemComponents()
		{
		}
	}
}
