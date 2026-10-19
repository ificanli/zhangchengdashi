using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20009E3")]
	public class MysteryAdventureLapRewardPopupView : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009E6")]
		[CompilerGenerated]
		private struct _003CHideAsync_003Ed__22 : IAsyncStateMachine
		{
			[Token(Token = "0x4004994")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004995")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004996")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventureLapRewardPopupView _003C_003E4__this;

			[Token(Token = "0x4004997")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float animationSpeedMultiplier;

			[Token(Token = "0x4004998")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003B06")]
			[Address(RVA = "0x4121F8C", Offset = "0x411DF8C", VA = "0x4121F8C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003B07")]
			[Address(RVA = "0x4122460", Offset = "0x411E460", VA = "0x4122460", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009E7")]
		[CompilerGenerated]
		private struct _003CPlayFallbackScaleHideAsync_003Ed__24 : IAsyncStateMachine
		{
			[Token(Token = "0x4004999")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400499A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400499B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventureLapRewardPopupView _003C_003E4__this;

			[Token(Token = "0x400499C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float animationSpeedMultiplier;

			[Token(Token = "0x400499D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003B08")]
			[Address(RVA = "0x412246C", Offset = "0x411E46C", VA = "0x412246C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003B09")]
			[Address(RVA = "0x41229F0", Offset = "0x411E9F0", VA = "0x41229F0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009E8")]
		[CompilerGenerated]
		private struct _003CPlayFallbackScaleShowAsync_003Ed__23 : IAsyncStateMachine
		{
			[Token(Token = "0x400499E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400499F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40049A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventureLapRewardPopupView _003C_003E4__this;

			[Token(Token = "0x40049A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float animationSpeedMultiplier;

			[Token(Token = "0x40049A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003B0A")]
			[Address(RVA = "0x41229FC", Offset = "0x411E9FC", VA = "0x41229FC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003B0B")]
			[Address(RVA = "0x412301C", Offset = "0x411F01C", VA = "0x412301C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009E9")]
		[CompilerGenerated]
		private struct _003CShowAsync_003Ed__21 : IAsyncStateMachine
		{
			[Token(Token = "0x40049A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40049A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40049A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventureLapRewardPopupView _003C_003E4__this;

			[Token(Token = "0x40049A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float animationSpeedMultiplier;

			[Token(Token = "0x40049A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003B0C")]
			[Address(RVA = "0x4123028", Offset = "0x411F028", VA = "0x4123028", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003B0D")]
			[Address(RVA = "0x4123748", Offset = "0x411F748", VA = "0x4123748", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004986")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _closeButton;

		[Token(Token = "0x4004987")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _contentRoot;

		[Token(Token = "0x4004988")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _upgradeBlock;

		[Token(Token = "0x4004989")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _levelText;

		[Token(Token = "0x400498A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI _bonusPercentText;

		[Token(Token = "0x400498B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _lapBlock;

		[Token(Token = "0x400498C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TextMeshProUGUI _rewardAmountText;

		[Token(Token = "0x400498D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Action _onClose;

		[Token(Token = "0x400498E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool _built;

		[Token(Token = "0x400498F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool _isPlayTween;

		[Token(Token = "0x170008FC")]
		public Button CloseButton
		{
			[Token(Token = "0x6003AE8")]
			[Address(RVA = "0x4120B88", Offset = "0x411CB88", VA = "0x4120B88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008FD")]
		public RectTransform ContentRoot
		{
			[Token(Token = "0x6003AE9")]
			[Address(RVA = "0x4120B90", Offset = "0x411CB90", VA = "0x4120B90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008FE")]
		public bool IsPlayTween
		{
			[Token(Token = "0x6003AEA")]
			[Address(RVA = "0x4120B98", Offset = "0x411CB98", VA = "0x4120B98")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6003AEB")]
		[Address(RVA = "0x4120BA0", Offset = "0x411CBA0", VA = "0x4120BA0")]
		public void Initialize(Action onClose)
		{
		}

		[Token(Token = "0x6003AEC")]
		[Address(RVA = "0x4120BBC", Offset = "0x411CBBC", VA = "0x4120BBC")]
		public void EnsureBuilt()
		{
		}

		[Token(Token = "0x6003AED")]
		[Address(RVA = "0x4121220", Offset = "0x411D220", VA = "0x4121220")]
		[ContextMenu("Rebuild UI From Builder")]
		public void RebuildUi()
		{
		}

		[Token(Token = "0x6003AEE")]
		[Address(RVA = "0x412124C", Offset = "0x411D24C", VA = "0x412124C")]
		private void ClearBuiltUi()
		{
		}

		[Token(Token = "0x6003AEF")]
		[Address(RVA = "0x4121330", Offset = "0x411D330", VA = "0x4121330")]
		public UniTask ApplyAsync(MysteryAdventureLapRewardPopupData data)
		{
			return default;
		}

		[Token(Token = "0x6003AF0")]
		[Address(RVA = "0x4121B30", Offset = "0x411DB30", VA = "0x4121B30")]
		[AsyncStateMachine(typeof(_003CShowAsync_003Ed__21))]
		public UniTask ShowAsync(float animationSpeedMultiplier = 1f)
		{
			return default;
		}

		[Token(Token = "0x6003AF1")]
		[Address(RVA = "0x4121BD0", Offset = "0x411DBD0", VA = "0x4121BD0")]
		[AsyncStateMachine(typeof(_003CHideAsync_003Ed__22))]
		public UniTask HideAsync(float animationSpeedMultiplier = 1f)
		{
			return default;
		}

		[Token(Token = "0x6003AF2")]
		[Address(RVA = "0x4121C70", Offset = "0x411DC70", VA = "0x4121C70")]
		[AsyncStateMachine(typeof(_003CPlayFallbackScaleShowAsync_003Ed__23))]
		private UniTask PlayFallbackScaleShowAsync(float animationSpeedMultiplier)
		{
			return default;
		}

		[Token(Token = "0x6003AF3")]
		[Address(RVA = "0x4121D10", Offset = "0x411DD10", VA = "0x4121D10")]
		[AsyncStateMachine(typeof(_003CPlayFallbackScaleHideAsync_003Ed__24))]
		private UniTask PlayFallbackScaleHideAsync(float animationSpeedMultiplier)
		{
			return default;
		}

		[Token(Token = "0x6003AF4")]
		[Address(RVA = "0x4121DB0", Offset = "0x411DDB0", VA = "0x4121DB0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6003AF5")]
		[Address(RVA = "0x4120C54", Offset = "0x411CC54", VA = "0x4120C54")]
		private void BindCloseButton()
		{
		}

		[Token(Token = "0x6003AF6")]
		[Address(RVA = "0x4121DC8", Offset = "0x411DDC8", VA = "0x4121DC8")]
		private void OnCloseClicked()
		{
		}

		[Token(Token = "0x6003AF7")]
		[Address(RVA = "0x4121DEC", Offset = "0x411DDEC", VA = "0x4121DEC")]
		private static void Stretch(RectTransform rect, Vector2 offsetMin, Vector2 offsetMax)
		{
		}

		[Token(Token = "0x6003AF8")]
		[Address(RVA = "0x4121EC8", Offset = "0x411DEC8", VA = "0x4121EC8")]
		internal void BindCloseButton(Button button)
		{
		}

		[Token(Token = "0x6003AF9")]
		[Address(RVA = "0x4121ED0", Offset = "0x411DED0", VA = "0x4121ED0")]
		internal void BindContentRoot(RectTransform root)
		{
		}

		[Token(Token = "0x6003AFA")]
		[Address(RVA = "0x4121ED8", Offset = "0x411DED8", VA = "0x4121ED8")]
		internal void BindUpgradeBlock(GameObject block)
		{
		}

		[Token(Token = "0x6003AFB")]
		[Address(RVA = "0x4121EE0", Offset = "0x411DEE0", VA = "0x4121EE0")]
		internal void BindLevelText(TextMeshProUGUI text)
		{
		}

		[Token(Token = "0x6003AFC")]
		[Address(RVA = "0x4121EE8", Offset = "0x411DEE8", VA = "0x4121EE8")]
		internal void BindBonusPercentText(TextMeshProUGUI text)
		{
		}

		[Token(Token = "0x6003AFD")]
		[Address(RVA = "0x4121590", Offset = "0x411D590", VA = "0x4121590")]
		private void TryBindSerializedRefsFromHierarchy()
		{
		}

		[Token(Token = "0x6003AFE")]
		[Address(RVA = "0x4121EF0", Offset = "0x411DEF0", VA = "0x4121EF0")]
		internal void BindLapBlock(GameObject block)
		{
		}

		[Token(Token = "0x6003AFF")]
		[Address(RVA = "0x4121EF8", Offset = "0x411DEF8", VA = "0x4121EF8")]
		internal void BindRewardAmountText(TextMeshProUGUI text)
		{
		}

		[Token(Token = "0x6003B00")]
		[Address(RVA = "0x41219AC", Offset = "0x411D9AC", VA = "0x41219AC")]
		private void ApplyLapRewardAmountText(MysteryAdventureLapRewardPopupData data)
		{
		}

		[Token(Token = "0x6003B01")]
		[Address(RVA = "0x4121F00", Offset = "0x411DF00", VA = "0x4121F00")]
		public MysteryAdventureLapRewardPopupView()
		{
		}
	}
}
