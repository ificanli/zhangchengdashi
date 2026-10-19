using System.Runtime.InteropServices;
using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x200031A")]
	public class CatapultBehaviour : MachineBehaviour
	{
		[Token(Token = "0x6000E0C")]
		[Address(RVA = "0x3D69194", Offset = "0x3D65194", VA = "0x3D69194", Slot = "20")]
		public override void Init(GlobalRoleInfo info, bool isEnemy, int cardLevel, RareLevel rareLevel, [Optional] string relativeCardID, CardFettersType fettersType = CardFettersType.Null, AtkWayType atkWayType = AtkWayType.Null)
		{
		}

		[Token(Token = "0x6000E0D")]
		[Address(RVA = "0x3D691F8", Offset = "0x3D651F8", VA = "0x3D691F8")]
		public CatapultBehaviour()
		{
		}
	}
}
