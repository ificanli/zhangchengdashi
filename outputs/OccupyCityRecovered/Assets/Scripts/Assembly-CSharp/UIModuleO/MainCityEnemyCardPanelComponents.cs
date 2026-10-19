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
	[Token(Token = "0x2000931")]
	public class MainCityEnemyCardPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000932")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__204 : IAsyncStateMachine
		{
			[Token(Token = "0x40044D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40044D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40044D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MainCityEnemyCardPanelComponents _003C_003E4__this;

			[Token(Token = "0x40044D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003528")]
			[Address(RVA = "0x40B2F2C", Offset = "0x40AEF2C", VA = "0x40B2F2C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003529")]
			[Address(RVA = "0x40B31A4", Offset = "0x40AF1A4", VA = "0x40B31A4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40044C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Button _buttonBg;

		[Token(Token = "0x40044C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformTop;

		[Token(Token = "0x40044C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformEquipContent;

		[Token(Token = "0x40044C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Button _buttonCardItem1;

		[Token(Token = "0x40044CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Button _buttonCardItem2;

		[Token(Token = "0x40044CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Button _buttonCardItem3;

		[Token(Token = "0x40044CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Button _buttonCardItem4;

		[Token(Token = "0x40044CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Button _buttonCardItem5;

		[Token(Token = "0x40044CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Button _buttonCardItem6;

		[Token(Token = "0x40044CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Button _buttonCardItem7;

		[Token(Token = "0x40044D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Button _buttonCardItem8;

		[Token(Token = "0x40044D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Button _buttonBtnCancel;

		[Token(Token = "0x1700075C")]
		public Button ButtonBg
		{
			[Token(Token = "0x600350C")]
			[Address(RVA = "0x40B1FC4", Offset = "0x40ADFC4", VA = "0x40B1FC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700075D")]
		public RectTransform RectTransformTop
		{
			[Token(Token = "0x600350D")]
			[Address(RVA = "0x40B0298", Offset = "0x40AC298", VA = "0x40B0298")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700075E")]
		public RectTransform RectTransformEquipContent
		{
			[Token(Token = "0x600350E")]
			[Address(RVA = "0x40AFEF0", Offset = "0x40ABEF0", VA = "0x40AFEF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700075F")]
		public Button ButtonCardItem1
		{
			[Token(Token = "0x600350F")]
			[Address(RVA = "0x40B208C", Offset = "0x40AE08C", VA = "0x40B208C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000760")]
		public Button ButtonCardItem2
		{
			[Token(Token = "0x6003510")]
			[Address(RVA = "0x40B2154", Offset = "0x40AE154", VA = "0x40B2154")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000761")]
		public Button ButtonCardItem3
		{
			[Token(Token = "0x6003511")]
			[Address(RVA = "0x40B221C", Offset = "0x40AE21C", VA = "0x40B221C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000762")]
		public Button ButtonCardItem4
		{
			[Token(Token = "0x6003512")]
			[Address(RVA = "0x40B22E4", Offset = "0x40AE2E4", VA = "0x40B22E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000763")]
		public Button ButtonCardItem5
		{
			[Token(Token = "0x6003513")]
			[Address(RVA = "0x40B23AC", Offset = "0x40AE3AC", VA = "0x40B23AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000764")]
		public Button ButtonCardItem6
		{
			[Token(Token = "0x6003514")]
			[Address(RVA = "0x40B2474", Offset = "0x40AE474", VA = "0x40B2474")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000765")]
		public Button ButtonCardItem7
		{
			[Token(Token = "0x6003515")]
			[Address(RVA = "0x40B253C", Offset = "0x40AE53C", VA = "0x40B253C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000766")]
		public Button ButtonCardItem8
		{
			[Token(Token = "0x6003516")]
			[Address(RVA = "0x40B2604", Offset = "0x40AE604", VA = "0x40B2604")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000767")]
		public Button ButtonBtnCancel
		{
			[Token(Token = "0x6003517")]
			[Address(RVA = "0x40B26CC", Offset = "0x40AE6CC", VA = "0x40B26CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003518")]
		[Address(RVA = "0x40B2794", Offset = "0x40AE794", VA = "0x40B2794")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6003519")]
		[Address(RVA = "0x40B2A88", Offset = "0x40AEA88", VA = "0x40B2A88", Slot = "12")]
		protected virtual void OnButtonBgClicked()
		{
		}

		[Token(Token = "0x600351A")]
		[Address(RVA = "0x40B2AF4", Offset = "0x40AEAF4", VA = "0x40B2AF4", Slot = "13")]
		protected virtual void OnButtonCardItem1Clicked()
		{
		}

		[Token(Token = "0x600351B")]
		[Address(RVA = "0x40B2B60", Offset = "0x40AEB60", VA = "0x40B2B60", Slot = "14")]
		protected virtual void OnButtonCardItem2Clicked()
		{
		}

		[Token(Token = "0x600351C")]
		[Address(RVA = "0x40B2BCC", Offset = "0x40AEBCC", VA = "0x40B2BCC", Slot = "15")]
		protected virtual void OnButtonCardItem3Clicked()
		{
		}

		[Token(Token = "0x600351D")]
		[Address(RVA = "0x40B2C38", Offset = "0x40AEC38", VA = "0x40B2C38", Slot = "16")]
		protected virtual void OnButtonCardItem4Clicked()
		{
		}

		[Token(Token = "0x600351E")]
		[Address(RVA = "0x40B2CA4", Offset = "0x40AECA4", VA = "0x40B2CA4", Slot = "17")]
		protected virtual void OnButtonCardItem5Clicked()
		{
		}

		[Token(Token = "0x600351F")]
		[Address(RVA = "0x40B2D10", Offset = "0x40AED10", VA = "0x40B2D10", Slot = "18")]
		protected virtual void OnButtonCardItem6Clicked()
		{
		}

		[Token(Token = "0x6003520")]
		[Address(RVA = "0x40B2D7C", Offset = "0x40AED7C", VA = "0x40B2D7C", Slot = "19")]
		protected virtual void OnButtonCardItem7Clicked()
		{
		}

		[Token(Token = "0x6003521")]
		[Address(RVA = "0x40B2DE8", Offset = "0x40AEDE8", VA = "0x40B2DE8", Slot = "20")]
		protected virtual void OnButtonCardItem8Clicked()
		{
		}

		[Token(Token = "0x6003522")]
		[Address(RVA = "0x40B022C", Offset = "0x40AC22C", VA = "0x40B022C", Slot = "21")]
		protected virtual void OnButtonBtnCancelClicked()
		{
		}

		[Token(Token = "0x6003523")]
		[Address(RVA = "0x40B2E54", Offset = "0x40AEE54", VA = "0x40B2E54", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6003524")]
		[Address(RVA = "0x40B0374", Offset = "0x40AC374", VA = "0x40B0374", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__204))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003525")]
		[Address(RVA = "0x40B2E70", Offset = "0x40AEE70", VA = "0x40B2E70", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6003526")]
		[Address(RVA = "0x40B0368", Offset = "0x40AC368", VA = "0x40B0368")]
		public MainCityEnemyCardPanelComponents()
		{
		}
	}
}
