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
	[Token(Token = "0x200079E")]
	public class CardItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200079F")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__243 : IAsyncStateMachine
		{
			[Token(Token = "0x4003B2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003B30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003B31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CardItemComponents _003C_003E4__this;

			[Token(Token = "0x4003B32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002A2B")]
			[Address(RVA = "0x3FD0B50", Offset = "0x3FCCB50", VA = "0x3FD0B50", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002A2C")]
			[Address(RVA = "0x3FD0DC8", Offset = "0x3FCCDC8", VA = "0x3FD0DC8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003B21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendCardItem;

		[Token(Token = "0x4003B22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageBG;

		[Token(Token = "0x4003B23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Mask _maskImgMask;

		[Token(Token = "0x4003B24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _imageImgIcon;

		[Token(Token = "0x4003B25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUITxtLevel;

		[Token(Token = "0x4003B26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RectTransform _rectTransformImgProcessBG;

		[Token(Token = "0x4003B27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Image _imageImgProcessBG;

		[Token(Token = "0x4003B28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Image _imageImgProcess;

		[Token(Token = "0x4003B29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUITxtCardCount;

		[Token(Token = "0x4003B2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Image _imageImgType;

		[Token(Token = "0x4003B2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private RectTransform _rectTransformImgRedDot;

		[Token(Token = "0x4003B2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private RectTransform _rectTransformImgArrowHead;

		[Token(Token = "0x4003B2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Image _imageImgArrowHead;

		[Token(Token = "0x4003B2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private RectTransform _rectTransformBuffSpineEffect;

		[Token(Token = "0x17000428")]
		public ButtonExtend ButtonExtendCardItem
		{
			[Token(Token = "0x6002A16")]
			[Address(RVA = "0x3FD08D4", Offset = "0x3FCC8D4", VA = "0x3FD08D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000429")]
		public Image ImageBG
		{
			[Token(Token = "0x6002A17")]
			[Address(RVA = "0x3FD01C0", Offset = "0x3FCC1C0", VA = "0x3FD01C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700042A")]
		public Mask MaskImgMask
		{
			[Token(Token = "0x6002A18")]
			[Address(RVA = "0x3FD0350", Offset = "0x3FCC350", VA = "0x3FD0350")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700042B")]
		public Image ImageImgIcon
		{
			[Token(Token = "0x6002A19")]
			[Address(RVA = "0x3FD0030", Offset = "0x3FCC030", VA = "0x3FD0030")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700042C")]
		public TextMeshProUGUI TextMeshProUGUITxtLevel
		{
			[Token(Token = "0x6002A1A")]
			[Address(RVA = "0x3FD0288", Offset = "0x3FCC288", VA = "0x3FD0288")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700042D")]
		public RectTransform RectTransformImgProcessBG
		{
			[Token(Token = "0x6002A1B")]
			[Address(RVA = "0x3FD0418", Offset = "0x3FCC418", VA = "0x3FD0418")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700042E")]
		public Image ImageImgProcessBG
		{
			[Token(Token = "0x6002A1C")]
			[Address(RVA = "0x3FCEAAC", Offset = "0x3FCAAAC", VA = "0x3FCEAAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700042F")]
		public Image ImageImgProcess
		{
			[Token(Token = "0x6002A1D")]
			[Address(RVA = "0x3FD05A8", Offset = "0x3FCC5A8", VA = "0x3FD05A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000430")]
		public TextMeshProUGUI TextMeshProUGUITxtCardCount
		{
			[Token(Token = "0x6002A1E")]
			[Address(RVA = "0x3FD04E0", Offset = "0x3FCC4E0", VA = "0x3FD04E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000431")]
		public Image ImageImgType
		{
			[Token(Token = "0x6002A1F")]
			[Address(RVA = "0x3FD00F8", Offset = "0x3FCC0F8", VA = "0x3FD00F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000432")]
		public RectTransform RectTransformImgRedDot
		{
			[Token(Token = "0x6002A20")]
			[Address(RVA = "0x3FCD9C8", Offset = "0x3FC99C8", VA = "0x3FCD9C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000433")]
		public RectTransform RectTransformImgArrowHead
		{
			[Token(Token = "0x6002A21")]
			[Address(RVA = "0x3FD0738", Offset = "0x3FCC738", VA = "0x3FD0738")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000434")]
		public Image ImageImgArrowHead
		{
			[Token(Token = "0x6002A22")]
			[Address(RVA = "0x3FD0670", Offset = "0x3FCC670", VA = "0x3FD0670")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000435")]
		public RectTransform RectTransformBuffSpineEffect
		{
			[Token(Token = "0x6002A23")]
			[Address(RVA = "0x3FD0800", Offset = "0x3FCC800", VA = "0x3FD0800")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002A24")]
		[Address(RVA = "0x3FD0978", Offset = "0x3FCC978", VA = "0x3FD0978")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002A25")]
		[Address(RVA = "0x3FCDE2C", Offset = "0x3FC9E2C", VA = "0x3FCDE2C", Slot = "12")]
		protected virtual void OnButtonExtendCardItemClicked()
		{
		}

		[Token(Token = "0x6002A26")]
		[Address(RVA = "0x3FCD6D4", Offset = "0x3FC96D4", VA = "0x3FCD6D4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002A27")]
		[Address(RVA = "0x3FD0A00", Offset = "0x3FCCA00", VA = "0x3FD0A00", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__243))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002A28")]
		[Address(RVA = "0x3FD0A94", Offset = "0x3FCCA94", VA = "0x3FD0A94", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002A29")]
		[Address(RVA = "0x3FCDF2C", Offset = "0x3FC9F2C", VA = "0x3FCDF2C")]
		public CardItemComponents()
		{
		}
	}
}
