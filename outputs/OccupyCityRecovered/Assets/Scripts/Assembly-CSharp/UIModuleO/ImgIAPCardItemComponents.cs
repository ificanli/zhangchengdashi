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
	[Token(Token = "0x2000B4A")]
	public class ImgIAPCardItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B4B")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__153 : IAsyncStateMachine
		{
			[Token(Token = "0x4005245")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005246")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005247")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ImgIAPCardItemComponents _003C_003E4__this;

			[Token(Token = "0x4005248")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60044EB")]
			[Address(RVA = "0x41F7714", Offset = "0x41F3714", VA = "0x41F7714", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60044EC")]
			[Address(RVA = "0x41F798C", Offset = "0x41F398C", VA = "0x41F798C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400523B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformImgGoldLight;

		[Token(Token = "0x400523C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageImgBg;

		[Token(Token = "0x400523D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ButtonExtend _buttonExtendImgBg;

		[Token(Token = "0x400523E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _imageImgCardIcon;

		[Token(Token = "0x400523F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Image _imageImgType;

		[Token(Token = "0x4005240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Image _imageImgProgress;

		[Token(Token = "0x4005241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TextMeshProUGUI _textMeshProUGUITxtProgress;

		[Token(Token = "0x4005242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TextMeshProUGUI _textMeshProUGUITxtNum;

		[Token(Token = "0x4005243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUITxtCardName;

		[Token(Token = "0x4005244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TextMeshProUGUI _textMeshProUGUITxtRareLevelDes;

		[Token(Token = "0x17000B67")]
		public RectTransform RectTransformImgGoldLight
		{
			[Token(Token = "0x60044DA")]
			[Address(RVA = "0x41F567C", Offset = "0x41F167C", VA = "0x41F567C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B68")]
		public Image ImageImgBg
		{
			[Token(Token = "0x60044DB")]
			[Address(RVA = "0x41F4B60", Offset = "0x41F0B60", VA = "0x41F4B60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B69")]
		public ButtonExtend ButtonExtendImgBg
		{
			[Token(Token = "0x60044DC")]
			[Address(RVA = "0x41F4A98", Offset = "0x41F0A98", VA = "0x41F4A98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B6A")]
		public Image ImageImgCardIcon
		{
			[Token(Token = "0x60044DD")]
			[Address(RVA = "0x41F7384", Offset = "0x41F3384", VA = "0x41F7384")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B6B")]
		public Image ImageImgType
		{
			[Token(Token = "0x60044DE")]
			[Address(RVA = "0x41F744C", Offset = "0x41F344C", VA = "0x41F744C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B6C")]
		public Image ImageImgProgress
		{
			[Token(Token = "0x60044DF")]
			[Address(RVA = "0x41F72BC", Offset = "0x41F32BC", VA = "0x41F72BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B6D")]
		public TextMeshProUGUI TextMeshProUGUITxtProgress
		{
			[Token(Token = "0x60044E0")]
			[Address(RVA = "0x41F71F4", Offset = "0x41F31F4", VA = "0x41F71F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B6E")]
		public TextMeshProUGUI TextMeshProUGUITxtNum
		{
			[Token(Token = "0x60044E1")]
			[Address(RVA = "0x41F4984", Offset = "0x41F0984", VA = "0x41F4984")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B6F")]
		public TextMeshProUGUI TextMeshProUGUITxtCardName
		{
			[Token(Token = "0x60044E2")]
			[Address(RVA = "0x41F557C", Offset = "0x41F157C", VA = "0x41F557C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B70")]
		public TextMeshProUGUI TextMeshProUGUITxtRareLevelDes
		{
			[Token(Token = "0x60044E3")]
			[Address(RVA = "0x41F506C", Offset = "0x41F106C", VA = "0x41F506C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60044E4")]
		[Address(RVA = "0x41F7520", Offset = "0x41F3520", VA = "0x41F7520")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60044E5")]
		[Address(RVA = "0x41F5000", Offset = "0x41F1000", VA = "0x41F5000", Slot = "12")]
		protected virtual void OnButtonExtendImgBgClicked()
		{
		}

		[Token(Token = "0x60044E6")]
		[Address(RVA = "0x41F75A8", Offset = "0x41F35A8", VA = "0x41F75A8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60044E7")]
		[Address(RVA = "0x41F75C4", Offset = "0x41F35C4", VA = "0x41F75C4", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__153))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60044E8")]
		[Address(RVA = "0x41F7658", Offset = "0x41F3658", VA = "0x41F7658", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60044E9")]
		[Address(RVA = "0x41F5898", Offset = "0x41F1898", VA = "0x41F5898")]
		public ImgIAPCardItemComponents()
		{
		}
	}
}
