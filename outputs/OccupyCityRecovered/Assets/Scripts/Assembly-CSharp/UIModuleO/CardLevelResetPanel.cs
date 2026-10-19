using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using GameModule;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20007A0")]
	public class CardLevelResetPanel : UIPanel
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007A1")]
		[CompilerGenerated]
		private struct _003COnResetClicked_003Ed__18 : IAsyncStateMachine
		{
			[Token(Token = "0x4003B3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003B40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003B41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CardLevelResetPanel _003C_003E4__this;

			[Token(Token = "0x4003B42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002A37")]
			[Address(RVA = "0x3FD152C", Offset = "0x3FCD52C", VA = "0x3FD152C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002A38")]
			[Address(RVA = "0x3FD19DC", Offset = "0x3FCD9DC", VA = "0x3FD19DC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007A2")]
		[CompilerGenerated]
		private struct _003CRefresh_003Ed__15 : IAsyncStateMachine
		{
			[Token(Token = "0x4003B43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003B44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003B45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CardLevelResetPanel _003C_003E4__this;

			[Token(Token = "0x4003B46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4003B47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002A39")]
			[Address(RVA = "0x3FD19E8", Offset = "0x3FCD9E8", VA = "0x3FD19E8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002A3A")]
			[Address(RVA = "0x3FD2158", Offset = "0x3FCE158", VA = "0x3FD2158", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007A3")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__14 : IAsyncStateMachine
		{
			[Token(Token = "0x4003B48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003B49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003B4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CardLevelResetPanel _003C_003E4__this;

			[Token(Token = "0x4003B4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x4003B4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002A3B")]
			[Address(RVA = "0x3FD2164", Offset = "0x3FCE164", VA = "0x3FD2164", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002A3C")]
			[Address(RVA = "0x3FD27B4", Offset = "0x3FCE7B4", VA = "0x3FD27B4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003B33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button ButtonClose;

		[Token(Token = "0x4003B34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button ButtonReset;

		[Token(Token = "0x4003B35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TextMeshProUGUI TextCurrentLevel;

		[Token(Token = "0x4003B36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TextMeshProUGUI TextResetLevel;

		[Token(Token = "0x4003B37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TextMeshProUGUI TextCostCount;

		[Token(Token = "0x4003B38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image ImageCostIcon;

		[Token(Token = "0x4003B39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CardItem CardItemPreview;

		[Token(Token = "0x4003B3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private List<RewardItemUI> RefundItems;

		[Token(Token = "0x4003B3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform RectTransformTweenRoot;

		[Token(Token = "0x4003B3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _layoutGroup;

		[Token(Token = "0x4003B3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private UserHeroCardData _data;

		[Token(Token = "0x4003B3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private CardLevelResetService.Preview _preview;

		[Token(Token = "0x6002A2D")]
		[Address(RVA = "0x3FD0DD4", Offset = "0x3FCCDD4", VA = "0x3FD0DD4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002A2E")]
		[Address(RVA = "0x3FD0F14", Offset = "0x3FCCF14", VA = "0x3FD0F14")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6002A2F")]
		[Address(RVA = "0x3FD0FFC", Offset = "0x3FCCFFC", VA = "0x3FD0FFC", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__14))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002A30")]
		[Address(RVA = "0x3FD1098", Offset = "0x3FCD098", VA = "0x3FD1098")]
		[AsyncStateMachine(typeof(_003CRefresh_003Ed__15))]
		private UniTask Refresh()
		{
			return default;
		}

		[Token(Token = "0x6002A31")]
		[Address(RVA = "0x3FD1124", Offset = "0x3FCD124", VA = "0x3FD1124")]
		private void RefreshRefundItems(CardLevelResetService.Preview preview)
		{
		}

		[Token(Token = "0x6002A32")]
		[Address(RVA = "0x3FD1320", Offset = "0x3FCD320", VA = "0x3FD1320")]
		private void SetAllRefundItemsActive(bool active)
		{
		}

		[Token(Token = "0x6002A33")]
		[Address(RVA = "0x3FD1428", Offset = "0x3FCD428", VA = "0x3FD1428")]
		[AsyncStateMachine(typeof(_003COnResetClicked_003Ed__18))]
		private void OnResetClicked()
		{
		}

		[Token(Token = "0x6002A34")]
		[Address(RVA = "0x3FD14B4", Offset = "0x3FCD4B4", VA = "0x3FD14B4")]
		private void OnCloseClicked()
		{
		}

		[Token(Token = "0x6002A35")]
		[Address(RVA = "0x3FD151C", Offset = "0x3FCD51C", VA = "0x3FD151C")]
		public CardLevelResetPanel()
		{
		}
	}
}
