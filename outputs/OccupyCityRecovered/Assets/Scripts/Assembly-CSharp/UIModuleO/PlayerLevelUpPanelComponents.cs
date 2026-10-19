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
	[Token(Token = "0x2000A94")]
	public class PlayerLevelUpPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A95")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__201 : IAsyncStateMachine
		{
			[Token(Token = "0x4004E17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004E18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004E19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PlayerLevelUpPanelComponents _003C_003E4__this;

			[Token(Token = "0x4004E1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003FE0")]
			[Address(RVA = "0x419EB88", Offset = "0x419AB88", VA = "0x419EB88", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003FE1")]
			[Address(RVA = "0x419EE00", Offset = "0x419AE00", VA = "0x419EE00", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004E0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformBalckBG;

		[Token(Token = "0x4004E10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageLevelBG1;

		[Token(Token = "0x4004E11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUILevelText;

		[Token(Token = "0x4004E12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUILastLevel;

		[Token(Token = "0x4004E13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUICurrentLevel;

		[Token(Token = "0x4004E14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Image _imageRewardIcon;

		[Token(Token = "0x4004E15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TextMeshProUGUI _textMeshProUGUIRewardName;

		[Token(Token = "0x4004E16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ButtonExtend _buttonExtendClaimBtn;

		[Token(Token = "0x170009E6")]
		public RectTransform RectTransformBalckBG
		{
			[Token(Token = "0x6003FD1")]
			[Address(RVA = "0x419D5E4", Offset = "0x41995E4", VA = "0x419D5E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009E7")]
		public Image ImageLevelBG1
		{
			[Token(Token = "0x6003FD2")]
			[Address(RVA = "0x419DA2C", Offset = "0x4199A2C", VA = "0x419DA2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009E8")]
		public TextMeshProUGUI TextMeshProUGUILevelText
		{
			[Token(Token = "0x6003FD3")]
			[Address(RVA = "0x419E704", Offset = "0x419A704", VA = "0x419E704")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009E9")]
		public TextMeshProUGUI TextMeshProUGUILastLevel
		{
			[Token(Token = "0x6003FD4")]
			[Address(RVA = "0x419E894", Offset = "0x419A894", VA = "0x419E894")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009EA")]
		public TextMeshProUGUI TextMeshProUGUICurrentLevel
		{
			[Token(Token = "0x6003FD5")]
			[Address(RVA = "0x419E7CC", Offset = "0x419A7CC", VA = "0x419E7CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009EB")]
		public Image ImageRewardIcon
		{
			[Token(Token = "0x6003FD6")]
			[Address(RVA = "0x419E63C", Offset = "0x419A63C", VA = "0x419E63C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009EC")]
		public TextMeshProUGUI TextMeshProUGUIRewardName
		{
			[Token(Token = "0x6003FD7")]
			[Address(RVA = "0x419E95C", Offset = "0x419A95C", VA = "0x419E95C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009ED")]
		public ButtonExtend ButtonExtendClaimBtn
		{
			[Token(Token = "0x6003FD8")]
			[Address(RVA = "0x419EA30", Offset = "0x419AA30", VA = "0x419EA30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003FD9")]
		[Address(RVA = "0x419EAF8", Offset = "0x419AAF8", VA = "0x419EAF8")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6003FDA")]
		[Address(RVA = "0x419D7FC", Offset = "0x41997FC", VA = "0x419D7FC", Slot = "12")]
		protected virtual void OnButtonExtendClaimBtnClicked()
		{
		}

		[Token(Token = "0x6003FDB")]
		[Address(RVA = "0x419D5C8", Offset = "0x41995C8", VA = "0x419D5C8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6003FDC")]
		[Address(RVA = "0x419DB08", Offset = "0x4199B08", VA = "0x419DB08", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__201))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003FDD")]
		[Address(RVA = "0x419D878", Offset = "0x4199878", VA = "0x419D878", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6003FDE")]
		[Address(RVA = "0x419DAFC", Offset = "0x4199AFC", VA = "0x419DAFC")]
		public PlayerLevelUpPanelComponents()
		{
		}
	}
}
