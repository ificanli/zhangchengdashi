using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using GameModule;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x200086D")]
	public class EnemyCardEditorPanel : EnemyCardEditorPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000872")]
		[CompilerGenerated]
		private struct _003CAwake_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4003FCF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003FD0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003FD1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public EnemyCardEditorPanel _003C_003E4__this;

			[Token(Token = "0x4003FD2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002F75")]
			[Address(RVA = "0x402FB40", Offset = "0x402BB40", VA = "0x402FB40", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002F76")]
			[Address(RVA = "0x402FEE8", Offset = "0x402BEE8", VA = "0x402FEE8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000873")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__11 : IAsyncStateMachine
		{
			[Token(Token = "0x4003FD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003FD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003FD5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public EnemyCardEditorPanel _003C_003E4__this;

			[Token(Token = "0x4003FD6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002F77")]
			[Address(RVA = "0x402FEF4", Offset = "0x402BEF4", VA = "0x402FEF4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002F78")]
			[Address(RVA = "0x40304C4", Offset = "0x402C4C4", VA = "0x40304C4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000874")]
		[CompilerGenerated]
		private struct _003CUpdateCardBG_003Ed__20 : IAsyncStateMachine
		{
			[Token(Token = "0x4003FD7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003FD8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x4003FD9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RareLevel rare;

			[Token(Token = "0x4003FDA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002F79")]
			[Address(RVA = "0x40304D0", Offset = "0x402C4D0", VA = "0x40304D0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002F7A")]
			[Address(RVA = "0x4030E70", Offset = "0x402CE70", VA = "0x4030E70", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000875")]
		[CompilerGenerated]
		private struct _003CUpdateCardElements_003Ed__13 : IAsyncStateMachine
		{
			[Token(Token = "0x4003FDB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003FDC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003FDD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public EnemyCardEditorPanel _003C_003E4__this;

			[Token(Token = "0x4003FDE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public List<UserHeroCardData> dataList;

			[Token(Token = "0x6002F7B")]
			[Address(RVA = "0x4030EC8", Offset = "0x402CEC8", VA = "0x4030EC8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002F7C")]
			[Address(RVA = "0x4031870", Offset = "0x402D870", VA = "0x4031870", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000876")]
		[CompilerGenerated]
		private struct _003CUpdateCardItem_003Ed__12 : IAsyncStateMachine
		{
			[Token(Token = "0x4003FDF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003FE0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003FE1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string id;

			[Token(Token = "0x4003FE2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GameObject cardItem;

			[Token(Token = "0x4003FE3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public EnemyCardEditorPanel _003C_003E4__this;

			[Token(Token = "0x4003FE4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private GlobalHeroCardInfo _003Cconfig_003E5__2;

			[Token(Token = "0x4003FE5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Image _003C_003E7__wrap2;

			[Token(Token = "0x4003FE6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002F7D")]
			[Address(RVA = "0x403187C", Offset = "0x402D87C", VA = "0x403187C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002F7E")]
			[Address(RVA = "0x4032768", Offset = "0x402E768", VA = "0x4032768", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003FBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Dictionary<GameObject, string> _equipItem;

		[Token(Token = "0x4003FBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Dictionary<GameObject, string> _bottomItem;

		[Token(Token = "0x4003FC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public GameObject cardItemPrefab;

		[Token(Token = "0x4003FC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool _creatItemIng;

		[Token(Token = "0x4003FC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector2 size;

		[Token(Token = "0x4003FC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private GameObject res;

		[Token(Token = "0x4003FC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float num;

		[Token(Token = "0x4003FC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public List<string> equipCards;

		[Token(Token = "0x4003FC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private GameObject selectTopItem;

		[Token(Token = "0x4003FC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private GameObject selectButtonItem;

		[Token(Token = "0x4003FC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private List<GameObject> showFetterCardList;

		[Token(Token = "0x6002F5E")]
		[Address(RVA = "0x402E834", Offset = "0x402A834", VA = "0x402E834", Slot = "4")]
		[AsyncStateMachine(typeof(_003CAwake_003Ed__10))]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002F5F")]
		[Address(RVA = "0x402E8C4", Offset = "0x402A8C4", VA = "0x402E8C4", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__11))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002F60")]
		[Address(RVA = "0x402E958", Offset = "0x402A958", VA = "0x402E958")]
		[AsyncStateMachine(typeof(_003CUpdateCardItem_003Ed__12))]
		public void UpdateCardItem(GameObject cardItem, string id)
		{
		}

		[Token(Token = "0x6002F61")]
		[Address(RVA = "0x402EA00", Offset = "0x402AA00", VA = "0x402EA00")]
		[AsyncStateMachine(typeof(_003CUpdateCardElements_003Ed__13))]
		private void UpdateCardElements(List<UserHeroCardData> dataList)
		{
		}

		[Token(Token = "0x6002F62")]
		[Address(RVA = "0x402EA9C", Offset = "0x402AA9C", VA = "0x402EA9C")]
		public GlobalHeroCardInfo GetInfo(string id)
		{
			return null;
		}

		[Token(Token = "0x6002F63")]
		[Address(RVA = "0x402EB98", Offset = "0x402AB98", VA = "0x402EB98", Slot = "17")]
		public virtual RareLevel GetRareLevel(string id)
		{
			return default;
		}

		[Token(Token = "0x6002F64")]
		[Address(RVA = "0x402ECE4", Offset = "0x402ACE4", VA = "0x402ECE4", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002F65")]
		[Address(RVA = "0x402ED00", Offset = "0x402AD00", VA = "0x402ED00")]
		public void Clear()
		{
		}

		[Token(Token = "0x6002F66")]
		[Address(RVA = "0x402EFC4", Offset = "0x402AFC4", VA = "0x402EFC4")]
		private void UpdateAllBattleNum(object o)
		{
		}

		[Token(Token = "0x6002F67")]
		[Address(RVA = "0x402F2D4", Offset = "0x402B2D4", VA = "0x402F2D4")]
		[AsyncStateMachine(typeof(_003CUpdateCardBG_003Ed__20))]
		public UniTask<Sprite> UpdateCardBG(RareLevel rare)
		{
			return default;
		}

		[Token(Token = "0x6002F68")]
		[Address(RVA = "0x402F3A8", Offset = "0x402B3A8", VA = "0x402F3A8", Slot = "15")]
		protected override void OnButtonBtnUnitClicked()
		{
		}

		[Token(Token = "0x6002F69")]
		[Address(RVA = "0x402F664", Offset = "0x402B664", VA = "0x402F664")]
		public EnemyCardEditorPanel()
		{
		}
	}
}
