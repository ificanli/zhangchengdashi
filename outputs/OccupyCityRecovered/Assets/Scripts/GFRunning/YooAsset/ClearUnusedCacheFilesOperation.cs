using System.Collections.Generic;
using Il2CppDummyDll;

namespace YooAsset
{
	[Token(Token = "0x20000A2")]
	public sealed class ClearUnusedCacheFilesOperation : AsyncOperationBase
	{
		[Token(Token = "0x20000A3")]
		private enum J_00BE_008B_00B0Â_0085
		{
			[Token(Token = "0x4000214")]
			None = 0,
			[Token(Token = "0x4000215")]
			GetUnusedCacheFiles = 1,
			[Token(Token = "0x4000216")]
			ClearUnusedCacheFiles = 2,
			[Token(Token = "0x4000217")]
			Done = 3
		}

		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x40")]
		private readonly ResourcePackage _00B1N_005D_009EV_009F;

		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x48")]
		private List<string> _0087_0084_0093I_008F_008E;

		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x50")]
		private int _0094_0096P_005B_00A5M;

		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0x54")]
		private J_00BE_008B_00B0Â_0085 _008F_009DWK_0080_008A;

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x72C8438", Offset = "0x72C4438", VA = "0x72C8438")]
		internal ClearUnusedCacheFilesOperation(ResourcePackage TC_0083sn_0082)
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x72C8460", Offset = "0x72C4460", VA = "0x72C8460", Slot = "8")]
		internal override void _007EZ_00A7_008E_0095U()
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x72C8628", Offset = "0x72C4628", VA = "0x72C8628", Slot = "7")]
		internal override void GL_008Ccx_00A1()
		{
		}
	}
}
