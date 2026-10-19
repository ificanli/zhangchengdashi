using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using ToolModule;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UIFramework
{
	[Token(Token = "0x2000C53")]
	public class UIManager : ManagerBase<UIManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C56")]
		[CompilerGenerated]
		private struct _003CGetPanel_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x4005861")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005862")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<UIPanel> _003C_003Et__builder;

			[Token(Token = "0x4005863")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UIManager _003C_003E4__this;

			[Token(Token = "0x4005864")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string panelPath;

			[Token(Token = "0x4005865")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<UIPanel> _003C_003Eu__1;

			[Token(Token = "0x6004C67")]
			[Address(RVA = "0x42767AC", Offset = "0x42727AC", VA = "0x42767AC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004C68")]
			[Address(RVA = "0x4276B00", Offset = "0x4272B00", VA = "0x4276B00", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C57")]
		[CompilerGenerated]
		private struct _003CHidePanel_003Ed__13 : IAsyncStateMachine
		{
			[Token(Token = "0x4005866")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005867")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005868")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIManager _003C_003E4__this;

			[Token(Token = "0x4005869")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string panelName;

			[Token(Token = "0x400586A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<UIPanel>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004C69")]
			[Address(RVA = "0x4276B58", Offset = "0x4272B58", VA = "0x4276B58", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004C6A")]
			[Address(RVA = "0x4276F0C", Offset = "0x4272F0C", VA = "0x4276F0C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C58")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x400586B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400586C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400586D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIManager _003C_003E4__this;

			[Token(Token = "0x6004C6B")]
			[Address(RVA = "0x4276F18", Offset = "0x4272F18", VA = "0x4276F18", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004C6C")]
			[Address(RVA = "0x42771A4", Offset = "0x42731A4", VA = "0x42771A4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C59")]
		[CompilerGenerated]
		private struct _003CLoadPanel_003Ed__11 : IAsyncStateMachine
		{
			[Token(Token = "0x400586E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400586F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<UIPanel> _003C_003Et__builder;

			[Token(Token = "0x4005870")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string panelPath;

			[Token(Token = "0x4005871")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UIManager _003C_003E4__this;

			[Token(Token = "0x4005872")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004C6D")]
			[Address(RVA = "0x42771B0", Offset = "0x42731B0", VA = "0x42771B0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004C6E")]
			[Address(RVA = "0x42779AC", Offset = "0x42739AC", VA = "0x42779AC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C5A")]
		[CompilerGenerated]
		private struct _003CShowPanel_003Ed__12 : IAsyncStateMachine
		{
			[Token(Token = "0x4005873")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005874")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005875")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string panelPath;

			[Token(Token = "0x4005876")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UIManager _003C_003E4__this;

			[Token(Token = "0x4005877")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public object[] objects;

			[Token(Token = "0x4005878")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<UIPanel>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4005879")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6004C6F")]
			[Address(RVA = "0x4277A28", Offset = "0x4273A28", VA = "0x4277A28", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004C70")]
			[Address(RVA = "0x427817C", Offset = "0x427417C", VA = "0x427817C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400585B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform _panelsParent;

		[Token(Token = "0x400585C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<string, UIPanel> _uiPanelsDict;

		[Token(Token = "0x400585D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private EventSystem _eventSystem;

		[Token(Token = "0x400585E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool initcomplete;

		[Token(Token = "0x17000D8E")]
		public EventSystem SceneEventSystem
		{
			[Token(Token = "0x6004C56")]
			[Address(RVA = "0x4275B7C", Offset = "0x4271B7C", VA = "0x4275B7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004C57")]
		[Address(RVA = "0x4275C18", Offset = "0x4271C18", VA = "0x4275C18", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__6))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6004C58")]
		[Address(RVA = "0x4275C9C", Offset = "0x4271C9C", VA = "0x4275C9C")]
		[AsyncStateMachine(typeof(_003CGetPanel_003Ed__7))]
		public UniTask<UIPanel> GetPanel(string panelPath)
		{
			return default;
		}

		[Token(Token = "0x6004C59")]
		[Address(RVA = "0x4275D78", Offset = "0x4271D78", VA = "0x4275D78")]
		public bool IsPanelShowing(string panelPath, out UIPanel showingPanel)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED UIManager.IsPanelShowing RVA=0x4275D78 Token=0x6004C59");
}

		[Token(Token = "0x6004C5A")]
		[Address(RVA = "0x4275E1C", Offset = "0x4271E1C", VA = "0x4275E1C")]
		public bool IsHavePanel(string path)
		{
			return default;
		}

		[Token(Token = "0x6004C5B")]
		[Address(RVA = "0x4275E74", Offset = "0x4271E74", VA = "0x4275E74")]
		public void AddPanel(string panelPath, UIPanel uiPanel)
		{
		}

		[Token(Token = "0x6004C5C")]
		[Address(RVA = "0x4275FEC", Offset = "0x4271FEC", VA = "0x4275FEC")]
		[AsyncStateMachine(typeof(_003CLoadPanel_003Ed__11))]
		private Task<UIPanel> LoadPanel(string panelPath)
		{
			return null;
		}

		[Token(Token = "0x6004C5D")]
		[Address(RVA = "0x42760D8", Offset = "0x42720D8", VA = "0x42760D8")]
		[AsyncStateMachine(typeof(_003CShowPanel_003Ed__12))]
		public UniTask ShowPanel(string panelPath, params object[] objects)
		{
			return default;
		}

		[Token(Token = "0x6004C5E")]
		[Address(RVA = "0x4276180", Offset = "0x4272180", VA = "0x4276180")]
		[AsyncStateMachine(typeof(_003CHidePanel_003Ed__13))]
		public UniTask HidePanel(string panelName)
		{
			return default;
		}

		[Token(Token = "0x6004C5F")]
		[Address(RVA = "0x4276218", Offset = "0x4272218", VA = "0x4276218")]
		public void UnloadPanel(string panelName)
		{
		}

		[Token(Token = "0x6004C60")]
		[Address(RVA = "0x4276314", Offset = "0x4272314", VA = "0x4276314")]
		public void InitToCanvas(GameObject go, int sortLayer = 1)
		{
		}

		[Token(Token = "0x6004C61")]
		[Address(RVA = "0x4276644", Offset = "0x4272644", VA = "0x4276644")]
		public RectTransform FindRectTrans(string path)
		{
			return null;
		}

		[Token(Token = "0x6004C62")]
		[Address(RVA = "0x42766FC", Offset = "0x42726FC", VA = "0x42766FC")]
		public UIManager()
		{
		}
	}
}
