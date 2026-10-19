using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using Spine.Unity;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000A85")]
	public class OpenBoxAnimationPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A86")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__109 : IAsyncStateMachine
		{
			[Token(Token = "0x4004DB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004DB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004DB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public OpenBoxAnimationPanelComponents _003C_003E4__this;

			[Token(Token = "0x4004DBA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003F60")]
			[Address(RVA = "0x417D63C", Offset = "0x417963C", VA = "0x417D63C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003F61")]
			[Address(RVA = "0x417D8B4", Offset = "0x41798B4", VA = "0x417D8B4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004DB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Button _buttonBG;

		[Token(Token = "0x4004DB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SkeletonGraphic _skeletonGraphicBoxSpine;

		[Token(Token = "0x4004DB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformBoxSpineTargetPos;

		[Token(Token = "0x4004DB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUITxtTapToGetReward;

		[Token(Token = "0x4004DB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RectTransform _rectTransformRewardPosition;

		[Token(Token = "0x4004DB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RectTransform _rectTransformRewardRoot;

		[Token(Token = "0x4004DB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ButtonExtend _buttonExtendBtnSkip;

		[Token(Token = "0x170009B8")]
		public Button ButtonBG
		{
			[Token(Token = "0x6003F51")]
			[Address(RVA = "0x417D498", Offset = "0x4179498", VA = "0x417D498")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009B9")]
		public SkeletonGraphic SkeletonGraphicBoxSpine
		{
			[Token(Token = "0x6003F52")]
			[Address(RVA = "0x417A78C", Offset = "0x417678C", VA = "0x417A78C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009BA")]
		public RectTransform RectTransformBoxSpineTargetPos
		{
			[Token(Token = "0x6003F53")]
			[Address(RVA = "0x417BD64", Offset = "0x4177D64", VA = "0x417BD64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009BB")]
		public TextMeshProUGUI TextMeshProUGUITxtTapToGetReward
		{
			[Token(Token = "0x6003F54")]
			[Address(RVA = "0x417ADAC", Offset = "0x4176DAC", VA = "0x417ADAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009BC")]
		public RectTransform RectTransformRewardPosition
		{
			[Token(Token = "0x6003F55")]
			[Address(RVA = "0x417A558", Offset = "0x4176558", VA = "0x417A558")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009BD")]
		public RectTransform RectTransformRewardRoot
		{
			[Token(Token = "0x6003F56")]
			[Address(RVA = "0x417BC9C", Offset = "0x4177C9C", VA = "0x417BC9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009BE")]
		public ButtonExtend ButtonExtendBtnSkip
		{
			[Token(Token = "0x6003F57")]
			[Address(RVA = "0x417ACE4", Offset = "0x4176CE4", VA = "0x417ACE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003F58")]
		[Address(RVA = "0x417D560", Offset = "0x4179560", VA = "0x417D560")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6003F59")]
		[Address(RVA = "0x417B3D0", Offset = "0x41773D0", VA = "0x417B3D0", Slot = "12")]
		protected virtual void OnButtonBGClicked()
		{
		}

		[Token(Token = "0x6003F5A")]
		[Address(RVA = "0x417A90C", Offset = "0x417690C", VA = "0x417A90C", Slot = "13")]
		protected virtual void OnButtonExtendBtnSkipClicked()
		{
		}

		[Token(Token = "0x6003F5B")]
		[Address(RVA = "0x417A53C", Offset = "0x417653C", VA = "0x417A53C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6003F5C")]
		[Address(RVA = "0x417B210", Offset = "0x4177210", VA = "0x417B210", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__109))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003F5D")]
		[Address(RVA = "0x417B0E0", Offset = "0x41770E0", VA = "0x417B0E0", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6003F5E")]
		[Address(RVA = "0x417B204", Offset = "0x4177204", VA = "0x417B204")]
		public OpenBoxAnimationPanelComponents()
		{
		}
	}
}
