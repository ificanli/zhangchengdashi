using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DataModule;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000B90")]
	public class SubMetaEntryBtn : SubMetaEntryBtnComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B91")]
		[CompilerGenerated]
		private struct _003CUpdateInfo_003Ed__1 : IAsyncStateMachine
		{
			[Token(Token = "0x4005433")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005434")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005435")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SubMetaEntryBtn _003C_003E4__this;

			[Token(Token = "0x4005436")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GlobalSubMetaModuleInfo info;

			[Token(Token = "0x4005437")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4005438")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60046FE")]
			[Address(RVA = "0x421D8DC", Offset = "0x42198DC", VA = "0x421D8DC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60046FF")]
			[Address(RVA = "0x421DE40", Offset = "0x4219E40", VA = "0x421DE40", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string _clickEvent;

		[Token(Token = "0x60046FA")]
		[Address(RVA = "0x421D740", Offset = "0x4219740", VA = "0x421D740")]
		[AsyncStateMachine(typeof(_003CUpdateInfo_003Ed__1))]
		public void UpdateInfo(GlobalSubMetaModuleInfo info)
		{
		}

		[Token(Token = "0x60046FB")]
		[Address(RVA = "0x421D7E0", Offset = "0x42197E0", VA = "0x421D7E0")]
		private void OnSubMetaEntryBtnBtnClick()
		{
		}

		[Token(Token = "0x60046FC")]
		[Address(RVA = "0x421D83C", Offset = "0x421983C", VA = "0x421D83C", Slot = "11")]
		protected override void BindButtonEvent()
		{
		}

		[Token(Token = "0x60046FD")]
		[Address(RVA = "0x421D8CC", Offset = "0x42198CC", VA = "0x421D8CC")]
		public SubMetaEntryBtn()
		{
		}
	}
}
