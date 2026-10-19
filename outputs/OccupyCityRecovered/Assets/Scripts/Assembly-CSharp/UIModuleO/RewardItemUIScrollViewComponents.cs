using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UIFramework;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000ADD")]
	public class RewardItemUIScrollViewComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000ADE")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__201 : IAsyncStateMachine
		{
			[Token(Token = "0x4004F9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004F9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004F9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public RewardItemUIScrollViewComponents _003C_003E4__this;

			[Token(Token = "0x4004FA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60041A5")]
			[Address(RVA = "0x41BE830", Offset = "0x41BA830", VA = "0x41BE830", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60041A6")]
			[Address(RVA = "0x41BEAA8", Offset = "0x41BAAA8", VA = "0x41BEAA8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004F9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ScrollRect _scrollRectRewardItemUIScrollView;

		[Token(Token = "0x4004F9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformContent;

		[Token(Token = "0x4004F9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformRewardItemUI;

		[Token(Token = "0x17000A69")]
		public ScrollRect ScrollRectRewardItemUIScrollView
		{
			[Token(Token = "0x600419B")]
			[Address(RVA = "0x41BE564", Offset = "0x41BA564", VA = "0x41BE564")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A6A")]
		public RectTransform RectTransformContent
		{
			[Token(Token = "0x600419C")]
			[Address(RVA = "0x41BE0AC", Offset = "0x41BA0AC", VA = "0x41BE0AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A6B")]
		public RectTransform RectTransformRewardItemUI
		{
			[Token(Token = "0x600419D")]
			[Address(RVA = "0x41BDFE4", Offset = "0x41B9FE4", VA = "0x41BDFE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600419E")]
		[Address(RVA = "0x41BE608", Offset = "0x41BA608", VA = "0x41BE608")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x600419F")]
		[Address(RVA = "0x41BE6A4", Offset = "0x41BA6A4", VA = "0x41BE6A4", Slot = "12")]
		protected virtual void OnScrollRectRewardItemUIScrollViewValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x60041A0")]
		[Address(RVA = "0x41BE758", Offset = "0x41BA758", VA = "0x41BE758", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60041A1")]
		[Address(RVA = "0x41BE298", Offset = "0x41BA298", VA = "0x41BE298", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__201))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60041A2")]
		[Address(RVA = "0x41BE774", Offset = "0x41BA774", VA = "0x41BE774", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60041A3")]
		[Address(RVA = "0x41BE28C", Offset = "0x41BA28C", VA = "0x41BE28C")]
		public RewardItemUIScrollViewComponents()
		{
		}
	}
}
