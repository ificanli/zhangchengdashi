using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000B2F")]
	public class BuyArtifactGiftTwoSurePanel : BuyArtifactGiftTwoSurePanelComponents
	{
		[Token(Token = "0x2000B30")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass10_0
		{
			[Token(Token = "0x4005194")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public BuyArtifactGiftTwoSurePanel _003C_003E4__this;

			[Token(Token = "0x4005195")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GlobalPropInfo configInfo;

			[Token(Token = "0x600440F")]
			[Address(RVA = "0x41E5FA8", Offset = "0x41E1FA8", VA = "0x41E5FA8")]
			public _003C_003Ec__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6004410")]
			[Address(RVA = "0x41E5FB0", Offset = "0x41E1FB0", VA = "0x41E5FB0")]
			internal bool _003CShow_003Eb__0(GlobalIAPInfo x)
			{
				return default;
			}

			[Token(Token = "0x6004411")]
			[Address(RVA = "0x41E5FE0", Offset = "0x41E1FE0", VA = "0x41E5FE0")]
			internal bool _003CShow_003Eb__1(UserPropData x)
			{
				return default;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B31")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4005196")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005197")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005198")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BuyArtifactGiftTwoSurePanel _003C_003E4__this;

			[Token(Token = "0x4005199")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x400519A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private _003C_003Ec__DisplayClass10_0 _003C_003E8__1;

			[Token(Token = "0x400519B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string _003CpropId_003E5__2;

			[Token(Token = "0x400519C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int _003CpropCount_003E5__3;

			[Token(Token = "0x400519D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x400519E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Image _003C_003E7__wrap3;

			[Token(Token = "0x400519F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6004412")]
			[Address(RVA = "0x41E6008", Offset = "0x41E2008", VA = "0x41E6008", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004413")]
			[Address(RVA = "0x41E7974", Offset = "0x41E3974", VA = "0x41E7974", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400518D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private GlobalShopInfo _info;

		[Token(Token = "0x400518E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private string _placement;

		[Token(Token = "0x400518F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private string productID;

		[Token(Token = "0x4005190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float lastTriggerPurchaseProductTime;

		[Token(Token = "0x4005191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Sequence floatSequence;

		[Token(Token = "0x4005192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 originalPos;

		[Token(Token = "0x4005193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private readonly List<GameObject> spawnedArtifactResourceRewardUis;

		[Token(Token = "0x6004403")]
		[Address(RVA = "0x41E537C", Offset = "0x41E137C", VA = "0x41E537C")]
		private void ClearSpawnedArtifactResourceRewardUis()
		{
		}

		[Token(Token = "0x6004404")]
		[Address(RVA = "0x41E54B8", Offset = "0x41E14B8", VA = "0x41E54B8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004405")]
		[Address(RVA = "0x41E5784", Offset = "0x41E1784", VA = "0x41E5784")]
		private void BuyGiftPackSuccess(object o)
		{
		}

		[Token(Token = "0x6004406")]
		[Address(RVA = "0x41E5790", Offset = "0x41E1790", VA = "0x41E5790", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__10))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004407")]
		[Address(RVA = "0x41E5830", Offset = "0x41E1830", VA = "0x41E5830")]
		private void ArtifactAnime()
		{
		}

		[Token(Token = "0x6004408")]
		[Address(RVA = "0x41E5954", Offset = "0x41E1954", VA = "0x41E5954", Slot = "17")]
		protected override void OnButtonExtendBtnBuyClicked()
		{
		}

		[Token(Token = "0x6004409")]
		[Address(RVA = "0x41E5C0C", Offset = "0x41E1C0C", VA = "0x41E5C0C", Slot = "16")]
		protected override void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x600440A")]
		[Address(RVA = "0x41E5C98", Offset = "0x41E1C98", VA = "0x41E5C98", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600440B")]
		[Address(RVA = "0x41E5DD8", Offset = "0x41E1DD8", VA = "0x41E5DD8", Slot = "12")]
		protected override void OnButtonBGClicked()
		{
		}

		[Token(Token = "0x600440C")]
		[Address(RVA = "0x41E5E64", Offset = "0x41E1E64", VA = "0x41E5E64")]
		public BuyArtifactGiftTwoSurePanel()
		{
		}
	}
}
