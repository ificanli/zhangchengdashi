using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x200025A")]
	public class JiXieTuiJinBless : BlessBase
	{
		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x4383FC4", Offset = "0x437FFC4", VA = "0x4383FC4")]
		public JiXieTuiJinBless(string blessId, float value) : base(blessId, value)
		{
		}

		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x4383FFC", Offset = "0x437FFFC", VA = "0x4383FFC", Slot = "4")]
		public override void HandleRoleNumber(RolePropertyTemp propertyTemp)
		{
		}
	}
}
