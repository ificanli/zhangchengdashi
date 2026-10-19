using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000D6")]
public class Test : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct _003CSS_003Ed__4 : IAsyncStateMachine
	{
		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FloatingTextFontConfig _003CfloatingTextFontConfig_003E5__2;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private FloatingTextConfig _003CfloatingTextConfig_003E5__3;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UniTask<FloatingTextFontConfig>.Awaiter _003C_003Eu__1;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private UniTask<FloatingTextConfig>.Awaiter _003C_003Eu__2;

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x3E44318", Offset = "0x3E40318", VA = "0x3E44318", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x3E44A24", Offset = "0x3E40A24", VA = "0x3E44A24", Slot = "5")]
		[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x40004D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<GPUInstanceAnimationBehaviour> gpuInstanceAnimationBehaviour;

	[Token(Token = "0x40004D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string json;

	[Token(Token = "0x60004A7")]
	[Address(RVA = "0x3E44148", Offset = "0x3E40148", VA = "0x3E44148")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004A8")]
	[Address(RVA = "0x3E4420C", Offset = "0x3E4020C", VA = "0x3E4420C")]
	private void Update()
	{
	}

	[Token(Token = "0x60004A9")]
	[Address(RVA = "0x3E44210", Offset = "0x3E40210", VA = "0x3E44210")]
	[AsyncStateMachine(typeof(_003CSS_003Ed__4))]
	private void SS()
	{
	}

	[Token(Token = "0x60004AA")]
	[Address(RVA = "0x3E4429C", Offset = "0x3E4029C", VA = "0x3E4429C")]
	public Test()
	{
	}
}
