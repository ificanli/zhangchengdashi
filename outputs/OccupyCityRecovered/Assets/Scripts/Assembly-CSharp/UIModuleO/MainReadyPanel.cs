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
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x200094D")]
	public class MainReadyPanel : MainReadyPanelComponents, IPanelOnOnSecondClick
	{
		[Token(Token = "0x2000950")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass52_0
		{
			[Token(Token = "0x40045F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MainReadyPanel _003C_003E4__this;

			[Token(Token = "0x40045F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UserArenaData data;

			[Token(Token = "0x40045F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int index;

			[Token(Token = "0x60036CA")]
			[Address(RVA = "0x40CF200", Offset = "0x40CB200", VA = "0x40CF200")]
			public _003C_003Ec__DisplayClass52_0()
			{
			}

			[Token(Token = "0x60036CB")]
			[Address(RVA = "0x40CF208", Offset = "0x40CB208", VA = "0x40CF208")]
			internal void _003CArenaUnlockAnimation_003Eb__0()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000952")]
		[CompilerGenerated]
		private struct _003CAdaptCardDeckBtnPos_003Ed__31 : IAsyncStateMachine
		{
			[Token(Token = "0x40045F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40045F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40045F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MainReadyPanel _003C_003E4__this;

			[Token(Token = "0x40045FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Transform _003Ctarget_003E5__2;

			[Token(Token = "0x40045FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60036CF")]
			[Address(RVA = "0x40CF3E4", Offset = "0x40CB3E4", VA = "0x40CF3E4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60036D0")]
			[Address(RVA = "0x40CFBE4", Offset = "0x40CBBE4", VA = "0x40CFBE4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000953")]
		[CompilerGenerated]
		private struct _003CArenaUnlockAnimation_003Ed__52 : IAsyncStateMachine
		{
			[Token(Token = "0x40045FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40045FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40045FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MainReadyPanel _003C_003E4__this;

			[Token(Token = "0x40045FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int unlockArenaIndex;

			[Token(Token = "0x4004600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private _003C_003Ec__DisplayClass52_0 _003C_003E8__1;

			[Token(Token = "0x4004601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4004602")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x60036D1")]
			[Address(RVA = "0x40CFBF0", Offset = "0x40CBBF0", VA = "0x40CFBF0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60036D2")]
			[Address(RVA = "0x40D0B88", Offset = "0x40CCB88", VA = "0x40D0B88", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000954")]
		[CompilerGenerated]
		private struct _003CAwake_003Ed__16 : IAsyncStateMachine
		{
			[Token(Token = "0x4004603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MainReadyPanel _003C_003E4__this;

			[Token(Token = "0x60036D3")]
			[Address(RVA = "0x40D0B94", Offset = "0x40CCB94", VA = "0x40D0B94", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60036D4")]
			[Address(RVA = "0x40D1AAC", Offset = "0x40CDAAC", VA = "0x40D1AAC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000955")]
		[CompilerGenerated]
		private struct _003CCheckAndPlayBoxCollectAnimation_003Ed__50 : IAsyncStateMachine
		{
			[Token(Token = "0x4004606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60036D5")]
			[Address(RVA = "0x40D1AB8", Offset = "0x40CDAB8", VA = "0x40D1AB8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60036D6")]
			[Address(RVA = "0x40D2010", Offset = "0x40CE010", VA = "0x40D2010", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000956")]
		[CompilerGenerated]
		private struct _003CCheckArenaUnlockAni_003Ed__51 : IAsyncStateMachine
		{
			[Token(Token = "0x4004609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400460A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400460B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MainReadyPanel _003C_003E4__this;

			[Token(Token = "0x400460C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60036D7")]
			[Address(RVA = "0x40D201C", Offset = "0x40CE01C", VA = "0x40D201C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60036D8")]
			[Address(RVA = "0x40D2690", Offset = "0x40CE690", VA = "0x40D2690", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000957")]
		[CompilerGenerated]
		private struct _003CDoAnimation_003Ed__42 : IAsyncStateMachine
		{
			[Token(Token = "0x400460D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400460E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400460F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MainReadyPanel _003C_003E4__this;

			[Token(Token = "0x4004610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private RewardConfig _003CrewardCofig_003E5__2;

			[Token(Token = "0x4004611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool _003CisVictory_003E5__3;

			[Token(Token = "0x4004612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
			private bool _003CisCompleteReward_003E5__4;

			[Token(Token = "0x4004613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<bool>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4004614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x4004615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private ArenaUIBGItem _003Citem_003E5__5;

			[Token(Token = "0x60036D9")]
			[Address(RVA = "0x40D269C", Offset = "0x40CE69C", VA = "0x40D269C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60036DA")]
			[Address(RVA = "0x40D43F8", Offset = "0x40D03F8", VA = "0x40D43F8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000958")]
		[CompilerGenerated]
		private struct _003CExpCollectAni_003Ed__49 : IAsyncStateMachine
		{
			[Token(Token = "0x4004616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MainReadyPanel _003C_003E4__this;

			[Token(Token = "0x4004619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool isVitory;

			[Token(Token = "0x400461A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private int _003CaddExpNumber_003E5__2;

			[Token(Token = "0x400461B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<bool>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x400461C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x400461D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private int _003Clevel_003E5__3;

			[Token(Token = "0x400461E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float _003Cprogress_003E5__4;

			[Token(Token = "0x60036DB")]
			[Address(RVA = "0x40D4404", Offset = "0x40D0404", VA = "0x40D4404", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60036DC")]
			[Address(RVA = "0x40D68EC", Offset = "0x40D28EC", VA = "0x40D68EC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000959")]
		[CompilerGenerated]
		private struct _003CGetNewCardPanelEnd_003Ed__44 : IAsyncStateMachine
		{
			[Token(Token = "0x400461F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MainReadyPanel _003C_003E4__this;

			[Token(Token = "0x4004622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60036DD")]
			[Address(RVA = "0x40D68F8", Offset = "0x40D28F8", VA = "0x40D68F8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60036DE")]
			[Address(RVA = "0x40D6E14", Offset = "0x40D2E14", VA = "0x40D6E14", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200095A")]
		[CompilerGenerated]
		private struct _003CGetNewCardUpdateExpUI_003Ed__56 : IAsyncStateMachine
		{
			[Token(Token = "0x4004623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MainReadyPanel _003C_003E4__this;

			[Token(Token = "0x4004626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4004627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60036DF")]
			[Address(RVA = "0x40D6E20", Offset = "0x40D2E20", VA = "0x40D6E20", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60036E0")]
			[Address(RVA = "0x40D71D4", Offset = "0x40D31D4", VA = "0x40D71D4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200095B")]
		[CompilerGenerated]
		private struct _003CHeadShotClick_003Ed__55 : IAsyncStateMachine
		{
			[Token(Token = "0x4004628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400462A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public object o;

			[Token(Token = "0x400462B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public MainReadyPanel _003C_003E4__this;

			[Token(Token = "0x400462C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x400462D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60036E1")]
			[Address(RVA = "0x40D71E0", Offset = "0x40D31E0", VA = "0x40D71E0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60036E2")]
			[Address(RVA = "0x40D760C", Offset = "0x40D360C", VA = "0x40D760C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200095C")]
		[CompilerGenerated]
		private struct _003CMoraleBubbleFollowBtn_003Ed__62 : IAsyncStateMachine
		{
			[Token(Token = "0x400462E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400462F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MainReadyPanel _003C_003E4__this;

			[Token(Token = "0x4004631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public RectTransform followRect;

			[Token(Token = "0x4004632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60036E3")]
			[Address(RVA = "0x40D7C48", Offset = "0x40D3C48", VA = "0x40D7C48", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60036E4")]
			[Address(RVA = "0x40D829C", Offset = "0x40D429C", VA = "0x40D829C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200095D")]
		[CompilerGenerated]
		private struct _003CMoraleCollectAnimation_003Ed__68 : IAsyncStateMachine
		{
			[Token(Token = "0x4004633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x60036E5")]
			[Address(RVA = "0x40D82A8", Offset = "0x40D42A8", VA = "0x40D82A8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60036E6")]
			[Address(RVA = "0x40D82B8", Offset = "0x40D42B8", VA = "0x40D82B8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200095E")]
		[CompilerGenerated]
		private struct _003COpenBoxAniPanelEnd_003Ed__43 : IAsyncStateMachine
		{
			[Token(Token = "0x4004635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MainReadyPanel _003C_003E4__this;

			[Token(Token = "0x4004638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<bool>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4004639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x60036E7")]
			[Address(RVA = "0x40D82C4", Offset = "0x40D42C4", VA = "0x40D82C4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60036E8")]
			[Address(RVA = "0x40D8B00", Offset = "0x40D4B00", VA = "0x40D8B00", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200095F")]
		[CompilerGenerated]
		private struct _003CRefreshMainReadyPlayerBannerSafeAreaNextFrame_003Ed__24 : IAsyncStateMachine
		{
			[Token(Token = "0x400463A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400463B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400463C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MainReadyPanel _003C_003E4__this;

			[Token(Token = "0x400463D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private MeatScrollRectPageController _003CscrollController_003E5__2;

			[Token(Token = "0x400463E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int _003CwaitedFrames_003E5__3;

			[Token(Token = "0x400463F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60036E9")]
			[Address(RVA = "0x40D8B0C", Offset = "0x40D4B0C", VA = "0x40D8B0C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60036EA")]
			[Address(RVA = "0x40D8FC8", Offset = "0x40D4FC8", VA = "0x40D8FC8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000960")]
		[CompilerGenerated]
		private struct _003CRewardFlyCollectAnimation_003Ed__48 : IAsyncStateMachine
		{
			[Token(Token = "0x4004640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MainReadyPanel _003C_003E4__this;

			[Token(Token = "0x4004643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool isDiamond;

			[Token(Token = "0x4004644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private string _003Cresid_003E5__2;

			[Token(Token = "0x4004645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector2 _003CtarPos_003E5__3;

			[Token(Token = "0x4004646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<bool>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4004647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x4004648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private UniTask.Awaiter _003C_003Eu__3;

			[Token(Token = "0x60036EB")]
			[Address(RVA = "0x40D8FD4", Offset = "0x40D4FD4", VA = "0x40D8FD4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60036EC")]
			[Address(RVA = "0x40D9E5C", Offset = "0x40D5E5C", VA = "0x40D9E5C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000961")]
		[CompilerGenerated]
		private struct _003CRewardGameAssetSeasonPassScoreFlyCollectAnimation_003Ed__47 : IAsyncStateMachine
		{
			[Token(Token = "0x4004649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400464A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400464B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60036ED")]
			[Address(RVA = "0x40D9E68", Offset = "0x40D5E68", VA = "0x40D9E68", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60036EE")]
			[Address(RVA = "0x40DA2E0", Offset = "0x40D62E0", VA = "0x40DA2E0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000962")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__26 : IAsyncStateMachine
		{
			[Token(Token = "0x400464C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400464D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400464E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MainReadyPanel _003C_003E4__this;

			[Token(Token = "0x400464F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x4004650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4004651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60036EF")]
			[Address(RVA = "0x40DA2EC", Offset = "0x40D62EC", VA = "0x40DA2EC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60036F0")]
			[Address(RVA = "0x40DC308", Offset = "0x40D8308", VA = "0x40DC308", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000963")]
		[CompilerGenerated]
		private struct _003CUpdateDailyBlessBtnActive_003Ed__57 : IAsyncStateMachine
		{
			[Token(Token = "0x4004652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MainReadyPanel _003C_003E4__this;

			[Token(Token = "0x4004655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4004656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60036F1")]
			[Address(RVA = "0x40DC314", Offset = "0x40D8314", VA = "0x40DC314", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60036F2")]
			[Address(RVA = "0x40DC9F8", Offset = "0x40D89F8", VA = "0x40DC9F8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000964")]
		[CompilerGenerated]
		private struct _003CUpdateElements_003Ed__38 : IAsyncStateMachine
		{
			[Token(Token = "0x4004657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MainReadyPanel _003C_003E4__this;

			[Token(Token = "0x400465A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool resetCreat;

			[Token(Token = "0x400465B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public List<UserArenaData> dataList;

			[Token(Token = "0x400465C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x400465D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x60036F3")]
			[Address(RVA = "0x40DCA04", Offset = "0x40D8A04", VA = "0x40DCA04", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60036F4")]
			[Address(RVA = "0x40DD00C", Offset = "0x40D900C", VA = "0x40DD00C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000965")]
		[CompilerGenerated]
		private struct _003CUpdateLevelRewardIcon_003Ed__35 : IAsyncStateMachine
		{
			[Token(Token = "0x400465E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400465F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MainReadyPanel _003C_003E4__this;

			[Token(Token = "0x4004661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60036F5")]
			[Address(RVA = "0x40DD018", Offset = "0x40D9018", VA = "0x40DD018", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60036F6")]
			[Address(RVA = "0x40DD790", Offset = "0x40D9790", VA = "0x40DD790", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000966")]
		[CompilerGenerated]
		private struct _003CUpdateRewardBubble_003Ed__34 : IAsyncStateMachine
		{
			[Token(Token = "0x4004662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MainReadyPanel _003C_003E4__this;

			[Token(Token = "0x4004665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4004666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60036F7")]
			[Address(RVA = "0x40DD79C", Offset = "0x40D979C", VA = "0x40DD79C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60036F8")]
			[Address(RVA = "0x40DE588", Offset = "0x40DA588", VA = "0x40DE588", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000967")]
		[CompilerGenerated]
		private struct _003CWaitUntilArenaItemReady_003Ed__41 : IAsyncStateMachine
		{
			[Token(Token = "0x4004667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

			[Token(Token = "0x4004669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MainReadyPanel _003C_003E4__this;

			[Token(Token = "0x400466A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<int>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60036F9")]
			[Address(RVA = "0x40DE594", Offset = "0x40DA594", VA = "0x40DE594", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60036FA")]
			[Address(RVA = "0x40DEB14", Offset = "0x40DAB14", VA = "0x40DEB14", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40045D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private Tween _btnTw;

		[Token(Token = "0x40045D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private List<ArenaUIBGItem> itemList;

		[Token(Token = "0x40045D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private bool arenaRewardAnimationIng;

		[Token(Token = "0x40045DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B1")]
		private bool isAnimationIng;

		[Token(Token = "0x40045DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B2")]
		private bool banClick;

		[Token(Token = "0x40045DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B3")]
		private bool expProgressReach;

		[Token(Token = "0x40045DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private Image currentImage;

		[Token(Token = "0x40045DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private Image nextImage;

		[Token(Token = "0x40045DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private int nowIndex;

		[Token(Token = "0x40045E0")]
		private const int MetaMainPageScrollIndex = 2;

		[Token(Token = "0x40045E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2CC")]
		private Vector2 _mainReadyPlayerBannerDefaultAnchoredPos;

		[Token(Token = "0x40045E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D4")]
		private bool _hasMainReadyPlayerBannerDefaultAnchoredPos;

		[Token(Token = "0x40045E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private MeatScrollRectPageController _metaScrollPageController;

		[Token(Token = "0x40045E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private bool _subscribedMetaScrollPageComplete;

		[Token(Token = "0x40045E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E1")]
		private bool cardDeckHasAdapt;

		[Token(Token = "0x40045E6")]
		private const float ArenaItemReadyTimeoutSeconds = 10f;

		[Token(Token = "0x40045E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private string stayUnLoadArenaID;

		[Token(Token = "0x40045E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private Tween _tween;

		[Token(Token = "0x170007F6")]
		private bool IsTrainingLockOnMainReady
		{
			[Token(Token = "0x6003675")]
			[Address(RVA = "0x40CB298", Offset = "0x40C7298", VA = "0x40CB298")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6003676")]
		[Address(RVA = "0x40CB360", Offset = "0x40C7360", VA = "0x40CB360", Slot = "4")]
		[AsyncStateMachine(typeof(_003CAwake_003Ed__16))]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6003677")]
		[Address(RVA = "0x40CB3EC", Offset = "0x40C73EC", VA = "0x40CB3EC")]
		private void ChangeBanner(object obj)
		{
		}

		[Token(Token = "0x6003678")]
		[Address(RVA = "0x40CB458", Offset = "0x40C7458", VA = "0x40CB458")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6003679")]
		[Address(RVA = "0x40CB704", Offset = "0x40C7704", VA = "0x40CB704")]
		private void OnMetaPanelChanged(object obj)
		{
		}

		[Token(Token = "0x600367A")]
		[Address(RVA = "0x40CB880", Offset = "0x40C7880", VA = "0x40CB880")]
		private void OnMetaScrollPageChangeComplete(int pageIndex)
		{
		}

		[Token(Token = "0x600367B")]
		[Address(RVA = "0x40CB994", Offset = "0x40C7994", VA = "0x40CB994")]
		private void CacheMainReadyPlayerBannerDefaultAnchoredPos()
		{
		}

		[Token(Token = "0x600367C")]
		[Address(RVA = "0x40CBA40", Offset = "0x40C7A40", VA = "0x40CBA40")]
		private void EnsureMetaScrollPageControllerSubscribed()
		{
		}

		[Token(Token = "0x600367D")]
		[Address(RVA = "0x40CB5E4", Offset = "0x40C75E4", VA = "0x40CB5E4")]
		private void UnsubscribeMetaScrollPageController()
		{
		}

		[Token(Token = "0x600367E")]
		[Address(RVA = "0x40CB7E8", Offset = "0x40C77E8", VA = "0x40CB7E8")]
		[AsyncStateMachine(typeof(_003CRefreshMainReadyPlayerBannerSafeAreaNextFrame_003Ed__24))]
		private UniTask RefreshMainReadyPlayerBannerSafeAreaNextFrame()
		{
			return default;
		}

		[Token(Token = "0x600367F")]
		[Address(RVA = "0x40CB890", Offset = "0x40C7890", VA = "0x40CB890")]
		private void RefreshMainReadyPlayerBannerSafeArea()
		{
		}

		[Token(Token = "0x6003680")]
		[Address(RVA = "0x40CBBBC", Offset = "0x40C7BBC", VA = "0x40CBBBC", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__26))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003681")]
		[Address(RVA = "0x40CBC64", Offset = "0x40C7C64", VA = "0x40CBC64")]
		private void UpdatePlayerTotalPower(object o)
		{
		}

		[Token(Token = "0x6003682")]
		[Address(RVA = "0x40CBD04", Offset = "0x40C7D04", VA = "0x40CBD04")]
		private void MoraleProgressSetActive(object o)
		{
		}

		[Token(Token = "0x6003683")]
		[Address(RVA = "0x40CBD08", Offset = "0x40C7D08", VA = "0x40CBD08")]
		private void Update()
		{
		}

		[Token(Token = "0x6003684")]
		[Address(RVA = "0x40CBED0", Offset = "0x40C7ED0", VA = "0x40CBED0")]
		[AsyncStateMachine(typeof(_003CAdaptCardDeckBtnPos_003Ed__31))]
		private void AdaptCardDeckBtnPos()
		{
		}

		[Token(Token = "0x6003685")]
		[Address(RVA = "0x40CBF60", Offset = "0x40C7F60", VA = "0x40CBF60")]
		private void UpdateMoraleUI(object o)
		{
		}

		[Token(Token = "0x6003686")]
		[Address(RVA = "0x40CBF64", Offset = "0x40C7F64", VA = "0x40CBF64")]
		private void ArenaUIItemAdapt()
		{
		}

		[Token(Token = "0x6003687")]
		[Address(RVA = "0x40CC208", Offset = "0x40C8208", VA = "0x40CC208")]
		[AsyncStateMachine(typeof(_003CUpdateRewardBubble_003Ed__34))]
		private void UpdateRewardBubble()
		{
		}

		[Token(Token = "0x6003688")]
		[Address(RVA = "0x40CC298", Offset = "0x40C8298", VA = "0x40CC298")]
		[AsyncStateMachine(typeof(_003CUpdateLevelRewardIcon_003Ed__35))]
		private void UpdateLevelRewardIcon()
		{
		}

		[Token(Token = "0x6003689")]
		[Address(RVA = "0x40CC328", Offset = "0x40C8328", VA = "0x40CC328")]
		private void UpdateProgressBuUI()
		{
		}

		[Token(Token = "0x600368A")]
		[Address(RVA = "0x40CC6E8", Offset = "0x40C86E8", VA = "0x40CC6E8")]
		private void UpdateExpProgressTextUI()
		{
		}

		[Token(Token = "0x600368B")]
		[Address(RVA = "0x40CC7C0", Offset = "0x40C87C0", VA = "0x40CC7C0")]
		[AsyncStateMachine(typeof(_003CUpdateElements_003Ed__38))]
		private void UpdateElements(List<UserArenaData> dataList, bool resetCreat = false)
		{
		}

		[Token(Token = "0x600368C")]
		[Address(RVA = "0x40CC870", Offset = "0x40C8870", VA = "0x40CC870")]
		private void ResetCreatArenaItem(object o)
		{
		}

		[Token(Token = "0x600368D")]
		[Address(RVA = "0x40CC8F4", Offset = "0x40C88F4", VA = "0x40CC8F4")]
		[AsyncStateMachine(typeof(_003CWaitUntilArenaItemReady_003Ed__41))]
		private UniTask<bool> WaitUntilArenaItemReady()
		{
			return default;
		}

		[Token(Token = "0x600368E")]
		[Address(RVA = "0x40CC9B8", Offset = "0x40C89B8", VA = "0x40CC9B8")]
		[AsyncStateMachine(typeof(_003CDoAnimation_003Ed__42))]
		private void DoAnimation(object o)
		{
		}

		[Token(Token = "0x600368F")]
		[Address(RVA = "0x40CCA4C", Offset = "0x40C8A4C", VA = "0x40CCA4C")]
		[AsyncStateMachine(typeof(_003COpenBoxAniPanelEnd_003Ed__43))]
		private void OpenBoxAniPanelEnd(object o)
		{
		}

		[Token(Token = "0x6003690")]
		[Address(RVA = "0x40CCADC", Offset = "0x40C8ADC", VA = "0x40CCADC")]
		[AsyncStateMachine(typeof(_003CGetNewCardPanelEnd_003Ed__44))]
		private void GetNewCardPanelEnd(object o)
		{
		}

		[Token(Token = "0x6003691")]
		[Address(RVA = "0x40CCB68", Offset = "0x40C8B68", VA = "0x40CCB68")]
		private void HasArenaStayUnLock(object o)
		{
		}

		[Token(Token = "0x6003692")]
		[Address(RVA = "0x40CCB98", Offset = "0x40C8B98", VA = "0x40CCB98")]
		[AsyncStateMachine(typeof(_003CRewardGameAssetSeasonPassScoreFlyCollectAnimation_003Ed__47))]
		private UniTask RewardGameAssetSeasonPassScoreFlyCollectAnimation()
		{
			return default;
		}

		[Token(Token = "0x6003693")]
		[Address(RVA = "0x40CCC28", Offset = "0x40C8C28", VA = "0x40CCC28")]
		[AsyncStateMachine(typeof(_003CRewardFlyCollectAnimation_003Ed__48))]
		private UniTask RewardFlyCollectAnimation(bool isDiamond, bool isArenaCompleteAnimation = false)
		{
			return default;
		}

		[Token(Token = "0x6003694")]
		[Address(RVA = "0x40CCCDC", Offset = "0x40C8CDC", VA = "0x40CCCDC")]
		[AsyncStateMachine(typeof(_003CExpCollectAni_003Ed__49))]
		private UniTask ExpCollectAni(bool isVitory)
		{
			return default;
		}

		[Token(Token = "0x6003695")]
		[Address(RVA = "0x40CCD80", Offset = "0x40C8D80", VA = "0x40CCD80")]
		[AsyncStateMachine(typeof(_003CCheckAndPlayBoxCollectAnimation_003Ed__50))]
		private UniTask CheckAndPlayBoxCollectAnimation()
		{
			return default;
		}

		[Token(Token = "0x6003696")]
		[Address(RVA = "0x40CCE04", Offset = "0x40C8E04", VA = "0x40CCE04")]
		[AsyncStateMachine(typeof(_003CCheckArenaUnlockAni_003Ed__51))]
		private UniTask CheckArenaUnlockAni()
		{
			return default;
		}

		[Token(Token = "0x6003697")]
		[Address(RVA = "0x40CCE90", Offset = "0x40C8E90", VA = "0x40CCE90")]
		[AsyncStateMachine(typeof(_003CArenaUnlockAnimation_003Ed__52))]
		public UniTask ArenaUnlockAnimation(int unlockArenaIndex = -1)
		{
			return default;
		}

		[Token(Token = "0x6003698")]
		[Address(RVA = "0x40CCF30", Offset = "0x40C8F30", VA = "0x40CCF30")]
		private void ScrollNumber(int fromVal, int toVal, float dur, int allVal)
		{
		}

		[Token(Token = "0x6003699")]
		[Address(RVA = "0x40CD0F0", Offset = "0x40C90F0", VA = "0x40CD0F0")]
		[AsyncStateMachine(typeof(_003CHeadShotClick_003Ed__55))]
		private void HeadShotClick(object o)
		{
		}

		[Token(Token = "0x600369A")]
		[Address(RVA = "0x40CD190", Offset = "0x40C9190", VA = "0x40CD190")]
		[AsyncStateMachine(typeof(_003CGetNewCardUpdateExpUI_003Ed__56))]
		private void GetNewCardUpdateExpUI(object o)
		{
		}

		[Token(Token = "0x600369B")]
		[Address(RVA = "0x40CD220", Offset = "0x40C9220", VA = "0x40CD220")]
		[AsyncStateMachine(typeof(_003CUpdateDailyBlessBtnActive_003Ed__57))]
		private void UpdateDailyBlessBtnActive(object o)
		{
		}

		[Token(Token = "0x600369C")]
		[Address(RVA = "0x40CD2B0", Offset = "0x40C92B0", VA = "0x40CD2B0", Slot = "23")]
		protected override void OnButtonExtendImgBlessBgClicked()
		{
		}

		[Token(Token = "0x600369D")]
		[Address(RVA = "0x40CD5A8", Offset = "0x40C95A8", VA = "0x40CD5A8", Slot = "12")]
		protected override void OnButtonExtendSettingsBtnClicked()
		{
		}

		[Token(Token = "0x600369E")]
		[Address(RVA = "0x40CD6A8", Offset = "0x40C96A8", VA = "0x40CD6A8", Slot = "13")]
		protected override void OnButtonExtendAllIAPsBtnClicked()
		{
		}

		[Token(Token = "0x600369F")]
		[Address(RVA = "0x40CD7A8", Offset = "0x40C97A8", VA = "0x40CD7A8", Slot = "24")]
		protected override void OnButtonExtendBtnClickClicked()
		{
		}

		[Token(Token = "0x60036A0")]
		[Address(RVA = "0x40CD8A8", Offset = "0x40C98A8", VA = "0x40CD8A8")]
		[AsyncStateMachine(typeof(_003CMoraleBubbleFollowBtn_003Ed__62))]
		private void MoraleBubbleFollowBtn(RectTransform followRect)
		{
		}

		[Token(Token = "0x60036A1")]
		[Address(RVA = "0x40CD940", Offset = "0x40C9940", VA = "0x40CD940")]
		private void RewardAnimationBegin(object o)
		{
		}

		[Token(Token = "0x60036A2")]
		[Address(RVA = "0x40CD94C", Offset = "0x40C994C", VA = "0x40CD94C")]
		private void RewardAnimationEnd(object o)
		{
		}

		[Token(Token = "0x60036A3")]
		[Address(RVA = "0x40CD98C", Offset = "0x40C998C", VA = "0x40CD98C")]
		private void ExpProgressReach(object o)
		{
		}

		[Token(Token = "0x60036A4")]
		[Address(RVA = "0x40CD998", Offset = "0x40C9998", VA = "0x40CD998")]
		private void BeginBanClick(object o)
		{
		}

		[Token(Token = "0x60036A5")]
		[Address(RVA = "0x40CD9A4", Offset = "0x40C99A4", VA = "0x40CD9A4")]
		private void EndBanClick(object o)
		{
		}

		[Token(Token = "0x60036A6")]
		[Address(RVA = "0x40CD9AC", Offset = "0x40C99AC", VA = "0x40CD9AC")]
		[AsyncStateMachine(typeof(_003CMoraleCollectAnimation_003Ed__68))]
		private void MoraleCollectAnimation(object o)
		{
		}

		[Token(Token = "0x60036A7")]
		[Address(RVA = "0x40CDA30", Offset = "0x40C9A30", VA = "0x40CDA30")]
		public void ReleaseChestSlotsResources()
		{
		}

		[Token(Token = "0x60036A8")]
		[Address(RVA = "0x40CDA54", Offset = "0x40C9A54", VA = "0x40CDA54", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60036A9")]
		[Address(RVA = "0x40CDA8C", Offset = "0x40C9A8C", VA = "0x40CDA8C")]
		private void UpdatePlayerNameUI(object o)
		{
		}

		[Token(Token = "0x60036AA")]
		[Address(RVA = "0x40CDB14", Offset = "0x40C9B14", VA = "0x40CDB14")]
		public void ArneaLinerBInItem(List<UserArenaData> dataList, GameObject res)
		{
		}

		[Token(Token = "0x60036AB")]
		[Address(RVA = "0x40CE31C", Offset = "0x40CA31C", VA = "0x40CE31C", Slot = "14")]
		protected override void OnButtonExtendOpenUpgradeRewardsPreviewClicked()
		{
		}

		[Token(Token = "0x60036AC")]
		[Address(RVA = "0x40CE380", Offset = "0x40CA380", VA = "0x40CE380", Slot = "25")]
		protected override void OnButtonExtendSubGameChaosTrailEntranceClicked()
		{
		}

		[Token(Token = "0x60036AD")]
		[Address(RVA = "0x40CE400", Offset = "0x40CA400", VA = "0x40CE400")]
		private void UpdateSubGameChaosTrailEntranceActive(object obj)
		{
		}

		[Token(Token = "0x60036AE")]
		[Address(RVA = "0x40CE554", Offset = "0x40CA554", VA = "0x40CE554")]
		private void RefreshSubGameChaosTrailEntranceAnimation(bool isAnimationActive)
		{
		}

		[Token(Token = "0x60036AF")]
		[Address(RVA = "0x40CE644", Offset = "0x40CA644", VA = "0x40CE644", Slot = "45")]
		public void PanelOnOnSecondClickInit()
		{
		}

		[Token(Token = "0x60036B0")]
		[Address(RVA = "0x40CE700", Offset = "0x40CA700", VA = "0x40CE700", Slot = "46")]
		public void OnSecondClick(object o)
		{
		}

		[Token(Token = "0x60036B1")]
		[Address(RVA = "0x40CE7D0", Offset = "0x40CA7D0", VA = "0x40CE7D0", Slot = "47")]
		public void OnHide()
		{
		}

		[Token(Token = "0x60036B2")]
		[Address(RVA = "0x40CE7D4", Offset = "0x40CA7D4", VA = "0x40CE7D4")]
		public MainReadyPanel()
		{
		}
	}
}
