using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TimeModuleO;
using ToolModule;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000464")]
	public class GameManager : ManagerBase<GameManager>
	{
		[Token(Token = "0x2000466")]
		[CompilerGenerated]
		private sealed class _003CCheckNetworkState_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4002ADC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4002ADD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4002ADE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GameManager _003C_003E4__this;

			[Token(Token = "0x17000143")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600159C")]
				[Address(RVA = "0x3E1CF4C", Offset = "0x3E18F4C", VA = "0x3E1CF4C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000144")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600159E")]
				[Address(RVA = "0x3E1CF8C", Offset = "0x3E18F8C", VA = "0x3E1CF8C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6001599")]
			[Address(RVA = "0x3E19988", Offset = "0x3E15988", VA = "0x3E19988")]
			[DebuggerHidden]
			public _003CCheckNetworkState_003Ed__14(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600159A")]
			[Address(RVA = "0x3E1CAF0", Offset = "0x3E18AF0", VA = "0x3E1CAF0", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600159B")]
			[Address(RVA = "0x3E1CAF4", Offset = "0x3E18AF4", VA = "0x3E1CAF4", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600159C")]
			[Address(RVA = "0x3E1CF4C", Offset = "0x3E18F4C", VA = "0x3E1CF4C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600159D")]
			[Address(RVA = "0x3E1CF54", Offset = "0x3E18F54", VA = "0x3E1CF54", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600159E")]
			[Address(RVA = "0x3E1CF8C", Offset = "0x3E18F8C", VA = "0x3E1CF8C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000467")]
		[CompilerGenerated]
		private struct _003CEnterMeta_003Ed__20 : IAsyncStateMachine
		{
			[Token(Token = "0x4002ADF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002AE0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002AE1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public object obj;

			[Token(Token = "0x600159F")]
			[Address(RVA = "0x3E1CF94", Offset = "0x3E18F94", VA = "0x3E1CF94", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60015A0")]
			[Address(RVA = "0x3E1D2E4", Offset = "0x3E192E4", VA = "0x3E1D2E4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000468")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__9 : IAsyncStateMachine
		{
			[Token(Token = "0x4002AE2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002AE3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002AE4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameManager _003C_003E4__this;

			[Token(Token = "0x4002AE5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60015A1")]
			[Address(RVA = "0x3E1D2F0", Offset = "0x3E192F0", VA = "0x3E1D2F0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60015A2")]
			[Address(RVA = "0x3E1F2C4", Offset = "0x3E1B2C4", VA = "0x3E1F2C4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000469")]
		[CompilerGenerated]
		private struct _003CShowCardProbabilityPanel_003Ed__24 : IAsyncStateMachine
		{
			[Token(Token = "0x4002AE6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002AE7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002AE8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60015A3")]
			[Address(RVA = "0x3E1F2D0", Offset = "0x3E1B2D0", VA = "0x3E1F2D0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60015A4")]
			[Address(RVA = "0x3E1F66C", Offset = "0x3E1B66C", VA = "0x3E1F66C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002AC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool InitComplete;

		[Token(Token = "0x4002AC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		private bool _isFirstThroghGame;

		[Token(Token = "0x4002AC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateController updateController;

		[Token(Token = "0x4002AC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject APostProcess;

		[Token(Token = "0x4002AC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameObject BPostProcess;

		[Token(Token = "0x4002AC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TimeManager.Timer canPushGiftPackTimer;

		[Token(Token = "0x4002ACA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TimeManager.Timer pushGiftPackCutDownTimer;

		[Token(Token = "0x4002ACB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TimeManager.Timer pushGiftPackCdTimer;

		[Token(Token = "0x4002ACC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Action onGameManagerInitComplete;

		[Token(Token = "0x4002ACD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool showNoInternetPanel;

		[Token(Token = "0x4002ACE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool _cheatGamePaused;

		[Token(Token = "0x4002ACF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TimeManager.Timer monthPass;

		[Token(Token = "0x4002AD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool closeLoadPanel;

		[Token(Token = "0x600157A")]
		[Address(RVA = "0x3E197C0", Offset = "0x3E157C0", VA = "0x3E197C0", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__9))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x600157B")]
		[Address(RVA = "0x3E1984C", Offset = "0x3E1584C", VA = "0x3E1984C")]
		public void RegisterOnGameManagerInitComplete(Action action)
		{
		}

		[Token(Token = "0x600157C")]
		[Address(RVA = "0x3E198F0", Offset = "0x3E158F0", VA = "0x3E198F0")]
		private void Update()
		{
		}

		[Token(Token = "0x600157D")]
		[Address(RVA = "0x3E19928", Offset = "0x3E15928", VA = "0x3E19928")]
		[IteratorStateMachine(typeof(_003CCheckNetworkState_003Ed__14))]
		private IEnumerator CheckNetworkState()
		{
			return null;
		}

		[Token(Token = "0x600157E")]
		[Address(RVA = "0x3E199B0", Offset = "0x3E159B0", VA = "0x3E199B0")]
		private void PauseGame()
		{
		}

		[Token(Token = "0x600157F")]
		[Address(RVA = "0x3E19AB8", Offset = "0x3E15AB8", VA = "0x3E19AB8")]
		private void ResumeGame()
		{
		}

		[Token(Token = "0x6001580")]
		[Address(RVA = "0x3E19924", Offset = "0x3E15924", VA = "0x3E19924")]
		private void CheckMonthPass()
		{
		}

		[Token(Token = "0x6001581")]
		[Address(RVA = "0x3E19BC0", Offset = "0x3E15BC0", VA = "0x3E19BC0")]
		private void StartCoreGame(object obj)
		{
		}

		[Token(Token = "0x6001582")]
		[Address(RVA = "0x3E19D38", Offset = "0x3E15D38", VA = "0x3E19D38")]
		[AsyncStateMachine(typeof(_003CEnterMeta_003Ed__20))]
		private void EnterMeta(object obj)
		{
		}

		[Token(Token = "0x6001583")]
		[Address(RVA = "0x3E19DC4", Offset = "0x3E15DC4", VA = "0x3E19DC4")]
		private void RegisterOnTimeToZero()
		{
		}

		[Token(Token = "0x6001584")]
		[Address(RVA = "0x3E1A2C4", Offset = "0x3E162C4", VA = "0x3E1A2C4")]
		private void RegisterOnTimeToMonDayZero()
		{
		}

		[Token(Token = "0x6001585")]
		[Address(RVA = "0x3E1A5B8", Offset = "0x3E165B8", VA = "0x3E1A5B8")]
		private void DanChangeUpdateInfo(object o)
		{
		}

		[Token(Token = "0x6001586")]
		[Address(RVA = "0x3E1A608", Offset = "0x3E16608", VA = "0x3E1A608")]
		[AsyncStateMachine(typeof(_003CShowCardProbabilityPanel_003Ed__24))]
		private void ShowCardProbabilityPanel(object o)
		{
		}

		[Token(Token = "0x6001587")]
		[Address(RVA = "0x3E1A690", Offset = "0x3E16690", VA = "0x3E1A690")]
		private void CardSteerEnd(object o)
		{
		}

		[Token(Token = "0x6001588")]
		[Address(RVA = "0x3E1A694", Offset = "0x3E16694", VA = "0x3E1A694")]
		public void ShowConfirmPanel(string titleStr, string contentStr, string buttonTextStr, bool canCancelPanel, Action<bool> onClick)
		{
		}

		[Token(Token = "0x6001589")]
		[Address(RVA = "0x3E1A864", Offset = "0x3E16864", VA = "0x3E1A864")]
		private void FetterSteerEnd(object o)
		{
		}

		[Token(Token = "0x600158A")]
		[Address(RVA = "0x3E1A918", Offset = "0x3E16918", VA = "0x3E1A918")]
		private void CloseLoadPanel(object o)
		{
		}

		[Token(Token = "0x600158B")]
		[Address(RVA = "0x3E1A9EC", Offset = "0x3E169EC", VA = "0x3E1A9EC")]
		private void LoadEnd(object o)
		{
		}

		[Token(Token = "0x600158C")]
		[Address(RVA = "0x3E1AA70", Offset = "0x3E16A70", VA = "0x3E1AA70")]
		public GameManager()
		{
		}
	}
}
