using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using GameModule;
using Il2CppDummyDll;
using Spine;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000A7E")]
	public class OpenBoxAnimationPanel : OpenBoxAnimationPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A80")]
		[CompilerGenerated]
		private struct _003CCreateReward_003Ed__13 : IAsyncStateMachine
		{
			[Token(Token = "0x4004D9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004D9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004D9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public OpenBoxAnimationPanel _003C_003E4__this;

			[Token(Token = "0x4004D9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003F47")]
			[Address(RVA = "0x417B4A0", Offset = "0x41774A0", VA = "0x417B4A0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003F48")]
			[Address(RVA = "0x417BE2C", Offset = "0x4177E2C", VA = "0x417BE2C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A81")]
		[CompilerGenerated]
		private struct _003CInitSpine_003Ed__11 : IAsyncStateMachine
		{
			[Token(Token = "0x4004D9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004DA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004DA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public OpenBoxAnimationPanel _003C_003E4__this;

			[Token(Token = "0x4004DA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int boxid;

			[Token(Token = "0x4004DA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<Spine.Unity.SkeletonDataAsset>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003F49")]
			[Address(RVA = "0x417BE38", Offset = "0x4177E38", VA = "0x417BE38", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003F4A")]
			[Address(RVA = "0x417C598", Offset = "0x4178598", VA = "0x417C598", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A82")]
		[CompilerGenerated]
		private struct _003COnButtonBGClicked_003Ed__15 : IAsyncStateMachine
		{
			[Token(Token = "0x4004DA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004DA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004DA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public OpenBoxAnimationPanel _003C_003E4__this;

			[Token(Token = "0x6003F4B")]
			[Address(RVA = "0x417C5A4", Offset = "0x41785A4", VA = "0x417C5A4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003F4C")]
			[Address(RVA = "0x417C6A4", Offset = "0x41786A4", VA = "0x417C6A4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A83")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4004DA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004DA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004DA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public OpenBoxAnimationPanel _003C_003E4__this;

			[Token(Token = "0x4004DAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003F4D")]
			[Address(RVA = "0x417C6B0", Offset = "0x41786B0", VA = "0x417C6B0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003F4E")]
			[Address(RVA = "0x417C9D0", Offset = "0x41789D0", VA = "0x417C9D0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A84")]
		[CompilerGenerated]
		private struct _003CShowAllRewardAnimation_003Ed__20 : IAsyncStateMachine
		{
			[Token(Token = "0x4004DAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004DAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004DAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public OpenBoxAnimationPanel _003C_003E4__this;

			[Token(Token = "0x4004DAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4004DAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int _003Ci_003E5__2;

			[Token(Token = "0x6003F4F")]
			[Address(RVA = "0x417C9DC", Offset = "0x41789DC", VA = "0x417C9DC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003F50")]
			[Address(RVA = "0x417D48C", Offset = "0x417948C", VA = "0x417D48C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004D91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private string spineAnime_Open;

		[Token(Token = "0x4004D92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private string spineAnime_Loop;

		[Token(Token = "0x4004D93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool _canOpen;

		[Token(Token = "0x4004D94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		private bool isPlayAnition;

		[Token(Token = "0x4004D95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private RewardConfig _rewardConfig;

		[Token(Token = "0x4004D96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private GameObject rewardItemObj;

		[Token(Token = "0x4004D97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private GameObject rewardItemPositionObj;

		[Token(Token = "0x4004D98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private List<GameObject> _rewardObjList;

		[Token(Token = "0x4004D99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<Transform> rewardRoots;

		[Token(Token = "0x170009B7")]
		public bool IsEntryAnimationPlaying
		{
			[Token(Token = "0x6003F3D")]
			[Address(RVA = "0x417AE74", Offset = "0x4176E74", VA = "0x417AE74")]
			get
			{
				return isPlayAnition;
			}
		}

		[Token(Token = "0x6003F35")]
		[Address(RVA = "0x417A434", Offset = "0x4176434", VA = "0x417A434", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6003F36")]
		[Address(RVA = "0x417A620", Offset = "0x4176620", VA = "0x417A620", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__10))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003F37")]
		[Address(RVA = "0x417A6B4", Offset = "0x41766B4", VA = "0x417A6B4")]
		[AsyncStateMachine(typeof(_003CInitSpine_003Ed__11))]
		private void InitSpine(int boxid)
		{
		}

		[Token(Token = "0x6003F38")]
		[Address(RVA = "0x417A754", Offset = "0x4176754", VA = "0x417A754")]
		private void SpineOnComplete_dakai(TrackEntry trackEntry)
		{
		}

		[Token(Token = "0x6003F39")]
		[Address(RVA = "0x417A854", Offset = "0x4176854", VA = "0x417A854")]
		[AsyncStateMachine(typeof(_003CCreateReward_003Ed__13))]
		private void CreateReward()
		{
		}

		[Token(Token = "0x6003F3A")]
		[Address(RVA = "0x417A8E4", Offset = "0x41768E4", VA = "0x417A8E4", Slot = "13")]
		protected override void OnButtonExtendBtnSkipClicked()
		{
		}

		[Token(Token = "0x6003F3B")]
		[Address(RVA = "0x417AC58", Offset = "0x4176C58", VA = "0x417AC58", Slot = "12")]
		[AsyncStateMachine(typeof(_003COnButtonBGClicked_003Ed__15))]
		protected override void OnButtonBGClicked()
		{
		}

		[Token(Token = "0x6003F3C")]
		[Address(RVA = "0x417A978", Offset = "0x4176978", VA = "0x417A978")]
		private void ShowAllReward()
		{
		}

		[Token(Token = "0x6003F3E")]
		[Address(RVA = "0x417AE7C", Offset = "0x4176E7C", VA = "0x417AE7C")]
		public void ForceSkipToRewardReveal()
		{
		}

		[Token(Token = "0x6003F3F")]
		[Address(RVA = "0x417AE8C", Offset = "0x4176E8C", VA = "0x417AE8C")]
		[AsyncStateMachine(typeof(_003CShowAllRewardAnimation_003Ed__20))]
		private void ShowAllRewardAnimation()
		{
		}

		[Token(Token = "0x6003F40")]
		[Address(RVA = "0x417AF1C", Offset = "0x4176F1C", VA = "0x417AF1C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6003F41")]
		[Address(RVA = "0x417B194", Offset = "0x4177194", VA = "0x417B194")]
		public OpenBoxAnimationPanel()
		{
		}
	}
}
