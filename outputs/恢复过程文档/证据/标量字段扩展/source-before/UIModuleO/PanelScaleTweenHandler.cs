using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace UIModuleO
{
	[Token(Token = "0x200068D")]
	public class PanelScaleTweenHandler : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200068E")]
		[CompilerGenerated]
		private struct _003CHideAsync_003Ed__42 : IAsyncStateMachine
		{
			[Token(Token = "0x40034F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40034F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40034F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PanelScaleTweenHandler _003C_003E4__this;

			[Token(Token = "0x40034F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x60022B9")]
			[Address(RVA = "0x3F3C8DC", Offset = "0x3F388DC", VA = "0x3F3C8DC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60022BA")]
			[Address(RVA = "0x3F3CD9C", Offset = "0x3F38D9C", VA = "0x3F3CD9C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200068F")]
		[CompilerGenerated]
		private struct _003CShowAsync_003Ed__41 : IAsyncStateMachine
		{
			[Token(Token = "0x40034F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40034FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40034FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PanelScaleTweenHandler _003C_003E4__this;

			[Token(Token = "0x40034FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x60022BB")]
			[Address(RVA = "0x3F3CDA8", Offset = "0x3F38DA8", VA = "0x3F3CDA8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60022BC")]
			[Address(RVA = "0x3F3D278", Offset = "0x3F39278", VA = "0x3F3D278", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40034E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _tweenTarget;

		[Token(Token = "0x40034E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _visibilityRoot;

		[Token(Token = "0x40034E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _duration;

		[Token(Token = "0x40034E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _showScale;

		[Token(Token = "0x40034E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _hideScale;

		[Token(Token = "0x40034E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Ease _showEase;

		[Token(Token = "0x40034EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Ease _hideEase;

		[Token(Token = "0x40034EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private bool _useUnscaledTime;

		[Token(Token = "0x40034EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UnityEvent _onShowStarted;

		[Token(Token = "0x40034ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UnityEvent _onShowCompleted;

		[Token(Token = "0x40034EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UnityEvent _onHideStarted;

		[Token(Token = "0x40034EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UnityEvent _onHideCompleted;

		[Token(Token = "0x40034F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[CompilerGenerated]
		private Action m_ShowStarted;

		[Token(Token = "0x40034F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[CompilerGenerated]
		private Action m_ShowCompleted;

		[Token(Token = "0x40034F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[CompilerGenerated]
		private Action m_HideStarted;

		[Token(Token = "0x40034F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[CompilerGenerated]
		private Action m_HideCompleted;

		[Token(Token = "0x170001E3")]
		public bool IsPlaying
		{
			[Token(Token = "0x600229E")]
			[Address(RVA = "0x3F3BF10", Offset = "0x3F37F10", VA = "0x3F3BF10")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x600229F")]
			[Address(RVA = "0x3F3BF18", Offset = "0x3F37F18", VA = "0x3F3BF18")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170001E4")]
		public UnityEvent OnShowStarted
		{
			[Token(Token = "0x60022A8")]
			[Address(RVA = "0x3F3C404", Offset = "0x3F38404", VA = "0x3F3C404")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001E5")]
		public UnityEvent OnShowCompleted
		{
			[Token(Token = "0x60022A9")]
			[Address(RVA = "0x3F3C40C", Offset = "0x3F3840C", VA = "0x3F3C40C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001E6")]
		public UnityEvent OnHideStarted
		{
			[Token(Token = "0x60022AA")]
			[Address(RVA = "0x3F3C414", Offset = "0x3F38414", VA = "0x3F3C414")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001E7")]
		public UnityEvent OnHideCompleted
		{
			[Token(Token = "0x60022AB")]
			[Address(RVA = "0x3F3C41C", Offset = "0x3F3841C", VA = "0x3F3C41C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000004")]
		public event Action ShowStarted
		{
			[Token(Token = "0x60022A0")]
			[Address(RVA = "0x3F3BF24", Offset = "0x3F37F24", VA = "0x3F3BF24")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60022A1")]
			[Address(RVA = "0x3F3BFC0", Offset = "0x3F37FC0", VA = "0x3F3BFC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event Action ShowCompleted
		{
			[Token(Token = "0x60022A2")]
			[Address(RVA = "0x3F3C05C", Offset = "0x3F3805C", VA = "0x3F3C05C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60022A3")]
			[Address(RVA = "0x3F3C0F8", Offset = "0x3F380F8", VA = "0x3F3C0F8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event Action HideStarted
		{
			[Token(Token = "0x60022A4")]
			[Address(RVA = "0x3F3C194", Offset = "0x3F38194", VA = "0x3F3C194")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60022A5")]
			[Address(RVA = "0x3F3C230", Offset = "0x3F38230", VA = "0x3F3C230")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event Action HideCompleted
		{
			[Token(Token = "0x60022A6")]
			[Address(RVA = "0x3F3C2CC", Offset = "0x3F382CC", VA = "0x3F3C2CC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60022A7")]
			[Address(RVA = "0x3F3C368", Offset = "0x3F38368", VA = "0x3F3C368")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60022AC")]
		[Address(RVA = "0x3F3C424", Offset = "0x3F38424", VA = "0x3F3C424")]
		private void Awake()
		{
		}

		[Token(Token = "0x60022AD")]
		[Address(RVA = "0x3F3C504", Offset = "0x3F38504", VA = "0x3F3C504")]
		public void Configure(RectTransform tweenTarget, [Optional] GameObject visibilityRoot)
		{
		}

		[Token(Token = "0x60022AE")]
		[Address(RVA = "0x3F3C5A4", Offset = "0x3F385A4", VA = "0x3F3C5A4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60022AF")]
		[Address(RVA = "0x3F3C5BC", Offset = "0x3F385BC", VA = "0x3F3C5BC")]
		public void Show()
		{
		}

		[Token(Token = "0x60022B0")]
		[Address(RVA = "0x3F3C658", Offset = "0x3F38658", VA = "0x3F3C658")]
		public void Hide()
		{
		}

		[Token(Token = "0x60022B1")]
		[Address(RVA = "0x3F3C5D0", Offset = "0x3F385D0", VA = "0x3F3C5D0")]
		[AsyncStateMachine(typeof(_003CShowAsync_003Ed__41))]
		public UniTask ShowAsync()
		{
			return default;
		}

		[Token(Token = "0x60022B2")]
		[Address(RVA = "0x3F3C66C", Offset = "0x3F3866C", VA = "0x3F3C66C")]
		[AsyncStateMachine(typeof(_003CHideAsync_003Ed__42))]
		public UniTask HideAsync()
		{
			return default;
		}

		[Token(Token = "0x60022B3")]
		[Address(RVA = "0x3F3C6F4", Offset = "0x3F386F4", VA = "0x3F3C6F4")]
		public void PrepareHidden()
		{
		}

		[Token(Token = "0x60022B4")]
		[Address(RVA = "0x3F3C7C4", Offset = "0x3F387C4", VA = "0x3F3C7C4")]
		private void RaiseShowStarted()
		{
		}

		[Token(Token = "0x60022B5")]
		[Address(RVA = "0x3F3C800", Offset = "0x3F38800", VA = "0x3F3C800")]
		private void RaiseShowCompleted()
		{
		}

		[Token(Token = "0x60022B6")]
		[Address(RVA = "0x3F3C83C", Offset = "0x3F3883C", VA = "0x3F3C83C")]
		private void RaiseHideStarted()
		{
		}

		[Token(Token = "0x60022B7")]
		[Address(RVA = "0x3F3C878", Offset = "0x3F38878", VA = "0x3F3C878")]
		private void RaiseHideCompleted()
		{
		}

		[Token(Token = "0x60022B8")]
		[Address(RVA = "0x3F3C8B4", Offset = "0x3F388B4", VA = "0x3F3C8B4")]
		public PanelScaleTweenHandler()
		{
		}
	}
}
