using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using ToolModule;
using UIFramework;

namespace GameModule
{
	[Token(Token = "0x200055A")]
	public class MaskManager : ManagerBase<MaskManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200055C")]
		[CompilerGenerated]
		private struct _003CHideMask_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4002F62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002F63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002F64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MaskManager _003C_003E4__this;

			[Token(Token = "0x4002F65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string key;

			[Token(Token = "0x4002F66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UIPanel _003C_maskPanel_003E5__2;

			[Token(Token = "0x4002F67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001B9C")]
			[Address(RVA = "0x3EBE584", Offset = "0x3EBA584", VA = "0x3EBE584", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001B9D")]
			[Address(RVA = "0x3EBEA90", Offset = "0x3EBAA90", VA = "0x3EBEA90", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200055D")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x4002F68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002F69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x6001B9E")]
			[Address(RVA = "0x3EBEA9C", Offset = "0x3EBAA9C", VA = "0x3EBEA9C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001B9F")]
			[Address(RVA = "0x3EBEB50", Offset = "0x3EBAB50", VA = "0x3EBEB50", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200055E")]
		[CompilerGenerated]
		private struct _003CShowMask_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x4002F6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002F6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002F6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MaskManager _003C_003E4__this;

			[Token(Token = "0x4002F6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string key;

			[Token(Token = "0x4002F6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool showLoadingIcon;

			[Token(Token = "0x4002F6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<UIPanel>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001BA0")]
			[Address(RVA = "0x3EBEB5C", Offset = "0x3EBAB5C", VA = "0x3EBEB5C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001BA1")]
			[Address(RVA = "0x3EBF00C", Offset = "0x3EBB00C", VA = "0x3EBF00C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002F5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private UIPanel maskPanel;

		[Token(Token = "0x4002F5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<MaskData> allMaskKey;

		[Token(Token = "0x4002F5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int showLoadingIconCount;

		[Token(Token = "0x6001B94")]
		[Address(RVA = "0x3EBE130", Offset = "0x3EBA130", VA = "0x3EBE130")]
		[AsyncStateMachine(typeof(_003CShowMask_003Ed__3))]
		public void ShowMask(string key = "DefaultMaskKey", bool showLoadingIcon = true)
		{
		}

		[Token(Token = "0x6001B95")]
		[Address(RVA = "0x3EBE1DC", Offset = "0x3EBA1DC", VA = "0x3EBE1DC")]
		public void SetLoadingIconActive()
		{
		}

		[Token(Token = "0x6001B96")]
		[Address(RVA = "0x3EBE324", Offset = "0x3EBA324", VA = "0x3EBE324")]
		[AsyncStateMachine(typeof(_003CHideMask_003Ed__5))]
		public void HideMask(string key = "DefaultMaskKey")
		{
		}

		[Token(Token = "0x6001B97")]
		[Address(RVA = "0x3EBE3C0", Offset = "0x3EBA3C0", VA = "0x3EBE3C0", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__6))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6001B98")]
		[Address(RVA = "0x3EBE440", Offset = "0x3EBA440", VA = "0x3EBE440")]
		public MaskManager()
		{
		}
	}
}
