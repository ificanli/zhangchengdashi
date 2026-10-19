using System.Runtime.InteropServices;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000393")]
	public class VillagerRoleBehaviour : TerranBehaviour
	{
		[Token(Token = "0x4002609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private bool triggerSkill;

		[Token(Token = "0x400260A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D4")]
		private int skillThreshold;

		[Token(Token = "0x6001020")]
		[Address(RVA = "0x3D9D088", Offset = "0x3D99088", VA = "0x3D9D088", Slot = "20")]
		public override void Init(GlobalRoleInfo info, bool isEnemy, int cardLevel, RareLevel rareLevel, [Optional] string relativeCardID, CardFettersType fettersType = CardFettersType.Null, AtkWayType atkWayType = AtkWayType.Null)
		{
		}

		[Token(Token = "0x6001021")]
		[Address(RVA = "0x3D9D0C4", Offset = "0x3D990C4", VA = "0x3D9D0C4", Slot = "4")]
		public override void Wound(int damage, string id, [Optional][DefaultParameterValue(false)] bool isBuild, [Optional] EntityBase target, [Optional][DefaultParameterValue(false)] bool isLandRole, [Optional][DefaultParameterValue((AtkWayType)0)] AtkWayType atkWayType, [Optional][DefaultParameterValue((CardFettersType)4)] CardFettersType fetterType, [Optional] Object linkAttackObj)
		{
		}

		[Token(Token = "0x6001022")]
		[Address(RVA = "0x3D9D320", Offset = "0x3D99320", VA = "0x3D9D320", Slot = "39")]
		protected override void OnRecycle()
		{
		}

		[Token(Token = "0x6001023")]
		[Address(RVA = "0x3D9D33C", Offset = "0x3D9933C", VA = "0x3D9D33C")]
		public VillagerRoleBehaviour()
		{
		}
	}
}
