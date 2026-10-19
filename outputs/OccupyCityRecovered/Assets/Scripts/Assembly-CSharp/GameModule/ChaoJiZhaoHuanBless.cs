using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000259")]
	public class ChaoJiZhaoHuanBless : BlessBase
	{
		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x4383F88", Offset = "0x437FF88", VA = "0x4383F88")]
		public ChaoJiZhaoHuanBless(string blessId, float value) : base(blessId, value)
		{
		}

		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x4383FC0", Offset = "0x437FFC0", VA = "0x4383FC0", Slot = "4")]
		public override void HandleRoleNumber(RolePropertyTemp propertyTemp)
		{
		}
	}
}
