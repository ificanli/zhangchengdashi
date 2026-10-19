using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000AFE")]
	public class SeasonPassRewardItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AFF")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__286 : IAsyncStateMachine
		{
			[Token(Token = "0x400509B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400509C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400509D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SeasonPassRewardItemComponents _003C_003E4__this;

			[Token(Token = "0x400509E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60042A6")]
			[Address(RVA = "0x41D17AC", Offset = "0x41CD7AC", VA = "0x41D17AC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60042A7")]
			[Address(RVA = "0x41D1A24", Offset = "0x41CDA24", VA = "0x41D1A24", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Image _imageSeasonPassRewardItem;

		[Token(Token = "0x4005094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RewardItemUI _rewardItemUIRewardItemUI1;

		[Token(Token = "0x4005095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformImgMask;

		[Token(Token = "0x4005096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private DOTweenAnimation _dOTweenAnimationImgMask;

		[Token(Token = "0x4005097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Image _imageLockImage;

		[Token(Token = "0x4005098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Image _imageHadClaim;

		[Token(Token = "0x4005099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ButtonExtend _buttonExtendShowDes;

		[Token(Token = "0x400509A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ButtonExtend _buttonExtendClaimBtn1;

		[Token(Token = "0x17000AB6")]
		public Image ImageSeasonPassRewardItem
		{
			[Token(Token = "0x6004296")]
			[Address(RVA = "0x41D0414", Offset = "0x41CC414", VA = "0x41D0414")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AB7")]
		public RewardItemUI RewardItemUIRewardItemUI1
		{
			[Token(Token = "0x6004297")]
			[Address(RVA = "0x41D05F4", Offset = "0x41CC5F4", VA = "0x41D05F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AB8")]
		public RectTransform RectTransformImgMask
		{
			[Token(Token = "0x6004298")]
			[Address(RVA = "0x41D1414", Offset = "0x41CD414", VA = "0x41D1414")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AB9")]
		public DOTweenAnimation DOTweenAnimationImgMask
		{
			[Token(Token = "0x6004299")]
			[Address(RVA = "0x41D134C", Offset = "0x41CD34C", VA = "0x41D134C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000ABA")]
		public Image ImageLockImage
		{
			[Token(Token = "0x600429A")]
			[Address(RVA = "0x41D0860", Offset = "0x41CC860", VA = "0x41D0860")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000ABB")]
		public Image ImageHadClaim
		{
			[Token(Token = "0x600429B")]
			[Address(RVA = "0x41D0798", Offset = "0x41CC798", VA = "0x41D0798")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000ABC")]
		public ButtonExtend ButtonExtendShowDes
		{
			[Token(Token = "0x600429C")]
			[Address(RVA = "0x41D14E8", Offset = "0x41CD4E8", VA = "0x41D14E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000ABD")]
		public ButtonExtend ButtonExtendClaimBtn1
		{
			[Token(Token = "0x600429D")]
			[Address(RVA = "0x41D0928", Offset = "0x41CC928", VA = "0x41D0928")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600429E")]
		[Address(RVA = "0x41D15B0", Offset = "0x41CD5B0", VA = "0x41D15B0")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x600429F")]
		[Address(RVA = "0x41D1684", Offset = "0x41CD684", VA = "0x41D1684", Slot = "12")]
		protected virtual void OnButtonExtendShowDesClicked()
		{
		}

		[Token(Token = "0x60042A0")]
		[Address(RVA = "0x41D0A7C", Offset = "0x41CCA7C", VA = "0x41D0A7C", Slot = "13")]
		protected virtual void OnButtonExtendClaimBtn1Clicked()
		{
		}

		[Token(Token = "0x60042A1")]
		[Address(RVA = "0x41D03F8", Offset = "0x41CC3F8", VA = "0x41D03F8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60042A2")]
		[Address(RVA = "0x41D0B0C", Offset = "0x41CCB0C", VA = "0x41D0B0C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__286))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60042A3")]
		[Address(RVA = "0x41D16F0", Offset = "0x41CD6F0", VA = "0x41D16F0", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60042A4")]
		[Address(RVA = "0x41D0B00", Offset = "0x41CCB00", VA = "0x41D0B00")]
		public SeasonPassRewardItemComponents()
		{
		}
	}
}
