using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DataModule;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000B04")]
	public class SelectBannerItem : SelectBannerItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B06")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__1 : IAsyncStateMachine
		{
			[Token(Token = "0x40050B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40050B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40050B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string id;

			[Token(Token = "0x40050B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public SelectBannerItem _003C_003E4__this;

			[Token(Token = "0x40050B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x40050B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60042C5")]
			[Address(RVA = "0x41D3168", Offset = "0x41CF168", VA = "0x41D3168", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60042C6")]
			[Address(RVA = "0x41D37AC", Offset = "0x41CF7AC", VA = "0x41D37AC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40050B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GlobalBannerInfo config;

		[Token(Token = "0x60042C0")]
		[Address(RVA = "0x41D2F40", Offset = "0x41CEF40", VA = "0x41D2F40")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__1))]
		public void Init(string id)
		{
		}

		[Token(Token = "0x60042C1")]
		[Address(RVA = "0x41D2FE0", Offset = "0x41CEFE0", VA = "0x41D2FE0", Slot = "12")]
		protected override void OnButtonExtendSelectBannerItemClicked()
		{
		}

		[Token(Token = "0x60042C2")]
		[Address(RVA = "0x41D312C", Offset = "0x41CF12C", VA = "0x41D312C")]
		public SelectBannerItem()
		{
		}
	}
}
