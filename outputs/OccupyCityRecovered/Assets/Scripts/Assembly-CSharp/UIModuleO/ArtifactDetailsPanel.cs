using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using DataModule;
using GameModule;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x20006C5")]
	public class ArtifactDetailsPanel : ArtifactDetailsPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006C6")]
		[CompilerGenerated]
		private struct _003COnButtonExtendStarUpgradeClicked_003Ed__18 : IAsyncStateMachine
		{
			[Token(Token = "0x4003630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ArtifactDetailsPanel _003C_003E4__this;

			[Token(Token = "0x4003633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002436")]
			[Address(RVA = "0x3F56E2C", Offset = "0x3F52E2C", VA = "0x3F56E2C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002437")]
			[Address(RVA = "0x3F571D0", Offset = "0x3F531D0", VA = "0x3F571D0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006C7")]
		[CompilerGenerated]
		private struct _003CRefreshForgingList_003Ed__9 : IAsyncStateMachine
		{
			[Token(Token = "0x4003634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArtifactDetailsPanel _003C_003E4__this;

			[Token(Token = "0x4003637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002438")]
			[Address(RVA = "0x3F571DC", Offset = "0x3F531DC", VA = "0x3F571DC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002439")]
			[Address(RVA = "0x3F57C28", Offset = "0x3F53C28", VA = "0x3F57C28", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006C8")]
		[CompilerGenerated]
		private struct _003CRefreshIconLightEffect_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4003638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400363A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArtifactDetailsPanel _003C_003E4__this;

			[Token(Token = "0x400363B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int rareLevel;

			[Token(Token = "0x400363C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private SkeletonGraphic _003CspineGraphic_003E5__2;

			[Token(Token = "0x400363D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<SkeletonDataAsset>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600243A")]
			[Address(RVA = "0x3F57C34", Offset = "0x3F53C34", VA = "0x3F57C34", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600243B")]
			[Address(RVA = "0x3F58248", Offset = "0x3F54248", VA = "0x3F58248", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006C9")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x400363E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400363F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArtifactDetailsPanel _003C_003E4__this;

			[Token(Token = "0x4003641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x4003642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600243C")]
			[Address(RVA = "0x3F58254", Offset = "0x3F54254", VA = "0x3F58254", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600243D")]
			[Address(RVA = "0x3F5895C", Offset = "0x3F5495C", VA = "0x3F5895C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006CA")]
		[CompilerGenerated]
		private struct _003CUpdateView_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x4003643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArtifactDetailsPanel _003C_003E4__this;

			[Token(Token = "0x4003646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private GlobalPropInfo _003Cinfo_003E5__2;

			[Token(Token = "0x4003647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private bool _003CisUnlock_003E5__3;

			[Token(Token = "0x4003648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4003649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x600243E")]
			[Address(RVA = "0x3F58968", Offset = "0x3F54968", VA = "0x3F58968", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600243F")]
			[Address(RVA = "0x3F5A52C", Offset = "0x3F5652C", VA = "0x3F5A52C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400362B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private UserPropData userData;

		[Token(Token = "0x400362C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Tween _iconFloatTween;

		[Token(Token = "0x400362D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 _iconOriginLocalPos;

		[Token(Token = "0x400362E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int _pendingTraitUnlockLevel;

		[Token(Token = "0x400362F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private readonly List<PropDetailAttrItem> _attrItems;

		[Token(Token = "0x600241D")]
		[Address(RVA = "0x3F54FD8", Offset = "0x3F50FD8", VA = "0x3F54FD8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600241E")]
		[Address(RVA = "0x3F551EC", Offset = "0x3F511EC", VA = "0x3F551EC", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__5))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600241F")]
		[Address(RVA = "0x3F55288", Offset = "0x3F51288", VA = "0x3F55288")]
		private void EventUpdateUI(object o)
		{
		}

		[Token(Token = "0x6002420")]
		[Address(RVA = "0x3F5529C", Offset = "0x3F5129C", VA = "0x3F5529C")]
		[AsyncStateMachine(typeof(_003CUpdateView_003Ed__7))]
		private UniTask UpdateView()
		{
			return default;
		}

		[Token(Token = "0x6002421")]
		[Address(RVA = "0x3F55330", Offset = "0x3F51330", VA = "0x3F55330")]
		private void RefreshUpgradeProgress(GlobalPropInfo info)
		{
		}

		[Token(Token = "0x6002422")]
		[Address(RVA = "0x3F556A4", Offset = "0x3F516A4", VA = "0x3F556A4")]
		[AsyncStateMachine(typeof(_003CRefreshForgingList_003Ed__9))]
		private UniTask RefreshForgingList()
		{
			return default;
		}

		[Token(Token = "0x6002423")]
		[Address(RVA = "0x3F55730", Offset = "0x3F51730", VA = "0x3F55730")]
		[AsyncStateMachine(typeof(_003CRefreshIconLightEffect_003Ed__10))]
		private UniTask RefreshIconLightEffect(int rareLevel)
		{
			return default;
		}

		[Token(Token = "0x6002424")]
		[Address(RVA = "0x3F557D0", Offset = "0x3F517D0", VA = "0x3F557D0")]
		private void PlayIconFloatAnimation()
		{
		}

		[Token(Token = "0x6002425")]
		[Address(RVA = "0x3F5588C", Offset = "0x3F5188C", VA = "0x3F5588C")]
		private void StopIconFloatAnimation()
		{
		}

		[Token(Token = "0x6002426")]
		[Address(RVA = "0x3F55950", Offset = "0x3F51950", VA = "0x3F55950", Slot = "13")]
		protected override void OnButtonExtendCloseClicked()
		{
		}

		[Token(Token = "0x6002427")]
		[Address(RVA = "0x3F559DC", Offset = "0x3F519DC", VA = "0x3F559DC", Slot = "12")]
		protected override void OnButtonBackgroundClicked()
		{
		}

		[Token(Token = "0x6002428")]
		[Address(RVA = "0x3F55A68", Offset = "0x3F51A68", VA = "0x3F55A68", Slot = "18")]
		protected override void OnButtonExtendUpgradeClicked()
		{
		}

		[Token(Token = "0x6002429")]
		[Address(RVA = "0x3F55E68", Offset = "0x3F51E68", VA = "0x3F55E68")]
		private static bool IsTraitUnlockLevel(int level)
		{
			return default;
		}

		[Token(Token = "0x600242A")]
		[Address(RVA = "0x3F56060", Offset = "0x3F52060", VA = "0x3F56060", Slot = "19")]
		protected override void OnButtonExtendEquipClicked()
		{
		}

		[Token(Token = "0x600242B")]
		[Address(RVA = "0x3F56150", Offset = "0x3F52150", VA = "0x3F56150", Slot = "14")]
		[AsyncStateMachine(typeof(_003COnButtonExtendStarUpgradeClicked_003Ed__18))]
		protected override void OnButtonExtendStarUpgradeClicked()
		{
		}

		[Token(Token = "0x600242C")]
		[Address(RVA = "0x3F55E90", Offset = "0x3F51E90", VA = "0x3F55E90")]
		private void ShowUpgradeEffect(RareLevel rareLevel)
		{
		}

		[Token(Token = "0x600242D")]
		[Address(RVA = "0x3F561DC", Offset = "0x3F521DC", VA = "0x3F561DC", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600242E")]
		[Address(RVA = "0x3F55D54", Offset = "0x3F51D54", VA = "0x3F55D54")]
		private bool TryRebindUserData()
		{
			return default;
		}

		[Token(Token = "0x600242F")]
		[Address(RVA = "0x3F56374", Offset = "0x3F52374", VA = "0x3F56374", Slot = "20")]
		protected override void OnButtonExtendGoGetBtnClicked()
		{
		}

		[Token(Token = "0x6002430")]
		[Address(RVA = "0x3F56448", Offset = "0x3F52448", VA = "0x3F56448")]
		private void RefreshAttrList()
		{
		}

		[Token(Token = "0x6002431")]
		[Address(RVA = "0x3F56B00", Offset = "0x3F52B00", VA = "0x3F56B00")]
		private void UpdatePower()
		{
		}

		[Token(Token = "0x6002432")]
		[Address(RVA = "0x3F56C64", Offset = "0x3F52C64", VA = "0x3F56C64")]
		public ArtifactDetailsPanel()
		{
		}
	}
}
