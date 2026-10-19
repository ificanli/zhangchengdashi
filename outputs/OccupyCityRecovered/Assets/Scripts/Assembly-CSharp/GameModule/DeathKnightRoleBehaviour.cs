using System.Collections.Generic;
using System.Runtime.InteropServices;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000322")]
	public class DeathKnightRoleBehaviour : UndeadBehaviour
	{
		[Token(Token = "0x400238B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D4")]
		private float SkillCdTime;

		[Token(Token = "0x400238C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private float jtime;

		[Token(Token = "0x400238D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private List<RoleBehaviour> skillEnemyRole;

		[Token(Token = "0x400238E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private List<RoleBehaviour> skillTeamRole;

		[Token(Token = "0x400238F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private GameObject effObj;

		[Token(Token = "0x4002390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private GameObject effObjCircle;

		[Token(Token = "0x6000E32")]
		[Address(RVA = "0x3D6C584", Offset = "0x3D68584", VA = "0x3D6C584", Slot = "20")]
		public override void Init(GlobalRoleInfo info, bool isEnemy, int cardLevel, RareLevel rareLevel, [Optional] string relativeCardID, CardFettersType fettersType = CardFettersType.Null, AtkWayType atkWayType = AtkWayType.Null)
		{
		}

		[Token(Token = "0x6000E33")]
		[Address(RVA = "0x3D6C8B0", Offset = "0x3D688B0", VA = "0x3D6C8B0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000E34")]
		[Address(RVA = "0x3D6C9F4", Offset = "0x3D689F4", VA = "0x3D6C9F4", Slot = "38")]
		protected override void OnUpdateSkill()
		{
		}

		[Token(Token = "0x6000E35")]
		[Address(RVA = "0x3D6CA4C", Offset = "0x3D68A4C", VA = "0x3D6CA4C")]
		private void DeathKnightSkill()
		{
		}

		[Token(Token = "0x6000E36")]
		[Address(RVA = "0x3D6CDB8", Offset = "0x3D68DB8", VA = "0x3D6CDB8")]
		public DeathKnightRoleBehaviour()
		{
		}
	}
}
