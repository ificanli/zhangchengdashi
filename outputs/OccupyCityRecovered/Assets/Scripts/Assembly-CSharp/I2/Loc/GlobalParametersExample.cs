using Il2CppDummyDll;

namespace I2.Loc
{
	[Token(Token = "0x2000D61")]
	public class GlobalParametersExample : RegisterGlobalParameters
	{
		[Token(Token = "0x60052BA")]
		[Address(RVA = "0x4304708", Offset = "0x4300708", VA = "0x4304708", Slot = "7")]
		public override string GetParameterValue(string ParamName)
		{
			return null;
		}

		[Token(Token = "0x60052BB")]
		[Address(RVA = "0x43047C4", Offset = "0x43007C4", VA = "0x43047C4")]
		public GlobalParametersExample()
		{
		}
	}
}
