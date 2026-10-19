using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DBTSDK;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000B0C")]
	public class SettingsPanel : SettingsPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B0D")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x40050C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40050CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40050CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SettingsPanel _003C_003E4__this;

			[Token(Token = "0x40050CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60042F9")]
			[Address(RVA = "0x41D6EE4", Offset = "0x41D2EE4", VA = "0x41D6EE4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60042FA")]
			[Address(RVA = "0x41D7198", Offset = "0x41D3198", VA = "0x41D7198", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x2000B0E")]
		[CompilerGenerated]
		private sealed class _003CVerifyCdkTimeOut_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40050CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40050CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40050CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SettingsPanel _003C_003E4__this;

			[Token(Token = "0x17000ACC")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60042FE")]
				[Address(RVA = "0x41D72B8", Offset = "0x41D32B8", VA = "0x41D72B8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000ACD")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6004300")]
				[Address(RVA = "0x41D72F8", Offset = "0x41D32F8", VA = "0x41D72F8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60042FB")]
			[Address(RVA = "0x41D63BC", Offset = "0x41D23BC", VA = "0x41D63BC")]
			[DebuggerHidden]
			public _003CVerifyCdkTimeOut_003Ed__21(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60042FC")]
			[Address(RVA = "0x41D71A4", Offset = "0x41D31A4", VA = "0x41D71A4", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60042FD")]
			[Address(RVA = "0x41D71A8", Offset = "0x41D31A8", VA = "0x41D71A8", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60042FE")]
			[Address(RVA = "0x41D72B8", Offset = "0x41D32B8", VA = "0x41D72B8", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60042FF")]
			[Address(RVA = "0x41D72C0", Offset = "0x41D32C0", VA = "0x41D72C0", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6004300")]
			[Address(RVA = "0x41D72F8", Offset = "0x41D32F8", VA = "0x41D72F8", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x40050C5")]
		private const float CdkVerifyTimeoutSeconds = 10f;

		[Token(Token = "0x40050C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private TMP_Dropdown _dropdownLanguage;

		[Token(Token = "0x40050C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private bool _isCdkVerifying;

		[Token(Token = "0x40050C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Coroutine _cdkVerifyCoroutine;

		[Token(Token = "0x60042E0")]
		[Address(RVA = "0x41D4410", Offset = "0x41D0410", VA = "0x41D4410", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60042E1")]
		[Address(RVA = "0x41D4FF4", Offset = "0x41D0FF4", VA = "0x41D4FF4")]
		private void OnDropdownLanguageValueChanged(int index)
		{
		}

		[Token(Token = "0x60042E2")]
		[Address(RVA = "0x41D52D8", Offset = "0x41D12D8", VA = "0x41D52D8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__6))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60042E3")]
		[Address(RVA = "0x41D536C", Offset = "0x41D136C", VA = "0x41D536C", Slot = "34")]
		protected override void OnButtonExtendCloseBtnClicked()
		{
		}

		[Token(Token = "0x60042E4")]
		[Address(RVA = "0x41D53F8", Offset = "0x41D13F8", VA = "0x41D53F8", Slot = "27")]
		protected override void OnButtonExtendRestoreBtnClicked()
		{
		}

		[Token(Token = "0x60042E5")]
		[Address(RVA = "0x41D54FC", Offset = "0x41D14FC", VA = "0x41D54FC", Slot = "12")]
		protected override void OnButtonBlackClicked()
		{
		}

		[Token(Token = "0x60042E6")]
		[Address(RVA = "0x41D5588", Offset = "0x41D1588", VA = "0x41D5588", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60042E7")]
		[Address(RVA = "0x41D5724", Offset = "0x41D1724", VA = "0x41D5724")]
		private void OnLogoutFinish(params object[] args)
		{
		}

		[Token(Token = "0x60042E8")]
		[Address(RVA = "0x41D57F4", Offset = "0x41D17F4", VA = "0x41D57F4", Slot = "28")]
		protected override void OnButtonExtendConnectAccountClicked()
		{
		}

		[Token(Token = "0x60042E9")]
		[Address(RVA = "0x41D5910", Offset = "0x41D1910", VA = "0x41D5910", Slot = "29")]
		protected override void OnButtonExtendDisconnectAccountClicked()
		{
		}

		[Token(Token = "0x60042EA")]
		[Address(RVA = "0x41D4ED8", Offset = "0x41D0ED8", VA = "0x41D4ED8")]
		private void SwitchAccountButtons()
		{
		}

		[Token(Token = "0x60042EB")]
		[Address(RVA = "0x41D5BC0", Offset = "0x41D1BC0", VA = "0x41D5BC0", Slot = "17")]
		protected override void OnButtonExtendCdkBtnClicked()
		{
		}

		[Token(Token = "0x60042EC")]
		[Address(RVA = "0x41D5D28", Offset = "0x41D1D28", VA = "0x41D5D28", Slot = "38")]
		protected override void OnButtonExtendCloseCdkPanelBtnClicked()
		{
		}

		[Token(Token = "0x60042ED")]
		[Address(RVA = "0x41D5EF4", Offset = "0x41D1EF4", VA = "0x41D5EF4", Slot = "35")]
		protected override void OnButtonCdkPanelMaskClicked()
		{
		}

		[Token(Token = "0x60042EE")]
		[Address(RVA = "0x41D5F78", Offset = "0x41D1F78", VA = "0x41D5F78", Slot = "37")]
		protected override void OnButtonExtendConfirmBtnClicked()
		{
		}

		[Token(Token = "0x60042EF")]
		[Address(RVA = "0x41D5C44", Offset = "0x41D1C44", VA = "0x41D5C44")]
		private void ShowCdkPanel()
		{
		}

		[Token(Token = "0x60042F0")]
		[Address(RVA = "0x41D5DAC", Offset = "0x41D1DAC", VA = "0x41D5DAC")]
		private void HideCdkPanel()
		{
		}

		[Token(Token = "0x60042F1")]
		[Address(RVA = "0x41D635C", Offset = "0x41D235C", VA = "0x41D635C")]
		[IteratorStateMachine(typeof(_003CVerifyCdkTimeOut_003Ed__21))]
		private IEnumerator VerifyCdkTimeOut()
		{
			return null;
		}

		[Token(Token = "0x60042F2")]
		[Address(RVA = "0x41D63E4", Offset = "0x41D23E4", VA = "0x41D63E4")]
		private void OnVerifyCdk(int code, CDKInfo info)
		{
		}

		[Token(Token = "0x60042F3")]
		[Address(RVA = "0x41D564C", Offset = "0x41D164C", VA = "0x41D564C")]
		private void StopCdkVerifyCoroutine()
		{
		}

		[Token(Token = "0x60042F4")]
		[Address(RVA = "0x41D6924", Offset = "0x41D2924", VA = "0x41D6924", Slot = "18")]
		protected override void OnButtonExtendAnnouncementBtnClicked()
		{
		}

		[Token(Token = "0x60042F5")]
		[Address(RVA = "0x41D69E8", Offset = "0x41D29E8", VA = "0x41D69E8")]
		public SettingsPanel()
		{
		}
	}
}
