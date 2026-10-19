using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000258")]
	public class CaiJiTiXiaoBless : BlessBase
	{
		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x4383F4C", Offset = "0x437FF4C", VA = "0x4383F4C")]
		public CaiJiTiXiaoBless(string blessId, float value) : base(blessId, value)
		{
		}

		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x4383F84", Offset = "0x437FF84", VA = "0x4383F84", Slot = "4")]
		public override void HandleRoleNumber(RolePropertyTemp propertyTemp)
		{
		}
	}
}
