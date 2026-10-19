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
	[Token(Token = "0x2000AAB")]
	public class PropItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AAC")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__141 : IAsyncStateMachine
		{
			[Token(Token = "0x4004E90")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004E91")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004E92")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PropItemComponents _003C_003E4__this;

			[Token(Token = "0x4004E93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600406E")]
			[Address(RVA = "0x41A8258", Offset = "0x41A4258", VA = "0x41A8258", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600406F")]
			[Address(RVA = "0x41A84D0", Offset = "0x41A44D0", VA = "0x41A84D0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004E84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendPropItem;

		[Token(Token = "0x4004E85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageBG;

		[Token(Token = "0x4004E86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Image _imageImgLight;

		[Token(Token = "0x4004E87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Mask _maskImgMask;

		[Token(Token = "0x4004E88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Image _imageImgIcon;

		[Token(Token = "0x4004E89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUITxtLevel;

		[Token(Token = "0x4004E8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RectTransform _rectTransformImgProcessBG;

		[Token(Token = "0x4004E8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Image _imageImgProcess;

		[Token(Token = "0x4004E8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUITxtCardCount;

		[Token(Token = "0x4004E8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private RectTransform _rectTransformImgArrowHead;

		[Token(Token = "0x4004E8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image _imageImgArrowHead;

		[Token(Token = "0x4004E8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Image _imageImgFrontBlackBg;

		[Token(Token = "0x17000A08")]
		public ButtonExtend ButtonExtendPropItem
		{
			[Token(Token = "0x600405B")]
			[Address(RVA = "0x41A7FDC", Offset = "0x41A3FDC", VA = "0x41A7FDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A09")]
		public Image ImageBG
		{
			[Token(Token = "0x600405C")]
			[Address(RVA = "0x41A7A58", Offset = "0x41A3A58", VA = "0x41A7A58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A0A")]
		public Image ImageImgLight
		{
			[Token(Token = "0x600405D")]
			[Address(RVA = "0x41A638C", Offset = "0x41A238C", VA = "0x41A638C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A0B")]
		public Mask MaskImgMask
		{
			[Token(Token = "0x600405E")]
			[Address(RVA = "0x41A7D78", Offset = "0x41A3D78", VA = "0x41A7D78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A0C")]
		public Image ImageImgIcon
		{
			[Token(Token = "0x600405F")]
			[Address(RVA = "0x41A7990", Offset = "0x41A3990", VA = "0x41A7990")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A0D")]
		public TextMeshProUGUI TextMeshProUGUITxtLevel
		{
			[Token(Token = "0x6004060")]
			[Address(RVA = "0x41A7BE8", Offset = "0x41A3BE8", VA = "0x41A7BE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A0E")]
		public RectTransform RectTransformImgProcessBG
		{
			[Token(Token = "0x6004061")]
			[Address(RVA = "0x41A7CB0", Offset = "0x41A3CB0", VA = "0x41A7CB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A0F")]
		public Image ImageImgProcess
		{
			[Token(Token = "0x6004062")]
			[Address(RVA = "0x41A6A58", Offset = "0x41A2A58", VA = "0x41A6A58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A10")]
		public TextMeshProUGUI TextMeshProUGUITxtCardCount
		{
			[Token(Token = "0x6004063")]
			[Address(RVA = "0x41A7E40", Offset = "0x41A3E40", VA = "0x41A7E40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A11")]
		public RectTransform RectTransformImgArrowHead
		{
			[Token(Token = "0x6004064")]
			[Address(RVA = "0x41A6B20", Offset = "0x41A2B20", VA = "0x41A6B20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A12")]
		public Image ImageImgArrowHead
		{
			[Token(Token = "0x6004065")]
			[Address(RVA = "0x41A7F08", Offset = "0x41A3F08", VA = "0x41A7F08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A13")]
		public Image ImageImgFrontBlackBg
		{
			[Token(Token = "0x6004066")]
			[Address(RVA = "0x41A7B20", Offset = "0x41A3B20", VA = "0x41A7B20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004067")]
		[Address(RVA = "0x41A8080", Offset = "0x41A4080", VA = "0x41A8080")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004068")]
		[Address(RVA = "0x41A6070", Offset = "0x41A2070", VA = "0x41A6070", Slot = "12")]
		protected virtual void OnButtonExtendPropItemClicked()
		{
		}

		[Token(Token = "0x6004069")]
		[Address(RVA = "0x41A5FD8", Offset = "0x41A1FD8", VA = "0x41A5FD8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600406A")]
		[Address(RVA = "0x41A8108", Offset = "0x41A4108", VA = "0x41A8108", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__141))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600406B")]
		[Address(RVA = "0x41A819C", Offset = "0x41A419C", VA = "0x41A819C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600406C")]
		[Address(RVA = "0x41A6748", Offset = "0x41A2748", VA = "0x41A6748")]
		public PropItemComponents()
		{
		}
	}
}
