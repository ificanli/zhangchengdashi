using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using DataModule;
using Il2CppDummyDll;
using TimeModuleO;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x200075E")]
	public class BtnCommonCardPackItem : BtnCommonCardPackItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000760")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x40039BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40039BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40039BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GlobalShopInfo info;

			[Token(Token = "0x40039C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public BtnCommonCardPackItem _003C_003E4__this;

			[Token(Token = "0x6002862")]
			[Address(RVA = "0x3FB1F90", Offset = "0x3FADF90", VA = "0x3FB1F90", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002863")]
			[Address(RVA = "0x3FB2854", Offset = "0x3FAE854", VA = "0x3FB2854", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000761")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x40039C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40039C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40039C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BtnCommonCardPackItem _003C_003E4__this;

			[Token(Token = "0x40039C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002864")]
			[Address(RVA = "0x3FB2860", Offset = "0x3FAE860", VA = "0x3FB2860", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002865")]
			[Address(RVA = "0x3FB2A40", Offset = "0x3FAEA40", VA = "0x3FB2A40", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000762")]
		[CompilerGenerated]
		private struct _003CUpdateCardItem_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x40039C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40039C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40039C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BtnCommonCardPackItem _003C_003E4__this;

			[Token(Token = "0x40039C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int _003Cindex_003E5__2;

			[Token(Token = "0x40039C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private List<RewardItemUI> _003CrewardItemUIs_003E5__3;

			[Token(Token = "0x40039CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private List<Image> _003CimgIconUIs_003E5__4;

			[Token(Token = "0x40039CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private string[] _003CrewardConfig_003E5__5;

			[Token(Token = "0x40039CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private int _003Ci_003E5__6;

			[Token(Token = "0x40039CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Image _003C_003E7__wrap6;

			[Token(Token = "0x40039CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002866")]
			[Address(RVA = "0x3FB2A4C", Offset = "0x3FAEA4C", VA = "0x3FB2A4C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002867")]
			[Address(RVA = "0x3FB37DC", Offset = "0x3FAF7DC", VA = "0x3FB37DC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40039B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private GlobalShopInfo _info;

		[Token(Token = "0x40039B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private string IAPID;

		[Token(Token = "0x40039B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool InitStartEvevt;

		[Token(Token = "0x40039B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private TimeManager.Timer toMondayTimer;

		[Token(Token = "0x40039BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Tween lightTween;

		[Token(Token = "0x6002850")]
		[Address(RVA = "0x3FB0D64", Offset = "0x3FACD64", VA = "0x3FB0D64", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__5))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002851")]
		[Address(RVA = "0x3FB0DF8", Offset = "0x3FACDF8", VA = "0x3FB0DF8")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__6))]
		public void Init(GlobalShopInfo info)
		{
		}

		[Token(Token = "0x6002852")]
		[Address(RVA = "0x3FB0E94", Offset = "0x3FACE94", VA = "0x3FB0E94")]
		[AsyncStateMachine(typeof(_003CUpdateCardItem_003Ed__7))]
		private void UpdateCardItem()
		{
		}

		[Token(Token = "0x6002853")]
		[Address(RVA = "0x3FB0F2C", Offset = "0x3FACF2C", VA = "0x3FB0F2C")]
		private void Update()
		{
		}

		[Token(Token = "0x6002854")]
		[Address(RVA = "0x3FB1060", Offset = "0x3FAD060", VA = "0x3FB1060")]
		private void TimeToMonDayZero(object o)
		{
		}

		[Token(Token = "0x6002855")]
		[Address(RVA = "0x3FB133C", Offset = "0x3FAD33C", VA = "0x3FB133C")]
		private void RefreshItem(object o)
		{
		}

		[Token(Token = "0x6002856")]
		[Address(RVA = "0x3FB1354", Offset = "0x3FAD354", VA = "0x3FB1354")]
		private void RefreshBuyCount()
		{
		}

		[Token(Token = "0x6002857")]
		[Address(RVA = "0x3FB1064", Offset = "0x3FAD064", VA = "0x3FB1064")]
		private void UpdateBuyPackCountUI()
		{
		}

		[Token(Token = "0x6002858")]
		[Address(RVA = "0x3FB16F8", Offset = "0x3FAD6F8", VA = "0x3FB16F8")]
		private string[] BuildGiftPackPackRewardArray(Dictionary<string, int> packConfig)
		{
			return null;
		}

		[Token(Token = "0x6002859")]
		[Address(RVA = "0x3FB1A1C", Offset = "0x3FADA1C", VA = "0x3FB1A1C", Slot = "12")]
		protected override void OnButtonExtendBtnCommonCardPackItemClicked()
		{
		}

		[Token(Token = "0x600285A")]
		[Address(RVA = "0x3FB1CB0", Offset = "0x3FADCB0", VA = "0x3FB1CB0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600285B")]
		[Address(RVA = "0x3FB1E38", Offset = "0x3FADE38", VA = "0x3FB1E38")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600285C")]
		[Address(RVA = "0x3FB1E60", Offset = "0x3FADE60", VA = "0x3FB1E60")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600285D")]
		[Address(RVA = "0x3FB1E88", Offset = "0x3FADE88", VA = "0x3FB1E88")]
		public BtnCommonCardPackItem()
		{
		}
	}
}
