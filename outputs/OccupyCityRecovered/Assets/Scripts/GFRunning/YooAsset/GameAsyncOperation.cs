using Il2CppDummyDll;

namespace YooAsset
{
	[Token(Token = "0x20000DA")]
	public abstract class GameAsyncOperation : AsyncOperationBase
	{
		[Token(Token = "0x6000BB7")]
		[Address(RVA = "0x731CE28", Offset = "0x7318E28", VA = "0x731CE28", Slot = "7")]
		internal override void GL_008Ccx_00A1()
		{
		}

		[Token(Token = "0x6000BB8")]
		[Address(RVA = "0x731CE34", Offset = "0x7318E34", VA = "0x731CE34", Slot = "8")]
		internal override void _007EZ_00A7_008E_0095U()
		{
		}

		[Token(Token = "0x6000BB9")]
		protected abstract void OnStart();

		[Token(Token = "0x6000BBA")]
		protected abstract void OnUpdate();

		[Token(Token = "0x6000BBB")]
		[Address(RVA = "0x731CE40", Offset = "0x7318E40", VA = "0x731CE40")]
		protected bool IsBusy()
		{
			return default;
		}

		[Token(Token = "0x6000BBC")]
		[Address(RVA = "0x731CF54", Offset = "0x7318F54", VA = "0x731CF54")]
		protected GameAsyncOperation()
		{
		}
	}
}
