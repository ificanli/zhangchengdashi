using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using ljzs_lt;

namespace UIModuleO
{
	[Token(Token = "0x2000A2F")]
	public class MysteryAdventureRuinsPanel : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A30")]
		[CompilerGenerated]
		private struct _003CLoadCardAsync_003Ed__16 : IAsyncStateMachine
		{
			[Token(Token = "0x4004BA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004BA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004BA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MysteryAdventureRuinsPanel _003C_003E4__this;

			[Token(Token = "0x4004BAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int eventId;

			[Token(Token = "0x4004BAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003CD8")]
			[Address(RVA = "0x414E804", Offset = "0x414A804", VA = "0x414E804", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003CD9")]
			[Address(RVA = "0x414EE9C", Offset = "0x414AE9C", VA = "0x414EE9C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A31")]
		[CompilerGenerated]
		private struct _003CLoadRewardPreviewIconAsync_003Ed__13 : IAsyncStateMachine
		{
			[Token(Token = "0x4004BAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004BAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004BAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MysteryAdventureRuinsPanel _003C_003E4__this;

			[Token(Token = "0x4004BAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string rewardRaw;

			[Token(Token = "0x4004BB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int _003CrequestId_003E5__2;

			[Token(Token = "0x4004BB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003CDA")]
			[Address(RVA = "0x414EEA8", Offset = "0x414AEA8", VA = "0x414EEA8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003CDB")]
			[Address(RVA = "0x414F3C0", Offset = "0x414B3C0", VA = "0x414F3C0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004BA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MysteryAdventureRuinsPanelView _view;

		[Token(Token = "0x4004BA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Action<int> _onOptionSelected;

		[Token(Token = "0x4004BA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Action _onClosed;

		[Token(Token = "0x4004BA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RuinsConfigConfig _currentConfig;

		[Token(Token = "0x4004BA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _loadingCardEventId;

		[Token(Token = "0x4004BA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int _loadingRewardPreviewRequestId;

		[Token(Token = "0x6003CCB")]
		[Address(RVA = "0x414D894", Offset = "0x4149894", VA = "0x414D894")]
		private void Awake()
		{
		}

		[Token(Token = "0x6003CCC")]
		[Address(RVA = "0x414D920", Offset = "0x4149920", VA = "0x414D920")]
		public void ShowEvent(RuinsConfigConfig config, Action<int> onOptionSelected, [Optional] Action onClosed)
		{
		}

		[Token(Token = "0x6003CCD")]
		[Address(RVA = "0x413C2A0", Offset = "0x41382A0", VA = "0x413C2A0")]
		public UniTask ShowEventAsync(RuinsConfigConfig config, Action<int> onOptionSelected, [Optional] Action onClosed, float animationSpeedMultiplier = 1f)
		{
			return default;
		}

		[Token(Token = "0x6003CCE")]
		[Address(RVA = "0x414DD14", Offset = "0x4149D14", VA = "0x414DD14")]
		public void HideEvent()
		{
		}

		[Token(Token = "0x6003CCF")]
		[Address(RVA = "0x414D938", Offset = "0x4149938", VA = "0x414D938")]
		private void Refresh(RuinsConfigConfig config)
		{
		}

		[Token(Token = "0x6003CD0")]
		[Address(RVA = "0x414DD70", Offset = "0x4149D70", VA = "0x414DD70")]
		private static string BuildDescriptionText(RuinsConfigConfig config, string description, bool showRewardPreview, string rewardPreviewRaw)
		{
			return null;
		}

		[Token(Token = "0x6003CD1")]
		[Address(RVA = "0x414DEC0", Offset = "0x4149EC0", VA = "0x414DEC0")]
		private void RefreshRewardPreview(string rewardRaw, bool showPreview)
		{
		}

		[Token(Token = "0x6003CD2")]
		[Address(RVA = "0x414E600", Offset = "0x414A600", VA = "0x414E600")]
		[AsyncStateMachine(typeof(_003CLoadRewardPreviewIconAsync_003Ed__13))]
		private UniTaskVoid LoadRewardPreviewIconAsync(string rewardRaw)
		{
			return default;
		}

		[Token(Token = "0x6003CD3")]
		[Address(RVA = "0x414E684", Offset = "0x414A684", VA = "0x414E684")]
		private void OnOptionClicked(int optionIndex)
		{
		}

		[Token(Token = "0x6003CD4")]
		[Address(RVA = "0x414E740", Offset = "0x414A740", VA = "0x414E740")]
		public void ConfirmFirstOption()
		{
		}

		[Token(Token = "0x6003CD5")]
		[Address(RVA = "0x414E00C", Offset = "0x414A00C", VA = "0x414E00C")]
		[AsyncStateMachine(typeof(_003CLoadCardAsync_003Ed__16))]
		private UniTaskVoid LoadCardAsync(int eventId)
		{
			return default;
		}

		[Token(Token = "0x6003CD6")]
		[Address(RVA = "0x414E748", Offset = "0x414A748", VA = "0x414E748")]
		private void ApplyCardSprite(Sprite sprite)
		{
		}

		[Token(Token = "0x6003CD7")]
		[Address(RVA = "0x414E7FC", Offset = "0x414A7FC", VA = "0x414E7FC")]
		public MysteryAdventureRuinsPanel()
		{
		}
	}
}
