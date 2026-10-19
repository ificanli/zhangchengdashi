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
	[Token(Token = "0x20007E4")]
	public class ChooseBoxItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007E5")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__63 : IAsyncStateMachine
		{
			[Token(Token = "0x4003CD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003CD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003CD5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ChooseBoxItemComponents _003C_003E4__this;

			[Token(Token = "0x4003CD6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002C03")]
			[Address(RVA = "0x3FF4740", Offset = "0x3FF0740", VA = "0x3FF4740", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002C04")]
			[Address(RVA = "0x3FF49B8", Offset = "0x3FF09B8", VA = "0x3FF49B8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003CCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendChooseBoxItem;

		[Token(Token = "0x4003CCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageNull;

		[Token(Token = "0x4003CD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RewardItemUI _rewardItemUIRewardItemUI;

		[Token(Token = "0x4003CD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUITxtShowName;

		[Token(Token = "0x4003CD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RectTransform _rectTransformImgChooseLight;

		[Token(Token = "0x170004C1")]
		public ButtonExtend ButtonExtendChooseBoxItem
		{
			[Token(Token = "0x6002BF7")]
			[Address(RVA = "0x3FF453C", Offset = "0x3FF053C", VA = "0x3FF453C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004C2")]
		public Image ImageNull
		{
			[Token(Token = "0x6002BF8")]
			[Address(RVA = "0x3FF40EC", Offset = "0x3FF00EC", VA = "0x3FF40EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004C3")]
		public RewardItemUI RewardItemUIRewardItemUI
		{
			[Token(Token = "0x6002BF9")]
			[Address(RVA = "0x3FF41B4", Offset = "0x3FF01B4", VA = "0x3FF41B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004C4")]
		public TextMeshProUGUI TextMeshProUGUITxtShowName
		{
			[Token(Token = "0x6002BFA")]
			[Address(RVA = "0x3FF427C", Offset = "0x3FF027C", VA = "0x3FF427C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004C5")]
		public RectTransform RectTransformImgChooseLight
		{
			[Token(Token = "0x6002BFB")]
			[Address(RVA = "0x3FF39B0", Offset = "0x3FEF9B0", VA = "0x3FF39B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002BFC")]
		[Address(RVA = "0x3FF45E0", Offset = "0x3FF05E0", VA = "0x3FF45E0")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002BFD")]
		[Address(RVA = "0x3FF3B00", Offset = "0x3FEFB00", VA = "0x3FF3B00", Slot = "12")]
		protected virtual void OnButtonExtendChooseBoxItemClicked()
		{
		}

		[Token(Token = "0x6002BFE")]
		[Address(RVA = "0x3FF4668", Offset = "0x3FF0668", VA = "0x3FF4668", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002BFF")]
		[Address(RVA = "0x3FF3BF4", Offset = "0x3FEFBF4", VA = "0x3FF3BF4", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__63))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002C00")]
		[Address(RVA = "0x3FF4684", Offset = "0x3FF0684", VA = "0x3FF4684", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002C01")]
		[Address(RVA = "0x3FF3BE8", Offset = "0x3FEFBE8", VA = "0x3FF3BE8")]
		public ChooseBoxItemComponents()
		{
		}
	}
}
