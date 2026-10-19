using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using I2.Loc;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace LocalizationModule
{
	[Token(Token = "0x20001C3")]
	public class LanguageDropdownExtend : TMP_Dropdown
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001C4")]
		[CompilerGenerated]
		private struct _003CHandleValueChanged_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x4001B42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001B43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001B44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int index;

			[Token(Token = "0x4001B45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public LanguageDropdownExtend _003C_003E4__this;

			[Token(Token = "0x4001B46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<TMP_FontAsset>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000741")]
			[Address(RVA = "0x407F668", Offset = "0x407B668", VA = "0x407F668", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000742")]
			[Address(RVA = "0x407FAE0", Offset = "0x407BAE0", VA = "0x407FAE0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001C5")]
		[CompilerGenerated]
		private struct _003CSetFont_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x4001B47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001B48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001B49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DropdownItem dropdownItem;

			[Token(Token = "0x4001B4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public TermData termData;

			[Token(Token = "0x4001B4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public LanguageDropdownExtend _003C_003E4__this;

			[Token(Token = "0x4001B4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TMP_Text _003C_003E7__wrap1;

			[Token(Token = "0x4001B4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<TMP_FontAsset>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000743")]
			[Address(RVA = "0x407FAEC", Offset = "0x407BAEC", VA = "0x407FAEC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000744")]
			[Address(RVA = "0x407FE34", Offset = "0x407BE34", VA = "0x407FE34", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001B40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private int _newItemIndex;

		[Token(Token = "0x4001B41")]
		private const string TermName = "01Font";

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x407F2F8", Offset = "0x407B2F8", VA = "0x407F2F8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x407F418", Offset = "0x407B418", VA = "0x407F418")]
		[AsyncStateMachine(typeof(_003CHandleValueChanged_003Ed__3))]
		private void HandleValueChanged(int index)
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x407F4B8", Offset = "0x407B4B8", VA = "0x407F4B8", Slot = "47")]
		protected override GameObject CreateDropdownList(GameObject template)
		{
			return null;
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x407F4C4", Offset = "0x407B4C4", VA = "0x407F4C4", Slot = "49")]
		protected override DropdownItem CreateItem(DropdownItem itemTemplate)
		{
			return null;
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x407F56C", Offset = "0x407B56C", VA = "0x407F56C")]
		[AsyncStateMachine(typeof(_003CSetFont_003Ed__6))]
		private void SetFont(DropdownItem dropdownItem, TermData termData)
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x407F610", Offset = "0x407B610", VA = "0x407F610")]
		public LanguageDropdownExtend()
		{
		}
	}
}
