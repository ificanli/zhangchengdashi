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
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000933")]
	public class MainCityEventPanel : MainCityEventPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000935")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x40044E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40044E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40044E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MainCityEventPanel _003C_003E4__this;

			[Token(Token = "0x40044E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x40044E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003543")]
			[Address(RVA = "0x40B4CC0", Offset = "0x40B0CC0", VA = "0x40B4CC0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003544")]
			[Address(RVA = "0x40B75EC", Offset = "0x40B35EC", VA = "0x40B75EC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000936")]
		[CompilerGenerated]
		private struct _003CUpdateBuilding_003Ed__12 : IAsyncStateMachine
		{
			[Token(Token = "0x40044E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40044E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40044EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MainCityEventPanel _003C_003E4__this;

			[Token(Token = "0x40044EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private List<GlobalMainCityAssetsInfo> _003Cconfigs_003E5__2;

			[Token(Token = "0x40044EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Image _003C_003E7__wrap2;

			[Token(Token = "0x40044ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003545")]
			[Address(RVA = "0x40B75F8", Offset = "0x40B35F8", VA = "0x40B75F8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003546")]
			[Address(RVA = "0x40B87A0", Offset = "0x40B47A0", VA = "0x40B87A0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000937")]
		[CompilerGenerated]
		private struct _003CUpdateShowPanel_003Ed__11 : IAsyncStateMachine
		{
			[Token(Token = "0x40044EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40044EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40044F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string eventType;

			[Token(Token = "0x40044F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MainCityEventPanel _003C_003E4__this;

			[Token(Token = "0x40044F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003547")]
			[Address(RVA = "0x40B87AC", Offset = "0x40B47AC", VA = "0x40B87AC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003548")]
			[Address(RVA = "0x40B9800", Offset = "0x40B5800", VA = "0x40B9800", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40044D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private EnemyBattleDataCofig enemyConfig;

		[Token(Token = "0x40044D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private List<UserHeroCardData> enemyCardDatas;

		[Token(Token = "0x40044D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private bool isBattleWin;

		[Token(Token = "0x40044D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private string familyNameKey;

		[Token(Token = "0x40044DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private string enemyNumber;

		[Token(Token = "0x40044DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private List<string> curBuildingList;

		[Token(Token = "0x40044DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private bool _isRecycle;

		[Token(Token = "0x40044DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		private float _scaleFactor;

		[Token(Token = "0x40044DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private float _duration;

		[Token(Token = "0x40044DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Sequence sq;

		[Token(Token = "0x600352A")]
		[Address(RVA = "0x40B31B0", Offset = "0x40AF1B0", VA = "0x40B31B0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__10))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600352B")]
		[Address(RVA = "0x40B324C", Offset = "0x40AF24C", VA = "0x40B324C")]
		[AsyncStateMachine(typeof(_003CUpdateShowPanel_003Ed__11))]
		public UniTask UpdateShowPanel(string eventType)
		{
			return default;
		}

		[Token(Token = "0x600352C")]
		[Address(RVA = "0x40B32E8", Offset = "0x40AF2E8", VA = "0x40B32E8")]
		[AsyncStateMachine(typeof(_003CUpdateBuilding_003Ed__12))]
		public UniTask UpdateBuilding()
		{
			return default;
		}

		[Token(Token = "0x600352D")]
		[Address(RVA = "0x40B3378", Offset = "0x40AF378", VA = "0x40B3378", Slot = "12")]
		protected override void OnButtonExtendHpBuilding1Clicked()
		{
		}

		[Token(Token = "0x600352E")]
		[Address(RVA = "0x40B36BC", Offset = "0x40AF6BC", VA = "0x40B36BC", Slot = "13")]
		protected override void OnButtonExtendHpBuilding2Clicked()
		{
		}

		[Token(Token = "0x600352F")]
		[Address(RVA = "0x40B3938", Offset = "0x40AF938", VA = "0x40B3938", Slot = "14")]
		protected override void OnButtonExtendAtkBuilding1Clicked()
		{
		}

		[Token(Token = "0x6003530")]
		[Address(RVA = "0x40B3BB4", Offset = "0x40AFBB4", VA = "0x40B3BB4", Slot = "15")]
		protected override void OnButtonExtendAtkBuilding2Clicked()
		{
		}

		[Token(Token = "0x6003531")]
		[Address(RVA = "0x40B3E30", Offset = "0x40AFE30", VA = "0x40B3E30", Slot = "19")]
		protected override void OnButtonExtendSureClicked()
		{
		}

		[Token(Token = "0x6003532")]
		[Address(RVA = "0x40B3FA0", Offset = "0x40AFFA0", VA = "0x40B3FA0", Slot = "18")]
		protected override void OnButtonExtendRunClicked()
		{
		}

		[Token(Token = "0x6003533")]
		[Address(RVA = "0x40B4150", Offset = "0x40B0150", VA = "0x40B4150", Slot = "17")]
		protected override void OnButtonExtendFightClicked()
		{
		}

		[Token(Token = "0x6003534")]
		[Address(RVA = "0x40B42C0", Offset = "0x40B02C0", VA = "0x40B42C0", Slot = "16")]
		protected override void OnButtonExtendEnemyInfoClicked()
		{
		}

		[Token(Token = "0x6003535")]
		[Address(RVA = "0x40B4530", Offset = "0x40B0530", VA = "0x40B4530", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6003536")]
		[Address(RVA = "0x40B478C", Offset = "0x40B078C", VA = "0x40B478C")]
		public MainCityEventPanel()
		{
		}
	}
}
