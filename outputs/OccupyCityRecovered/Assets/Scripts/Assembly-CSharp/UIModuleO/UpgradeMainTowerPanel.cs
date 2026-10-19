using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using GameModule;
using Il2CppDummyDll;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000BD8")]
	public class UpgradeMainTowerPanel : UpgradeMainTowerPanelComponents, IPanelOnOnSecondClick
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BD9")]
		[CompilerGenerated]
		private struct _003CAwake_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x400560A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400560B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400560C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UpgradeMainTowerPanel _003C_003E4__this;

			[Token(Token = "0x600493D")]
			[Address(RVA = "0x4245AB4", Offset = "0x4241AB4", VA = "0x4245AB4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600493E")]
			[Address(RVA = "0x4245E00", Offset = "0x4241E00", VA = "0x4245E00", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BDA")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__13 : IAsyncStateMachine
		{
			[Token(Token = "0x400560D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400560E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400560F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UpgradeMainTowerPanel _003C_003E4__this;

			[Token(Token = "0x4005610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x4005611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600493F")]
			[Address(RVA = "0x4245E0C", Offset = "0x4241E0C", VA = "0x4245E0C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004940")]
			[Address(RVA = "0x424693C", Offset = "0x424293C", VA = "0x424693C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Tween tw;

		[Token(Token = "0x4005602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion rota;

		[Token(Token = "0x4005603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private CameraMoveBehaviour mainCameraMoveBehaviour;

		[Token(Token = "0x4005604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private NewMainCityItem newMainCityItem;

		[Token(Token = "0x4005605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool _isMainCityItemCreated;

		[Token(Token = "0x4005606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Tween scaleTween;

		[Token(Token = "0x4005607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float ftime;

		[Token(Token = "0x4005608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool ro;

		[Token(Token = "0x4005609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion qu;

		[Token(Token = "0x600492C")]
		[Address(RVA = "0x4245268", Offset = "0x4241268", VA = "0x4245268", Slot = "4")]
		[AsyncStateMachine(typeof(_003CAwake_003Ed__5))]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600492D")]
		[Address(RVA = "0x42452F4", Offset = "0x42412F4", VA = "0x42452F4")]
		private void UpgradeTalent(object o)
		{
		}

		[Token(Token = "0x600492E")]
		[Address(RVA = "0x42452FC", Offset = "0x42412FC", VA = "0x42452FC")]
		private void UpdateLevel(object o)
		{
		}

		[Token(Token = "0x600492F")]
		[Address(RVA = "0x42452F8", Offset = "0x42412F8", VA = "0x42452F8")]
		private void UpdatePropertyUI()
		{
		}

		[Token(Token = "0x6004930")]
		[Address(RVA = "0x4245300", Offset = "0x4241300", VA = "0x4245300", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__13))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004931")]
		[Address(RVA = "0x4245398", Offset = "0x4241398", VA = "0x4245398", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004932")]
		[Address(RVA = "0x42454D8", Offset = "0x42414D8", VA = "0x42454D8")]
		public void HideOrShowUIGroup(object parm)
		{
		}

		[Token(Token = "0x6004933")]
		[Address(RVA = "0x42456A4", Offset = "0x42416A4", VA = "0x42456A4", Slot = "12")]
		public void PanelOnOnSecondClickInit()
		{
		}

		[Token(Token = "0x6004934")]
		[Address(RVA = "0x4245760", Offset = "0x4241760", VA = "0x4245760", Slot = "13")]
		public void OnSecondClick(object o)
		{
		}

		[Token(Token = "0x6004935")]
		[Address(RVA = "0x4245898", Offset = "0x4241898", VA = "0x4245898", Slot = "14")]
		public void OnHide()
		{
		}

		[Token(Token = "0x6004936")]
		[Address(RVA = "0x424589C", Offset = "0x424189C", VA = "0x424589C")]
		public UpgradeMainTowerPanel()
		{
		}
	}
}
