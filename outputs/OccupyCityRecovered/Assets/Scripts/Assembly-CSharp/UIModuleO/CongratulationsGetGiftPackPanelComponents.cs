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
	[Token(Token = "0x2000B45")]
	public class CongratulationsGetGiftPackPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B46")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__175 : IAsyncStateMachine
		{
			[Token(Token = "0x4005224")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005225")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005226")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CongratulationsGetGiftPackPanelComponents _003C_003E4__this;

			[Token(Token = "0x4005227")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60044C3")]
			[Address(RVA = "0x41F44D0", Offset = "0x41F04D0", VA = "0x41F44D0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60044C4")]
			[Address(RVA = "0x41F4748", Offset = "0x41F0748", VA = "0x41F4748", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformCongratulationsGetGiftPackPanel;

		[Token(Token = "0x4005215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Button _buttonBG;

		[Token(Token = "0x4005216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformRoot;

		[Token(Token = "0x4005217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ButtonExtend _buttonExtendBtnClose;

		[Token(Token = "0x4005218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUITxtCongratulations;

		[Token(Token = "0x4005219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RectTransform _rectTransformRewardRoot;

		[Token(Token = "0x400521A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GridLayoutGroup _gridLayoutGroupRewardRoot;

		[Token(Token = "0x400521B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Image _imageImgResRoot;

		[Token(Token = "0x400521C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private RectTransform _rectTransformImgRes1;

		[Token(Token = "0x400521D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Image _imageImgRes1;

		[Token(Token = "0x400521E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TextMeshProUGUI _textMeshProUGUITxtRes1Num;

		[Token(Token = "0x400521F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TextMeshProUGUI _textMeshProUGUITxtRes1Name;

		[Token(Token = "0x4005220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RectTransform _rectTransformImgRes2;

		[Token(Token = "0x4005221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Image _imageImgRes2;

		[Token(Token = "0x4005222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private TextMeshProUGUI _textMeshProUGUITxtRes2Num;

		[Token(Token = "0x4005223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private TextMeshProUGUI _textMeshProUGUITxtRes2Name;

		[Token(Token = "0x17000B57")]
		public RectTransform RectTransformCongratulationsGetGiftPackPanel
		{
			[Token(Token = "0x60044AB")]
			[Address(RVA = "0x41F24D4", Offset = "0x41EE4D4", VA = "0x41F24D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B58")]
		public Button ButtonBG
		{
			[Token(Token = "0x60044AC")]
			[Address(RVA = "0x41F4264", Offset = "0x41F0264", VA = "0x41F4264")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B59")]
		public RectTransform RectTransformRoot
		{
			[Token(Token = "0x60044AD")]
			[Address(RVA = "0x41F055C", Offset = "0x41EC55C", VA = "0x41F055C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B5A")]
		public ButtonExtend ButtonExtendBtnClose
		{
			[Token(Token = "0x60044AE")]
			[Address(RVA = "0x41F432C", Offset = "0x41F032C", VA = "0x41F432C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B5B")]
		public TextMeshProUGUI TextMeshProUGUITxtCongratulations
		{
			[Token(Token = "0x60044AF")]
			[Address(RVA = "0x41F3470", Offset = "0x41EF470", VA = "0x41F3470")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B5C")]
		public RectTransform RectTransformRewardRoot
		{
			[Token(Token = "0x60044B0")]
			[Address(RVA = "0x41EF8DC", Offset = "0x41EB8DC", VA = "0x41EF8DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B5D")]
		public GridLayoutGroup GridLayoutGroupRewardRoot
		{
			[Token(Token = "0x60044B1")]
			[Address(RVA = "0x41EF9F4", Offset = "0x41EB9F4", VA = "0x41EF9F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B5E")]
		public Image ImageImgResRoot
		{
			[Token(Token = "0x60044B2")]
			[Address(RVA = "0x41F09E0", Offset = "0x41EC9E0", VA = "0x41F09E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B5F")]
		public RectTransform RectTransformImgRes1
		{
			[Token(Token = "0x60044B3")]
			[Address(RVA = "0x41F240C", Offset = "0x41EE40C", VA = "0x41F240C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B60")]
		public Image ImageImgRes1
		{
			[Token(Token = "0x60044B4")]
			[Address(RVA = "0x41F17B0", Offset = "0x41ED7B0", VA = "0x41F17B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B61")]
		public TextMeshProUGUI TextMeshProUGUITxtRes1Num
		{
			[Token(Token = "0x60044B5")]
			[Address(RVA = "0x41F1940", Offset = "0x41ED940", VA = "0x41F1940")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B62")]
		public TextMeshProUGUI TextMeshProUGUITxtRes1Name
		{
			[Token(Token = "0x60044B6")]
			[Address(RVA = "0x41F1878", Offset = "0x41ED878", VA = "0x41F1878")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B63")]
		public RectTransform RectTransformImgRes2
		{
			[Token(Token = "0x60044B7")]
			[Address(RVA = "0x41F2578", Offset = "0x41EE578", VA = "0x41F2578")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B64")]
		public Image ImageImgRes2
		{
			[Token(Token = "0x60044B8")]
			[Address(RVA = "0x41F1A08", Offset = "0x41EDA08", VA = "0x41F1A08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B65")]
		public TextMeshProUGUI TextMeshProUGUITxtRes2Num
		{
			[Token(Token = "0x60044B9")]
			[Address(RVA = "0x41F1B98", Offset = "0x41EDB98", VA = "0x41F1B98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B66")]
		public TextMeshProUGUI TextMeshProUGUITxtRes2Name
		{
			[Token(Token = "0x60044BA")]
			[Address(RVA = "0x41F1AD0", Offset = "0x41EDAD0", VA = "0x41F1AD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60044BB")]
		[Address(RVA = "0x41F43F4", Offset = "0x41F03F4", VA = "0x41F43F4")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60044BC")]
		[Address(RVA = "0x41F0644", Offset = "0x41EC644", VA = "0x41F0644", Slot = "12")]
		protected virtual void OnButtonBGClicked()
		{
		}

		[Token(Token = "0x60044BD")]
		[Address(RVA = "0x41F033C", Offset = "0x41EC33C", VA = "0x41F033C", Slot = "13")]
		protected virtual void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x60044BE")]
		[Address(RVA = "0x41F0750", Offset = "0x41EC750", VA = "0x41F0750", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60044BF")]
		[Address(RVA = "0x41F0770", Offset = "0x41EC770", VA = "0x41F0770", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__175))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60044C0")]
		[Address(RVA = "0x41F092C", Offset = "0x41EC92C", VA = "0x41F092C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60044C1")]
		[Address(RVA = "0x41F072C", Offset = "0x41EC72C", VA = "0x41F072C")]
		public CongratulationsGetGiftPackPanelComponents()
		{
		}
	}
}
