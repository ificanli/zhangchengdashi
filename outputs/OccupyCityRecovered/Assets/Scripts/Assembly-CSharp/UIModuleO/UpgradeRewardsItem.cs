using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using DataModule;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000BDD")]
	public class UpgradeRewardsItem : UpgradeRewardsItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BE0")]
		[CompilerGenerated]
		private struct _003CLoadIconAsync_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x4005624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string path;

			[Token(Token = "0x4005627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public UpgradeRewardsItem _003C_003E4__this;

			[Token(Token = "0x4005628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string id;

			[Token(Token = "0x4005629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004963")]
			[Address(RVA = "0x42487D4", Offset = "0x42447D4", VA = "0x42487D4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004964")]
			[Address(RVA = "0x4248B34", Offset = "0x4244B34", VA = "0x4248B34", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BE1")]
		[CompilerGenerated]
		private struct _003CLoadSpineAsync_003Ed__9 : IAsyncStateMachine
		{
			[Token(Token = "0x400562A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400562B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400562C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UpgradeRewardsItem _003C_003E4__this;

			[Token(Token = "0x400562D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string spinePath;

			[Token(Token = "0x400562E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string id;

			[Token(Token = "0x400562F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string animName;

			[Token(Token = "0x4005630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<Spine.Unity.SkeletonDataAsset>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004965")]
			[Address(RVA = "0x4248B40", Offset = "0x4244B40", VA = "0x4248B40", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004966")]
			[Address(RVA = "0x4248F40", Offset = "0x4244F40", VA = "0x4248F40", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BE2")]
		[CompilerGenerated]
		private struct _003CRefresh_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4005631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GlobaUpgradeReward data;

			[Token(Token = "0x4005634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public UpgradeRewardsItem _003C_003E4__this;

			[Token(Token = "0x4005635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4005636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004967")]
			[Address(RVA = "0x4248F4C", Offset = "0x4244F4C", VA = "0x4248F4C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004968")]
			[Address(RVA = "0x4249CF0", Offset = "0x4245CF0", VA = "0x4249CF0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400561B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool isGetReward;

		[Token(Token = "0x400561C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		private bool isUnlock;

		[Token(Token = "0x400561D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Tween getRwardTween;

		[Token(Token = "0x400561E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private GlobaUpgradeReward _data;

		[Token(Token = "0x400561F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private UpgradeRewardsPreviewPanel _upgradeRewardsPreviewPanel;

		[Token(Token = "0x600494E")]
		[Address(RVA = "0x4246BD8", Offset = "0x4242BD8", VA = "0x4246BD8")]
		[AsyncStateMachine(typeof(_003CRefresh_003Ed__5))]
		public void Refresh(GlobaUpgradeReward data)
		{
		}

		[Token(Token = "0x600494F")]
		[Address(RVA = "0x4246C78", Offset = "0x4242C78", VA = "0x4246C78")]
		public void UpgradeRefresh(GlobaUpgradeReward data, Action upgradAnimeCallBack)
		{
		}

		[Token(Token = "0x6004950")]
		[Address(RVA = "0x4247574", Offset = "0x4243574", VA = "0x4247574")]
		private void ResetDisplayState()
		{
		}

		[Token(Token = "0x6004951")]
		[Address(RVA = "0x4247C8C", Offset = "0x4243C8C", VA = "0x4247C8C")]
		[AsyncStateMachine(typeof(_003CLoadIconAsync_003Ed__8))]
		private void LoadIconAsync(string path, string id)
		{
		}

		[Token(Token = "0x6004952")]
		[Address(RVA = "0x4247D34", Offset = "0x4243D34", VA = "0x4247D34")]
		[AsyncStateMachine(typeof(_003CLoadSpineAsync_003Ed__9))]
		private void LoadSpineAsync(string spinePath, string id, string animName)
		{
		}

		[Token(Token = "0x6004953")]
		[Address(RVA = "0x4248104", Offset = "0x4244104", VA = "0x4248104")]
		private string GetSpineAnimName(bool unlock, bool getReward)
		{
			return null;
		}

		[Token(Token = "0x6004954")]
		[Address(RVA = "0x4248194", Offset = "0x4244194", VA = "0x4248194", Slot = "12")]
		protected override void OnButtonExtendRewardClicked()
		{
		}

		[Token(Token = "0x6004955")]
		[Address(RVA = "0x42482C4", Offset = "0x42442C4", VA = "0x42482C4")]
		private void ShowPropBubble()
		{
		}

		[Token(Token = "0x6004956")]
		[Address(RVA = "0x4248478", Offset = "0x4244478", VA = "0x4248478")]
		private void PlayTween()
		{
		}

		[Token(Token = "0x6004957")]
		[Address(RVA = "0x4248604", Offset = "0x4244604", VA = "0x4248604")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6004958")]
		[Address(RVA = "0x424862C", Offset = "0x424462C", VA = "0x424862C")]
		public UpgradeRewardsItem()
		{
		}
	}
}
