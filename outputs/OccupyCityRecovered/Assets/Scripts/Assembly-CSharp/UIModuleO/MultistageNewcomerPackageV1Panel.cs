using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x20009A1")]
	public class MultistageNewcomerPackageV1Panel : MultistageNewcomerPackageV1PanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009A5")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__13 : IAsyncStateMachine
		{
			[Token(Token = "0x4004810")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004811")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004812")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MultistageNewcomerPackageV1Panel _003C_003E4__this;

			[Token(Token = "0x4004813")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600393C")]
			[Address(RVA = "0x41033D8", Offset = "0x40FF3D8", VA = "0x41033D8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600393D")]
			[Address(RVA = "0x41036D0", Offset = "0x40FF6D0", VA = "0x41036D0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004800")]
		private const int PackageCount = 3;

		[Token(Token = "0x4004801")]
		private const float CountdownRefreshInterval = 1f;

		[Token(Token = "0x4004802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private int _index;

		[Token(Token = "0x4004803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private string _placement;

		[Token(Token = "0x4004804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private float _countdownRefreshTimer;

		[Token(Token = "0x4004805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private bool _isSyncingToggle;

		[Token(Token = "0x4004806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 _cardLightBaseLocalEuler;

		[Token(Token = "0x4004807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector2 _cardItemBaseAnchoredPos;

		[Token(Token = "0x4004808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private readonly List<dayAwardItem> _dayAwardItems;

		[Token(Token = "0x4004809")]
		private const float CardFloatDuration = 1.2f;

		[Token(Token = "0x400480A")]
		private const float CardFloatOffsetY = 15f;

		[Token(Token = "0x400480B")]
		private const float CardLightRotateSecondsPerTurn = 14f;

		[Token(Token = "0x600391F")]
		[Address(RVA = "0x40FFD0C", Offset = "0x40FBD0C", VA = "0x40FFD0C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6003920")]
		[Address(RVA = "0x4100578", Offset = "0x40FC578", VA = "0x4100578", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__13))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003921")]
		[Address(RVA = "0x410060C", Offset = "0x40FC60C", VA = "0x410060C")]
		private void PlayCardFloatAndCardLightLoop()
		{
		}

		[Token(Token = "0x6003922")]
		[Address(RVA = "0x410081C", Offset = "0x40FC81C", VA = "0x410081C")]
		private void Update()
		{
		}

		[Token(Token = "0x6003923")]
		[Address(RVA = "0x4100BBC", Offset = "0x40FCBBC", VA = "0x4100BBC")]
		private void SetCurrentPackageIndex(int tempIndex, bool syncToggle)
		{
		}

		[Token(Token = "0x6003924")]
		[Address(RVA = "0x4100F6C", Offset = "0x40FCF6C", VA = "0x4100F6C")]
		private void DataRefreshView()
		{
		}

		[Token(Token = "0x6003925")]
		[Address(RVA = "0x410105C", Offset = "0x40FD05C", VA = "0x410105C")]
		private void RefreshView()
		{
		}

		[Token(Token = "0x6003926")]
		[Address(RVA = "0x4100874", Offset = "0x40FC874", VA = "0x4100874")]
		private void RefreshCountdown()
		{
		}

		[Token(Token = "0x6003927")]
		[Address(RVA = "0x410214C", Offset = "0x40FE14C", VA = "0x410214C")]
		private static bool CanClaim(MultistageNewcomerPackageData userData)
		{
			return default;
		}

		[Token(Token = "0x6003928")]
		[Address(RVA = "0x4101970", Offset = "0x40FD970", VA = "0x4101970")]
		private static string GetCardNumber(string rewardConfig)
		{
			return null;
		}

		[Token(Token = "0x6003929")]
		[Address(RVA = "0x4101E10", Offset = "0x40FDE10", VA = "0x4101E10")]
		private void EnsureDayAwardItems()
		{
		}

		[Token(Token = "0x600392A")]
		[Address(RVA = "0x4102984", Offset = "0x40FE984", VA = "0x4102984", Slot = "14")]
		protected override void OnButtonExtendClaimBtnClicked()
		{
		}

		[Token(Token = "0x600392B")]
		[Address(RVA = "0x4102A4C", Offset = "0x40FEA4C", VA = "0x4102A4C", Slot = "16")]
		protected override void OnToggleLevel1ValueChanged(bool arg)
		{
		}

		[Token(Token = "0x600392C")]
		[Address(RVA = "0x4102B3C", Offset = "0x40FEB3C", VA = "0x4102B3C", Slot = "17")]
		protected override void OnToggleLevel2ValueChanged(bool arg)
		{
		}

		[Token(Token = "0x600392D")]
		[Address(RVA = "0x4102C30", Offset = "0x40FEC30", VA = "0x4102C30", Slot = "18")]
		protected override void OnToggleLevel3ValueChanged(bool arg)
		{
		}

		[Token(Token = "0x600392E")]
		[Address(RVA = "0x4102D24", Offset = "0x40FED24", VA = "0x4102D24", Slot = "13")]
		protected override void OnButtonExtendCloseClicked()
		{
		}

		[Token(Token = "0x600392F")]
		[Address(RVA = "0x4102DB0", Offset = "0x40FEDB0", VA = "0x4102DB0", Slot = "12")]
		protected override void OnButtonBackgroundClicked()
		{
		}

		[Token(Token = "0x6003930")]
		[Address(RVA = "0x4102E3C", Offset = "0x40FEE3C", VA = "0x4102E3C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6003931")]
		[Address(RVA = "0x4102F60", Offset = "0x40FEF60", VA = "0x4102F60", Slot = "7")]
		protected override void OnHideAnimationComplete()
		{
		}

		[Token(Token = "0x6003932")]
		[Address(RVA = "0x4103100", Offset = "0x40FF100", VA = "0x4103100")]
		public MultistageNewcomerPackageV1Panel()
		{
		}
	}
}
