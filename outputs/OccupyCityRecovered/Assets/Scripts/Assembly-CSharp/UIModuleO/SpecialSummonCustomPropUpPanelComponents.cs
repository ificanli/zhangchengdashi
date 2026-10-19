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

namespace UIModuleO
{
	[Token(Token = "0x2000B7B")]
	public class SpecialSummonCustomPropUpPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B7C")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__285 : IAsyncStateMachine
		{
			[Token(Token = "0x40053B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40053BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40053BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SpecialSummonCustomPropUpPanelComponents _003C_003E4__this;

			[Token(Token = "0x40053BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004671")]
			[Address(RVA = "0x4215230", Offset = "0x4211230", VA = "0x4215230", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004672")]
			[Address(RVA = "0x42154A8", Offset = "0x42114A8", VA = "0x42154A8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40053AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBG;

		[Token(Token = "0x40053AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ButtonExtend _buttonExtendCloseBtn;

		[Token(Token = "0x40053B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformRewardRoot;

		[Token(Token = "0x40053B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private SpecialSummonCustomPropItem _specialSummonCustomPropItemPropItem;

		[Token(Token = "0x40053B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ButtonExtend _buttonExtendChangeBtn;

		[Token(Token = "0x40053B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RectTransform _rectTransformConfirmPanel;

		[Token(Token = "0x40053B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ButtonExtend _buttonExtendMask;

		[Token(Token = "0x40053B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ButtonExtend _buttonExtendCloseConfirmBtn;

		[Token(Token = "0x40053B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUIChnageCost;

		[Token(Token = "0x40053B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ButtonExtend _buttonExtendConfirmBtn;

		[Token(Token = "0x40053B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private ButtonExtend _buttonExtendCancelbtn;

		[Token(Token = "0x17000BDB")]
		public ButtonExtend ButtonExtendBG
		{
			[Token(Token = "0x6004659")]
			[Address(RVA = "0x421485C", Offset = "0x421085C", VA = "0x421485C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BDC")]
		public ButtonExtend ButtonExtendCloseBtn
		{
			[Token(Token = "0x600465A")]
			[Address(RVA = "0x4214924", Offset = "0x4210924", VA = "0x4214924")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BDD")]
		public RectTransform RectTransformRewardRoot
		{
			[Token(Token = "0x600465B")]
			[Address(RVA = "0x4213D64", Offset = "0x420FD64", VA = "0x4213D64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BDE")]
		public SpecialSummonCustomPropItem SpecialSummonCustomPropItemPropItem
		{
			[Token(Token = "0x600465C")]
			[Address(RVA = "0x4213C9C", Offset = "0x420FC9C", VA = "0x4213C9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BDF")]
		public ButtonExtend ButtonExtendChangeBtn
		{
			[Token(Token = "0x600465D")]
			[Address(RVA = "0x4213FB8", Offset = "0x420FFB8", VA = "0x4213FB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BE0")]
		public RectTransform RectTransformConfirmPanel
		{
			[Token(Token = "0x600465E")]
			[Address(RVA = "0x4214080", Offset = "0x4210080", VA = "0x4214080")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BE1")]
		public ButtonExtend ButtonExtendMask
		{
			[Token(Token = "0x600465F")]
			[Address(RVA = "0x42149EC", Offset = "0x42109EC", VA = "0x42149EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BE2")]
		public ButtonExtend ButtonExtendCloseConfirmBtn
		{
			[Token(Token = "0x6004660")]
			[Address(RVA = "0x4214AB4", Offset = "0x4210AB4", VA = "0x4214AB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BE3")]
		public TextMeshProUGUI TextMeshProUGUIChnageCost
		{
			[Token(Token = "0x6004661")]
			[Address(RVA = "0x4214148", Offset = "0x4210148", VA = "0x4214148")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BE4")]
		public ButtonExtend ButtonExtendConfirmBtn
		{
			[Token(Token = "0x6004662")]
			[Address(RVA = "0x4214B7C", Offset = "0x4210B7C", VA = "0x4214B7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BE5")]
		public ButtonExtend ButtonExtendCancelbtn
		{
			[Token(Token = "0x6004663")]
			[Address(RVA = "0x4214C44", Offset = "0x4210C44", VA = "0x4214C44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004664")]
		[Address(RVA = "0x4214D0C", Offset = "0x4210D0C", VA = "0x4214D0C")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004665")]
		[Address(RVA = "0x4214F34", Offset = "0x4210F34", VA = "0x4214F34", Slot = "12")]
		protected virtual void OnButtonExtendBGClicked()
		{
		}

		[Token(Token = "0x6004666")]
		[Address(RVA = "0x4214FA0", Offset = "0x4210FA0", VA = "0x4214FA0", Slot = "13")]
		protected virtual void OnButtonExtendCloseBtnClicked()
		{
		}

		[Token(Token = "0x6004667")]
		[Address(RVA = "0x421500C", Offset = "0x421100C", VA = "0x421500C", Slot = "14")]
		protected virtual void OnButtonExtendChangeBtnClicked()
		{
		}

		[Token(Token = "0x6004668")]
		[Address(RVA = "0x4215078", Offset = "0x4211078", VA = "0x4215078", Slot = "15")]
		protected virtual void OnButtonExtendMaskClicked()
		{
		}

		[Token(Token = "0x6004669")]
		[Address(RVA = "0x42150E4", Offset = "0x42110E4", VA = "0x42150E4", Slot = "16")]
		protected virtual void OnButtonExtendCloseConfirmBtnClicked()
		{
		}

		[Token(Token = "0x600466A")]
		[Address(RVA = "0x4215150", Offset = "0x4211150", VA = "0x4215150", Slot = "17")]
		protected virtual void OnButtonExtendConfirmBtnClicked()
		{
		}

		[Token(Token = "0x600466B")]
		[Address(RVA = "0x42151BC", Offset = "0x42111BC", VA = "0x42151BC", Slot = "18")]
		protected virtual void OnButtonExtendCancelbtnClicked()
		{
		}

		[Token(Token = "0x600466C")]
		[Address(RVA = "0x42130F0", Offset = "0x420F0F0", VA = "0x42130F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600466D")]
		[Address(RVA = "0x42142AC", Offset = "0x42102AC", VA = "0x42142AC", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__285))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600466E")]
		[Address(RVA = "0x42136AC", Offset = "0x420F6AC", VA = "0x42136AC", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600466F")]
		[Address(RVA = "0x42142A0", Offset = "0x42102A0", VA = "0x42142A0")]
		public SpecialSummonCustomPropUpPanelComponents()
		{
		}
	}
}
