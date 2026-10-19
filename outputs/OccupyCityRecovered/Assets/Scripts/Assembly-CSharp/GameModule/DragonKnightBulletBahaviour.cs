using System.Runtime.InteropServices;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000267")]
	public class DragonKnightBulletBahaviour : BulletBehaviour
	{
		[Token(Token = "0x4001F12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 en;

		[Token(Token = "0x4001F13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private CardTalentTreeData _treeData;

		[Token(Token = "0x4001F14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float critObb;

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x4386A58", Offset = "0x4382A58", VA = "0x4386A58", Slot = "4")]
		public override void InitInfo(EntityBase obj, int atk, bool isEnemy, bool isEffBullet, [Optional] EntityBase fireObj, bool isLand = true, CardFettersType fettersType = CardFettersType.Null)
		{
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x4386C5C", Offset = "0x4382C5C", VA = "0x4386C5C")]
		public void InitTreeData(CardTalentTreeData treeData)
		{
		}

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x4386C64", Offset = "0x4382C64", VA = "0x4386C64")]
		public void InitCrittObb(float critObb)
		{
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x4386C6C", Offset = "0x4382C6C", VA = "0x4386C6C", Slot = "6")]
		protected override void BulletLogic()
		{
		}

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x43872A8", Offset = "0x43832A8", VA = "0x43872A8", Slot = "9")]
		protected override void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x43872AC", Offset = "0x43832AC", VA = "0x43872AC", Slot = "10")]
		protected override void Clear()
		{
		}

		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x43872D0", Offset = "0x43832D0", VA = "0x43872D0")]
		public DragonKnightBulletBahaviour()
		{
		}
	}
}
