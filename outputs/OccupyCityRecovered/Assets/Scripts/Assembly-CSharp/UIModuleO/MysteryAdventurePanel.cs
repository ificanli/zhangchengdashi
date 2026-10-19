using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using GameModule;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using ljzs_lt;

namespace UIModuleO
{
	[Token(Token = "0x20009EB")]
	public class MysteryAdventurePanel : UIPanel
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009EE")]
		[CompilerGenerated]
		private struct _003CEnsureDailyTaskPanelAsync_003Ed__100 : IAsyncStateMachine
		{
			[Token(Token = "0x40049D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40049D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40049D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventurePanel _003C_003E4__this;

			[Token(Token = "0x40049D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x40049D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private GameObject _003Cinstance_003E5__2;

			[Token(Token = "0x40049DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x40049DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask.Awaiter _003C_003Eu__3;

			[Token(Token = "0x6003BC2")]
			[Address(RVA = "0x412C63C", Offset = "0x412863C", VA = "0x412C63C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003BC3")]
			[Address(RVA = "0x412D2E8", Offset = "0x41292E8", VA = "0x412D2E8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009EF")]
		[CompilerGenerated]
		private struct _003CEnsureDailyTaskPanelAsync_003Ed__102 : IAsyncStateMachine
		{
			[Token(Token = "0x40049DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40049DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40049DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MysteryAdventurePanel _003C_003E4__this;

			[Token(Token = "0x40049DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool showTaskPage;

			[Token(Token = "0x40049E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003BC4")]
			[Address(RVA = "0x412D2F4", Offset = "0x41292F4", VA = "0x412D2F4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003BC5")]
			[Address(RVA = "0x412D5FC", Offset = "0x41295FC", VA = "0x412D5FC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009F0")]
		[CompilerGenerated]
		private struct _003CEnsureDiceEffectAsync_003Ed__136 : IAsyncStateMachine
		{
			[Token(Token = "0x40049E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40049E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40049E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventurePanel _003C_003E4__this;

			[Token(Token = "0x40049E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Transform _003CrollButton_003E5__2;

			[Token(Token = "0x40049E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003BC6")]
			[Address(RVA = "0x412D608", Offset = "0x4129608", VA = "0x412D608", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003BC7")]
			[Address(RVA = "0x412DEB0", Offset = "0x4129EB0", VA = "0x412DEB0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009F1")]
		[CompilerGenerated]
		private struct _003CEnsureDiscountShopPanelAsync_003Ed__123 : IAsyncStateMachine
		{
			[Token(Token = "0x40049E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40049E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40049E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventurePanel _003C_003E4__this;

			[Token(Token = "0x40049E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x40049EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private RectTransform _003Cparent_003E5__2;

			[Token(Token = "0x40049EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x40049EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask.Awaiter _003C_003Eu__3;

			[Token(Token = "0x6003BC8")]
			[Address(RVA = "0x412DEBC", Offset = "0x4129EBC", VA = "0x412DEBC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003BC9")]
			[Address(RVA = "0x412EADC", Offset = "0x412AADC", VA = "0x412EADC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009F2")]
		[CompilerGenerated]
		private struct _003CEnsureInitializedAsync_003Ed__135 : IAsyncStateMachine
		{
			[Token(Token = "0x40049ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40049EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40049EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventurePanel _003C_003E4__this;

			[Token(Token = "0x40049F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x40049F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x40049F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<MysteryAdventureUiAssets>.Awaiter _003C_003Eu__3;

			[Token(Token = "0x6003BCA")]
			[Address(RVA = "0x412EAE8", Offset = "0x412AAE8", VA = "0x412EAE8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003BCB")]
			[Address(RVA = "0x412F6A4", Offset = "0x412B6A4", VA = "0x412F6A4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009F3")]
		[CompilerGenerated]
		private struct _003CEnsureLapRewardPopupLoadedAsync_003Ed__140 : IAsyncStateMachine
		{
			[Token(Token = "0x40049F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40049F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40049F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventurePanel _003C_003E4__this;

			[Token(Token = "0x40049F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x40049F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private RectTransform _003Cparent_003E5__2;

			[Token(Token = "0x40049F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private GameObject _003Cinstance_003E5__3;

			[Token(Token = "0x40049F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6003BCC")]
			[Address(RVA = "0x412F6B0", Offset = "0x412B6B0", VA = "0x412F6B0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003BCD")]
			[Address(RVA = "0x4130360", Offset = "0x412C360", VA = "0x4130360", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009F4")]
		[CompilerGenerated]
		private struct _003CEnsureRuinsPanelsAsync_003Ed__161 : IAsyncStateMachine
		{
			[Token(Token = "0x40049FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40049FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40049FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventurePanel _003C_003E4__this;

			[Token(Token = "0x40049FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x40049FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6003BCE")]
			[Address(RVA = "0x413036C", Offset = "0x412C36C", VA = "0x413036C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003BCF")]
			[Address(RVA = "0x4130B64", Offset = "0x412CB64", VA = "0x4130B64", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009F5")]
		[CompilerGenerated]
		private struct _003CEnsureRuinsRpsGameplayPanelAsync_003Ed__177 : IAsyncStateMachine
		{
			[Token(Token = "0x40049FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004A00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004A01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventurePanel _003C_003E4__this;

			[Token(Token = "0x4004A02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4004A03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6003BD0")]
			[Address(RVA = "0x4130B70", Offset = "0x412CB70", VA = "0x4130B70", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003BD1")]
			[Address(RVA = "0x41312F0", Offset = "0x412D2F0", VA = "0x41312F0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009F6")]
		[CompilerGenerated]
		private struct _003CEnsureRulesPanelAsync_003Ed__182 : IAsyncStateMachine
		{
			[Token(Token = "0x4004A04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004A05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004A06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventurePanel _003C_003E4__this;

			[Token(Token = "0x4004A07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool showBuildingTab;

			[Token(Token = "0x4004A08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003BD2")]
			[Address(RVA = "0x41312FC", Offset = "0x412D2FC", VA = "0x41312FC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003BD3")]
			[Address(RVA = "0x413177C", Offset = "0x412D77C", VA = "0x413177C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009F7")]
		[CompilerGenerated]
		private struct _003CEnsureRulesPanelLoadedAsync_003Ed__181 : IAsyncStateMachine
		{
			[Token(Token = "0x4004A09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004A0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004A0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventurePanel _003C_003E4__this;

			[Token(Token = "0x4004A0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4004A0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private GameObject _003Cinstance_003E5__2;

			[Token(Token = "0x4004A0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x4004A0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask.Awaiter _003C_003Eu__3;

			[Token(Token = "0x6003BD4")]
			[Address(RVA = "0x4131788", Offset = "0x412D788", VA = "0x4131788", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003BD5")]
			[Address(RVA = "0x4132244", Offset = "0x412E244", VA = "0x4132244", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009F8")]
		[CompilerGenerated]
		private struct _003CEnsureSideEntryRedDotSpriteAsync_003Ed__115 : IAsyncStateMachine
		{
			[Token(Token = "0x4004A10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004A11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004A12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameObject redDot;

			[Token(Token = "0x4004A13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Image _003Cimage_003E5__2;

			[Token(Token = "0x4004A14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003BD6")]
			[Address(RVA = "0x4132250", Offset = "0x412E250", VA = "0x4132250", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003BD7")]
			[Address(RVA = "0x41327A4", Offset = "0x412E7A4", VA = "0x41327A4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009F9")]
		[CompilerGenerated]
		private struct _003CExecuteRollAsync_003Ed__151 : IAsyncStateMachine
		{
			[Token(Token = "0x4004A15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004A16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

			[Token(Token = "0x4004A17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MysteryAdventurePanel _003C_003E4__this;

			[Token(Token = "0x4004A18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int rollFlowVersion;

			[Token(Token = "0x4004A19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private MysteryAdventureRollResult _003Cresult_003E5__2;

			[Token(Token = "0x4004A1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private MysteryAdventureManager _003Cmanager_003E5__3;

			[Token(Token = "0x4004A1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4004A1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private object _003C_003E7__wrap3;

			[Token(Token = "0x4004A1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private int _003C_003E7__wrap4;

			[Token(Token = "0x4004A1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			private bool _003C_003E7__wrap5;

			[Token(Token = "0x4004A1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float _003Cspeed_003E5__7;

			[Token(Token = "0x4004A20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private Vector3 _003CflyStartPos_003E5__8;

			[Token(Token = "0x4004A21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private List<MysteryAdventureMoveSegment> _003Csegments_003E5__9;

			[Token(Token = "0x4004A22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private int _003Ci_003E5__10;

			[Token(Token = "0x4004A23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private MysteryAdventureMoveSegment _003Csegment_003E5__11;

			[Token(Token = "0x4004A24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private MysteryAdventureLapRewardPopupData _003ClapPopupData_003E5__12;

			[Token(Token = "0x4004A25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private UniTask<bool>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6003BD8")]
			[Address(RVA = "0x41327B0", Offset = "0x412E7B0", VA = "0x41327B0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003BD9")]
			[Address(RVA = "0x4134F44", Offset = "0x4130F44", VA = "0x4134F44", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009FA")]
		[CompilerGenerated]
		private struct _003CGmShowDiscountShopAsync_003Ed__129 : IAsyncStateMachine
		{
			[Token(Token = "0x4004A26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004A27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004A28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventurePanel _003C_003E4__this;

			[Token(Token = "0x4004A29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003BDA")]
			[Address(RVA = "0x4136D9C", Offset = "0x4132D9C", VA = "0x4136D9C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003BDB")]
			[Address(RVA = "0x413718C", Offset = "0x413318C", VA = "0x413718C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009FB")]
		[CompilerGenerated]
		private struct _003CHandleAutoRollPendingInteractionAsync_003Ed__153 : IAsyncStateMachine
		{
			[Token(Token = "0x4004A2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004A2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004A2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventurePanel _003C_003E4__this;

			[Token(Token = "0x4004A2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003BDC")]
			[Address(RVA = "0x4137198", Offset = "0x4133198", VA = "0x4137198", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003BDD")]
			[Address(RVA = "0x4137A4C", Offset = "0x4133A4C", VA = "0x4137A4C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009FC")]
		[CompilerGenerated]
		private struct _003CHandleAutoRollRewardPanelAsync_003Ed__154 : IAsyncStateMachine
		{
			[Token(Token = "0x4004A2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004A2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004A30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventurePanel _003C_003E4__this;

			[Token(Token = "0x4004A31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003BDE")]
			[Address(RVA = "0x4137A58", Offset = "0x4133A58", VA = "0x4137A58", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003BDF")]
			[Address(RVA = "0x4137E9C", Offset = "0x4133E9C", VA = "0x4137E9C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009FD")]
		[CompilerGenerated]
		private struct _003CHandleInsufficientDiceAsync_003Ed__110 : IAsyncStateMachine
		{
			[Token(Token = "0x4004A32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004A33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004A34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventurePanel _003C_003E4__this;

			[Token(Token = "0x4004A35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003BE0")]
			[Address(RVA = "0x4137EA8", Offset = "0x4133EA8", VA = "0x4137EA8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003BE1")]
			[Address(RVA = "0x413833C", Offset = "0x413433C", VA = "0x413833C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009FE")]
		[CompilerGenerated]
		private struct _003CHideDiscountShopPanelAsync_003Ed__126 : IAsyncStateMachine
		{
			[Token(Token = "0x4004A36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004A37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004A38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventurePanel _003C_003E4__this;

			[Token(Token = "0x4004A39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003BE2")]
			[Address(RVA = "0x4138348", Offset = "0x4134348", VA = "0x4138348", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003BE3")]
			[Address(RVA = "0x4138898", Offset = "0x4134898", VA = "0x4138898", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009FF")]
		[CompilerGenerated]
		private struct _003CLoadRuinsPanelAsync_003Ed__162<T> : IAsyncStateMachine where T : Component
		{
			[Token(Token = "0x4004A3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004A3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004A3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> assignPanel;

			[Token(Token = "0x4004A3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<GameObject> assignInstance;

			[Token(Token = "0x4004A3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string prefabPath;

			[Token(Token = "0x4004A3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RectTransform parent;

			[Token(Token = "0x4004A40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<T> buildFallback;

			[Token(Token = "0x4004A41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private GameObject _003Cprefab_003E5__2;

			[Token(Token = "0x4004A42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003BE4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003BE5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A00")]
		[CompilerGenerated]
		private struct _003COnRollClickedAsync_003Ed__150 : IAsyncStateMachine
		{
			[Token(Token = "0x4004A43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004A44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004A45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MysteryAdventurePanel _003C_003E4__this;

			[Token(Token = "0x4004A46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private UniTask<bool>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003BE6")]
			[Address(RVA = "0x41388A4", Offset = "0x41348A4", VA = "0x41388A4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003BE7")]
			[Address(RVA = "0x4138AFC", Offset = "0x4134AFC", VA = "0x4138AFC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A01")]
		[CompilerGenerated]
		private struct _003CPlayRuinsBlackHoleMoveAndSettleAsync_003Ed__171 : IAsyncStateMachine
		{
			[Token(Token = "0x4004A47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004A48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004A49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventurePanel _003C_003E4__this;

			[Token(Token = "0x4004A4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private MysteryAdventureManager _003Cmanager_003E5__2;

			[Token(Token = "0x4004A4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object _003C_003E7__wrap2;

			[Token(Token = "0x4004A4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int _003C_003E7__wrap3;

			[Token(Token = "0x4004A4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private List<MysteryAdventureMoveSegment> _003Csegments_003E5__5;

			[Token(Token = "0x4004A4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int _003CtoCellId_003E5__6;

			[Token(Token = "0x4004A4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float _003Cspeed_003E5__7;

			[Token(Token = "0x4004A50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 _003CflyStartPos_003E5__8;

			[Token(Token = "0x4004A51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4004A52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private int _003Ci_003E5__9;

			[Token(Token = "0x4004A53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private MysteryAdventureMoveSegment _003Csegment_003E5__10;

			[Token(Token = "0x4004A54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private MysteryAdventureLapRewardPopupData _003ClapPopupData_003E5__11;

			[Token(Token = "0x6003BE8")]
			[Address(RVA = "0x4138B08", Offset = "0x4134B08", VA = "0x4138B08", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003BE9")]
			[Address(RVA = "0x413A898", Offset = "0x4136898", VA = "0x413A898", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A02")]
		[CompilerGenerated]
		private struct _003CPlayRuinsDiceRewardPanelAsync_003Ed__170 : IAsyncStateMachine
		{
			[Token(Token = "0x4004A55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004A56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004A57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventurePanel _003C_003E4__this;

			[Token(Token = "0x4004A58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int diceGrant;

			[Token(Token = "0x4004A59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003BEA")]
			[Address(RVA = "0x413A8A4", Offset = "0x41368A4", VA = "0x413A8A4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003BEB")]
			[Address(RVA = "0x413AD74", Offset = "0x4136D74", VA = "0x413AD74", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A03")]
		[CompilerGenerated]
		private struct _003CPlayRuinsRpsAndResolveAsync_003Ed__172 : IAsyncStateMachine
		{
			[Token(Token = "0x4004A5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004A5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004A5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventurePanel _003C_003E4__this;

			[Token(Token = "0x4004A5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int playerChoiceIndex;

			[Token(Token = "0x4004A5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4004A5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<MysteryAdventureRpsOutcome>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6003BEC")]
			[Address(RVA = "0x413AD80", Offset = "0x4136D80", VA = "0x413AD80", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003BED")]
			[Address(RVA = "0x413B75C", Offset = "0x413775C", VA = "0x413B75C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A04")]
		[CompilerGenerated]
		private struct _003CRefreshDailyGiftPageAsync_003Ed__117 : IAsyncStateMachine
		{
			[Token(Token = "0x4004A60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004A61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004A62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MysteryAdventurePanel _003C_003E4__this;

			[Token(Token = "0x4004A63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003BEE")]
			[Address(RVA = "0x413B768", Offset = "0x4137768", VA = "0x413B768", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003BEF")]
			[Address(RVA = "0x413BAC0", Offset = "0x4137AC0", VA = "0x413BAC0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A05")]
		[CompilerGenerated]
		private struct _003CRestoreRuinsBanditPanelIfNeededAsync_003Ed__160 : IAsyncStateMachine
		{
			[Token(Token = "0x4004A64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004A65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004A66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventurePanel _003C_003E4__this;

			[Token(Token = "0x4004A67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private RuinsConfigConfig _003Cconfig_003E5__2;

			[Token(Token = "0x4004A68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003BF0")]
			[Address(RVA = "0x413BACC", Offset = "0x4137ACC", VA = "0x413BACC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003BF1")]
			[Address(RVA = "0x413C364", Offset = "0x4138364", VA = "0x413C364", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A06")]
		[CompilerGenerated]
		private struct _003CRunAutoRollLoopAsync_003Ed__148 : IAsyncStateMachine
		{
			[Token(Token = "0x4004A69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004A6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004A6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MysteryAdventurePanel _003C_003E4__this;

			[Token(Token = "0x4004A6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int rollFlowVersion;

			[Token(Token = "0x4004A6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private bool _003CstoppedByDiceExhausted_003E5__2;

			[Token(Token = "0x4004A6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<bool>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4004A6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6003BF2")]
			[Address(RVA = "0x413C370", Offset = "0x4138370", VA = "0x413C370", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003BF3")]
			[Address(RVA = "0x413CB28", Offset = "0x4138B28", VA = "0x413CB28", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A07")]
		[CompilerGenerated]
		private struct _003CRunRuinsOptionSelectedAsync_003Ed__167 : IAsyncStateMachine
		{
			[Token(Token = "0x4004A70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004A71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004A72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventurePanel _003C_003E4__this;

			[Token(Token = "0x4004A73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int optionIndex;

			[Token(Token = "0x4004A74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003BF4")]
			[Address(RVA = "0x413CB34", Offset = "0x4138B34", VA = "0x413CB34", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003BF5")]
			[Address(RVA = "0x413D5C4", Offset = "0x41395C4", VA = "0x413D5C4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A08")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__72 : IAsyncStateMachine
		{
			[Token(Token = "0x4004A75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004A76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004A77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventurePanel _003C_003E4__this;

			[Token(Token = "0x4004A78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x4004A79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003BF6")]
			[Address(RVA = "0x413D5D0", Offset = "0x41395D0", VA = "0x413D5D0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003BF7")]
			[Address(RVA = "0x413DDF4", Offset = "0x4139DF4", VA = "0x413DDF4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A09")]
		[CompilerGenerated]
		private struct _003CShowDiscountShopPanelAsync_003Ed__124 : IAsyncStateMachine
		{
			[Token(Token = "0x4004A7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004A7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004A7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventurePanel _003C_003E4__this;

			[Token(Token = "0x4004A7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003BF8")]
			[Address(RVA = "0x413DE00", Offset = "0x4139E00", VA = "0x413DE00", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003BF9")]
			[Address(RVA = "0x413E608", Offset = "0x413A608", VA = "0x413E608", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A0A")]
		[CompilerGenerated]
		private struct _003CShowLapRewardPopupAndWaitAsync_003Ed__141 : IAsyncStateMachine
		{
			[Token(Token = "0x4004A7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004A7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004A80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventureLapRewardPopupData data;

			[Token(Token = "0x4004A81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MysteryAdventurePanel _003C_003E4__this;

			[Token(Token = "0x4004A82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTaskCompletionSource _003CcloseTcs_003E5__2;

			[Token(Token = "0x4004A83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float _003CanimationSpeed_003E5__3;

			[Token(Token = "0x4004A84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4004A85")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<int>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6003BFA")]
			[Address(RVA = "0x413E614", Offset = "0x413A614", VA = "0x413E614", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003BFB")]
			[Address(RVA = "0x413F66C", Offset = "0x413B66C", VA = "0x413F66C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A0B")]
		[CompilerGenerated]
		private struct _003CShowRuinsEventPanelAsync_003Ed__163 : IAsyncStateMachine
		{
			[Token(Token = "0x4004A86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004A87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004A88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventurePanel _003C_003E4__this;

			[Token(Token = "0x4004A89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private RuinsConfigConfig _003Cconfig_003E5__2;

			[Token(Token = "0x4004A8A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4004A8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6003BFC")]
			[Address(RVA = "0x413F678", Offset = "0x413B678", VA = "0x413F678", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003BFD")]
			[Address(RVA = "0x413FF98", Offset = "0x413BF98", VA = "0x413FF98", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A0C")]
		[CompilerGenerated]
		private struct _003CShowTokenResourceRewardTipAsync_003Ed__35 : IAsyncStateMachine
		{
			[Token(Token = "0x4004A8C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004A8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004A8E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventurePanel _003C_003E4__this;

			[Token(Token = "0x4004A8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string assetId;

			[Token(Token = "0x4004A90")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int count;

			[Token(Token = "0x4004A91")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003BFE")]
			[Address(RVA = "0x413FFA4", Offset = "0x413BFA4", VA = "0x413FFA4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003BFF")]
			[Address(RVA = "0x4140600", Offset = "0x413C600", VA = "0x4140600", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A0D")]
		[CompilerGenerated]
		private struct _003CStartRuinsBanditBattleAsync_003Ed__168 : IAsyncStateMachine
		{
			[Token(Token = "0x4004A92")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004A93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004A94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventurePanel _003C_003E4__this;

			[Token(Token = "0x4004A95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003C00")]
			[Address(RVA = "0x414060C", Offset = "0x413C60C", VA = "0x414060C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003C01")]
			[Address(RVA = "0x4140BC8", Offset = "0x413CBC8", VA = "0x4140BC8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A0E")]
		[CompilerGenerated]
		private struct _003CTryRefreshForcedMoveCellEffectAsync_003Ed__25 : IAsyncStateMachine
		{
			[Token(Token = "0x4004A96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004A97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004A98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventureMoveSegment segment;

			[Token(Token = "0x4004A99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MysteryAdventurePanel _003C_003E4__this;

			[Token(Token = "0x4004A9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003C02")]
			[Address(RVA = "0x4140BD4", Offset = "0x413CBD4", VA = "0x4140BD4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003C03")]
			[Address(RVA = "0x414106C", Offset = "0x413D06C", VA = "0x414106C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A0F")]
		[CompilerGenerated]
		private struct _003CTryShowPendingRuinsInteractionAsync_003Ed__152 : IAsyncStateMachine
		{
			[Token(Token = "0x4004A9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004A9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

			[Token(Token = "0x4004A9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MysteryAdventureRollResult result;

			[Token(Token = "0x4004A9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MysteryAdventurePanel _003C_003E4__this;

			[Token(Token = "0x4004A9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003C04")]
			[Address(RVA = "0x4141078", Offset = "0x413D078", VA = "0x4141078", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003C05")]
			[Address(RVA = "0x414174C", Offset = "0x413D74C", VA = "0x414174C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A10")]
		[CompilerGenerated]
		private struct _003CWaitBeforeLapRewardPopupAsync_003Ed__33 : IAsyncStateMachine
		{
			[Token(Token = "0x4004AA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004AA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004AA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventurePanel _003C_003E4__this;

			[Token(Token = "0x4004AA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MysteryAdventureMoveSegment segment;

			[Token(Token = "0x4004AA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int _003ClapExp_003E5__2;

			[Token(Token = "0x4004AA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private MysteryAdventurePanelEffectView _003Ceffect_003E5__3;

			[Token(Token = "0x4004AA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool _003ChasLevelUp_003E5__4;

			[Token(Token = "0x4004AA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
			private bool _003ClapIncreased_003E5__5;

			[Token(Token = "0x4004AA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private CancellationToken _003CcancellationToken_003E5__6;

			[Token(Token = "0x4004AA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003C06")]
			[Address(RVA = "0x41417A4", Offset = "0x413D7A4", VA = "0x41417A4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003C07")]
			[Address(RVA = "0x4142498", Offset = "0x413E498", VA = "0x4142498", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40049AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string _cachedLapDisplayText;

		[Token(Token = "0x40049AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private MysteryAdventurePanelView _view;

		[Token(Token = "0x40049AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private MysteryAdventureBoardView _boardView;

		[Token(Token = "0x40049AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MysteryAdventureTotalDiceTrackView _totalDiceTrackView;

		[Token(Token = "0x40049AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MysteryAdventureDailyTaskPanelView _dailyTaskPanelView;

		[Token(Token = "0x40049B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _dailyTaskPanelLoading;

		[Token(Token = "0x40049B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private MysteryAdventureRulesPanelView _rulesPanelView;

		[Token(Token = "0x40049B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool _rulesPanelLoading;

		[Token(Token = "0x40049B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private MysteryAdventureDiscountShopPanelView _discountShopPanelView;

		[Token(Token = "0x40049B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private GameObject _discountShopPanelInstance;

		[Token(Token = "0x40049B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool _discountShopPanelLoading;

		[Token(Token = "0x40049B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private MysteryAdventureRuinsPanel _ruinsEventPanel;

		[Token(Token = "0x40049B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private GameObject _ruinsEventPanelInstance;

		[Token(Token = "0x40049B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool _ruinsPanelLoading;

		[Token(Token = "0x40049B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private MysteryAdventureRuinsRpsGameplayPanel _ruinsRpsGameplayPanel;

		[Token(Token = "0x40049BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private GameObject _ruinsRpsGameplayPanelInstance;

		[Token(Token = "0x40049BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool _ruinsRpsPanelLoading;

		[Token(Token = "0x40049BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private RuinsConfigConfig _activeRuinsConfig;

		[Token(Token = "0x40049BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private MysteryAdventureUiAssets _uiAssets;

		[Token(Token = "0x40049BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float _refreshTimer;

		[Token(Token = "0x40049BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private bool _isRollingUi;

		[Token(Token = "0x40049C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDD")]
		private bool _isAutoRolling;

		[Token(Token = "0x40049C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDE")]
		private bool _autoRollPreferred;

		[Token(Token = "0x40049C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDF")]
		private bool _autoRollSessionActive;

		[Token(Token = "0x40049C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private string _autoRollDiceExhaustedStatusPending;

		[Token(Token = "0x40049C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int _rollFlowVersion;

		[Token(Token = "0x40049C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private bool _suppressToggleCallback;

		[Token(Token = "0x40049C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xED")]
		private bool _initialized;

		[Token(Token = "0x40049C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEE")]
		private bool _initializing;

		[Token(Token = "0x40049C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private int _displayedLapExp;

		[Token(Token = "0x40049C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private int _lastSyncedDiceCount;

		[Token(Token = "0x40049CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private int _lastLapLevel;

		[Token(Token = "0x40049CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private int _lastLapExpForEffect;

		[Token(Token = "0x40049CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private string _pendingInteractionStatusText;

		[Token(Token = "0x40049CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private GameObject _sideDailyTaskRedDot;

		[Token(Token = "0x40049CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private GameObject _sideDailyGiftRedDot;

		[Token(Token = "0x40049CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private MysteryAdventureLapRewardPopupView _lapRewardPopupView;

		[Token(Token = "0x40049D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private bool _lapRewardPopupLoading;

		[Token(Token = "0x40049D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private UniTaskCompletionSource _lapRewardPopupCloseTcs;

		[Token(Token = "0x40049D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private bool _tenRollPreferred;

		[Token(Token = "0x6003B14")]
		[Address(RVA = "0x41245A0", Offset = "0x41205A0", VA = "0x41245A0")]
		private void BindToggleEvents()
		{
		}

		[Token(Token = "0x6003B15")]
		[Address(RVA = "0x4124968", Offset = "0x4120968", VA = "0x4124968")]
		private void RestoreToggleStates()
		{
		}

		[Token(Token = "0x6003B16")]
		[Address(RVA = "0x4124C68", Offset = "0x4120C68", VA = "0x4124C68")]
		private void OnAutoRollToggleChanged(bool isOn)
		{
		}

		[Token(Token = "0x6003B17")]
		[Address(RVA = "0x4124E48", Offset = "0x4120E48", VA = "0x4124E48")]
		private void SyncAutoRollWithDiceState()
		{
		}

		[Token(Token = "0x6003B18")]
		[Address(RVA = "0x4124FA0", Offset = "0x4120FA0", VA = "0x4124FA0")]
		private bool CanResumeAutoRollAfterBlock()
		{
			return default;
		}

		[Token(Token = "0x6003B19")]
		[Address(RVA = "0x41251F8", Offset = "0x41211F8", VA = "0x41251F8")]
		private bool ShouldRetryAutoRollAfterFailedExecute()
		{
			return default;
		}

		[Token(Token = "0x6003B1A")]
		[Address(RVA = "0x41251EC", Offset = "0x41211EC", VA = "0x41251EC")]
		private void EndAutoRollSessionKeepToggle()
		{
		}

		[Token(Token = "0x6003B1B")]
		[Address(RVA = "0x4125180", Offset = "0x4121180", VA = "0x4125180")]
		private void EndAutoRollDueToDiceExhausted()
		{
		}

		[Token(Token = "0x6003B1C")]
		[Address(RVA = "0x41253F0", Offset = "0x41213F0", VA = "0x41253F0")]
		private void OnSkipAnimToggleChanged(bool isOn)
		{
		}

		[Token(Token = "0x6003B1D")]
		[Address(RVA = "0x412543C", Offset = "0x412143C", VA = "0x412543C")]
		private bool IsSkipAnimEnabled()
		{
			return default;
		}

		[Token(Token = "0x6003B1E")]
		[Address(RVA = "0x41254DC", Offset = "0x41214DC", VA = "0x41254DC")]
		private float GetAnimationSpeedMultiplier()
		{
			return default;
		}

		[Token(Token = "0x6003B1F")]
		[Address(RVA = "0x41254F4", Offset = "0x41214F4", VA = "0x41254F4")]
		private bool ShouldAutoCloseLapRewardPopup()
		{
			return default;
		}

		[Token(Token = "0x6003B20")]
		[Address(RVA = "0x4125524", Offset = "0x4121524", VA = "0x4125524")]
		private float GetLapRewardPopupAutoCloseSeconds()
		{
			return default;
		}

		[Token(Token = "0x6003B21")]
		[Address(RVA = "0x412554C", Offset = "0x412154C", VA = "0x412554C")]
		private bool IsAutoRollEnabled()
		{
			return default;
		}

		[Token(Token = "0x6003B22")]
		[Address(RVA = "0x4125554", Offset = "0x4121554", VA = "0x4125554")]
		private void StopAutoRollByUserInteraction()
		{
		}

		[Token(Token = "0x6003B23")]
		[Address(RVA = "0x41255D4", Offset = "0x41215D4", VA = "0x41255D4")]
		private void TryHandleAutoRollScreenStop()
		{
		}

		[Token(Token = "0x6003B24")]
		[Address(RVA = "0x4125600", Offset = "0x4121600", VA = "0x4125600")]
		private static bool WasScreenPointerPressedThisFrame()
		{
			return default;
		}

		[Token(Token = "0x6003B25")]
		[Address(RVA = "0x4125688", Offset = "0x4121688", VA = "0x4125688")]
		private void EnsurePanelEffectReference()
		{
		}

		[Token(Token = "0x6003B26")]
		[Address(RVA = "0x4125790", Offset = "0x4121790", VA = "0x4125790")]
		private void EnsurePanelEffectInitialized()
		{
		}

		[Token(Token = "0x6003B27")]
		[Address(RVA = "0x41257C4", Offset = "0x41217C4", VA = "0x41257C4")]
		private void RefreshPanelEffects()
		{
		}

		[Token(Token = "0x6003B28")]
		[Address(RVA = "0x41258BC", Offset = "0x41218BC", VA = "0x41258BC")]
		private void RefreshLapProgressEffects(int lapExp)
		{
		}

		[Token(Token = "0x6003B29")]
		[Address(RVA = "0x41259A4", Offset = "0x41219A4", VA = "0x41259A4")]
		private bool ShouldDeferBoardEffectRefresh()
		{
			return default;
		}

		[Token(Token = "0x6003B2A")]
		[Address(RVA = "0x41259D4", Offset = "0x41219D4", VA = "0x41259D4")]
		private void RefreshBoardCellEffects()
		{
		}

		[Token(Token = "0x6003B2B")]
		[Address(RVA = "0x4125A74", Offset = "0x4121A74", VA = "0x4125A74")]
		private void HideBoardCellEffects()
		{
		}

		[Token(Token = "0x6003B2C")]
		[Address(RVA = "0x4125A90", Offset = "0x4121A90", VA = "0x4125A90")]
		private void RefreshBoardCellEffectsForLanding(int landingCellId)
		{
		}

		[Token(Token = "0x6003B2D")]
		[Address(RVA = "0x4125AB4", Offset = "0x4121AB4", VA = "0x4125AB4")]
		[AsyncStateMachine(typeof(_003CTryRefreshForcedMoveCellEffectAsync_003Ed__25))]
		private UniTask TryRefreshForcedMoveCellEffectAsync(MysteryAdventureMoveSegment segment)
		{
			return default;
		}

		[Token(Token = "0x6003B2E")]
		[Address(RVA = "0x4125B5C", Offset = "0x4121B5C", VA = "0x4125B5C")]
		private void RefreshLandingEffectsAfterMove()
		{
		}

		[Token(Token = "0x6003B2F")]
		[Address(RVA = "0x4125BD8", Offset = "0x4121BD8", VA = "0x4125BD8")]
		private void RefreshBoardView(bool refreshLapProgress = true)
		{
		}

		[Token(Token = "0x6003B30")]
		[Address(RVA = "0x4125C78", Offset = "0x4121C78", VA = "0x4125C78")]
		private bool ShouldDeferLapProgressRefresh()
		{
			return default;
		}

		[Token(Token = "0x6003B31")]
		[Address(RVA = "0x4125CA8", Offset = "0x4121CA8", VA = "0x4125CA8")]
		private void ApplyLapProgressDisplay(int lapExp, bool refreshLapEffects = true)
		{
		}

		[Token(Token = "0x6003B32")]
		[Address(RVA = "0x4125E9C", Offset = "0x4121E9C", VA = "0x4125E9C")]
		private void OnLapProgressReachedStart()
		{
		}

		[Token(Token = "0x6003B33")]
		[Address(RVA = "0x4125B60", Offset = "0x4121B60", VA = "0x4125B60")]
		private void RefreshLapProgressEffectsAfterLanding()
		{
		}

		[Token(Token = "0x6003B34")]
		[Address(RVA = "0x4125F30", Offset = "0x4121F30", VA = "0x4125F30")]
		[AsyncStateMachine(typeof(_003CWaitBeforeLapRewardPopupAsync_003Ed__33))]
		private UniTask WaitBeforeLapRewardPopupAsync(MysteryAdventureMoveSegment segment)
		{
			return default;
		}

		[Token(Token = "0x6003B35")]
		[Address(RVA = "0x4125FDC", Offset = "0x4121FDC", VA = "0x4125FDC")]
		private void SyncLapEffectTracking(int lapExp)
		{
		}

		[Token(Token = "0x6003B36")]
		[Address(RVA = "0x4126018", Offset = "0x4122018", VA = "0x4126018")]
		[AsyncStateMachine(typeof(_003CShowTokenResourceRewardTipAsync_003Ed__35))]
		public UniTask ShowTokenResourceRewardTipAsync(string assetId, int count)
		{
			return default;
		}

		[Token(Token = "0x6003B37")]
		[Address(RVA = "0x41260C4", Offset = "0x41220C4", VA = "0x41260C4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6003B38")]
		[Address(RVA = "0x4126218", Offset = "0x4122218", VA = "0x4126218", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__72))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003B39")]
		[Address(RVA = "0x41262C0", Offset = "0x41222C0", VA = "0x41262C0")]
		private static string ResolveEnterWay(object[] args)
		{
			return null;
		}

		[Token(Token = "0x6003B3A")]
		[Address(RVA = "0x4126358", Offset = "0x4122358", VA = "0x4126358", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6003B3B")]
		[Address(RVA = "0x41265B0", Offset = "0x41225B0", VA = "0x41265B0")]
		private void ResetRollFlowState()
		{
		}

		[Token(Token = "0x6003B3C")]
		[Address(RVA = "0x4126800", Offset = "0x4122800", VA = "0x4126800")]
		private bool IsRollFlowCurrent(int rollFlowVersion)
		{
			return default;
		}

		[Token(Token = "0x6003B3D")]
		[Address(RVA = "0x412681C", Offset = "0x412281C", VA = "0x412681C")]
		private bool IsAdventureBusyForNavigation()
		{
			return default;
		}

		[Token(Token = "0x6003B3E")]
		[Address(RVA = "0x412685C", Offset = "0x412285C", VA = "0x412685C")]
		private bool TryBlockAdventureNavigation()
		{
			return default;
		}

		[Token(Token = "0x6003B3F")]
		[Address(RVA = "0x41268DC", Offset = "0x41228DC", VA = "0x41268DC")]
		public static bool TryBlockResourceBarNavigation()
		{
			return default;
		}

		[Token(Token = "0x6003B40")]
		[Address(RVA = "0x4126A04", Offset = "0x4122A04", VA = "0x4126A04")]
		private void BindPanelButtons()
		{
		}

		[Token(Token = "0x6003B41")]
		[Address(RVA = "0x4126DA4", Offset = "0x4122DA4", VA = "0x4126DA4")]
		private static void ConfigureRollButtonRaycast(MysteryAdventurePanelView view)
		{
		}

		[Token(Token = "0x6003B42")]
		[Address(RVA = "0x4127288", Offset = "0x4123288", VA = "0x4127288")]
		private void ApplyMvpUiState()
		{
		}

		[Token(Token = "0x6003B43")]
		[Address(RVA = "0x4127470", Offset = "0x4123470", VA = "0x4127470")]
		private void SetupDiceEffectPresentation()
		{
		}

		[Token(Token = "0x6003B44")]
		[Address(RVA = "0x41275A0", Offset = "0x41235A0", VA = "0x41275A0")]
		private static void SetRollDiceIconVisible(MysteryAdventurePanelView view, bool visible)
		{
		}

		[Token(Token = "0x6003B45")]
		[Address(RVA = "0x4127344", Offset = "0x4123344", VA = "0x4127344")]
		private static void RestoreSideEntryUi(Image icon, TextMeshProUGUI label)
		{
		}

		[Token(Token = "0x6003B46")]
		[Address(RVA = "0x4126F98", Offset = "0x4122F98", VA = "0x4126F98")]
		private static void BindSideEntry(Image icon, UnityAction onClick)
		{
		}

		[Token(Token = "0x6003B47")]
		[Address(RVA = "0x412767C", Offset = "0x412367C", VA = "0x412767C")]
		private void Update()
		{
		}

		[Token(Token = "0x6003B48")]
		[Address(RVA = "0x41276E4", Offset = "0x41236E4", VA = "0x41276E4")]
		private void UpdateTimeSensitiveUi()
		{
		}

		[Token(Token = "0x6003B49")]
		[Address(RVA = "0x4128044", Offset = "0x4124044", VA = "0x4128044", Slot = "9")]
		public override void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x6003B4A")]
		[Address(RVA = "0x412804C", Offset = "0x412404C", VA = "0x412804C")]
		internal void RefreshUi(MysteryAdventurePanelRefreshScope scope)
		{
		}

		[Token(Token = "0x6003B4B")]
		[Address(RVA = "0x4127A04", Offset = "0x4123A04", VA = "0x4127A04")]
		private void ApplyDiceCountFooterText(int diceCount)
		{
		}

		[Token(Token = "0x6003B4C")]
		[Address(RVA = "0x4127B4C", Offset = "0x4123B4C", VA = "0x4127B4C")]
		private void SyncDiceCountResourceUi(int diceCount)
		{
		}

		[Token(Token = "0x6003B4D")]
		[Address(RVA = "0x4127BDC", Offset = "0x4123BDC", VA = "0x4127BDC")]
		private void ApplyRecoverCountdownText(MysteryAdventureManager manager)
		{
		}

		[Token(Token = "0x6003B4E")]
		[Address(RVA = "0x4127E24", Offset = "0x4123E24", VA = "0x4127E24")]
		private void RefreshAdventureStatusText(bool isActive, PlayerMysteryAdventureData data, MysteryAdventureManager manager)
		{
		}

		[Token(Token = "0x6003B4F")]
		[Address(RVA = "0x4124E24", Offset = "0x4120E24", VA = "0x4124E24")]
		private void SyncAutoRollRingEffect()
		{
		}

		[Token(Token = "0x6003B50")]
		[Address(RVA = "0x4128440", Offset = "0x4124440", VA = "0x4128440")]
		private void UpdateTotalDiceTrackUi(PlayerMysteryAdventureData data)
		{
		}

		[Token(Token = "0x6003B51")]
		[Address(RVA = "0x412675C", Offset = "0x412275C", VA = "0x412675C")]
		private void SetRollButtonInteractable(bool interactable)
		{
		}

		[Token(Token = "0x6003B52")]
		[Address(RVA = "0x4128960", Offset = "0x4124960", VA = "0x4128960")]
		private void OnCloseClicked()
		{
		}

		[Token(Token = "0x6003B53")]
		[Address(RVA = "0x4128A14", Offset = "0x4124A14", VA = "0x4128A14")]
		private void OnRulesClicked()
		{
		}

		[Token(Token = "0x6003B54")]
		[Address(RVA = "0x4128AD0", Offset = "0x4124AD0", VA = "0x4128AD0")]
		[AsyncStateMachine(typeof(_003CEnsureDailyTaskPanelAsync_003Ed__100))]
		private UniTask EnsureDailyTaskPanelAsync()
		{
			return default;
		}

		[Token(Token = "0x6003B55")]
		[Address(RVA = "0x412660C", Offset = "0x412260C", VA = "0x412660C")]
		private void HideDailyTaskPanel()
		{
		}

		[Token(Token = "0x6003B56")]
		[Address(RVA = "0x4128B64", Offset = "0x4124B64", VA = "0x4128B64")]
		[AsyncStateMachine(typeof(_003CEnsureDailyTaskPanelAsync_003Ed__102))]
		private UniTaskVoid EnsureDailyTaskPanelAsync(bool showTaskPage)
		{
			return default;
		}

		[Token(Token = "0x6003B57")]
		[Address(RVA = "0x4128BF0", Offset = "0x4124BF0", VA = "0x4128BF0")]
		private void InitializeDailyTaskPanelPages()
		{
		}

		[Token(Token = "0x6003B58")]
		[Address(RVA = "0x4128DB4", Offset = "0x4124DB4", VA = "0x4128DB4")]
		private void BindDailyTaskPanelButtons()
		{
		}

		[Token(Token = "0x6003B59")]
		[Address(RVA = "0x4127CE8", Offset = "0x4123CE8", VA = "0x4127CE8")]
		private void UpdateDailyTaskPanelUi()
		{
		}

		[Token(Token = "0x6003B5A")]
		[Address(RVA = "0x412846C", Offset = "0x412446C", VA = "0x412846C")]
		private void UpdateDailyGiftPanelUi()
		{
		}

		[Token(Token = "0x6003B5B")]
		[Address(RVA = "0x4129050", Offset = "0x4125050", VA = "0x4129050")]
		private void OnSideDailyTaskClicked()
		{
		}

		[Token(Token = "0x6003B5C")]
		[Address(RVA = "0x4129074", Offset = "0x4125074", VA = "0x4129074")]
		private void OnSideDailyGiftClicked()
		{
		}

		[Token(Token = "0x6003B5D")]
		[Address(RVA = "0x4129098", Offset = "0x4125098", VA = "0x4129098")]
		public void OpenDailyGiftPage()
		{
		}

		[Token(Token = "0x6003B5E")]
		[Address(RVA = "0x41290D4", Offset = "0x41250D4", VA = "0x41290D4")]
		[AsyncStateMachine(typeof(_003CHandleInsufficientDiceAsync_003Ed__110))]
		private UniTask HandleInsufficientDiceAsync()
		{
			return default;
		}

		[Token(Token = "0x6003B5F")]
		[Address(RVA = "0x4128768", Offset = "0x4124768", VA = "0x4128768")]
		private void UpdateSideEntryRedDots()
		{
		}

		[Token(Token = "0x6003B60")]
		[Address(RVA = "0x412916C", Offset = "0x412516C", VA = "0x412916C")]
		private void SetSideEntryRedDotImage(bool visible, ref GameObject redDotCache, GameObject prefabRedDot, Image icon)
		{
		}

		[Token(Token = "0x6003B61")]
		[Address(RVA = "0x4129250", Offset = "0x4125250", VA = "0x4129250")]
		private GameObject EnsureSideEntryRedDotImage(ref GameObject redDotCache, GameObject prefabRedDot, Image icon)
		{
			return null;
		}

		[Token(Token = "0x6003B62")]
		[Address(RVA = "0x41296A0", Offset = "0x41256A0", VA = "0x41296A0")]
		private static void HideLegacySideEntryRedDot(Image icon)
		{
		}

		[Token(Token = "0x6003B63")]
		[Address(RVA = "0x4129614", Offset = "0x4125614", VA = "0x4129614")]
		[AsyncStateMachine(typeof(_003CEnsureSideEntryRedDotSpriteAsync_003Ed__115))]
		private UniTask EnsureSideEntryRedDotSpriteAsync(GameObject redDot)
		{
			return default;
		}

		[Token(Token = "0x6003B64")]
		[Address(RVA = "0x412977C", Offset = "0x412577C", VA = "0x412977C")]
		private void ShowDailyTaskPanel(bool showTaskPage)
		{
		}

		[Token(Token = "0x6003B65")]
		[Address(RVA = "0x41298E8", Offset = "0x41258E8", VA = "0x41298E8")]
		[AsyncStateMachine(typeof(_003CRefreshDailyGiftPageAsync_003Ed__117))]
		private UniTaskVoid RefreshDailyGiftPageAsync()
		{
			return default;
		}

		[Token(Token = "0x6003B66")]
		[Address(RVA = "0x4129960", Offset = "0x4125960", VA = "0x4129960")]
		private void OnDailyTaskClaimClicked(DailyTaskConfig config)
		{
		}

		[Token(Token = "0x6003B67")]
		[Address(RVA = "0x4129A08", Offset = "0x4125A08", VA = "0x4129A08")]
		private void OnDailyTaskGotoClicked(DailyTaskConfig config)
		{
		}

		[Token(Token = "0x6003B68")]
		[Address(RVA = "0x4129B18", Offset = "0x4125B18", VA = "0x4129B18")]
		private void NavigateDailyTaskToMeta(string metaModuleId)
		{
		}

		[Token(Token = "0x6003B69")]
		[Address(RVA = "0x4129C00", Offset = "0x4125C00", VA = "0x4129C00")]
		private void OnDailyGiftFreeClaimClicked(DailyPriceConfig config)
		{
		}

		[Token(Token = "0x6003B6A")]
		[Address(RVA = "0x4129CA8", Offset = "0x4125CA8", VA = "0x4129CA8")]
		private void OnSideFeatureClicked()
		{
		}

		[Token(Token = "0x6003B6B")]
		[Address(RVA = "0x4129CF0", Offset = "0x4125CF0", VA = "0x4129CF0")]
		[AsyncStateMachine(typeof(_003CEnsureDiscountShopPanelAsync_003Ed__123))]
		private UniTask EnsureDiscountShopPanelAsync()
		{
			return default;
		}

		[Token(Token = "0x6003B6C")]
		[Address(RVA = "0x4129D84", Offset = "0x4125D84", VA = "0x4129D84")]
		[AsyncStateMachine(typeof(_003CShowDiscountShopPanelAsync_003Ed__124))]
		private UniTask ShowDiscountShopPanelAsync()
		{
			return default;
		}

		[Token(Token = "0x6003B6D")]
		[Address(RVA = "0x4129E1C", Offset = "0x4125E1C", VA = "0x4129E1C")]
		private void HideDiscountShopPanel()
		{
		}

		[Token(Token = "0x6003B6E")]
		[Address(RVA = "0x4129E30", Offset = "0x4125E30", VA = "0x4129E30")]
		[AsyncStateMachine(typeof(_003CHideDiscountShopPanelAsync_003Ed__126))]
		private UniTask HideDiscountShopPanelAsync()
		{
			return default;
		}

		[Token(Token = "0x6003B6F")]
		[Address(RVA = "0x4129EC8", Offset = "0x4125EC8", VA = "0x4129EC8")]
		private void OnDiscountShopBuyClicked(SaleShopConfig config)
		{
		}

		[Token(Token = "0x6003B70")]
		[Address(RVA = "0x412A03C", Offset = "0x412603C", VA = "0x412A03C")]
		private void OnDiscountShopRefreshClicked()
		{
		}

		[Token(Token = "0x6003B71")]
		[Address(RVA = "0x412A0EC", Offset = "0x41260EC", VA = "0x412A0EC")]
		[AsyncStateMachine(typeof(_003CGmShowDiscountShopAsync_003Ed__129))]
		public UniTask GmShowDiscountShopAsync()
		{
			return default;
		}

		[Token(Token = "0x6003B72")]
		[Address(RVA = "0x412A184", Offset = "0x4126184", VA = "0x412A184")]
		public void GmRefreshDiscountShopView()
		{
		}

		[Token(Token = "0x6003B73")]
		[Address(RVA = "0x412A264", Offset = "0x4126264", VA = "0x412A264")]
		public void GmHideDiscountShop()
		{
		}

		[Token(Token = "0x6003B74")]
		[Address(RVA = "0x4127198", Offset = "0x4123198", VA = "0x4127198")]
		private void BindDiscountShopSideEntry()
		{
		}

		[Token(Token = "0x6003B75")]
		[Address(RVA = "0x412A278", Offset = "0x4126278", VA = "0x412A278")]
		private void OnSideDiscountShopClicked()
		{
		}

		[Token(Token = "0x6003B76")]
		[Address(RVA = "0x4128470", Offset = "0x4124470", VA = "0x4128470")]
		private void UpdateDiscountShopSideEntryUi()
		{
		}

		[Token(Token = "0x6003B77")]
		[Address(RVA = "0x412A32C", Offset = "0x412632C", VA = "0x412A32C")]
		[AsyncStateMachine(typeof(_003CEnsureInitializedAsync_003Ed__135))]
		private UniTask EnsureInitializedAsync()
		{
			return default;
		}

		[Token(Token = "0x6003B78")]
		[Address(RVA = "0x412A3BC", Offset = "0x41263BC", VA = "0x412A3BC")]
		[AsyncStateMachine(typeof(_003CEnsureDiceEffectAsync_003Ed__136))]
		private UniTask EnsureDiceEffectAsync()
		{
			return default;
		}

		[Token(Token = "0x6003B79")]
		[Address(RVA = "0x412A448", Offset = "0x4126448", VA = "0x412A448")]
		[AsyncStateMachine(typeof(_003CEnsureLapRewardPopupLoadedAsync_003Ed__140))]
		private UniTask EnsureLapRewardPopupLoadedAsync()
		{
			return default;
		}

		[Token(Token = "0x6003B7A")]
		[Address(RVA = "0x412A4D8", Offset = "0x41264D8", VA = "0x412A4D8")]
		[AsyncStateMachine(typeof(_003CShowLapRewardPopupAndWaitAsync_003Ed__141))]
		public UniTask ShowLapRewardPopupAndWaitAsync(MysteryAdventureLapRewardPopupData data)
		{
			return default;
		}

		[Token(Token = "0x6003B7B")]
		[Address(RVA = "0x412A584", Offset = "0x4126584", VA = "0x412A584")]
		private static void GrantLapRewardPopupRewards(MysteryAdventureLapRewardPopupData data)
		{
		}

		[Token(Token = "0x6003B7C")]
		[Address(RVA = "0x412A6F4", Offset = "0x41266F4", VA = "0x412A6F4")]
		private void HideLapRewardPopup()
		{
		}

		[Token(Token = "0x6003B7D")]
		[Address(RVA = "0x41266A0", Offset = "0x41226A0", VA = "0x41266A0")]
		private bool CanClickRollButton()
		{
			return default;
		}

		[Token(Token = "0x6003B7E")]
		[Address(RVA = "0x4124EF8", Offset = "0x4120EF8", VA = "0x4124EF8")]
		private bool CanAutoRollContinue()
		{
			return default;
		}

		[Token(Token = "0x6003B7F")]
		[Address(RVA = "0x41250B0", Offset = "0x41210B0", VA = "0x41250B0")]
		private bool IsInsufficientDiceForRoll()
		{
			return default;
		}

		[Token(Token = "0x6003B80")]
		[Address(RVA = "0x412A788", Offset = "0x4126788", VA = "0x412A788")]
		private void OnRollClicked()
		{
		}

		[Token(Token = "0x6003B81")]
		[Address(RVA = "0x4125028", Offset = "0x4121028", VA = "0x4125028")]
		[AsyncStateMachine(typeof(_003CRunAutoRollLoopAsync_003Ed__148))]
		private UniTaskVoid RunAutoRollLoopAsync(int rollFlowVersion)
		{
			return default;
		}

		[Token(Token = "0x6003B82")]
		[Address(RVA = "0x4124D28", Offset = "0x4120D28", VA = "0x4124D28")]
		private void StopAutoRoll(bool setToggleOff)
		{
		}

		[Token(Token = "0x6003B83")]
		[Address(RVA = "0x412A914", Offset = "0x4126914", VA = "0x412A914")]
		[AsyncStateMachine(typeof(_003COnRollClickedAsync_003Ed__150))]
		private UniTaskVoid OnRollClickedAsync()
		{
			return default;
		}

		[Token(Token = "0x6003B84")]
		[Address(RVA = "0x412A98C", Offset = "0x412698C", VA = "0x412A98C")]
		[AsyncStateMachine(typeof(_003CExecuteRollAsync_003Ed__151))]
		private UniTask<bool> ExecuteRollAsync(int rollFlowVersion)
		{
			return default;
		}

		[Token(Token = "0x6003B85")]
		[Address(RVA = "0x412AA50", Offset = "0x4126A50", VA = "0x412AA50")]
		[AsyncStateMachine(typeof(_003CTryShowPendingRuinsInteractionAsync_003Ed__152))]
		private UniTask<bool> TryShowPendingRuinsInteractionAsync(MysteryAdventureRollResult result)
		{
			return default;
		}

		[Token(Token = "0x6003B86")]
		[Address(RVA = "0x412AB1C", Offset = "0x4126B1C", VA = "0x412AB1C")]
		[AsyncStateMachine(typeof(_003CHandleAutoRollPendingInteractionAsync_003Ed__153))]
		private UniTask HandleAutoRollPendingInteractionAsync()
		{
			return default;
		}

		[Token(Token = "0x6003B87")]
		[Address(RVA = "0x412ABB4", Offset = "0x4126BB4", VA = "0x412ABB4")]
		[AsyncStateMachine(typeof(_003CHandleAutoRollRewardPanelAsync_003Ed__154))]
		private UniTask HandleAutoRollRewardPanelAsync()
		{
			return default;
		}

		[Token(Token = "0x6003B88")]
		[Address(RVA = "0x412AC4C", Offset = "0x4126C4C", VA = "0x412AC4C")]
		private static void PlayAdvancedCellSfxIfNeeded(int buildId)
		{
		}

		[Token(Token = "0x6003B89")]
		[Address(RVA = "0x412ACDC", Offset = "0x4126CDC", VA = "0x412ACDC")]
		private static bool IsAdvancedCellBuild(int buildId)
		{
			return default;
		}

		[Token(Token = "0x6003B8A")]
		[Address(RVA = "0x412ACEC", Offset = "0x4126CEC", VA = "0x412ACEC")]
		private void CleanupStaleRuinsUiOnShow()
		{
		}

		[Token(Token = "0x6003B8B")]
		[Address(RVA = "0x412ADC8", Offset = "0x4126DC8", VA = "0x412ADC8")]
		private void TryClaimPendingRuinsBanditReward()
		{
		}

		[Token(Token = "0x6003B8C")]
		[Address(RVA = "0x412AEA0", Offset = "0x4126EA0", VA = "0x412AEA0")]
		private void CloseRuinsEventPanelAfterBanditReturn()
		{
		}

		[Token(Token = "0x6003B8D")]
		[Address(RVA = "0x412AF00", Offset = "0x4126F00", VA = "0x412AF00")]
		[AsyncStateMachine(typeof(_003CRestoreRuinsBanditPanelIfNeededAsync_003Ed__160))]
		private UniTask RestoreRuinsBanditPanelIfNeededAsync()
		{
			return default;
		}

		[Token(Token = "0x6003B8E")]
		[Address(RVA = "0x412AFD8", Offset = "0x4126FD8", VA = "0x412AFD8")]
		[AsyncStateMachine(typeof(_003CEnsureRuinsPanelsAsync_003Ed__161))]
		private UniTask EnsureRuinsPanelsAsync()
		{
			return default;
		}

		[Token(Token = "0x6003B8F")]
		[AsyncStateMachine(typeof(_003CLoadRuinsPanelAsync_003Ed__162<>))]
		private UniTask LoadRuinsPanelAsync<T>(string prefabPath, RectTransform parent, Action<T> assignPanel, Action<GameObject> assignInstance, Func<T> buildFallback) where T : Component
		{
			return default;
		}

		[Token(Token = "0x6003B90")]
		[Address(RVA = "0x412B068", Offset = "0x4127068", VA = "0x412B068")]
		[AsyncStateMachine(typeof(_003CShowRuinsEventPanelAsync_003Ed__163))]
		public UniTask ShowRuinsEventPanelAsync()
		{
			return default;
		}

		[Token(Token = "0x6003B91")]
		[Address(RVA = "0x412B100", Offset = "0x4127100", VA = "0x412B100")]
		private static void ActivateRuinsPanelInstance(GameObject instance, Component panel)
		{
		}

		[Token(Token = "0x6003B92")]
		[Address(RVA = "0x412B1AC", Offset = "0x41271AC", VA = "0x412B1AC")]
		private static void DeactivateRuinsPanelInstance(GameObject instance, Component panel)
		{
		}

		[Token(Token = "0x6003B93")]
		[Address(RVA = "0x412B258", Offset = "0x4127258", VA = "0x412B258")]
		private void OnRuinsOptionSelected(int optionIndex)
		{
		}

		[Token(Token = "0x6003B94")]
		[Address(RVA = "0x412B26C", Offset = "0x412726C", VA = "0x412B26C")]
		[AsyncStateMachine(typeof(_003CRunRuinsOptionSelectedAsync_003Ed__167))]
		private UniTask RunRuinsOptionSelectedAsync(int optionIndex)
		{
			return default;
		}

		[Token(Token = "0x6003B95")]
		[Address(RVA = "0x412B318", Offset = "0x4127318", VA = "0x412B318")]
		[AsyncStateMachine(typeof(_003CStartRuinsBanditBattleAsync_003Ed__168))]
		private UniTask StartRuinsBanditBattleAsync()
		{
			return default;
		}

		[Token(Token = "0x6003B96")]
		[Address(RVA = "0x412B3B0", Offset = "0x41273B0", VA = "0x412B3B0")]
		private void NavigateToBattleMeta()
		{
		}

		[Token(Token = "0x6003B97")]
		[Address(RVA = "0x412B490", Offset = "0x4127490", VA = "0x412B490")]
		[AsyncStateMachine(typeof(_003CPlayRuinsDiceRewardPanelAsync_003Ed__170))]
		private UniTask PlayRuinsDiceRewardPanelAsync(int diceGrant)
		{
			return default;
		}

		[Token(Token = "0x6003B98")]
		[Address(RVA = "0x412B53C", Offset = "0x412753C", VA = "0x412B53C")]
		[AsyncStateMachine(typeof(_003CPlayRuinsBlackHoleMoveAndSettleAsync_003Ed__171))]
		private UniTask PlayRuinsBlackHoleMoveAndSettleAsync()
		{
			return default;
		}

		[Token(Token = "0x6003B99")]
		[Address(RVA = "0x412B5DC", Offset = "0x41275DC", VA = "0x412B5DC")]
		[AsyncStateMachine(typeof(_003CPlayRuinsRpsAndResolveAsync_003Ed__172))]
		private UniTask PlayRuinsRpsAndResolveAsync(int playerChoiceIndex)
		{
			return default;
		}

		[Token(Token = "0x6003B9A")]
		[Address(RVA = "0x412B688", Offset = "0x4127688", VA = "0x412B688")]
		private static void ResolveRuinsRpsWithoutGameplay(int playerChoiceIndex)
		{
		}

		[Token(Token = "0x6003B9B")]
		[Address(RVA = "0x412B728", Offset = "0x4127728", VA = "0x412B728")]
		private static void BringRuinsOverlayToFront(GameObject instance, Component panel)
		{
		}

		[Token(Token = "0x6003B9C")]
		[Address(RVA = "0x412B7DC", Offset = "0x41277DC", VA = "0x412B7DC")]
		private void PrepareRpsOverlayForDisplay()
		{
		}

		[Token(Token = "0x6003B9D")]
		[Address(RVA = "0x412BA14", Offset = "0x4127A14", VA = "0x412BA14")]
		private static void SetLayerRecursively(GameObject go, int layer)
		{
		}

		[Token(Token = "0x6003B9E")]
		[Address(RVA = "0x412BB00", Offset = "0x4127B00", VA = "0x412BB00")]
		[AsyncStateMachine(typeof(_003CEnsureRuinsRpsGameplayPanelAsync_003Ed__177))]
		private UniTask EnsureRuinsRpsGameplayPanelAsync()
		{
			return default;
		}

		[Token(Token = "0x6003B9F")]
		[Address(RVA = "0x412AF9C", Offset = "0x4126F9C", VA = "0x412AF9C")]
		private void OnRuinsPanelClosed()
		{
		}

		[Token(Token = "0x6003BA0")]
		[Address(RVA = "0x412AD80", Offset = "0x4126D80", VA = "0x412AD80")]
		public void GmHideRuinsEvent()
		{
		}

		[Token(Token = "0x6003BA1")]
		[Address(RVA = "0x412BB90", Offset = "0x4127B90", VA = "0x412BB90")]
		private void PreloadRulesPanelIfNeeded()
		{
		}

		[Token(Token = "0x6003BA2")]
		[Address(RVA = "0x412BBA4", Offset = "0x4127BA4", VA = "0x412BBA4")]
		[AsyncStateMachine(typeof(_003CEnsureRulesPanelLoadedAsync_003Ed__181))]
		private UniTask EnsureRulesPanelLoadedAsync()
		{
			return default;
		}

		[Token(Token = "0x6003BA3")]
		[Address(RVA = "0x4128A2C", Offset = "0x4124A2C", VA = "0x4128A2C")]
		[AsyncStateMachine(typeof(_003CEnsureRulesPanelAsync_003Ed__182))]
		private UniTask EnsureRulesPanelAsync(bool showBuildingTab)
		{
			return default;
		}

		[Token(Token = "0x6003BA4")]
		[Address(RVA = "0x412BC38", Offset = "0x4127C38", VA = "0x412BC38")]
		private void ShowRulesPanel(bool showBuildingTab)
		{
		}

		[Token(Token = "0x6003BA5")]
		[Address(RVA = "0x412BD10", Offset = "0x4127D10", VA = "0x412BD10")]
		private void HideRulesPanel()
		{
		}

		[Token(Token = "0x6003BA6")]
		[Address(RVA = "0x412529C", Offset = "0x412129C", VA = "0x412529C")]
		private void SetStatusText(string message)
		{
		}

		[Token(Token = "0x6003BA7")]
		[Address(RVA = "0x41288A4", Offset = "0x41248A4", VA = "0x41288A4")]
		private void ClearStatusText()
		{
		}

		[Token(Token = "0x6003BA8")]
		[Address(RVA = "0x412BDA4", Offset = "0x4127DA4", VA = "0x412BDA4")]
		private void EnsureTenRollToggle()
		{
		}

		[Token(Token = "0x6003BA9")]
		[Address(RVA = "0x412C068", Offset = "0x4128068", VA = "0x412C068")]
		private void ApplyTenRollToggleLabel()
		{
		}

		[Token(Token = "0x6003BAA")]
		[Address(RVA = "0x41247F8", Offset = "0x41207F8", VA = "0x41247F8")]
		private void BindTenRollToggleEvents()
		{
		}

		[Token(Token = "0x6003BAB")]
		[Address(RVA = "0x4124B14", Offset = "0x4120B14", VA = "0x4124B14")]
		private void RestoreTenRollToggleState()
		{
		}

		[Token(Token = "0x6003BAC")]
		[Address(RVA = "0x412C324", Offset = "0x4128324", VA = "0x412C324")]
		private void OnTenRollToggleChanged(bool isOn)
		{
		}

		[Token(Token = "0x6003BAD")]
		[Address(RVA = "0x412C244", Offset = "0x4128244", VA = "0x412C244")]
		private void SyncTenRollToManager()
		{
		}

		[Token(Token = "0x6003BAE")]
		[Address(RVA = "0x412C500", Offset = "0x4128500", VA = "0x412C500")]
		private bool WantsTenRoll()
		{
			return default;
		}

		[Token(Token = "0x6003BAF")]
		[Address(RVA = "0x412C4D8", Offset = "0x41284D8", VA = "0x412C4D8")]
		private bool IsTenRollEnabled()
		{
			return default;
		}

		[Token(Token = "0x6003BB0")]
		[Address(RVA = "0x412A8A0", Offset = "0x41268A0", VA = "0x412A8A0")]
		private bool TryGetTenRollBlockMessage(out string message)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MysteryAdventurePanel.TryGetTenRollBlockMessage RVA=0x412A8A0 Token=0x6003BB0");
}

		[Token(Token = "0x6003BB1")]
		[Address(RVA = "0x412C418", Offset = "0x4128418", VA = "0x412C418")]
		private bool HasUnlockedTenRoll()
		{
			return default;
		}

		[Token(Token = "0x6003BB2")]
		[Address(RVA = "0x412C178", Offset = "0x4128178", VA = "0x412C178")]
		private void RefreshTenRollToggleVisibility()
		{
		}

		[Token(Token = "0x6003BB3")]
		[Address(RVA = "0x412C2C0", Offset = "0x41282C0", VA = "0x412C2C0")]
		private bool CanEnableTenRoll()
		{
			return default;
		}

		[Token(Token = "0x6003BB4")]
		[Address(RVA = "0x41264CC", Offset = "0x41224CC", VA = "0x41264CC")]
		private void CancelTenRoll(bool setToggleOff)
		{
		}

		[Token(Token = "0x6003BB5")]
		[Address(RVA = "0x4127F54", Offset = "0x4123F54", VA = "0x4127F54")]
		private void SyncTenRollWithDiceState()
		{
		}

		[Token(Token = "0x6003BB6")]
		[Address(RVA = "0x412C5C4", Offset = "0x41285C4", VA = "0x412C5C4")]
		public MysteryAdventurePanel()
		{
		}
	}
}
