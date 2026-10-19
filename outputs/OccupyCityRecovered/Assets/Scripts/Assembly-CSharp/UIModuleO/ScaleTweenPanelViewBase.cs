using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000690")]
	public abstract class ScaleTweenPanelViewBase : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000691")]
		[CompilerGenerated]
		private struct _003CHideAsync_003Ed__9 : IAsyncStateMachine
		{
			[Token(Token = "0x40034FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40034FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003500")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ScaleTweenPanelViewBase _003C_003E4__this;

			[Token(Token = "0x4003501")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60022CC")]
			[Address(RVA = "0x3F3D854", Offset = "0x3F39854", VA = "0x3F3D854", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60022CD")]
			[Address(RVA = "0x3F3E108", Offset = "0x3F3A108", VA = "0x3F3E108", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000692")]
		[CompilerGenerated]
		private struct _003CShowAsync_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x4003502")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ScaleTweenPanelViewBase _003C_003E4__this;

			[Token(Token = "0x4003505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60022CE")]
			[Address(RVA = "0x3F3E114", Offset = "0x3F3A114", VA = "0x3F3E114", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60022CF")]
			[Address(RVA = "0x3F3E950", Offset = "0x3F3A950", VA = "0x3F3E950", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40034FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PanelScaleTweenHandler _panelTween;

		[Token(Token = "0x170001E8")]
		public bool IsPanelTweenPlaying
		{
			[Token(Token = "0x60022BD")]
			[Address(RVA = "0x3F3D284", Offset = "0x3F39284", VA = "0x3F3D284")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001E9")]
		protected PanelScaleTweenHandler PanelTween
		{
			[Token(Token = "0x60022BE")]
			[Address(RVA = "0x3F3D30C", Offset = "0x3F3930C", VA = "0x3F3D30C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60022BF")]
		[Address(RVA = "0x3F3D314", Offset = "0x3F39314", VA = "0x3F3D314", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60022C0")]
		[Address(RVA = "0x3F3D444", Offset = "0x3F39444", VA = "0x3F3D444")]
		public void Show()
		{
		}

		[Token(Token = "0x60022C1")]
		[Address(RVA = "0x3F3D460", Offset = "0x3F39460", VA = "0x3F3D460")]
		public void Hide()
		{
		}

		[Token(Token = "0x60022C2")]
		[Address(RVA = "0x3F3D47C", Offset = "0x3F3947C", VA = "0x3F3D47C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShowAsync_003Ed__8))]
		public virtual UniTask ShowAsync()
		{
			return default;
		}

		[Token(Token = "0x60022C3")]
		[Address(RVA = "0x3F3D508", Offset = "0x3F39508", VA = "0x3F3D508", Slot = "6")]
		[AsyncStateMachine(typeof(_003CHideAsync_003Ed__9))]
		public virtual UniTask HideAsync()
		{
			return default;
		}

		[Token(Token = "0x60022C4")]
		[Address(RVA = "0x3F3D594", Offset = "0x3F39594", VA = "0x3F3D594", Slot = "7")]
		protected virtual bool ShouldPlayShowTween()
		{
			return default;
		}

		[Token(Token = "0x60022C5")]
		[Address(RVA = "0x3F3D628", Offset = "0x3F39628", VA = "0x3F3D628", Slot = "8")]
		protected virtual RectTransform ResolveTweenTarget()
		{
			return null;
		}

		[Token(Token = "0x60022C6")]
		[Address(RVA = "0x3F3D6F4", Offset = "0x3F396F4", VA = "0x3F3D6F4", Slot = "9")]
		protected virtual UniTask OnBeforeShowAsync()
		{
			return default;
		}

		[Token(Token = "0x60022C7")]
		[Address(RVA = "0x3F3D74C", Offset = "0x3F3974C", VA = "0x3F3D74C", Slot = "10")]
		protected virtual UniTask OnAfterShowAsync()
		{
			return default;
		}

		[Token(Token = "0x60022C8")]
		[Address(RVA = "0x3F3D7A4", Offset = "0x3F397A4", VA = "0x3F3D7A4", Slot = "11")]
		protected virtual UniTask OnBeforeHideAsync()
		{
			return default;
		}

		[Token(Token = "0x60022C9")]
		[Address(RVA = "0x3F3D7FC", Offset = "0x3F397FC", VA = "0x3F3D7FC", Slot = "12")]
		protected virtual UniTask OnAfterHideAsync()
		{
			return default;
		}

		[Token(Token = "0x60022CA")]
		[Address(RVA = "0x3F3D318", Offset = "0x3F39318", VA = "0x3F3D318")]
		private void EnsurePanelTween()
		{
		}

		[Token(Token = "0x60022CB")]
		[Address(RVA = "0x3F3BA30", Offset = "0x3F37A30", VA = "0x3F3BA30")]
		protected ScaleTweenPanelViewBase()
		{
		}
	}
}
