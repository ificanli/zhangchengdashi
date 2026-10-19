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
	[Token(Token = "0x2000877")]
	public class EnemyCardEditorPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000878")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__394 : IAsyncStateMachine
		{
			[Token(Token = "0x4003FF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003FF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003FF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public EnemyCardEditorPanelComponents _003C_003E4__this;

			[Token(Token = "0x4003FF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002F93")]
			[Address(RVA = "0x4033CB8", Offset = "0x402FCB8", VA = "0x4033CB8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002F94")]
			[Address(RVA = "0x4033F30", Offset = "0x402FF30", VA = "0x4033F30", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003FE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Button _buttonCardItem;

		[Token(Token = "0x4003FE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformBottom;

		[Token(Token = "0x4003FE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ScrollRect _scrollRectAllCardScrollView;

		[Token(Token = "0x4003FEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformAllCardContent;

		[Token(Token = "0x4003FEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ScrollRect _scrollRectEquipScrollView;

		[Token(Token = "0x4003FEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RectTransform _rectTransformEquipContent;

		[Token(Token = "0x4003FED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TextMeshProUGUI _textMeshProUGUITxtAllBattleNum;

		[Token(Token = "0x4003FEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Button _buttonBtnUnit;

		[Token(Token = "0x4003FEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Button _buttonBtnCancel;

		[Token(Token = "0x17000599")]
		public Button ButtonCardItem
		{
			[Token(Token = "0x6002F7F")]
			[Address(RVA = "0x4032FC0", Offset = "0x402EFC0", VA = "0x4032FC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700059A")]
		public RectTransform RectTransformBottom
		{
			[Token(Token = "0x6002F80")]
			[Address(RVA = "0x4033088", Offset = "0x402F088", VA = "0x4033088")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700059B")]
		public ScrollRect ScrollRectAllCardScrollView
		{
			[Token(Token = "0x6002F81")]
			[Address(RVA = "0x4033150", Offset = "0x402F150", VA = "0x4033150")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700059C")]
		public RectTransform RectTransformAllCardContent
		{
			[Token(Token = "0x6002F82")]
			[Address(RVA = "0x4033218", Offset = "0x402F218", VA = "0x4033218")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700059D")]
		public ScrollRect ScrollRectEquipScrollView
		{
			[Token(Token = "0x6002F83")]
			[Address(RVA = "0x40332E0", Offset = "0x402F2E0", VA = "0x40332E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700059E")]
		public RectTransform RectTransformEquipContent
		{
			[Token(Token = "0x6002F84")]
			[Address(RVA = "0x40333A8", Offset = "0x402F3A8", VA = "0x40333A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700059F")]
		public TextMeshProUGUI TextMeshProUGUITxtAllBattleNum
		{
			[Token(Token = "0x6002F85")]
			[Address(RVA = "0x4033470", Offset = "0x402F470", VA = "0x4033470")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005A0")]
		public Button ButtonBtnUnit
		{
			[Token(Token = "0x6002F86")]
			[Address(RVA = "0x4033538", Offset = "0x402F538", VA = "0x4033538")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005A1")]
		public Button ButtonBtnCancel
		{
			[Token(Token = "0x6002F87")]
			[Address(RVA = "0x4033600", Offset = "0x402F600", VA = "0x4033600")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002F88")]
		[Address(RVA = "0x40336C8", Offset = "0x402F6C8", VA = "0x40336C8")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002F89")]
		[Address(RVA = "0x4033898", Offset = "0x402F898", VA = "0x4033898", Slot = "12")]
		protected virtual void OnButtonCardItemClicked()
		{
		}

		[Token(Token = "0x6002F8A")]
		[Address(RVA = "0x4033904", Offset = "0x402F904", VA = "0x4033904", Slot = "13")]
		protected virtual void OnScrollRectAllCardScrollViewValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x6002F8B")]
		[Address(RVA = "0x40339B8", Offset = "0x402F9B8", VA = "0x40339B8", Slot = "14")]
		protected virtual void OnScrollRectEquipScrollViewValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x6002F8C")]
		[Address(RVA = "0x4033A6C", Offset = "0x402FA6C", VA = "0x4033A6C", Slot = "15")]
		protected virtual void OnButtonBtnUnitClicked()
		{
		}

		[Token(Token = "0x6002F8D")]
		[Address(RVA = "0x4033AD8", Offset = "0x402FAD8", VA = "0x4033AD8", Slot = "16")]
		protected virtual void OnButtonBtnCancelClicked()
		{
		}

		[Token(Token = "0x6002F8E")]
		[Address(RVA = "0x4033B44", Offset = "0x402FB44", VA = "0x4033B44", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002F8F")]
		[Address(RVA = "0x4033B60", Offset = "0x402FB60", VA = "0x4033B60", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__394))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002F90")]
		[Address(RVA = "0x4033BF4", Offset = "0x402FBF4", VA = "0x4033BF4", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002F91")]
		[Address(RVA = "0x4033CA8", Offset = "0x402FCA8", VA = "0x4033CA8")]
		public EnemyCardEditorPanelComponents()
		{
		}
	}
}
