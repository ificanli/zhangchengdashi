using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using DataModule;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20008AD")]
	public class GamePanel : GamePanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008B0")]
		[CompilerGenerated]
		private struct _003CAwake_003Ed__26 : IAsyncStateMachine
		{
			[Token(Token = "0x40041B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40041B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40041B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GamePanel _003C_003E4__this;

			[Token(Token = "0x40041B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003181")]
			[Address(RVA = "0x405DB90", Offset = "0x4059B90", VA = "0x405DB90", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003182")]
			[Address(RVA = "0x405E79C", Offset = "0x405A79C", VA = "0x405E79C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008B1")]
		[CompilerGenerated]
		private struct _003CBlessUpdateUI_003Ed__65 : IAsyncStateMachine
		{
			[Token(Token = "0x40041B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40041B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40041BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GamePanel _003C_003E4__this;

			[Token(Token = "0x40041BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x40041BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003183")]
			[Address(RVA = "0x405E7A8", Offset = "0x405A7A8", VA = "0x405E7A8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003184")]
			[Address(RVA = "0x405F0A4", Offset = "0x405B0A4", VA = "0x405F0A4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008B2")]
		[CompilerGenerated]
		private struct _003CDoAni_003Ed__31 : IAsyncStateMachine
		{
			[Token(Token = "0x40041BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40041BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40041BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GamePanel _003C_003E4__this;

			[Token(Token = "0x40041C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003185")]
			[Address(RVA = "0x405F0B0", Offset = "0x405B0B0", VA = "0x405F0B0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003186")]
			[Address(RVA = "0x405F5A4", Offset = "0x405B5A4", VA = "0x405F5A4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008B3")]
		[CompilerGenerated]
		private struct _003CEnemyShowEmoji_003Ed__91 : IAsyncStateMachine
		{
			[Token(Token = "0x40041C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40041C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40041C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GamePanel _003C_003E4__this;

			[Token(Token = "0x40041C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int id;

			[Token(Token = "0x40041C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003187")]
			[Address(RVA = "0x405F5B0", Offset = "0x405B5B0", VA = "0x405F5B0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003188")]
			[Address(RVA = "0x405FA80", Offset = "0x405BA80", VA = "0x405FA80", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008B4")]
		[CompilerGenerated]
		private struct _003CHideChaosBuffPanelAnimatedAsync_003Ed__47 : IAsyncStateMachine
		{
			[Token(Token = "0x40041C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40041C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40041C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GamePanel _003C_003E4__this;

			[Token(Token = "0x40041C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6003189")]
			[Address(RVA = "0x405FA8C", Offset = "0x405BA8C", VA = "0x405FA8C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600318A")]
			[Address(RVA = "0x405FFB0", Offset = "0x405BFB0", VA = "0x405FFB0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008B5")]
		[CompilerGenerated]
		private struct _003CInitEmojiSystem_003Ed__66 : IAsyncStateMachine
		{
			[Token(Token = "0x40041CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40041CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40041CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GamePanel _003C_003E4__this;

			[Token(Token = "0x40041CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600318B")]
			[Address(RVA = "0x405FFBC", Offset = "0x405BFBC", VA = "0x405FFBC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600318C")]
			[Address(RVA = "0x4060414", Offset = "0x405C414", VA = "0x4060414", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008B6")]
		[CompilerGenerated]
		private struct _003CLoadSpineEmojiResources_003Ed__67 : IAsyncStateMachine
		{
			[Token(Token = "0x40041CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40041CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40041D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<string> expressionIds;

			[Token(Token = "0x40041D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GamePanel _003C_003E4__this;

			[Token(Token = "0x40041D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<GlobalExpression> _003CglobalExpressions_003E5__2;

			[Token(Token = "0x40041D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private SkeletonGraphic[] _003CspineComponents_003E5__3;

			[Token(Token = "0x40041D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int _003Ci_003E5__4;

			[Token(Token = "0x40041D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<SkeletonDataAsset>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600318D")]
			[Address(RVA = "0x4060630", Offset = "0x405C630", VA = "0x4060630", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600318E")]
			[Address(RVA = "0x4061150", Offset = "0x405D150", VA = "0x4061150", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008B7")]
		[CompilerGenerated]
		private struct _003COnButtonExtendBtnBanEmojisClicked_003Ed__87 : IAsyncStateMachine
		{
			[Token(Token = "0x40041D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40041D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40041D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GamePanel _003C_003E4__this;

			[Token(Token = "0x40041D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x40041DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600318F")]
			[Address(RVA = "0x406115C", Offset = "0x405D15C", VA = "0x406115C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003190")]
			[Address(RVA = "0x40617E0", Offset = "0x405D7E0", VA = "0x40617E0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008B8")]
		[CompilerGenerated]
		private struct _003COnButtonExtendBtnGuideClicked_003Ed__71 : IAsyncStateMachine
		{
			[Token(Token = "0x40041DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40041DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40041DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GamePanel _003C_003E4__this;

			[Token(Token = "0x6003191")]
			[Address(RVA = "0x40617EC", Offset = "0x405D7EC", VA = "0x40617EC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003192")]
			[Address(RVA = "0x4061A04", Offset = "0x405DA04", VA = "0x4061A04", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008B9")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__36 : IAsyncStateMachine
		{
			[Token(Token = "0x40041DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40041DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40041E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GamePanel _003C_003E4__this;

			[Token(Token = "0x40041E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x40041E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x40041E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x40041E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6003193")]
			[Address(RVA = "0x4061A10", Offset = "0x405DA10", VA = "0x4061A10", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003194")]
			[Address(RVA = "0x40643D4", Offset = "0x40603D4", VA = "0x40643D4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008BA")]
		[CompilerGenerated]
		private struct _003CShowChaosBuffPanelAnimatedAsync_003Ed__45 : IAsyncStateMachine
		{
			[Token(Token = "0x40041E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40041E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40041E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GamePanel _003C_003E4__this;

			[Token(Token = "0x40041E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6003195")]
			[Address(RVA = "0x40643E0", Offset = "0x40603E0", VA = "0x40643E0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003196")]
			[Address(RVA = "0x4064A78", Offset = "0x4060A78", VA = "0x4064A78", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008BB")]
		[CompilerGenerated]
		private struct _003CShowEmojis_003Ed__89 : IAsyncStateMachine
		{
			[Token(Token = "0x40041E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40041EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40041EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GamePanel _003C_003E4__this;

			[Token(Token = "0x40041EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int id;

			[Token(Token = "0x40041ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003197")]
			[Address(RVA = "0x4064A84", Offset = "0x4060A84", VA = "0x4064A84", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003198")]
			[Address(RVA = "0x4065080", Offset = "0x4061080", VA = "0x4065080", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008BC")]
		[CompilerGenerated]
		private struct _003CShowEmojisWithSpine_003Ed__68 : IAsyncStateMachine
		{
			[Token(Token = "0x40041EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40041EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40041F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int index;

			[Token(Token = "0x40041F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool isEnemy;

			[Token(Token = "0x40041F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GamePanel _003C_003E4__this;

			[Token(Token = "0x40041F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private SkeletonGraphic _003CtargetSpine_003E5__2;

			[Token(Token = "0x40041F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<SkeletonDataAsset>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003199")]
			[Address(RVA = "0x406508C", Offset = "0x406108C", VA = "0x406508C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600319A")]
			[Address(RVA = "0x4065984", Offset = "0x4061984", VA = "0x4065984", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008BD")]
		[CompilerGenerated]
		private struct _003CWaitChaosBuffAutoCloseAsync_003Ed__49 : IAsyncStateMachine
		{
			[Token(Token = "0x40041F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40041F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40041F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CancellationToken token;

			[Token(Token = "0x40041F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GamePanel _003C_003E4__this;

			[Token(Token = "0x40041F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600319B")]
			[Address(RVA = "0x4065990", Offset = "0x4061990", VA = "0x4065990", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600319C")]
			[Address(RVA = "0x4065E6C", Offset = "0x4061E6C", VA = "0x4065E6C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400418D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		[SerializeField]
		private Button lookBuffBtn;

		[Token(Token = "0x400418E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		[SerializeField]
		private RectTransform lookBuffBtnRect;

		[Token(Token = "0x400418F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		[SerializeField]
		private GameObject chaosBuffPanel;

		[Token(Token = "0x4004190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		[SerializeField]
		private RectTransform chaosBuffPanelContent;

		[Token(Token = "0x4004191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		[SerializeField]
		private Button hideChaosBuffPanelBtn;

		[Token(Token = "0x4004192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		[SerializeField]
		private RectTransform chaosBuffRoot;

		[Token(Token = "0x4004193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		[SerializeField]
		private ChaosBuffItem chaosBuffItemTemplate;

		[Token(Token = "0x4004194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		[SerializeField]
		private float _chaosBuffTweenDuration;

		[Token(Token = "0x4004195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x314")]
		[SerializeField]
		private Ease _chaosBuffShowEase;

		[Token(Token = "0x4004196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		[SerializeField]
		private Ease _chaosBuffHideEase;

		[Token(Token = "0x4004197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31C")]
		[SerializeField]
		private float _chaosBuffItemStaggerDelay;

		[Token(Token = "0x4004198")]
		private const float ChaosBuffAutoCloseDelay = 1f;

		[Token(Token = "0x4004199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		private readonly List<ChaosBuffItem> _chaosBuffItems;

		[Token(Token = "0x400419A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		private Vector2 _chaosBuffContentRestPos;

		[Token(Token = "0x400419B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		private bool _chaosBuffPanelTweening;

		[Token(Token = "0x400419C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x331")]
		private bool _chaosBuffPanelClosing;

		[Token(Token = "0x400419D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x332")]
		private bool _chaosBuffPanelVisible;

		[Token(Token = "0x400419E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x333")]
		private bool _chaosBuffAllowAutoClose;

		[Token(Token = "0x400419F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x334")]
		private bool _chaosBuffAutoShowTriggered;

		[Token(Token = "0x40041A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		private CancellationTokenSource _chaosBuffAutoCloseCts;

		[Token(Token = "0x40041A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		private Vector2 _beginPos;

		[Token(Token = "0x40041A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		private bool isShowGameCheat;

		[Token(Token = "0x40041A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34C")]
		private Vector2 guideBornPos;

		[Token(Token = "0x40041A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		private GameObject screenEmojiPropRes;

		[Token(Token = "0x40041A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Color SelectLightingValidColor;

		[Token(Token = "0x40041A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Color SelectLightingInvalidColor;

		[Token(Token = "0x40041A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		private bool isShowSendEmojis;

		[Token(Token = "0x40041A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x361")]
		private bool showSendEmojisTweening;

		[Token(Token = "0x40041A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x362")]
		private bool canShowSendEmojiUI;

		[Token(Token = "0x40041AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
		private GameObject playerObj;

		[Token(Token = "0x40041AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
		private GameObject enemyObj;

		[Token(Token = "0x40041AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
		private Vector3 playerPos;

		[Token(Token = "0x40041AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x384")]
		private Vector3 enemyPos;

		[Token(Token = "0x40041AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
		private Vector3 readPos;

		[Token(Token = "0x40041AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
		private List<GameObject> allPlayerScreenEmojiPropObj;

		[Token(Token = "0x40041B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
		private List<GameObject> allEnemyScreenEmojiPropObj;

		[Token(Token = "0x40041B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
		private readonly List<GameObject> screenEmojiPropPool;

		[Token(Token = "0x6003113")]
		[Address(RVA = "0x4057774", Offset = "0x4053774", VA = "0x4057774", Slot = "4")]
		[AsyncStateMachine(typeof(_003CAwake_003Ed__26))]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6003114")]
		[Address(RVA = "0x4057804", Offset = "0x4053804", VA = "0x4057804")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6003115")]
		[Address(RVA = "0x4057AB4", Offset = "0x4053AB4", VA = "0x4057AB4")]
		private void InitChaosBuffUI()
		{
		}

		[Token(Token = "0x6003116")]
		[Address(RVA = "0x4057E60", Offset = "0x4053E60", VA = "0x4057E60")]
		private void UpdateTopFile(object o)
		{
		}

		[Token(Token = "0x6003117")]
		[Address(RVA = "0x4057F54", Offset = "0x4053F54", VA = "0x4057F54")]
		private void OnCouncilCheatPanelTogShowCheatValueChanged(object o)
		{
		}

		[Token(Token = "0x6003118")]
		[Address(RVA = "0x4057FCC", Offset = "0x4053FCC", VA = "0x4057FCC")]
		[AsyncStateMachine(typeof(_003CDoAni_003Ed__31))]
		public void DoAni()
		{
		}

		[Token(Token = "0x6003119")]
		[Address(RVA = "0x4058058", Offset = "0x4054058", VA = "0x4058058", Slot = "9")]
		public override void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x600311A")]
		[Address(RVA = "0x4058228", Offset = "0x4054228", VA = "0x4058228")]
		public void UpdateWoodNum(object o)
		{
		}

		[Token(Token = "0x600311B")]
		[Address(RVA = "0x4058414", Offset = "0x4054414", VA = "0x4058414")]
		private void UpdatePlayerRoleCount(object o)
		{
		}

		[Token(Token = "0x600311C")]
		[Address(RVA = "0x405858C", Offset = "0x405458C", VA = "0x405858C")]
		private void UpdateEnemyRoleCount(object o)
		{
		}

		[Token(Token = "0x600311D")]
		[Address(RVA = "0x4058704", Offset = "0x4054704", VA = "0x4058704", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__36))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600311E")]
		[Address(RVA = "0x40587B0", Offset = "0x40547B0", VA = "0x40587B0")]
		private void OnShowCheat(object o)
		{
		}

		[Token(Token = "0x600311F")]
		[Address(RVA = "0x40587B4", Offset = "0x40547B4", VA = "0x40587B4")]
		private void OnCheatEnemyArtifactStateChanged(object o)
		{
		}

		[Token(Token = "0x6003120")]
		[Address(RVA = "0x40587B8", Offset = "0x40547B8", VA = "0x40587B8")]
		private void ApplyEnemyArtifactCheatVisibility()
		{
		}

		[Token(Token = "0x6003121")]
		[Address(RVA = "0x40587BC", Offset = "0x40547BC", VA = "0x40587BC")]
		private void OnCloseMatchPanelForChaosBuff(object o)
		{
		}

		[Token(Token = "0x6003122")]
		[Address(RVA = "0x405893C", Offset = "0x405493C", VA = "0x405893C")]
		private void OnLookBuffBtnClicked()
		{
		}

		[Token(Token = "0x6003123")]
		[Address(RVA = "0x4058A30", Offset = "0x4054A30", VA = "0x4058A30")]
		private void OnHideChaosBuffPanelBtnClicked()
		{
		}

		[Token(Token = "0x6003124")]
		[Address(RVA = "0x4058850", Offset = "0x4054850", VA = "0x4058850")]
		private void ShowChaosBuffPanelImmediate()
		{
		}

		[Token(Token = "0x6003125")]
		[Address(RVA = "0x4058A1C", Offset = "0x4054A1C", VA = "0x4058A1C")]
		private void ShowChaosBuffPanelAnimated()
		{
		}

		[Token(Token = "0x6003126")]
		[Address(RVA = "0x4058E2C", Offset = "0x4054E2C", VA = "0x4058E2C")]
		[AsyncStateMachine(typeof(_003CShowChaosBuffPanelAnimatedAsync_003Ed__45))]
		private UniTask ShowChaosBuffPanelAnimatedAsync()
		{
			return default;
		}

		[Token(Token = "0x6003127")]
		[Address(RVA = "0x4058A78", Offset = "0x4054A78", VA = "0x4058A78")]
		private void HideChaosBuffPanelAnimated()
		{
		}

		[Token(Token = "0x6003128")]
		[Address(RVA = "0x4058EC0", Offset = "0x4054EC0", VA = "0x4058EC0")]
		[AsyncStateMachine(typeof(_003CHideChaosBuffPanelAnimatedAsync_003Ed__47))]
		private UniTask HideChaosBuffPanelAnimatedAsync()
		{
			return default;
		}

		[Token(Token = "0x6003129")]
		[Address(RVA = "0x4058D94", Offset = "0x4054D94", VA = "0x4058D94")]
		private void StartChaosBuffAutoCloseTimer()
		{
		}

		[Token(Token = "0x600312A")]
		[Address(RVA = "0x4058F48", Offset = "0x4054F48", VA = "0x4058F48")]
		[AsyncStateMachine(typeof(_003CWaitChaosBuffAutoCloseAsync_003Ed__49))]
		private UniTask WaitChaosBuffAutoCloseAsync(CancellationToken token)
		{
			return default;
		}

		[Token(Token = "0x600312B")]
		[Address(RVA = "0x40579FC", Offset = "0x40539FC", VA = "0x40579FC")]
		private void CancelChaosBuffAutoCloseTimer()
		{
		}

		[Token(Token = "0x600312C")]
		[Address(RVA = "0x4058FF0", Offset = "0x4054FF0", VA = "0x4058FF0")]
		private Vector2 GetChaosBuffContentPosFromBtn()
		{
			return default;
		}

		[Token(Token = "0x600312D")]
		[Address(RVA = "0x4057D88", Offset = "0x4053D88", VA = "0x4057D88")]
		private void ResetChaosBuffContentToRest()
		{
		}

		[Token(Token = "0x600312E")]
		[Address(RVA = "0x4057A34", Offset = "0x4053A34", VA = "0x4057A34")]
		private void KillChaosBuffContentTween()
		{
		}

		[Token(Token = "0x600312F")]
		[Address(RVA = "0x40591C0", Offset = "0x40551C0", VA = "0x40591C0")]
		private void CleanupChaosBuffPanelTween()
		{
		}

		[Token(Token = "0x6003130")]
		[Address(RVA = "0x405936C", Offset = "0x405536C", VA = "0x405936C")]
		private void SetChaosBuffCloseButtonInteractable(bool interactable)
		{
		}

		[Token(Token = "0x6003131")]
		[Address(RVA = "0x4059450", Offset = "0x4055450", VA = "0x4059450")]
		private void SetChaosBuffLookButtonInteractable(bool interactable)
		{
		}

		[Token(Token = "0x6003132")]
		[Address(RVA = "0x4058C94", Offset = "0x4054C94", VA = "0x4058C94")]
		private void PlayChaosBuffItemsShowAnimation(bool immediate)
		{
		}

		[Token(Token = "0x6003133")]
		[Address(RVA = "0x4059284", Offset = "0x4055284", VA = "0x4059284")]
		private void KillChaosBuffItemsShowAnimation()
		{
		}

		[Token(Token = "0x6003134")]
		[Address(RVA = "0x4058124", Offset = "0x4054124", VA = "0x4058124")]
		private void RefreshChaosBuffUI(bool hidePanel)
		{
		}

		[Token(Token = "0x6003135")]
		[Address(RVA = "0x4058A8C", Offset = "0x4054A8C", VA = "0x4058A8C")]
		private void RefreshChaosBuffList(bool prepareForShow = false)
		{
		}

		[Token(Token = "0x6003136")]
		[Address(RVA = "0x40594E8", Offset = "0x40554E8", VA = "0x40594E8")]
		private ChaosBuffItem GetChaosBuffItem(int index)
		{
			return null;
		}

		[Token(Token = "0x6003137")]
		[Address(RVA = "0x40587F0", Offset = "0x40547F0", VA = "0x40587F0")]
		private bool CanShowChaosBuffUI()
		{
			return default;
		}

		[Token(Token = "0x6003138")]
		[Address(RVA = "0x4058984", Offset = "0x4054984", VA = "0x4058984")]
		private void HideChaosBuffUI()
		{
		}

		[Token(Token = "0x6003139")]
		[Address(RVA = "0x4059698", Offset = "0x4055698", VA = "0x4059698")]
		private void HideChaosBuffItems()
		{
		}

		[Token(Token = "0x600313A")]
		[Address(RVA = "0x40597F8", Offset = "0x40557F8", VA = "0x40597F8")]
		[AsyncStateMachine(typeof(_003CBlessUpdateUI_003Ed__65))]
		private void BlessUpdateUI()
		{
		}

		[Token(Token = "0x600313B")]
		[Address(RVA = "0x4059888", Offset = "0x4055888", VA = "0x4059888")]
		[AsyncStateMachine(typeof(_003CInitEmojiSystem_003Ed__66))]
		private UniTask InitEmojiSystem()
		{
			return default;
		}

		[Token(Token = "0x600313C")]
		[Address(RVA = "0x4059914", Offset = "0x4055914", VA = "0x4059914")]
		[AsyncStateMachine(typeof(_003CLoadSpineEmojiResources_003Ed__67))]
		private UniTask LoadSpineEmojiResources(List<string> expressionIds)
		{
			return default;
		}

		[Token(Token = "0x600313D")]
		[Address(RVA = "0x40599C0", Offset = "0x40559C0", VA = "0x40599C0")]
		[AsyncStateMachine(typeof(_003CShowEmojisWithSpine_003Ed__68))]
		private UniTask ShowEmojisWithSpine(int index, bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x600313E")]
		[Address(RVA = "0x4059A78", Offset = "0x4055A78", VA = "0x4059A78")]
		private void EnemyClickHorn(object o)
		{
		}

		[Token(Token = "0x600313F")]
		[Address(RVA = "0x4059B5C", Offset = "0x4055B5C", VA = "0x4059B5C")]
		private void OnSkillItemSkillItemClicked(object o)
		{
		}

		[Token(Token = "0x6003140")]
		[Address(RVA = "0x4059C40", Offset = "0x4055C40", VA = "0x4059C40", Slot = "25")]
		[AsyncStateMachine(typeof(_003COnButtonExtendBtnGuideClicked_003Ed__71))]
		protected override void OnButtonExtendBtnGuideClicked()
		{
		}

		[Token(Token = "0x6003141")]
		[Address(RVA = "0x4059CCC", Offset = "0x4055CCC", VA = "0x4059CCC")]
		private void GuideDoAni(object o)
		{
		}

		[Token(Token = "0x6003142")]
		[Address(RVA = "0x4059DAC", Offset = "0x4055DAC", VA = "0x4059DAC", Slot = "14")]
		protected override void OnButtonExtendBtnSendEmojisClicked()
		{
		}

		[Token(Token = "0x6003143")]
		[Address(RVA = "0x4059DE4", Offset = "0x4055DE4", VA = "0x4059DE4")]
		private void SetImgEmojisBgState(bool active)
		{
		}

		[Token(Token = "0x6003144")]
		[Address(RVA = "0x4059F14", Offset = "0x4055F14", VA = "0x4059F14")]
		private void EnmeySendEnmojis(object o)
		{
		}

		[Token(Token = "0x6003145")]
		[Address(RVA = "0x405A02C", Offset = "0x405602C", VA = "0x405A02C")]
		private void EnemySendWords(object o)
		{
		}

		[Token(Token = "0x6003146")]
		[Address(RVA = "0x405A48C", Offset = "0x405648C", VA = "0x405A48C", Slot = "15")]
		protected override void OnButtonExtendBtnWordBg1Clicked()
		{
		}

		[Token(Token = "0x6003147")]
		[Address(RVA = "0x405A80C", Offset = "0x405680C", VA = "0x405A80C", Slot = "16")]
		protected override void OnButtonExtendBtnWordBg2Clicked()
		{
		}

		[Token(Token = "0x6003148")]
		[Address(RVA = "0x405A850", Offset = "0x4056850", VA = "0x405A850", Slot = "17")]
		protected override void OnButtonExtendBtnWordBg3Clicked()
		{
		}

		[Token(Token = "0x6003149")]
		[Address(RVA = "0x405A894", Offset = "0x4056894", VA = "0x405A894", Slot = "18")]
		protected override void OnButtonExtendBtnWordBg4Clicked()
		{
		}

		[Token(Token = "0x600314A")]
		[Address(RVA = "0x405A8D8", Offset = "0x40568D8", VA = "0x405A8D8", Slot = "19")]
		protected override void OnButtonExtendBtnEmojisThinkClicked()
		{
		}

		[Token(Token = "0x600314B")]
		[Address(RVA = "0x405A998", Offset = "0x4056998", VA = "0x405A998", Slot = "20")]
		protected override void OnButtonExtendBtnEmojisLaughClicked()
		{
		}

		[Token(Token = "0x600314C")]
		[Address(RVA = "0x405A9B8", Offset = "0x40569B8", VA = "0x405A9B8", Slot = "21")]
		protected override void OnButtonExtendBtnEmojisCryClicked()
		{
		}

		[Token(Token = "0x600314D")]
		[Address(RVA = "0x405A9D8", Offset = "0x40569D8", VA = "0x405A9D8", Slot = "22")]
		protected override void OnButtonExtendBtnEmojisAngryClicked()
		{
		}

		[Token(Token = "0x600314E")]
		[Address(RVA = "0x405A9F8", Offset = "0x40569F8", VA = "0x405A9F8", Slot = "23")]
		[AsyncStateMachine(typeof(_003COnButtonExtendBtnBanEmojisClicked_003Ed__87))]
		protected override void OnButtonExtendBtnBanEmojisClicked()
		{
		}

		[Token(Token = "0x600314F")]
		[Address(RVA = "0x405A8F8", Offset = "0x40568F8", VA = "0x405A8F8")]
		[AsyncStateMachine(typeof(_003CShowEmojis_003Ed__89))]
		private void ShowEmojis(int id)
		{
		}

		[Token(Token = "0x6003150")]
		[Address(RVA = "0x405A4D0", Offset = "0x40564D0", VA = "0x405A4D0")]
		private void ShowWordText(string str)
		{
		}

		[Token(Token = "0x6003151")]
		[Address(RVA = "0x4059F8C", Offset = "0x4055F8C", VA = "0x4059F8C")]
		[AsyncStateMachine(typeof(_003CEnemyShowEmoji_003Ed__91))]
		private void EnemyShowEmoji(int id)
		{
		}

		[Token(Token = "0x6003152")]
		[Address(RVA = "0x405A1A4", Offset = "0x40561A4", VA = "0x405A1A4")]
		private void EnemyShowWordText(string str)
		{
		}

		[Token(Token = "0x6003153")]
		[Address(RVA = "0x405AA88", Offset = "0x4056A88", VA = "0x405AA88")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6003154")]
		[Address(RVA = "0x405ADA0", Offset = "0x4056DA0", VA = "0x405ADA0")]
		private GameObject GetOrCreateScreenEmojiProp(bool isEnemy)
		{
			return null;
		}

		[Token(Token = "0x6003155")]
		[Address(RVA = "0x405AFB8", Offset = "0x4056FB8", VA = "0x405AFB8")]
		public void ShowScreenEmojiUI(int id, bool isEnemy, ref List<GameObject> list)
		{
		}

		[Token(Token = "0x6003156")]
		[Address(RVA = "0x405B184", Offset = "0x4057184", VA = "0x405B184")]
		private void PlayerUseProp(object id)
		{
		}

		[Token(Token = "0x6003157")]
		[Address(RVA = "0x405B188", Offset = "0x4057188", VA = "0x405B188")]
		private void EnemyUseProp(object id)
		{
		}

		[Token(Token = "0x6003158")]
		[Address(RVA = "0x405B18C", Offset = "0x405718C", VA = "0x405B18C")]
		private void RotateSelfAndImmediateChildren(Transform target)
		{
		}

		[Token(Token = "0x6003159")]
		[Address(RVA = "0x405B1F8", Offset = "0x40571F8", VA = "0x405B1F8")]
		private void ApplyRotation(Transform target)
		{
		}

		[Token(Token = "0x600315A")]
		[Address(RVA = "0x405B230", Offset = "0x4057230", VA = "0x405B230", Slot = "24")]
		protected override void OnButtonExtendImgPlayerBlessBgClicked()
		{
		}

		[Token(Token = "0x600315B")]
		[Address(RVA = "0x405B52C", Offset = "0x405752C", VA = "0x405B52C", Slot = "27")]
		protected override void OnButtonExtendImgEnemyBlessBgClicked()
		{
		}

		[Token(Token = "0x600315C")]
		[Address(RVA = "0x405B7EC", Offset = "0x40577EC", VA = "0x405B7EC", Slot = "26")]
		protected override void OnButtonExtendRightBGClicked()
		{
		}

		[Token(Token = "0x600315D")]
		[Address(RVA = "0x405C2EC", Offset = "0x40582EC", VA = "0x405C2EC", Slot = "28")]
		protected override void OnBtnCloseClicked()
		{
		}

		[Token(Token = "0x600315E")]
		[Address(RVA = "0x405B878", Offset = "0x4057878", VA = "0x405B878")]
		private void UpdateEnemyCheatInfo()
		{
		}

		[Token(Token = "0x600315F")]
		[Address(RVA = "0x405C32C", Offset = "0x405832C", VA = "0x405C32C")]
		public void ShowDragArrow(Vector3 circleWorldPos, Vector2 startScreenPos)
		{
		}

		[Token(Token = "0x6003160")]
		[Address(RVA = "0x405C594", Offset = "0x4058594", VA = "0x405C594")]
		public void HideDragArrow()
		{
		}

		[Token(Token = "0x6003161")]
		[Address(RVA = "0x405C640", Offset = "0x4058640", VA = "0x405C640", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6003162")]
		[Address(RVA = "0x405CCF0", Offset = "0x4058CF0", VA = "0x405CCF0")]
		public void ShowSelectLighting()
		{
		}

		[Token(Token = "0x6003163")]
		[Address(RVA = "0x405CCF8", Offset = "0x4058CF8", VA = "0x405CCF8")]
		public void ShowSelectLighting(bool isValid)
		{
		}

		[Token(Token = "0x6003164")]
		[Address(RVA = "0x405CDC0", Offset = "0x4058DC0", VA = "0x405CDC0")]
		public void UpdateSelectLightingState(bool isValid)
		{
		}

		[Token(Token = "0x6003165")]
		[Address(RVA = "0x405CC38", Offset = "0x4058C38", VA = "0x405CC38")]
		public void HideSelectLighting()
		{
		}

		[Token(Token = "0x6003166")]
		[Address(RVA = "0x405CEE4", Offset = "0x4058EE4", VA = "0x405CEE4")]
		public GamePanel()
		{
		}
	}
}
