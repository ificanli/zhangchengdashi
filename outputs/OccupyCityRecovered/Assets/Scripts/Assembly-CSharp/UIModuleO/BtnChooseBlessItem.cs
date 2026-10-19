using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000759")]
	public class BtnChooseBlessItem : BtnChooseBlessItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200075A")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x40039A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40039A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40039A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BtnChooseBlessItem _003C_003E4__this;

			[Token(Token = "0x40039A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600283D")]
			[Address(RVA = "0x3FAFCFC", Offset = "0x3FABCFC", VA = "0x3FAFCFC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600283E")]
			[Address(RVA = "0x3FAFEDC", Offset = "0x3FABEDC", VA = "0x3FAFEDC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200075B")]
		[CompilerGenerated]
		private struct _003CUpdateUI_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x40039A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40039A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40039A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BtnChooseBlessItem _003C_003E4__this;

			[Token(Token = "0x40039AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x40039AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600283F")]
			[Address(RVA = "0x3FAFEE8", Offset = "0x3FABEE8", VA = "0x3FAFEE8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002840")]
			[Address(RVA = "0x3FB08D0", Offset = "0x3FAC8D0", VA = "0x3FB08D0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40039A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GlobalBlessInfo info;

		[Token(Token = "0x40039A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int index;

		[Token(Token = "0x6002837")]
		[Address(RVA = "0x3FAF898", Offset = "0x3FAB898", VA = "0x3FAF898", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__2))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002838")]
		[Address(RVA = "0x3FAF92C", Offset = "0x3FAB92C", VA = "0x3FAF92C")]
		public void Init(GlobalBlessInfo info, int index)
		{
		}

		[Token(Token = "0x6002839")]
		[Address(RVA = "0x3FAF938", Offset = "0x3FAB938", VA = "0x3FAF938")]
		[AsyncStateMachine(typeof(_003CUpdateUI_003Ed__4))]
		private void UpdateUI()
		{
		}

		[Token(Token = "0x600283A")]
		[Address(RVA = "0x3FAF9C8", Offset = "0x3FAB9C8", VA = "0x3FAF9C8", Slot = "12")]
		protected override void OnButtonExtendBtnChooseBlessItemClicked()
		{
		}

		[Token(Token = "0x600283B")]
		[Address(RVA = "0x3FAFC54", Offset = "0x3FABC54", VA = "0x3FAFC54")]
		public BtnChooseBlessItem()
		{
		}
	}
}
