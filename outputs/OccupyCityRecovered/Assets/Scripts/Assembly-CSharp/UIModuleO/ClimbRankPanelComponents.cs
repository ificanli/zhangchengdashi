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
	[Token(Token = "0x2000AC1")]
	public class ClimbRankPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AC2")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__147 : IAsyncStateMachine
		{
			[Token(Token = "0x4004F27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004F28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004F29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ClimbRankPanelComponents _003C_003E4__this;

			[Token(Token = "0x4004F2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600410F")]
			[Address(RVA = "0x41B509C", Offset = "0x41B109C", VA = "0x41B509C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004110")]
			[Address(RVA = "0x41B5314", Offset = "0x41B1314", VA = "0x41B5314", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004F1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformClimbRankPanel;

		[Token(Token = "0x4004F1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformScrollRect;

		[Token(Token = "0x4004F1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformMid;

		[Token(Token = "0x4004F1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformContent;

		[Token(Token = "0x4004F20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Image _imageImgDanIcon;

		[Token(Token = "0x4004F21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUITxtDanDes;

		[Token(Token = "0x4004F22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RectTransform _rectTransformBtnClose;

		[Token(Token = "0x4004F23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ButtonExtend _buttonExtendBtnClose;

		[Token(Token = "0x4004F24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private RectTransform _rectTransformHideInterface;

		[Token(Token = "0x4004F25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Image _imageImgOldDanIcon;

		[Token(Token = "0x4004F26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image _imageImgChangeDanIcon;

		[Token(Token = "0x17000A3D")]
		public RectTransform RectTransformClimbRankPanel
		{
			[Token(Token = "0x60040FD")]
			[Address(RVA = "0x41B49E4", Offset = "0x41B09E4", VA = "0x41B49E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A3E")]
		public RectTransform RectTransformScrollRect
		{
			[Token(Token = "0x60040FE")]
			[Address(RVA = "0x41B4E70", Offset = "0x41B0E70", VA = "0x41B4E70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A3F")]
		public RectTransform RectTransformMid
		{
			[Token(Token = "0x60040FF")]
			[Address(RVA = "0x41B4C18", Offset = "0x41B0C18", VA = "0x41B4C18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A40")]
		public RectTransform RectTransformContent
		{
			[Token(Token = "0x6004100")]
			[Address(RVA = "0x41B4A88", Offset = "0x41B0A88", VA = "0x41B4A88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A41")]
		public Image ImageImgDanIcon
		{
			[Token(Token = "0x6004101")]
			[Address(RVA = "0x41B4874", Offset = "0x41B0874", VA = "0x41B4874")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A42")]
		public TextMeshProUGUI TextMeshProUGUITxtDanDes
		{
			[Token(Token = "0x6004102")]
			[Address(RVA = "0x41B47AC", Offset = "0x41B07AC", VA = "0x41B47AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A43")]
		public RectTransform RectTransformBtnClose
		{
			[Token(Token = "0x6004103")]
			[Address(RVA = "0x41B461C", Offset = "0x41B061C", VA = "0x41B461C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A44")]
		public ButtonExtend ButtonExtendBtnClose
		{
			[Token(Token = "0x6004104")]
			[Address(RVA = "0x41B46E4", Offset = "0x41B06E4", VA = "0x41B46E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A45")]
		public RectTransform RectTransformHideInterface
		{
			[Token(Token = "0x6004105")]
			[Address(RVA = "0x41B4B50", Offset = "0x41B0B50", VA = "0x41B4B50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A46")]
		public Image ImageImgOldDanIcon
		{
			[Token(Token = "0x6004106")]
			[Address(RVA = "0x41B4CE0", Offset = "0x41B0CE0", VA = "0x41B4CE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A47")]
		public Image ImageImgChangeDanIcon
		{
			[Token(Token = "0x6004107")]
			[Address(RVA = "0x41B4DA8", Offset = "0x41B0DA8", VA = "0x41B4DA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004108")]
		[Address(RVA = "0x41B500C", Offset = "0x41B100C", VA = "0x41B500C")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004109")]
		[Address(RVA = "0x41B173C", Offset = "0x41AD73C", VA = "0x41B173C", Slot = "12")]
		protected virtual void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x600410A")]
		[Address(RVA = "0x41B13A4", Offset = "0x41AD3A4", VA = "0x41B13A4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600410B")]
		[Address(RVA = "0x41B1A68", Offset = "0x41ADA68", VA = "0x41B1A68", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__147))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600410C")]
		[Address(RVA = "0x41B192C", Offset = "0x41AD92C", VA = "0x41B192C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600410D")]
		[Address(RVA = "0x41B1A5C", Offset = "0x41ADA5C", VA = "0x41B1A5C")]
		public ClimbRankPanelComponents()
		{
		}
	}
}
