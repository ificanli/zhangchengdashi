using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x200025D")]
	public class ShangHaiJianMianBless : BlessBase
	{
		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x43840F4", Offset = "0x43800F4", VA = "0x43840F4")]
		public ShangHaiJianMianBless(string blessId, float value) : base(blessId, value)
		{
		}

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x438412C", Offset = "0x438012C", VA = "0x438412C", Slot = "4")]
		public override void HandleRoleNumber(RolePropertyTemp propertyTemp)
		{
		}
	}
}
