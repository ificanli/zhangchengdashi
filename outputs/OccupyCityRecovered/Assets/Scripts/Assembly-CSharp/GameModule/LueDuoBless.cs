using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x200025B")]
	public class LueDuoBless : BlessBase
	{
		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x4384030", Offset = "0x4380030", VA = "0x4384030")]
		public LueDuoBless(string blessId, float value) : base(blessId, value)
		{
		}

		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x4384068", Offset = "0x4380068", VA = "0x4384068", Slot = "4")]
		public override void HandleRoleNumber(RolePropertyTemp propertyTemp)
		{
		}
	}
}
