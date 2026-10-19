using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using ToolModule;
using UIModuleO;

namespace GameModule
{
	[Token(Token = "0x20004ED")]
	public class MetaGameManager : ManagerBase<MetaGameManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004EF")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__11 : IAsyncStateMachine
		{
			[Token(Token = "0x4002CFE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002CFF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002D00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MetaGameManager _003C_003E4__this;

			[Token(Token = "0x4002D01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<UIFramework.UIPanel>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4002D02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x60018F9")]
			[Address(RVA = "0x3E89EC0", Offset = "0x3E85EC0", VA = "0x3E89EC0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60018FA")]
			[Address(RVA = "0x3E8B750", Offset = "0x3E87750", VA = "0x3E8B750", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004F0")]
		[CompilerGenerated]
		private struct _003CShowMetaSwitchPanel_003Ed__14 : IAsyncStateMachine
		{
			[Token(Token = "0x4002D03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002D04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002D05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MetaGameManager _003C_003E4__this;

			[Token(Token = "0x4002D06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int lastPanelIndex;

			[Token(Token = "0x4002D07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x4002D08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__2;

			[Token(Token = "0x60018FB")]
			[Address(RVA = "0x3E8B75C", Offset = "0x3E8775C", VA = "0x3E8B75C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60018FC")]
			[Address(RVA = "0x3E8BBE4", Offset = "0x3E87BE4", VA = "0x3E8BBE4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002CF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool metaSwitchBtnInEnd;

		[Token(Token = "0x4002CF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string _currentMetaId;

		[Token(Token = "0x4002CFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<GlobalMetaModuleInfo> _metaModuleInfos;

		[Token(Token = "0x4002CFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<string, GlobalMetaModuleInfo> _metaModuleInfoDict;

		[Token(Token = "0x4002CFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private MetaSwitchPanel _metaSwitchPanel;

		[Token(Token = "0x17000150")]
		public MetaSwitchPanel MetaSwitchPanel
		{
			[Token(Token = "0x60018E7")]
			[Address(RVA = "0x3E89304", Offset = "0x3E85304", VA = "0x3E89304")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000151")]
		public bool CurrentIdIsMainTower
		{
			[Token(Token = "0x60018E8")]
			[Address(RVA = "0x3E8930C", Offset = "0x3E8530C", VA = "0x3E8930C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000152")]
		public string CurrentId
		{
			[Token(Token = "0x60018E9")]
			[Address(RVA = "0x3E89358", Offset = "0x3E85358", VA = "0x3E89358")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60018EA")]
		[Address(RVA = "0x3E89360", Offset = "0x3E85360", VA = "0x3E89360", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__11))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x60018EB")]
		[Address(RVA = "0x3E893F0", Offset = "0x3E853F0", VA = "0x3E893F0")]
		private void Listen()
		{
		}

		[Token(Token = "0x60018EC")]
		[Address(RVA = "0x3E894B8", Offset = "0x3E854B8", VA = "0x3E894B8")]
		private void MetaSwitchBtnInEnd(object o)
		{
		}

		[Token(Token = "0x60018ED")]
		[Address(RVA = "0x3E894C4", Offset = "0x3E854C4", VA = "0x3E894C4")]
		[AsyncStateMachine(typeof(_003CShowMetaSwitchPanel_003Ed__14))]
		public void ShowMetaSwitchPanel(int lastPanelIndex = 2)
		{
		}

		[Token(Token = "0x60018EE")]
		[Address(RVA = "0x3E89564", Offset = "0x3E85564", VA = "0x3E89564")]
		public void HideMetaSwitchPanel()
		{
		}

		[Token(Token = "0x60018EF")]
		[Address(RVA = "0x3E89584", Offset = "0x3E85584", VA = "0x3E89584")]
		public void SuppressMetaSwitchPanelForOverlay()
		{
		}

		[Token(Token = "0x60018F0")]
		[Address(RVA = "0x3E89628", Offset = "0x3E85628", VA = "0x3E89628")]
		public void RestoreMetaSwitchPanelFromOverlay()
		{
		}

		[Token(Token = "0x60018F1")]
		[Address(RVA = "0x3E89898", Offset = "0x3E85898", VA = "0x3E89898")]
		private void ClickMetaBtn(object o)
		{
		}

		[Token(Token = "0x60018F2")]
		[Address(RVA = "0x3E898A8", Offset = "0x3E858A8", VA = "0x3E898A8")]
		public void ShowMetaPanel(object metaIdObj, bool isClickBtn, bool applyResourceBarVisibility = true, bool useSecondClick = true)
		{
		}

		[Token(Token = "0x60018F3")]
		[Address(RVA = "0x3E89D6C", Offset = "0x3E85D6C", VA = "0x3E89D6C")]
		public void HideCurrentMetaPanel()
		{
		}

		[Token(Token = "0x60018F4")]
		[Address(RVA = "0x3E896C0", Offset = "0x3E856C0", VA = "0x3E896C0")]
		private void ApplyResourceBarVisibilityForCurrentMeta()
		{
		}

		[Token(Token = "0x60018F5")]
		[Address(RVA = "0x3E89DC8", Offset = "0x3E85DC8", VA = "0x3E89DC8")]
		public MetaGameManager()
		{
		}
	}
}
