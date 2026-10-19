using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20009AE")]
	public class MysteriousStoreItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009AF")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__297 : IAsyncStateMachine
		{
			[Token(Token = "0x4004854")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004855")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004856")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteriousStoreItemComponents _003C_003E4__this;

			[Token(Token = "0x4004857")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003998")]
			[Address(RVA = "0x41064D4", Offset = "0x41024D4", VA = "0x41064D4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003999")]
			[Address(RVA = "0x410674C", Offset = "0x410274C", VA = "0x410674C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400484D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendMysteriousStoreItem;

		[Token(Token = "0x400484E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI _textMeshProUGUIName;

		[Token(Token = "0x400484F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUIPurchasedText;

		[Token(Token = "0x4004850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUIPriceText;

		[Token(Token = "0x4004851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RewardItemUI _rewardItemUIRewardItemUI;

		[Token(Token = "0x4004852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUIDiscountText;

		[Token(Token = "0x4004853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Image _imageIsGet;

		[Token(Token = "0x170008CA")]
		public ButtonExtend ButtonExtendMysteriousStoreItem
		{
			[Token(Token = "0x600398A")]
			[Address(RVA = "0x410623C", Offset = "0x410223C", VA = "0x410623C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008CB")]
		public TextMeshProUGUI TextMeshProUGUIName
		{
			[Token(Token = "0x600398B")]
			[Address(RVA = "0x4105A6C", Offset = "0x4101A6C", VA = "0x4105A6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008CC")]
		public TextMeshProUGUI TextMeshProUGUIPurchasedText
		{
			[Token(Token = "0x600398C")]
			[Address(RVA = "0x41058DC", Offset = "0x41018DC", VA = "0x41058DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008CD")]
		public TextMeshProUGUI TextMeshProUGUIPriceText
		{
			[Token(Token = "0x600398D")]
			[Address(RVA = "0x41059A4", Offset = "0x41019A4", VA = "0x41059A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008CE")]
		public RewardItemUI RewardItemUIRewardItemUI
		{
			[Token(Token = "0x600398E")]
			[Address(RVA = "0x4105BFC", Offset = "0x4101BFC", VA = "0x4105BFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008CF")]
		public TextMeshProUGUI TextMeshProUGUIDiscountText
		{
			[Token(Token = "0x600398F")]
			[Address(RVA = "0x4105B34", Offset = "0x4101B34", VA = "0x4105B34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008D0")]
		public Image ImageIsGet
		{
			[Token(Token = "0x6003990")]
			[Address(RVA = "0x4105814", Offset = "0x4101814", VA = "0x4105814")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003991")]
		[Address(RVA = "0x41062E0", Offset = "0x41022E0", VA = "0x41062E0")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6003992")]
		[Address(RVA = "0x4105D64", Offset = "0x4101D64", VA = "0x4105D64", Slot = "12")]
		protected virtual void OnButtonExtendMysteriousStoreItemClicked()
		{
		}

		[Token(Token = "0x6003993")]
		[Address(RVA = "0x4106368", Offset = "0x4102368", VA = "0x4106368", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6003994")]
		[Address(RVA = "0x4106384", Offset = "0x4102384", VA = "0x4106384", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__297))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003995")]
		[Address(RVA = "0x4106418", Offset = "0x4102418", VA = "0x4106418", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6003996")]
		[Address(RVA = "0x4105D58", Offset = "0x4101D58", VA = "0x4105D58")]
		public MysteriousStoreItemComponents()
		{
		}
	}
}
