using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using DataModule;
using GameModule;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000708")]
	public class BattleResultPanel : BattleResultPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200070A")]
		[CompilerGenerated]
		private struct _003CAdGiftPackHandle_003Ed__25 : IAsyncStateMachine
		{
			[Token(Token = "0x40037F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40037F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40037F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BattleResultPanel _003C_003E4__this;

			[Token(Token = "0x40037F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private bool _003CshowPack_003E5__2;

			[Token(Token = "0x40037F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UserHeroCardData _003Cdata_003E5__3;

			[Token(Token = "0x40037F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Image _003C_003E7__wrap3;

			[Token(Token = "0x40037F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600263F")]
			[Address(RVA = "0x3F9062C", Offset = "0x3F8C62C", VA = "0x3F9062C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002640")]
			[Address(RVA = "0x3F91AB8", Offset = "0x3F8DAB8", VA = "0x3F91AB8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200070B")]
		[CompilerGenerated]
		private struct _003CAwake_003Ed__18 : IAsyncStateMachine
		{
			[Token(Token = "0x40037FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40037FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40037FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BattleResultPanel _003C_003E4__this;

			[Token(Token = "0x6002641")]
			[Address(RVA = "0x3F91AC4", Offset = "0x3F8DAC4", VA = "0x3F91AC4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002642")]
			[Address(RVA = "0x3F91D54", Offset = "0x3F8DD54", VA = "0x3F91D54", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200070C")]
		[CompilerGenerated]
		private struct _003CGetBoxReward_003Ed__26 : IAsyncStateMachine
		{
			[Token(Token = "0x40037FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40037FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40037FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BattleResultPanel _003C_003E4__this;

			[Token(Token = "0x4003800")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4003801")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002643")]
			[Address(RVA = "0x3F91D60", Offset = "0x3F8DD60", VA = "0x3F91D60", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002644")]
			[Address(RVA = "0x3F92658", Offset = "0x3F8E658", VA = "0x3F92658", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200070D")]
		[CompilerGenerated]
		private struct _003CLoadPrefab_003Ed__19 : IAsyncStateMachine
		{
			[Token(Token = "0x4003802")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003803")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003804")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BattleResultPanel _003C_003E4__this;

			[Token(Token = "0x4003805")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002645")]
			[Address(RVA = "0x3F92664", Offset = "0x3F8E664", VA = "0x3F92664", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002646")]
			[Address(RVA = "0x3F92A58", Offset = "0x3F8EA58", VA = "0x3F92A58", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200070E")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__21 : IAsyncStateMachine
		{
			[Token(Token = "0x4003806")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003807")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003808")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BattleResultPanel _003C_003E4__this;

			[Token(Token = "0x4003809")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x400380A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private RewardConfig _003CrewardConfig_003E5__2;

			[Token(Token = "0x400380B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int _003CotherRewardCount_003E5__3;

			[Token(Token = "0x400380C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private bool _003ChasOther_003E5__4;

			[Token(Token = "0x400380D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int _003CwoodNum_003E5__5;

			[Token(Token = "0x400380E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002647")]
			[Address(RVA = "0x3F92A64", Offset = "0x3F8EA64", VA = "0x3F92A64", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002648")]
			[Address(RVA = "0x3F95194", Offset = "0x3F91194", VA = "0x3F95194", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200070F")]
		[CompilerGenerated]
		private struct _003CShowMvpModel_003Ed__27 : IAsyncStateMachine
		{
			[Token(Token = "0x400380F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003810")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003811")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BattleResultPanel _003C_003E4__this;

			[Token(Token = "0x4003812")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4003813")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002649")]
			[Address(RVA = "0x3F951A0", Offset = "0x3F911A0", VA = "0x3F951A0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600264A")]
			[Address(RVA = "0x3F9575C", Offset = "0x3F9175C", VA = "0x3F9575C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40037DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Tween _btnTw;

		[Token(Token = "0x40037DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private GameObject _rewardCardRes;

		[Token(Token = "0x40037E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private readonly List<GameObject> _rewardCardList;

		[Token(Token = "0x40037E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private string packCardId;

		[Token(Token = "0x40037E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private int cardNum;

		[Token(Token = "0x40037E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private int adGetCoinNumber;

		[Token(Token = "0x40037E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private GameObject rewardRes;

		[Token(Token = "0x40037E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private List<GameObject> allRewardObj;

		[Token(Token = "0x40037E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private List<GameObject> topRewardObj;

		[Token(Token = "0x40037E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private int TrophyNum;

		[Token(Token = "0x40037E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private BattleResult _battleResult;

		[Token(Token = "0x40037E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private string itemPath;

		[Token(Token = "0x40037EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private GameObject res;

		[Token(Token = "0x40037EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private bool canClose;

		[Token(Token = "0x40037EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private UserHeroCardData heroCardData;

		[Token(Token = "0x40037ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private bool isGetBox;

		[Token(Token = "0x40037EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
		private int getBoxId;

		[Token(Token = "0x40037EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private Vector3 roleIconPos;

		[Token(Token = "0x6002626")]
		[Address(RVA = "0x3F8DB40", Offset = "0x3F89B40", VA = "0x3F8DB40", Slot = "18")]
		protected override void OnButtonExtendBtnSureClicked()
		{
		}

		[Token(Token = "0x6002627")]
		[Address(RVA = "0x3F8DC30", Offset = "0x3F89C30", VA = "0x3F8DC30", Slot = "4")]
		[AsyncStateMachine(typeof(_003CAwake_003Ed__18))]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002628")]
		[Address(RVA = "0x3F8DCBC", Offset = "0x3F89CBC", VA = "0x3F8DCBC")]
		[AsyncStateMachine(typeof(_003CLoadPrefab_003Ed__19))]
		private UniTask LoadPrefab()
		{
			return default;
		}

		[Token(Token = "0x6002629")]
		[Address(RVA = "0x3F8DD4C", Offset = "0x3F89D4C", VA = "0x3F8DD4C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__21))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600262A")]
		[Address(RVA = "0x3F8DDEC", Offset = "0x3F89DEC", VA = "0x3F8DDEC")]
		private void AdPackGetCoinHandle()
		{
		}

		[Token(Token = "0x600262B")]
		[Address(RVA = "0x3F8DF9C", Offset = "0x3F89F9C", VA = "0x3F8DF9C")]
		private void PlayerGuidDataHandle()
		{
		}

		[Token(Token = "0x600262C")]
		[Address(RVA = "0x3F8E030", Offset = "0x3F8A030", VA = "0x3F8E030")]
		private void BattleWinStreakHandle()
		{
		}

		[Token(Token = "0x600262D")]
		[Address(RVA = "0x3F8E1B4", Offset = "0x3F8A1B4", VA = "0x3F8E1B4")]
		[AsyncStateMachine(typeof(_003CAdGiftPackHandle_003Ed__25))]
		private void AdGiftPackHandle()
		{
		}

		[Token(Token = "0x600262E")]
		[Address(RVA = "0x3F8E244", Offset = "0x3F8A244", VA = "0x3F8E244")]
		[AsyncStateMachine(typeof(_003CGetBoxReward_003Ed__26))]
		private void GetBoxReward()
		{
		}

		[Token(Token = "0x600262F")]
		[Address(RVA = "0x3F8E2D4", Offset = "0x3F8A2D4", VA = "0x3F8E2D4")]
		[AsyncStateMachine(typeof(_003CShowMvpModel_003Ed__27))]
		private void ShowMvpModel()
		{
		}

		[Token(Token = "0x6002630")]
		[Address(RVA = "0x3F8E364", Offset = "0x3F8A364", VA = "0x3F8E364")]
		private void AdCallBack()
		{
		}

		[Token(Token = "0x6002631")]
		[Address(RVA = "0x3F8ED1C", Offset = "0x3F8AD1C", VA = "0x3F8ED1C")]
		private void UpdateTxtWatchADPackCount()
		{
		}

		[Token(Token = "0x6002632")]
		[Address(RVA = "0x3F8EFEC", Offset = "0x3F8AFEC", VA = "0x3F8EFEC", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002633")]
		[Address(RVA = "0x3F8FA1C", Offset = "0x3F8BA1C", VA = "0x3F8FA1C")]
		public void ShowDefeatPanelAFKTips(object parms)
		{
		}

		[Token(Token = "0x6002634")]
		[Address(RVA = "0x3F8FA6C", Offset = "0x3F8BA6C", VA = "0x3F8FA6C", Slot = "14")]
		protected override void OnButtonImgCardItemClicked()
		{
		}

		[Token(Token = "0x6002635")]
		[Address(RVA = "0x3F8FC28", Offset = "0x3F8BC28", VA = "0x3F8FC28", Slot = "15")]
		protected override void OnButtonExtendImgCoinIconClicked()
		{
		}

		[Token(Token = "0x6002636")]
		[Address(RVA = "0x3F8FECC", Offset = "0x3F8BECC", VA = "0x3F8FECC", Slot = "16")]
		protected override void OnButtonExtendImgWoodIconClicked()
		{
		}

		[Token(Token = "0x6002637")]
		[Address(RVA = "0x3F90170", Offset = "0x3F8C170", VA = "0x3F90170", Slot = "13")]
		protected override void OnButtonExtendImgBoxBgClicked()
		{
		}

		[Token(Token = "0x6002638")]
		[Address(RVA = "0x3F90380", Offset = "0x3F8C380", VA = "0x3F90380")]
		public BattleResultPanel()
		{
		}
	}
}
