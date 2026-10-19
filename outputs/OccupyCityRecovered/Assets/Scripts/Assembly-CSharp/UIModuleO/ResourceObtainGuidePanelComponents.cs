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
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000AD8")]
	public class ResourceObtainGuidePanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AD9")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__176 : IAsyncStateMachine
		{
			[Token(Token = "0x4004F8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004F8C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004F8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ResourceObtainGuidePanelComponents _003C_003E4__this;

			[Token(Token = "0x4004F8E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600418F")]
			[Address(RVA = "0x41BD7DC", Offset = "0x41B97DC", VA = "0x41BD7DC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004190")]
			[Address(RVA = "0x41BDA54", Offset = "0x41B9A54", VA = "0x41BDA54", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004F7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Button _buttonMask;

		[Token(Token = "0x4004F7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ButtonExtend _buttonExtendCloseBtn;

		[Token(Token = "0x4004F7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformResourceItem;

		[Token(Token = "0x4004F7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _imageResourceItemBG;

		[Token(Token = "0x4004F80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Image _imageResourceIcon;

		[Token(Token = "0x4004F81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RectTransform _rectTransformCardItem;

		[Token(Token = "0x4004F82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Image _imageCardItemBG;

		[Token(Token = "0x4004F83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Image _imageCardIcon;

		[Token(Token = "0x4004F84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUIName;

		[Token(Token = "0x4004F85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TextMeshProUGUI _textMeshProUGUICount;

		[Token(Token = "0x4004F86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TextMeshProUGUI _textMeshProUGUIDes;

		[Token(Token = "0x4004F87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ScrollRect _scrollRectScrollView;

		[Token(Token = "0x4004F88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RectTransform _rectTransformContent;

		[Token(Token = "0x4004F89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private RectTransform _rectTransformWayItem;

		[Token(Token = "0x4004F8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private RectTransform _rectTransformNoWayTips;

		[Token(Token = "0x17000A5A")]
		public Button ButtonMask
		{
			[Token(Token = "0x6004177")]
			[Address(RVA = "0x41BD2A8", Offset = "0x41B92A8", VA = "0x41BD2A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A5B")]
		public ButtonExtend ButtonExtendCloseBtn
		{
			[Token(Token = "0x6004178")]
			[Address(RVA = "0x41BD370", Offset = "0x41B9370", VA = "0x41BD370")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A5C")]
		public RectTransform RectTransformResourceItem
		{
			[Token(Token = "0x6004179")]
			[Address(RVA = "0x41BC0AC", Offset = "0x41B80AC", VA = "0x41BC0AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A5D")]
		public Image ImageResourceItemBG
		{
			[Token(Token = "0x600417A")]
			[Address(RVA = "0x41BC3CC", Offset = "0x41B83CC", VA = "0x41BC3CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A5E")]
		public Image ImageResourceIcon
		{
			[Token(Token = "0x600417B")]
			[Address(RVA = "0x41BC304", Offset = "0x41B8304", VA = "0x41BC304")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A5F")]
		public RectTransform RectTransformCardItem
		{
			[Token(Token = "0x600417C")]
			[Address(RVA = "0x41BBFE4", Offset = "0x41B7FE4", VA = "0x41BBFE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A60")]
		public Image ImageCardItemBG
		{
			[Token(Token = "0x600417D")]
			[Address(RVA = "0x41BC494", Offset = "0x41B8494", VA = "0x41BC494")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A61")]
		public Image ImageCardIcon
		{
			[Token(Token = "0x600417E")]
			[Address(RVA = "0x41BC55C", Offset = "0x41B855C", VA = "0x41BC55C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A62")]
		public TextMeshProUGUI TextMeshProUGUIName
		{
			[Token(Token = "0x600417F")]
			[Address(RVA = "0x41BC174", Offset = "0x41B8174", VA = "0x41BC174")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A63")]
		public TextMeshProUGUI TextMeshProUGUICount
		{
			[Token(Token = "0x6004180")]
			[Address(RVA = "0x41BBF1C", Offset = "0x41B7F1C", VA = "0x41BBF1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A64")]
		public TextMeshProUGUI TextMeshProUGUIDes
		{
			[Token(Token = "0x6004181")]
			[Address(RVA = "0x41BC23C", Offset = "0x41B823C", VA = "0x41BC23C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A65")]
		public ScrollRect ScrollRectScrollView
		{
			[Token(Token = "0x6004182")]
			[Address(RVA = "0x41BCAA4", Offset = "0x41B8AA4", VA = "0x41BCAA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A66")]
		public RectTransform RectTransformContent
		{
			[Token(Token = "0x6004183")]
			[Address(RVA = "0x41BA2F4", Offset = "0x41B62F4", VA = "0x41BA2F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A67")]
		public RectTransform RectTransformWayItem
		{
			[Token(Token = "0x6004184")]
			[Address(RVA = "0x41B9F30", Offset = "0x41B5F30", VA = "0x41B9F30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A68")]
		public RectTransform RectTransformNoWayTips
		{
			[Token(Token = "0x6004185")]
			[Address(RVA = "0x41BCB6C", Offset = "0x41B8B6C", VA = "0x41BCB6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004186")]
		[Address(RVA = "0x41BD438", Offset = "0x41B9438", VA = "0x41BD438")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004187")]
		[Address(RVA = "0x41BD578", Offset = "0x41B9578", VA = "0x41BD578", Slot = "12")]
		protected virtual void OnButtonMaskClicked()
		{
		}

		[Token(Token = "0x6004188")]
		[Address(RVA = "0x41BD5E4", Offset = "0x41B95E4", VA = "0x41BD5E4", Slot = "13")]
		protected virtual void OnButtonExtendCloseBtnClicked()
		{
		}

		[Token(Token = "0x6004189")]
		[Address(RVA = "0x41BD650", Offset = "0x41B9650", VA = "0x41BD650", Slot = "14")]
		protected virtual void OnScrollRectScrollViewValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x600418A")]
		[Address(RVA = "0x41BD704", Offset = "0x41B9704", VA = "0x41BD704", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600418B")]
		[Address(RVA = "0x41BA510", Offset = "0x41B6510", VA = "0x41BA510", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__176))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600418C")]
		[Address(RVA = "0x41BD720", Offset = "0x41B9720", VA = "0x41BD720", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600418D")]
		[Address(RVA = "0x41BA504", Offset = "0x41B6504", VA = "0x41BA504")]
		public ResourceObtainGuidePanelComponents()
		{
		}
	}
}
