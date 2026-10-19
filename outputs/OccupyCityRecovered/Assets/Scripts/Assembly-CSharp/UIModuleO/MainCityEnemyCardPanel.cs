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
	[Token(Token = "0x200092D")]
	public class MainCityEnemyCardPanel : MainCityEnemyCardPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200092E")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__0 : IAsyncStateMachine
		{
			[Token(Token = "0x40044B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40044B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40044B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MainCityEnemyCardPanel _003C_003E4__this;

			[Token(Token = "0x40044B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003506")]
			[Address(RVA = "0x40B0408", Offset = "0x40AC408", VA = "0x40B0408", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003507")]
			[Address(RVA = "0x40B06C8", Offset = "0x40AC6C8", VA = "0x40B06C8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200092F")]
		[CompilerGenerated]
		private struct _003CUpdateCardBG_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x40044BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40044BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x40044BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RareLevel rare;

			[Token(Token = "0x40044BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003508")]
			[Address(RVA = "0x40B06D4", Offset = "0x40AC6D4", VA = "0x40B06D4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003509")]
			[Address(RVA = "0x40B1074", Offset = "0x40AD074", VA = "0x40B1074", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000930")]
		[CompilerGenerated]
		private struct _003CUpdateCardItem_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x40044BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40044BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40044C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string id;

			[Token(Token = "0x40044C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GameObject cardItem;

			[Token(Token = "0x40044C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public MainCityEnemyCardPanel _003C_003E4__this;

			[Token(Token = "0x40044C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private GlobalHeroCardInfo _003Cconfig_003E5__2;

			[Token(Token = "0x40044C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Image _003C_003E7__wrap2;

			[Token(Token = "0x40044C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600350A")]
			[Address(RVA = "0x40B10CC", Offset = "0x40AD0CC", VA = "0x40B10CC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600350B")]
			[Address(RVA = "0x40B1FB8", Offset = "0x40ADFB8", VA = "0x40B1FB8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x60034FF")]
		[Address(RVA = "0x40AFD90", Offset = "0x40ABD90", VA = "0x40AFD90", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__0))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003500")]
		[Address(RVA = "0x40AFE24", Offset = "0x40ABE24", VA = "0x40AFE24")]
		private void UpdateCardsUI(List<string> cards)
		{
		}

		[Token(Token = "0x6003501")]
		[Address(RVA = "0x40AFFB8", Offset = "0x40ABFB8", VA = "0x40AFFB8")]
		[AsyncStateMachine(typeof(_003CUpdateCardItem_003Ed__2))]
		private void UpdateCardItem(GameObject cardItem, string id)
		{
		}

		[Token(Token = "0x6003502")]
		[Address(RVA = "0x40B0060", Offset = "0x40AC060", VA = "0x40B0060")]
		[AsyncStateMachine(typeof(_003CUpdateCardBG_003Ed__3))]
		private UniTask<Sprite> UpdateCardBG(RareLevel rare)
		{
			return default;
		}

		[Token(Token = "0x6003503")]
		[Address(RVA = "0x40B0134", Offset = "0x40AC134", VA = "0x40B0134", Slot = "21")]
		protected override void OnButtonBtnCancelClicked()
		{
		}

		[Token(Token = "0x6003504")]
		[Address(RVA = "0x40B0360", Offset = "0x40AC360", VA = "0x40B0360")]
		public MainCityEnemyCardPanel()
		{
		}
	}
}
