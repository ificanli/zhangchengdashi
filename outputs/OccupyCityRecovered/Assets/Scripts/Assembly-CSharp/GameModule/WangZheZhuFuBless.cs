using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x200025E")]
	public class WangZheZhuFuBless : BlessBase
	{
		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x4384158", Offset = "0x4380158", VA = "0x4384158")]
		public WangZheZhuFuBless(string blessId, float value) : base(blessId, value)
		{
		}

		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x4384190", Offset = "0x4380190", VA = "0x4384190", Slot = "4")]
		public override void HandleRoleNumber(RolePropertyTemp propertyTemp)
		{
		}
	}
}
