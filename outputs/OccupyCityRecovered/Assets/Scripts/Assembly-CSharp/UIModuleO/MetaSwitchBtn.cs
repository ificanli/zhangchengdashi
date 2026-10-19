using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using DataModule;
using Il2CppDummyDll;
using Spine;

namespace UIModuleO
{
	[Token(Token = "0x200098D")]
	public class MetaSwitchBtn : MetaSwitchBtnComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200098E")]
		[CompilerGenerated]
		private struct _003CInitSpine_003Ed__28 : IAsyncStateMachine
		{
			[Token(Token = "0x400478A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400478B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400478C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MetaSwitchBtn _003C_003E4__this;

			[Token(Token = "0x400478D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private UniTask<Spine.Unity.SkeletonDataAsset>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003891")]
			[Address(RVA = "0x40F7F24", Offset = "0x40F3F24", VA = "0x40F7F24", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003892")]
			[Address(RVA = "0x40F8470", Offset = "0x40F4470", VA = "0x40F8470", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400477A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string metaInfoId;

		[Token(Token = "0x400477B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool _isUpgradeMainTowerPanelDoAniIng;

		[Token(Token = "0x400477C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		private bool banClick;

		[Token(Token = "0x400477D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB2")]
		private bool primaryRedDotIsTrue;

		[Token(Token = "0x400477E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB3")]
		private bool artifactsRedDotIsTrue;

		[Token(Token = "0x400477F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private bool cardRedDotStateIsTrue;

		[Token(Token = "0x4004780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		private bool propRedDotStateIsTrue;

		[Token(Token = "0x4004781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private GlobalMetaModuleInfo _info;

		[Token(Token = "0x4004782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool isSelected;

		[Token(Token = "0x4004783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private AnimationState _animationState;

		[Token(Token = "0x4004784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private bool _isDestroyed;

		[Token(Token = "0x4004785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Action<bool> _featureUnlockStateChanged;

		[Token(Token = "0x4004786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Tween _scaleTween;

		[Token(Token = "0x4004787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Tween _iconMoveTween;

		[Token(Token = "0x4004788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Tween _bgScaleTween;

		[Token(Token = "0x4004789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Tween iconScaleTween;

		[Token(Token = "0x17000879")]
		private static bool IsShopLockedByTraining
		{
			[Token(Token = "0x6003885")]
			[Address(RVA = "0x40F6570", Offset = "0x40F2570", VA = "0x40F6570")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600387E")]
		[Address(RVA = "0x40F5F64", Offset = "0x40F1F64", VA = "0x40F5F64", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600387F")]
		[Address(RVA = "0x40F629C", Offset = "0x40F229C", VA = "0x40F629C")]
		private bool IsFirstChild()
		{
			return default;
		}

		[Token(Token = "0x6003880")]
		[Address(RVA = "0x40F62C8", Offset = "0x40F22C8", VA = "0x40F62C8")]
		private bool IsLastChild()
		{
			return default;
		}

		[Token(Token = "0x6003881")]
		[Address(RVA = "0x40F62F4", Offset = "0x40F22F4", VA = "0x40F62F4")]
		private void OnLanguageChanged(object obj)
		{
		}

		[Token(Token = "0x6003882")]
		[Address(RVA = "0x40F648C", Offset = "0x40F248C", VA = "0x40F648C")]
		private void BeginBanClick(object o)
		{
		}

		[Token(Token = "0x6003883")]
		[Address(RVA = "0x40F6498", Offset = "0x40F2498", VA = "0x40F6498")]
		private void EndBanClick(object o)
		{
		}

		[Token(Token = "0x6003884")]
		[Address(RVA = "0x40F64A0", Offset = "0x40F24A0", VA = "0x40F64A0")]
		private void OnTrainingGroundComplete(object _)
		{
		}

		[Token(Token = "0x6003886")]
		[Address(RVA = "0x40F6700", Offset = "0x40F2700", VA = "0x40F6700")]
		public void InitInfo(GlobalMetaModuleInfo metaModuleInfo)
		{
		}

		[Token(Token = "0x6003887")]
		[Address(RVA = "0x40F7248", Offset = "0x40F3248", VA = "0x40F7248")]
		public void UpdateSelected(string selectedId)
		{
		}

		[Token(Token = "0x6003888")]
		[Address(RVA = "0x40F76D4", Offset = "0x40F36D4", VA = "0x40F76D4", Slot = "12")]
		protected override void OnButtonExtendMetaSwitchBtnClicked()
		{
		}

		[Token(Token = "0x6003889")]
		[Address(RVA = "0x40F6D20", Offset = "0x40F2D20", VA = "0x40F6D20")]
		[AsyncStateMachine(typeof(_003CInitSpine_003Ed__28))]
		private UniTaskVoid InitSpine()
		{
			return default;
		}

		[Token(Token = "0x600388A")]
		[Address(RVA = "0x40F7654", Offset = "0x40F3654", VA = "0x40F7654")]
		private void PlaySpine(bool isShow)
		{
		}

		[Token(Token = "0x600388B")]
		[Address(RVA = "0x40F7A94", Offset = "0x40F3A94", VA = "0x40F7A94")]
		private void UpgradeMainTowerPanelBeginDoAni(object o)
		{
		}

		[Token(Token = "0x600388C")]
		[Address(RVA = "0x40F7AA0", Offset = "0x40F3AA0", VA = "0x40F7AA0")]
		private void UpgradeMainTowerPanelDoAniEnd(object o)
		{
		}

		[Token(Token = "0x600388D")]
		[Address(RVA = "0x40F7AA8", Offset = "0x40F3AA8", VA = "0x40F7AA8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600388E")]
		[Address(RVA = "0x40F7E64", Offset = "0x40F3E64", VA = "0x40F7E64")]
		private void OnFeatureUnlockStateChanged(bool isUnlock)
		{
		}

		[Token(Token = "0x600388F")]
		[Address(RVA = "0x40F7DF4", Offset = "0x40F3DF4", VA = "0x40F7DF4")]
		private void KillTweens()
		{
		}

		[Token(Token = "0x6003890")]
		[Address(RVA = "0x40F7F14", Offset = "0x40F3F14", VA = "0x40F7F14")]
		public MetaSwitchBtn()
		{
		}
	}
}
