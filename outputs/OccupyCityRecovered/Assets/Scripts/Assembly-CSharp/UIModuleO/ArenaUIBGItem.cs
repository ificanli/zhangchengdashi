using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000946")]
	public class ArenaUIBGItem : ArenaUIBGItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000949")]
		[CompilerGenerated]
		private struct _003CInitInfo_003Ed__21 : IAsyncStateMachine
		{
			[Token(Token = "0x4004594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ArenaUIBGItem _003C_003E4__this;

			[Token(Token = "0x4004597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public UserArenaData data;

			[Token(Token = "0x4004598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int index;

			[Token(Token = "0x6003631")]
			[Address(RVA = "0x40C8304", Offset = "0x40C4304", VA = "0x40C8304", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003632")]
			[Address(RVA = "0x40C8810", Offset = "0x40C4810", VA = "0x40C8810", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200094A")]
		[CompilerGenerated]
		private struct _003CUpdateUI_003Ed__23 : IAsyncStateMachine
		{
			[Token(Token = "0x4004599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400459A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400459B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ArenaUIBGItem _003C_003E4__this;

			[Token(Token = "0x400459C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x400459D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x6003633")]
			[Address(RVA = "0x40C881C", Offset = "0x40C481C", VA = "0x40C881C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003634")]
			[Address(RVA = "0x40CAC00", Offset = "0x40C6C00", VA = "0x40CAC00", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private float _chooseArenaNums;

		[Token(Token = "0x4004583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
		private bool _isDrag;

		[Token(Token = "0x4004584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1ED")]
		private bool _flipEd;

		[Token(Token = "0x4004585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		public UserArenaData data;

		[Token(Token = "0x4004586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private GlobalArenaInfo arenaInfo;

		[Token(Token = "0x4004587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private int index;

		[Token(Token = "0x4004588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private Sequence btnSequence;

		[Token(Token = "0x4004589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private Sequence iconSequence;

		[Token(Token = "0x400458A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private bool banClick;

		[Token(Token = "0x400458B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private string betRewardNum;

		[Token(Token = "0x400458C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private Tween _tween;

		[Token(Token = "0x170007BE")]
		public Transform StartBtn
		{
			[Token(Token = "0x60035FA")]
			[Address(RVA = "0x40C22A0", Offset = "0x40BE2A0", VA = "0x40C22A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007BF")]
		public Transform StartBtnLeft
		{
			[Token(Token = "0x60035FB")]
			[Address(RVA = "0x40C2384", Offset = "0x40BE384", VA = "0x40C2384")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007C0")]
		public Transform StartBtnRight
		{
			[Token(Token = "0x60035FC")]
			[Address(RVA = "0x40C2468", Offset = "0x40BE468", VA = "0x40C2468")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60035FD")]
		[Address(RVA = "0x40C254C", Offset = "0x40BE54C", VA = "0x40C254C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60035FE")]
		[Address(RVA = "0x40C2B4C", Offset = "0x40BEB4C", VA = "0x40C2B4C")]
		private void BeginBanClick(object o)
		{
		}

		[Token(Token = "0x60035FF")]
		[Address(RVA = "0x40C2B58", Offset = "0x40BEB58", VA = "0x40C2B58")]
		private void EndBanClick(object o)
		{
		}

		[Token(Token = "0x6003600")]
		[Address(RVA = "0x40C2B60", Offset = "0x40BEB60", VA = "0x40C2B60")]
		private void BetUpdateCoinUI(object o)
		{
		}

		[Token(Token = "0x6003601")]
		[Address(RVA = "0x40C2CA8", Offset = "0x40BECA8", VA = "0x40C2CA8")]
		private void BetRecordRewardNum(object o)
		{
		}

		[Token(Token = "0x6003602")]
		[Address(RVA = "0x40C2CD8", Offset = "0x40BECD8", VA = "0x40C2CD8")]
		[AsyncStateMachine(typeof(_003CInitInfo_003Ed__21))]
		public void InitInfo(UserArenaData data, int index)
		{
		}

		[Token(Token = "0x6003603")]
		[Address(RVA = "0x40C2D78", Offset = "0x40BED78", VA = "0x40C2D78")]
		public void ArenaIconDoAni()
		{
		}

		[Token(Token = "0x6003604")]
		[Address(RVA = "0x40C2F90", Offset = "0x40BEF90", VA = "0x40C2F90")]
		[AsyncStateMachine(typeof(_003CUpdateUI_003Ed__23))]
		public void UpdateUI()
		{
		}

		[Token(Token = "0x6003605")]
		[Address(RVA = "0x40C3020", Offset = "0x40BF020", VA = "0x40C3020")]
		private void UpdatePvpTextUI()
		{
		}

		[Token(Token = "0x6003606")]
		[Address(RVA = "0x40C3DCC", Offset = "0x40BFDCC", VA = "0x40C3DCC")]
		public void TrophyProgressReset()
		{
		}

		[Token(Token = "0x6003607")]
		[Address(RVA = "0x40C4034", Offset = "0x40C0034", VA = "0x40C4034")]
		private void OnMainReadyPanelChangeActive(object o)
		{
		}

		[Token(Token = "0x6003608")]
		[Address(RVA = "0x40C4100", Offset = "0x40C0100", VA = "0x40C4100")]
		public void DiamondIconDoScale()
		{
		}

		[Token(Token = "0x6003609")]
		[Address(RVA = "0x40C42AC", Offset = "0x40C02AC", VA = "0x40C42AC")]
		public void KeyIconDoScale()
		{
		}

		[Token(Token = "0x600360A")]
		[Address(RVA = "0x40C4458", Offset = "0x40C0458", VA = "0x40C4458")]
		public void BoxIconDoScale()
		{
		}

		[Token(Token = "0x600360B")]
		[Address(RVA = "0x40C4604", Offset = "0x40C0604", VA = "0x40C4604")]
		public void TrophyProcessDoAni()
		{
		}

		[Token(Token = "0x600360C")]
		[Address(RVA = "0x40C4A90", Offset = "0x40C0A90", VA = "0x40C4A90")]
		public void DoFlip()
		{
		}

		[Token(Token = "0x600360D")]
		[Address(RVA = "0x40C4C38", Offset = "0x40C0C38", VA = "0x40C4C38")]
		private void TrophyLockImgSetTrue(bool isAni = false)
		{
		}

		[Token(Token = "0x600360E")]
		[Address(RVA = "0x40C4F4C", Offset = "0x40C0F4C", VA = "0x40C4F4C")]
		public void ImgDiamondDoubleSetTrue(bool isAni = false)
		{
		}

		[Token(Token = "0x600360F")]
		[Address(RVA = "0x40C5100", Offset = "0x40C1100", VA = "0x40C5100")]
		public void ImgKeyDoubleSetTrue(bool isAni = false)
		{
		}

		[Token(Token = "0x6003610")]
		[Address(RVA = "0x40C52B4", Offset = "0x40C12B4", VA = "0x40C52B4")]
		public void ImgBoxDoubleSetTrue(bool isAni = false)
		{
		}

		[Token(Token = "0x6003611")]
		[Address(RVA = "0x40C48DC", Offset = "0x40C08DC", VA = "0x40C48DC")]
		private void ScrollNumber(int fromVal, int toVal, float dur)
		{
		}

		[Token(Token = "0x6003612")]
		[Address(RVA = "0x40C5470", Offset = "0x40C1470", VA = "0x40C5470", Slot = "14")]
		protected override void OnButtonExtendStartBtnClicked()
		{
		}

		[Token(Token = "0x6003613")]
		[Address(RVA = "0x40C2A30", Offset = "0x40BEA30", VA = "0x40C2A30")]
		private void UpdateBtnButtonArenaInteractable()
		{
		}

		[Token(Token = "0x6003614")]
		[Address(RVA = "0x40C58C4", Offset = "0x40C18C4", VA = "0x40C58C4")]
		private void OnTrainingGroundComplete(object o)
		{
		}

		[Token(Token = "0x6003615")]
		[Address(RVA = "0x40C58C8", Offset = "0x40C18C8", VA = "0x40C58C8", Slot = "12")]
		protected override void OnButtonExtendBtnButtonArenaClicked()
		{
		}

		[Token(Token = "0x6003616")]
		[Address(RVA = "0x40C5998", Offset = "0x40C1998", VA = "0x40C5998", Slot = "13")]
		protected override void OnButtonBotRewardBGClicked()
		{
		}

		[Token(Token = "0x6003617")]
		[Address(RVA = "0x40C5AC8", Offset = "0x40C1AC8", VA = "0x40C5AC8")]
		public void DoAniMation()
		{
		}

		[Token(Token = "0x6003618")]
		[Address(RVA = "0x40C5ACC", Offset = "0x40C1ACC", VA = "0x40C5ACC")]
		private void UpdateTrophyProgressUI(object o)
		{
		}

		[Token(Token = "0x6003619")]
		[Address(RVA = "0x40C5EE8", Offset = "0x40C1EE8", VA = "0x40C5EE8")]
		private void GameWin(object o)
		{
		}

		[Token(Token = "0x600361A")]
		[Address(RVA = "0x40C5EEC", Offset = "0x40C1EEC", VA = "0x40C5EEC")]
		private void CheckStayUnLocakArena(object o)
		{
		}

		[Token(Token = "0x600361B")]
		[Address(RVA = "0x40C6044", Offset = "0x40C2044", VA = "0x40C6044")]
		public void DoUnLockAni()
		{
		}

		[Token(Token = "0x600361C")]
		[Address(RVA = "0x40C6270", Offset = "0x40C2270", VA = "0x40C6270")]
		public void ShowLockUI()
		{
		}

		[Token(Token = "0x600361D")]
		[Address(RVA = "0x40C6414", Offset = "0x40C2414", VA = "0x40C6414")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600361E")]
		[Address(RVA = "0x40C68E8", Offset = "0x40C28E8", VA = "0x40C68E8")]
		public ArenaUIBGItem()
		{
		}
	}
}
