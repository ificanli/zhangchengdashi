using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using TimeModuleO;

namespace UIModuleO
{
	[Token(Token = "0x200097C")]
	public class MainReadyPanel_BtnRoot_Left : MainReadyPanel_BtnRoot_LeftComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200097F")]
		[CompilerGenerated]
		private struct _003COnButtonExtendBtnGoldCardWeeklyClicked_003Ed__31 : IAsyncStateMachine
		{
			[Token(Token = "0x4004726")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004727")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004728")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MainReadyPanel_BtnRoot_Left _003C_003E4__this;

			[Token(Token = "0x6003802")]
			[Address(RVA = "0x40EFC80", Offset = "0x40EBC80", VA = "0x40EFC80", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003803")]
			[Address(RVA = "0x40EFDA4", Offset = "0x40EBDA4", VA = "0x40EFDA4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000980")]
		[CompilerGenerated]
		private struct _003COnButtonExtendBtnMysteriousStoreClicked_003Ed__32 : IAsyncStateMachine
		{
			[Token(Token = "0x4004729")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400472A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400472B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MainReadyPanel_BtnRoot_Left _003C_003E4__this;

			[Token(Token = "0x400472C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003804")]
			[Address(RVA = "0x40EFDB0", Offset = "0x40EBDB0", VA = "0x40EFDB0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003805")]
			[Address(RVA = "0x40F014C", Offset = "0x40EC14C", VA = "0x40F014C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000981")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x400472D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400472E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400472F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MainReadyPanel_BtnRoot_Left _003C_003E4__this;

			[Token(Token = "0x4004730")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003806")]
			[Address(RVA = "0x40F0158", Offset = "0x40EC158", VA = "0x40F0158", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003807")]
			[Address(RVA = "0x40F04CC", Offset = "0x40EC4CC", VA = "0x40F04CC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000982")]
		[CompilerGenerated]
		private struct _003CUpdateBtnArenaPackActive_003Ed__23 : IAsyncStateMachine
		{
			[Token(Token = "0x4004731")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004732")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MainReadyPanel_BtnRoot_Left _003C_003E4__this;

			[Token(Token = "0x4004734")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private ArenaPackageData _003Cdata_003E5__2;

			[Token(Token = "0x4004735")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private ShopArenaPackInfos _003Cconfig_003E5__3;

			[Token(Token = "0x4004736")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private GlobalIAPInfo _003CiapInfo_003E5__4;

			[Token(Token = "0x4004737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private GlobalHeroCardInfo _003CheroCardInfo_003E5__5;

			[Token(Token = "0x4004738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003808")]
			[Address(RVA = "0x40F04D8", Offset = "0x40EC4D8", VA = "0x40F04D8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003809")]
			[Address(RVA = "0x40F0A88", Offset = "0x40ECA88", VA = "0x40F0A88", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private TimeManager.Timer pushGiftPackCutDowm;

		[Token(Token = "0x400471A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private TimeManager.Timer giftChainTimer;

		[Token(Token = "0x400471B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private string curGiftChainKey;

		[Token(Token = "0x400471C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private float _checkTimer;

		[Token(Token = "0x400471D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private ArenaPackageData _arenaPackCachedData;

		[Token(Token = "0x400471E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private ShopArenaPackInfos _arenaPackCachedConfig;

		[Token(Token = "0x400471F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private GlobalIAPInfo _arenaPackCachedIap;

		[Token(Token = "0x4004720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private bool _worldCupEntryVisualConfigured;

		[Token(Token = "0x60037DC")]
		[Address(RVA = "0x40EB300", Offset = "0x40E7300", VA = "0x40EB300", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60037DD")]
		[Address(RVA = "0x40EBA90", Offset = "0x40E7A90", VA = "0x40EBA90")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60037DE")]
		[Address(RVA = "0x40EBCD4", Offset = "0x40E7CD4", VA = "0x40EBCD4", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__10))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60037DF")]
		[Address(RVA = "0x40EBD68", Offset = "0x40E7D68", VA = "0x40EBD68")]
		private void Update()
		{
		}

		[Token(Token = "0x60037E0")]
		[Address(RVA = "0x40ED0E0", Offset = "0x40E90E0", VA = "0x40ED0E0")]
		private void UpdateBtnSpecialOfferActive(object o)
		{
		}

		[Token(Token = "0x60037E1")]
		[Address(RVA = "0x40ED4C8", Offset = "0x40E94C8", VA = "0x40ED4C8")]
		private void UpdateBtnElitePackActive(object o)
		{
		}

		[Token(Token = "0x60037E2")]
		[Address(RVA = "0x40ED650", Offset = "0x40E9650", VA = "0x40ED650")]
		private void UpdateBtnPushPackActive(object o)
		{
		}

		[Token(Token = "0x60037E3")]
		[Address(RVA = "0x40ED93C", Offset = "0x40E993C", VA = "0x40ED93C")]
		private void UpdateGiftChain2BtnActive(object o)
		{
		}

		[Token(Token = "0x60037E4")]
		[Address(RVA = "0x40EDA48", Offset = "0x40E9A48", VA = "0x40EDA48")]
		private void GoldCardWeeklyBtnActive(object o)
		{
		}

		[Token(Token = "0x60037E5")]
		[Address(RVA = "0x40EDBDC", Offset = "0x40E9BDC", VA = "0x40EDBDC")]
		private void UpdateGoldCardWeeklyBtnSpine(object o)
		{
		}

		[Token(Token = "0x60037E6")]
		[Address(RVA = "0x40EDD10", Offset = "0x40E9D10", VA = "0x40EDD10")]
		private void UpdateGiftChainActive(object o)
		{
		}

		[Token(Token = "0x60037E7")]
		[Address(RVA = "0x40EE088", Offset = "0x40EA088", VA = "0x40EE088")]
		private void UpdateCustomSelectUITxt(object o)
		{
		}

		[Token(Token = "0x60037E8")]
		[Address(RVA = "0x40EE2A4", Offset = "0x40EA2A4", VA = "0x40EE2A4")]
		private void UpdateBtnMysteriousStoreActive(object o)
		{
		}

		[Token(Token = "0x60037E9")]
		[Address(RVA = "0x40ECEB4", Offset = "0x40E8EB4", VA = "0x40ECEB4")]
		private void UpdateBtnWorldCupActive(object o)
		{
		}

		[Token(Token = "0x60037EA")]
		[Address(RVA = "0x40EE328", Offset = "0x40EA328", VA = "0x40EE328")]
		private void ConfigureWorldCupEntryVisualIfNeeded()
		{
		}

		[Token(Token = "0x60037EB")]
		[Address(RVA = "0x40ECC90", Offset = "0x40E8C90", VA = "0x40ECC90")]
		[AsyncStateMachine(typeof(_003CUpdateBtnArenaPackActive_003Ed__23))]
		private void UpdateBtnArenaPackActive(object o)
		{
		}

		[Token(Token = "0x60037EC")]
		[Address(RVA = "0x40EE490", Offset = "0x40EA490", VA = "0x40EE490")]
		private bool TryGetArenaPackTopRareHero(GlobalIAPInfo iapInfo, out GlobalHeroCardInfo heroCardInfo)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MainReadyPanel_BtnRoot_Left.TryGetArenaPackTopRareHero RVA=0x40EE490 Token=0x60037EC");
}

		[Token(Token = "0x60037ED")]
		[Address(RVA = "0x40ED268", Offset = "0x40E9268", VA = "0x40ED268")]
		public void ResetView()
		{
		}

		[Token(Token = "0x60037EE")]
		[Address(RVA = "0x40EECAC", Offset = "0x40EACAC", VA = "0x40EECAC", Slot = "18")]
		protected override void OnButtonExtendBtnPushPackClicked()
		{
		}

		[Token(Token = "0x60037EF")]
		[Address(RVA = "0x40EEEA0", Offset = "0x40EAEA0", VA = "0x40EEEA0", Slot = "16")]
		protected override void OnButtonExtendBtnGiftChainClicked()
		{
		}

		[Token(Token = "0x60037F0")]
		[Address(RVA = "0x40EF034", Offset = "0x40EB034", VA = "0x40EF034", Slot = "19")]
		protected override void OnButtonExtendBtnSpecialOfferClicked()
		{
		}

		[Token(Token = "0x60037F1")]
		[Address(RVA = "0x40EF10C", Offset = "0x40EB10C", VA = "0x40EF10C", Slot = "20")]
		protected override void OnButtonExtendBtnElitePackClicked()
		{
		}

		[Token(Token = "0x60037F2")]
		[Address(RVA = "0x40EF1E4", Offset = "0x40EB1E4", VA = "0x40EF1E4", Slot = "17")]
		protected override void OnButtonExtendBtnGiftChain2Clicked()
		{
		}

		[Token(Token = "0x60037F3")]
		[Address(RVA = "0x40EF2BC", Offset = "0x40EB2BC", VA = "0x40EF2BC", Slot = "14")]
		[AsyncStateMachine(typeof(_003COnButtonExtendBtnGoldCardWeeklyClicked_003Ed__31))]
		protected override void OnButtonExtendBtnGoldCardWeeklyClicked()
		{
		}

		[Token(Token = "0x60037F4")]
		[Address(RVA = "0x40EF348", Offset = "0x40EB348", VA = "0x40EF348", Slot = "15")]
		[AsyncStateMachine(typeof(_003COnButtonExtendBtnMysteriousStoreClicked_003Ed__32))]
		protected override void OnButtonExtendBtnMysteriousStoreClicked()
		{
		}

		[Token(Token = "0x60037F5")]
		[Address(RVA = "0x40EF3D4", Offset = "0x40EB3D4", VA = "0x40EF3D4", Slot = "21")]
		protected override void OnButtonExtendBtnArenaPackClicked()
		{
		}

		[Token(Token = "0x60037F6")]
		[Address(RVA = "0x40EF5C0", Offset = "0x40EB5C0", VA = "0x40EF5C0", Slot = "22")]
		protected override void OnButtonExtendBtnWorldCupClicked()
		{
		}

		[Token(Token = "0x60037F7")]
		[Address(RVA = "0x40EF688", Offset = "0x40EB688", VA = "0x40EF688")]
		public MainReadyPanel_BtnRoot_Left()
		{
		}
	}
}
