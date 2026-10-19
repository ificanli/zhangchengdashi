using System.Runtime.InteropServices;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000333")]
	public class GargoyleRoleBehaviour : UndeadBehaviour
	{
		[Token(Token = "0x40023DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private GameObject skillEff;

		[Token(Token = "0x6000E6B")]
		[Address(RVA = "0x3D710EC", Offset = "0x3D6D0EC", VA = "0x3D710EC", Slot = "20")]
		public override void Init(GlobalRoleInfo info, bool isEnemy, int cardLevel, RareLevel rareLevel, [Optional] string relativeCardID, CardFettersType fettersType = CardFettersType.Null, AtkWayType atkWayType = AtkWayType.Null)
		{
		}

		[Token(Token = "0x6000E6C")]
		[Address(RVA = "0x3D71284", Offset = "0x3D6D284", VA = "0x3D71284")]
		public GargoyleRoleBehaviour()
		{
		}
	}
}
