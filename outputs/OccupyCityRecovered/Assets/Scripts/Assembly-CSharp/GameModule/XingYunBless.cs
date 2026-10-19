using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000260")]
	public class XingYunBless : BlessBase
	{
		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x4384268", Offset = "0x4380268", VA = "0x4384268")]
		public XingYunBless(string blessId, float value) : base(blessId, value)
		{
		}

		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x43842A0", Offset = "0x43802A0", VA = "0x43842A0", Slot = "4")]
		public override void HandleRoleNumber(RolePropertyTemp propertyTemp)
		{
		}
	}
}
