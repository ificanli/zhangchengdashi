using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000C07")]
	public class WeeklyClashGuidePanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C08")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__153 : IAsyncStateMachine
		{
			[Token(Token = "0x4005707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WeeklyClashGuidePanelComponents _003C_003E4__this;

			[Token(Token = "0x400570A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004A8A")]
			[Address(RVA = "0x425CB6C", Offset = "0x4258B6C", VA = "0x425CB6C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004A8B")]
			[Address(RVA = "0x425CDE4", Offset = "0x4258DE4", VA = "0x425CDE4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBG;

		[Token(Token = "0x4005701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformImgIcon1;

		[Token(Token = "0x4005702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformImgArrow1;

		[Token(Token = "0x4005703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformImgIcon2;

		[Token(Token = "0x4005704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RectTransform _rectTransformImgArrow2;

		[Token(Token = "0x4005705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RectTransform _rectTransformImgIcon3;

		[Token(Token = "0x4005706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TextMeshProUGUI _textMeshProUGUITxtTapToContinue;

		[Token(Token = "0x17000D14")]
		public ButtonExtend ButtonExtendBG
		{
			[Token(Token = "0x6004A7C")]
			[Address(RVA = "0x425C944", Offset = "0x4258944", VA = "0x425C944")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D15")]
		public RectTransform RectTransformImgIcon1
		{
			[Token(Token = "0x6004A7D")]
			[Address(RVA = "0x425C1AC", Offset = "0x42581AC", VA = "0x425C1AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D16")]
		public RectTransform RectTransformImgArrow1
		{
			[Token(Token = "0x6004A7E")]
			[Address(RVA = "0x425C274", Offset = "0x4258274", VA = "0x425C274")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D17")]
		public RectTransform RectTransformImgIcon2
		{
			[Token(Token = "0x6004A7F")]
			[Address(RVA = "0x425C33C", Offset = "0x425833C", VA = "0x425C33C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D18")]
		public RectTransform RectTransformImgArrow2
		{
			[Token(Token = "0x6004A80")]
			[Address(RVA = "0x425C404", Offset = "0x4258404", VA = "0x425C404")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D19")]
		public RectTransform RectTransformImgIcon3
		{
			[Token(Token = "0x6004A81")]
			[Address(RVA = "0x425C4CC", Offset = "0x42584CC", VA = "0x425C4CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D1A")]
		public TextMeshProUGUI TextMeshProUGUITxtTapToContinue
		{
			[Token(Token = "0x6004A82")]
			[Address(RVA = "0x425C0E4", Offset = "0x42580E4", VA = "0x425C0E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004A83")]
		[Address(RVA = "0x425CA0C", Offset = "0x4258A0C", VA = "0x425CA0C")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004A84")]
		[Address(RVA = "0x425C5B4", Offset = "0x42585B4", VA = "0x425C5B4", Slot = "12")]
		protected virtual void OnButtonExtendBGClicked()
		{
		}

		[Token(Token = "0x6004A85")]
		[Address(RVA = "0x425CA94", Offset = "0x4258A94", VA = "0x425CA94", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004A86")]
		[Address(RVA = "0x425C634", Offset = "0x4258634", VA = "0x425C634", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__153))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004A87")]
		[Address(RVA = "0x425CAB0", Offset = "0x4258AB0", VA = "0x425CAB0", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004A88")]
		[Address(RVA = "0x425C628", Offset = "0x4258628", VA = "0x425C628")]
		public WeeklyClashGuidePanelComponents()
		{
		}
	}
}
