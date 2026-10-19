using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using GameModule;
using Il2CppDummyDll;
using Spine;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000AAD")]
	public class PropLotteryItem : PropLotteryItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AAE")]
		[CompilerGenerated]
		private struct _003CUpdateInfo_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x4004E9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004E9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004E9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PropLotteryItem _003C_003E4__this;

			[Token(Token = "0x4004E9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SummonPanelMode summonPanelMode;

			[Token(Token = "0x4004E9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RewardConfigSingle rewardConfigSingle;

			[Token(Token = "0x4004E9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private IGlobalAssetsInfo _003Cinfo_003E5__2;

			[Token(Token = "0x4004EA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int _003Clevel_003E5__3;

			[Token(Token = "0x4004EA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<GameObject> _003Ceffect_003E5__4;

			[Token(Token = "0x4004EA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Image _003C_003E7__wrap4;

			[Token(Token = "0x4004EA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4004EA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6004079")]
			[Address(RVA = "0x41A8DF8", Offset = "0x41A4DF8", VA = "0x41A8DF8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600407A")]
			[Address(RVA = "0x41AA150", Offset = "0x41A6150", VA = "0x41AA150", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004E94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool epic;

		[Token(Token = "0x4004E95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool legend;

		[Token(Token = "0x4004E96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		private bool common;

		[Token(Token = "0x4004E97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		private bool rare;

		[Token(Token = "0x4004E98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private SkeletonGraphic spine;

		[Token(Token = "0x4004E99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private SummonPanelMode _summonPanelMode;

		[Token(Token = "0x6004070")]
		[Address(RVA = "0x41A84DC", Offset = "0x41A44DC", VA = "0x41A84DC")]
		public bool ShouldPlaySwayAnimation()
		{
			return default;
		}

		[Token(Token = "0x6004071")]
		[Address(RVA = "0x41A8508", Offset = "0x41A4508", VA = "0x41A8508")]
		private bool HasRareSpineEffect()
		{
			return default;
		}

		[Token(Token = "0x6004072")]
		[Address(RVA = "0x41A8528", Offset = "0x41A4528", VA = "0x41A8528")]
		[AsyncStateMachine(typeof(_003CUpdateInfo_003Ed__8))]
		public UniTask UpdateInfo(RewardConfigSingle rewardConfigSingle, SummonPanelMode summonPanelMode = SummonPanelMode.Normal)
		{
			return default;
		}

		[Token(Token = "0x6004073")]
		[Address(RVA = "0x41A85D0", Offset = "0x41A45D0", VA = "0x41A85D0")]
		private void ShowRareSpineGlowEffect()
		{
		}

		[Token(Token = "0x6004074")]
		[Address(RVA = "0x41A86A0", Offset = "0x41A46A0", VA = "0x41A86A0")]
		public void SetCount(int count)
		{
		}

		[Token(Token = "0x6004075")]
		[Address(RVA = "0x41A8848", Offset = "0x41A4848", VA = "0x41A8848")]
		public void ForceShow()
		{
		}

		[Token(Token = "0x6004076")]
		[Address(RVA = "0x41A8B04", Offset = "0x41A4B04", VA = "0x41A8B04")]
		public void PlayEffect()
		{
		}

		[Token(Token = "0x6004077")]
		[Address(RVA = "0x41A8C88", Offset = "0x41A4C88", VA = "0x41A8C88")]
		private void OnSpineComplete(TrackEntry trackentry)
		{
		}

		[Token(Token = "0x6004078")]
		[Address(RVA = "0x41A8DE8", Offset = "0x41A4DE8", VA = "0x41A8DE8")]
		public PropLotteryItem()
		{
		}
	}
}
