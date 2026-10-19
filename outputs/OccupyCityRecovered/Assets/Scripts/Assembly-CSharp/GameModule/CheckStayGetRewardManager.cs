using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using ToolModule;

namespace GameModule
{
	[Token(Token = "0x200043A")]
	public class CheckStayGetRewardManager : ManagerBase<CheckStayGetRewardManager>
	{
		[Token(Token = "0x200043B")]
		[CompilerGenerated]
		private sealed class _003CInTurnOpenBoxAndNewCardPanel_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40029E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40029E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40029EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CheckStayGetRewardManager _003C_003E4__this;

			[Token(Token = "0x40029EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public object o;

			[Token(Token = "0x40029EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int _003Cboxcount_003E5__2;

			[Token(Token = "0x40029ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int _003Ccardcount_003E5__3;

			[Token(Token = "0x40029EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int _003Ci_003E5__4;

			[Token(Token = "0x17000138")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600148A")]
				[Address(RVA = "0x3E00AFC", Offset = "0x3DFCAFC", VA = "0x3E00AFC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000139")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600148C")]
				[Address(RVA = "0x3E00B3C", Offset = "0x3DFCB3C", VA = "0x3E00B3C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6001487")]
			[Address(RVA = "0x3E00190", Offset = "0x3DFC190", VA = "0x3E00190")]
			[DebuggerHidden]
			public _003CInTurnOpenBoxAndNewCardPanel_003Ed__5(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6001488")]
			[Address(RVA = "0x3E00698", Offset = "0x3DFC698", VA = "0x3E00698", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6001489")]
			[Address(RVA = "0x3E0069C", Offset = "0x3DFC69C", VA = "0x3E0069C", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600148A")]
			[Address(RVA = "0x3E00AFC", Offset = "0x3DFCAFC", VA = "0x3E00AFC", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600148B")]
			[Address(RVA = "0x3E00B04", Offset = "0x3DFCB04", VA = "0x3E00B04", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600148C")]
			[Address(RVA = "0x3E00B3C", Offset = "0x3DFCB3C", VA = "0x3E00B3C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200043C")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x40029EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40029F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40029F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CheckStayGetRewardManager _003C_003E4__this;

			[Token(Token = "0x600148D")]
			[Address(RVA = "0x3E00B44", Offset = "0x3DFCB44", VA = "0x3E00B44", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600148E")]
			[Address(RVA = "0x3E00EB0", Offset = "0x3DFCEB0", VA = "0x3E00EB0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40029E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<UserBoxData> userStayOpenBoxData;

		[Token(Token = "0x40029E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<string> userStayGetCardData;

		[Token(Token = "0x40029E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool _isOpenBoxPanelIng;

		[Token(Token = "0x6001480")]
		[Address(RVA = "0x3DFFEA0", Offset = "0x3DFBEA0", VA = "0x3DFFEA0", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__2))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6001481")]
		[Address(RVA = "0x3DFFF24", Offset = "0x3DFBF24", VA = "0x3DFFF24")]
		private void ShowOpenBoxPanel(object o)
		{
		}

		[Token(Token = "0x6001482")]
		[Address(RVA = "0x3E00124", Offset = "0x3DFC124", VA = "0x3E00124")]
		[IteratorStateMachine(typeof(_003CInTurnOpenBoxAndNewCardPanel_003Ed__5))]
		private IEnumerator InTurnOpenBoxAndNewCardPanel(object o)
		{
			return null;
		}

		[Token(Token = "0x6001483")]
		[Address(RVA = "0x3E001B8", Offset = "0x3DFC1B8", VA = "0x3E001B8")]
		public void GetNewCardAni()
		{
		}

		[Token(Token = "0x6001484")]
		[Address(RVA = "0x3E002E8", Offset = "0x3DFC2E8", VA = "0x3E002E8")]
		public void GetLastCardAndShowPanel(bool ShowGetNewCardPanel = true)
		{
		}

		[Token(Token = "0x6001485")]
		[Address(RVA = "0x3E00648", Offset = "0x3DFC648", VA = "0x3E00648")]
		private void OpenBoxPanelEnd(object o)
		{
		}

		[Token(Token = "0x6001486")]
		[Address(RVA = "0x3E00650", Offset = "0x3DFC650", VA = "0x3E00650")]
		public CheckStayGetRewardManager()
		{
		}
	}
}
