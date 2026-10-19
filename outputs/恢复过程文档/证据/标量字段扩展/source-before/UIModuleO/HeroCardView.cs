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
	[Token(Token = "0x2000837")]
	public class HeroCardView : HeroCardViewComponents
	{
		[Token(Token = "0x2000839")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass22_0
		{
			[Token(Token = "0x4003E98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string weeklyCardId;

			[Token(Token = "0x6002E2E")]
			[Address(RVA = "0x40197C0", Offset = "0x40157C0", VA = "0x40197C0")]
			public _003C_003Ec__DisplayClass22_0()
			{
			}

			[Token(Token = "0x6002E2F")]
			[Address(RVA = "0x40197C8", Offset = "0x40157C8", VA = "0x40197C8")]
			internal bool _003CSortNoEquipCards_003Eb__1(UserHeroCardData card)
			{
				return default;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200083B")]
		[CompilerGenerated]
		private struct _003CAwake_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4003E9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003E9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003E9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HeroCardView _003C_003E4__this;

			[Token(Token = "0x4003E9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002E32")]
			[Address(RVA = "0x4019888", Offset = "0x4015888", VA = "0x4019888", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002E33")]
			[Address(RVA = "0x4019D78", Offset = "0x4015D78", VA = "0x4019D78", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200083C")]
		[CompilerGenerated]
		private struct _003CCreateShowCard_003Ed__26 : IAsyncStateMachine
		{
			[Token(Token = "0x4003E9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003E9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003EA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HeroCardView _003C_003E4__this;

			[Token(Token = "0x4003EA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string filterField;

			[Token(Token = "0x4003EA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string filterValue;

			[Token(Token = "0x4003EA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002E34")]
			[Address(RVA = "0x4019D84", Offset = "0x4015D84", VA = "0x4019D84", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002E35")]
			[Address(RVA = "0x401A598", Offset = "0x4016598", VA = "0x401A598", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200083D")]
		[CompilerGenerated]
		private struct _003COnChangeBottomPanel_003Ed__36 : IAsyncStateMachine
		{
			[Token(Token = "0x4003EA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003EA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003EA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HeroCardView _003C_003E4__this;

			[Token(Token = "0x4003EA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public object o;

			[Token(Token = "0x4003EA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UserHeroCardData _003Cdata_003E5__2;

			[Token(Token = "0x4003EA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Image _003C_003E7__wrap2;

			[Token(Token = "0x4003EAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002E36")]
			[Address(RVA = "0x401A5A4", Offset = "0x40165A4", VA = "0x401A5A4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002E37")]
			[Address(RVA = "0x401B6D8", Offset = "0x40176D8", VA = "0x401B6D8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200083E")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__15 : IAsyncStateMachine
		{
			[Token(Token = "0x4003EAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003EAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003EAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HeroCardView _003C_003E4__this;

			[Token(Token = "0x4003EAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x4003EAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002E38")]
			[Address(RVA = "0x401B6E4", Offset = "0x40176E4", VA = "0x401B6E4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002E39")]
			[Address(RVA = "0x401C094", Offset = "0x4018094", VA = "0x401C094", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200083F")]
		[CompilerGenerated]
		private struct _003CSortNoEquipCards_003Ed__22 : IAsyncStateMachine
		{
			[Token(Token = "0x4003EB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003EB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003EB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<UserHeroCardData> noEquipCard;

			[Token(Token = "0x4003EB3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private _003C_003Ec__DisplayClass22_0 _003C_003E8__1;

			[Token(Token = "0x4003EB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002E3A")]
			[Address(RVA = "0x401C0A0", Offset = "0x40180A0", VA = "0x401C0A0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002E3B")]
			[Address(RVA = "0x401C718", Offset = "0x4018718", VA = "0x401C718", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000840")]
		[CompilerGenerated]
		private struct _003CUpdateCardElements_003Ed__17 : IAsyncStateMachine
		{
			[Token(Token = "0x4003EB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003EB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003EB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<UserHeroCardData> dataList;

			[Token(Token = "0x4003EB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HeroCardView _003C_003E4__this;

			[Token(Token = "0x4003EB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<UserHeroCardData> _003CsortDataList_003E5__2;

			[Token(Token = "0x4003EBA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<UserHeroCardData> _003CnoEquipCard_003E5__3;

			[Token(Token = "0x4003EBB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4003EBC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6002E3C")]
			[Address(RVA = "0x401C724", Offset = "0x4018724", VA = "0x401C724", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002E3D")]
			[Address(RVA = "0x401D7E8", Offset = "0x40197E8", VA = "0x401D7E8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000841")]
		[CompilerGenerated]
		private struct _003CUpdateFetterCountUI_003Ed__24 : IAsyncStateMachine
		{
			[Token(Token = "0x4003EBD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003EBE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003EBF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HeroCardView _003C_003E4__this;

			[Token(Token = "0x4003EC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int _003CundeadLevel_003E5__2;

			[Token(Token = "0x4003EC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int _003CterranLevel_003E5__3;

			[Token(Token = "0x4003EC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int _003CmachineLevel_003E5__4;

			[Token(Token = "0x4003EC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int _003CmeleeLevel_003E5__5;

			[Token(Token = "0x4003EC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int _003CremoteLevel_003E5__6;

			[Token(Token = "0x4003EC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Image _003C_003E7__wrap6;

			[Token(Token = "0x4003EC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002E3E")]
			[Address(RVA = "0x401D7F4", Offset = "0x40197F4", VA = "0x401D7F4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002E3F")]
			[Address(RVA = "0x401F2B8", Offset = "0x401B2B8", VA = "0x401F2B8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000842")]
		[CompilerGenerated]
		private struct _003CUpdateFetterDesPage_003Ed__29 : IAsyncStateMachine
		{
			[Token(Token = "0x4003EC7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003EC8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003EC9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HeroCardView _003C_003E4__this;

			[Token(Token = "0x4003ECA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string fetterBuffI2LocKey;

			[Token(Token = "0x4003ECB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string fetterActiveCount;

			[Token(Token = "0x4003ECC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool isFetter;

			[Token(Token = "0x4003ECD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public int fetterValue;

			[Token(Token = "0x4003ECE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public RectTransform buttonRect;

			[Token(Token = "0x4003ECF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string titleDes;

			[Token(Token = "0x4003ED0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4003ED1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6002E40")]
			[Address(RVA = "0x401F2C4", Offset = "0x401B2C4", VA = "0x401F2C4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002E41")]
			[Address(RVA = "0x401FB74", Offset = "0x401BB74", VA = "0x401FB74", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003E84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private List<CardItem> _equipItems;

		[Token(Token = "0x4003E85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private List<CardItem> _bottomItems;

		[Token(Token = "0x4003E86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private GameObject _cardItemPrefab;

		[Token(Token = "0x4003E87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private GameObject _fetterShowCardRes;

		[Token(Token = "0x4003E88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private bool _isCreatingItems;

		[Token(Token = "0x4003E89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x221")]
		private bool _isChangeEquipCardIng;

		[Token(Token = "0x4003E8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
		private int _nowCardDeckIndex;

		[Token(Token = "0x4003E8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private float _introTextOffsetY;

		[Token(Token = "0x4003E8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22C")]
		private Vector2 _introBackSize;

		[Token(Token = "0x4003E8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private List<GameObject> _showFetterCardList;

		[Token(Token = "0x17000532")]
		public bool IsChangeEquipCardIng
		{
			[Token(Token = "0x6002E00")]
			[Address(RVA = "0x4016348", Offset = "0x4012348", VA = "0x4016348")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6002DF6")]
		[Address(RVA = "0x40155DC", Offset = "0x40115DC", VA = "0x40155DC", Slot = "4")]
		[AsyncStateMachine(typeof(_003CAwake_003Ed__10))]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002DF7")]
		[Address(RVA = "0x401566C", Offset = "0x401166C", VA = "0x401566C")]
		private void Update()
		{
		}

		[Token(Token = "0x6002DF8")]
		[Address(RVA = "0x4015830", Offset = "0x4011830", VA = "0x4015830")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6002DF9")]
		[Address(RVA = "0x4015BF8", Offset = "0x4011BF8", VA = "0x4015BF8")]
		private void RegisterEvents()
		{
		}

		[Token(Token = "0x6002DFA")]
		[Address(RVA = "0x4015834", Offset = "0x4011834", VA = "0x4015834")]
		private void UnregisterEvents()
		{
		}

		[Token(Token = "0x6002DFB")]
		[Address(RVA = "0x4015FBC", Offset = "0x4011FBC", VA = "0x4015FBC", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__15))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002DFC")]
		[Address(RVA = "0x4016064", Offset = "0x4012064", VA = "0x4016064", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002DFD")]
		[Address(RVA = "0x401608C", Offset = "0x401208C", VA = "0x401608C")]
		[AsyncStateMachine(typeof(_003CUpdateCardElements_003Ed__17))]
		public UniTask UpdateCardElements(List<UserHeroCardData> dataList)
		{
			return default;
		}

		[Token(Token = "0x6002DFE")]
		[Address(RVA = "0x4016134", Offset = "0x4012134", VA = "0x4016134")]
		public void RefreshAllCardsUI()
		{
		}

		[Token(Token = "0x6002DFF")]
		[Address(RVA = "0x4016080", Offset = "0x4012080", VA = "0x4016080")]
		public void ClearCardItems()
		{
		}

		[Token(Token = "0x6002E01")]
		[Address(RVA = "0x4016350", Offset = "0x4012350", VA = "0x4016350")]
		[AsyncStateMachine(typeof(_003CSortNoEquipCards_003Ed__22))]
		private UniTask SortNoEquipCards(List<UserHeroCardData> noEquipCard)
		{
			return default;
		}

		[Token(Token = "0x6002E02")]
		[Address(RVA = "0x40163E8", Offset = "0x40123E8", VA = "0x40163E8")]
		private List<UserHeroCardData> SortByPartialOrder(List<UserHeroCardData> dataList, List<int> orderedIds)
		{
			return null;
		}

		[Token(Token = "0x6002E03")]
		[Address(RVA = "0x4016880", Offset = "0x4012880", VA = "0x4016880")]
		[AsyncStateMachine(typeof(_003CUpdateFetterCountUI_003Ed__24))]
		private void UpdateFetterCountUI(object o)
		{
		}

		[Token(Token = "0x6002E04")]
		[Address(RVA = "0x4016914", Offset = "0x4012914", VA = "0x4016914")]
		private void UpdateBubbleUI(int num, string[] str, bool isNormal)
		{
		}

		[Token(Token = "0x6002E05")]
		[Address(RVA = "0x4016DB0", Offset = "0x4012DB0", VA = "0x4016DB0")]
		[AsyncStateMachine(typeof(_003CCreateShowCard_003Ed__26))]
		private UniTask CreateShowCard(string filterField, string filterValue)
		{
			return default;
		}

		[Token(Token = "0x6002E06")]
		[Address(RVA = "0x4016E5C", Offset = "0x4012E5C", VA = "0x4016E5C")]
		private void CalculateBubblePositionAndPivot(RectTransform buttonRect, out Vector2 pivot, out Vector3 position)
		{
		}

		[Token(Token = "0x6002E07")]
		[Address(RVA = "0x40156C0", Offset = "0x40116C0", VA = "0x40156C0")]
		private void HideFetterIntro()
		{
		}

		[Token(Token = "0x6002E08")]
		[Address(RVA = "0x401714C", Offset = "0x401314C", VA = "0x401714C")]
		[AsyncStateMachine(typeof(_003CUpdateFetterDesPage_003Ed__29))]
		private void UpdateFetterDesPage(string fetterBuffI2LocKey, string fetterActiveCount, bool isFetter, RectTransform buttonRect, int fetterValue, string titleDes)
		{
		}

		[Token(Token = "0x6002E09")]
		[Address(RVA = "0x4017224", Offset = "0x4013224", VA = "0x4017224")]
		private void UpdateCardDeckBtnUI()
		{
		}

		[Token(Token = "0x6002E0A")]
		[Address(RVA = "0x4017368", Offset = "0x4013368", VA = "0x4017368")]
		private void RefreshEquipCard(int nowCardDeckIndex)
		{
		}

		[Token(Token = "0x6002E0B")]
		[Address(RVA = "0x4017434", Offset = "0x4013434", VA = "0x4017434")]
		private void UpdateAllBattleNum(object o)
		{
		}

		[Token(Token = "0x6002E0C")]
		[Address(RVA = "0x40174D0", Offset = "0x40134D0", VA = "0x40174D0")]
		private void OnCardUpgrade(object o)
		{
		}

		[Token(Token = "0x6002E0D")]
		[Address(RVA = "0x40174D4", Offset = "0x40134D4", VA = "0x40174D4")]
		private void OnCardEquip(object o)
		{
		}

		[Token(Token = "0x6002E0E")]
		[Address(RVA = "0x4017594", Offset = "0x4013594", VA = "0x4017594")]
		private void OnTopAllCardShow(object o)
		{
		}

		[Token(Token = "0x6002E0F")]
		[Address(RVA = "0x4017598", Offset = "0x4013598", VA = "0x4017598")]
		[AsyncStateMachine(typeof(_003COnChangeBottomPanel_003Ed__36))]
		private void OnChangeBottomPanel(object o)
		{
		}

		[Token(Token = "0x6002E10")]
		[Address(RVA = "0x4017634", Offset = "0x4013634", VA = "0x4017634")]
		private void OnBeginChangeEquipCard(object o)
		{
		}

		[Token(Token = "0x6002E11")]
		[Address(RVA = "0x4016084", Offset = "0x4012084", VA = "0x4016084")]
		private void OnChangeEquipCardEnd(object o)
		{
		}

		[Token(Token = "0x6002E12")]
		[Address(RVA = "0x4017640", Offset = "0x4013640", VA = "0x4017640")]
		private void OnOpenTheUniversalCard(object o)
		{
		}

		[Token(Token = "0x6002E13")]
		[Address(RVA = "0x4017BB0", Offset = "0x4013BB0", VA = "0x4017BB0", Slot = "13")]
		protected override void OnButtonExtendBtnCardDeck1Clicked()
		{
		}

		[Token(Token = "0x6002E14")]
		[Address(RVA = "0x4017BE0", Offset = "0x4013BE0", VA = "0x4017BE0", Slot = "14")]
		protected override void OnButtonExtendBtnCardDeck2Clicked()
		{
		}

		[Token(Token = "0x6002E15")]
		[Address(RVA = "0x4017C10", Offset = "0x4013C10", VA = "0x4017C10", Slot = "15")]
		protected override void OnButtonExtendBtnCardDeck3Clicked()
		{
		}

		[Token(Token = "0x6002E16")]
		[Address(RVA = "0x4017C40", Offset = "0x4013C40", VA = "0x4017C40", Slot = "16")]
		protected override void OnButtonExtendBtnCardDeck4Clicked()
		{
		}

		[Token(Token = "0x6002E17")]
		[Address(RVA = "0x4017C70", Offset = "0x4013C70", VA = "0x4017C70", Slot = "17")]
		protected override void OnButtonExtendBtnCardDeck5Clicked()
		{
		}

		[Token(Token = "0x6002E18")]
		[Address(RVA = "0x4017CA0", Offset = "0x4013CA0", VA = "0x4017CA0", Slot = "20")]
		protected override void OnButtonExtendBtnOrcsClicked()
		{
		}

		[Token(Token = "0x6002E19")]
		[Address(RVA = "0x4017EA0", Offset = "0x4013EA0", VA = "0x4017EA0", Slot = "21")]
		protected override void OnButtonExtendBtnUndeadClicked()
		{
		}

		[Token(Token = "0x6002E1A")]
		[Address(RVA = "0x4017FF0", Offset = "0x4013FF0", VA = "0x4017FF0", Slot = "19")]
		protected override void OnButtonExtendBtnTerranClicked()
		{
		}

		[Token(Token = "0x6002E1B")]
		[Address(RVA = "0x4018140", Offset = "0x4014140", VA = "0x4018140", Slot = "22")]
		protected override void OnButtonExtendBtnMachineClicked()
		{
		}

		[Token(Token = "0x6002E1C")]
		[Address(RVA = "0x4018290", Offset = "0x4014290", VA = "0x4018290", Slot = "23")]
		protected override void OnButtonExtendBtnMeleeClicked()
		{
		}

		[Token(Token = "0x6002E1D")]
		[Address(RVA = "0x40183D4", Offset = "0x40143D4", VA = "0x40183D4", Slot = "24")]
		protected override void OnButtonExtendBtnRemoteClicked()
		{
		}

		[Token(Token = "0x6002E1E")]
		[Address(RVA = "0x4017DF0", Offset = "0x4013DF0", VA = "0x4017DF0")]
		private string GetBuffDesStrKey(string I2LocKey)
		{
			return null;
		}

		[Token(Token = "0x6002E1F")]
		[Address(RVA = "0x4018518", Offset = "0x4014518", VA = "0x4018518", Slot = "25")]
		protected override void OnButtonExtendBtnCancelClicked()
		{
		}

		[Token(Token = "0x6002E20")]
		[Address(RVA = "0x40185E4", Offset = "0x40145E4", VA = "0x40185E4")]
		public HeroCardView()
		{
		}
	}
}
