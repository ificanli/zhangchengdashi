using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x200078E")]
	public class CardDeckChangePanel : CardDeckChangePanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000791")]
		[CompilerGenerated]
		private struct _003CAwake_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x4003AB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003AB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003AB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CardDeckChangePanel _003C_003E4__this;

			[Token(Token = "0x4003AB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60029AD")]
			[Address(RVA = "0x3FC8AFC", Offset = "0x3FC4AFC", VA = "0x3FC8AFC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60029AE")]
			[Address(RVA = "0x3FC8FD4", Offset = "0x3FC4FD4", VA = "0x3FC8FD4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000792")]
		[CompilerGenerated]
		private struct _003CCreateShowCard_003Ed__37 : IAsyncStateMachine
		{
			[Token(Token = "0x4003AB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003AB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003ABA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CardDeckChangePanel _003C_003E4__this;

			[Token(Token = "0x4003ABB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string filterField;

			[Token(Token = "0x4003ABC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string filterValue;

			[Token(Token = "0x4003ABD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60029AF")]
			[Address(RVA = "0x3FC8FE0", Offset = "0x3FC4FE0", VA = "0x3FC8FE0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60029B0")]
			[Address(RVA = "0x3FC9628", Offset = "0x3FC5628", VA = "0x3FC9628", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000793")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__9 : IAsyncStateMachine
		{
			[Token(Token = "0x4003ABE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003ABF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003AC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CardDeckChangePanel _003C_003E4__this;

			[Token(Token = "0x4003AC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60029B1")]
			[Address(RVA = "0x3FC9634", Offset = "0x3FC5634", VA = "0x3FC9634", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60029B2")]
			[Address(RVA = "0x3FC9C48", Offset = "0x3FC5C48", VA = "0x3FC9C48", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000794")]
		[CompilerGenerated]
		private struct _003CUpdateBubbleUI_003Ed__36 : IAsyncStateMachine
		{
			[Token(Token = "0x4003AC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003AC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003AC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CardDeckChangePanel _003C_003E4__this;

			[Token(Token = "0x4003AC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int num;

			[Token(Token = "0x4003AC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public bool isNormal;

			[Token(Token = "0x4003AC7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string[] str;

			[Token(Token = "0x60029B3")]
			[Address(RVA = "0x3FC9C54", Offset = "0x3FC5C54", VA = "0x3FC9C54", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60029B4")]
			[Address(RVA = "0x3FCA5BC", Offset = "0x3FC65BC", VA = "0x3FCA5BC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000795")]
		[CompilerGenerated]
		private struct _003CUpdateCardDeck_003Ed__24 : IAsyncStateMachine
		{
			[Token(Token = "0x4003AC8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003AC9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003ACA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<UserHeroCardData> cardDatas;

			[Token(Token = "0x4003ACB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public CardDeckChangePanel _003C_003E4__this;

			[Token(Token = "0x4003ACC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isEnemy;

			[Token(Token = "0x4003ACD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60029B5")]
			[Address(RVA = "0x3FCA5C8", Offset = "0x3FC65C8", VA = "0x3FCA5C8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60029B6")]
			[Address(RVA = "0x3FCAE8C", Offset = "0x3FC6E8C", VA = "0x3FCAE8C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000796")]
		[CompilerGenerated]
		private struct _003CUpdateShowCardTypeCountUI_003Ed__28 : IAsyncStateMachine
		{
			[Token(Token = "0x4003ACE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003ACF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003AD0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<UserHeroCardData> cardDatas;

			[Token(Token = "0x4003AD1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public CardDeckChangePanel _003C_003E4__this;

			[Token(Token = "0x4003AD2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Dictionary<int, int> _003CcardAllFetter_003E5__2;

			[Token(Token = "0x4003AD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Image _003C_003E7__wrap2;

			[Token(Token = "0x4003AD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60029B7")]
			[Address(RVA = "0x3FCAE98", Offset = "0x3FC6E98", VA = "0x3FCAE98", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60029B8")]
			[Address(RVA = "0x3FCC674", Offset = "0x3FC8674", VA = "0x3FCC674", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003AA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private int nowCardDeckIndex;

		[Token(Token = "0x4003AA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private List<GameObject> equipItem;

		[Token(Token = "0x4003AA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private Vector2 size;

		[Token(Token = "0x4003AAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private GameObject res;

		[Token(Token = "0x4003AAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private List<GameObject> showFetterCardList;

		[Token(Token = "0x4003AAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private float num;

		[Token(Token = "0x4003AAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private Dictionary<string, List<int>> cardTalentUnlockDic;

		[Token(Token = "0x6002982")]
		[Address(RVA = "0x3FC48A8", Offset = "0x3FC08A8", VA = "0x3FC48A8", Slot = "4")]
		[AsyncStateMachine(typeof(_003CAwake_003Ed__7))]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002983")]
		[Address(RVA = "0x3FC4938", Offset = "0x3FC0938", VA = "0x3FC4938")]
		private void Update()
		{
		}

		[Token(Token = "0x6002984")]
		[Address(RVA = "0x3FC4BB4", Offset = "0x3FC0BB4", VA = "0x3FC4BB4", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__9))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002985")]
		[Address(RVA = "0x3FC4C48", Offset = "0x3FC0C48", VA = "0x3FC4C48", Slot = "12")]
		protected override void OnButtonBgClicked()
		{
		}

		[Token(Token = "0x6002986")]
		[Address(RVA = "0x3FC4CD4", Offset = "0x3FC0CD4", VA = "0x3FC4CD4", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002987")]
		[Address(RVA = "0x3FC4D98", Offset = "0x3FC0D98", VA = "0x3FC4D98", Slot = "7")]
		protected override void OnHideAnimationComplete()
		{
		}

		[Token(Token = "0x6002988")]
		[Address(RVA = "0x3FC4FBC", Offset = "0x3FC0FBC", VA = "0x3FC4FBC")]
		private void UpdateCardDeckBtnUI(int cardDeckIndex)
		{
		}

		[Token(Token = "0x6002989")]
		[Address(RVA = "0x3FC590C", Offset = "0x3FC190C", VA = "0x3FC590C")]
		private void CardUpgrade(object o)
		{
		}

		[Token(Token = "0x600298A")]
		[Address(RVA = "0x3FC59C0", Offset = "0x3FC19C0", VA = "0x3FC59C0", Slot = "14")]
		protected override void OnButtonExtendBtnCardDeck1Clicked()
		{
		}

		[Token(Token = "0x600298B")]
		[Address(RVA = "0x3FC5D3C", Offset = "0x3FC1D3C", VA = "0x3FC5D3C", Slot = "15")]
		protected override void OnButtonExtendBtnCardDeck2Clicked()
		{
		}

		[Token(Token = "0x600298C")]
		[Address(RVA = "0x3FC5DC4", Offset = "0x3FC1DC4", VA = "0x3FC5DC4", Slot = "16")]
		protected override void OnButtonExtendBtnCardDeck3Clicked()
		{
		}

		[Token(Token = "0x600298D")]
		[Address(RVA = "0x3FC5E4C", Offset = "0x3FC1E4C", VA = "0x3FC5E4C", Slot = "17")]
		protected override void OnButtonExtendBtnCardDeck4Clicked()
		{
		}

		[Token(Token = "0x600298E")]
		[Address(RVA = "0x3FC5ED4", Offset = "0x3FC1ED4", VA = "0x3FC5ED4", Slot = "18")]
		protected override void OnButtonExtendBtnCardDeck5Clicked()
		{
		}

		[Token(Token = "0x600298F")]
		[Address(RVA = "0x3FC5A48", Offset = "0x3FC1A48", VA = "0x3FC5A48")]
		private void ChangeEquipCard(int nowCardDeckIndex)
		{
		}

		[Token(Token = "0x6002990")]
		[Address(RVA = "0x3FC5F5C", Offset = "0x3FC1F5C", VA = "0x3FC5F5C")]
		private void ShowCardDeck(List<UserHeroCardData> cardList, Dictionary<string, List<int>> allCardUnLockTalent, bool isEnemy)
		{
		}

		[Token(Token = "0x6002991")]
		[Address(RVA = "0x3FC4F08", Offset = "0x3FC0F08", VA = "0x3FC4F08")]
		public void ChangeFetterButtonInteractable(bool interactable)
		{
		}

		[Token(Token = "0x6002992")]
		[Address(RVA = "0x3FC4ED8", Offset = "0x3FC0ED8", VA = "0x3FC4ED8")]
		public void ButtonCardDeckSetActive(bool active)
		{
		}

		[Token(Token = "0x6002993")]
		[Address(RVA = "0x3FC6100", Offset = "0x3FC2100", VA = "0x3FC6100")]
		[AsyncStateMachine(typeof(_003CUpdateCardDeck_003Ed__24))]
		private void UpdateCardDeck(List<UserHeroCardData> cardDatas, bool isEnemy)
		{
		}

		[Token(Token = "0x6002994")]
		[Address(RVA = "0x3FC4DD0", Offset = "0x3FC0DD0", VA = "0x3FC4DD0")]
		private void Clear()
		{
		}

		[Token(Token = "0x6002995")]
		[Address(RVA = "0x3FC6724", Offset = "0x3FC2724", VA = "0x3FC6724")]
		private List<UserHeroCardData> SortByPartialOrder(List<UserHeroCardData> dataList, List<int> orderedIds)
		{
			return null;
		}

		[Token(Token = "0x6002996")]
		[Address(RVA = "0x3FC604C", Offset = "0x3FC204C", VA = "0x3FC604C")]
		private void UpdateAllBattleNum(List<UserHeroCardData> cardDatas, Dictionary<string, List<int>> allCardUnLockTalent)
		{
		}

		[Token(Token = "0x6002997")]
		[Address(RVA = "0x3FC5FB0", Offset = "0x3FC1FB0", VA = "0x3FC5FB0")]
		[AsyncStateMachine(typeof(_003CUpdateShowCardTypeCountUI_003Ed__28))]
		private void UpdateShowCardTypeCountUI(List<UserHeroCardData> cardDatas)
		{
		}

		[Token(Token = "0x6002998")]
		[Address(RVA = "0x3FC6C8C", Offset = "0x3FC2C8C", VA = "0x3FC6C8C", Slot = "20")]
		protected override void OnButtonExtendBtnOrcsClicked()
		{
		}

		[Token(Token = "0x6002999")]
		[Address(RVA = "0x3FC727C", Offset = "0x3FC327C", VA = "0x3FC727C", Slot = "21")]
		protected override void OnButtonExtendBtnUndeadClicked()
		{
		}

		[Token(Token = "0x600299A")]
		[Address(RVA = "0x3FC7610", Offset = "0x3FC3610", VA = "0x3FC7610", Slot = "19")]
		protected override void OnButtonExtendBtnTerranClicked()
		{
		}

		[Token(Token = "0x600299B")]
		[Address(RVA = "0x3FC7968", Offset = "0x3FC3968", VA = "0x3FC7968", Slot = "22")]
		protected override void OnButtonExtendBtnMachineClicked()
		{
		}

		[Token(Token = "0x600299C")]
		[Address(RVA = "0x3FC7CFC", Offset = "0x3FC3CFC", VA = "0x3FC7CFC", Slot = "23")]
		protected override void OnButtonExtendBtnMeleeClicked()
		{
		}

		[Token(Token = "0x600299D")]
		[Address(RVA = "0x3FC8054", Offset = "0x3FC4054", VA = "0x3FC8054", Slot = "24")]
		protected override void OnButtonExtendBtnRemoteClicked()
		{
		}

		[Token(Token = "0x600299E")]
		[Address(RVA = "0x3FC6FE4", Offset = "0x3FC2FE4", VA = "0x3FC6FE4")]
		private void UpdateFetterDesPage(string fetterBuffI2LocKey, string fetterActiveCount, bool isFetter, Vector2 introBackPivot, Vector3 followPos, int fetterValue, string titleDes)
		{
		}

		[Token(Token = "0x600299F")]
		[Address(RVA = "0x3FC83AC", Offset = "0x3FC43AC", VA = "0x3FC83AC")]
		[AsyncStateMachine(typeof(_003CUpdateBubbleUI_003Ed__36))]
		private void UpdateBubbleUI(int num, string[] str, bool isNormal)
		{
		}

		[Token(Token = "0x60029A0")]
		[Address(RVA = "0x3FC8464", Offset = "0x3FC4464", VA = "0x3FC8464")]
		[AsyncStateMachine(typeof(_003CCreateShowCard_003Ed__37))]
		private void CreateShowCard(Vector2 pos, string filterField, string filterValue)
		{
		}

		[Token(Token = "0x60029A1")]
		[Address(RVA = "0x3FC4A50", Offset = "0x3FC0A50", VA = "0x3FC4A50")]
		private void IntroBackHide()
		{
		}

		[Token(Token = "0x60029A2")]
		[Address(RVA = "0x3FC8760", Offset = "0x3FC4760", VA = "0x3FC8760")]
		public CardDeckChangePanel()
		{
		}
	}
}
