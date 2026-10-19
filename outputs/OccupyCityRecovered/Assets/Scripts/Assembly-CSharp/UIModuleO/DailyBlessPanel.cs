using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000855")]
	public class DailyBlessPanel : DailyBlessPanelComponents
	{
		[Token(Token = "0x2000856")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass8_0
		{
			[Token(Token = "0x4003F51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DailyBlessPanel _003C_003E4__this;

			[Token(Token = "0x4003F52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int i;

			[Token(Token = "0x4003F53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Predicate<GlobalBlessInfo> _003C_003E9__0;

			[Token(Token = "0x6002EEA")]
			[Address(RVA = "0x4027B40", Offset = "0x4023B40", VA = "0x4027B40")]
			public _003C_003Ec__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6002EEB")]
			[Address(RVA = "0x4027B48", Offset = "0x4023B48", VA = "0x4027B48")]
			internal bool _003CUpdateInfo_003Eb__0(GlobalBlessInfo x)
			{
				return default;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000857")]
		[CompilerGenerated]
		private struct _003CAwake_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x4003F54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003F55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003F56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DailyBlessPanel _003C_003E4__this;

			[Token(Token = "0x4003F57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002EEC")]
			[Address(RVA = "0x4027BC0", Offset = "0x4023BC0", VA = "0x4027BC0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002EED")]
			[Address(RVA = "0x40280A8", Offset = "0x40240A8", VA = "0x40280A8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000858")]
		[CompilerGenerated]
		private struct _003CChooseDailyBlessAnimation_003Ed__9 : IAsyncStateMachine
		{
			[Token(Token = "0x4003F58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003F59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003F5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DailyBlessPanel _003C_003E4__this;

			[Token(Token = "0x4003F5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public object o;

			[Token(Token = "0x4003F5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int _003Cindex_003E5__2;

			[Token(Token = "0x4003F5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Image _003C_003E7__wrap2;

			[Token(Token = "0x4003F5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4003F5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6002EEE")]
			[Address(RVA = "0x40280B4", Offset = "0x40240B4", VA = "0x40280B4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002EEF")]
			[Address(RVA = "0x4028EBC", Offset = "0x4024EBC", VA = "0x4028EBC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000859")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x4003F60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003F61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003F62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public DailyBlessPanel _003C_003E4__this;

			[Token(Token = "0x4003F63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002EF0")]
			[Address(RVA = "0x4028EC8", Offset = "0x4024EC8", VA = "0x4028EC8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002EF1")]
			[Address(RVA = "0x4029858", Offset = "0x4025858", VA = "0x4029858", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200085A")]
		[CompilerGenerated]
		private struct _003CUpdateInfo_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x4003F64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003F65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003F66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DailyBlessPanel _003C_003E4__this;

			[Token(Token = "0x4003F67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public object[] args;

			[Token(Token = "0x4003F68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private _003C_003Ec__DisplayClass8_0 _003C_003E8__1;

			[Token(Token = "0x4003F69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float _003CdelayTime_003E5__2;

			[Token(Token = "0x4003F6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private int _003CitemCount_003E5__3;

			[Token(Token = "0x4003F6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private int _003Ci_003E5__4;

			[Token(Token = "0x4003F6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002EF2")]
			[Address(RVA = "0x4029864", Offset = "0x4025864", VA = "0x4029864", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002EF3")]
			[Address(RVA = "0x4029F8C", Offset = "0x4025F8C", VA = "0x4029F8C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003F4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private GameObject res;

		[Token(Token = "0x4003F4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private List<GameObject> allObj;

		[Token(Token = "0x4003F4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<string> allBless;

		[Token(Token = "0x4003F4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<GlobalBlessInfo> info;

		[Token(Token = "0x4003F4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private string targetObjPath;

		[Token(Token = "0x4003F50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool NoHide;

		[Token(Token = "0x6002EDE")]
		[Address(RVA = "0x402737C", Offset = "0x402337C", VA = "0x402737C", Slot = "4")]
		[AsyncStateMachine(typeof(_003CAwake_003Ed__6))]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002EDF")]
		[Address(RVA = "0x402740C", Offset = "0x402340C", VA = "0x402740C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__7))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002EE0")]
		[Address(RVA = "0x40274A0", Offset = "0x40234A0", VA = "0x40274A0", Slot = "9")]
		[AsyncStateMachine(typeof(_003CUpdateInfo_003Ed__8))]
		public override void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x6002EE1")]
		[Address(RVA = "0x402753C", Offset = "0x402353C", VA = "0x402753C")]
		[AsyncStateMachine(typeof(_003CChooseDailyBlessAnimation_003Ed__9))]
		private void ChooseDailyBlessAnimation(object o)
		{
		}

		[Token(Token = "0x6002EE2")]
		[Address(RVA = "0x40275DC", Offset = "0x40235DC", VA = "0x40275DC")]
		private void RefreshDailyAdCallBack()
		{
		}

		[Token(Token = "0x6002EE3")]
		[Address(RVA = "0x4027640", Offset = "0x4023640", VA = "0x4027640", Slot = "12")]
		protected override void OnButtonExtendBgClicked()
		{
		}

		[Token(Token = "0x6002EE4")]
		[Address(RVA = "0x40276DC", Offset = "0x40236DC", VA = "0x40276DC", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002EE5")]
		[Address(RVA = "0x40277EC", Offset = "0x40237EC", VA = "0x40277EC")]
		public DailyBlessPanel()
		{
		}
	}
}
