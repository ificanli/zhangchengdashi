using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000266")]
	public class DemonLordBulletBehaviour : BulletBehaviour
	{
		[Token(Token = "0x4001F0D")]
		[FieldOffset(Offset = "0x70")]
		private float Speed;

		[Token(Token = "0x4001F0E")]
		[FieldOffset(Offset = "0x74")]
		private float durationTime;

		[Token(Token = "0x4001F0F")]
		[FieldOffset(Offset = "0x78")]
		private HellfireBehaviour hellfireBehaviour;

		[Token(Token = "0x4001F10")]
		[FieldOffset(Offset = "0x80")]
		private bool isDemonLordSkill;

		[Token(Token = "0x4001F11")]
		[FieldOffset(Offset = "0x88")]
		private readonly List<RoleBehaviour> skillTargets;

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x4386248", Offset = "0x4382248", VA = "0x4386248")]
		public void InitSkillInfo(bool isEnemy, float Speed, HellfireBehaviour hellFire, float durationTime)
		{
		}

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x43862B8", Offset = "0x43822B8", VA = "0x43862B8", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x43865F0", Offset = "0x43825F0", VA = "0x43865F0")]
		private void SkillLogic()
		{
		}

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x438694C", Offset = "0x438294C", VA = "0x438694C", Slot = "9")]
		protected override void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x438695C", Offset = "0x438295C", VA = "0x438695C", Slot = "10")]
		protected override void Clear()
		{
		}

		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x43869DC", Offset = "0x43829DC", VA = "0x43869DC")]
		public DemonLordBulletBehaviour()
		{
		}
	}
}
