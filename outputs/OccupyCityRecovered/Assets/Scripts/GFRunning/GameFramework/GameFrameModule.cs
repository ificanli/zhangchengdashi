using System;
using Il2CppDummyDll;

namespace GameFramework
{
	[Token(Token = "0x2000331")]
	public abstract class GameFrameModule
	{
		[Token(Token = "0x4001990")]
		[FieldOffset(Offset = "0x10")]
		internal bool x_0080_008D_00B1f_0086;

		[Token(Token = "0x4001991")]
		[FieldOffset(Offset = "0x18")]
		internal Action Àª_00A6_00A3_00BDE;

		[Token(Token = "0x170010C2")]
		internal virtual int Priority
		{
			[Token(Token = "0x60055E6")]
			[Address(RVA = "0x715BEF0", Offset = "0x7157EF0", VA = "0x715BEF0", Slot = "4")]
			get
		{
			return default;
		}
		}

		[Token(Token = "0x60055E7")]
		internal abstract void Initialize(params object[] FuV_00B8_00B2D);

		[Token(Token = "0x60055E8")]
		internal abstract void Start();

		[Token(Token = "0x60055E9")]
		internal abstract void Update(float _008EJ_0092_009BUc, float rfjÀ_0098L);

		[Token(Token = "0x60055EA")]
		[Address(RVA = "0x715BEF8", Offset = "0x7157EF8", VA = "0x715BEF8", Slot = "8")]
		internal virtual void U_0095_008Bd_008A_00AC()
		{
		}

		[Token(Token = "0x60055EB")]
		internal abstract void Shutdown();

		[Token(Token = "0x60055EC")]
		[Address(RVA = "0x715BEFC", Offset = "0x7157EFC", VA = "0x715BEFC")]
		protected GameFrameModule()
		{
		}
	}
}
