using System.Collections.Generic;
using Il2CppDummyDll;

namespace YooAsset
{
	[Token(Token = "0x20000A0")]
	public sealed class ClearAllCacheFilesOperation : AsyncOperationBase
	{
		[Token(Token = "0x20000A1")]
		private enum _00B1na_0090_009Ax
		{
			[Token(Token = "0x400020B")]
			None = 0,
			[Token(Token = "0x400020C")]
			GetAllCacheFiles = 1,
			[Token(Token = "0x400020D")]
			ClearAllCacheFiles = 2,
			[Token(Token = "0x400020E")]
			Done = 3
		}

		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x40")]
		private readonly ResourcePackage _00B1N_005D_009EV_009F;

		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x48")]
		private List<string> b_005B_0084_0099ÂS;

		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x50")]
		private int zj_0083_005D_007C_0092;

		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x54")]
		private _00B1na_0090_009Ax _008F_009DWK_0080_008A;

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x72C823C", Offset = "0x72C423C", VA = "0x72C823C")]
		internal ClearAllCacheFilesOperation(ResourcePackage TC_0083sn_0082)
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x72C8264", Offset = "0x72C4264", VA = "0x72C8264", Slot = "7")]
		internal override void GL_008Ccx_00A1()
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x72C8270", Offset = "0x72C4270", VA = "0x72C8270", Slot = "8")]
		internal override void _007EZ_00A7_008E_0095U()
		{
		}
	}
}
