using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x200097A")]
	public class MainReadyPanel_BoxBtnRootComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200097B")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__138 : IAsyncStateMachine
		{
			[Token(Token = "0x4004715")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004716")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004717")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MainReadyPanel_BoxBtnRootComponents _003C_003E4__this;

			[Token(Token = "0x4004718")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60037DA")]
			[Address(RVA = "0x40EB07C", Offset = "0x40E707C", VA = "0x40EB07C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60037DB")]
			[Address(RVA = "0x40EB2F4", Offset = "0x40E72F4", VA = "0x40EB2F4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400470E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Image _imageImgBg;

		[Token(Token = "0x400470F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ButtonExtend _buttonExtendImgBg;

		[Token(Token = "0x4004710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformViewport;

		[Token(Token = "0x4004711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformContent;

		[Token(Token = "0x4004712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RectTransform _rectTransformIndicatorRoot;

		[Token(Token = "0x4004713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Image _imageImgAIcon;

		[Token(Token = "0x4004714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Image _imageImgBIcon;

		[Token(Token = "0x1700084A")]
		public Image ImageImgBg
		{
			[Token(Token = "0x60037CC")]
			[Address(RVA = "0x40E7F3C", Offset = "0x40E3F3C", VA = "0x40E7F3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700084B")]
		public ButtonExtend ButtonExtendImgBg
		{
			[Token(Token = "0x60037CD")]
			[Address(RVA = "0x40EAE70", Offset = "0x40E6E70", VA = "0x40EAE70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700084C")]
		public RectTransform RectTransformViewport
		{
			[Token(Token = "0x60037CE")]
			[Address(RVA = "0x40E7E74", Offset = "0x40E3E74", VA = "0x40E7E74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700084D")]
		public RectTransform RectTransformContent
		{
			[Token(Token = "0x60037CF")]
			[Address(RVA = "0x40EA5D4", Offset = "0x40E65D4", VA = "0x40EA5D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700084E")]
		public RectTransform RectTransformIndicatorRoot
		{
			[Token(Token = "0x60037D0")]
			[Address(RVA = "0x40E8194", Offset = "0x40E4194", VA = "0x40E8194")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700084F")]
		public Image ImageImgAIcon
		{
			[Token(Token = "0x60037D1")]
			[Address(RVA = "0x40E8004", Offset = "0x40E4004", VA = "0x40E8004")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000850")]
		public Image ImageImgBIcon
		{
			[Token(Token = "0x60037D2")]
			[Address(RVA = "0x40E80CC", Offset = "0x40E40CC", VA = "0x40E80CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60037D3")]
		[Address(RVA = "0x40EAF38", Offset = "0x40E6F38", VA = "0x40EAF38")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60037D4")]
		[Address(RVA = "0x40E9384", Offset = "0x40E5384", VA = "0x40E9384", Slot = "12")]
		protected virtual void OnButtonExtendImgBgClicked()
		{
		}

		[Token(Token = "0x60037D5")]
		[Address(RVA = "0x40E9548", Offset = "0x40E5548", VA = "0x40E9548", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60037D6")]
		[Address(RVA = "0x40E9568", Offset = "0x40E5568", VA = "0x40E9568", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__138))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60037D7")]
		[Address(RVA = "0x40EAFC0", Offset = "0x40E6FC0", VA = "0x40EAFC0", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60037D8")]
		[Address(RVA = "0x40E9524", Offset = "0x40E5524", VA = "0x40E9524")]
		public MainReadyPanel_BoxBtnRootComponents()
		{
		}
	}
}
