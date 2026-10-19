using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using DataModule;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x200082C")]
	public class ExpressionViewLoopItem : ExpressionViewLoopItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200082D")]
		[CompilerGenerated]
		private struct _003CLoadAndApplyBgSprite_003Ed__15 : IAsyncStateMachine
		{
			[Token(Token = "0x4003E57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003E58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003E59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ExpressionViewLoopItem _003C_003E4__this;

			[Token(Token = "0x4003E5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002DCD")]
			[Address(RVA = "0x4012864", Offset = "0x400E864", VA = "0x4012864", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002DCE")]
			[Address(RVA = "0x4012E40", Offset = "0x400EE40", VA = "0x4012E40", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200082E")]
		[CompilerGenerated]
		private struct _003CLoadAndApplySpine_003Ed__16 : IAsyncStateMachine
		{
			[Token(Token = "0x4003E5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003E5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003E5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ExpressionViewLoopItem _003C_003E4__this;

			[Token(Token = "0x4003E5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002DCF")]
			[Address(RVA = "0x4012E4C", Offset = "0x400EE4C", VA = "0x4012E4C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002DD0")]
			[Address(RVA = "0x40133E4", Offset = "0x400F3E4", VA = "0x40133E4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200082F")]
		[CompilerGenerated]
		private struct _003CLoadNewSpine_003Ed__17 : IAsyncStateMachine
		{
			[Token(Token = "0x4003E5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003E60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003E61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ExpressionViewLoopItem _003C_003E4__this;

			[Token(Token = "0x4003E62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<SkeletonDataAsset>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002DD1")]
			[Address(RVA = "0x40133F0", Offset = "0x400F3F0", VA = "0x40133F0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002DD2")]
			[Address(RVA = "0x40139E4", Offset = "0x400F9E4", VA = "0x40139E4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000830")]
		[CompilerGenerated]
		private struct _003CUpdateItem_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x4003E63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003E64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003E65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ExpressionViewLoopItem _003C_003E4__this;

			[Token(Token = "0x4003E66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GlobalExpression itemData;

			[Token(Token = "0x4003E67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ExpressionView parentView;

			[Token(Token = "0x4003E68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002DD3")]
			[Address(RVA = "0x40139F0", Offset = "0x400F9F0", VA = "0x40139F0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002DD4")]
			[Address(RVA = "0x40140B8", Offset = "0x40100B8", VA = "0x40140B8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003E50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Color DimmedColor;

		[Token(Token = "0x4003E51")]
		private const float PitchOnAnimDuration = 0.15f;

		[Token(Token = "0x4003E52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GlobalExpression _itemData;

		[Token(Token = "0x4003E53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ExpressionView _parentView;

		[Token(Token = "0x4003E54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool _isOwned;

		[Token(Token = "0x4003E55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private string _displayedExpressionId;

		[Token(Token = "0x4003E56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Tween _pitchOnTween;

		[Token(Token = "0x6002DBC")]
		[Address(RVA = "0x401089C", Offset = "0x400C89C", VA = "0x401089C")]
		[AsyncStateMachine(typeof(_003CUpdateItem_003Ed__7))]
		public UniTask UpdateItem(int index, GlobalExpression itemData, [Optional] ExpressionView parentView)
		{
			return default;
		}

		[Token(Token = "0x6002DBD")]
		[Address(RVA = "0x4011B00", Offset = "0x400DB00", VA = "0x4011B00")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6002DBE")]
		[Address(RVA = "0x4011B18", Offset = "0x400DB18", VA = "0x4011B18", Slot = "12")]
		protected override void OnButtonExtendPitchOnButtonClicked()
		{
		}

		[Token(Token = "0x6002DBF")]
		[Address(RVA = "0x4011CD8", Offset = "0x400DCD8", VA = "0x4011CD8", Slot = "13")]
		protected override void OnButtonBgClicked()
		{
		}

		[Token(Token = "0x6002DC0")]
		[Address(RVA = "0x401214C", Offset = "0x400E14C", VA = "0x401214C")]
		private void UpdateSelectionUI(bool isSelected)
		{
		}

		[Token(Token = "0x6002DC1")]
		[Address(RVA = "0x4011F50", Offset = "0x400DF50", VA = "0x4011F50")]
		private void ShowPitchOnWithAnimation()
		{
		}

		[Token(Token = "0x6002DC2")]
		[Address(RVA = "0x4011E44", Offset = "0x400DE44", VA = "0x4011E44")]
		private void HidePitchOn()
		{
		}

		[Token(Token = "0x6002DC3")]
		[Address(RVA = "0x40122F0", Offset = "0x400E2F0", VA = "0x40122F0")]
		private static bool IsExpressionOwned(string expressionId)
		{
			return default;
		}

		[Token(Token = "0x6002DC4")]
		[Address(RVA = "0x4012394", Offset = "0x400E394", VA = "0x4012394")]
		[AsyncStateMachine(typeof(_003CLoadAndApplyBgSprite_003Ed__15))]
		private UniTask LoadAndApplyBgSprite()
		{
			return default;
		}

		[Token(Token = "0x6002DC5")]
		[Address(RVA = "0x4012424", Offset = "0x400E424", VA = "0x4012424")]
		[AsyncStateMachine(typeof(_003CLoadAndApplySpine_003Ed__16))]
		private UniTask LoadAndApplySpine()
		{
			return default;
		}

		[Token(Token = "0x6002DC6")]
		[Address(RVA = "0x40124B0", Offset = "0x400E4B0", VA = "0x40124B0")]
		[AsyncStateMachine(typeof(_003CLoadNewSpine_003Ed__17))]
		private UniTask LoadNewSpine()
		{
			return default;
		}

		[Token(Token = "0x6002DC7")]
		[Address(RVA = "0x4012540", Offset = "0x400E540", VA = "0x4012540")]
		private void UpdateSpineColor()
		{
		}

		[Token(Token = "0x6002DC8")]
		[Address(RVA = "0x40126F8", Offset = "0x400E6F8", VA = "0x40126F8")]
		private static void SetSpineToLastFrame(SkeletonGraphic skeletonGraphic)
		{
		}

		[Token(Token = "0x6002DC9")]
		[Address(RVA = "0x4011BB0", Offset = "0x400DBB0", VA = "0x4011BB0")]
		private void PlaySpineAnimation()
		{
		}

		[Token(Token = "0x6002DCA")]
		[Address(RVA = "0x40127FC", Offset = "0x400E7FC", VA = "0x40127FC")]
		public ExpressionViewLoopItem()
		{
		}
	}
}
