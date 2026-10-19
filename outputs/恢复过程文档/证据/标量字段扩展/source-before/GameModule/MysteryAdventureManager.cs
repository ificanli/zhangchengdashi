using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using ToolModule;
using UIModuleO;
using UnityEngine;
using ljzs_lt;

namespace GameModule
{
	[Token(Token = "0x2000511")]
	public class MysteryAdventureManager : ManagerBase<MysteryAdventureManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000514")]
		[CompilerGenerated]
		private struct _003CAutoCloseGetNewCardPanelAsync_003Ed__141 : IAsyncStateMachine
		{
			[Token(Token = "0x4002DEA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002DEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002DEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float closeDelaySeconds;

			[Token(Token = "0x4002DED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001AAB")]
			[Address(RVA = "0x3EA680C", Offset = "0x3EA280C", VA = "0x3EA680C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001AAC")]
			[Address(RVA = "0x3EA6F74", Offset = "0x3EA2F74", VA = "0x3EA6F74", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000515")]
		[CompilerGenerated]
		private struct _003CAutoCloseOpenBoxAnimationPanelAsync_003Ed__142 : IAsyncStateMachine
		{
			[Token(Token = "0x4002DEE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002DEF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002DF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public OpenBoxAnimationPanel openBoxPanel;

			[Token(Token = "0x4002DF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float closeDelaySeconds;

			[Token(Token = "0x4002DF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private float _003CentryDeadline_003E5__2;

			[Token(Token = "0x4002DF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4002DF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6001AAD")]
			[Address(RVA = "0x3EA6F80", Offset = "0x3EA2F80", VA = "0x3EA6F80", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001AAE")]
			[Address(RVA = "0x3EA75E0", Offset = "0x3EA35E0", VA = "0x3EA75E0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000516")]
		[CompilerGenerated]
		private struct _003CAutoCloseRewardPanelIfShowingAsync_003Ed__138 : IAsyncStateMachine
		{
			[Token(Token = "0x4002DF5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002DF6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002DF7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float waitShowTimeoutSeconds;

			[Token(Token = "0x4002DF8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float closeDelaySeconds;

			[Token(Token = "0x4002DF9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private float _003CoverallDeadline_003E5__2;

			[Token(Token = "0x4002DFA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private float _003Cdeadline_003E5__3;

			[Token(Token = "0x4002DFB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4002DFC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x4002DFD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<bool>.Awaiter _003C_003Eu__3;

			[Token(Token = "0x6001AAF")]
			[Address(RVA = "0x3EA75EC", Offset = "0x3EA35EC", VA = "0x3EA75EC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001AB0")]
			[Address(RVA = "0x3EA82BC", Offset = "0x3EA42BC", VA = "0x3EA82BC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000517")]
		[CompilerGenerated]
		private struct _003CClaimTotalDiceRewardsAsync_003Ed__266 : IAsyncStateMachine
		{
			[Token(Token = "0x4002DFE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002DFF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

			[Token(Token = "0x4002E00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MysteryAdventureManager _003C_003E4__this;

			[Token(Token = "0x4002E01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001AB1")]
			[Address(RVA = "0x3EA82C8", Offset = "0x3EA42C8", VA = "0x3EA82C8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001AB2")]
			[Address(RVA = "0x3EA8600", Offset = "0x3EA4600", VA = "0x3EA8600", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000518")]
		[CompilerGenerated]
		private struct _003CCompleteRuinsBlackHoleMoveAsync_003Ed__190 : IAsyncStateMachine
		{
			[Token(Token = "0x4002E02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002E03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002E04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventureManager _003C_003E4__this;

			[Token(Token = "0x4002E05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UnityEngine.Vector3 flyStartWorldPos;

			[Token(Token = "0x4002E06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public bool awaitDiceGrant;

			[Token(Token = "0x4002E07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001AB3")]
			[Address(RVA = "0x3EA8658", Offset = "0x3EA4658", VA = "0x3EA8658", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001AB4")]
			[Address(RVA = "0x3EA9048", Offset = "0x3EA5048", VA = "0x3EA9048", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000519")]
		[CompilerGenerated]
		private struct _003CCreateRuntimeEntryButtonAsync_003Ed__48 : IAsyncStateMachine
		{
			[Token(Token = "0x4002E08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002E09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002E0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MysteryAdventureManager _003C_003E4__this;

			[Token(Token = "0x4002E0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RectTransform _003Cparent_003E5__2;

			[Token(Token = "0x4002E0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001AB5")]
			[Address(RVA = "0x3EA9054", Offset = "0x3EA5054", VA = "0x3EA9054", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001AB6")]
			[Address(RVA = "0x3EA9558", Offset = "0x3EA5558", VA = "0x3EA9558", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200051A")]
		[CompilerGenerated]
		private struct _003CEnsureActivityAssetsPreloadedAsync_003Ed__40 : IAsyncStateMachine
		{
			[Token(Token = "0x4002E0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002E0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002E0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventureManager _003C_003E4__this;

			[Token(Token = "0x4002E10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4002E11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<MysteryAdventureUiAssets> _003CuiAssetsTask_003E5__2;

			[Token(Token = "0x4002E12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private bool _003CuiAssetsPending_003E5__3;

			[Token(Token = "0x4002E13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x4002E14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask<MysteryAdventureUiAssets>.Awaiter _003C_003Eu__3;

			[Token(Token = "0x6001AB7")]
			[Address(RVA = "0x3EA9564", Offset = "0x3EA5564", VA = "0x3EA9564", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001AB8")]
			[Address(RVA = "0x3EAA160", Offset = "0x3EA6160", VA = "0x3EAA160", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200051B")]
		[CompilerGenerated]
		private struct _003CGetOrLoadUiAssetsAsync_003Ed__21 : IAsyncStateMachine
		{
			[Token(Token = "0x4002E15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002E16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<MysteryAdventureUiAssets> _003C_003Et__builder;

			[Token(Token = "0x4002E17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MysteryAdventureManager _003C_003E4__this;

			[Token(Token = "0x4002E18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001AB9")]
			[Address(RVA = "0x3EAA16C", Offset = "0x3EA616C", VA = "0x3EAA16C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001ABA")]
			[Address(RVA = "0x3EAA588", Offset = "0x3EA6588", VA = "0x3EAA588", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200051C")]
		[CompilerGenerated]
		private struct _003CGmOpenDiscountShopAsync_003Ed__247 : IAsyncStateMachine
		{
			[Token(Token = "0x4002E19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002E1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<string> _003C_003Et__builder;

			[Token(Token = "0x4002E1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MysteryAdventureManager _003C_003E4__this;

			[Token(Token = "0x4002E1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001ABB")]
			[Address(RVA = "0x3EAA5E0", Offset = "0x3EA65E0", VA = "0x3EAA5E0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001ABC")]
			[Address(RVA = "0x3EAACC8", Offset = "0x3EA6CC8", VA = "0x3EAACC8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200051D")]
		[CompilerGenerated]
		private struct _003CGmOpenRuinsEventAsync_003Ed__194 : IAsyncStateMachine
		{
			[Token(Token = "0x4002E1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002E1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<string> _003C_003Et__builder;

			[Token(Token = "0x4002E1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MysteryAdventureManager _003C_003E4__this;

			[Token(Token = "0x4002E20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int eventId;

			[Token(Token = "0x4002E21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001ABD")]
			[Address(RVA = "0x3EAAD20", Offset = "0x3EA6D20", VA = "0x3EAAD20", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001ABE")]
			[Address(RVA = "0x3EAB47C", Offset = "0x3EA747C", VA = "0x3EAB47C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200051E")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__23 : IAsyncStateMachine
		{
			[Token(Token = "0x4002E22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002E23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002E24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventureManager _003C_003E4__this;

			[Token(Token = "0x4002E25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001ABF")]
			[Address(RVA = "0x3EAB4D4", Offset = "0x3EA74D4", VA = "0x3EAB4D4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001AC0")]
			[Address(RVA = "0x3EABBD0", Offset = "0x3EA7BD0", VA = "0x3EABBD0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200051F")]
		[CompilerGenerated]
		private struct _003COpenActivityPanelAsync_003Ed__51 : IAsyncStateMachine
		{
			[Token(Token = "0x4002E26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002E27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002E28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MysteryAdventureManager _003C_003E4__this;

			[Token(Token = "0x4002E29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001AC1")]
			[Address(RVA = "0x3EABBDC", Offset = "0x3EA7BDC", VA = "0x3EABBDC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001AC2")]
			[Address(RVA = "0x3EABEEC", Offset = "0x3EA7EEC", VA = "0x3EABEEC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000520")]
		[CompilerGenerated]
		private struct _003CReturnToMysteryAdventureAfterBanditBattleAsync_003Ed__212 : IAsyncStateMachine
		{
			[Token(Token = "0x4002E2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002E2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002E2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventureManager _003C_003E4__this;

			[Token(Token = "0x4002E2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4002E2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6001AC3")]
			[Address(RVA = "0x3EABEF8", Offset = "0x3EA7EF8", VA = "0x3EABEF8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001AC4")]
			[Address(RVA = "0x3EAC48C", Offset = "0x3EA848C", VA = "0x3EAC48C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000521")]
		[CompilerGenerated]
		private struct _003CScheduleBanditBattleAutoReturnAsync_003Ed__211 : IAsyncStateMachine
		{
			[Token(Token = "0x4002E2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002E30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002E31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MysteryAdventureManager _003C_003E4__this;

			[Token(Token = "0x4002E32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001AC5")]
			[Address(RVA = "0x3EAC498", Offset = "0x3EA8498", VA = "0x3EAC498", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001AC6")]
			[Address(RVA = "0x3EAD010", Offset = "0x3EA9010", VA = "0x3EAD010", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000522")]
		[CompilerGenerated]
		private struct _003CShowActivityPanel_003Ed__39 : IAsyncStateMachine
		{
			[Token(Token = "0x4002E33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002E34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002E35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventureManager _003C_003E4__this;

			[Token(Token = "0x4002E36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string enterWay;

			[Token(Token = "0x4002E37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001AC7")]
			[Address(RVA = "0x3EAD01C", Offset = "0x3EA901C", VA = "0x3EAD01C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001AC8")]
			[Address(RVA = "0x3EAD800", Offset = "0x3EA9800", VA = "0x3EAD800", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000523")]
		[CompilerGenerated]
		private struct _003CShowDiceCollectFlyAsync_003Ed__152 : IAsyncStateMachine
		{
			[Token(Token = "0x4002E38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002E39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002E3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int grantCount;

			[Token(Token = "0x4002E3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public UnityEngine.Vector3 startWorldPos;

			[Token(Token = "0x4002E3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MysteryAdventureManager _003C_003E4__this;

			[Token(Token = "0x4002E3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001AC9")]
			[Address(RVA = "0x3EAD80C", Offset = "0x3EA980C", VA = "0x3EAD80C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001ACA")]
			[Address(RVA = "0x3EADC20", Offset = "0x3EA9C20", VA = "0x3EADC20", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000524")]
		[CompilerGenerated]
		private struct _003CShowLapRewardAndWaitAsync_003Ed__137 : IAsyncStateMachine
		{
			[Token(Token = "0x4002E3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002E3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002E40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string lapRewardRaw;

			[Token(Token = "0x4002E41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MysteryAdventureManager _003C_003E4__this;

			[Token(Token = "0x4002E42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int lapReportLapCount;

			[Token(Token = "0x4002E43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int lapReportLevel;

			[Token(Token = "0x4002E44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int lapReportMultiplier;

			[Token(Token = "0x4002E45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public UnityEngine.Vector3 flyStartWorldPos;

			[Token(Token = "0x4002E46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool autoCloseForAutoRoll;

			[Token(Token = "0x4002E47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float autoCloseDelaySeconds;

			[Token(Token = "0x4002E48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4002E49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6001ACB")]
			[Address(RVA = "0x3EADC2C", Offset = "0x3EA9C2C", VA = "0x3EADC2C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001ACC")]
			[Address(RVA = "0x3EAE524", Offset = "0x3EAA524", VA = "0x3EAE524", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000525")]
		[CompilerGenerated]
		private struct _003CShowRollRewardsAsync_003Ed__131 : IAsyncStateMachine
		{
			[Token(Token = "0x4002E4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002E4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002E4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventureRollResult result;

			[Token(Token = "0x4002E4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MysteryAdventureManager _003C_003E4__this;

			[Token(Token = "0x4002E4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UnityEngine.Vector3 flyStartWorldPos;

			[Token(Token = "0x4002E4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public bool awaitDiceGrant;

			[Token(Token = "0x4002E50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001ACD")]
			[Address(RVA = "0x3EAE530", Offset = "0x3EAA530", VA = "0x3EAE530", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001ACE")]
			[Address(RVA = "0x3EAECB4", Offset = "0x3EAACB4", VA = "0x3EAECB4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000526")]
		[CompilerGenerated]
		private struct _003CShowRuinsEventPanelAsync_003Ed__191 : IAsyncStateMachine
		{
			[Token(Token = "0x4002E51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002E52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002E53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventureManager _003C_003E4__this;

			[Token(Token = "0x4002E54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001ACF")]
			[Address(RVA = "0x3EAECC0", Offset = "0x3EAACC0", VA = "0x3EAECC0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001AD0")]
			[Address(RVA = "0x3EAF154", Offset = "0x3EAB154", VA = "0x3EAF154", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000527")]
		[CompilerGenerated]
		private struct _003CShowRuinsRoadsideDiceRewardPanelAsync_003Ed__153 : IAsyncStateMachine
		{
			[Token(Token = "0x4002E55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002E56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002E57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int grantCount;

			[Token(Token = "0x4002E58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MysteryAdventureManager _003C_003E4__this;

			[Token(Token = "0x4002E59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool autoCloseForAutoRoll;

			[Token(Token = "0x4002E5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float autoCloseDelaySeconds;

			[Token(Token = "0x4002E5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4002E5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6001AD1")]
			[Address(RVA = "0x3EAF160", Offset = "0x3EAB160", VA = "0x3EAF160", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001AD2")]
			[Address(RVA = "0x3EAFA24", Offset = "0x3EABA24", VA = "0x3EAFA24", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000528")]
		[CompilerGenerated]
		private struct _003CTryAutoStartBanditBattleMatchAsync_003Ed__182 : IAsyncStateMachine
		{
			[Token(Token = "0x4002E5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002E5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002E5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventureManager _003C_003E4__this;

			[Token(Token = "0x4002E60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001AD3")]
			[Address(RVA = "0x3EAFA30", Offset = "0x3EABA30", VA = "0x3EAFA30", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001AD4")]
			[Address(RVA = "0x3EB046C", Offset = "0x3EAC46C", VA = "0x3EB046C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000529")]
		[CompilerGenerated]
		private struct _003CTryGrantMysteryAdventureRewardAsync_003Ed__135 : IAsyncStateMachine
		{
			[Token(Token = "0x4002E61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002E62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002E63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool forceRewardPanel;

			[Token(Token = "0x4002E64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string rewardRaw;

			[Token(Token = "0x4002E65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool awaitDiceGrant;

			[Token(Token = "0x4002E66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public UnityEngine.Vector3 flyStartWorldPos;

			[Token(Token = "0x4002E67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public CurrencyTransactionSceneType sceneType;

			[Token(Token = "0x4002E68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001AD5")]
			[Address(RVA = "0x3EB0478", Offset = "0x3EAC478", VA = "0x3EB0478", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001AD6")]
			[Address(RVA = "0x3EB0AA8", Offset = "0x3EACAA8", VA = "0x3EB0AA8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200052A")]
		[CompilerGenerated]
		private struct _003CWaitForNextGetNewCardPanelAsync_003Ed__140 : IAsyncStateMachine
		{
			[Token(Token = "0x4002E69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002E6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

			[Token(Token = "0x4002E6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float graceSeconds;

			[Token(Token = "0x4002E6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private float _003Cdeadline_003E5__2;

			[Token(Token = "0x4002E6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001AD7")]
			[Address(RVA = "0x3EB0AB4", Offset = "0x3EACAB4", VA = "0x3EB0AB4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001AD8")]
			[Address(RVA = "0x3EB0EF0", Offset = "0x3EACEF0", VA = "0x3EB0EF0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002DBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IReadOnlyList<MysteryAdventureCellConfig> _cells;

		[Token(Token = "0x4002DBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GiftBtn _runtimeEntryBtn;

		[Token(Token = "0x4002DBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool _isRolling;

		[Token(Token = "0x4002DBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool _batchRollUiRefresh;

		[Token(Token = "0x4002DBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool _entryCreateRequested;

		[Token(Token = "0x4002DC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
		private bool _gmTestMode;

		[Token(Token = "0x4002DC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool _gmForceOpenActivity;

		[Token(Token = "0x4002DC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool _gmSaveCleared;

		[Token(Token = "0x4002DC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _gmFixedDiceValue;

		[Token(Token = "0x4002DC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool _assetsPreloading;

		[Token(Token = "0x4002DC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private MysteryAdventureUiAssets _cachedUiAssets;

		[Token(Token = "0x4002DC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _dailyGiftIapListenersRegistered;

		[Token(Token = "0x4002DC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool _dailyTaskEventListenersRegistered;

		[Token(Token = "0x4002DC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		private bool _ruinsBanditBattleEventListenersRegistered;

		[Token(Token = "0x4002DC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BattleResult _lastBanditBattleResult;

		[Token(Token = "0x4002DCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _banditBattleReturnScheduled;

		[Token(Token = "0x4002DCB")]
		private const string DailyGiftPlacement = "main_menu";

		[Token(Token = "0x4002DCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool s_loginFaceSlapShownThisSession;

		[Token(Token = "0x4002DCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string _onlineParamSyncKey;

		[Token(Token = "0x4002DCE")]
		private const string MysteryAdventureRandomCardPoolAssetId = "5001";

		[Token(Token = "0x4002DCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int _grantDiceSourceOverride;

		[Token(Token = "0x4002DD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RuinsConfigConfig _pendingRuinsConfig;

		[Token(Token = "0x4002DD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private MysteryAdventureRollResult _pendingRuinsResult;

		[Token(Token = "0x4002DD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private PlayerMysteryAdventureData _pendingRuinsData;

		[Token(Token = "0x4002DD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private string _pendingRuinsRandomRewardRaw;

		[Token(Token = "0x4002DD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool _pendingRuinsBlackHoleHasMove;

		[Token(Token = "0x4002DD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		private bool _pendingRuinsBlackHoleForward;

		[Token(Token = "0x4002DD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private int _pendingRuinsBlackHoleSteps;

		[Token(Token = "0x4002DD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool _pendingRuinsRoadsideDiceHasGrant;

		[Token(Token = "0x4002DD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private int _pendingRuinsRoadsideDiceCount;

		[Token(Token = "0x4002DD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool _pendingShopInteraction;

		[Token(Token = "0x4002DDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		private bool _discountShopAccumulateOnly;

		[Token(Token = "0x4002DDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		private bool _discountShopSessionActive;

		[Token(Token = "0x4002DDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
		private bool _tenRollEnabled;

		[Token(Token = "0x4002DDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private int _lapSegmentDiceConsumed;

		[Token(Token = "0x4002DDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int _lapSegmentRollCount;

		[Token(Token = "0x4002DDF")]
		public const int RequiredUnlockArenaLevel = 3;

		[Token(Token = "0x17000154")]
		public bool IsGmTestMode
		{
			[Token(Token = "0x60019B8")]
			[Address(RVA = "0x3E98E70", Offset = "0x3E94E70", VA = "0x3E98E70")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000155")]
		public bool IsGmForceOpenActivity
		{
			[Token(Token = "0x60019B9")]
			[Address(RVA = "0x3E98E78", Offset = "0x3E94E78", VA = "0x3E98E78")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000156")]
		public int GmFixedDiceValue
		{
			[Token(Token = "0x6001A13")]
			[Address(RVA = "0x3E9E2D0", Offset = "0x3E9A2D0", VA = "0x3E9E2D0")]
			get
			{
				return _gmFixedDiceValue;
			}
		}

		[Token(Token = "0x17000157")]
		private DbtSaveDataManager_PlayerMysteryAdventureData SaveManager
		{
			[Token(Token = "0x6001A70")]
			[Address(RVA = "0x3EA3AAC", Offset = "0x3E9FAAC", VA = "0x3EA3AAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000158")]
		public bool HasPendingShopInteraction
		{
			[Token(Token = "0x6001A76")]
			[Address(RVA = "0x3EA3AF4", Offset = "0x3E9FAF4", VA = "0x3EA3AF4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000159")]
		public bool HasActiveDiscountShopSession
		{
			[Token(Token = "0x6001A77")]
			[Address(RVA = "0x3EA3AFC", Offset = "0x3E9FAFC", VA = "0x3EA3AFC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700015A")]
		public bool IsTenRollEnabled
		{
			[Token(Token = "0x6001A8B")]
			[Address(RVA = "0x3EA44AC", Offset = "0x3EA04AC", VA = "0x3EA44AC")]
			get
			{
				return _tenRollEnabled;
			}
		}

		[Token(Token = "0x60019BA")]
		[Address(RVA = "0x3E98E80", Offset = "0x3E94E80", VA = "0x3E98E80")]
		[AsyncStateMachine(typeof(_003CGetOrLoadUiAssetsAsync_003Ed__21))]
		public UniTask<MysteryAdventureUiAssets> GetOrLoadUiAssetsAsync()
		{
			return default;
		}

		[Token(Token = "0x60019BB")]
		[Address(RVA = "0x3E98F64", Offset = "0x3E94F64", VA = "0x3E98F64")]
		public void PreloadActivityAssetsIfNeeded()
		{
		}

		[Token(Token = "0x60019BC")]
		[Address(RVA = "0x3E99018", Offset = "0x3E95018", VA = "0x3E99018", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__23))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x60019BD")]
		[Address(RVA = "0x3E990B0", Offset = "0x3E950B0", VA = "0x3E990B0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60019BE")]
		[Address(RVA = "0x3E99668", Offset = "0x3E95668", VA = "0x3E99668")]
		private void OnRewardPanelClosed(object unused)
		{
		}

		[Token(Token = "0x60019BF")]
		[Address(RVA = "0x3E998C8", Offset = "0x3E958C8", VA = "0x3E998C8")]
		public MysteryAdventureCellConfig GetCellConfig(int cellId)
		{
			return null;
		}

		[Token(Token = "0x60019C0")]
		[Address(RVA = "0x3E99970", Offset = "0x3E95970", VA = "0x3E99970")]
		public bool IsActivityActive()
		{
			return default;
		}

		[Token(Token = "0x60019C1")]
		[Address(RVA = "0x3E999FC", Offset = "0x3E959FC", VA = "0x3E999FC")]
		public bool IsActivityEnded()
		{
			return default;
		}

		[Token(Token = "0x60019C2")]
		[Address(RVA = "0x3E99C04", Offset = "0x3E95C04", VA = "0x3E99C04")]
		private MysteryAdventureOnlineActivityWindow GetCurrentActivityWindow()
		{
			return default;
		}

		[Token(Token = "0x60019C3")]
		[Address(RVA = "0x3E99CAC", Offset = "0x3E95CAC", VA = "0x3E99CAC")]
		private bool IsDailyRefreshAllowed()
		{
			return default;
		}

		[Token(Token = "0x60019C4")]
		[Address(RVA = "0x3E99D18", Offset = "0x3E95D18", VA = "0x3E99D18")]
		private DateTime GetLiveActivityEndTime()
		{
			return default;
		}

		[Token(Token = "0x60019C5")]
		[Address(RVA = "0x3E99D60", Offset = "0x3E95D60", VA = "0x3E99D60")]
		public bool ShouldShowEntryButton()
		{
			return default;
		}

		[Token(Token = "0x60019C6")]
		[Address(RVA = "0x3E99D7C", Offset = "0x3E95D7C", VA = "0x3E99D7C")]
		public string GetActivityCountdownStr()
		{
			return null;
		}

		[Token(Token = "0x60019C7")]
		[Address(RVA = "0x3E99F2C", Offset = "0x3E95F2C", VA = "0x3E99F2C")]
		public string GetActivityEntryCountdownStr()
		{
			return null;
		}

		[Token(Token = "0x60019C8")]
		[Address(RVA = "0x3E9A0B4", Offset = "0x3E960B4", VA = "0x3E9A0B4")]
		public string GetDiceRecoverCountdownStr()
		{
			return null;
		}

		[Token(Token = "0x60019C9")]
		[Address(RVA = "0x3E9A26C", Offset = "0x3E9626C", VA = "0x3E9A26C")]
		public string GetDiceCountDisplayText()
		{
			return null;
		}

		[Token(Token = "0x60019CA")]
		[Address(RVA = "0x3E9A2B0", Offset = "0x3E962B0", VA = "0x3E9A2B0")]
		public string GetDiceCountFooterDisplayText()
		{
			return null;
		}

		[Token(Token = "0x60019CB")]
		[Address(RVA = "0x3E9A28C", Offset = "0x3E9628C", VA = "0x3E9A28C")]
		public int GetDiceCount()
		{
			return default;
		}

		[Token(Token = "0x60019CC")]
		[Address(RVA = "0x3E9A598", Offset = "0x3E96598", VA = "0x3E9A598")]
		[AsyncStateMachine(typeof(_003CShowActivityPanel_003Ed__39))]
		public UniTask ShowActivityPanel(string enterWay = "button")
		{
			return default;
		}

		[Token(Token = "0x60019CD")]
		[Address(RVA = "0x3E98F78", Offset = "0x3E94F78", VA = "0x3E98F78")]
		[AsyncStateMachine(typeof(_003CEnsureActivityAssetsPreloadedAsync_003Ed__40))]
		private UniTask EnsureActivityAssetsPreloadedAsync()
		{
			return default;
		}

		[Token(Token = "0x60019CE")]
		[Address(RVA = "0x3E9A640", Offset = "0x3E96640", VA = "0x3E9A640")]
		public string GetBoardSummaryText()
		{
			return null;
		}

		[Token(Token = "0x60019CF")]
		[Address(RVA = "0x3E9A888", Offset = "0x3E96888", VA = "0x3E9A888")]
		private void EnsureData()
		{
		}

		[Token(Token = "0x60019D0")]
		[Address(RVA = "0x3E9AE98", Offset = "0x3E96E98", VA = "0x3E9AE98")]
		public void SetBatchRollUiRefresh(bool enabled)
		{
		}

		[Token(Token = "0x60019D1")]
		[Address(RVA = "0x3E9AEA4", Offset = "0x3E96EA4", VA = "0x3E9AEA4")]
		private void QueuePanelRefresh(MysteryAdventurePanelRefreshScope scope)
		{
		}

		[Token(Token = "0x60019D2")]
		[Address(RVA = "0x3E99740", Offset = "0x3E95740", VA = "0x3E99740")]
		private void RefreshPanelIfShowing(MysteryAdventurePanelRefreshScope scope = MysteryAdventurePanelRefreshScope.AfterRollComplete)
		{
		}

		[Token(Token = "0x60019D3")]
		[Address(RVA = "0x3E9AEB8", Offset = "0x3E96EB8", VA = "0x3E9AEB8")]
		private void UpdateRuntimeEntryRedDot()
		{
		}

		[Token(Token = "0x60019D4")]
		[Address(RVA = "0x3E9AFCC", Offset = "0x3E96FCC", VA = "0x3E9AFCC")]
		private void CreateRuntimeEntryButton()
		{
		}

		[Token(Token = "0x60019D5")]
		[Address(RVA = "0x3E9AFEC", Offset = "0x3E96FEC", VA = "0x3E9AFEC")]
		[AsyncStateMachine(typeof(_003CCreateRuntimeEntryButtonAsync_003Ed__48))]
		private UniTaskVoid CreateRuntimeEntryButtonAsync()
		{
			return default;
		}

		[Token(Token = "0x60019D6")]
		[Address(RVA = "0x3E9B068", Offset = "0x3E97068", VA = "0x3E9B068")]
		private void SetupRuntimeEntryButton(GiftBtn giftBtn)
		{
		}

		[Token(Token = "0x60019D7")]
		[Address(RVA = "0x3E9B3BC", Offset = "0x3E973BC", VA = "0x3E9B3BC")]
		private void OnRuntimeEntryButtonClicked()
		{
		}

		[Token(Token = "0x60019D8")]
		[Address(RVA = "0x3E9B434", Offset = "0x3E97434", VA = "0x3E9B434")]
		[AsyncStateMachine(typeof(_003COpenActivityPanelAsync_003Ed__51))]
		private UniTaskVoid OpenActivityPanelAsync()
		{
			return default;
		}

		[Token(Token = "0x60019D9")]
		[Address(RVA = "0x3E9B1C0", Offset = "0x3E971C0", VA = "0x3E9B1C0")]
		private static void ConfigureGiftBtnRaycast(GiftBtn giftBtn)
		{
		}

		[Token(Token = "0x60019DA")]
		[Address(RVA = "0x3E9B4AC", Offset = "0x3E974AC", VA = "0x3E9B4AC")]
		private void UpdateRuntimeEntryButton(float _)
		{
		}

		[Token(Token = "0x60019DB")]
		[Address(RVA = "0x3E9B5EC", Offset = "0x3E975EC", VA = "0x3E9B5EC")]
		private void UpdateRuntimeEntryButtonVisibility()
		{
		}

		[Token(Token = "0x60019DC")]
		[Address(RVA = "0x3E9B744", Offset = "0x3E97744", VA = "0x3E9B744")]
		public IReadOnlyList<MysteryAdventureDailyTaskRecord> GetDailyTaskRecords()
		{
			return null;
		}

		[Token(Token = "0x60019DD")]
		[Address(RVA = "0x3E9B7F4", Offset = "0x3E977F4", VA = "0x3E9B7F4")]
		public MysteryAdventureDailyTaskRecord GetDailyTaskRecord(int configId)
		{
			return null;
		}

		[Token(Token = "0x60019DE")]
		[Address(RVA = "0x3E9B8EC", Offset = "0x3E978EC", VA = "0x3E9B8EC")]
		public string GetDailyRefreshCountdownStr()
		{
			return null;
		}

		[Token(Token = "0x60019DF")]
		[Address(RVA = "0x3E9B988", Offset = "0x3E97988", VA = "0x3E9B988")]
		public string GetDailyTaskRefreshCountdownStr()
		{
			return null;
		}

		[Token(Token = "0x60019E0")]
		[Address(RVA = "0x3E9B98C", Offset = "0x3E9798C", VA = "0x3E9B98C")]
		public void EnsureDailyRefreshData()
		{
		}

		[Token(Token = "0x60019E1")]
		[Address(RVA = "0x3E9BAFC", Offset = "0x3E97AFC", VA = "0x3E9BAFC")]
		public bool HasClaimableDailyTaskReward()
		{
			return default;
		}

		[Token(Token = "0x60019E2")]
		[Address(RVA = "0x3E9BC84", Offset = "0x3E97C84", VA = "0x3E9BC84")]
		public string GetDailyGiftPlacement()
		{
			return null;
		}

		[Token(Token = "0x60019E3")]
		[Address(RVA = "0x3E9BCC4", Offset = "0x3E97CC4", VA = "0x3E9BCC4")]
		public int GetDailyGiftBoughtCount(int configId)
		{
			return default;
		}

		[Token(Token = "0x60019E4")]
		[Address(RVA = "0x3E9BD04", Offset = "0x3E97D04", VA = "0x3E9BD04")]
		public bool HasClaimableDailyGift()
		{
			return default;
		}

		[Token(Token = "0x60019E5")]
		[Address(RVA = "0x3E9AF80", Offset = "0x3E96F80", VA = "0x3E9AF80")]
		public bool HasDailySideEntryRedDot()
		{
			return default;
		}

		[Token(Token = "0x60019E6")]
		[Address(RVA = "0x3E9BEBC", Offset = "0x3E97EBC", VA = "0x3E9BEBC")]
		public void OpenDailyGiftPageIfShowing()
		{
		}

		[Token(Token = "0x60019E7")]
		[Address(RVA = "0x3E9BE8C", Offset = "0x3E97E8C", VA = "0x3E9BE8C")]
		public int GetDailyGiftRemainCount(DailyPriceConfig config)
		{
			return default;
		}

		[Token(Token = "0x60019E8")]
		[Address(RVA = "0x3E9BF8C", Offset = "0x3E97F8C", VA = "0x3E9BF8C")]
		public bool TryClaimFreeDailyGift(int configId, out string errorMessage)
		{
			return default;
		}

		[Token(Token = "0x60019E9")]
		[Address(RVA = "0x3E9C2F0", Offset = "0x3E982F0", VA = "0x3E9C2F0")]
		public bool TryGrantPurchasedDailyGift(int configId, out string errorMessage)
		{
			return default;
		}

		[Token(Token = "0x60019EA")]
		[Address(RVA = "0x3E9C4B4", Offset = "0x3E984B4", VA = "0x3E9C4B4")]
		public void RecordDailyTaskItemCost(int itemId, int count)
		{
		}

		[Token(Token = "0x60019EB")]
		[Address(RVA = "0x3E9C720", Offset = "0x3E98720", VA = "0x3E9C720")]
		public void RecordDailyTaskItemCost(string itemId, int count)
		{
		}

		[Token(Token = "0x60019EC")]
		[Address(RVA = "0x3E9C774", Offset = "0x3E98774", VA = "0x3E9C774")]
		public void RecordDailyTaskBattleEnter(int count = 1)
		{
		}

		[Token(Token = "0x60019ED")]
		[Address(RVA = "0x3E9C78C", Offset = "0x3E9878C", VA = "0x3E9C78C")]
		public void RecordDailyTaskBattleWin(int count = 1)
		{
		}

		[Token(Token = "0x60019EE")]
		[Address(RVA = "0x3E9C4C8", Offset = "0x3E984C8", VA = "0x3E9C4C8")]
		public void RecordDailyTaskProgress(MysteryAdventureDailyTaskType taskType, int delta, int normalParam = 0, bool saveImmediately = true, bool refreshPanel = true)
		{
		}

		[Token(Token = "0x60019EF")]
		[Address(RVA = "0x3E9C7D4", Offset = "0x3E987D4", VA = "0x3E9C7D4")]
		public bool TryClaimDailyTaskReward(int configId, out string errorMessage)
		{
			return default;
		}

		[Token(Token = "0x60019F0")]
		[Address(RVA = "0x3E9CB2C", Offset = "0x3E98B2C", VA = "0x3E9CB2C")]
		public void GmResetDailyTasks()
		{
		}

		[Token(Token = "0x60019F1")]
		[Address(RVA = "0x3E9CDE0", Offset = "0x3E98DE0", VA = "0x3E9CDE0")]
		public void GmAddDailyTaskProgress(int taskType, int delta, int normalParam = 0)
		{
		}

		[Token(Token = "0x60019F2")]
		[Address(RVA = "0x3E9B768", Offset = "0x3E97768", VA = "0x3E9B768")]
		private void EnsureDailyTaskData()
		{
		}

		[Token(Token = "0x60019F3")]
		[Address(RVA = "0x3E9B9A4", Offset = "0x3E979A4", VA = "0x3E9B9A4")]
		private void EnsureDailyGiftData()
		{
		}

		[Token(Token = "0x60019F4")]
		[Address(RVA = "0x3E9CEE4", Offset = "0x3E98EE4", VA = "0x3E9CEE4")]
		private static bool ShouldResetDailyDataForDateChange(string storedDateKey, string newDateKey)
		{
			return default;
		}

		[Token(Token = "0x60019F5")]
		[Address(RVA = "0x3E9D3AC", Offset = "0x3E993AC", VA = "0x3E9D3AC")]
		private static bool TryParseDateKey(string dateKey, out DateTime date)
		{
			return default;
		}

		[Token(Token = "0x60019F6")]
		[Address(RVA = "0x3E9C2B0", Offset = "0x3E982B0", VA = "0x3E9C2B0")]
		private void MarkDailyGiftBought(int configId)
		{
		}

		[Token(Token = "0x60019F7")]
		[Address(RVA = "0x3E9D468", Offset = "0x3E99468", VA = "0x3E9D468")]
		private void RegisterDailyGiftIapListeners()
		{
		}

		[Token(Token = "0x60019F8")]
		[Address(RVA = "0x3E9D6A8", Offset = "0x3E996A8", VA = "0x3E9D6A8")]
		private void OnDailyGiftPurchaseComplete(string productId)
		{
		}

		[Token(Token = "0x60019F9")]
		[Address(RVA = "0x3E9D830", Offset = "0x3E99830", VA = "0x3E9D830")]
		private void RegisterDailyTaskEventListeners()
		{
		}

		[Token(Token = "0x60019FA")]
		[Address(RVA = "0x3E992CC", Offset = "0x3E952CC", VA = "0x3E992CC")]
		private void UnregisterDailyTaskEventListeners()
		{
		}

		[Token(Token = "0x60019FB")]
		[Address(RVA = "0x3E9DA38", Offset = "0x3E99A38", VA = "0x3E9DA38")]
		private void OnDailyTaskBattleEnter(object _)
		{
		}

		[Token(Token = "0x60019FC")]
		[Address(RVA = "0x3E9DA50", Offset = "0x3E99A50", VA = "0x3E9DA50")]
		private void OnDailyTaskBattleWin(object _)
		{
		}

		[Token(Token = "0x60019FD")]
		[Address(RVA = "0x3E9DA68", Offset = "0x3E99A68", VA = "0x3E9DA68")]
		private void OnDailyTaskItemCost(object arg)
		{
		}

		[Token(Token = "0x60019FE")]
		[Address(RVA = "0x3E9DB20", Offset = "0x3E99B20", VA = "0x3E9DB20")]
		private static bool TryGetInt(object value, out int result)
		{
			return default;
		}

		[Token(Token = "0x60019FF")]
		[Address(RVA = "0x3E9CB74", Offset = "0x3E98B74", VA = "0x3E9CB74")]
		private void ResetDailyTasksForToday()
		{
		}

		[Token(Token = "0x6001A00")]
		[Address(RVA = "0x3E9CFC0", Offset = "0x3E98FC0", VA = "0x3E9CFC0")]
		private void SyncDailyTaskRecordsWithConfig()
		{
		}

		[Token(Token = "0x6001A01")]
		[Address(RVA = "0x3E9C7A4", Offset = "0x3E987A4", VA = "0x3E9C7A4")]
		private void SaveDailyTaskData()
		{
		}

		[Token(Token = "0x6001A02")]
		[Address(RVA = "0x3E9B81C", Offset = "0x3E9781C", VA = "0x3E9B81C")]
		private MysteryAdventureDailyTaskRecord FindDailyTaskRecord(int configId)
		{
			return null;
		}

		[Token(Token = "0x6001A03")]
		[Address(RVA = "0x3E9C9D4", Offset = "0x3E989D4", VA = "0x3E9C9D4")]
		private static bool TryBuildValidDailyTaskReward(string rewardRaw, out RewardConfig rewardConfig, out string errorMessage)
		{
			return default;
		}

		[Token(Token = "0x6001A04")]
		[Address(RVA = "0x3E9C150", Offset = "0x3E98150", VA = "0x3E9C150")]
		private static bool TryBuildValidDailyGiftReward(DailyPriceConfig config, out RewardConfig rewardConfig, out string errorMessage)
		{
			return default;
		}

		[Token(Token = "0x6001A05")]
		[Address(RVA = "0x3E9CE2C", Offset = "0x3E98E2C", VA = "0x3E9CE2C")]
		private string GetDailyTaskDateKey()
		{
			return null;
		}

		[Token(Token = "0x6001A06")]
		[Address(RVA = "0x3E9DC18", Offset = "0x3E99C18", VA = "0x3E9DC18")]
		private void OnDailyRefreshAtServerMidnight()
		{
		}

		[Token(Token = "0x6001A07")]
		[Address(RVA = "0x3E9DC50", Offset = "0x3E99C50", VA = "0x3E9DC50")]
		public void TryEnqueueLoginFaceSlapPopup(int packIndex)
		{
		}

		[Token(Token = "0x6001A08")]
		[Address(RVA = "0x3E9DDBC", Offset = "0x3E99DBC", VA = "0x3E9DDBC")]
		public bool ShouldShowLoginFaceSlap()
		{
			return default;
		}

		[Token(Token = "0x6001A09")]
		[Address(RVA = "0x3E9DF08", Offset = "0x3E99F08", VA = "0x3E9DF08")]
		public void PersistLoginFaceSlapDismissIfNeeded(bool dontShowToday)
		{
		}

		[Token(Token = "0x6001A0A")]
		[Address(RVA = "0x3E9DE50", Offset = "0x3E99E50", VA = "0x3E9DE50")]
		private string GetFaceSlapDateKey()
		{
			return null;
		}

		[Token(Token = "0x6001A0B")]
		[Address(RVA = "0x3E9DF48", Offset = "0x3E99F48", VA = "0x3E9DF48")]
		public void SetGmForceOpenActivity(bool enabled)
		{
		}

		[Token(Token = "0x6001A0C")]
		[Address(RVA = "0x3E9E044", Offset = "0x3E9A044", VA = "0x3E9E044")]
		public void SetGmTestMode(bool enabled)
		{
		}

		[Token(Token = "0x6001A0D")]
		[Address(RVA = "0x3E9DF8C", Offset = "0x3E99F8C", VA = "0x3E9DF8C")]
		private void RefreshGmActivityEntryState()
		{
		}

		[Token(Token = "0x6001A0E")]
		[Address(RVA = "0x3E9CB54", Offset = "0x3E98B54", VA = "0x3E9CB54")]
		public void EnsureGmTestContext(bool enableTestMode = true)
		{
		}

		[Token(Token = "0x6001A0F")]
		[Address(RVA = "0x3E9E138", Offset = "0x3E9A138", VA = "0x3E9E138")]
		public void GmClearSave()
		{
		}

		[Token(Token = "0x6001A10")]
		[Address(RVA = "0x3E9E258", Offset = "0x3E9A258", VA = "0x3E9E258")]
		public void GmClearLapRewardProgress()
		{
		}

		[Token(Token = "0x6001A11")]
		[Address(RVA = "0x3E9E2A8", Offset = "0x3E9A2A8", VA = "0x3E9E2A8")]
		public void GmSetFixedDiceValue(int value)
		{
		}

		[Token(Token = "0x6001A12")]
		[Address(RVA = "0x3E9E2C4", Offset = "0x3E9A2C4", VA = "0x3E9E2C4")]
		public void GmClearFixedDiceValue()
		{
		}

		[Token(Token = "0x6001A14")]
		[Address(RVA = "0x3E9E2D8", Offset = "0x3E9A2D8", VA = "0x3E9E2D8")]
		public void GmFillDice(int count = -1)
		{
		}

		[Token(Token = "0x6001A15")]
		[Address(RVA = "0x3E9E368", Offset = "0x3E9A368", VA = "0x3E9E368")]
		public void GmAddDice(int amount)
		{
		}

		[Token(Token = "0x6001A16")]
		[Address(RVA = "0x3E9E3CC", Offset = "0x3E9A3CC", VA = "0x3E9E3CC")]
		public void GmResetActivity()
		{
		}

		[Token(Token = "0x6001A17")]
		[Address(RVA = "0x3E9E53C", Offset = "0x3E9A53C", VA = "0x3E9E53C")]
		public bool TryGmGrantChestPoolReward(bool deluxe, out string errorMessage, out string rewardRaw)
		{
			return default;
		}

		[Token(Token = "0x6001A18")]
		[Address(RVA = "0x3E9E6B8", Offset = "0x3E9A6B8", VA = "0x3E9E6B8")]
		public bool TryGmGrantBuildPoolReward(int buildId, out string errorMessage, out string rewardRaw)
		{
			return default;
		}

		[Token(Token = "0x6001A19")]
		[Address(RVA = "0x3E9E5CC", Offset = "0x3E9A5CC", VA = "0x3E9E5CC")]
		private bool TryGmGrantBuildPoolReward(int buildId, string missingConfigMessage, out string errorMessage, out string rewardRaw)
		{
			return default;
		}

		[Token(Token = "0x6001A1A")]
		[Address(RVA = "0x3E9E728", Offset = "0x3E9A728", VA = "0x3E9E728")]
		public bool TryGmGrantPoolReward(int poolId, out string errorMessage, out string rewardRaw)
		{
			return default;
		}

		[Token(Token = "0x6001A1B")]
		[Address(RVA = "0x3E9E824", Offset = "0x3E9A824", VA = "0x3E9E824")]
		private static bool ShouldInitNewActivitySave(PlayerMysteryAdventureData data)
		{
			return default;
		}

		[Token(Token = "0x6001A1C")]
		[Address(RVA = "0x3E9E8BC", Offset = "0x3E9A8BC", VA = "0x3E9E8BC")]
		private void UnlockGmActivityWithoutReset(PlayerMysteryAdventureData data, DateTime now, int initialDiceCount)
		{
		}

		[Token(Token = "0x6001A1D")]
		[Address(RVA = "0x3E9AC90", Offset = "0x3E96C90", VA = "0x3E9AC90")]
		private void ApplyGmForceOpenActivityState()
		{
		}

		[Token(Token = "0x6001A1E")]
		[Address(RVA = "0x3E9A9D8", Offset = "0x3E969D8", VA = "0x3E9A9D8")]
		private void ApplyGmTestModeState()
		{
		}

		[Token(Token = "0x6001A1F")]
		[Address(RVA = "0x3E9A8E4", Offset = "0x3E968E4", VA = "0x3E9A8E4")]
		private void SyncActivityDataWithOnlineParams()
		{
		}

		[Token(Token = "0x6001A20")]
		[Address(RVA = "0x3E9EA0C", Offset = "0x3E9AA0C", VA = "0x3E9EA0C")]
		private static string BuildOnlineParamSyncKey(MysteryAdventureOnlineActivityWindow window)
		{
			return null;
		}

		[Token(Token = "0x6001A21")]
		[Address(RVA = "0x3E9EC5C", Offset = "0x3E9AC5C", VA = "0x3E9EC5C")]
		private bool ApplyOnlineParamSync(MysteryAdventureOnlineActivityWindow window)
		{
			return default;
		}

		[Token(Token = "0x6001A22")]
		[Address(RVA = "0x3E9A380", Offset = "0x3E96380", VA = "0x3E9A380")]
		public void RefreshDiceRecovery()
		{
		}

		[Token(Token = "0x6001A23")]
		[Address(RVA = "0x3E9EEB0", Offset = "0x3E9AEB0", VA = "0x3E9EEB0")]
		private void ResetDiceRecoverTimeIfDroppedBelowCap(PlayerMysteryAdventureData data, int countBefore, int countAfter)
		{
		}

		[Token(Token = "0x6001A24")]
		[Address(RVA = "0x3E9EF60", Offset = "0x3E9AF60", VA = "0x3E9EF60")]
		public MysteryAdventureRollResult TryRollDice()
		{
			return null;
		}

		[Token(Token = "0x6001A25")]
		[Address(RVA = "0x3EA0420", Offset = "0x3E9C420", VA = "0x3EA0420")]
		[AsyncStateMachine(typeof(_003CShowRollRewardsAsync_003Ed__131))]
		public UniTask ShowRollRewardsAsync(MysteryAdventureRollResult result, UnityEngine.Vector3 flyStartWorldPos, bool awaitDiceGrant = false)
		{
			return default;
		}

		[Token(Token = "0x6001A26")]
		[Address(RVA = "0x3EA04F8", Offset = "0x3E9C4F8", VA = "0x3EA04F8")]
		private static bool ShouldForceRewardPanelForStopBuild(int buildId)
		{
			return default;
		}

		[Token(Token = "0x6001A27")]
		[Address(RVA = "0x3EA0508", Offset = "0x3E9C508", VA = "0x3EA0508")]
		public void ReportFinalStopCellIfNeeded(MysteryAdventureRollResult result)
		{
		}

		[Token(Token = "0x6001A28")]
		[Address(RVA = "0x3EA0510", Offset = "0x3E9C510", VA = "0x3EA0510")]
		private static void ReportStopCellRewards(MysteryAdventureRollResult result)
		{
		}

		[Token(Token = "0x6001A29")]
		[Address(RVA = "0x3EA05F0", Offset = "0x3E9C5F0", VA = "0x3EA05F0")]
		[AsyncStateMachine(typeof(_003CTryGrantMysteryAdventureRewardAsync_003Ed__135))]
		private static UniTask TryGrantMysteryAdventureRewardAsync(string rewardRaw, CurrencyTransactionSceneType sceneType, [Optional] UnityEngine.Vector3 flyStartWorldPos, bool awaitDiceGrant = false, bool forceRewardPanel = false)
		{
			return default;
		}

		[Token(Token = "0x6001A2A")]
		[Address(RVA = "0x3E9E808", Offset = "0x3E9A808", VA = "0x3E9E808")]
		private static void TryGrantMysteryAdventureReward(string rewardRaw, CurrencyTransactionSceneType sceneType, [Optional] UnityEngine.Vector3 flyStartWorldPos)
		{
		}

		[Token(Token = "0x6001A2B")]
		[Address(RVA = "0x3EA06E0", Offset = "0x3E9C6E0", VA = "0x3EA06E0")]
		[AsyncStateMachine(typeof(_003CShowLapRewardAndWaitAsync_003Ed__137))]
		public UniTask ShowLapRewardAndWaitAsync(string lapRewardRaw, [Optional][DefaultParameterValue(false)] bool autoCloseForAutoRoll, [Optional][DefaultParameterValue(0.5f)] float autoCloseDelaySeconds, [Optional] UnityEngine.Vector3 flyStartWorldPos, int lapReportLevel = 0, int lapReportLapCount = 0, int lapReportMultiplier = 1)
		{
			return default;
		}

		[Token(Token = "0x6001A2C")]
		[Address(RVA = "0x3EA07E4", Offset = "0x3E9C7E4", VA = "0x3EA07E4")]
		[AsyncStateMachine(typeof(_003CAutoCloseRewardPanelIfShowingAsync_003Ed__138))]
		public UniTask AutoCloseRewardPanelIfShowingAsync(float closeDelaySeconds, float waitShowTimeoutSeconds = 1.5f)
		{
			return default;
		}

		[Token(Token = "0x6001A2D")]
		[Address(RVA = "0x3EA088C", Offset = "0x3E9C88C", VA = "0x3EA088C")]
		private static bool HasAutoCloseBlockingPanels()
		{
			return default;
		}

		[Token(Token = "0x6001A2E")]
		[Address(RVA = "0x3EA09CC", Offset = "0x3E9C9CC", VA = "0x3EA09CC")]
		[AsyncStateMachine(typeof(_003CWaitForNextGetNewCardPanelAsync_003Ed__140))]
		private static UniTask<bool> WaitForNextGetNewCardPanelAsync(float graceSeconds)
		{
			return default;
		}

		[Token(Token = "0x6001A2F")]
		[Address(RVA = "0x3EA0A94", Offset = "0x3E9CA94", VA = "0x3EA0A94")]
		[AsyncStateMachine(typeof(_003CAutoCloseGetNewCardPanelAsync_003Ed__141))]
		private static UniTask AutoCloseGetNewCardPanelAsync(float closeDelaySeconds)
		{
			return default;
		}

		[Token(Token = "0x6001A30")]
		[Address(RVA = "0x3EA0B34", Offset = "0x3E9CB34", VA = "0x3EA0B34")]
		[AsyncStateMachine(typeof(_003CAutoCloseOpenBoxAnimationPanelAsync_003Ed__142))]
		private static UniTask AutoCloseOpenBoxAnimationPanelAsync(OpenBoxAnimationPanel openBoxPanel, float closeDelaySeconds)
		{
			return default;
		}

		[Token(Token = "0x6001A31")]
		[Address(RVA = "0x3EA0BDC", Offset = "0x3E9CBDC", VA = "0x3EA0BDC")]
		private static void TryShowRollRewardPanel(string rewardRaw, CurrencyTransactionSceneType sceneType)
		{
		}

		[Token(Token = "0x6001A32")]
		[Address(RVA = "0x3EA0DE8", Offset = "0x3E9CDE8", VA = "0x3EA0DE8")]
		private static void ReplaceMysteryAdventureRandomCardPoolRewards(RewardConfig rewardConfig)
		{
		}

		[Token(Token = "0x6001A33")]
		[Address(RVA = "0x3EA1144", Offset = "0x3E9D144", VA = "0x3EA1144")]
		private static List<UserHeroCardData> DrawMysteryAdventureRandomCards(GlobalRandomHeroCardInfo randomCardConfig, BigInteger count)
		{
			return null;
		}

		[Token(Token = "0x6001A34")]
		[Address(RVA = "0x3EA161C", Offset = "0x3E9D61C", VA = "0x3EA161C")]
		private static string SelectMysteryAdventureRandomCardRarity(Dictionary<string, int> rarityProbabilities)
		{
			return null;
		}

		[Token(Token = "0x6001A35")]
		[Address(RVA = "0x3EA17F0", Offset = "0x3E9D7F0", VA = "0x3EA17F0")]
		public void SetGrantDiceSourceOverride(int source)
		{
		}

		[Token(Token = "0x6001A36")]
		[Address(RVA = "0x3EA17F8", Offset = "0x3E9D7F8", VA = "0x3EA17F8")]
		public void ClearGrantDiceSourceOverride()
		{
		}

		[Token(Token = "0x6001A37")]
		[Address(RVA = "0x3E98D50", Offset = "0x3E94D50", VA = "0x3E98D50")]
		public int GrantDice(int grantCount, int getDiceSource = 4)
		{
			return default;
		}

		[Token(Token = "0x6001A38")]
		[Address(RVA = "0x3EA1800", Offset = "0x3E9D800", VA = "0x3EA1800")]
		[AsyncStateMachine(typeof(_003CShowDiceCollectFlyAsync_003Ed__152))]
		public UniTask ShowDiceCollectFlyAsync(int grantCount, UnityEngine.Vector3 startWorldPos)
		{
			return default;
		}

		[Token(Token = "0x6001A39")]
		[Address(RVA = "0x3EA18CC", Offset = "0x3E9D8CC", VA = "0x3EA18CC")]
		[AsyncStateMachine(typeof(_003CShowRuinsRoadsideDiceRewardPanelAsync_003Ed__153))]
		public UniTask ShowRuinsRoadsideDiceRewardPanelAsync(int grantCount, bool autoCloseForAutoRoll = false, float autoCloseDelaySeconds = 0.5f)
		{
			return default;
		}

		[Token(Token = "0x6001A3A")]
		[Address(RVA = "0x3E9F6C8", Offset = "0x3E9B6C8", VA = "0x3E9F6C8")]
		private List<int> BuildMovePath(int fromCellId, int steps)
		{
			return null;
		}

		[Token(Token = "0x6001A3B")]
		[Address(RVA = "0x3EA19A8", Offset = "0x3E9D9A8", VA = "0x3EA19A8")]
		private List<int> BuildBackwardPath(int fromCellId, int steps)
		{
			return null;
		}

		[Token(Token = "0x6001A3C")]
		[Address(RVA = "0x3EA1994", Offset = "0x3E9D994", VA = "0x3EA1994")]
		private static int GetNextCellId(int cellId)
		{
			return default;
		}

		[Token(Token = "0x6001A3D")]
		[Address(RVA = "0x3EA1AB4", Offset = "0x3E9DAB4", VA = "0x3EA1AB4")]
		private static int GetPreviousCellId(int cellId)
		{
			return default;
		}

		[Token(Token = "0x6001A3E")]
		[Address(RVA = "0x3E9F7D4", Offset = "0x3E9B7D4", VA = "0x3E9F7D4")]
		private void AppendMoveSegmentsWithLapPauses(int fromCellId, IReadOnlyList<int> path, StringBuilder lapRewardBuilder, MysteryAdventureRollResult result, PlayerMysteryAdventureData data, List<MysteryAdventureMoveSegment> targetSegments, int lapRewardMultiplier, [Optional] string statusHint)
		{
		}

		[Token(Token = "0x6001A3F")]
		[Address(RVA = "0x3E9FDE0", Offset = "0x3E9BDE0", VA = "0x3E9FDE0")]
		private int ResolveStopCellChain(int cellId, StringBuilder stopRewardBuilder, StringBuilder lapRewardBuilder, MysteryAdventureRollResult result, PlayerMysteryAdventureData data, int depth, int stopRewardMultiplier, int lapRewardMultiplier)
		{
			return default;
		}

		[Token(Token = "0x6001A40")]
		[Address(RVA = "0x3EA1BBC", Offset = "0x3E9DBBC", VA = "0x3EA1BBC")]
		private static void ReportBoardCellFromStopContext(int cellId, int buildId, string rewardRaw, int lapCount, int rewardMultiplier)
		{
		}

		[Token(Token = "0x6001A41")]
		[Address(RVA = "0x3EA1DF0", Offset = "0x3E9DDF0", VA = "0x3EA1DF0")]
		private static void MarkPendingInteraction(MysteryAdventureRollResult result, string message)
		{
		}

		[Token(Token = "0x6001A42")]
		[Address(RVA = "0x3EA1B38", Offset = "0x3E9DB38", VA = "0x3EA1B38")]
		private static string ApplyStopPoolReward(MysteryAdventureCellConfig cell, int lapExp)
		{
			return null;
		}

		[Token(Token = "0x6001A43")]
		[Address(RVA = "0x3EA1AC8", Offset = "0x3E9DAC8", VA = "0x3EA1AC8")]
		private static void AppendReward(StringBuilder sb, string reward)
		{
		}

		[Token(Token = "0x6001A44")]
		[Address(RVA = "0x3EA02BC", Offset = "0x3E9C2BC", VA = "0x3EA02BC")]
		private static List<string> ParseRewardStrings(string rewardStr)
		{
			return null;
		}

		[Token(Token = "0x6001A45")]
		[Address(RVA = "0x3EA1D2C", Offset = "0x3E9DD2C", VA = "0x3EA1D2C")]
		private void TryTriggerRuinsEvent(MysteryAdventureRollResult result, PlayerMysteryAdventureData data)
		{
		}

		[Token(Token = "0x6001A46")]
		[Address(RVA = "0x3EA1EB0", Offset = "0x3E9DEB0", VA = "0x3EA1EB0")]
		public bool HasPendingRuinsEvent()
		{
			return default;
		}

		[Token(Token = "0x6001A47")]
		[Address(RVA = "0x3EA1EC0", Offset = "0x3E9DEC0", VA = "0x3EA1EC0")]
		public void DiscardInterruptedRuinsSession()
		{
		}

		[Token(Token = "0x6001A48")]
		[Address(RVA = "0x3EA2004", Offset = "0x3E9E004", VA = "0x3EA2004")]
		public bool HasPendingRuinsBanditBattle()
		{
			return default;
		}

		[Token(Token = "0x6001A49")]
		[Address(RVA = "0x3EA2024", Offset = "0x3E9E024", VA = "0x3EA2024")]
		public bool HasPendingRuinsBanditClaimReward()
		{
			return default;
		}

		[Token(Token = "0x6001A4A")]
		[Address(RVA = "0x3EA2044", Offset = "0x3E9E044", VA = "0x3EA2044")]
		public bool ShouldRestoreRuinsBanditPanel()
		{
			return default;
		}

		[Token(Token = "0x6001A4B")]
		[Address(RVA = "0x3EA2080", Offset = "0x3E9E080", VA = "0x3EA2080")]
		public bool TryStartRuinsBanditBattle(out string errorMessage)
		{
			return default;
		}

		[Token(Token = "0x6001A4C")]
		[Address(RVA = "0x3EA21B0", Offset = "0x3E9E1B0", VA = "0x3EA21B0")]
		public void CompleteRuinsBanditRuinsPanel()
		{
		}

		[Token(Token = "0x6001A4D")]
		[Address(RVA = "0x3EA21EC", Offset = "0x3E9E1EC", VA = "0x3EA21EC")]
		[AsyncStateMachine(typeof(_003CTryAutoStartBanditBattleMatchAsync_003Ed__182))]
		public UniTask TryAutoStartBanditBattleMatchAsync()
		{
			return default;
		}

		[Token(Token = "0x6001A4E")]
		[Address(RVA = "0x3EA2284", Offset = "0x3E9E284", VA = "0x3EA2284")]
		public bool TryClaimPendingRuinsBanditReward()
		{
			return default;
		}

		[Token(Token = "0x6001A4F")]
		[Address(RVA = "0x3EA24A0", Offset = "0x3E9E4A0", VA = "0x3EA24A0")]
		public RuinsConfigConfig GetPendingRuinsConfig()
		{
			return null;
		}

		[Token(Token = "0x6001A50")]
		[Address(RVA = "0x3EA24A8", Offset = "0x3E9E4A8", VA = "0x3EA24A8")]
		public string GetPendingRuinsRandomRewardRaw()
		{
			return null;
		}

		[Token(Token = "0x6001A51")]
		[Address(RVA = "0x3EA24B0", Offset = "0x3E9E4B0", VA = "0x3EA24B0")]
		public string GetPendingRuinsRandomRewardPreviewRaw()
		{
			return null;
		}

		[Token(Token = "0x6001A52")]
		[Address(RVA = "0x3EA2620", Offset = "0x3E9E620", VA = "0x3EA2620")]
		public bool TryGetPendingRuinsBlackHoleMove(out bool forward, out int steps)
		{
			return default;
		}

		[Token(Token = "0x6001A53")]
		[Address(RVA = "0x3EA2638", Offset = "0x3E9E638", VA = "0x3EA2638")]
		public bool TryGetRuinsBlackHoleMovePlan(out int fromCellId, out List<int> pathCellIds, out int toCellId)
		{
			return default;
		}

		[Token(Token = "0x6001A54")]
		[Address(RVA = "0x3EA27E4", Offset = "0x3E9E7E4", VA = "0x3EA27E4")]
		public bool TryGetRuinsBlackHoleMoveSegments(out int fromCellId, out List<MysteryAdventureMoveSegment> segments, out int toCellId)
		{
			return default;
		}

		[Token(Token = "0x6001A55")]
		[Address(RVA = "0x3EA2918", Offset = "0x3E9E918", VA = "0x3EA2918")]
		[AsyncStateMachine(typeof(_003CCompleteRuinsBlackHoleMoveAsync_003Ed__190))]
		public UniTask CompleteRuinsBlackHoleMoveAsync(UnityEngine.Vector3 flyStartWorldPos, bool awaitDiceGrant = false)
		{
			return default;
		}

		[Token(Token = "0x6001A56")]
		[Address(RVA = "0x3EA29E8", Offset = "0x3E9E9E8", VA = "0x3EA29E8")]
		[AsyncStateMachine(typeof(_003CShowRuinsEventPanelAsync_003Ed__191))]
		public UniTask ShowRuinsEventPanelAsync()
		{
			return default;
		}

		[Token(Token = "0x6001A57")]
		[Address(RVA = "0x3EA2A80", Offset = "0x3E9EA80", VA = "0x3EA2A80")]
		public int ResolveRuinsOption(int optionIndex)
		{
			return default;
		}

		[Token(Token = "0x6001A58")]
		[Address(RVA = "0x3EA2D60", Offset = "0x3E9ED60", VA = "0x3EA2D60")]
		public void ResolveRuinsRpsOption(int playerChoiceIndex, MysteryAdventureRpsOutcome outcome)
		{
		}

		[Token(Token = "0x6001A59")]
		[Address(RVA = "0x3EA2E68", Offset = "0x3E9EE68", VA = "0x3EA2E68")]
		[AsyncStateMachine(typeof(_003CGmOpenRuinsEventAsync_003Ed__194))]
		public UniTask<string> GmOpenRuinsEventAsync(int eventId = 0)
		{
			return default;
		}

		[Token(Token = "0x6001A5A")]
		[Address(RVA = "0x3EA2F50", Offset = "0x3E9EF50", VA = "0x3EA2F50")]
		public void GmCloseRuinsEvent()
		{
		}

		[Token(Token = "0x6001A5B")]
		[Address(RVA = "0x3EA1F34", Offset = "0x3E9DF34", VA = "0x3EA1F34")]
		private void CloseRuinsPanelIfShowing()
		{
		}

		[Token(Token = "0x6001A5C")]
		[Address(RVA = "0x3EA1E04", Offset = "0x3E9DE04", VA = "0x3EA1E04")]
		private void PreparePendingRuinsExtras(RuinsConfigConfig config)
		{
		}

		[Token(Token = "0x6001A5D")]
		[Address(RVA = "0x3EA2F84", Offset = "0x3E9EF84", VA = "0x3EA2F84")]
		private static int RollRuinsRoadsideDiceGrant()
		{
			return default;
		}

		[Token(Token = "0x6001A5E")]
		[Address(RVA = "0x3EA2F6C", Offset = "0x3E9EF6C", VA = "0x3EA2F6C")]
		private void ResetPendingRuinsExtras()
		{
		}

		[Token(Token = "0x6001A5F")]
		[Address(RVA = "0x3EA1F18", Offset = "0x3E9DF18", VA = "0x3EA1F18")]
		private void ClearPendingRuinsState()
		{
		}

		[Token(Token = "0x6001A60")]
		[Address(RVA = "0x3EA2A84", Offset = "0x3E9EA84", VA = "0x3EA2A84")]
		private int OnRuinsOptionSelected(int optionIndex)
		{
			return default;
		}

		[Token(Token = "0x6001A61")]
		[Address(RVA = "0x3EA2D64", Offset = "0x3E9ED64", VA = "0x3EA2D64")]
		private void OnRuinsRpsOptionSelected(int playerChoiceIndex, MysteryAdventureRpsOutcome outcome)
		{
		}

		[Token(Token = "0x6001A62")]
		[Address(RVA = "0x3EA2724", Offset = "0x3E9E724", VA = "0x3EA2724")]
		private bool TryBuildRuinsBlackHoleMovePath(PlayerMysteryAdventureData data, out List<int> path)
		{
			return default;
		}

		[Token(Token = "0x6001A63")]
		[Address(RVA = "0x3EA2600", Offset = "0x3E9E600", VA = "0x3EA2600")]
		public int GetPendingRuinsRewardMultiplier()
		{
			return default;
		}

		[Token(Token = "0x6001A64")]
		[Address(RVA = "0x3EA218C", Offset = "0x3E9E18C", VA = "0x3EA218C")]
		private string ScaleRuinsReward(string rewardRaw)
		{
			return null;
		}

		[Token(Token = "0x6001A65")]
		[Address(RVA = "0x3EA2F94", Offset = "0x3E9EF94", VA = "0x3EA2F94")]
		private int GetRuinsRoadsideDiceGrantCount()
		{
			return default;
		}

		[Token(Token = "0x6001A66")]
		[Address(RVA = "0x3EA2FC8", Offset = "0x3E9EFC8", VA = "0x3EA2FC8")]
		private void RegisterRuinsBanditBattleEventListeners()
		{
		}

		[Token(Token = "0x6001A67")]
		[Address(RVA = "0x3E994D0", Offset = "0x3E954D0", VA = "0x3E994D0")]
		private void UnregisterRuinsBanditBattleEventListeners()
		{
		}

		[Token(Token = "0x6001A68")]
		[Address(RVA = "0x3EA3164", Offset = "0x3E9F164", VA = "0x3EA3164")]
		private void OnRuinsBanditBattleRewardCalculated(object arg)
		{
		}

		[Token(Token = "0x6001A69")]
		[Address(RVA = "0x3EA32D4", Offset = "0x3E9F2D4", VA = "0x3EA32D4")]
		private void OnRuinsBanditBattleGameOver(object arg)
		{
		}

		[Token(Token = "0x6001A6A")]
		[Address(RVA = "0x3EA325C", Offset = "0x3E9F25C", VA = "0x3EA325C")]
		[AsyncStateMachine(typeof(_003CScheduleBanditBattleAutoReturnAsync_003Ed__211))]
		private UniTaskVoid ScheduleBanditBattleAutoReturnAsync()
		{
			return default;
		}

		[Token(Token = "0x6001A6B")]
		[Address(RVA = "0x3EA3308", Offset = "0x3E9F308", VA = "0x3EA3308")]
		[AsyncStateMachine(typeof(_003CReturnToMysteryAdventureAfterBanditBattleAsync_003Ed__212))]
		private UniTask ReturnToMysteryAdventureAfterBanditBattleAsync()
		{
			return default;
		}

		[Token(Token = "0x6001A6C")]
		[Address(RVA = "0x3EA33A4", Offset = "0x3E9F3A4", VA = "0x3EA33A4")]
		private static string ResolveBanditMatchArenaId()
		{
			return null;
		}

		[Token(Token = "0x6001A6D")]
		[Address(RVA = "0x3EA34A8", Offset = "0x3E9F4A8", VA = "0x3EA34A8")]
		private static UserArenaData FindArenaData(string arenaId)
		{
			return null;
		}

		[Token(Token = "0x6001A6E")]
		[Address(RVA = "0x3EA35C8", Offset = "0x3E9F5C8", VA = "0x3EA35C8")]
		private static void TriggerBanditArenaMatchStart(string arenaId)
		{
		}

		[Token(Token = "0x6001A6F")]
		[Address(RVA = "0x3EA3244", Offset = "0x3E9F244", VA = "0x3EA3244")]
		private static MysteryAdventureRpsOutcome ResolveRuinsBanditBattleOutcome(BattleResult battleResult)
		{
			return default;
		}

		[Token(Token = "0x6001A71")]
		[Address(RVA = "0x3E98DE0", Offset = "0x3E94DE0", VA = "0x3E98DE0")]
		public PlayerMysteryAdventureData GetData()
		{
			return null;
		}

		[Token(Token = "0x6001A72")]
		[Address(RVA = "0x3E9D334", Offset = "0x3E99334", VA = "0x3E9D334")]
		public void SaveMysteryAdventureData()
		{
		}

		[Token(Token = "0x6001A73")]
		[Address(RVA = "0x3E9E07C", Offset = "0x3E9A07C", VA = "0x3E9E07C")]
		private PlayerMysteryAdventureData EnsureSaveData()
		{
			return null;
		}

		[Token(Token = "0x6001A74")]
		[Address(RVA = "0x3E9EE1C", Offset = "0x3E9AE1C", VA = "0x3E9EE1C")]
		private PlayerMysteryAdventureData LoadOrCreateSaveData()
		{
			return null;
		}

		[Token(Token = "0x6001A75")]
		[Address(RVA = "0x3E9DC14", Offset = "0x3E99C14", VA = "0x3E9DC14")]
		private PlayerMysteryAdventureData GetOrCreateSaveData()
		{
			return null;
		}

		[Token(Token = "0x6001A78")]
		[Address(RVA = "0x3EA3B04", Offset = "0x3E9FB04", VA = "0x3EA3B04")]
		public void SetDiscountShopAccumulateOnly(bool accumulateOnly)
		{
		}

		[Token(Token = "0x6001A79")]
		[Address(RVA = "0x3EA3B10", Offset = "0x3E9FB10", VA = "0x3EA3B10")]
		public int GetDiscountShopVisitCount()
		{
			return default;
		}

		[Token(Token = "0x6001A7A")]
		[Address(RVA = "0x3EA3B28", Offset = "0x3E9FB28", VA = "0x3EA3B28")]
		public IReadOnlyList<int> GetCurrentDiscountShopItemIds()
		{
			return null;
		}

		[Token(Token = "0x6001A7B")]
		[Address(RVA = "0x3EA3BCC", Offset = "0x3E9FBCC", VA = "0x3EA3BCC")]
		public bool IsDiscountShopItemPurchased(int configId)
		{
			return default;
		}

		[Token(Token = "0x6001A7C")]
		[Address(RVA = "0x3EA3BF4", Offset = "0x3E9FBF4", VA = "0x3EA3BF4")]
		public void ClearPendingShopInteraction()
		{
		}

		[Token(Token = "0x6001A7D")]
		[Address(RVA = "0x3EA3BFC", Offset = "0x3E9FBFC", VA = "0x3EA3BFC")]
		public void BeginDiscountShopSession()
		{
		}

		[Token(Token = "0x6001A7E")]
		[Address(RVA = "0x3EA3C08", Offset = "0x3E9FC08", VA = "0x3EA3C08")]
		public void EndDiscountShopSession()
		{
		}

		[Token(Token = "0x6001A7F")]
		[Address(RVA = "0x3EA3C14", Offset = "0x3E9FC14", VA = "0x3EA3C14")]
		public bool EnsureDiscountShopItemsReady(out string errorMessage)
		{
			return default;
		}

		[Token(Token = "0x6001A80")]
		[Address(RVA = "0x3EA3CEC", Offset = "0x3E9FCEC", VA = "0x3EA3CEC")]
		public bool TryPrepareDiscountShopSession(bool consumeVisitCount, out string errorMessage)
		{
			return default;
		}

		[Token(Token = "0x6001A81")]
		[Address(RVA = "0x3EA3E44", Offset = "0x3E9FE44", VA = "0x3EA3E44")]
		public bool TryPurchaseDiscountShopItem(int configId, out string errorMessage)
		{
			return default;
		}

		[Token(Token = "0x6001A82")]
		[Address(RVA = "0x3EA1BE8", Offset = "0x3E9DBE8", VA = "0x3EA1BE8")]
		private void TryTriggerDiscountShopEvent(MysteryAdventureRollResult result, PlayerMysteryAdventureData data)
		{
		}

		[Token(Token = "0x6001A83")]
		[Address(RVA = "0x3EA40D8", Offset = "0x3EA00D8", VA = "0x3EA40D8")]
		public bool TryGmPrepareDiscountShop(out string errorMessage)
		{
			return default;
		}

		[Token(Token = "0x6001A84")]
		[Address(RVA = "0x3EA4120", Offset = "0x3EA0120", VA = "0x3EA4120")]
		public bool TryGmRerollDiscountShop(out string errorMessage)
		{
			return default;
		}

		[Token(Token = "0x6001A85")]
		[Address(RVA = "0x3EA4210", Offset = "0x3EA0210", VA = "0x3EA4210")]
		public void GmClearDiscountShopPurchases()
		{
		}

		[Token(Token = "0x6001A86")]
		[Address(RVA = "0x3EA4288", Offset = "0x3EA0288", VA = "0x3EA4288")]
		public void GmCloseDiscountShopInteraction()
		{
		}

		[Token(Token = "0x6001A87")]
		[Address(RVA = "0x3EA4364", Offset = "0x3EA0364", VA = "0x3EA4364")]
		public void GmAddDiscountShopVisitCount(int count = 1)
		{
		}

		[Token(Token = "0x6001A88")]
		[Address(RVA = "0x3EA43C8", Offset = "0x3EA03C8", VA = "0x3EA43C8")]
		[AsyncStateMachine(typeof(_003CGmOpenDiscountShopAsync_003Ed__247))]
		public UniTask<string> GmOpenDiscountShopAsync()
		{
			return default;
		}

		[Token(Token = "0x6001A89")]
		[Address(RVA = "0x3EA4140", Offset = "0x3EA0140", VA = "0x3EA4140")]
		private void RefreshDiscountShopPanelIfShowing()
		{
		}

		[Token(Token = "0x6001A8A")]
		[Address(RVA = "0x3EA4294", Offset = "0x3EA0294", VA = "0x3EA4294")]
		private void CloseDiscountShopPanelIfShowing()
		{
		}

		[Token(Token = "0x6001A8C")]
		[Address(RVA = "0x3E9F648", Offset = "0x3E9B648", VA = "0x3E9F648")]
		public int GetRollDiceCost()
		{
			return default;
		}

		[Token(Token = "0x6001A8D")]
		[Address(RVA = "0x3EA44B4", Offset = "0x3EA04B4", VA = "0x3EA44B4")]
		public void SetTenRollEnabled(bool enabled)
		{
		}

		[Token(Token = "0x6001A8E")]
		[Address(RVA = "0x3E9E2A0", Offset = "0x3E9A2A0", VA = "0x3E9E2A0")]
		public void ResetLapSegmentTracking()
		{
		}

		[Token(Token = "0x6001A8F")]
		[Address(RVA = "0x3E9F684", Offset = "0x3E9B684", VA = "0x3E9F684")]
		private void RecordLapSegmentRoll(int diceCost)
		{
		}

		[Token(Token = "0x6001A90")]
		[Address(RVA = "0x3E9F6A0", Offset = "0x3E9B6A0", VA = "0x3E9F6A0")]
		private int ComputeLapSegmentIncrement()
		{
			return default;
		}

		[Token(Token = "0x6001A91")]
		[Address(RVA = "0x3E9F66C", Offset = "0x3E9B66C", VA = "0x3E9F66C")]
		private int GetRollRewardMultiplierByDiceCost(int diceCost)
		{
			return default;
		}

		[Token(Token = "0x6001A92")]
		[Address(RVA = "0x3EA0274", Offset = "0x3E9C274", VA = "0x3EA0274")]
		private static string ScaleRollRewards(string rewardRaw, int multiplier)
		{
			return null;
		}

		[Token(Token = "0x6001A93")]
		[Address(RVA = "0x3EA44E4", Offset = "0x3EA04E4", VA = "0x3EA44E4")]
		public MysteryAdventureTotalDiceProgress GetTotalDiceProgress()
		{
			return null;
		}

		[Token(Token = "0x6001A94")]
		[Address(RVA = "0x3EA484C", Offset = "0x3EA084C", VA = "0x3EA484C")]
		public bool HasClaimableTotalDiceRewards()
		{
			return default;
		}

		[Token(Token = "0x6001A95")]
		[Address(RVA = "0x3EA4868", Offset = "0x3EA0868", VA = "0x3EA4868")]
		public bool TryClaimTotalDiceReward(int configId, out string errorMessage)
		{
			return default;
		}

		[Token(Token = "0x6001A96")]
		[Address(RVA = "0x3EA4E84", Offset = "0x3EA0E84", VA = "0x3EA4E84")]
		private static bool TryShowMergedTotalDiceReward(string rewardRaw, out string errorMessage)
		{
			return default;
		}

		[Token(Token = "0x6001A97")]
		[Address(RVA = "0x3EA5074", Offset = "0x3EA1074", VA = "0x3EA5074")]
		[AsyncStateMachine(typeof(_003CClaimTotalDiceRewardsAsync_003Ed__266))]
		public UniTask<bool> ClaimTotalDiceRewardsAsync()
		{
			return default;
		}

		[Token(Token = "0x6001A98")]
		[Address(RVA = "0x3EA5134", Offset = "0x3EA1134", VA = "0x3EA5134")]
		public bool TryClaimTotalDiceRewards(out string rewardRaw)
		{
			return default;
		}

		[Token(Token = "0x6001A99")]
		[Address(RVA = "0x3EA4BE4", Offset = "0x3EA0BE4", VA = "0x3EA4BE4")]
		public bool TryClaimTotalDiceRewards(out string rewardRaw, out int lastClaimedConfigId)
		{
			return default;
		}

		[Token(Token = "0x6001A9A")]
		[Address(RVA = "0x3EA4A34", Offset = "0x3EA0A34", VA = "0x3EA4A34")]
		private static TotalDiceConfig FindTotalDiceConfig(int configId)
		{
			return null;
		}

		[Token(Token = "0x6001A9B")]
		[Address(RVA = "0x3E99B58", Offset = "0x3E95B58", VA = "0x3E99B58")]
		public bool IsPlayerProgressUnlocked()
		{
			return default;
		}

		[Token(Token = "0x6001A9C")]
		[Address(RVA = "0x3EA5150", Offset = "0x3EA1150", VA = "0x3EA5150")]
		public string GetProgressUnlockTip()
		{
			return null;
		}

		[Token(Token = "0x6001A9D")]
		[Address(RVA = "0x3E99B2C", Offset = "0x3E95B2C", VA = "0x3E99B2C")]
		public bool IsOnlineActivityWindowOpen()
		{
			return default;
		}

		[Token(Token = "0x6001A9E")]
		[Address(RVA = "0x3E9B408", Offset = "0x3E97408", VA = "0x3E9B408")]
		public bool TryShowProgressUnlockTip()
		{
			return default;
		}

		[Token(Token = "0x6001A9F")]
		[Address(RVA = "0x3EA5230", Offset = "0x3EA1230", VA = "0x3EA5230")]
		private void OnArenaUnlockChanged(object unused)
		{
		}

		[Token(Token = "0x6001AA0")]
		[Address(RVA = "0x3EA524C", Offset = "0x3EA124C", VA = "0x3EA524C")]
		public MysteryAdventureManager()
		{
		}
	}
}
