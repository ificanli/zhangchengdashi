using System.Runtime.InteropServices;
using DataModule;
using Il2CppDummyDll;
using UnityEngine.Events;

namespace GameModule
{
	[Token(Token = "0x2000255")]
	public class ResourcesArchitectureBehaviour : ArchitectureBehaviour
	{
		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x4383B10", Offset = "0x437FB10", VA = "0x4383B10", Slot = "8")]
		public override void Init(HexBehaviour hex, GlobalArchitectureInfo info, bool isEnemy, int cardLevel, RareLevel rareLevel, [Optional] UnityAction callBack, CardFettersType fettersType = CardFettersType.Null, AtkWayType atkWayType = AtkWayType.Null)
		{
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x4383C4C", Offset = "0x437FC4C", VA = "0x4383C4C", Slot = "13")]
		protected override void PerformLogic()
		{
		}

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x4383CA0", Offset = "0x437FCA0", VA = "0x4383CA0")]
		private void CreatResources()
		{
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x4383EE4", Offset = "0x437FEE4", VA = "0x4383EE4")]
		public ResourcesArchitectureBehaviour()
		{
		}
	}
}
