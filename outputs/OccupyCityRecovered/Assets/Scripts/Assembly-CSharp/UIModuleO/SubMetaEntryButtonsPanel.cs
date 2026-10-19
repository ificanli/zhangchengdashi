using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000B93")]
	public class SubMetaEntryButtonsPanel : SubMetaEntryButtonsPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B94")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__1 : IAsyncStateMachine
		{
			[Token(Token = "0x400543D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400543E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400543F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SubMetaEntryButtonsPanel _003C_003E4__this;

			[Token(Token = "0x4005440")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x4005441")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<GlobalSubMetaModuleInfo> _003CsubMetaModuleInfos_003E5__2;

			[Token(Token = "0x4005442")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<UnityEngine.GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004707")]
			[Address(RVA = "0x421DF9C", Offset = "0x4219F9C", VA = "0x421DF9C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004708")]
			[Address(RVA = "0x421E704", Offset = "0x421A704", VA = "0x421E704", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400543C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<SubMetaEntryBtn> _subMetaEntryBtnList;

		[Token(Token = "0x6004704")]
		[Address(RVA = "0x421DEE8", Offset = "0x4219EE8", VA = "0x421DEE8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__1))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004705")]
		[Address(RVA = "0x421DF84", Offset = "0x4219F84", VA = "0x421DF84")]
		public SubMetaEntryButtonsPanel()
		{
		}
	}
}
