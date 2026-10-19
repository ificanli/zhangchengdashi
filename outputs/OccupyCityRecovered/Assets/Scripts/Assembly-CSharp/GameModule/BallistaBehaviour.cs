using System.Runtime.InteropServices;
using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000318")]
	public class BallistaBehaviour : MachineBehaviour
	{
		[Token(Token = "0x6000E06")]
		[Address(RVA = "0x3D68C30", Offset = "0x3D64C30", VA = "0x3D68C30", Slot = "20")]
		public override void Init(GlobalRoleInfo info, bool isEnemy, int cardLevel, RareLevel rareLevel, [Optional] string relativeCardID, CardFettersType fettersType = CardFettersType.Null, AtkWayType atkWayType = AtkWayType.Null)
		{
		}

		[Token(Token = "0x6000E07")]
		[Address(RVA = "0x3D68D0C", Offset = "0x3D64D0C", VA = "0x3D68D0C")]
		public BallistaBehaviour()
		{
		}
	}
}
