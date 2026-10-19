using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000261")]
	public class YeShouZhiLiBless : BlessBase
	{
		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x43842A4", Offset = "0x43802A4", VA = "0x43842A4")]
		public YeShouZhiLiBless(string blessId, float value) : base(blessId, value)
		{
		}

		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x43842DC", Offset = "0x43802DC", VA = "0x43842DC", Slot = "4")]
		public override void HandleRoleNumber(RolePropertyTemp propertyTemp)
		{
		}
	}
}
