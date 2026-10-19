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
using SuperScrollView;
using TMPro;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x20007EC")]
	public class AllNewArtifactView : AllNewArtifactViewComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007EF")]
		[CompilerGenerated]
		private struct _003CAwake_003Ed__14 : IAsyncStateMachine
		{
			[Token(Token = "0x4003D12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003D13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003D14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AllNewArtifactView _003C_003E4__this;

			[Token(Token = "0x6002C58")]
			[Address(RVA = "0x3FFAA68", Offset = "0x3FF6A68", VA = "0x3FFAA68", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002C59")]
			[Address(RVA = "0x3FFABF0", Offset = "0x3FF6BF0", VA = "0x3FFABF0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007F0")]
		[CompilerGenerated]
		private struct _003COnButtonExtendArtifactIConClicked_003Ed__27 : IAsyncStateMachine
		{
			[Token(Token = "0x4003D15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003D16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003D17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AllNewArtifactView _003C_003E4__this;

			[Token(Token = "0x4003D18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002C5A")]
			[Address(RVA = "0x3FFABFC", Offset = "0x3FF6BFC", VA = "0x3FFABFC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002C5B")]
			[Address(RVA = "0x3FFAFA8", Offset = "0x3FF6FA8", VA = "0x3FFAFA8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007F1")]
		[CompilerGenerated]
		private struct _003COnButtonExtendStarupgradeButtonClicked_003Ed__29 : IAsyncStateMachine
		{
			[Token(Token = "0x4003D19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003D1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003D1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AllNewArtifactView _003C_003E4__this;

			[Token(Token = "0x4003D1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002C5C")]
			[Address(RVA = "0x3FFAFB4", Offset = "0x3FF6FB4", VA = "0x3FFAFB4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002C5D")]
			[Address(RVA = "0x3FFB358", Offset = "0x3FF7358", VA = "0x3FFB358", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007F2")]
		[CompilerGenerated]
		private struct _003CRefreshArtifactList_003Ed__22 : IAsyncStateMachine
		{
			[Token(Token = "0x4003D1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003D1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003D1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AllNewArtifactView _003C_003E4__this;

			[Token(Token = "0x4003D20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool resetScrollPosition;

			[Token(Token = "0x6002C5E")]
			[Address(RVA = "0x3FFB364", Offset = "0x3FF7364", VA = "0x3FFB364", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002C5F")]
			[Address(RVA = "0x3FFBA48", Offset = "0x3FF7A48", VA = "0x3FFBA48", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007F3")]
		[CompilerGenerated]
		private struct _003CRefreshAttrContent_003Ed__34 : IAsyncStateMachine
		{
			[Token(Token = "0x4003D21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003D22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003D23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AllNewArtifactView _003C_003E4__this;

			[Token(Token = "0x4003D24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object _003C_003Eu__1;

			[Token(Token = "0x6002C60")]
			[Address(RVA = "0x3FFBA54", Offset = "0x3FF7A54", VA = "0x3FFBA54", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002C61")]
			[Address(RVA = "0x3FFC16C", Offset = "0x3FF816C", VA = "0x3FFC16C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007F4")]
		[CompilerGenerated]
		private struct _003CRefreshEquipArtifact_003Ed__19 : IAsyncStateMachine
		{
			[Token(Token = "0x4003D25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003D26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003D27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AllNewArtifactView _003C_003E4__this;

			[Token(Token = "0x4003D28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UserPropData _003CuserPropData_003E5__2;

			[Token(Token = "0x4003D29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private GlobalPropInfo _003Cinfo_003E5__3;

			[Token(Token = "0x4003D2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4003D2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6002C62")]
			[Address(RVA = "0x3FFC178", Offset = "0x3FF8178", VA = "0x3FFC178", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002C63")]
			[Address(RVA = "0x3FFD15C", Offset = "0x3FF915C", VA = "0x3FFD15C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007F5")]
		[CompilerGenerated]
		private struct _003CRefreshForgeList_003Ed__21 : IAsyncStateMachine
		{
			[Token(Token = "0x4003D2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003D2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003D2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UserPropData userPropData;

			[Token(Token = "0x4003D2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AllNewArtifactView _003C_003E4__this;

			[Token(Token = "0x4003D30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002C64")]
			[Address(RVA = "0x3FFD168", Offset = "0x3FF9168", VA = "0x3FFD168", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002C65")]
			[Address(RVA = "0x3FFDB90", Offset = "0x3FF9B90", VA = "0x3FFDB90", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007F6")]
		[CompilerGenerated]
		private struct _003CRefreshIconLightEffect_003Ed__24 : IAsyncStateMachine
		{
			[Token(Token = "0x4003D31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003D32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003D33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AllNewArtifactView _003C_003E4__this;

			[Token(Token = "0x4003D34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int rareLevel;

			[Token(Token = "0x4003D35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private SkeletonGraphic _003CspineGraphic_003E5__2;

			[Token(Token = "0x4003D36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<SkeletonDataAsset>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002C66")]
			[Address(RVA = "0x3FFDB9C", Offset = "0x3FF9B9C", VA = "0x3FFDB9C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002C67")]
			[Address(RVA = "0x3FFE1B0", Offset = "0x3FFA1B0", VA = "0x3FFE1B0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007F7")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__15 : IAsyncStateMachine
		{
			[Token(Token = "0x4003D37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003D38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003D39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AllNewArtifactView _003C_003E4__this;

			[Token(Token = "0x4003D3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x4003D3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002C68")]
			[Address(RVA = "0x3FFE1BC", Offset = "0x3FFA1BC", VA = "0x3FFE1BC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002C69")]
			[Address(RVA = "0x3FFE8F8", Offset = "0x3FFA8F8", VA = "0x3FFE8F8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007F8")]
		[CompilerGenerated]
		private struct _003CUpdateView_003Ed__18 : IAsyncStateMachine
		{
			[Token(Token = "0x4003D3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003D3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003D3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AllNewArtifactView _003C_003E4__this;

			[Token(Token = "0x4003D3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool resetScrollPosition;

			[Token(Token = "0x4003D40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002C6A")]
			[Address(RVA = "0x3FFE904", Offset = "0x3FFA904", VA = "0x3FFE904", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002C6B")]
			[Address(RVA = "0x3FFF0D8", Offset = "0x3FFB0D8", VA = "0x3FFF0D8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003CFE")]
		private const string ItemName = "NewArtifactItem";

		[Token(Token = "0x4003CFF")]
		private const float SwitchAnimDuration = 1f;

		[Token(Token = "0x4003D00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private List<UserPropData> _artifactDataList;

		[Token(Token = "0x4003D01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool _hasInitLoopView;

		[Token(Token = "0x4003D02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private UserPropData _equipUserPropData;

		[Token(Token = "0x4003D03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private string _lastEquipPropId;

		[Token(Token = "0x4003D04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private bool _playEquipSwitchAnim;

		[Token(Token = "0x4003D05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		private int _lastArtifactCount;

		[Token(Token = "0x4003D06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Tween _qualityFlickerTween;

		[Token(Token = "0x4003D07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Tween _iconFloatTween;

		[Token(Token = "0x4003D08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Tween _iconSwitchTween;

		[Token(Token = "0x4003D09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Vector2 _iconOriginAnchoredPos;

		[Token(Token = "0x4003D0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private bool _hasIconOriginAnchoredPos;

		[Token(Token = "0x4003D0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x169")]
		private bool _hasIconOriginForCurrentPlay;

		[Token(Token = "0x4003D0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private readonly Dictionary<PropManager.PropAttrType, TextMeshProUGUI> _attrTextDict;

		[Token(Token = "0x4003D0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private readonly Dictionary<PropManager.PropAttrType, PropAttrItem> _allAttrPanelItemsDict;

		[Token(Token = "0x6002C35")]
		[Address(RVA = "0x3FF8008", Offset = "0x3FF4008", VA = "0x3FF8008", Slot = "4")]
		[AsyncStateMachine(typeof(_003CAwake_003Ed__14))]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002C36")]
		[Address(RVA = "0x3FF8094", Offset = "0x3FF4094", VA = "0x3FF8094", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__15))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002C37")]
		[Address(RVA = "0x3FF8130", Offset = "0x3FF4130", VA = "0x3FF8130", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002C38")]
		[Address(RVA = "0x3FF85D0", Offset = "0x3FF45D0", VA = "0x3FF85D0")]
		private void EventUpdateView(object obj)
		{
		}

		[Token(Token = "0x6002C39")]
		[Address(RVA = "0x3FF85E8", Offset = "0x3FF45E8", VA = "0x3FF85E8")]
		[AsyncStateMachine(typeof(_003CUpdateView_003Ed__18))]
		private UniTask UpdateView(bool resetScrollPosition)
		{
			return default;
		}

		[Token(Token = "0x6002C3A")]
		[Address(RVA = "0x3FF868C", Offset = "0x3FF468C", VA = "0x3FF868C")]
		[AsyncStateMachine(typeof(_003CRefreshEquipArtifact_003Ed__19))]
		private UniTask RefreshEquipArtifact()
		{
			return default;
		}

		[Token(Token = "0x6002C3B")]
		[Address(RVA = "0x3FF8720", Offset = "0x3FF4720", VA = "0x3FF8720")]
		private void RefreshEquipUpgradeState(UserPropData userPropData)
		{
		}

		[Token(Token = "0x6002C3C")]
		[Address(RVA = "0x3FF89A0", Offset = "0x3FF49A0", VA = "0x3FF89A0")]
		[AsyncStateMachine(typeof(_003CRefreshForgeList_003Ed__21))]
		private UniTask RefreshForgeList(UserPropData userPropData)
		{
			return default;
		}

		[Token(Token = "0x6002C3D")]
		[Address(RVA = "0x3FF8A3C", Offset = "0x3FF4A3C", VA = "0x3FF8A3C")]
		[AsyncStateMachine(typeof(_003CRefreshArtifactList_003Ed__22))]
		private UniTask RefreshArtifactList(bool resetScrollPosition)
		{
			return default;
		}

		[Token(Token = "0x6002C3E")]
		[Address(RVA = "0x3FF8AD8", Offset = "0x3FF4AD8", VA = "0x3FF8AD8")]
		private LoopGridViewItem OnGetItem(LoopGridView gridView, int index, int row, int column)
		{
			return null;
		}

		[Token(Token = "0x6002C3F")]
		[Address(RVA = "0x3FF8CF0", Offset = "0x3FF4CF0", VA = "0x3FF8CF0")]
		[AsyncStateMachine(typeof(_003CRefreshIconLightEffect_003Ed__24))]
		private UniTask RefreshIconLightEffect(int rareLevel)
		{
			return default;
		}

		[Token(Token = "0x6002C40")]
		[Address(RVA = "0x3FF8D90", Offset = "0x3FF4D90", VA = "0x3FF8D90")]
		private void PlayEquipAnimations()
		{
		}

		[Token(Token = "0x6002C41")]
		[Address(RVA = "0x3FF83C0", Offset = "0x3FF43C0", VA = "0x3FF83C0")]
		private void StopEquipAnimations()
		{
		}

		[Token(Token = "0x6002C42")]
		[Address(RVA = "0x3FF90B0", Offset = "0x3FF50B0", VA = "0x3FF90B0", Slot = "12")]
		[AsyncStateMachine(typeof(_003COnButtonExtendArtifactIConClicked_003Ed__27))]
		protected override void OnButtonExtendArtifactIConClicked()
		{
		}

		[Token(Token = "0x6002C43")]
		[Address(RVA = "0x3FF913C", Offset = "0x3FF513C", VA = "0x3FF913C", Slot = "13")]
		protected override void OnButtonExtendSummonBtnClicked()
		{
		}

		[Token(Token = "0x6002C44")]
		[Address(RVA = "0x3FF91FC", Offset = "0x3FF51FC", VA = "0x3FF91FC", Slot = "14")]
		[AsyncStateMachine(typeof(_003COnButtonExtendStarupgradeButtonClicked_003Ed__29))]
		protected override void OnButtonExtendStarupgradeButtonClicked()
		{
		}

		[Token(Token = "0x6002C45")]
		[Address(RVA = "0x3FF9288", Offset = "0x3FF5288", VA = "0x3FF9288")]
		private void ShowHint(object obj)
		{
		}

		[Token(Token = "0x6002C46")]
		[Address(RVA = "0x3FF94B8", Offset = "0x3FF54B8", VA = "0x3FF94B8")]
		private void InitAttrTextDict()
		{
		}

		[Token(Token = "0x6002C47")]
		[Address(RVA = "0x3FFA348", Offset = "0x3FF6348", VA = "0x3FFA348")]
		[AsyncStateMachine(typeof(_003CRefreshAttrContent_003Ed__34))]
		private UniTask RefreshAttrContent()
		{
			return default;
		}

		[Token(Token = "0x6002C48")]
		[Address(RVA = "0x3FFA3D0", Offset = "0x3FF63D0", VA = "0x3FFA3D0", Slot = "15")]
		protected override void OnButtonExtendAllAttrBtnClicked()
		{
		}

		[Token(Token = "0x6002C49")]
		[Address(RVA = "0x3FFA53C", Offset = "0x3FF653C", VA = "0x3FFA53C", Slot = "17")]
		protected override void OnButtonAllAttrMaskClicked()
		{
		}

		[Token(Token = "0x6002C4A")]
		[Address(RVA = "0x3FFA5E0", Offset = "0x3FF65E0", VA = "0x3FFA5E0", Slot = "18")]
		protected override void OnButtonBtnCloseAllAttrPanelClicked()
		{
		}

		[Token(Token = "0x6002C4B")]
		[Address(RVA = "0x3FFA684", Offset = "0x3FF6684", VA = "0x3FFA684")]
		public AllNewArtifactView()
		{
		}
	}
}
