using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using YooAsset;

[Token(Token = "0x2000320")]
internal static class pQ_00A2qµR
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000321")]
	private struct oS_00BF_00A5R_008D : IAsyncStateMachine
	{
		[Token(Token = "0x4001947")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4001948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<AudioClip> _003C_003Et__builder;

		[Token(Token = "0x4001949")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string resPath;

		[Token(Token = "0x400194A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter<AssetOperationHandle> _003C_003Eu__1;

		[Token(Token = "0x400194B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter<AudioClip> _003C_003Eu__2;

		[Token(Token = "0x60054C6")]
		[Address(RVA = "0x714FAB4", Offset = "0x714BAB4", VA = "0x714FAB4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
		{
		}

		[Token(Token = "0x60054C7")]
		[Address(RVA = "0x71502C4", Offset = "0x714C2C4", VA = "0x71502C4", Slot = "5")]
		[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000322")]
	private struct _00B0_0096_00B1µ_00A1y : IAsyncStateMachine
	{
		[Token(Token = "0x400194C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x400194D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<AssetOperationHandle> _003C_003Et__builder;

		[Token(Token = "0x400194E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string resPath;

		[Token(Token = "0x400194F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter<AssetOperationHandle> _003C_003Eu__1;

		[Token(Token = "0x60054C8")]
		[Address(RVA = "0x7150340", Offset = "0x714C340", VA = "0x7150340", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
		{
		}

		[Token(Token = "0x60054C9")]
		[Address(RVA = "0x7150608", Offset = "0x714C608", VA = "0x7150608", Slot = "5")]
		[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x60054C0")]
	[Address(RVA = "0x714F614", Offset = "0x714B614", VA = "0x714F614")]
	public static int RandomId(int _0095_00ABpn_00B6m, int _00BE_0093_00AFl_009Bi, List<int> _00B3p_00B8_008F_00B8v)
	{
		return default;
	}

	[Token(Token = "0x60054C1")]
	[Address(RVA = "0x714F684", Offset = "0x714B684", VA = "0x714F684")]
	public static AudioSource CreateAudioSource(GameObject _00B7_00A8z_00A2X_00BE, string _00AE_008C_009AiPJ)
	{
		return null;
	}

	[Token(Token = "0x60054C2")]
	[Address(RVA = "0x714F75C", Offset = "0x714B75C", VA = "0x714F75C")]
	public static void DestroyAudioSource(AudioSource B_00AD_007E_00BD_00BF_0085)
	{
	}

	[Token(Token = "0x60054C3")]
	[Address(RVA = "0x714F7E4", Offset = "0x714B7E4", VA = "0x714F7E4")]
	[AsyncStateMachine(typeof(oS_00BF_00A5R_008D))]
	public static Task<AudioClip> LoadAudioClip(string p_00AEX_008E_009A_009F)
	{
		return null;
	}

	[Token(Token = "0x60054C4")]
	[Address(RVA = "0x714F8CC", Offset = "0x714B8CC", VA = "0x714F8CC")]
	[AsyncStateMachine(typeof(_00B0_0096_00B1µ_00A1y))]
	public static Task<AssetOperationHandle> LoadAudioClipForNewRes(string p_00AEX_008E_009A_009F)
	{
		return null;
	}

	[Token(Token = "0x60054C5")]
	[Address(RVA = "0x714F9B0", Offset = "0x714B9B0", VA = "0x714F9B0")]
	public static void UnLoadAudioClip(string p_00AEX_008E_009A_009F)
	{
	}
}
