using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DataModule;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000920")]
	public class ImgIAPArtifactCardItem : ImgIAPArtifactCardItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000921")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x4004482")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004483")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004484")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ImgIAPArtifactCardItem _003C_003E4__this;

			[Token(Token = "0x4004485")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string rewardCofig;

			[Token(Token = "0x60034C9")]
			[Address(RVA = "0x40ACAFC", Offset = "0x40A8AFC", VA = "0x40ACAFC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60034CA")]
			[Address(RVA = "0x40ACCCC", Offset = "0x40A8CCC", VA = "0x40ACCCC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000922")]
		[CompilerGenerated]
		private struct _003CUpdateUI_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x4004486")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004487")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004488")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ImgIAPArtifactCardItem _003C_003E4__this;

			[Token(Token = "0x4004489")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UserPropData _003Cdata_003E5__2;

			[Token(Token = "0x400448A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60034CB")]
			[Address(RVA = "0x40ACCD8", Offset = "0x40A8CD8", VA = "0x40ACCD8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60034CC")]
			[Address(RVA = "0x40ADA04", Offset = "0x40A9A04", VA = "0x40ADA04", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400447E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private string cardId;

		[Token(Token = "0x400447F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int cardNum;

		[Token(Token = "0x4004480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private string rewardNum;

		[Token(Token = "0x4004481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool isDecreaseOne;

		[Token(Token = "0x60034C3")]
		[Address(RVA = "0x40AC994", Offset = "0x40A8994", VA = "0x40AC994")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__3))]
		public void Init(string rewardCofig)
		{
		}

		[Token(Token = "0x60034C4")]
		[Address(RVA = "0x40ACA30", Offset = "0x40A8A30", VA = "0x40ACA30")]
		private void LoseCard(object o)
		{
		}

		[Token(Token = "0x60034C5")]
		[Address(RVA = "0x40ACAC4", Offset = "0x40A8AC4", VA = "0x40ACAC4")]
		private void GetCard(object o)
		{
		}

		[Token(Token = "0x60034C6")]
		[Address(RVA = "0x40ACA34", Offset = "0x40A8A34", VA = "0x40ACA34")]
		[AsyncStateMachine(typeof(_003CUpdateUI_003Ed__7))]
		public void UpdateUI()
		{
		}

		[Token(Token = "0x60034C7")]
		[Address(RVA = "0x40ACAC8", Offset = "0x40A8AC8", VA = "0x40ACAC8")]
		public ImgIAPArtifactCardItem()
		{
		}
	}
}
