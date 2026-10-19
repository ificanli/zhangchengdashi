using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x20007D5")]
	public class OutsiderCheatPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007D6")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__157 : IAsyncStateMachine
		{
			[Token(Token = "0x4003C6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003C6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003C6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public OutsiderCheatPanelComponents _003C_003E4__this;

			[Token(Token = "0x4003C70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002B78")]
			[Address(RVA = "0x3FEC5D0", Offset = "0x3FE85D0", VA = "0x3FEC5D0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002B79")]
			[Address(RVA = "0x3FEC848", Offset = "0x3FE8848", VA = "0x3FEC848", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003C67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBtnClose;

		[Token(Token = "0x4003C68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformBG;

		[Token(Token = "0x4003C69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ButtonExtend _buttonExtendBtnAddCoin;

		[Token(Token = "0x4003C6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ButtonExtend _buttonExtendBtnWin;

		[Token(Token = "0x4003C6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ButtonExtend _buttonExtendBtnLose;

		[Token(Token = "0x4003C6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ButtonExtend _buttonExtendBtnAddProp;

		[Token(Token = "0x1700048C")]
		public ButtonExtend ButtonExtendBtnClose
		{
			[Token(Token = "0x6002B67")]
			[Address(RVA = "0x3FEBEDC", Offset = "0x3FE7EDC", VA = "0x3FEBEDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700048D")]
		public RectTransform RectTransformBG
		{
			[Token(Token = "0x6002B68")]
			[Address(RVA = "0x3FEBA68", Offset = "0x3FE7A68", VA = "0x3FEBA68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700048E")]
		public ButtonExtend ButtonExtendBtnAddCoin
		{
			[Token(Token = "0x6002B69")]
			[Address(RVA = "0x3FEBFA4", Offset = "0x3FE7FA4", VA = "0x3FEBFA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700048F")]
		public ButtonExtend ButtonExtendBtnWin
		{
			[Token(Token = "0x6002B6A")]
			[Address(RVA = "0x3FEC06C", Offset = "0x3FE806C", VA = "0x3FEC06C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000490")]
		public ButtonExtend ButtonExtendBtnLose
		{
			[Token(Token = "0x6002B6B")]
			[Address(RVA = "0x3FEC134", Offset = "0x3FE8134", VA = "0x3FEC134")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000491")]
		public ButtonExtend ButtonExtendBtnAddProp
		{
			[Token(Token = "0x6002B6C")]
			[Address(RVA = "0x3FEC1FC", Offset = "0x3FE81FC", VA = "0x3FEC1FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002B6D")]
		[Address(RVA = "0x3FEC2C4", Offset = "0x3FE82C4", VA = "0x3FEC2C4")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002B6E")]
		[Address(RVA = "0x3FEB9FC", Offset = "0x3FE79FC", VA = "0x3FEB9FC", Slot = "12")]
		protected virtual void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x6002B6F")]
		[Address(RVA = "0x3FEBB88", Offset = "0x3FE7B88", VA = "0x3FEBB88", Slot = "13")]
		protected virtual void OnButtonExtendBtnAddCoinClicked()
		{
		}

		[Token(Token = "0x6002B70")]
		[Address(RVA = "0x3FEBC50", Offset = "0x3FE7C50", VA = "0x3FEBC50", Slot = "14")]
		protected virtual void OnButtonExtendBtnWinClicked()
		{
		}

		[Token(Token = "0x6002B71")]
		[Address(RVA = "0x3FEBD18", Offset = "0x3FE7D18", VA = "0x3FEBD18", Slot = "15")]
		protected virtual void OnButtonExtendBtnLoseClicked()
		{
		}

		[Token(Token = "0x6002B72")]
		[Address(RVA = "0x3FEBE60", Offset = "0x3FE7E60", VA = "0x3FEBE60", Slot = "16")]
		protected virtual void OnButtonExtendBtnAddPropClicked()
		{
		}

		[Token(Token = "0x6002B73")]
		[Address(RVA = "0x3FEC464", Offset = "0x3FE8464", VA = "0x3FEC464", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002B74")]
		[Address(RVA = "0x3FEC480", Offset = "0x3FE8480", VA = "0x3FEC480", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__157))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002B75")]
		[Address(RVA = "0x3FEC514", Offset = "0x3FE8514", VA = "0x3FEC514", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002B76")]
		[Address(RVA = "0x3FEBED4", Offset = "0x3FE7ED4", VA = "0x3FEBED4")]
		public OutsiderCheatPanelComponents()
		{
		}
	}
}
