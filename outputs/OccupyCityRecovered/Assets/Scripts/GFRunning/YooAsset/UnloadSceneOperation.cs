using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace YooAsset
{
	[Token(Token = "0x200008B")]
	public sealed class UnloadSceneOperation : AsyncOperationBase
	{
		[Token(Token = "0x200008C")]
		private enum _008FLg_008E_00B8u
		{
			[Token(Token = "0x40001C3")]
			Normal = 0,
			[Token(Token = "0x40001C4")]
			Error = 1
		}

		[Token(Token = "0x200008D")]
		private enum º_00B7Gh_009D_009A
		{
			[Token(Token = "0x40001C6")]
			None = 0,
			[Token(Token = "0x40001C7")]
			UnLoad = 1,
			[Token(Token = "0x40001C8")]
			Checking = 2,
			[Token(Token = "0x40001C9")]
			Done = 3
		}

		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x40")]
		private readonly _008FLg_008E_00B8u _00A9v_00BD_0099p_0096;

		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x44")]
		private º_00B7Gh_009D_009A _008F_009DWK_0080_008A;

		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x48")]
		private Scene A_0091_00BB_00B9Â_0099;

		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x50")]
		private AsyncOperation j_007Fs_00B9_0060b;

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x718F3A0", Offset = "0x718B3A0", VA = "0x718F3A0")]
		internal UnloadSceneOperation(string Á_009B_0082E_00AC_009B)
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x719C834", Offset = "0x7198834", VA = "0x719C834", Slot = "8")]
		internal override void _007EZ_00A7_008E_0095U()
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x718F4CC", Offset = "0x718B4CC", VA = "0x718F4CC")]
		internal UnloadSceneOperation(Scene _00AE_0093_00B0_0098_00A1_009F)
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x719C940", Offset = "0x7198940", VA = "0x719C940", Slot = "7")]
		internal override void GL_008Ccx_00A1()
		{
		}
	}
}
